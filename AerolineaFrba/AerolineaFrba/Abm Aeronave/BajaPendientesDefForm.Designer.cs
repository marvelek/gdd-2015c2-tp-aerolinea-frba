namespace AerolineaFrba.Abm_Aeronave
{
    partial class BajaPendientesDefForm
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
            this.reemplazarBut = new System.Windows.Forms.Button();
            this.CancelarVueBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reemplazarBut
            // 
            this.reemplazarBut.Location = new System.Drawing.Point(199, 77);
            this.reemplazarBut.Name = "reemplazarBut";
            this.reemplazarBut.Size = new System.Drawing.Size(124, 23);
            this.reemplazarBut.TabIndex = 5;
            this.reemplazarBut.Text = "Reemplazar Aeronave";
            this.reemplazarBut.UseVisualStyleBackColor = true;
            this.reemplazarBut.Click += new System.EventHandler(this.reemplazarBut_Click);
            // 
            // CancelarVueBut
            // 
            this.CancelarVueBut.Location = new System.Drawing.Point(72, 77);
            this.CancelarVueBut.Name = "CancelarVueBut";
            this.CancelarVueBut.Size = new System.Drawing.Size(127, 23);
            this.CancelarVueBut.TabIndex = 4;
            this.CancelarVueBut.Text = "Cancelar Vuelos";
            this.CancelarVueBut.UseVisualStyleBackColor = true;
            this.CancelarVueBut.Click += new System.EventHandler(this.CancelarVueBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "La Aeronave tiene vuelos pendientes. ¿Que desea hacer?";
            // 
            // BajaPendientesDefForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 155);
            this.Controls.Add(this.reemplazarBut);
            this.Controls.Add(this.CancelarVueBut);
            this.Controls.Add(this.label1);
            this.Name = "BajaPendientesDefForm";
            this.Text = "Baja definitiva - Aeronaves";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reemplazarBut;
        private System.Windows.Forms.Button CancelarVueBut;
        private System.Windows.Forms.Label label1;
    }
}