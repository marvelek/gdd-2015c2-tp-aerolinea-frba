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
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2015DataSet = new AerolineaFrba.GD2C2015DataSet();
            this.productosTableAdapter = new AerolineaFrba.GD2C2015DataSetTableAdapters.ProductosTableAdapter();
            this.proidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procantidadmillasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prostockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canjear = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.historialMillasTableAdapter1 = new AerolineaFrba.GD2C2015DataSetTableAdapters.historialMillasTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.clientesTableAdapter1 = new AerolineaFrba.GD2C2015DataSetTableAdapters.ClientesTableAdapter();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.apellidoLabel = new System.Windows.Forms.Label();
            this.millasLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productosGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DNI:";
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(98, 36);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(110, 20);
            this.dni.TabIndex = 3;
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
            this.canjear});
            this.productosGrid.DataSource = this.productosBindingSource;
            this.productosGrid.Location = new System.Drawing.Point(33, 153);
            this.productosGrid.Name = "productosGrid";
            this.productosGrid.Size = new System.Drawing.Size(545, 150);
            this.productosGrid.TabIndex = 4;
            this.productosGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // 
            // procantidadmillasDataGridViewTextBoxColumn
            // 
            this.procantidadmillasDataGridViewTextBoxColumn.DataPropertyName = "pro_cantidad_millas";
            this.procantidadmillasDataGridViewTextBoxColumn.HeaderText = "Millas requeridas";
            this.procantidadmillasDataGridViewTextBoxColumn.Name = "procantidadmillasDataGridViewTextBoxColumn";
            // 
            // prostockDataGridViewTextBoxColumn
            // 
            this.prostockDataGridViewTextBoxColumn.DataPropertyName = "pro_stock";
            this.prostockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.prostockDataGridViewTextBoxColumn.Name = "prostockDataGridViewTextBoxColumn";
            // 
            // canjear
            // 
            this.canjear.HeaderText = "Canjear";
            this.canjear.Name = "canjear";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cantidad:";
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(534, 107);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(35, 20);
            this.cantidad.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Validar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 98);
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
            this.label5.Location = new System.Drawing.Point(40, 125);
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
            this.nombreLabel.Location = new System.Drawing.Point(95, 70);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(0, 13);
            this.nombreLabel.TabIndex = 13;
            // 
            // apellidoLabel
            // 
            this.apellidoLabel.AutoSize = true;
            this.apellidoLabel.Location = new System.Drawing.Point(93, 98);
            this.apellidoLabel.Name = "apellidoLabel";
            this.apellidoLabel.Size = new System.Drawing.Size(0, 13);
            this.apellidoLabel.TabIndex = 14;
            // 
            // millasLabel
            // 
            this.millasLabel.AutoSize = true;
            this.millasLabel.Location = new System.Drawing.Point(93, 125);
            this.millasLabel.Name = "millasLabel";
            this.millasLabel.Size = new System.Drawing.Size(0, 13);
            this.millasLabel.TabIndex = 15;
            // 
            // CanjeMillasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 354);
            this.Controls.Add(this.millasLabel);
            this.Controls.Add(this.apellidoLabel);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.productosGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dni);
            this.Name = "CanjeMillasForm";
            this.Text = "Canje de Millas";
            this.Load += new System.EventHandler(this.CanjeMillasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productosGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.DataGridView productosGrid;
        private GD2C2015DataSet gD2C2015DataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private GD2C2015DataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn proidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procantidadmillasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prostockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn canjear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private GD2C2015DataSetTableAdapters.historialMillasTableAdapter historialMillasTableAdapter1;
        private System.Windows.Forms.Label label5;
        private GD2C2015DataSetTableAdapters.ClientesTableAdapter clientesTableAdapter1;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label apellidoLabel;
        private System.Windows.Forms.Label millasLabel;
    }
}