﻿using System;
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
    public partial class emitirBoleta : MaterialSkin.Controls.MaterialForm
    {
        public emitirBoleta()
        {
            InitializeComponent();
        }

        private void emitirBoleta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'restauranteDataSet3.pedido' Puede moverla o quitarla según sea necesario.
            this.pedidoTableAdapter.Fill(this.restauranteDataSet3.pedido);

        }
    }
}
