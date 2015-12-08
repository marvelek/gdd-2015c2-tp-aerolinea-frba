namespace AerolineaFrba.Devolucion
{
    partial class VistaDevolucionForm
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
            this.Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Motivo = new System.Windows.Forms.Label();
            this.compra = new System.Windows.Forms.TextBox();
            this.codigo = new System.Windows.Forms.TextBox();
            this.motivoData = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.TextBox();
            this.devolucionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2015DataSet = new AerolineaFrba.GD2C2015DataSet();
            this.devolucionesTableAdapter = new AerolineaFrba.GD2C2015DataSetTableAdapters.DevolucionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.devolucionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Devolución:";
            // 
            // Id
            // 
            this.Id.Enabled = false;
            this.Id.Location = new System.Drawing.Point(147, 33);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(118, 20);
            this.Id.TabIndex = 1;
            this.Id.TextChanged += new System.EventHandler(this.Id_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código de Compra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Código de Pasaje:";
            // 
            // Motivo
            // 
            this.Motivo.AutoSize = true;
            this.Motivo.Location = new System.Drawing.Point(22, 209);
            this.Motivo.Name = "Motivo";
            this.Motivo.Size = new System.Drawing.Size(119, 13);
            this.Motivo.TabIndex = 4;
            this.Motivo.Text = "Motivo de Cancelación:";
            this.Motivo.Click += new System.EventHandler(this.Motivo_Click);
            // 
            // compra
            // 
            this.compra.Enabled = false;
            this.compra.Location = new System.Drawing.Point(147, 77);
            this.compra.Name = "compra";
            this.compra.Size = new System.Drawing.Size(118, 20);
            this.compra.TabIndex = 5;
            // 
            // codigo
            // 
            this.codigo.Enabled = false;
            this.codigo.Location = new System.Drawing.Point(147, 121);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(118, 20);
            this.codigo.TabIndex = 6;
            // 
            // motivoData
            // 
            this.motivoData.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.devolucionesBindingSource, "dev_motivo", true));
            this.motivoData.Enabled = false;
            this.motivoData.Location = new System.Drawing.Point(147, 209);
            this.motivoData.Multiline = true;
            this.motivoData.Name = "motivoData";
            this.motivoData.Size = new System.Drawing.Size(180, 93);
            this.motivoData.TabIndex = 7;
            this.motivoData.TextChanged += new System.EventHandler(this.motivoData_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha:";
            // 
            // fecha
            // 
            this.fecha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devolucionesBindingSource, "dev_fecha", true));
            this.fecha.Enabled = false;
            this.fecha.Location = new System.Drawing.Point(147, 165);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(100, 20);
            this.fecha.TabIndex = 9;
            // 
            // devolucionesBindingSource
            // 
            this.devolucionesBindingSource.DataMember = "Devoluciones";
            this.devolucionesBindingSource.DataSource = this.gD2C2015DataSet;
            // 
            // gD2C2015DataSet
            // 
            this.gD2C2015DataSet.DataSetName = "GD2C2015DataSet";
            this.gD2C2015DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // devolucionesTableAdapter
            // 
            this.devolucionesTableAdapter.ClearBeforeFill = true;
            // 
            // VistaDevolucionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 326);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.motivoData);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.compra);
            this.Controls.Add(this.Motivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label1);
            this.Name = "VistaDevolucionForm";
            this.Text = "Devolución";
            this.Load += new System.EventHandler(this.VistaDevolucionForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.devolucionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Motivo;
        private System.Windows.Forms.TextBox compra;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.TextBox motivoData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fecha;
        private GD2C2015DataSet gD2C2015DataSet;
        private System.Windows.Forms.BindingSource devolucionesBindingSource;
        private GD2C2015DataSetTableAdapters.DevolucionesTableAdapter devolucionesTableAdapter;
    }
}