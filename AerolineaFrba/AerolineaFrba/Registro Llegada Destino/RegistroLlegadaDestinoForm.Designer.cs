﻿namespace AerolineaFrba.Registro_Llegada_Destino
{
    partial class RegistroLlegadaDestinoForm
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
            this.fechaLlegada = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.limpiar = new System.Windows.Forms.Button();
            this.registrar = new System.Windows.Forms.Button();
            this.matricula = new System.Windows.Forms.TextBox();
            this.origen = new System.Windows.Forms.TextBox();
            this.destino = new System.Windows.Forms.TextBox();
            this.aeronavesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2015DataSet = new AerolineaFrba.GD2C2015DataSet();
            this.aeronavesTableAdapter1 = new AerolineaFrba.GD2C2015DataSetTableAdapters.AeronavesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.aeronavesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha llegada:";
            // 
            // fechaLlegada
            // 
            this.fechaLlegada.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.fechaLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaLlegada.Location = new System.Drawing.Point(203, 35);
            this.fechaLlegada.MinDate = new System.DateTime(2015, 11, 28, 0, 0, 0, 0);
            this.fechaLlegada.Name = "fechaLlegada";
            this.fechaLlegada.Size = new System.Drawing.Size(150, 20);
            this.fechaLlegada.TabIndex = 1;
            this.fechaLlegada.Value = new System.DateTime(2015, 11, 28, 12, 16, 57, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Matricula aeronave:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ciudad origen:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ciudad destino:";
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(12, 227);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 6;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // registrar
            // 
            this.registrar.Location = new System.Drawing.Point(333, 227);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(75, 23);
            this.registrar.TabIndex = 7;
            this.registrar.Text = "Registrar";
            this.registrar.UseVisualStyleBackColor = true;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // matricula
            // 
            this.matricula.Location = new System.Drawing.Point(203, 76);
            this.matricula.Name = "matricula";
            this.matricula.Size = new System.Drawing.Size(150, 20);
            this.matricula.TabIndex = 3;
            // 
            // origen
            // 
            this.origen.Location = new System.Drawing.Point(203, 113);
            this.origen.Name = "origen";
            this.origen.Size = new System.Drawing.Size(150, 20);
            this.origen.TabIndex = 4;
            // 
            // destino
            // 
            this.destino.Location = new System.Drawing.Point(203, 150);
            this.destino.Name = "destino";
            this.destino.Size = new System.Drawing.Size(150, 20);
            this.destino.TabIndex = 5;
            // 
            // aeronavesBindingSource
            // 
            this.aeronavesBindingSource.DataMember = "Aeronaves";
            this.aeronavesBindingSource.DataSource = this.gD2C2015DataSet;
            // 
            // gD2C2015DataSet
            // 
            this.gD2C2015DataSet.DataSetName = "GD2C2015DataSet";
            this.gD2C2015DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aeronavesTableAdapter1
            // 
            this.aeronavesTableAdapter1.ClearBeforeFill = true;
            // 
            // RegistroLlegadaDestinoForm
            // 
            this.AcceptButton = this.registrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 270);
            this.Controls.Add(this.destino);
            this.Controls.Add(this.origen);
            this.Controls.Add(this.matricula);
            this.Controls.Add(this.registrar);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fechaLlegada);
            this.Controls.Add(this.label1);
            this.Name = "RegistroLlegadaDestinoForm";
            this.Text = "Registro llegada destino";
            this.Load += new System.EventHandler(this.RegistroLlegadaDestinoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aeronavesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fechaLlegada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button registrar;
        private System.Windows.Forms.TextBox matricula;
        private System.Windows.Forms.TextBox origen;
        private System.Windows.Forms.TextBox destino;
        private GD2C2015DataSet gD2C2015DataSet;
        private System.Windows.Forms.BindingSource aeronavesBindingSource;
        private GD2C2015DataSetTableAdapters.AeronavesTableAdapter aeronavesTableAdapter1;
    }
}