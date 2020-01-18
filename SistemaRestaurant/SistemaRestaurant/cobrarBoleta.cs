using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRestaurant
{
    public partial class cobrarBoleta : MaterialSkin.Controls.MaterialForm
    {
        public cobrarBoleta()
        {
            InitializeComponent();
        }

        private void cobrarBoleta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'restauranteDataSet1.boleta' Puede moverla o quitarla según sea necesario.
            this.boletaTableAdapter.Fill(this.restauranteDataSet1.boleta);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
