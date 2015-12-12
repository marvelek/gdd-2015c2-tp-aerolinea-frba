namespace AerolineaFrba.Compra
{
    partial class ResumenForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.montoAbonado = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pasajesGrid = new System.Windows.Forms.DataGridView();
            this.pasajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoPasaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoEncomienda = new System.Windows.Forms.GroupBox();
            this.paqueteGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pasajesGrid)).BeginInit();
            this.grupoEncomienda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paqueteGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.montoAbonado);
            this.groupBox1.Controls.Add(this.codigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compra";
            // 
            // montoAbonado
            // 
            this.montoAbonado.AutoSize = true;
            this.montoAbonado.Location = new System.Drawing.Point(132, 52);
            this.montoAbonado.Name = "montoAbonado";
            this.montoAbonado.Size = new System.Drawing.Size(0, 13);
            this.montoAbonado.TabIndex = 3;
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.Location = new System.Drawing.Point(132, 26);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(0, 13);
            this.codigo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monto abonado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pasajesGrid);
            this.groupBox2.Location = new System.Drawing.Point(12, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 124);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pasajes";
            // 
            // pasajesGrid
            // 
            this.pasajesGrid.AllowUserToAddRows = false;
            this.pasajesGrid.AllowUserToDeleteRows = false;
            this.pasajesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pasajesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pasajero,
            this.codigoPasaje,
            this.tipoServicio,
            this.precio});
            this.pasajesGrid.Location = new System.Drawing.Point(6, 19);
            this.pasajesGrid.Name = "pasajesGrid";
            this.pasajesGrid.ReadOnly = true;
            this.pasajesGrid.Size = new System.Drawing.Size(443, 99);
            this.pasajesGrid.TabIndex = 0;
            // 
            // pasajero
            // 
            this.pasajero.HeaderText = "Pasajero";
            this.pasajero.Name = "pasajero";
            this.pasajero.ReadOnly = true;
            // 
            // codigoPasaje
            // 
            this.codigoPasaje.HeaderText = "Código de Pasaje";
            this.codigoPasaje.Name = "codigoPasaje";
            this.codigoPasaje.ReadOnly = true;
            // 
            // tipoServicio
            // 
            this.tipoServicio.HeaderText = "Butaca";
            this.tipoServicio.Name = "tipoServicio";
            this.tipoServicio.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // grupoEncomienda
            // 
            this.grupoEncomienda.Controls.Add(this.paqueteGrid);
            this.grupoEncomienda.Location = new System.Drawing.Point(12, 232);
            this.grupoEncomienda.Name = "grupoEncomienda";
            this.grupoEncomienda.Size = new System.Drawing.Size(455, 100);
            this.grupoEncomienda.TabIndex = 2;
            this.grupoEncomienda.TabStop = false;
            this.grupoEncomienda.Text = "Encomienda";
            // 
            // paqueteGrid
            // 
            this.paqueteGrid.AllowUserToAddRows = false;
            this.paqueteGrid.AllowUserToDeleteRows = false;
            this.paqueteGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paqueteGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.paqueteGrid.Location = new System.Drawing.Point(6, 19);
            this.paqueteGrid.Name = "paqueteGrid";
            this.paqueteGrid.ReadOnly = true;
            this.paqueteGrid.Size = new System.Drawing.Size(443, 75);
            this.paqueteGrid.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Responsable";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Código de Paquete";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Peso";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // ResumenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 339);
            this.Controls.Add(this.grupoEncomienda);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ResumenForm";
            this.Text = "Resumen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pasajesGrid)).EndInit();
            this.grupoEncomienda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paqueteGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label montoAbonado;
        private System.Windows.Forms.Label codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView pasajesGrid;
        private System.Windows.Forms.GroupBox grupoEncomienda;
        private System.Windows.Forms.DataGridView paqueteGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn pasajero;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPasaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
    }
}