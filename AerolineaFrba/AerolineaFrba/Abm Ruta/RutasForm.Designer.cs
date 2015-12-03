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
            this.descripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.limpiar = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            this.rutasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2015DataSet = new AerolineaFrba.GD2C2015DataSet();
            this.rutasTableAdapter = new AerolineaFrba.GD2C2015DataSetTableAdapters.RutasTableAdapter();
            this.rutidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutcodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadorigenidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudad_origen_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudaddestinoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudad_destino_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutpreciobasekgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutpreciobasepasajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rut_activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // carga
            // 
            this.carga.Location = new System.Drawing.Point(440, 12);
            this.carga.Name = "carga";
            this.carga.Size = new System.Drawing.Size(115, 23);
            this.carga.TabIndex = 3;
            this.carga.Text = "Cargar nuevo";
            this.carga.UseVisualStyleBackColor = true;
            this.carga.Click += new System.EventHandler(this.carga_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.descripcion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.limpiar);
            this.groupBox1.Controls.Add(this.buscar);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 84);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de busqueda";
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(78, 23);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(100, 20);
            this.descripcion.TabIndex = 3;
            this.descripcion.TextChanged += new System.EventHandler(this.descripcion_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(7, 54);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 1;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click_1);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(462, 54);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 0;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click_1);
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(12, 271);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 23);
            this.eliminar.TabIndex = 6;
            this.eliminar.Text = "Inhabilitar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click_1);
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(480, 271);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(75, 23);
            this.modificar.TabIndex = 7;
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
            this.data.Location = new System.Drawing.Point(12, 131);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Size = new System.Drawing.Size(543, 134);
            this.data.TabIndex = 5;
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
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
            // RutasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 314);
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
    }
}