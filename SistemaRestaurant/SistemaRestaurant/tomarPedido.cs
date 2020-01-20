using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //BASE DE DATOS

namespace SistemaRestaurant
{
    public partial class tomarPedido : MaterialSkin.Controls.MaterialForm
    {
        public tomarPedido()
        {
            InitializeComponent();
            BD.cnn.Open();
            RefreshTables();
        }

        public void RefreshTables()
        {
            ViewComida.Rows.Clear();
            ViewBebida.Rows.Clear();
            string sql = "select id, nombre,precio from comida";
            SqlCommand command;
            SqlDataReader dataReader;
            command = new SqlCommand(sql, BD.cnn);
            dataReader = command.ExecuteReader();





            while (dataReader.Read())
            {
                //DataRow nuevo;
                //ViewComida.NewRow();
                ViewComida.Rows.Add(dataReader.GetValue(0), dataReader.GetValue(1), dataReader.GetValue(2));
            }
            dataReader.Close();




            SqlDataReader dataReader1;
            sql = "select id,nombre,precio from bebida";

            command = new SqlCommand(sql, BD.cnn);
            dataReader1 = command.ExecuteReader();


            while (dataReader1.Read())
            {
                ViewBebida.Rows.Add(dataReader1.GetValue(0), dataReader1.GetValue(1), dataReader1.GetValue(2));

            }
            dataReader1.Close();
        }


        private void tomarPedido_Load(object sender, EventArgs e)
        {
            ViewBebida.AllowUserToAddRows = false;
            ViewComida.AllowUserToAddRows = false;



        }



        public void verificarChecks(DataGridView tabla, ref List<Tuple<int, int>> arr)
        {

            foreach (DataGridViewRow row in tabla.Rows)
            {
                if (Convert.ToBoolean(row.Cells[3].Value) == true)
                {
                    arr.Add(Tuple.Create(row.Index, Convert.ToInt32(row.Cells[4].Value)));

                }
            }

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            //verificando reserva
            string sql = "SELECT COUNT(*) FROM reserva WHERE id_reserva=" + idReserva.Text + " and estado=='libre' and id_pedido is NULL;";
            SqlDataReader dataReader;
            SqlCommand command;
            command = new SqlCommand(sql, BD.cnn);

            dataReader = command.ExecuteReader();

            int cantidadReserva;
            dataReader.Read();

            cantidadReserva = Convert.ToInt32(dataReader.GetValue(0).ToString());
            dataReader.Close();
            if (cantidadReserva < 1)
            {
                MessageBox.Show("El número de Reserva es inválido o ya tiene un pedido");
                RefreshTables();
                return;
            }

            //int codigoPedidoEnter = Convert.ToInt32(cantidadReserva);



            //creando pedido
            sql = "INSERT INTO pedido(estado) values('00');";

            SqlDataAdapter adapter = new SqlDataAdapter();

            command = new SqlCommand(sql, BD.cnn);

            adapter.InsertCommand = new SqlCommand(sql, BD.cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            //asignando reserva


            //obetener id de pedido y asignando RESERVA
            sql = "SELECT IDENT_CURRENT('pedido');";

            command = new SqlCommand(sql, BD.cnn);

            dataReader = command.ExecuteReader();

            //dataReader.Close();

            string codigoPedido;
            dataReader.Read();

            codigoPedido = dataReader.GetValue(0).ToString();
            int codigoPedidoEnter = Convert.ToInt32(codigoPedido);
            MessageBox.Show(codigoPedidoEnter.ToString());
            dataReader.Close();

            //asignandooo
            sql = "UPDATE reserva SET id_pedido=" + codigoPedido + "WHERE id_reserva=" + idReserva.Text + ";";


            command = new SqlCommand(sql, BD.cnn);
            adapter.UpdateCommand = new SqlCommand(sql, BD.cnn);
            adapter.UpdateCommand.ExecuteNonQuery();
            command.Dispose();


            //command.Dispose();


            //creando detalles_pedido
            List<Tuple<int, int>> comidas = new List<Tuple<int, int>>();
            List<Tuple<int, int>> bebidas = new List<Tuple<int, int>>();


            verificarChecks(ViewComida, ref comidas);
            verificarChecks(ViewBebida, ref bebidas);

            for (int i = 0; i < comidas.Count; i++)
            {
                int k = Convert.ToInt32(comidas[i].Item2);
                for (int j = 0; j < k; j++)
                {
                    string word = (ViewComida.Rows[comidas[i].Item1].Cells[0].Value).ToString();
                    sql = "insert into detalle_pedido(id_pedido,id_comida) values(" + codigoPedido + "," + word + ");";

                    SqlDataAdapter adapter1 = new SqlDataAdapter();
                    command = new SqlCommand(sql, BD.cnn);
                    adapter1.InsertCommand = new SqlCommand(sql, BD.cnn);
                    adapter1.InsertCommand.ExecuteNonQuery();




                }
            }

            for (int i = 0; i < bebidas.Count; i++)
            {
                int k = Convert.ToInt32(bebidas[i].Item2);
                for (int j = 0; j < k; j++)
                {
                    string word = (ViewBebida.Rows[bebidas[i].Item1].Cells[0].Value).ToString();
                    sql = "insert into detalle_pedido(id_pedido,id_bebida) values(" + codigoPedido + "," + word + ");";

                    SqlDataAdapter adapter1 = new SqlDataAdapter();
                    command = new SqlCommand(sql, BD.cnn);
                    adapter1.InsertCommand = new SqlCommand(sql, BD.cnn);
                    adapter1.InsertCommand.ExecuteNonQuery();


                }
            }
            dataReader.Close();
            RefreshTables();

        }

        private void ViewComida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ViewComida.Columns[e.ColumnIndex].Name == "Pedir")
            {
                DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)ViewComida.CurrentCell;

                bool isChecked = (bool)checkbox.EditedFormattedValue;
                if (isChecked)
                {
                    ViewComida.Rows[e.RowIndex].Cells[4].ReadOnly = false;
                }
                else
                {
                    ViewComida.Rows[e.RowIndex].Cells[4].Value = "";
                    ViewComida.Rows[e.RowIndex].Cells[4].ReadOnly = true;
                }
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ViewBebida.Columns[e.ColumnIndex].Name == "pedir1")
            {
                //MessageBox.Show("HOLA");
                DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)ViewBebida.CurrentCell;

                bool isChecked = (bool)checkbox.EditedFormattedValue;
                if (isChecked)
                {

                    ViewBebida.Rows[e.RowIndex].Cells[4].ReadOnly = false;
                }
                else
                {
                    ViewBebida.Rows[e.RowIndex].Cells[4].Value = "";
                    ViewBebida.Rows[e.RowIndex].Cells[4].ReadOnly = true;
                }
            }
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            RefreshTables();
            idReserva.Text = string.Empty;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            BD.cnn.Close();
            this.Hide();
            Form back = new login();
            back.ShowDialog();
            this.Close();
        }
    }
}