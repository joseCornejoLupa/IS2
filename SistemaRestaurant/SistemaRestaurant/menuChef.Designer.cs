namespace SistemaRestaurant
{
    partial class menuChef
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelbienvenido = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.visualizarVentas = new System.Windows.Forms.Button();
            this.cerrarSesion = new System.Windows.Forms.Button();
            this.comprarSuministro = new System.Windows.Forms.Button();
            this.v = new System.Windows.Forms.Button();
            this.emitirBoleta = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelbienvenido
            // 
            this.labelbienvenido.AutoSize = true;
            this.labelbienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F);
            this.labelbienvenido.Location = new System.Drawing.Point(255, 79);
            this.labelbienvenido.Name = "labelbienvenido";
            this.labelbienvenido.Size = new System.Drawing.Size(706, 170);
            this.labelbienvenido.TabIndex = 9;
            this.labelbienvenido.Text = "Bienvenido al menú \r\nde caja!";
            this.labelbienvenido.Click += new System.EventHandler(this.labelbienvenido_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.visualizarVentas);
            this.panel1.Controls.Add(this.cerrarSesion);
            this.panel1.Controls.Add(this.comprarSuministro);
            this.panel1.Controls.Add(this.v);
            this.panel1.Controls.Add(this.emitirBoleta);
            this.panel1.Location = new System.Drawing.Point(1, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 540);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // visualizarVentas
            // 
            this.visualizarVentas.Location = new System.Drawing.Point(0, 172);
            this.visualizarVentas.Name = "visualizarVentas";
            this.visualizarVentas.Size = new System.Drawing.Size(230, 61);
            this.visualizarVentas.TabIndex = 5;
            this.visualizarVentas.Text = "Visualizar Ventas";
            this.visualizarVentas.UseVisualStyleBackColor = true;
            // 
            // cerrarSesion
            // 
            this.cerrarSesion.Location = new System.Drawing.Point(0, 463);
            this.cerrarSesion.Name = "cerrarSesion";
            this.cerrarSesion.Size = new System.Drawing.Size(230, 61);
            this.cerrarSesion.TabIndex = 6;
            this.cerrarSesion.Text = "Cerrar Sesión";
            this.cerrarSesion.UseVisualStyleBackColor = true;
            // 
            // comprarSuministro
            // 
            this.comprarSuministro.Location = new System.Drawing.Point(0, 115);
            this.comprarSuministro.Name = "comprarSuministro";
            this.comprarSuministro.Size = new System.Drawing.Size(230, 61);
            this.comprarSuministro.TabIndex = 4;
            this.comprarSuministro.Text = "Cobrar Suministros";
            this.comprarSuministro.UseVisualStyleBackColor = true;
            // 
            // v
            // 
            this.v.Location = new System.Drawing.Point(0, 58);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(230, 61);
            this.v.TabIndex = 3;
            this.v.Text = "Cobrar Boleta";
            this.v.UseVisualStyleBackColor = true;
            // 
            // emitirBoleta
            // 
            this.emitirBoleta.Location = new System.Drawing.Point(0, 0);
            this.emitirBoleta.Name = "emitirBoleta";
            this.emitirBoleta.Size = new System.Drawing.Size(230, 61);
            this.emitirBoleta.TabIndex = 2;
            this.emitirBoleta.Text = "Emitir Boleta";
            this.emitirBoleta.UseVisualStyleBackColor = true;
            // 
            // menuChef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.labelbienvenido);
            this.Controls.Add(this.panel1);
            this.Name = "menuChef";
            this.Text = "menuChef";
            this.Load += new System.EventHandler(this.menuChef_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelbienvenido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button visualizarVentas;
        private System.Windows.Forms.Button cerrarSesion;
        private System.Windows.Forms.Button comprarSuministro;
        private System.Windows.Forms.Button v;
        private System.Windows.Forms.Button emitirBoleta;
    }
}