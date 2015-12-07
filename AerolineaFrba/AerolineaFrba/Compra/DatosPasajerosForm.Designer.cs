namespace AerolineaFrba.Compra
{
    partial class DatosPasajerosForm
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
            this.dni = new System.Windows.Forms.TextBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2015DataSet = new AerolineaFrba.GD2C2015DataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.TextBox();
            this.direccion = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.butacas = new System.Windows.Forms.ComboBox();
            this.butacasDisponiblesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.butacaLabel = new System.Windows.Forms.Label();
            this.butacasDisponiblesTableAdapter = new AerolineaFrba.GD2C2015DataSetTableAdapters.ButacasDisponiblesTableAdapter();
            this.clientesTableAdapter1 = new AerolineaFrba.GD2C2015DataSetTableAdapters.ClientesTableAdapter();
            this.pasajeroGrupo = new System.Windows.Forms.GroupBox();
            this.buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.butacasDisponiblesBindingSource)).BeginInit();
            this.pasajeroGrupo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(174, 25);
            this.dni.MaxLength = 10;
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(100, 20);
            this.dni.TabIndex = 1;
            this.dni.TextChanged += new System.EventHandler(this.dni_TextChanged);
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.gD2C2015DataSet;
            // 
            // gD2C2015DataSet
            // 
            this.gD2C2015DataSet.DataSetName = "GD2C2015DataSet";
            this.gD2C2015DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(174, 51);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Direccion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mail:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Fecha nacimiento:";
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(174, 77);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(100, 20);
            this.apellido.TabIndex = 3;
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(354, 25);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(173, 20);
            this.direccion.TabIndex = 4;
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(354, 51);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(173, 20);
            this.telefono.TabIndex = 5;
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(354, 77);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(173, 20);
            this.mail.TabIndex = 6;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaNacimiento.Location = new System.Drawing.Point(174, 103);
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.fechaNacimiento.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(448, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cargar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butacas
            // 
            this.butacas.DataSource = this.butacasDisponiblesBindingSource;
            this.butacas.DisplayMember = "butaca";
            this.butacas.FormattingEnabled = true;
            this.butacas.Location = new System.Drawing.Point(174, 129);
            this.butacas.Name = "butacas";
            this.butacas.Size = new System.Drawing.Size(121, 21);
            this.butacas.TabIndex = 8;
            this.butacas.ValueMember = "but_id";
            // 
            // butacasDisponiblesBindingSource
            // 
            this.butacasDisponiblesBindingSource.DataMember = "ButacasDisponibles";
            this.butacasDisponiblesBindingSource.DataSource = this.gD2C2015DataSet;
            // 
            // butacaLabel
            // 
            this.butacaLabel.AutoSize = true;
            this.butacaLabel.Location = new System.Drawing.Point(54, 132);
            this.butacaLabel.Name = "butacaLabel";
            this.butacaLabel.Size = new System.Drawing.Size(44, 13);
            this.butacaLabel.TabIndex = 16;
            this.butacaLabel.Text = "Butaca:";
            // 
            // butacasDisponiblesTableAdapter
            // 
            this.butacasDisponiblesTableAdapter.ClearBeforeFill = true;
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // pasajeroGrupo
            // 
            this.pasajeroGrupo.Controls.Add(this.buscar);
            this.pasajeroGrupo.Controls.Add(this.telefono);
            this.pasajeroGrupo.Controls.Add(this.butacaLabel);
            this.pasajeroGrupo.Controls.Add(this.butacas);
            this.pasajeroGrupo.Controls.Add(this.label1);
            this.pasajeroGrupo.Controls.Add(this.button1);
            this.pasajeroGrupo.Controls.Add(this.dni);
            this.pasajeroGrupo.Controls.Add(this.label2);
            this.pasajeroGrupo.Controls.Add(this.fechaNacimiento);
            this.pasajeroGrupo.Controls.Add(this.nombre);
            this.pasajeroGrupo.Controls.Add(this.mail);
            this.pasajeroGrupo.Controls.Add(this.label3);
            this.pasajeroGrupo.Controls.Add(this.label4);
            this.pasajeroGrupo.Controls.Add(this.direccion);
            this.pasajeroGrupo.Controls.Add(this.label5);
            this.pasajeroGrupo.Controls.Add(this.apellido);
            this.pasajeroGrupo.Controls.Add(this.label6);
            this.pasajeroGrupo.Controls.Add(this.label7);
            this.pasajeroGrupo.Location = new System.Drawing.Point(12, 12);
            this.pasajeroGrupo.Name = "pasajeroGrupo";
            this.pasajeroGrupo.Size = new System.Drawing.Size(589, 186);
            this.pasajeroGrupo.TabIndex = 17;
            this.pasajeroGrupo.TabStop = false;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(354, 127);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(79, 23);
            this.buscar.TabIndex = 17;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // DatosPasajerosForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 216);
            this.Controls.Add(this.pasajeroGrupo);
            this.Name = "DatosPasajerosForm";
            this.Text = "Carga de datos pasajeros";
            this.Load += new System.EventHandler(this.DatosPasajerosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.butacasDisponiblesBindingSource)).EndInit();
            this.pasajeroGrupo.ResumeLayout(false);
            this.pasajeroGrupo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.DateTimePicker fechaNacimiento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox butacas;
        private System.Windows.Forms.Label butacaLabel;
        private System.Windows.Forms.BindingSource butacasDisponiblesBindingSource;
        private GD2C2015DataSet gD2C2015DataSet;
        private GD2C2015DataSetTableAdapters.ButacasDisponiblesTableAdapter butacasDisponiblesTableAdapter;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private GD2C2015DataSetTableAdapters.ClientesTableAdapter clientesTableAdapter1;
        private System.Windows.Forms.GroupBox pasajeroGrupo;
        private System.Windows.Forms.Button buscar;
    }
}