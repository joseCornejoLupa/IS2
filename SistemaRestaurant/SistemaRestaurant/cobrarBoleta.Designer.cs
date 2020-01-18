namespace SistemaRestaurant
{
    partial class cobrarBoleta
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.restauranteDataSet1 = new SistemaRestaurant.RestauranteDataSet1();
            this.boletaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boletaTableAdapter = new SistemaRestaurant.RestauranteDataSet1TableAdapters.boletaTableAdapter();
            this.idboletaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generarBoleta = new System.Windows.Forms.Button();
            this.regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boletaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idboletaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.idpedidoDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.boletaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(554, 430);
            this.dataGridView1.TabIndex = 0;
            // 
            // restauranteDataSet1
            // 
            this.restauranteDataSet1.DataSetName = "RestauranteDataSet1";
            this.restauranteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boletaBindingSource
            // 
            this.boletaBindingSource.DataMember = "boleta";
            this.boletaBindingSource.DataSource = this.restauranteDataSet1;
            // 
            // boletaTableAdapter
            // 
            this.boletaTableAdapter.ClearBeforeFill = true;
            // 
            // idboletaDataGridViewTextBoxColumn
            // 
            this.idboletaDataGridViewTextBoxColumn.DataPropertyName = "id_boleta";
            this.idboletaDataGridViewTextBoxColumn.HeaderText = "id_boleta";
            this.idboletaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idboletaDataGridViewTextBoxColumn.Name = "idboletaDataGridViewTextBoxColumn";
            this.idboletaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idboletaDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.Width = 125;
            // 
            // idpedidoDataGridViewTextBoxColumn
            // 
            this.idpedidoDataGridViewTextBoxColumn.DataPropertyName = "id_pedido";
            this.idpedidoDataGridViewTextBoxColumn.HeaderText = "id_pedido";
            this.idpedidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpedidoDataGridViewTextBoxColumn.Name = "idpedidoDataGridViewTextBoxColumn";
            this.idpedidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "monto";
            this.montoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.Width = 125;
            // 
            // generarBoleta
            // 
            this.generarBoleta.Location = new System.Drawing.Point(680, 173);
            this.generarBoleta.Name = "generarBoleta";
            this.generarBoleta.Size = new System.Drawing.Size(123, 45);
            this.generarBoleta.TabIndex = 3;
            this.generarBoleta.Text = "Cobrar Boleta";
            this.generarBoleta.UseVisualStyleBackColor = true;
            // 
            // regresar
            // 
            this.regresar.Location = new System.Drawing.Point(680, 326);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(123, 45);
            this.regresar.TabIndex = 4;
            this.regresar.Text = "Regresar";
            this.regresar.UseVisualStyleBackColor = true;
            // 
            // cobrarBoleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 691);
            this.Controls.Add(this.regresar);
            this.Controls.Add(this.generarBoleta);
            this.Controls.Add(this.dataGridView1);
            this.Name = "cobrarBoleta";
            this.Text = "cobrarBoleta";
            this.Load += new System.EventHandler(this.cobrarBoleta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boletaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RestauranteDataSet1 restauranteDataSet1;
        private System.Windows.Forms.BindingSource boletaBindingSource;
        private RestauranteDataSet1TableAdapters.boletaTableAdapter boletaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idboletaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button generarBoleta;
        private System.Windows.Forms.Button regresar;
    }
}