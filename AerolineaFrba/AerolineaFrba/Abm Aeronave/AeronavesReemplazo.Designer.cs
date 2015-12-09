namespace AerolineaFrba.Abm_Aeronave
{
    partial class AeronavesReemplazo
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
            this.aeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiposervicioidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aermatriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aermodeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aerkgdisponiblesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aerfabricanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aerfechafueraservicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aerfechareinicioservicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aerfechabajadefinitivaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aeractivoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.aerfechaaltaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aeronavesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2015DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2015DataSet = new AerolineaFrba.GD2C2015DataSet();
            this.aeronavesTableAdapter = new AerolineaFrba.GD2C2015DataSetTableAdapters.AeronavesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeronavesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aeridDataGridViewTextBoxColumn,
            this.tiposervicioidDataGridViewTextBoxColumn,
            this.aermatriculaDataGridViewTextBoxColumn,
            this.aermodeloDataGridViewTextBoxColumn,
            this.aerkgdisponiblesDataGridViewTextBoxColumn,
            this.aerfabricanteDataGridViewTextBoxColumn,
            this.aerfechafueraservicioDataGridViewTextBoxColumn,
            this.aerfechareinicioservicioDataGridViewTextBoxColumn,
            this.aerfechabajadefinitivaDataGridViewTextBoxColumn,
            this.aeractivoDataGridViewCheckBoxColumn,
            this.aerfechaaltaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aeronavesBindingSource;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(32, 52);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(541, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // aeridDataGridViewTextBoxColumn
            // 
            this.aeridDataGridViewTextBoxColumn.DataPropertyName = "aer_id";
            this.aeridDataGridViewTextBoxColumn.HeaderText = "aer_id";
            this.aeridDataGridViewTextBoxColumn.Name = "aeridDataGridViewTextBoxColumn";
            this.aeridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tiposervicioidDataGridViewTextBoxColumn
            // 
            this.tiposervicioidDataGridViewTextBoxColumn.DataPropertyName = "tipo_servicio_id";
            this.tiposervicioidDataGridViewTextBoxColumn.HeaderText = "tipo_servicio_id";
            this.tiposervicioidDataGridViewTextBoxColumn.Name = "tiposervicioidDataGridViewTextBoxColumn";
            this.tiposervicioidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aermatriculaDataGridViewTextBoxColumn
            // 
            this.aermatriculaDataGridViewTextBoxColumn.DataPropertyName = "aer_matricula";
            this.aermatriculaDataGridViewTextBoxColumn.HeaderText = "aer_matricula";
            this.aermatriculaDataGridViewTextBoxColumn.Name = "aermatriculaDataGridViewTextBoxColumn";
            this.aermatriculaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aermodeloDataGridViewTextBoxColumn
            // 
            this.aermodeloDataGridViewTextBoxColumn.DataPropertyName = "aer_modelo";
            this.aermodeloDataGridViewTextBoxColumn.HeaderText = "aer_modelo";
            this.aermodeloDataGridViewTextBoxColumn.Name = "aermodeloDataGridViewTextBoxColumn";
            this.aermodeloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aerkgdisponiblesDataGridViewTextBoxColumn
            // 
            this.aerkgdisponiblesDataGridViewTextBoxColumn.DataPropertyName = "aer_kg_disponibles";
            this.aerkgdisponiblesDataGridViewTextBoxColumn.HeaderText = "aer_kg_disponibles";
            this.aerkgdisponiblesDataGridViewTextBoxColumn.Name = "aerkgdisponiblesDataGridViewTextBoxColumn";
            this.aerkgdisponiblesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aerfabricanteDataGridViewTextBoxColumn
            // 
            this.aerfabricanteDataGridViewTextBoxColumn.DataPropertyName = "aer_fabricante";
            this.aerfabricanteDataGridViewTextBoxColumn.HeaderText = "aer_fabricante";
            this.aerfabricanteDataGridViewTextBoxColumn.Name = "aerfabricanteDataGridViewTextBoxColumn";
            this.aerfabricanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aerfechafueraservicioDataGridViewTextBoxColumn
            // 
            this.aerfechafueraservicioDataGridViewTextBoxColumn.DataPropertyName = "aer_fecha_fuera_servicio";
            this.aerfechafueraservicioDataGridViewTextBoxColumn.HeaderText = "aer_fecha_fuera_servicio";
            this.aerfechafueraservicioDataGridViewTextBoxColumn.Name = "aerfechafueraservicioDataGridViewTextBoxColumn";
            this.aerfechafueraservicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aerfechareinicioservicioDataGridViewTextBoxColumn
            // 
            this.aerfechareinicioservicioDataGridViewTextBoxColumn.DataPropertyName = "aer_fecha_reinicio_servicio";
            this.aerfechareinicioservicioDataGridViewTextBoxColumn.HeaderText = "aer_fecha_reinicio_servicio";
            this.aerfechareinicioservicioDataGridViewTextBoxColumn.Name = "aerfechareinicioservicioDataGridViewTextBoxColumn";
            this.aerfechareinicioservicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aerfechabajadefinitivaDataGridViewTextBoxColumn
            // 
            this.aerfechabajadefinitivaDataGridViewTextBoxColumn.DataPropertyName = "aer_fecha_baja_definitiva";
            this.aerfechabajadefinitivaDataGridViewTextBoxColumn.HeaderText = "aer_fecha_baja_definitiva";
            this.aerfechabajadefinitivaDataGridViewTextBoxColumn.Name = "aerfechabajadefinitivaDataGridViewTextBoxColumn";
            this.aerfechabajadefinitivaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aeractivoDataGridViewCheckBoxColumn
            // 
            this.aeractivoDataGridViewCheckBoxColumn.DataPropertyName = "aer_activo";
            this.aeractivoDataGridViewCheckBoxColumn.HeaderText = "aer_activo";
            this.aeractivoDataGridViewCheckBoxColumn.Name = "aeractivoDataGridViewCheckBoxColumn";
            this.aeractivoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // aerfechaaltaDataGridViewTextBoxColumn
            // 
            this.aerfechaaltaDataGridViewTextBoxColumn.DataPropertyName = "aer_fecha_alta";
            this.aerfechaaltaDataGridViewTextBoxColumn.HeaderText = "aer_fecha_alta";
            this.aerfechaaltaDataGridViewTextBoxColumn.Name = "aerfechaaltaDataGridViewTextBoxColumn";
            this.aerfechaaltaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aeronavesBindingSource
            // 
            this.aeronavesBindingSource.DataMember = "Aeronaves";
            this.aeronavesBindingSource.DataSource = this.gD2C2015DataSetBindingSource;
            // 
            // gD2C2015DataSetBindingSource
            // 
            this.gD2C2015DataSetBindingSource.DataSource = this.gD2C2015DataSet;
            this.gD2C2015DataSetBindingSource.Position = 0;
            // 
            // gD2C2015DataSet
            // 
            this.gD2C2015DataSet.DataSetName = "GD2C2015DataSet";
            this.gD2C2015DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aeronavesTableAdapter
            // 
            this.aeronavesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione la Aeronave de reemplazo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Reemplazar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AeronavesReemplazo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 276);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AeronavesReemplazo";
            this.Text = "Reemplazo Aeronaves";
            this.Load += new System.EventHandler(this.AeronavesReemplazo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeronavesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gD2C2015DataSetBindingSource;
        private GD2C2015DataSet gD2C2015DataSet;
        private System.Windows.Forms.BindingSource aeronavesBindingSource;
        private GD2C2015DataSetTableAdapters.AeronavesTableAdapter aeronavesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiposervicioidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aermatriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aermodeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aerkgdisponiblesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aerfabricanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aerfechafueraservicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aerfechareinicioservicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aerfechabajadefinitivaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aeractivoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aerfechaaltaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}