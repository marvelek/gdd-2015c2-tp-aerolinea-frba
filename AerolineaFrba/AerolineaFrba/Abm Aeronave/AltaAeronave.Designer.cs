namespace AerolineaFrba.Abm_Aeronave
{
    partial class AltaAeronave
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
            this.matricula = new System.Windows.Forms.Label();
            this.matriculaText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ComboTipoServicio = new System.Windows.Forms.ComboBox();
            this.modeloText = new System.Windows.Forms.TextBox();
            this.ButacasPasilloText = new System.Windows.Forms.TextBox();
            this.ButacasVentanillaText = new System.Windows.Forms.TextBox();
            this.kgEncomientasText = new System.Windows.Forms.TextBox();
            this.dateTimePickerAlta = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.aeronavesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2015DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2015DataSet = new AerolineaFrba.GD2C2015DataSet();
            this.FabricateTextBox = new System.Windows.Forms.TextBox();
            this.butacasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiposServicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeronavesTableAdapter = new AerolineaFrba.GD2C2015DataSetTableAdapters.AeronavesTableAdapter();
            this.butacasTableAdapter = new AerolineaFrba.GD2C2015DataSetTableAdapters.ButacasTableAdapter();
            this.tipos_ServicioTableAdapter = new AerolineaFrba.GD2C2015DataSetTableAdapters.Tipos_ServicioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.aeronavesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.butacasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposServicioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // matricula
            // 
            this.matricula.AutoSize = true;
            this.matricula.Location = new System.Drawing.Point(41, 28);
            this.matricula.Name = "matricula";
            this.matricula.Size = new System.Drawing.Size(52, 13);
            this.matricula.TabIndex = 0;
            this.matricula.Text = "Matrícula";
            // 
            // matriculaText
            // 
            this.matriculaText.Location = new System.Drawing.Point(44, 45);
            this.matriculaText.MaxLength = 10;
            this.matriculaText.Name = "matriculaText";
            this.matriculaText.Size = new System.Drawing.Size(222, 20);
            this.matriculaText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cant. Butacas Pasillo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cant. Butacas Ventanilla";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fabricante";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tipo de Servicio";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "KG Encomiendas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Fecha de Alta";
            // 
            // ComboTipoServicio
            // 
            this.ComboTipoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTipoServicio.FormattingEnabled = true;
            this.ComboTipoServicio.Location = new System.Drawing.Point(294, 155);
            this.ComboTipoServicio.Name = "ComboTipoServicio";
            this.ComboTipoServicio.Size = new System.Drawing.Size(222, 21);
            this.ComboTipoServicio.TabIndex = 6;
            // 
            // modeloText
            // 
            this.modeloText.Location = new System.Drawing.Point(297, 44);
            this.modeloText.Name = "modeloText";
            this.modeloText.Size = new System.Drawing.Size(219, 20);
            this.modeloText.TabIndex = 2;
            // 
            // ButacasPasilloText
            // 
            this.ButacasPasilloText.Location = new System.Drawing.Point(44, 98);
            this.ButacasPasilloText.Name = "ButacasPasilloText";
            this.ButacasPasilloText.Size = new System.Drawing.Size(219, 20);
            this.ButacasPasilloText.TabIndex = 3;
            this.ButacasPasilloText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ButacasPasilloText_KeyPress);
            // 
            // ButacasVentanillaText
            // 
            this.ButacasVentanillaText.Location = new System.Drawing.Point(297, 98);
            this.ButacasVentanillaText.Name = "ButacasVentanillaText";
            this.ButacasVentanillaText.Size = new System.Drawing.Size(219, 20);
            this.ButacasVentanillaText.TabIndex = 4;
            this.ButacasVentanillaText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ButacasVentanillaText_KeyPress);
            // 
            // kgEncomientasText
            // 
            this.kgEncomientasText.Location = new System.Drawing.Point(44, 207);
            this.kgEncomientasText.Name = "kgEncomientasText";
            this.kgEncomientasText.Size = new System.Drawing.Size(216, 20);
            this.kgEncomientasText.TabIndex = 7;
            this.kgEncomientasText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kgEncomientasText_KeyPress);
            // 
            // dateTimePickerAlta
            // 
            this.dateTimePickerAlta.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAlta.Location = new System.Drawing.Point(294, 207);
            this.dateTimePickerAlta.Name = "dateTimePickerAlta";
            this.dateTimePickerAlta.Size = new System.Drawing.Size(219, 20);
            this.dateTimePickerAlta.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(41, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Todos los campos son obligatorios.";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(44, 283);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(216, 44);
            this.buttonGuardar.TabIndex = 9;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(294, 283);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(106, 44);
            this.buttonVolver.TabIndex = 41;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(406, 283);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(107, 44);
            this.buttonLimpiar.TabIndex = 42;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
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
            // FabricateTextBox
            // 
            this.FabricateTextBox.Location = new System.Drawing.Point(44, 154);
            this.FabricateTextBox.Name = "FabricateTextBox";
            this.FabricateTextBox.Size = new System.Drawing.Size(219, 20);
            this.FabricateTextBox.TabIndex = 5;
            // 
            // butacasBindingSource
            // 
            this.butacasBindingSource.DataMember = "Butacas";
            this.butacasBindingSource.DataSource = this.gD2C2015DataSetBindingSource;
            // 
            // tiposServicioBindingSource
            // 
            this.tiposServicioBindingSource.DataMember = "Tipos_Servicio";
            this.tiposServicioBindingSource.DataSource = this.gD2C2015DataSetBindingSource;
            // 
            // aeronavesTableAdapter
            // 
            this.aeronavesTableAdapter.ClearBeforeFill = true;
            // 
            // butacasTableAdapter
            // 
            this.butacasTableAdapter.ClearBeforeFill = true;
            // 
            // tipos_ServicioTableAdapter
            // 
            this.tipos_ServicioTableAdapter.ClearBeforeFill = true;
            // 
            // AltaAeronave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 508);
            this.Controls.Add(this.FabricateTextBox);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePickerAlta);
            this.Controls.Add(this.kgEncomientasText);
            this.Controls.Add(this.ButacasVentanillaText);
            this.Controls.Add(this.ButacasPasilloText);
            this.Controls.Add(this.modeloText);
            this.Controls.Add(this.ComboTipoServicio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matriculaText);
            this.Controls.Add(this.matricula);
            this.Name = "AltaAeronave";
            this.Text = "Alta Aeronave";
            this.Load += new System.EventHandler(this.AltaAeronave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aeronavesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.butacasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposServicioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label matricula;
        private System.Windows.Forms.TextBox matriculaText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ComboTipoServicio;
        private System.Windows.Forms.TextBox modeloText;
        private System.Windows.Forms.TextBox ButacasPasilloText;
        private System.Windows.Forms.TextBox ButacasVentanillaText;
        private System.Windows.Forms.TextBox kgEncomientasText;
        private System.Windows.Forms.DateTimePicker dateTimePickerAlta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.BindingSource gD2C2015DataSetBindingSource;
        private GD2C2015DataSet gD2C2015DataSet;
        private System.Windows.Forms.BindingSource aeronavesBindingSource;
        private GD2C2015DataSetTableAdapters.AeronavesTableAdapter aeronavesTableAdapter;
        private System.Windows.Forms.TextBox FabricateTextBox;
        private System.Windows.Forms.BindingSource butacasBindingSource;
        private GD2C2015DataSetTableAdapters.ButacasTableAdapter butacasTableAdapter;
        private System.Windows.Forms.BindingSource tiposServicioBindingSource;
        private GD2C2015DataSetTableAdapters.Tipos_ServicioTableAdapter tipos_ServicioTableAdapter;
    }
}