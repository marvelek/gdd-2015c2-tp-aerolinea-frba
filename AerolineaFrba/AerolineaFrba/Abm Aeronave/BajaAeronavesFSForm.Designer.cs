namespace AerolineaFrba.Abm_Aeronave
{
    partial class BajaAeronavesFSForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.motivoBox = new System.Windows.Forms.TextBox();
            this.fechaHastaPicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ContinuarBut = new System.Windows.Forms.Button();
            this.CancelarBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // motivoBox
            // 
            this.motivoBox.Location = new System.Drawing.Point(46, 73);
            this.motivoBox.Name = "motivoBox";
            this.motivoBox.Size = new System.Drawing.Size(200, 20);
            this.motivoBox.TabIndex = 0;
            // 
            // fechaHastaPicker
            // 
            this.fechaHastaPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaHastaPicker.Location = new System.Drawing.Point(46, 130);
            this.fechaHastaPicker.MinDate = new System.DateTime(2015, 12, 8, 0, 0, 0, 0);
            this.fechaHastaPicker.Name = "fechaHastaPicker";
            this.fechaHastaPicker.Size = new System.Drawing.Size(200, 20);
            this.fechaHastaPicker.TabIndex = 1;
            this.fechaHastaPicker.Validating += new System.ComponentModel.CancelEventHandler(this.fechaHastaPicker_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Motivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de Reincorporación";
            // 
            // ContinuarBut
            // 
            this.ContinuarBut.Location = new System.Drawing.Point(46, 167);
            this.ContinuarBut.Name = "ContinuarBut";
            this.ContinuarBut.Size = new System.Drawing.Size(75, 23);
            this.ContinuarBut.TabIndex = 4;
            this.ContinuarBut.Text = "Continuar";
            this.ContinuarBut.UseVisualStyleBackColor = true;
            this.ContinuarBut.Click += new System.EventHandler(this.ContinuarBut_Click);
            // 
            // CancelarBut
            // 
            this.CancelarBut.Location = new System.Drawing.Point(171, 167);
            this.CancelarBut.Name = "CancelarBut";
            this.CancelarBut.Size = new System.Drawing.Size(75, 23);
            this.CancelarBut.TabIndex = 5;
            this.CancelarBut.Text = "Cancelar";
            this.CancelarBut.UseVisualStyleBackColor = true;
            this.CancelarBut.Click += new System.EventHandler(this.CancelarBut_Click);
            // 
            // BajaAeronavesFSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 250);
            this.Controls.Add(this.CancelarBut);
            this.Controls.Add(this.ContinuarBut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fechaHastaPicker);
            this.Controls.Add(this.motivoBox);
            this.Name = "BajaAeronavesFSForm";
            this.Text = "Fuera de Servicio - Aeronaves";
            this.Load += new System.EventHandler(this.BajaAeronavesFSForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox motivoBox;
        private System.Windows.Forms.DateTimePicker fechaHastaPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ContinuarBut;
        private System.Windows.Forms.Button CancelarBut;
    }
}