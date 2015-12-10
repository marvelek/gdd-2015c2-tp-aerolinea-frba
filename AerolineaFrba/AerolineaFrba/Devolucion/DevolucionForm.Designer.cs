namespace AerolineaFrba.Devolucion
{
    partial class DevolucionForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grillaVenta = new System.Windows.Forms.DataGridView();
            this.venidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compradoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vueloidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venfechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagotarjetaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venactivoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2015DataSet = new AerolineaFrba.GD2C2015DataSet();
            this.ventasTableAdapter = new AerolineaFrba.GD2C2015DataSetTableAdapters.VentasTableAdapter();
            this.grillaPaquete = new System.Windows.Forms.DataGridView();
            this.paqidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devolucionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paqcodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paqprecioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paqkgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paqactivoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.paquetesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paquetesTableAdapter = new AerolineaFrba.GD2C2015DataSetTableAdapters.PaquetesTableAdapter();
            this.grillaPasaje = new System.Windows.Forms.DataGridView();
            this.pasidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasajeroidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devolucionidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventaidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butacaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pascodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasprecioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasactivoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pasajesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pasajesTableAdapter = new AerolineaFrba.GD2C2015DataSetTableAdapters.PasajesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPaquete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paquetesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPasaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.codigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(489, 111);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Limpiar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(136, 78);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(100, 20);
            this.codigo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de devolución:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "VENTAS",
            "PAQUETES",
            "PASAJES"});
            this.comboBox1.Location = new System.Drawing.Point(136, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // grillaVenta
            // 
            this.grillaVenta.AllowUserToAddRows = false;
            this.grillaVenta.AllowUserToDeleteRows = false;
            this.grillaVenta.AutoGenerateColumns = false;
            this.grillaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.venidDataGridViewTextBoxColumn,
            this.compradoridDataGridViewTextBoxColumn,
            this.vueloidDataGridViewTextBoxColumn,
            this.venfechaDataGridViewTextBoxColumn,
            this.pagotarjetaidDataGridViewTextBoxColumn,
            this.venactivoDataGridViewCheckBoxColumn});
            this.grillaVenta.DataSource = this.ventasBindingSource;
            this.grillaVenta.Location = new System.Drawing.Point(35, 180);
            this.grillaVenta.Name = "grillaVenta";
            this.grillaVenta.ReadOnly = true;
            this.grillaVenta.Size = new System.Drawing.Size(541, 150);
            this.grillaVenta.TabIndex = 5;
            // 
            // venidDataGridViewTextBoxColumn
            // 
            this.venidDataGridViewTextBoxColumn.DataPropertyName = "ven_id";
            this.venidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.venidDataGridViewTextBoxColumn.Name = "venidDataGridViewTextBoxColumn";
            this.venidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // compradoridDataGridViewTextBoxColumn
            // 
            this.compradoridDataGridViewTextBoxColumn.DataPropertyName = "comprador_id";
            this.compradoridDataGridViewTextBoxColumn.HeaderText = "Comprador Id";
            this.compradoridDataGridViewTextBoxColumn.Name = "compradoridDataGridViewTextBoxColumn";
            this.compradoridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vueloidDataGridViewTextBoxColumn
            // 
            this.vueloidDataGridViewTextBoxColumn.DataPropertyName = "vuelo_id";
            this.vueloidDataGridViewTextBoxColumn.HeaderText = "Vuelo ID";
            this.vueloidDataGridViewTextBoxColumn.Name = "vueloidDataGridViewTextBoxColumn";
            this.vueloidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // venfechaDataGridViewTextBoxColumn
            // 
            this.venfechaDataGridViewTextBoxColumn.DataPropertyName = "ven_fecha";
            this.venfechaDataGridViewTextBoxColumn.HeaderText = "Fecha de Venta";
            this.venfechaDataGridViewTextBoxColumn.Name = "venfechaDataGridViewTextBoxColumn";
            this.venfechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pagotarjetaidDataGridViewTextBoxColumn
            // 
            this.pagotarjetaidDataGridViewTextBoxColumn.DataPropertyName = "pago_tarjeta_id";
            this.pagotarjetaidDataGridViewTextBoxColumn.HeaderText = "pago_tarjeta_id";
            this.pagotarjetaidDataGridViewTextBoxColumn.Name = "pagotarjetaidDataGridViewTextBoxColumn";
            this.pagotarjetaidDataGridViewTextBoxColumn.ReadOnly = true;
            this.pagotarjetaidDataGridViewTextBoxColumn.Visible = false;
            // 
            // venactivoDataGridViewCheckBoxColumn
            // 
            this.venactivoDataGridViewCheckBoxColumn.DataPropertyName = "ven_activo";
            this.venactivoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.venactivoDataGridViewCheckBoxColumn.Name = "venactivoDataGridViewCheckBoxColumn";
            this.venactivoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataMember = "Ventas";
            this.ventasBindingSource.DataSource = this.gD2C2015DataSet;
            // 
            // gD2C2015DataSet
            // 
            this.gD2C2015DataSet.DataSetName = "GD2C2015DataSet";
            this.gD2C2015DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ventasTableAdapter
            // 
            this.ventasTableAdapter.ClearBeforeFill = true;
            // 
            // grillaPaquete
            // 
            this.grillaPaquete.AllowUserToAddRows = false;
            this.grillaPaquete.AllowUserToDeleteRows = false;
            this.grillaPaquete.AutoGenerateColumns = false;
            this.grillaPaquete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaPaquete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paqidDataGridViewTextBoxColumn,
            this.devolucionidDataGridViewTextBoxColumn,
            this.ventaidDataGridViewTextBoxColumn,
            this.paqcodigoDataGridViewTextBoxColumn,
            this.paqprecioDataGridViewTextBoxColumn,
            this.paqkgDataGridViewTextBoxColumn,
            this.paqactivoDataGridViewCheckBoxColumn});
            this.grillaPaquete.DataSource = this.paquetesBindingSource;
            this.grillaPaquete.Location = new System.Drawing.Point(12, 180);
            this.grillaPaquete.Name = "grillaPaquete";
            this.grillaPaquete.ReadOnly = true;
            this.grillaPaquete.Size = new System.Drawing.Size(586, 150);
            this.grillaPaquete.TabIndex = 5;
            // 
            // paqidDataGridViewTextBoxColumn
            // 
            this.paqidDataGridViewTextBoxColumn.DataPropertyName = "paq_id";
            this.paqidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.paqidDataGridViewTextBoxColumn.Name = "paqidDataGridViewTextBoxColumn";
            this.paqidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // devolucionidDataGridViewTextBoxColumn
            // 
            this.devolucionidDataGridViewTextBoxColumn.DataPropertyName = "devolucion_id";
            this.devolucionidDataGridViewTextBoxColumn.HeaderText = "Devolucion";
            this.devolucionidDataGridViewTextBoxColumn.Name = "devolucionidDataGridViewTextBoxColumn";
            this.devolucionidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ventaidDataGridViewTextBoxColumn
            // 
            this.ventaidDataGridViewTextBoxColumn.DataPropertyName = "venta_id";
            this.ventaidDataGridViewTextBoxColumn.HeaderText = "Id Venta";
            this.ventaidDataGridViewTextBoxColumn.Name = "ventaidDataGridViewTextBoxColumn";
            this.ventaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paqcodigoDataGridViewTextBoxColumn
            // 
            this.paqcodigoDataGridViewTextBoxColumn.DataPropertyName = "paq_codigo";
            this.paqcodigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.paqcodigoDataGridViewTextBoxColumn.Name = "paqcodigoDataGridViewTextBoxColumn";
            this.paqcodigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paqprecioDataGridViewTextBoxColumn
            // 
            this.paqprecioDataGridViewTextBoxColumn.DataPropertyName = "paq_precio";
            this.paqprecioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.paqprecioDataGridViewTextBoxColumn.Name = "paqprecioDataGridViewTextBoxColumn";
            this.paqprecioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paqkgDataGridViewTextBoxColumn
            // 
            this.paqkgDataGridViewTextBoxColumn.DataPropertyName = "paq_kg";
            this.paqkgDataGridViewTextBoxColumn.HeaderText = "Kg";
            this.paqkgDataGridViewTextBoxColumn.Name = "paqkgDataGridViewTextBoxColumn";
            this.paqkgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paqactivoDataGridViewCheckBoxColumn
            // 
            this.paqactivoDataGridViewCheckBoxColumn.DataPropertyName = "paq_activo";
            this.paqactivoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.paqactivoDataGridViewCheckBoxColumn.Name = "paqactivoDataGridViewCheckBoxColumn";
            this.paqactivoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // paquetesBindingSource
            // 
            this.paquetesBindingSource.DataMember = "Paquetes";
            this.paquetesBindingSource.DataSource = this.gD2C2015DataSet;
            // 
            // paquetesTableAdapter
            // 
            this.paquetesTableAdapter.ClearBeforeFill = true;
            // 
            // grillaPasaje
            // 
            this.grillaPasaje.AllowUserToAddRows = false;
            this.grillaPasaje.AllowUserToDeleteRows = false;
            this.grillaPasaje.AutoGenerateColumns = false;
            this.grillaPasaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaPasaje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pasidDataGridViewTextBoxColumn,
            this.pasajeroidDataGridViewTextBoxColumn,
            this.devolucionidDataGridViewTextBoxColumn1,
            this.ventaidDataGridViewTextBoxColumn1,
            this.butacaidDataGridViewTextBoxColumn,
            this.pascodigoDataGridViewTextBoxColumn,
            this.pasprecioDataGridViewTextBoxColumn,
            this.pasactivoDataGridViewCheckBoxColumn});
            this.grillaPasaje.DataSource = this.pasajesBindingSource;
            this.grillaPasaje.Location = new System.Drawing.Point(12, 180);
            this.grillaPasaje.Name = "grillaPasaje";
            this.grillaPasaje.ReadOnly = true;
            this.grillaPasaje.Size = new System.Drawing.Size(590, 150);
            this.grillaPasaje.TabIndex = 5;
            this.grillaPasaje.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaPasaje_CellContentClick);
            // 
            // pasidDataGridViewTextBoxColumn
            // 
            this.pasidDataGridViewTextBoxColumn.DataPropertyName = "pas_id";
            this.pasidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.pasidDataGridViewTextBoxColumn.Name = "pasidDataGridViewTextBoxColumn";
            this.pasidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pasajeroidDataGridViewTextBoxColumn
            // 
            this.pasajeroidDataGridViewTextBoxColumn.DataPropertyName = "pasajero_id";
            this.pasajeroidDataGridViewTextBoxColumn.HeaderText = "Pasajero";
            this.pasajeroidDataGridViewTextBoxColumn.Name = "pasajeroidDataGridViewTextBoxColumn";
            this.pasajeroidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // devolucionidDataGridViewTextBoxColumn1
            // 
            this.devolucionidDataGridViewTextBoxColumn1.DataPropertyName = "devolucion_id";
            this.devolucionidDataGridViewTextBoxColumn1.HeaderText = "Devolucion";
            this.devolucionidDataGridViewTextBoxColumn1.Name = "devolucionidDataGridViewTextBoxColumn1";
            this.devolucionidDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ventaidDataGridViewTextBoxColumn1
            // 
            this.ventaidDataGridViewTextBoxColumn1.DataPropertyName = "venta_id";
            this.ventaidDataGridViewTextBoxColumn1.HeaderText = "Venta";
            this.ventaidDataGridViewTextBoxColumn1.Name = "ventaidDataGridViewTextBoxColumn1";
            this.ventaidDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // butacaidDataGridViewTextBoxColumn
            // 
            this.butacaidDataGridViewTextBoxColumn.DataPropertyName = "butaca_id";
            this.butacaidDataGridViewTextBoxColumn.HeaderText = "Butaca";
            this.butacaidDataGridViewTextBoxColumn.Name = "butacaidDataGridViewTextBoxColumn";
            this.butacaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pascodigoDataGridViewTextBoxColumn
            // 
            this.pascodigoDataGridViewTextBoxColumn.DataPropertyName = "pas_codigo";
            this.pascodigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.pascodigoDataGridViewTextBoxColumn.Name = "pascodigoDataGridViewTextBoxColumn";
            this.pascodigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pasprecioDataGridViewTextBoxColumn
            // 
            this.pasprecioDataGridViewTextBoxColumn.DataPropertyName = "pas_precio";
            this.pasprecioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.pasprecioDataGridViewTextBoxColumn.Name = "pasprecioDataGridViewTextBoxColumn";
            this.pasprecioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pasactivoDataGridViewCheckBoxColumn
            // 
            this.pasactivoDataGridViewCheckBoxColumn.DataPropertyName = "pas_activo";
            this.pasactivoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.pasactivoDataGridViewCheckBoxColumn.Name = "pasactivoDataGridViewCheckBoxColumn";
            this.pasactivoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // pasajesBindingSource
            // 
            this.pasajesBindingSource.DataMember = "Pasajes";
            this.pasajesBindingSource.DataSource = this.gD2C2015DataSet;
            // 
            // pasajesTableAdapter
            // 
            this.pasajesTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ver Cancelación";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar / Devolver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DevolucionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 386);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grillaPasaje);
            this.Controls.Add(this.grillaPaquete);
            this.Controls.Add(this.grillaVenta);
            this.Controls.Add(this.groupBox1);
            this.Name = "DevolucionForm";
            this.Text = "Cancelación / Devolución";
            this.Load += new System.EventHandler(this.DevolucionForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPaquete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paquetesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPasaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView grillaVenta;
        private GD2C2015DataSet gD2C2015DataSet;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private GD2C2015DataSetTableAdapters.VentasTableAdapter ventasTableAdapter;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grillaPaquete;
        private System.Windows.Forms.BindingSource paquetesBindingSource;
        private GD2C2015DataSetTableAdapters.PaquetesTableAdapter paquetesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn paqidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devolucionidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paqcodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paqprecioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paqkgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn paqactivoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridView grillaPasaje;
        private System.Windows.Forms.BindingSource pasajesBindingSource;
        private GD2C2015DataSetTableAdapters.PasajesTableAdapter pasajesTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn pasidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pasajeroidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devolucionidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventaidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn butacaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pascodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pasprecioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pasactivoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compradoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vueloidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venfechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagotarjetaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn venactivoDataGridViewCheckBoxColumn;
    }
}