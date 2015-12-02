namespace AerolineaFrba.Generacion_Viaje
{
    partial class GenerarViajeForm
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
            this.generar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.rutas = new System.Windows.Forms.ComboBox();
            this.fechaSalida = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fechaLlegadaEstimada = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.aeronaves = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // generar
            // 
            this.generar.Location = new System.Drawing.Point(560, 241);
            this.generar.Name = "generar";
            this.generar.Size = new System.Drawing.Size(76, 27);
            this.generar.TabIndex = 0;
            this.generar.Text = "Generar";
            this.generar.UseVisualStyleBackColor = true;
            this.generar.Click += new System.EventHandler(this.generar_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(13, 244);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 1;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // rutas
            // 
            this.rutas.FormattingEnabled = true;
            this.rutas.Location = new System.Drawing.Point(170, 121);
            this.rutas.Name = "rutas";
            this.rutas.Size = new System.Drawing.Size(312, 21);
            this.rutas.TabIndex = 2;
            // 
            // fechaSalida
            // 
            this.fechaSalida.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.fechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaSalida.Location = new System.Drawing.Point(170, 30);
            this.fechaSalida.MinDate = new System.DateTime(2015, 11, 28, 0, 0, 0, 0);
            this.fechaSalida.Name = "fechaSalida";
            this.fechaSalida.Size = new System.Drawing.Size(150, 20);
            this.fechaSalida.TabIndex = 3;
            this.fechaSalida.Value = new System.DateTime(2015, 11, 28, 12, 16, 57, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha Salida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha Llegada estimada:";
            // 
            // fechaLlegadaEstimada
            // 
            this.fechaLlegadaEstimada.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.fechaLlegadaEstimada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaLlegadaEstimada.Location = new System.Drawing.Point(170, 80);
            this.fechaLlegadaEstimada.MinDate = new System.DateTime(2015, 11, 28, 0, 0, 0, 0);
            this.fechaLlegadaEstimada.Name = "fechaLlegadaEstimada";
            this.fechaLlegadaEstimada.Size = new System.Drawing.Size(150, 20);
            this.fechaLlegadaEstimada.TabIndex = 7;
            this.fechaLlegadaEstimada.Value = new System.DateTime(2015, 11, 28, 12, 16, 57, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ruta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Aeronave:";
            // 
            // aeronaves
            // 
            this.aeronaves.FormattingEnabled = true;
            this.aeronaves.Location = new System.Drawing.Point(170, 166);
            this.aeronaves.Name = "aeronaves";
            this.aeronaves.Size = new System.Drawing.Size(312, 21);
            this.aeronaves.TabIndex = 10;
            // 
            // GenerarViajeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 288);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.aeronaves);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fechaLlegadaEstimada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fechaSalida);
            this.Controls.Add(this.rutas);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.generar);
            this.Name = "GenerarViajeForm";
            this.Text = "Generar viaje";
            this.Load += new System.EventHandler(this.GenerarViajeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generar;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.ComboBox rutas;
        private System.Windows.Forms.DateTimePicker fechaSalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fechaLlegadaEstimada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox aeronaves;
    }
}