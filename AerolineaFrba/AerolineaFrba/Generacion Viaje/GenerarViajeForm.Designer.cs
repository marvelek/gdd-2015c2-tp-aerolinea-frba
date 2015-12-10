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
            this.fechaSalida = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fechaLlegadaEstimada = new System.Windows.Forms.DateTimePicker();
            this.destino = new System.Windows.Forms.TextBox();
            this.origen = new System.Windows.Forms.TextBox();
            this.matricula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generar
            // 
            this.generar.Location = new System.Drawing.Point(279, 242);
            this.generar.Name = "generar";
            this.generar.Size = new System.Drawing.Size(76, 27);
            this.generar.TabIndex = 6;
            this.generar.Text = "Generar";
            this.generar.UseVisualStyleBackColor = true;
            this.generar.Click += new System.EventHandler(this.generar_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(13, 244);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 7;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // fechaSalida
            // 
            this.fechaSalida.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.fechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaSalida.Location = new System.Drawing.Point(170, 30);
            this.fechaSalida.MinDate = new System.DateTime(2015, 11, 28, 0, 0, 0, 0);
            this.fechaSalida.Name = "fechaSalida";
            this.fechaSalida.Size = new System.Drawing.Size(150, 20);
            this.fechaSalida.TabIndex = 1;
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
            this.fechaLlegadaEstimada.TabIndex = 2;
            this.fechaLlegadaEstimada.Value = new System.DateTime(2015, 11, 28, 12, 16, 57, 0);
            // 
            // destino
            // 
            this.destino.Location = new System.Drawing.Point(170, 195);
            this.destino.Name = "destino";
            this.destino.Size = new System.Drawing.Size(150, 20);
            this.destino.TabIndex = 5;
            // 
            // origen
            // 
            this.origen.Location = new System.Drawing.Point(170, 158);
            this.origen.Name = "origen";
            this.origen.Size = new System.Drawing.Size(150, 20);
            this.origen.TabIndex = 4;
            // 
            // matricula
            // 
            this.matricula.Location = new System.Drawing.Point(170, 121);
            this.matricula.Name = "matricula";
            this.matricula.Size = new System.Drawing.Size(150, 20);
            this.matricula.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ciudad destino:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ciudad origen:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Matricula aeronave:";
            // 
            // GenerarViajeForm
            // 
            this.AcceptButton = this.generar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 288);
            this.Controls.Add(this.destino);
            this.Controls.Add(this.origen);
            this.Controls.Add(this.matricula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fechaLlegadaEstimada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fechaSalida);
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
        private System.Windows.Forms.DateTimePicker fechaSalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fechaLlegadaEstimada;
        private System.Windows.Forms.TextBox destino;
        private System.Windows.Forms.TextBox origen;
        private System.Windows.Forms.TextBox matricula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}