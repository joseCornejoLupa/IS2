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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BD.cnn.Open();
        }


        // TEST - Jose Z
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            String sql, Output = "";
            SqlDataReader dataReader;
            sql = "select * from test";
            command = new SqlCommand(sql, BD.cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + "\n";
            }
            MessageBox.Show(Output);
        }
        // -------------------
    }
}
