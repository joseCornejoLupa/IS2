namespace SistemaRestaurant
{
    partial class gestionReserva
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
            this.horaFinTextBox = new System.Windows.Forms.TextBox();
            this.horaInicioTextBox = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.confirmarButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.dataGridReserva = new System.Windows.Forms.DataGridView();
            this.mesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modificarButtons = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eliminarButtons = new System.Windows.Forms.DataGridViewButtonColumn();
            this.reservarButtons = new System.Windows.Forms.DataGridViewButtonColumn();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // horaFinTextBox
            // 
            this.horaFinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaFinTextBox.Location = new System.Drawing.Point(755, 199);
            this.horaFinTextBox.Name = "horaFinTextBox";
            this.horaFinTextBox.Size = new System.Drawing.Size(232, 26);
            this.horaFinTextBox.TabIndex = 14;
            // 
            // horaInicioTextBox
            // 
            this.horaInicioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaInicioTextBox.Location = new System.Drawing.Point(755, 132);
            this.horaInicioTextBox.Name = "horaInicioTextBox";
            this.horaInicioTextBox.Size = new System.Drawing.Size(232, 26);
            this.horaInicioTextBox.TabIndex = 13;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(751, 167);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(70, 19);
            this.materialLabel3.TabIndex = 12;
            this.materialLabel3.Text = "Hora Fin:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(751, 97);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(87, 19);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Hora Inicio:";
            // 
            // confirmarButton
            // 
            this.confirmarButton.AutoSize = true;
            this.confirmarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.confirmarButton.Depth = 0;
            this.confirmarButton.Location = new System.Drawing.Point(826, 252);
            this.confirmarButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.confirmarButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.confirmarButton.Name = "confirmarButton";
            this.confirmarButton.Primary = false;
            this.confirmarButton.Size = new System.Drawing.Size(84, 36);
            this.confirmarButton.TabIndex = 17;
            this.confirmarButton.Text = "Modificar";
            this.confirmarButton.UseVisualStyleBackColor = true;
            this.confirmarButton.Click += new System.EventHandler(this.confirmarButton_Click_1);
            // 
            // dataGridReserva
            // 
            this.dataGridReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mesa,
            this.horaInicio,
            this.horaFin,
            this.estado,
            this.modificarButtons,
            this.eliminarButtons,
            this.reservarButtons});
            this.dataGridReserva.Location = new System.Drawing.Point(0, 63);
            this.dataGridReserva.Name = "dataGridReserva";
            this.dataGridReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridReserva.Size = new System.Drawing.Size(736, 538);
            this.dataGridReserva.TabIndex = 18;
            this.dataGridReserva.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridReserva_CellContentClick_1);
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
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // modificarButtons
            // 
            this.modificarButtons.HeaderText = "Modificar";
            this.modificarButtons.Name = "modificarButtons";
            this.modificarButtons.Text = "Modificar";
            // 
            // eliminarButtons
            // 
            this.eliminarButtons.HeaderText = "Eliminar";
            this.eliminarButtons.Name = "eliminarButtons";
            this.eliminarButtons.Text = "Eliminar";
            // 
            // reservarButtons
            // 
            this.reservarButtons.HeaderText = "Reservar";
            this.reservarButtons.Name = "reservarButtons";
            this.reservarButtons.Text = "Reservar";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(907, 549);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(80, 36);
            this.materialFlatButton1.TabIndex = 19;
            this.materialFlatButton1.Text = "Regresar";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // gestionReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.dataGridReserva);
            this.Controls.Add(this.confirmarButton);
            this.Controls.Add(this.horaFinTextBox);
            this.Controls.Add(this.horaInicioTextBox);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Name = "gestionReserva";
            this.Text = "Gestion Reserva";
            this.Load += new System.EventHandler(this.gestionReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox horaFinTextBox;
        private System.Windows.Forms.TextBox horaInicioTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialFlatButton confirmarButton;
        private System.Windows.Forms.DataGridView dataGridReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewButtonColumn modificarButtons;
        private System.Windows.Forms.DataGridViewButtonColumn eliminarButtons;
        private System.Windows.Forms.DataGridViewButtonColumn reservarButtons;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}