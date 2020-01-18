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


/*
 * 1.5.1 Creacion de formulario login - Jose Z
 * 1.5.6 Diseño de ventana login y menu de Chef y Bartender - Jose Z
 */

namespace SistemaRestaurant
{
    public partial class login : MaterialSkin.Controls.MaterialForm
    {
        public login()
        {
            InitializeComponent();
            BD.cnn.Open();
        }

        private void loggin_Load(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }     

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tipo;
            SqlCommand command;
            String sql, Output = "";
            SqlDataReader dataReader;
            sql = "select usuario, password, tipo from empleado";
            command = new SqlCommand(sql, BD.cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                if (textBox1.Text == dataReader.GetValue(0))
                {

                    if (textBox2.Text == dataReader.GetValue(1))
                    {
                        if(dataReader.GetValue(2) == "chef" || dataReader.GetValue(2) == "bartender")
                        {
                            menuChefBartender mCB = new menuChefBartender();
                            mCB.Show();
                        }
                        else if(dataReader.GetValue(2) == "mozo")
                        {
                            menuChefBartender mCB = new menuChefBartender();
                            mCB.Show();
                        }
                        else if(dataReader.GetValue(2) == "maitre")
                        {
                            menuChefBartender mCB = new menuChefBartender();
                            mCB.Show();
                        }
                    }
                }
            }
        }
    }
}
