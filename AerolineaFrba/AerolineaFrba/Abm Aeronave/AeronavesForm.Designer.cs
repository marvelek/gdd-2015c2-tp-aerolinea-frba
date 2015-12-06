namespace AerolineaFrba.Abm_Aeronave
{
    partial class AeronavesForm
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
            this.Matricula = new System.Windows.Forms.Label();
            this.MatriculaBox = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.Alta = new System.Windows.Forms.Button();
            this.FueraServicio = new System.Windows.Forms.Button();
            this.BajaDef = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeronavesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Location = new System.Drawing.Point(42, 97);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(517, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // Matricula
            // 
            this.Matricula.AutoSize = true;
            this.Matricula.Location = new System.Drawing.Point(42, 50);
            this.Matricula.Name = "Matricula";
            this.Matricula.Size = new System.Drawing.Size(53, 13);
            this.Matricula.TabIndex = 1;
            this.Matricula.Text = "Matricula:";
            // 
            // MatriculaBox
            // 
            this.MatriculaBox.Location = new System.Drawing.Point(98, 43);
            this.MatriculaBox.Name = "MatriculaBox";
            this.MatriculaBox.Size = new System.Drawing.Size(100, 20);
            this.MatriculaBox.TabIndex = 2;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(42, 273);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(88, 45);
            this.Buscar.TabIndex = 3;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Alta
            // 
            this.Alta.Location = new System.Drawing.Point(153, 273);
            this.Alta.Name = "Alta";
            this.Alta.Size = new System.Drawing.Size(82, 45);
            this.Alta.TabIndex = 4;
            this.Alta.Text = "Alta";
            this.Alta.UseVisualStyleBackColor = true;
            this.Alta.Click += new System.EventHandler(this.Alta_Click);
            // 
            // FueraServicio
            // 
            this.FueraServicio.Location = new System.Drawing.Point(258, 273);
            this.FueraServicio.Name = "FueraServicio";
            this.FueraServicio.Size = new System.Drawing.Size(93, 45);
            this.FueraServicio.TabIndex = 5;
            this.FueraServicio.Text = "Baja - Fuera de Servicio";
            this.FueraServicio.UseVisualStyleBackColor = true;
            this.FueraServicio.Click += new System.EventHandler(this.FueraServicio_Click);
            // 
            // BajaDef
            // 
            this.BajaDef.Location = new System.Drawing.Point(381, 273);
            this.BajaDef.Name = "BajaDef";
            this.BajaDef.Size = new System.Drawing.Size(85, 45);
            this.BajaDef.TabIndex = 6;
            this.BajaDef.Text = "Baja definitiva";
            this.BajaDef.UseVisualStyleBackColor = true;
            this.BajaDef.Click += new System.EventHandler(this.BajaDef_Click);
            // 
            // AeronavesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 446);
            this.Controls.Add(this.BajaDef);
            this.Controls.Add(this.FueraServicio);
            this.Controls.Add(this.Alta);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.MatriculaBox);
            this.Controls.Add(this.Matricula);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AeronavesForm";
            this.Text = "Aeronaves";
            this.Load += new System.EventHandler(this.AeronavesForm_Load);
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
        private System.Windows.Forms.Label Matricula;
        private System.Windows.Forms.TextBox MatriculaBox;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button Alta;
        private System.Windows.Forms.Button FueraServicio;
        private System.Windows.Forms.Button BajaDef;
    }
}