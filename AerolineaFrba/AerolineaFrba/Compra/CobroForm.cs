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

namespace AerolineaFrba.Compra
{
    public partial class CobroForm : Form
    {
        public List<Pasajero> pasajeros;
        public int vueloId;
        public bool pagaTarjeta = false;
        public int clienteId = 0;
        public bool administrador;
        public int pesoPaquete;
        public decimal precioTotal = 0;
        public decimal precioPasaje = 0;
        public decimal precioPaquete = 0;

        public CobroForm()
        {
            InitializeComponent();
        }

        public CobroForm(List<Pasajero> pasajerosParams, int vueloIdParam, bool administrador, int pesoEncomienda)
        {
            InitializeComponent();
            this.pesoPaquete = pesoEncomienda;
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
            this.vencimiento.Hide();
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
            this.vencimiento.Show();
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

        private void otro_Click(object sender, EventArgs e)
        {
            this.pasajerosCombo.SelectedIndex = 0;
            this.clienteId = 0;
            this.clearInputsComprador();
            this.dni.Clear();
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
            if (this.pasajerosCombo.SelectedIndex > 0)
            {
                Pasajero pasajero = pasajeros[pasajerosCombo.SelectedIndex - 1];

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
            else 
            {
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
                    this.clientesTableAdapter1.Insert(nombre.Text, apellido.Text, Convert.ToInt32(dni.Text), direccion.Text, Convert.ToInt32(telefono.Text), mail.Text, fechaNacimiento.Value, true);
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
                    if (result.Length > 0)
                    {
                        GD2C2015DataSet.ClientesRow row = result.First();
                        this.nombre.Text = row.cli_nombre;
                        this.apellido.Text = row.cli_apellido;
                        this.direccion.Text = row.cli_direccion;
                        this.telefono.Text = row.cli_telefono.ToString();
                        this.mail.Text = row.cli_mail;
                        this.fechaNacimiento.Value = row.cli_fecha_nacimiento;
                        this.clienteId = row.cli_id;
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
            if (pesoPaquete == 0)
            {
                encomiendaGrid.Hide();
            }

            precioPasaje = (decimal) pasajesTableAdapter1.precioPasaje(vueloId);

            foreach (Pasajero pasajero in pasajeros) 
            {
                pasajerosGrid.Rows.Add(pasajero.Nombre + ' ' + pasajero.Apellido, pasajero.ButacaString, precioPasaje);
            }

            precioPaquete = (decimal) paquetesTableAdapter1.precioPaquete(vueloId, pesoPaquete);

            if (pesoPaquete != 0)
            {
                encomiendaGrid.Rows.Add(pesoPaquete, precioPaquete);
            }

            precioTotal = precioPasaje * pasajeros.Count() + precioPaquete;
            this.totalAPagar.Text = precioTotal.ToString();
        }

        private void comprar_Click(object sender, EventArgs e)
        {
            if (!pagaTarjeta) 
            {
                int ventaId = Convert.ToInt32(ventasTableAdapter1.generarVenta(vueloId, clienteId, null));

                foreach (Pasajero pasajero in pasajeros)
                {
                    int codigoPasaje = Convert.ToInt32(pasajesTableAdapter1.generarPasaje(ventaId, pasajero.Id, pasajero.ButacaId, precioPasaje));
                    pasajero.CodigoPasaje = codigoPasaje;
                }

                if (pesoPaquete != 0)
                {
                    paquetesTableAdapter1.generarPaquete(ventaId, pesoPaquete, precioPaquete);
                }

            }
        }

        private Boolean datosCompraValidos() 
        {
            return true;
        }
    }
}
