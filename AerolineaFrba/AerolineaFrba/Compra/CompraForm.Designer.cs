namespace AerolineaFrba.Compra
{
    partial class CompraForm
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
            this.destinoViaje = new System.Windows.Forms.TextBox();
            this.origenViaje = new System.Windows.Forms.TextBox();
            this.pesoEncomienda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cantidadPasajeros = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fechaViaje = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Vuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aeronave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButacasLibres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KgDisponibles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.destinoViaje);
            this.groupBox1.Controls.Add(this.origenViaje);
            this.groupBox1.Controls.Add(this.pesoEncomienda);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cantidadPasajeros);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buscar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.fechaViaje);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // destinoViaje
            // 
            this.destinoViaje.Location = new System.Drawing.Point(437, 63);
            this.destinoViaje.Name = "destinoViaje";
            this.destinoViaje.Size = new System.Drawing.Size(100, 20);
            this.destinoViaje.TabIndex = 3;
            // 
            // origenViaje
            // 
            this.origenViaje.Location = new System.Drawing.Point(112, 63);
            this.origenViaje.Name = "origenViaje";
            this.origenViaje.Size = new System.Drawing.Size(100, 20);
            this.origenViaje.TabIndex = 2;
            // 
            // pesoEncomienda
            // 
            this.pesoEncomienda.Location = new System.Drawing.Point(437, 101);
            this.pesoEncomienda.Name = "pesoEncomienda";
            this.pesoEncomienda.Size = new System.Drawing.Size(100, 20);
            this.pesoEncomienda.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kg encomienda";
            // 
            // cantidadPasajeros
            // 
            this.cantidadPasajeros.Location = new System.Drawing.Point(112, 101);
            this.cantidadPasajeros.Name = "cantidadPasajeros";
            this.cantidadPasajeros.Size = new System.Drawing.Size(100, 20);
            this.cantidadPasajeros.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantidad pasajeros";
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(614, 120);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 6;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Destino:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Origen:";
            // 
            // fechaViaje
            // 
            this.fechaViaje.Location = new System.Drawing.Point(112, 18);
            this.fechaViaje.Name = "fechaViaje";
            this.fechaViaje.Size = new System.Drawing.Size(200, 20);
            this.fechaViaje.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:";
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vuelo,
            this.Aeronave,
            this.Servicio,
            this.ButacasLibres,
            this.KgDisponibles,
            this.Seleccionar});
            this.dataGrid.Location = new System.Drawing.Point(12, 167);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(695, 196);
            this.dataGrid.TabIndex = 1;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // Vuelo
            // 
            this.Vuelo.HeaderText = "Vuelo";
            this.Vuelo.Name = "Vuelo";
            this.Vuelo.ReadOnly = true;
            // 
            // Aeronave
            // 
            this.Aeronave.HeaderText = "Aeronave";
            this.Aeronave.Name = "Aeronave";
            this.Aeronave.ReadOnly = true;
            // 
            // Servicio
            // 
            this.Servicio.HeaderText = "Servicio";
            this.Servicio.Name = "Servicio";
            this.Servicio.ReadOnly = true;
            // 
            // ButacasLibres
            // 
            this.ButacasLibres.HeaderText = "ButacasLibres";
            this.ButacasLibres.Name = "ButacasLibres";
            this.ButacasLibres.ReadOnly = true;
            // 
            // KgDisponibles
            // 
            this.KgDisponibles.HeaderText = "KgDisponibles";
            this.KgDisponibles.Name = "KgDisponibles";
            this.KgDisponibles.ReadOnly = true;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // CompraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 402);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.groupBox1);
            this.Name = "CompraForm";
            this.Text = "Busqueda de viaje";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox pesoEncomienda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cantidadPasajeros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fechaViaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox destinoViaje;
        private System.Windows.Forms.TextBox origenViaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aeronave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ButacasLibres;
        private System.Windows.Forms.DataGridViewTextBoxColumn KgDisponibles;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
    }
}