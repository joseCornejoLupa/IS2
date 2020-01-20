using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

//1.6.2  --gestionReserva--  Jose C
//1.6.5  --gestionReservaBotonesFuncionalidadesDemas -- Jose C

namespace SistemaRestaurant
{
    public partial class gestionReserva : MaterialSkin.Controls.MaterialForm
    {
        string aux = "";
        string horaIO = "";
        string horaFO = "";
        public gestionReserva()
        {
            InitializeComponent();
        }
        private void gestionReserva_Load(object sender, EventArgs e)
        {
            modifyButton.Hide();
        }

        private void verDisponiblesButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridReserva_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void confirmarButton_Click_1(object sender, EventArgs e)
        {
            
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuReserva mR = new menuReserva();
            mR.Show();
        }

        private void gestionarReservaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gestionarReservaDataGridView.Columns[e.ColumnIndex].Name == "modificarButtons2")
            {
                modifyButton.Show();
                foreach (DataGridViewRow row in gestionarReservaDataGridView.SelectedRows)
                {
                    aux = row.Cells[0].Value.ToString();
                    horaIO = row.Cells[1].Value.ToString();
                    horaFO = row.Cells[2].Value.ToString();
                }
            }
            if (gestionarReservaDataGridView.Columns[e.ColumnIndex].Name == "eliminarButtons2")
            {
                foreach (DataGridViewRow row in gestionarReservaDataGridView.SelectedRows)
                {
                    aux = row.Cells[0].Value.ToString();
                    horaIO = row.Cells[1].Value.ToString();
                    horaFO = row.Cells[2].Value.ToString();
                }
                BD.cnn.Open();
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                String sql;
                sql = "update reserva set estado = 'libre', hora_inicio = CAST('" + horaIO + "' AS int), hora_fin = CAST('" + horaFO + "' AS int) where id_mesa = CAST('" + aux + "' AS int)";
                command = new SqlCommand(sql, BD.cnn);
                adapter.UpdateCommand = new SqlCommand(sql, BD.cnn);
                adapter.UpdateCommand.ExecuteNonQuery();
                command.Dispose();
                BD.cnn.Close();
                MessageBox.Show("Eliminado Correctamente");


                gestionarReservaDataGridView.Rows.Clear();
                BD.cnn.Open();
                SqlCommand command2;
                String sql2;
                SqlDataReader dataReader;
                sql2 = "select id_mesa,hora_inicio,hora_fin,estado from reserva where hora_inicio >= CAST('" + hiComboBox.SelectedItem.ToString() + "'AS int) and hora_fin <= CAST('" + hfComboBox.SelectedItem.ToString() + "'AS int)";
                command2 = new SqlCommand(sql2, BD.cnn);
                dataReader = command2.ExecuteReader();
                while (dataReader.Read())
                {
                    gestionarReservaDataGridView.Rows.Add(dataReader.GetValue(0), dataReader.GetValue(1), dataReader.GetValue(2), dataReader.GetValue(3));
                }
                dataReader.Close();
                BD.cnn.Close();
            }
            if (gestionarReservaDataGridView.Columns[e.ColumnIndex].Name == "reservarButtons2")
            {
                foreach (DataGridViewRow row in gestionarReservaDataGridView.SelectedRows)
                {
                    aux = row.Cells[0].Value.ToString();
                    horaIO = row.Cells[1].Value.ToString();
                    horaFO = row.Cells[2].Value.ToString();
                }
                BD.cnn.Open();
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();

                String sql;
                sql = "update reserva set estado = 'ocupado', hora_inicio = CAST('" + horaIO + "' AS int), hora_fin = CAST('" + horaFO + "' AS int) where id_mesa = CAST('" + aux + "' AS int)";
                command = new SqlCommand(sql, BD.cnn);
                adapter.UpdateCommand = new SqlCommand(sql, BD.cnn);
                adapter.UpdateCommand.ExecuteNonQuery();
                command.Dispose();
                BD.cnn.Close();
                MessageBox.Show("Reservado Correctamente");


                gestionarReservaDataGridView.Rows.Clear();
                BD.cnn.Open();
                SqlCommand command2;
                String sql2;
                SqlDataReader dataReader;
                sql2 = "select id_mesa,hora_inicio,hora_fin,estado from reserva where hora_inicio >= CAST('" + hiComboBox.SelectedItem.ToString() + "'AS int) and hora_fin <= CAST('" + hfComboBox.SelectedItem.ToString() + "'AS int)";
                command2 = new SqlCommand(sql2, BD.cnn);
                dataReader = command2.ExecuteReader();
                while (dataReader.Read())
                {
                    gestionarReservaDataGridView.Rows.Add(dataReader.GetValue(0), dataReader.GetValue(1), dataReader.GetValue(2), dataReader.GetValue(3));
                }
                dataReader.Close();
                BD.cnn.Close();
            }
        }

        private void QueryButton_Click(object sender, EventArgs e)
        {
            gestionarReservaDataGridView.Rows.Clear();
            BD.cnn.Open();
            SqlCommand command;
            String sql;
            SqlDataReader dataReader;
            sql = "select id_mesa,hora_inicio,hora_fin,estado from reserva where hora_inicio >= CAST('" + hiComboBox.SelectedItem.ToString() + "'AS int) and hora_fin <= CAST('" + hfComboBox.SelectedItem.ToString() + "'AS int)";
            command = new SqlCommand(sql, BD.cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                gestionarReservaDataGridView.Rows.Add(dataReader.GetValue(0), dataReader.GetValue(1), dataReader.GetValue(2), dataReader.GetValue(3));
            }
            dataReader.Close();
            BD.cnn.Close();
            foreach (DataGridViewRow row in gestionarReservaDataGridView.SelectedRows)
            {
                aux = row.Cells[0].Value.ToString();
                horaIO = row.Cells[1].Value.ToString();
                horaFO = row.Cells[2].Value.ToString();
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            int hora_inicio = 0, hora_fin = 0;
            SqlCommand command;
            try
            {
                hora_inicio = Convert.ToInt32(hiComboBox.SelectedItem.ToString());
                hora_fin = Convert.ToInt32(hfComboBox.SelectedItem.ToString());

                BD.cnn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                String sql;
                sql = "update reserva set hora_inicio = CAST('" + hiComboBox.SelectedItem.ToString() + "'AS int), hora_fin= CAST('" + hfComboBox.SelectedItem.ToString() + "'AS int) where id_mesa = CAST('" + aux + "' AS int)";
                command = new SqlCommand(sql, BD.cnn);
                adapter.UpdateCommand = new SqlCommand(sql, BD.cnn);
                adapter.UpdateCommand.ExecuteNonQuery();
                command.Dispose();
                BD.cnn.Close();
                MessageBox.Show("Modificado Correctamente");

                gestionarReservaDataGridView.Rows.Clear();
                BD.cnn.Open();
                SqlCommand command2;
                String sql2;
                SqlDataReader dataReader;
                sql2 = "select id_mesa,hora_inicio,hora_fin,estado from reserva where hora_inicio >= CAST('" + hiComboBox.SelectedItem.ToString() + "'AS int) and hora_fin <= CAST('" + hfComboBox.SelectedItem.ToString() + "'AS int)";
                command2 = new SqlCommand(sql2, BD.cnn);
                dataReader = command2.ExecuteReader();
                while (dataReader.Read())
                {
                    gestionarReservaDataGridView.Rows.Add(dataReader.GetValue(0), dataReader.GetValue(1), dataReader.GetValue(2), dataReader.GetValue(3));
                }
                dataReader.Close();
                BD.cnn.Close();
            }
            catch
            {
                MessageBox.Show("Ingrese una hora valida");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuReserva mR = new menuReserva();
            mR.Show();
        }
    }
}
