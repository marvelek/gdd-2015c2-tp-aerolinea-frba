namespace AerolineaFrba.Canje_Millas
{
    partial class CanjeMillasForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dni = new System.Windows.Forms.TextBox();
            this.productosGrid = new System.Windows.Forms.DataGridView();
            this.proidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procantidadmillasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prostockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadACanjear = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.canjear = new System.Windows.Forms.DataGridViewButtonColumn();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2015DataSet = new AerolineaFrba.GD2C2015DataSet();
            this.productosTableAdapter = new AerolineaFrba.GD2C2015DataSetTableAdapters.ProductosTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.historialMillasTableAdapter1 = new AerolineaFrba.GD2C2015DataSetTableAdapters.historialMillasTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.clientesTableAdapter1 = new AerolineaFrba.GD2C2015DataSetTableAdapters.ClientesTableAdapter();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.apellidoLabel = new System.Windows.Forms.Label();
            this.millasLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.productosGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DNI:";
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(80, 25);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(110, 20);
            this.dni.TabIndex = 1;
            // 
            // productosGrid
            // 
            this.productosGrid.AllowUserToAddRows = false;
            this.productosGrid.AllowUserToDeleteRows = false;
            this.productosGrid.AutoGenerateColumns = false;
            this.productosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proidDataGridViewTextBoxColumn,
            this.prodescripcionDataGridViewTextBoxColumn,
            this.procantidadmillasDataGridViewTextBoxColumn,
            this.prostockDataGridViewTextBoxColumn,
            this.cantidadACanjear,
            this.canjear});
            this.productosGrid.DataSource = this.productosBindingSource;
            this.productosGrid.Location = new System.Drawing.Point(33, 177);
            this.productosGrid.Name = "productosGrid";
            this.productosGrid.Size = new System.Drawing.Size(643, 150);
            this.productosGrid.TabIndex = 3;
            this.productosGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // proidDataGridViewTextBoxColumn
            // 
            this.proidDataGridViewTextBoxColumn.DataPropertyName = "pro_id";
            this.proidDataGridViewTextBoxColumn.HeaderText = "Id";
            this.proidDataGridViewTextBoxColumn.Name = "proidDataGridViewTextBoxColumn";
            this.proidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodescripcionDataGridViewTextBoxColumn
            // 
            this.prodescripcionDataGridViewTextBoxColumn.DataPropertyName = "pro_descripcion";
            this.prodescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.prodescripcionDataGridViewTextBoxColumn.Name = "prodescripcionDataGridViewTextBoxColumn";
            this.prodescripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // procantidadmillasDataGridViewTextBoxColumn
            // 
            this.procantidadmillasDataGridViewTextBoxColumn.DataPropertyName = "pro_cantidad_millas";
            this.procantidadmillasDataGridViewTextBoxColumn.HeaderText = "Millas requeridas";
            this.procantidadmillasDataGridViewTextBoxColumn.Name = "procantidadmillasDataGridViewTextBoxColumn";
            this.procantidadmillasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prostockDataGridViewTextBoxColumn
            // 
            this.prostockDataGridViewTextBoxColumn.DataPropertyName = "pro_stock";
            this.prostockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.prostockDataGridViewTextBoxColumn.Name = "prostockDataGridViewTextBoxColumn";
            this.prostockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadACanjear
            // 
            this.cantidadACanjear.HeaderText = "Cantidad";
            this.cantidadACanjear.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cantidadACanjear.Name = "cantidadACanjear";
            // 
            // canjear
            // 
            this.canjear.HeaderText = "Canjear";
            this.canjear.Name = "canjear";
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.gD2C2015DataSet;
            // 
            // gD2C2015DataSet
            // 
            this.gD2C2015DataSet.DataSetName = "GD2C2015DataSet";
            this.gD2C2015DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Validar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Apellido:";
            // 
            // historialMillasTableAdapter1
            // 
            this.historialMillasTableAdapter1.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Millas:";
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(74, 21);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(0, 13);
            this.nombreLabel.TabIndex = 13;
            // 
            // apellidoLabel
            // 
            this.apellidoLabel.AutoSize = true;
            this.apellidoLabel.Location = new System.Drawing.Point(72, 49);
            this.apellidoLabel.Name = "apellidoLabel";
            this.apellidoLabel.Size = new System.Drawing.Size(0, 13);
            this.apellidoLabel.TabIndex = 14;
            // 
            // millasLabel
            // 
            this.millasLabel.AutoSize = true;
            this.millasLabel.Location = new System.Drawing.Point(72, 76);
            this.millasLabel.Name = "millasLabel";
            this.millasLabel.Size = new System.Drawing.Size(0, 13);
            this.millasLabel.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dni);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 52);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.millasLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.apellidoLabel);
            this.groupBox2.Controls.Add(this.nombreLabel);
            this.groupBox2.Location = new System.Drawing.Point(33, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 100);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Cliente";
            // 
            // CanjeMillasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 354);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.productosGrid);
            this.Name = "CanjeMillasForm";
            this.Text = "Canje de Millas";
            this.Load += new System.EventHandler(this.CanjeMillasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productosGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.DataGridView productosGrid;
        private GD2C2015DataSet gD2C2015DataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private GD2C2015DataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private GD2C2015DataSetTableAdapters.historialMillasTableAdapter historialMillasTableAdapter1;
        private System.Windows.Forms.Label label5;
        private GD2C2015DataSetTableAdapters.ClientesTableAdapter clientesTableAdapter1;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label apellidoLabel;
        private System.Windows.Forms.Label millasLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn proidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procantidadmillasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prostockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cantidadACanjear;
        private System.Windows.Forms.DataGridViewButtonColumn canjear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}