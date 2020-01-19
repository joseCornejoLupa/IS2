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

//1.6.1  --gestionReserva--  Jose C

namespace SistemaRestaurant
{
    public partial class gestionReserva : MaterialSkin.Controls.MaterialForm
    {
        string aux = "";
        public gestionReserva()
        {
            InitializeComponent();
        }
        private void gestionReserva_Load(object sender, EventArgs e)
        {
            confirmarButton.Hide();
            BD.cnn.Open();
            SqlCommand command;
            String sql;
            SqlDataReader dataReader;
            sql = "select id_mesa,hora_inicio,hora_fin,estado from reserva";
            command = new SqlCommand(sql, BD.cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                dataGridReserva.Rows.Add(dataReader.GetValue(0), dataReader.GetValue(1), dataReader.GetValue(2), dataReader.GetValue(3));
            }
            dataReader.Close();
            BD.cnn.Close();
        }

        private void verDisponiblesButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridReserva_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridReserva.Columns[e.ColumnIndex].Name == "modificarButtons")
            {
                foreach (DataGridViewRow row in dataGridReserva.SelectedRows)
                {
                    aux = row.Cells[0].Value.ToString();
                    horaInicioTextBox.Text = row.Cells[1].Value.ToString();
                    horaFinTextBox.Text = row.Cells[2].Value.ToString();
                }
                confirmarButton.Show();
            }
            if (dataGridReserva.Columns[e.ColumnIndex].Name == "eliminarButtons")
            {

            }
            if (dataGridReserva.Columns[e.ColumnIndex].Name == "reservarButtons")
            {

            }
        }

        private void confirmarButton_Click_1(object sender, EventArgs e)
        {
            BD.cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();

            String sql;
            sql = "update reserva set hora_inicio = CAST('" + horaInicioTextBox.Text + "'AS time), hora_fin= CAST('" + horaFinTextBox.Text + "'AS time) where id_mesa = CAST('" + aux + "' AS int)";
            command = new SqlCommand(sql, BD.cnn);
            adapter.UpdateCommand = new SqlCommand(sql, BD.cnn);
            adapter.UpdateCommand.ExecuteNonQuery();
            command.Dispose();
            BD.cnn.Close();
            MessageBox.Show("Modificado Correctamente");
            //BD.cnn.Open();
            //SqlCommand command = BD.cnn.CreateCommand();
            //SqlTransaction transaction;
            //transaction = BD.cnn.BeginTransaction("update transaction");
            //command.Connection = BD.cnn;
            //command.Transaction = transaction;
            //command.CommandText = "UPDATE reserva SET hora_inicio = CAST(" + horaFinTextBox.Text + "AS time) WHERE id_mesa = CAST(" + aux + "AS int)";
            //command.ExecuteNonQuery();
            //transaction.Commit();
            //command.Dispose();
            //BD.cnn.Close();
            dataGridReserva.Rows.Clear();
            BD.cnn.Open();
            SqlCommand command2;
            String sql2;
            SqlDataReader dataReader;
            sql2 = "select id_mesa,hora_inicio,hora_fin,estado from reserva";
            command2 = new SqlCommand(sql2, BD.cnn);
            dataReader = command2.ExecuteReader();
            while (dataReader.Read())
            {
                dataGridReserva.Rows.Add(dataReader.GetValue(0), dataReader.GetValue(1), dataReader.GetValue(2), dataReader.GetValue(3));
            }
            dataReader.Close();
            BD.cnn.Close();
        }
    }
}
