namespace AerolineaFrba.Abm_Ruta
{
    partial class CargarRutaForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ciudadOrigen = new System.Windows.Forms.ComboBox();
            this.ciudadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2015DataSet = new AerolineaFrba.GD2C2015DataSet();
            this.ciudadDestino = new System.Windows.Forms.ComboBox();
            this.ciudadesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tiposServicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigo = new System.Windows.Forms.TextBox();
            this.precioKg = new System.Windows.Forms.TextBox();
            this.precioBase = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tipos_ServicioTableAdapter = new AerolineaFrba.GD2C2015DataSetTableAdapters.Tipos_ServicioTableAdapter();
            this.rutasTableAdapter1 = new AerolineaFrba.GD2C2015DataSetTableAdapters.RutasTableAdapter();
            this.ciudadesTableAdapter = new AerolineaFrba.GD2C2015DataSetTableAdapters.CiudadesTableAdapter();
            this.activo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposServicioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ciudad Origen";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ciudad Destino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de Servicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Código de Ruta";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio por Kg";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Precio Base por Pasaje";
            // 
            // ciudadOrigen
            // 
            this.ciudadOrigen.DataSource = this.ciudadesBindingSource;
            this.ciudadOrigen.DisplayMember = "ciu_descripcion";
            this.ciudadOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ciudadOrigen.FormattingEnabled = true;
            this.ciudadOrigen.Location = new System.Drawing.Point(180, 80);
            this.ciudadOrigen.Name = "ciudadOrigen";
            this.ciudadOrigen.Size = new System.Drawing.Size(121, 21);
            this.ciudadOrigen.TabIndex = 2;
            this.ciudadOrigen.ValueMember = "ciu_id";
            this.ciudadOrigen.SelectedIndexChanged += new System.EventHandler(this.ciudadOrigen_SelectedIndexChanged);
            // 
            // ciudadesBindingSource
            // 
            this.ciudadesBindingSource.DataMember = "Ciudades";
            this.ciudadesBindingSource.DataSource = this.gD2C2015DataSet;
            // 
            // gD2C2015DataSet
            // 
            this.gD2C2015DataSet.DataSetName = "GD2C2015DataSet";
            this.gD2C2015DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ciudadDestino
            // 
            this.ciudadDestino.DataSource = this.ciudadesBindingSource1;
            this.ciudadDestino.DisplayMember = "ciu_descripcion";
            this.ciudadDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ciudadDestino.FormattingEnabled = true;
            this.ciudadDestino.Location = new System.Drawing.Point(180, 117);
            this.ciudadDestino.Name = "ciudadDestino";
            this.ciudadDestino.Size = new System.Drawing.Size(121, 21);
            this.ciudadDestino.TabIndex = 3;
            this.ciudadDestino.ValueMember = "ciu_id";
            // 
            // ciudadesBindingSource1
            // 
            this.ciudadesBindingSource1.DataMember = "Ciudades";
            this.ciudadesBindingSource1.DataSource = this.gD2C2015DataSet;
            // 
            // tiposServicioBindingSource
            // 
            this.tiposServicioBindingSource.DataMember = "Tipos_Servicio";
            this.tiposServicioBindingSource.DataSource = this.gD2C2015DataSet;
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(180, 45);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(100, 20);
            this.codigo.TabIndex = 1;
            this.codigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // precioKg
            // 
            this.precioKg.Location = new System.Drawing.Point(180, 269);
            this.precioKg.Name = "precioKg";
            this.precioKg.Size = new System.Drawing.Size(100, 20);
            this.precioKg.TabIndex = 5;
            this.precioKg.TextChanged += new System.EventHandler(this.precioKg_TextChanged);
            this.precioKg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precioKg_KeyPress);
            // 
            // precioBase
            // 
            this.precioBase.Location = new System.Drawing.Point(180, 300);
            this.precioBase.Name = "precioBase";
            this.precioBase.Size = new System.Drawing.Size(100, 20);
            this.precioBase.TabIndex = 6;
            this.precioBase.TextChanged += new System.EventHandler(this.precioBase_TextChanged);
            this.precioBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precioBase_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(180, 154);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 4;
            // 
            // tipos_ServicioTableAdapter
            // 
            this.tipos_ServicioTableAdapter.ClearBeforeFill = true;
            // 
            // rutasTableAdapter1
            // 
            this.rutasTableAdapter1.ClearBeforeFill = true;
            // 
            // ciudadesTableAdapter
            // 
            this.ciudadesTableAdapter.ClearBeforeFill = true;
            // 
            // activo
            // 
            this.activo.AutoSize = true;
            this.activo.Enabled = false;
            this.activo.Location = new System.Drawing.Point(296, 12);
            this.activo.Name = "activo";
            this.activo.Size = new System.Drawing.Size(56, 17);
            this.activo.TabIndex = 6;
            this.activo.Text = "Activo";
            this.activo.UseVisualStyleBackColor = true;
            // 
            // CargarRutaForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 382);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.precioBase);
            this.Controls.Add(this.precioKg);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.ciudadDestino);
            this.Controls.Add(this.ciudadOrigen);
            this.Controls.Add(this.activo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CargarRutaForm";
            this.Text = "Formulario de Ruta";
            this.Load += new System.EventHandler(this.CargarRutaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposServicioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ciudadOrigen;
        private GD2C2015DataSet gD2C2015DataSet;
        private System.Windows.Forms.BindingSource ciudadesBindingSource;
        private System.Windows.Forms.ComboBox ciudadDestino;
        private System.Windows.Forms.BindingSource tiposServicioBindingSource;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.TextBox precioKg;
        private System.Windows.Forms.TextBox precioBase;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.BindingSource ciudadesBindingSource1;
        private GD2C2015DataSetTableAdapters.Tipos_ServicioTableAdapter tipos_ServicioTableAdapter;
        private GD2C2015DataSetTableAdapters.RutasTableAdapter rutasTableAdapter1;
        private GD2C2015DataSetTableAdapters.CiudadesTableAdapter ciudadesTableAdapter;
        private System.Windows.Forms.CheckBox activo;
    }
}