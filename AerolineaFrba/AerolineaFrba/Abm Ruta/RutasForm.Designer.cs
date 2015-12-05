namespace AerolineaFrba.Abm_Ruta
{
    partial class RutasForm
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
            this.carga = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.precioBaseHasta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.precioBaseDesde = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.precioKgHasta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.precioKgDesde = new System.Windows.Forms.TextBox();
            this.ciudadDestino = new System.Windows.Forms.TextBox();
            this.ciudadOrigen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.limpiar = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            this.rutidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutcodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadorigenidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudad_origen_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudaddestinoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudad_destino_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutpreciobasekgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutpreciobasepasajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rut_activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rutasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2015DataSet = new AerolineaFrba.GD2C2015DataSet();
            this.rutasTableAdapter = new AerolineaFrba.GD2C2015DataSetTableAdapters.RutasTableAdapter();
            this.ciudadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ciudadesTableAdapter = new AerolineaFrba.GD2C2015DataSetTableAdapters.CiudadesTableAdapter();
            this.ciudadesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // carga
            // 
            this.carga.Location = new System.Drawing.Point(440, 12);
            this.carga.Name = "carga";
            this.carga.Size = new System.Drawing.Size(115, 23);
            this.carga.TabIndex = 1;
            this.carga.Text = "Cargar nuevo";
            this.carga.UseVisualStyleBackColor = true;
            this.carga.Click += new System.EventHandler(this.carga_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.precioBaseHasta);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.precioBaseDesde);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.precioKgHasta);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.precioKgDesde);
            this.groupBox1.Controls.Add(this.ciudadDestino);
            this.groupBox1.Controls.Add(this.ciudadOrigen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.descripcion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.limpiar);
            this.groupBox1.Controls.Add(this.buscar);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 170);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de busqueda";
            // 
            // precioBaseHasta
            // 
            this.precioBaseHasta.Location = new System.Drawing.Point(266, 106);
            this.precioBaseHasta.Name = "precioBaseHasta";
            this.precioBaseHasta.Size = new System.Drawing.Size(100, 20);
            this.precioBaseHasta.TabIndex = 9;
            this.precioBaseHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precioBaseHasta_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Y";
            // 
            // precioBaseDesde
            // 
            this.precioBaseDesde.Location = new System.Drawing.Point(123, 109);
            this.precioBaseDesde.Name = "precioBaseDesde";
            this.precioBaseDesde.Size = new System.Drawing.Size(100, 20);
            this.precioBaseDesde.TabIndex = 8;
            this.precioBaseDesde.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.precioBaseDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precioBaseDesde_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Precio Base Entre";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // precioKgHasta
            // 
            this.precioKgHasta.Location = new System.Drawing.Point(266, 76);
            this.precioKgHasta.Name = "precioKgHasta";
            this.precioKgHasta.Size = new System.Drawing.Size(100, 20);
            this.precioKgHasta.TabIndex = 7;
            this.precioKgHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precioKgHasta_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Precio Kg Entre ";
            // 
            // precioKgDesde
            // 
            this.precioKgDesde.Location = new System.Drawing.Point(123, 79);
            this.precioKgDesde.Name = "precioKgDesde";
            this.precioKgDesde.Size = new System.Drawing.Size(100, 20);
            this.precioKgDesde.TabIndex = 6;
            this.precioKgDesde.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.precioKgDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precioKgDesde_KeyPress);
            // 
            // ciudadDestino
            // 
            this.ciudadDestino.Location = new System.Drawing.Point(351, 49);
            this.ciudadDestino.Name = "ciudadDestino";
            this.ciudadDestino.Size = new System.Drawing.Size(100, 20);
            this.ciudadDestino.TabIndex = 5;
            // 
            // ciudadOrigen
            // 
            this.ciudadOrigen.Location = new System.Drawing.Point(123, 49);
            this.ciudadOrigen.Name = "ciudadOrigen";
            this.ciudadOrigen.Size = new System.Drawing.Size(100, 20);
            this.ciudadOrigen.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ciudad Destino:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ciudad Origen:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "TODOS",
            "ACTIVO",
            "INACTIVO"});
            this.comboBox1.Location = new System.Drawing.Point(351, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Estado:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(123, 19);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(100, 20);
            this.descripcion.TabIndex = 2;
            this.descripcion.TextChanged += new System.EventHandler(this.descripcion_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(6, 141);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 10;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click_1);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(461, 141);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 11;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click_1);
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(12, 358);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 23);
            this.eliminar.TabIndex = 13;
            this.eliminar.Text = "Inhabilitar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click_1);
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(480, 358);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(75, 23);
            this.modificar.TabIndex = 14;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.AutoGenerateColumns = false;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rutidDataGridViewTextBoxColumn,
            this.rutcodigoDataGridViewTextBoxColumn,
            this.ciudadorigenidDataGridViewTextBoxColumn,
            this.ciudad_origen_desc,
            this.ciudaddestinoidDataGridViewTextBoxColumn,
            this.ciudad_destino_desc,
            this.rutpreciobasekgDataGridViewTextBoxColumn,
            this.rutpreciobasepasajeDataGridViewTextBoxColumn,
            this.rut_activo});
            this.data.DataSource = this.rutasBindingSource;
            this.data.Location = new System.Drawing.Point(12, 218);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Size = new System.Drawing.Size(543, 134);
            this.data.TabIndex = 12;
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
            // 
            // rutidDataGridViewTextBoxColumn
            // 
            this.rutidDataGridViewTextBoxColumn.DataPropertyName = "rut_id";
            this.rutidDataGridViewTextBoxColumn.HeaderText = "Id";
            this.rutidDataGridViewTextBoxColumn.Name = "rutidDataGridViewTextBoxColumn";
            this.rutidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rutcodigoDataGridViewTextBoxColumn
            // 
            this.rutcodigoDataGridViewTextBoxColumn.DataPropertyName = "rut_codigo";
            this.rutcodigoDataGridViewTextBoxColumn.HeaderText = "Código de Ruta";
            this.rutcodigoDataGridViewTextBoxColumn.Name = "rutcodigoDataGridViewTextBoxColumn";
            this.rutcodigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ciudadorigenidDataGridViewTextBoxColumn
            // 
            this.ciudadorigenidDataGridViewTextBoxColumn.DataPropertyName = "ciudad_origen_id";
            this.ciudadorigenidDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ciudadorigenidDataGridViewTextBoxColumn.Name = "ciudadorigenidDataGridViewTextBoxColumn";
            this.ciudadorigenidDataGridViewTextBoxColumn.ReadOnly = true;
            this.ciudadorigenidDataGridViewTextBoxColumn.Visible = false;
            // 
            // ciudad_origen_desc
            // 
            this.ciudad_origen_desc.DataPropertyName = "ciudad_origen_desc";
            this.ciudad_origen_desc.HeaderText = "Ciudad Origen";
            this.ciudad_origen_desc.Name = "ciudad_origen_desc";
            this.ciudad_origen_desc.ReadOnly = true;
            // 
            // ciudaddestinoidDataGridViewTextBoxColumn
            // 
            this.ciudaddestinoidDataGridViewTextBoxColumn.DataPropertyName = "ciudad_destino_id";
            this.ciudaddestinoidDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ciudaddestinoidDataGridViewTextBoxColumn.Name = "ciudaddestinoidDataGridViewTextBoxColumn";
            this.ciudaddestinoidDataGridViewTextBoxColumn.ReadOnly = true;
            this.ciudaddestinoidDataGridViewTextBoxColumn.Visible = false;
            // 
            // ciudad_destino_desc
            // 
            this.ciudad_destino_desc.DataPropertyName = "ciudad_destino_desc";
            this.ciudad_destino_desc.HeaderText = "Ciudad Destino";
            this.ciudad_destino_desc.Name = "ciudad_destino_desc";
            this.ciudad_destino_desc.ReadOnly = true;
            // 
            // rutpreciobasekgDataGridViewTextBoxColumn
            // 
            this.rutpreciobasekgDataGridViewTextBoxColumn.DataPropertyName = "rut_precio_base_kg";
            this.rutpreciobasekgDataGridViewTextBoxColumn.HeaderText = "Precio Base Kg";
            this.rutpreciobasekgDataGridViewTextBoxColumn.Name = "rutpreciobasekgDataGridViewTextBoxColumn";
            this.rutpreciobasekgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rutpreciobasepasajeDataGridViewTextBoxColumn
            // 
            this.rutpreciobasepasajeDataGridViewTextBoxColumn.DataPropertyName = "rut_precio_base_pasaje";
            this.rutpreciobasepasajeDataGridViewTextBoxColumn.HeaderText = "Precio Base Pasaje";
            this.rutpreciobasepasajeDataGridViewTextBoxColumn.Name = "rutpreciobasepasajeDataGridViewTextBoxColumn";
            this.rutpreciobasepasajeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rut_activo
            // 
            this.rut_activo.DataPropertyName = "rut_activo";
            this.rut_activo.HeaderText = "Activo";
            this.rut_activo.Name = "rut_activo";
            this.rut_activo.ReadOnly = true;
            // 
            // rutasBindingSource
            // 
            this.rutasBindingSource.DataMember = "Rutas";
            this.rutasBindingSource.DataSource = this.gD2C2015DataSet;
            // 
            // gD2C2015DataSet
            // 
            this.gD2C2015DataSet.DataSetName = "GD2C2015DataSet";
            this.gD2C2015DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rutasTableAdapter
            // 
            this.rutasTableAdapter.ClearBeforeFill = true;
            // 
            // ciudadesBindingSource
            // 
            this.ciudadesBindingSource.DataMember = "Ciudades";
            this.ciudadesBindingSource.DataSource = this.gD2C2015DataSet;
            // 
            // ciudadesTableAdapter
            // 
            this.ciudadesTableAdapter.ClearBeforeFill = true;
            // 
            // ciudadesBindingSource1
            // 
            this.ciudadesBindingSource1.DataMember = "Ciudades";
            this.ciudadesBindingSource1.DataSource = this.gD2C2015DataSet;
            // 
            // RutasForm
            // 
            this.AcceptButton = this.buscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 396);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.data);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.carga);
            this.Name = "RutasForm";
            this.Text = "Rutas";
            this.Load += new System.EventHandler(this.RutasForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button carga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button modificar;
        private GD2C2015DataSet gD2C2015DataSet;
        private System.Windows.Forms.BindingSource rutasBindingSource;
        private GD2C2015DataSetTableAdapters.RutasTableAdapter rutasTableAdapter;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutcodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadorigenidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudad_origen_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudaddestinoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudad_destino_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutpreciobasekgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutpreciobasepasajeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rut_activo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource ciudadesBindingSource;
        private GD2C2015DataSetTableAdapters.CiudadesTableAdapter ciudadesTableAdapter;
        private System.Windows.Forms.BindingSource ciudadesBindingSource1;
        private System.Windows.Forms.TextBox ciudadDestino;
        private System.Windows.Forms.TextBox ciudadOrigen;
        private System.Windows.Forms.TextBox precioBaseHasta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox precioBaseDesde;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox precioKgHasta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox precioKgDesde;
    }
}