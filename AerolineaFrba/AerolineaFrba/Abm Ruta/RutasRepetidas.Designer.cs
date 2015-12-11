namespace AerolineaFrba.Abm_Ruta
{
    partial class RutasRepetidas
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rutasRepetidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2015DataSet = new AerolineaFrba.GD2C2015DataSet();
            this.rutasRepetidasTableAdapter = new AerolineaFrba.GD2C2015DataSetTableAdapters.rutasRepetidasTableAdapter();
            this.rutidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutcodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadorigenidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadorigenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudaddestinoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudaddestinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_nuevo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutasRepetidasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 104);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADVERTENCIA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(422, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Si sale de esta pantalla sin confirmar, no podrá insertar o modificar rutas.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "de forma automática.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hay rutas con código repetidos. Se le asignarán los siguientes códigos ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rutidDataGridViewTextBoxColumn,
            this.rutcodigoDataGridViewTextBoxColumn,
            this.ciudadorigenidDataGridViewTextBoxColumn,
            this.ciudadorigenDataGridViewTextBoxColumn,
            this.ciudaddestinoidDataGridViewTextBoxColumn,
            this.ciudaddestinoDataGridViewTextBoxColumn,
            this.codigo_nuevo});
            this.dataGridView1.DataSource = this.rutasRepetidasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 163);
            this.dataGridView1.TabIndex = 2;
            // 
            // rutasRepetidasBindingSource
            // 
            this.rutasRepetidasBindingSource.DataMember = "rutasRepetidas";
            this.rutasRepetidasBindingSource.DataSource = this.gD2C2015DataSet;
            // 
            // gD2C2015DataSet
            // 
            this.gD2C2015DataSet.DataSetName = "GD2C2015DataSet";
            this.gD2C2015DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rutasRepetidasTableAdapter
            // 
            this.rutasRepetidasTableAdapter.ClearBeforeFill = true;
            // 
            // rutidDataGridViewTextBoxColumn
            // 
            this.rutidDataGridViewTextBoxColumn.DataPropertyName = "rut_id";
            this.rutidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.rutidDataGridViewTextBoxColumn.Name = "rutidDataGridViewTextBoxColumn";
            this.rutidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rutcodigoDataGridViewTextBoxColumn
            // 
            this.rutcodigoDataGridViewTextBoxColumn.DataPropertyName = "rut_codigo";
            this.rutcodigoDataGridViewTextBoxColumn.HeaderText = "CODIGO ANTERIOR";
            this.rutcodigoDataGridViewTextBoxColumn.Name = "rutcodigoDataGridViewTextBoxColumn";
            // 
            // ciudadorigenidDataGridViewTextBoxColumn
            // 
            this.ciudadorigenidDataGridViewTextBoxColumn.DataPropertyName = "ciudad_origen_id";
            this.ciudadorigenidDataGridViewTextBoxColumn.HeaderText = "ciudad_origen_id";
            this.ciudadorigenidDataGridViewTextBoxColumn.Name = "ciudadorigenidDataGridViewTextBoxColumn";
            this.ciudadorigenidDataGridViewTextBoxColumn.Visible = false;
            // 
            // ciudadorigenDataGridViewTextBoxColumn
            // 
            this.ciudadorigenDataGridViewTextBoxColumn.DataPropertyName = "ciudad_origen";
            this.ciudadorigenDataGridViewTextBoxColumn.HeaderText = "CIUDAD ORIGEN";
            this.ciudadorigenDataGridViewTextBoxColumn.Name = "ciudadorigenDataGridViewTextBoxColumn";
            // 
            // ciudaddestinoidDataGridViewTextBoxColumn
            // 
            this.ciudaddestinoidDataGridViewTextBoxColumn.DataPropertyName = "ciudad_destino_id";
            this.ciudaddestinoidDataGridViewTextBoxColumn.HeaderText = "ciudad_destino_id";
            this.ciudaddestinoidDataGridViewTextBoxColumn.Name = "ciudaddestinoidDataGridViewTextBoxColumn";
            this.ciudaddestinoidDataGridViewTextBoxColumn.Visible = false;
            // 
            // ciudaddestinoDataGridViewTextBoxColumn
            // 
            this.ciudaddestinoDataGridViewTextBoxColumn.DataPropertyName = "ciudad_destino";
            this.ciudaddestinoDataGridViewTextBoxColumn.HeaderText = "CIUDAD DESTINO";
            this.ciudaddestinoDataGridViewTextBoxColumn.Name = "ciudaddestinoDataGridViewTextBoxColumn";
            // 
            // codigo_nuevo
            // 
            this.codigo_nuevo.DataPropertyName = "codigo_nuevo";
            this.codigo_nuevo.HeaderText = "CODIGO NUEVO";
            this.codigo_nuevo.Name = "codigo_nuevo";
            this.codigo_nuevo.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "ACEPTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RutasRepetidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 362);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "RutasRepetidas";
            this.Text = "Rutas Repetidas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutasRepetidasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GD2C2015DataSet gD2C2015DataSet;
        private System.Windows.Forms.BindingSource rutasRepetidasBindingSource;
        private GD2C2015DataSetTableAdapters.rutasRepetidasTableAdapter rutasRepetidasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutcodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadorigenidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadorigenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudaddestinoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudaddestinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_nuevo;
        private System.Windows.Forms.Button button1;
    }
}