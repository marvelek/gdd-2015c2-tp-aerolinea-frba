using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.Contenido;
using System.Data.SqlClient;

namespace AerolineaFrba.Compra
{
    public partial class CobroForm : Form
    {
        public List<Pasajero> pasajeros;
        public int vueloId;
        public bool pagaTarjeta = false;
        public int clienteId = 0;
        public bool administrador;
        public decimal precioTotal = 0;
        public decimal precioPasaje = 0;
        public decimal precioPaquete = 0;
        public Pasajero responsableEncomienda;

        public CobroForm()
        {
            InitializeComponent();
        }

        public CobroForm(List<Pasajero> pasajerosParams, Pasajero responsableEncomienda, int vueloIdParam, bool administrador)
        {
            InitializeComponent();
            this.responsableEncomienda = responsableEncomienda;
            this.administrador = administrador;
            this.clientesTableAdapter1.Fill(gD2C2015DataSet.Clientes);
            this.deshabilitarInputsComprador();
            this.medioPago.SelectedIndex = 0;

            if (!administrador)
            {
                this.medioPago.Enabled = false;
            }

            this.pasajeros = pasajerosParams;
            this.vueloId = vueloIdParam;
            this.llenarPasajerosCombo();
            this.pasajerosCombo.SelectedIndex = 0;
            this.calcularTotales();
        }

        private void llenarPasajerosCombo()
        { 
            int index = 0;
            this.pasajerosCombo.Items.Insert(index, "Otro");
            if (responsableEncomienda != null)
            {
                index = index + 1;
                this.pasajerosCombo.Items.Insert(index, responsableEncomienda.Nombre + ' ' + responsableEncomienda.Apellido);
            }
            foreach(Pasajero pasajero in pasajeros) 
            {
                index = index + 1;
                this.pasajerosCombo.Items.Insert(index, pasajero.Nombre + ' ' + pasajero.Apellido);
            }

        }

        private void esconderInputsTarjeta()
        {
            this.numeroTarjeta.Hide();
            this.numeroTarjetaLabel.Hide();
            this.tipoTarjeta.Hide();
            this.tarjetaLabel.Hide();
            this.codigoSeguridad.Hide();
            this.codigoSeguridadLabel.Hide();
            this.anioVencimiento.Hide();
            this.mesVenciemiento.Hide();
            this.vencimientoLabel.Hide();
            this.cuotas.Hide();
            this.cuotasLabel.Hide();
        }

        private void mostrarInputsTarjeta()
        {
            this.numeroTarjeta.Show();
            this.numeroTarjetaLabel.Show();
            this.tipoTarjeta.Show();
            this.tarjetaLabel.Show();
            this.codigoSeguridad.Show();
            this.codigoSeguridadLabel.Show();
            this.anioVencimiento.Show();
            this.mesVenciemiento.Show();
            this.vencimientoLabel.Show();
            this.cuotas.Show();
            this.cuotasLabel.Show();
        }

        private void clearInputsComprador() 
        {
            this.nombre.Clear();
            this.apellido.Clear();
            this.fechaNacimiento.ResetText();
            this.direccion.Clear();
            this.telefono.Clear();
            this.mail.Clear();
        }

        private void deshabilitarInputsComprador()
        {
            this.dni.Enabled = false;
            this.nombre.Enabled = false;
            this.apellido.Enabled = false;
            this.fechaNacimiento.Enabled = false;
            this.direccion.Enabled = false;
            this.telefono.Enabled = false;
            this.mail.Enabled = false;
        }

        private void habilitarInputsComprador()
        {
            this.dni.Enabled = true;
            this.nombre.Enabled = true;
            this.apellido.Enabled = true;
            this.fechaNacimiento.Enabled = true;
            this.direccion.Enabled = true;
            this.telefono.Enabled = true;
            this.mail.Enabled = true;
        }

        private void CobroForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Tarjetas_Credito' Puede moverla o quitarla según sea necesario.
            this.tarjetas_CreditoTableAdapter.Fill(this.gD2C2015DataSet.Tarjetas_Credito);
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            this.habilitarInputsComprador();
        }

        private void medioPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.medioPago.SelectedIndex == 0) 
            {
                this.pagaTarjeta = true;
                this.mostrarInputsTarjeta();
            }
            if (this.medioPago.SelectedIndex == 1)
            {
                this.pagaTarjeta = false;
                this.esconderInputsTarjeta();
            }

        }

        private void pasajerosCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int offset = 1;
            if (responsableEncomienda != null)
            {
                offset = 2;
            }

            if (this.pasajerosCombo.SelectedIndex > (offset - 1))
            {
                Pasajero pasajero = pasajeros[pasajerosCombo.SelectedIndex - offset];

                this.dni.Text = pasajero.Dni.ToString();
                this.nombre.Text = pasajero.Nombre;
                this.apellido.Text = pasajero.Apellido;
                this.fechaNacimiento.Value = pasajero.FechaNacimiento;
                this.direccion.Text = pasajero.Direccion;
                this.telefono.Text = pasajero.Telefono.ToString();
                this.mail.Text = pasajero.Mail;
                this.clienteId = pasajero.Id;
                this.deshabilitarInputsComprador();
            }
            else if (this.pasajerosCombo.SelectedIndex == 1 && responsableEncomienda != null)
            {
                this.dni.Text = responsableEncomienda.Dni.ToString();
                this.nombre.Text = responsableEncomienda.Nombre;
                this.apellido.Text = responsableEncomienda.Apellido;
                this.fechaNacimiento.Value = responsableEncomienda.FechaNacimiento;
                this.direccion.Text = responsableEncomienda.Direccion;
                this.telefono.Text = responsableEncomienda.Telefono.ToString();
                this.mail.Text = responsableEncomienda.Mail;
                this.clienteId = responsableEncomienda.Id;
                this.deshabilitarInputsComprador();
            }
            else
            {
                this.clienteId = 0;
                this.clearInputsComprador();
                this.dni.Clear();
                this.habilitarInputsComprador();
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (compradorValido()) 
            {
                if (clienteId == 0)
                {
                    try
                    {
                        this.clientesTableAdapter1.Insert(nombre.Text, apellido.Text, Convert.ToInt32(dni.Text), direccion.Text, Convert.ToInt32(telefono.Text), mail.Text, fechaNacimiento.Value, true);
                    }
                    catch (System.Exception)
                    {
                        MessageBox.Show("Ha ocurrido un error al intentar guardar el cliente.\nSi el problema persiste póngase en contacto con el administrador.");
                        return;
                    }
                    this.clientesTableAdapter1.Fill(gD2C2015DataSet.Clientes);
                    this.clienteId = gD2C2015DataSet.Clientes.Count();
                }
                else 
                {
                    GD2C2015DataSet.ClientesRow cliente = (GD2C2015DataSet.ClientesRow) this.gD2C2015DataSet.Clientes.Select("cli_id='"+ clienteId + "'").First();
                    cliente.cli_apellido = apellido.Text;
                    cliente.cli_nombre = nombre.Text;
                    cliente.cli_dni = Convert.ToInt32(dni.Text);
                    cliente.cli_direccion = direccion.Text;
                    cliente.cli_mail = mail.Text;
                    cliente.cli_telefono = Convert.ToInt32(telefono.Text);
                    cliente.cli_fecha_nacimiento = fechaNacimiento.Value;
                    clientesTableAdapter1.Update(cliente);
                }
                this.deshabilitarInputsComprador();
            }
        }

        private bool compradorValido()
        {
            Utiles validador = new Utiles();
            string error = null;
            if (this.dni.Text == "" || !validador.IsNumber(this.dni.Text))
            {
                error = "El DNI no puede ser nulo y solo debe contener numeros\n";
            }
            if (this.nombre.Text == "")
            {
                error = error + "El nombre no puede ser nulo\n";
            }
            if (this.apellido.Text == "")
            {
                error = error + "El apellido no puede ser vacio\n";
            }
            if (this.direccion.Text == "")
            {
                error = error + "La direccion no puede ser nula\n";
            }
            if (this.telefono.Text == "" || !validador.IsNumber(this.telefono.Text))
            {
                error = error + "El telefono no puede ser nulo y solo debe contener numeros\n";
            }
            if (error != null)
            {
                MessageBox.Show(error);
                return false;
            }
            return true;
        }
        private void dni_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Utiles validador = new Utiles();
                if (this.dni.Text != "" && validador.IsNumber(this.dni.Text))
                {
                    GD2C2015DataSet.ClientesRow[] result = (GD2C2015DataSet.ClientesRow[])this.gD2C2015DataSet.Clientes.Select("cli_dni='" + Convert.ToInt32(this.dni.Text) + "' AND cli_activo=1");
                    if (result.Length == 1)
                    {
                        GD2C2015DataSet.ClientesRow row = result.First();
                        this.nombre.Text = row.cli_nombre;
                        this.apellido.Text = row.cli_apellido;
                        this.direccion.Text = row.cli_direccion;
                        this.telefono.Text = row.cli_telefono.ToString();
                        this.mail.Text = row.cli_mail;
                        this.fechaNacimiento.Value = row.cli_fecha_nacimiento;
                        this.clienteId = row.cli_id;

                        this.deshabilitarInputsComprador();
                    }
                    else if (result.Length > 1)
                    {
                        this.buscar.Show();
                        MessageBox.Show("Ingrese el nombre y apellido y presione el botón Buscar");
                    }
                    else
                    {
                        clearInputsComprador();
                    }
                }
                else
                {
                    clearInputsComprador();
                }
            }
            catch (System.OverflowException)
            {

            }
        }
        private void calcularTotales()
        {
            if (pasajeros.Count() == 0)
            {
                pasajerosGrid.Hide();
            }
            if (responsableEncomienda == null)
            {
                encomiendaGrid.Hide();
            }

            precioPasaje = (decimal) pasajesTableAdapter1.precioPasaje(vueloId);

            foreach (Pasajero pasajero in pasajeros) 
            {
                pasajero.Precio = precioPasaje;
                pasajerosGrid.Rows.Add(pasajero.Nombre + ' ' + pasajero.Apellido, pasajero.ButacaString, precioPasaje);
            }

            precioPaquete = (decimal) paquetesTableAdapter1.precioPaquete(vueloId, responsableEncomienda.PesoPaquete);

            if (responsableEncomienda != null)
            {
                responsableEncomienda.Precio = precioPaquete;
                encomiendaGrid.Rows.Add(responsableEncomienda.Nombre + ' ' + responsableEncomienda.Apellido, responsableEncomienda.PesoPaquete, precioPaquete);
            }

            precioTotal = precioPasaje * pasajeros.Count() + precioPaquete;
            this.totalAPagar.Text = precioTotal.ToString();
        }

        private void comprar_Click(object sender, EventArgs e)
        {
            if (datosCompraValidos()) 
            {
                ventasTableAdapter1.Connection.Open();
                SqlTransaction transaccion = ventasTableAdapter1.Connection.BeginTransaction();
                ventasTableAdapter1.Transaction = transaccion;
                try
                {
                    int ventaId;
                    if (pagaTarjeta)
                    {
                        decimal numeroTarjeta = Convert.ToDecimal(this.numeroTarjeta.Text);
                        int tarjetaId = Convert.ToInt32(this.tipoTarjeta.SelectedValue);
                        int codigoSeguridad = Convert.ToInt32(this.codigoSeguridad.Text);
                        int añoVencimiento = Convert.ToInt32(this.anioVencimiento.Text);
                        int mesVenciemiento = Convert.ToInt32(this.mesVenciemiento.Text);
                        int cantidadCuotas = Convert.ToInt32(this.cuotas.Text);

                        int pagoTarjetaId = Convert.ToInt32(ventasTableAdapter1.pagoTarjeta(numeroTarjeta, tarjetaId, codigoSeguridad, añoVencimiento, mesVenciemiento, cantidadCuotas));
                        ventaId = Convert.ToInt32(ventasTableAdapter1.generarVenta(vueloId, clienteId, pagoTarjetaId));
                    }
                    else
                    {
                        ventaId = Convert.ToInt32(ventasTableAdapter1.generarVenta(vueloId, clienteId, null));
                    }

                    foreach (Pasajero pasajero in pasajeros)
                    {
                        int codigoPasaje = Convert.ToInt32(ventasTableAdapter1.generarPasaje(ventaId, pasajero.Id, pasajero.ButacaId, precioPasaje));
                        pasajero.CodigoPasaje = codigoPasaje;
                    }

                    if (responsableEncomienda != null)
                    {
                        int codigoPaquete = Convert.ToInt32(ventasTableAdapter1.generarPaquete(ventaId, responsableEncomienda.Id, responsableEncomienda.PesoPaquete, precioPaquete));
                        responsableEncomienda.CodigoPasaje = codigoPaquete;
                    }
                    transaccion.Commit();
                }
                catch (System.Exception ex)
                {
                    transaccion.Rollback();
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Ha ocurrido un error al intentar realizar la compra.\nSi el problema persiste póngase en contacto con el administrador.");
                    return;
                }
                finally
                {
                    ventasTableAdapter1.Connection.Close();
                }

                MessageBox.Show("La compra fue realizada con éxito");

                ResumenForm form = new ResumenForm(pasajeros, responsableEncomienda, vueloId, precioTotal);
                form.MdiParent = this.MdiParent;
                form.Show();
                this.Close();
            }
        }

        private Boolean datosCompraValidos() 
        {
            Utiles validador = new Utiles();
            string error = null;
            if (clienteId == 0)
            {
                error = "Debe seleccionar un comprador\n";
            }
            if (this.pagaTarjeta) 
            {
                if (this.numeroTarjeta.Text.Length < 12 || !validador.IsNumber(this.numeroTarjeta.Text))
                {
                    error = error + "El número de tarjeta debe tener 12 números\n";
                }
                if (this.codigoSeguridad.Text.Length < 3 || !validador.IsNumber(this.codigoSeguridad.Text))
                {
                    error = error + "El código de seguridad debe tener 3 números\n";
                }
                if (this.mesVenciemiento.SelectedIndex == -1)
                {
                    error = error + "Debe seleccionar un mes de vencimiento\n";
                }
                if (this.anioVencimiento.SelectedIndex == -1)
                {
                    error = error + "Debe seleccionar un año de vencimiento\n";
                }
                if (this.cuotas.SelectedIndex == -1)
                {
                    error = error + "Debe seleccionar la cantidad de cuotas\n";
                }
                if (this.tipoTarjeta.SelectedIndex == -1)
                {
                    error = error + "Debe seleccionar la tarjeta\n";
                }
            }
            if (error != null)
            {
                MessageBox.Show(error);
                return false;
            }
            return true;
        }

        private void tipoTarjeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tipoTarjeta.SelectedIndex > 0)
            {
                GD2C2015DataSet.Tarjetas_CreditoRow tarjeta = (GD2C2015DataSet.Tarjetas_CreditoRow)gD2C2015DataSet.Tarjetas_Credito.Select("tac_id='" + tipoTarjeta.SelectedValue + "'").First();

                if (tarjeta.tac_admite_cuotas)
                {
                    cuotas.Enabled = true;
                }
                else
                {
                    cuotas.SelectedIndex = 0;
                    cuotas.Enabled = false;
                }

            }
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if (validoDniDuplicado())
            {
                GD2C2015DataSet.ClientesDataTable cliente = this.clientesTableAdapter1.GetDataByDniNombreApellido(Convert.ToInt32(dni.Text), nombre.Text, apellido.Text);

                if (cliente.Count() == 0)
                {
                    MessageBox.Show("No se encontró el cliente");
                }
                else if (cliente.Count() > 1)
                {
                    MessageBox.Show("Error en el sistema, contacte a un administrador");
                }
                else
                {
                    GD2C2015DataSet.ClientesRow row = cliente.First();
                    this.nombre.Text = row.cli_nombre;
                    this.apellido.Text = row.cli_apellido;
                    this.direccion.Text = row.cli_direccion;
                    this.telefono.Text = row.cli_telefono.ToString();
                    this.mail.Text = row.cli_mail;
                    this.fechaNacimiento.Value = row.cli_fecha_nacimiento;
                    this.clienteId = row.cli_id;

                    this.deshabilitarInputsComprador();
                }
            }
        }

        private Boolean validoDniDuplicado()
        {
            Utiles validador = new Utiles();
            string error = null;
            if (this.dni.Text == "" || !validador.IsNumber(this.dni.Text))
            {
                error = "El DNI no puede ser nulo y solo debe contener numeros\n";
            }
            if (this.nombre.Text == "")
            {
                error = error + "El nombre no puede ser nulo\n";
            }
            if (this.apellido.Text == "")
            {
                error = error + "El apellido no puede ser vacio\n";
            }
            if (error != null)
            {
                MessageBox.Show(error);
                return false;
            }
            return true;
        }
    }
}
