namespace AerolineaFrba.Abm_Aeronave
{
    partial class BajaPendientesFSForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.CancelarVueBut = new System.Windows.Forms.Button();
            this.reemplazarBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "La Aeronave tiene vuelos pendientes. ¿Que desea hacer?";
            // 
            // CancelarVueBut
            // 
            this.CancelarVueBut.Location = new System.Drawing.Point(55, 70);
            this.CancelarVueBut.Name = "CancelarVueBut";
            this.CancelarVueBut.Size = new System.Drawing.Size(128, 23);
            this.CancelarVueBut.TabIndex = 1;
            this.CancelarVueBut.Text = "Cancelar Vuelos";
            this.CancelarVueBut.UseVisualStyleBackColor = true;
            this.CancelarVueBut.Click += new System.EventHandler(this.CancelarVueBut_Click);
            // 
            // reemplazarBut
            // 
            this.reemplazarBut.Location = new System.Drawing.Point(182, 70);
            this.reemplazarBut.Name = "reemplazarBut";
            this.reemplazarBut.Size = new System.Drawing.Size(125, 23);
            this.reemplazarBut.TabIndex = 2;
            this.reemplazarBut.Text = "Reemplazar Aeronave";
            this.reemplazarBut.UseVisualStyleBackColor = true;
            this.reemplazarBut.Click += new System.EventHandler(this.reemplazarBut_Click);
            // 
            // BajaPendientesFSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 138);
            this.Controls.Add(this.reemplazarBut);
            this.Controls.Add(this.CancelarVueBut);
            this.Controls.Add(this.label1);
            this.Name = "BajaPendientesFSForm";
            this.Text = "Fuera de Servicio - Aeronaves";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelarVueBut;
        private System.Windows.Forms.Button reemplazarBut;
    }
}