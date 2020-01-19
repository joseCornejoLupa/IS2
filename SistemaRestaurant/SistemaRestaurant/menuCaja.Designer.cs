﻿namespace SistemaRestaurant
{
    partial class menuCaja
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
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.emitirBoleta = new System.Windows.Forms.Button();
            this.v = new System.Windows.Forms.Button();
            this.comprarSuministro = new System.Windows.Forms.Button();
            this.cerrarSesion = new System.Windows.Forms.Button();
            this.visualizarVentas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            // v
            // 
            this.v.Location = new System.Drawing.Point(0, 58);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(230, 61);
            this.v.TabIndex = 3;
            this.v.Text = "Cobrar Boleta";
            this.v.UseVisualStyleBackColor = true;
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
            // cerrarSesion
            // 
            this.cerrarSesion.Location = new System.Drawing.Point(0, 463);
            this.cerrarSesion.Name = "cerrarSesion";
            this.cerrarSesion.Size = new System.Drawing.Size(230, 61);
            this.cerrarSesion.TabIndex = 6;
            this.cerrarSesion.Text = "Cerrar Sesión";
            this.cerrarSesion.UseVisualStyleBackColor = true;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.visualizarVentas);
            this.panel1.Controls.Add(this.cerrarSesion);
            this.panel1.Controls.Add(this.comprarSuministro);
            this.panel1.Controls.Add(this.v);
            this.panel1.Controls.Add(this.emitirBoleta);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 540);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.Location = new System.Drawing.Point(568, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F);
            this.label1.Location = new System.Drawing.Point(430, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 85);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bienvenido";
            // 
            // menuCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "menuCaja";
            this.Text = "Menu Caja";
            this.Load += new System.EventHandler(this.menuCaja_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.Button emitirBoleta;
        private System.Windows.Forms.Button v;
        private System.Windows.Forms.Button comprarSuministro;
        private System.Windows.Forms.Button cerrarSesion;
        private System.Windows.Forms.Button visualizarVentas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}