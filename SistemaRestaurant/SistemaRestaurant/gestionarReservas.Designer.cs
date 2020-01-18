namespace SistemaRestaurant
{
    partial class gestionarReservas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modificarButtons = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eliminarButtons = new System.Windows.Forms.DataGridViewButtonColumn();
            this.reservarButtons = new System.Windows.Forms.DataGridViewButtonColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.horaInicioTextBox = new System.Windows.Forms.TextBox();
            this.horaFinTextBox = new System.Windows.Forms.TextBox();
            this.regresarButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.verDisponiblesButton = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mesa,
            this.horaInicio,
            this.horaFin,
            this.modificarButtons,
            this.eliminarButtons,
            this.reservarButtons,
            this.estado});
            this.dataGridView1.Location = new System.Drawing.Point(-2, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(736, 538);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mesa
            // 
            this.mesa.HeaderText = "Mesa";
            this.mesa.Name = "mesa";
            // 
            // horaInicio
            // 
            this.horaInicio.HeaderText = "Hora Inicio";
            this.horaInicio.Name = "horaInicio";
            // 
            // horaFin
            // 
            this.horaFin.HeaderText = "Hora Fin";
            this.horaFin.Name = "horaFin";
            // 
            // modificarButtons
            // 
            this.modificarButtons.HeaderText = "Modificar";
            this.modificarButtons.Name = "modificarButtons";
            // 
            // eliminarButtons
            // 
            this.eliminarButtons.HeaderText = "Eliminar";
            this.eliminarButtons.Name = "eliminarButtons";
            // 
            // reservarButtons
            // 
            this.reservarButtons.HeaderText = "Reservar";
            this.reservarButtons.Name = "reservarButtons";
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(749, 96);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(87, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Hora Inicio:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(749, 166);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(70, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Hora Fin:";
            // 
            // horaInicioTextBox
            // 
            this.horaInicioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaInicioTextBox.Location = new System.Drawing.Point(753, 131);
            this.horaInicioTextBox.Name = "horaInicioTextBox";
            this.horaInicioTextBox.Size = new System.Drawing.Size(232, 26);
            this.horaInicioTextBox.TabIndex = 6;
            // 
            // horaFinTextBox
            // 
            this.horaFinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaFinTextBox.Location = new System.Drawing.Point(753, 198);
            this.horaFinTextBox.Name = "horaFinTextBox";
            this.horaFinTextBox.Size = new System.Drawing.Size(232, 26);
            this.horaFinTextBox.TabIndex = 7;
            // 
            // regresarButton
            // 
            this.regresarButton.AutoSize = true;
            this.regresarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.regresarButton.Depth = 0;
            this.regresarButton.Location = new System.Drawing.Point(907, 549);
            this.regresarButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.regresarButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.regresarButton.Name = "regresarButton";
            this.regresarButton.Primary = false;
            this.regresarButton.Size = new System.Drawing.Size(80, 36);
            this.regresarButton.TabIndex = 8;
            this.regresarButton.Text = "Regresar";
            this.regresarButton.UseVisualStyleBackColor = true;
            // 
            // verDisponiblesButton
            // 
            this.verDisponiblesButton.AutoSize = true;
            this.verDisponiblesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.verDisponiblesButton.Depth = 0;
            this.verDisponiblesButton.Location = new System.Drawing.Point(806, 253);
            this.verDisponiblesButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.verDisponiblesButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.verDisponiblesButton.Name = "verDisponiblesButton";
            this.verDisponiblesButton.Primary = false;
            this.verDisponiblesButton.Size = new System.Drawing.Size(126, 36);
            this.verDisponiblesButton.TabIndex = 9;
            this.verDisponiblesButton.Text = "Ver Disponibles";
            this.verDisponiblesButton.UseVisualStyleBackColor = true;
            // 
            // gestionarReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.verDisponiblesButton);
            this.Controls.Add(this.regresarButton);
            this.Controls.Add(this.horaFinTextBox);
            this.Controls.Add(this.horaInicioTextBox);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "gestionarReservas";
            this.Text = "Gestionar Reservas";
            this.Load += new System.EventHandler(this.gestionarReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaFin;
        private System.Windows.Forms.DataGridViewButtonColumn modificarButtons;
        private System.Windows.Forms.DataGridViewButtonColumn eliminarButtons;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TextBox horaInicioTextBox;
        private System.Windows.Forms.TextBox horaFinTextBox;
        private System.Windows.Forms.DataGridViewButtonColumn reservarButtons;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private MaterialSkin.Controls.MaterialFlatButton regresarButton;
        private MaterialSkin.Controls.MaterialFlatButton verDisponiblesButton;
    }
}