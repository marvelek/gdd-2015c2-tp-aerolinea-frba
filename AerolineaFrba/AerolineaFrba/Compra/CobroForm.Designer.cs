﻿namespace AerolineaFrba.Compra
{
    partial class CobroForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buscar = new System.Windows.Forms.Button();
            this.mail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.dni = new System.Windows.Forms.TextBox();
            this.fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDni = new System.Windows.Forms.Label();
            this.Guardar = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pasajerosCombo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tipoTarjeta = new System.Windows.Forms.ComboBox();
            this.tarjetasCreditoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2015DataSet = new AerolineaFrba.GD2C2015DataSet();
            this.anioVencimiento = new System.Windows.Forms.ComboBox();
            this.mesVenciemiento = new System.Windows.Forms.ComboBox();
            this.tarjetaLabel = new System.Windows.Forms.Label();
            this.cuotas = new System.Windows.Forms.ComboBox();
            this.codigoSeguridad = new System.Windows.Forms.TextBox();
            this.numeroTarjeta = new System.Windows.Forms.TextBox();
            this.cuotasLabel = new System.Windows.Forms.Label();
            this.vencimientoLabel = new System.Windows.Forms.Label();
            this.codigoSeguridadLabel = new System.Windows.Forms.Label();
            this.numeroTarjetaLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.medioPago = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.encomiendaGrid = new System.Windows.Forms.DataGridView();
            this.responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioEncomienda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprar = new System.Windows.Forms.Button();
            this.totalAPagar = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pasajerosGrid = new System.Windows.Forms.DataGridView();
            this.pasajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesTableAdapter1 = new AerolineaFrba.GD2C2015DataSetTableAdapters.ClientesTableAdapter();
            this.ventasTableAdapter1 = new AerolineaFrba.GD2C2015DataSetTableAdapters.VentasTableAdapter();
            this.pasajesTableAdapter1 = new AerolineaFrba.GD2C2015DataSetTableAdapters.PasajesTableAdapter();
            this.paquetesTableAdapter1 = new AerolineaFrba.GD2C2015DataSetTableAdapters.PaquetesTableAdapter();
            this.pagos_TarjetaTableAdapter1 = new AerolineaFrba.GD2C2015DataSetTableAdapters.Pagos_TarjetaTableAdapter();
            this.tarjetas_CreditoTableAdapter = new AerolineaFrba.GD2C2015DataSetTableAdapters.Tarjetas_CreditoTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tarjetasCreditoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.encomiendaGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajerosGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buscar);
            this.groupBox1.Controls.Add(this.mail);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.telefono);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.direccion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.apellido);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Controls.Add(this.dni);
            this.groupBox1.Controls.Add(this.fechaNacimiento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelDni);
            this.groupBox1.Controls.Add(this.Guardar);
            this.groupBox1.Controls.Add(this.modificar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pasajerosCombo);
            this.groupBox1.Location = new System.Drawing.Point(49, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Comprador";
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(206, 17);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 19;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(277, 114);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(100, 20);
            this.mail.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Mail:";
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(277, 88);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(100, 20);
            this.telefono.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Teléfono:";
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(277, 62);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(100, 20);
            this.direccion.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Dirección:";
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(86, 114);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(100, 20);
            this.apellido.TabIndex = 7;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(86, 88);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 6;
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(86, 62);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(100, 20);
            this.dni.TabIndex = 5;
            this.dni.TextChanged += new System.EventHandler(this.dni_TextChanged);
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaNacimiento.Location = new System.Drawing.Point(86, 140);
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.fechaNacimiento.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre:";
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Location = new System.Drawing.Point(20, 65);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(29, 13);
            this.labelDni.TabIndex = 5;
            this.labelDni.Text = "DNI:";
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(368, 17);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 4;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(287, 17);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(75, 23);
            this.modificar.TabIndex = 3;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clientes";
            // 
            // pasajerosCombo
            // 
            this.pasajerosCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pasajerosCombo.FormattingEnabled = true;
            this.pasajerosCombo.Location = new System.Drawing.Point(79, 19);
            this.pasajerosCombo.Name = "pasajerosCombo";
            this.pasajerosCombo.Size = new System.Drawing.Size(121, 21);
            this.pasajerosCombo.TabIndex = 0;
            this.pasajerosCombo.SelectedIndexChanged += new System.EventHandler(this.pasajerosCombo_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tipoTarjeta);
            this.groupBox2.Controls.Add(this.anioVencimiento);
            this.groupBox2.Controls.Add(this.mesVenciemiento);
            this.groupBox2.Controls.Add(this.tarjetaLabel);
            this.groupBox2.Controls.Add(this.cuotas);
            this.groupBox2.Controls.Add(this.codigoSeguridad);
            this.groupBox2.Controls.Add(this.numeroTarjeta);
            this.groupBox2.Controls.Add(this.cuotasLabel);
            this.groupBox2.Controls.Add(this.vencimientoLabel);
            this.groupBox2.Controls.Add(this.codigoSeguridadLabel);
            this.groupBox2.Controls.Add(this.numeroTarjetaLabel);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.medioPago);
            this.groupBox2.Location = new System.Drawing.Point(49, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 122);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Pago";
            // 
            // tipoTarjeta
            // 
            this.tipoTarjeta.DataSource = this.tarjetasCreditoBindingSource;
            this.tipoTarjeta.DisplayMember = "tac_descripcion";
            this.tipoTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoTarjeta.FormattingEnabled = true;
            this.tipoTarjeta.Location = new System.Drawing.Point(320, 22);
            this.tipoTarjeta.Name = "tipoTarjeta";
            this.tipoTarjeta.Size = new System.Drawing.Size(121, 21);
            this.tipoTarjeta.TabIndex = 32;
            this.tipoTarjeta.ValueMember = "tac_id";
            this.tipoTarjeta.SelectedIndexChanged += new System.EventHandler(this.tipoTarjeta_SelectedIndexChanged);
            // 
            // tarjetasCreditoBindingSource
            // 
            this.tarjetasCreditoBindingSource.DataMember = "Tarjetas_Credito";
            this.tarjetasCreditoBindingSource.DataSource = this.gD2C2015DataSet;
            // 
            // gD2C2015DataSet
            // 
            this.gD2C2015DataSet.DataSetName = "GD2C2015DataSet";
            this.gD2C2015DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // anioVencimiento
            // 
            this.anioVencimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.anioVencimiento.FormattingEnabled = true;
            this.anioVencimiento.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027"});
            this.anioVencimiento.Location = new System.Drawing.Point(368, 75);
            this.anioVencimiento.Name = "anioVencimiento";
            this.anioVencimiento.Size = new System.Drawing.Size(50, 21);
            this.anioVencimiento.TabIndex = 17;
            // 
            // mesVenciemiento
            // 
            this.mesVenciemiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mesVenciemiento.FormattingEnabled = true;
            this.mesVenciemiento.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.mesVenciemiento.Location = new System.Drawing.Point(320, 75);
            this.mesVenciemiento.Name = "mesVenciemiento";
            this.mesVenciemiento.Size = new System.Drawing.Size(42, 21);
            this.mesVenciemiento.TabIndex = 16;
            // 
            // tarjetaLabel
            // 
            this.tarjetaLabel.AutoSize = true;
            this.tarjetaLabel.Location = new System.Drawing.Point(265, 25);
            this.tarjetaLabel.Name = "tarjetaLabel";
            this.tarjetaLabel.Size = new System.Drawing.Size(40, 13);
            this.tarjetaLabel.TabIndex = 31;
            this.tarjetaLabel.Text = "Tarjeta";
            // 
            // cuotas
            // 
            this.cuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cuotas.FormattingEnabled = true;
            this.cuotas.Items.AddRange(new object[] {
            "1",
            "3",
            "6",
            "12"});
            this.cuotas.Location = new System.Drawing.Point(429, 75);
            this.cuotas.Name = "cuotas";
            this.cuotas.Size = new System.Drawing.Size(62, 21);
            this.cuotas.TabIndex = 18;
            // 
            // codigoSeguridad
            // 
            this.codigoSeguridad.Location = new System.Drawing.Point(208, 77);
            this.codigoSeguridad.MaxLength = 3;
            this.codigoSeguridad.Name = "codigoSeguridad";
            this.codigoSeguridad.Size = new System.Drawing.Size(40, 20);
            this.codigoSeguridad.TabIndex = 15;
            // 
            // numeroTarjeta
            // 
            this.numeroTarjeta.Location = new System.Drawing.Point(17, 77);
            this.numeroTarjeta.MaxLength = 12;
            this.numeroTarjeta.Name = "numeroTarjeta";
            this.numeroTarjeta.Size = new System.Drawing.Size(177, 20);
            this.numeroTarjeta.TabIndex = 14;
            // 
            // cuotasLabel
            // 
            this.cuotasLabel.AutoSize = true;
            this.cuotasLabel.Location = new System.Drawing.Point(430, 60);
            this.cuotasLabel.Name = "cuotasLabel";
            this.cuotasLabel.Size = new System.Drawing.Size(40, 13);
            this.cuotasLabel.TabIndex = 25;
            this.cuotasLabel.Text = "Cuotas";
            // 
            // vencimientoLabel
            // 
            this.vencimientoLabel.AutoSize = true;
            this.vencimientoLabel.Location = new System.Drawing.Point(317, 60);
            this.vencimientoLabel.Name = "vencimientoLabel";
            this.vencimientoLabel.Size = new System.Drawing.Size(65, 13);
            this.vencimientoLabel.TabIndex = 24;
            this.vencimientoLabel.Text = "Vencimiento";
            // 
            // codigoSeguridadLabel
            // 
            this.codigoSeguridadLabel.AutoSize = true;
            this.codigoSeguridadLabel.Location = new System.Drawing.Point(205, 60);
            this.codigoSeguridadLabel.Name = "codigoSeguridadLabel";
            this.codigoSeguridadLabel.Size = new System.Drawing.Size(106, 13);
            this.codigoSeguridadLabel.TabIndex = 23;
            this.codigoSeguridadLabel.Text = "Código de Seguridad";
            // 
            // numeroTarjetaLabel
            // 
            this.numeroTarjetaLabel.AutoSize = true;
            this.numeroTarjetaLabel.Location = new System.Drawing.Point(14, 60);
            this.numeroTarjetaLabel.Name = "numeroTarjetaLabel";
            this.numeroTarjetaLabel.Size = new System.Drawing.Size(95, 13);
            this.numeroTarjetaLabel.TabIndex = 22;
            this.numeroTarjetaLabel.Text = "Numero de Tarjeta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Medio de Pago";
            // 
            // medioPago
            // 
            this.medioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.medioPago.FormattingEnabled = true;
            this.medioPago.Items.AddRange(new object[] {
            "Tarjeta de Crédito",
            "Efectivo"});
            this.medioPago.Location = new System.Drawing.Point(99, 22);
            this.medioPago.Name = "medioPago";
            this.medioPago.Size = new System.Drawing.Size(121, 21);
            this.medioPago.TabIndex = 12;
            this.medioPago.SelectedIndexChanged += new System.EventHandler(this.medioPago_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.encomiendaGrid);
            this.groupBox3.Controls.Add(this.comprar);
            this.groupBox3.Controls.Add(this.totalAPagar);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.pasajerosGrid);
            this.groupBox3.Location = new System.Drawing.Point(49, 339);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(506, 203);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resumen";
            // 
            // encomiendaGrid
            // 
            this.encomiendaGrid.AllowUserToAddRows = false;
            this.encomiendaGrid.AllowUserToDeleteRows = false;
            this.encomiendaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.encomiendaGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.responsable,
            this.peso,
            this.precioEncomienda});
            this.encomiendaGrid.Location = new System.Drawing.Point(17, 125);
            this.encomiendaGrid.Name = "encomiendaGrid";
            this.encomiendaGrid.ReadOnly = true;
            this.encomiendaGrid.Size = new System.Drawing.Size(345, 72);
            this.encomiendaGrid.TabIndex = 4;
            // 
            // responsable
            // 
            this.responsable.HeaderText = "Responsable";
            this.responsable.Name = "responsable";
            this.responsable.ReadOnly = true;
            // 
            // peso
            // 
            this.peso.HeaderText = "Peso";
            this.peso.Name = "peso";
            this.peso.ReadOnly = true;
            // 
            // precioEncomienda
            // 
            this.precioEncomienda.HeaderText = "Precio";
            this.precioEncomienda.Name = "precioEncomienda";
            this.precioEncomienda.ReadOnly = true;
            // 
            // comprar
            // 
            this.comprar.Location = new System.Drawing.Point(381, 134);
            this.comprar.Name = "comprar";
            this.comprar.Size = new System.Drawing.Size(89, 53);
            this.comprar.TabIndex = 19;
            this.comprar.Text = "Comprar";
            this.comprar.UseVisualStyleBackColor = true;
            this.comprar.Click += new System.EventHandler(this.comprar_Click);
            // 
            // totalAPagar
            // 
            this.totalAPagar.AutoSize = true;
            this.totalAPagar.Location = new System.Drawing.Point(418, 66);
            this.totalAPagar.Name = "totalAPagar";
            this.totalAPagar.Size = new System.Drawing.Size(0, 13);
            this.totalAPagar.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(378, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Total:";
            // 
            // pasajerosGrid
            // 
            this.pasajerosGrid.AllowUserToAddRows = false;
            this.pasajerosGrid.AllowUserToDeleteRows = false;
            this.pasajerosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pasajerosGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pasajero,
            this.butaca,
            this.precio});
            this.pasajerosGrid.Location = new System.Drawing.Point(17, 30);
            this.pasajerosGrid.Name = "pasajerosGrid";
            this.pasajerosGrid.ReadOnly = true;
            this.pasajerosGrid.Size = new System.Drawing.Size(343, 89);
            this.pasajerosGrid.TabIndex = 0;
            // 
            // pasajero
            // 
            this.pasajero.HeaderText = "Pasajero";
            this.pasajero.Name = "pasajero";
            this.pasajero.ReadOnly = true;
            // 
            // butaca
            // 
            this.butaca.HeaderText = "Butaca";
            this.butaca.Name = "butaca";
            this.butaca.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // ventasTableAdapter1
            // 
            this.ventasTableAdapter1.ClearBeforeFill = true;
            // 
            // pasajesTableAdapter1
            // 
            this.pasajesTableAdapter1.ClearBeforeFill = true;
            // 
            // paquetesTableAdapter1
            // 
            this.paquetesTableAdapter1.ClearBeforeFill = true;
            // 
            // pagos_TarjetaTableAdapter1
            // 
            this.pagos_TarjetaTableAdapter1.ClearBeforeFill = true;
            // 
            // tarjetas_CreditoTableAdapter
            // 
            this.tarjetas_CreditoTableAdapter.ClearBeforeFill = true;
            // 
            // CobroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 554);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CobroForm";
            this.Text = "Pago";
            this.Load += new System.EventHandler(this.CobroForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tarjetasCreditoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.encomiendaGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajerosGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.DateTimePicker fechaNacimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox pasajerosCombo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox medioPago;
        private System.Windows.Forms.ComboBox cuotas;
        private System.Windows.Forms.TextBox codigoSeguridad;
        private System.Windows.Forms.TextBox numeroTarjeta;
        private System.Windows.Forms.Label cuotasLabel;
        private System.Windows.Forms.Label vencimientoLabel;
        private System.Windows.Forms.Label codigoSeguridadLabel;
        private System.Windows.Forms.Label numeroTarjetaLabel;
        private System.Windows.Forms.Button comprar;
        private System.Windows.Forms.Label totalAPagar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView pasajerosGrid;
        private System.Windows.Forms.DataGridView encomiendaGrid;
        private System.Windows.Forms.Label tarjetaLabel;
        private GD2C2015DataSet gD2C2015DataSet;
        private GD2C2015DataSetTableAdapters.ClientesTableAdapter clientesTableAdapter1;
        private GD2C2015DataSetTableAdapters.VentasTableAdapter ventasTableAdapter1;
        private GD2C2015DataSetTableAdapters.PasajesTableAdapter pasajesTableAdapter1;
        private GD2C2015DataSetTableAdapters.PaquetesTableAdapter paquetesTableAdapter1;
        private GD2C2015DataSetTableAdapters.Pagos_TarjetaTableAdapter pagos_TarjetaTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pasajero;
        private System.Windows.Forms.DataGridViewTextBoxColumn butaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.ComboBox anioVencimiento;
        private System.Windows.Forms.ComboBox mesVenciemiento;
        private System.Windows.Forms.ComboBox tipoTarjeta;
        private System.Windows.Forms.BindingSource tarjetasCreditoBindingSource;
        private GD2C2015DataSetTableAdapters.Tarjetas_CreditoTableAdapter tarjetas_CreditoTableAdapter;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioEncomienda;
    }
}