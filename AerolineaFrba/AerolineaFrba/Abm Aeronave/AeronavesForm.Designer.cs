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
            this.modeloBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fabricanteBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.precioKgHasta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.precioKgDesde = new System.Windows.Forms.TextBox();
            this.estadoCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.servicioCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tiposServicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipos_ServicioTableAdapter = new AerolineaFrba.GD2C2015DataSetTableAdapters.Tipos_ServicioTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.modificarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeronavesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposServicioBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 147);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(595, 164);
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
            this.Matricula.Location = new System.Drawing.Point(22, 39);
            this.Matricula.Name = "Matricula";
            this.Matricula.Size = new System.Drawing.Size(53, 13);
            this.Matricula.TabIndex = 1;
            this.Matricula.Text = "Matricula:";
            // 
            // MatriculaBox
            // 
            this.MatriculaBox.Location = new System.Drawing.Point(78, 32);
            this.MatriculaBox.Name = "MatriculaBox";
            this.MatriculaBox.Size = new System.Drawing.Size(100, 20);
            this.MatriculaBox.TabIndex = 1;
            this.MatriculaBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MatriculaBox_KeyDown);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(507, 98);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(82, 25);
            this.Buscar.TabIndex = 8;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Alta
            // 
            this.Alta.Location = new System.Drawing.Point(480, 317);
            this.Alta.Name = "Alta";
            this.Alta.Size = new System.Drawing.Size(128, 45);
            this.Alta.TabIndex = 9;
            this.Alta.Text = "Alta";
            this.Alta.UseVisualStyleBackColor = true;
            this.Alta.Click += new System.EventHandler(this.Alta_Click);
            // 
            // FueraServicio
            // 
            this.FueraServicio.Location = new System.Drawing.Point(138, 317);
            this.FueraServicio.Name = "FueraServicio";
            this.FueraServicio.Size = new System.Drawing.Size(128, 45);
            this.FueraServicio.TabIndex = 9;
            this.FueraServicio.Text = "Baja - Fuera de Servicio";
            this.FueraServicio.UseVisualStyleBackColor = true;
            this.FueraServicio.Click += new System.EventHandler(this.FueraServicio_Click);
            // 
            // BajaDef
            // 
            this.BajaDef.Location = new System.Drawing.Point(12, 317);
            this.BajaDef.Name = "BajaDef";
            this.BajaDef.Size = new System.Drawing.Size(120, 45);
            this.BajaDef.TabIndex = 10;
            this.BajaDef.Text = "Baja definitiva";
            this.BajaDef.UseVisualStyleBackColor = true;
            this.BajaDef.Click += new System.EventHandler(this.BajaDef_Click);
            // 
            // modeloBox
            // 
            this.modeloBox.Location = new System.Drawing.Point(251, 32);
            this.modeloBox.Name = "modeloBox";
            this.modeloBox.Size = new System.Drawing.Size(100, 20);
            this.modeloBox.TabIndex = 2;
            this.modeloBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.modeloBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Modelo:";
            // 
            // fabricanteBox
            // 
            this.fabricanteBox.Location = new System.Drawing.Point(430, 32);
            this.fabricanteBox.Name = "fabricanteBox";
            this.fabricanteBox.Size = new System.Drawing.Size(100, 20);
            this.fabricanteBox.TabIndex = 3;
            this.fabricanteBox.TextChanged += new System.EventHandler(this.k);
            this.fabricanteBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fabricanteBox_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fabricante:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // precioKgHasta
            // 
            this.precioKgHasta.Location = new System.Drawing.Point(139, 70);
            this.precioKgHasta.Name = "precioKgHasta";
            this.precioKgHasta.Size = new System.Drawing.Size(40, 20);
            this.precioKgHasta.TabIndex = 5;
            this.precioKgHasta.TextChanged += new System.EventHandler(this.precioKgHasta_TextChanged);
            this.precioKgHasta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.precioKgHasta_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Kg Entre ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // precioKgDesde
            // 
            this.precioKgDesde.Location = new System.Drawing.Point(78, 70);
            this.precioKgDesde.Name = "precioKgDesde";
            this.precioKgDesde.Size = new System.Drawing.Size(35, 20);
            this.precioKgDesde.TabIndex = 4;
            this.precioKgDesde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.precioKgDesde_KeyDown);
            // 
            // estadoCombo
            // 
            this.estadoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoCombo.FormattingEnabled = true;
            this.estadoCombo.Items.AddRange(new object[] {
            "TODOS",
            "ACTIVO",
            "INACTIVO"});
            this.estadoCombo.Location = new System.Drawing.Point(430, 69);
            this.estadoCombo.Name = "estadoCombo";
            this.estadoCombo.Size = new System.Drawing.Size(99, 21);
            this.estadoCombo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Servicio:";
            // 
            // servicioCombo
            // 
            this.servicioCombo.AutoCompleteCustomSource.AddRange(new string[] {
            "Todos"});
            this.servicioCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.servicioCombo.FormattingEnabled = true;
            this.servicioCombo.Items.AddRange(new object[] {
            "Todos"});
            this.servicioCombo.Location = new System.Drawing.Point(252, 70);
            this.servicioCombo.Name = "servicioCombo";
            this.servicioCombo.Size = new System.Drawing.Size(99, 21);
            this.servicioCombo.TabIndex = 6;
            this.servicioCombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.servicioCombo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Estado:";
            // 
            // tiposServicioBindingSource
            // 
            this.tiposServicioBindingSource.DataMember = "Tipos_Servicio";
            this.tiposServicioBindingSource.DataSource = this.gD2C2015DataSetBindingSource;
            // 
            // tipos_ServicioTableAdapter
            // 
            this.tipos_ServicioTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.limpiarButton);
            this.groupBox1.Controls.Add(this.Buscar);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 129);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // limpiarButton
            // 
            this.limpiarButton.Location = new System.Drawing.Point(6, 98);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(75, 23);
            this.limpiarButton.TabIndex = 9;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Click += new System.EventHandler(this.limpiarButton_Click);
            // 
            // modificarButton
            // 
            this.modificarButton.Location = new System.Drawing.Point(369, 317);
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(105, 45);
            this.modificarButton.TabIndex = 22;
            this.modificarButton.Text = "Modificar";
            this.modificarButton.UseVisualStyleBackColor = true;
            this.modificarButton.Click += new System.EventHandler(this.modificarButton_Click);
            // 
            // AeronavesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 389);
            this.Controls.Add(this.modificarButton);
            this.Controls.Add(this.servicioCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.precioKgHasta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.precioKgDesde);
            this.Controls.Add(this.estadoCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fabricanteBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modeloBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MatriculaBox);
            this.Controls.Add(this.Matricula);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BajaDef);
            this.Controls.Add(this.FueraServicio);
            this.Controls.Add(this.Alta);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AeronavesForm";
            this.Text = "Aeronaves";
            this.Load += new System.EventHandler(this.AeronavesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeronavesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposServicioBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox modeloBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fabricanteBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox precioKgHasta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox precioKgDesde;
        private System.Windows.Forms.ComboBox estadoCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox servicioCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource tiposServicioBindingSource;
        private GD2C2015DataSetTableAdapters.Tipos_ServicioTableAdapter tipos_ServicioTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.Button modificarButton;
    }
}