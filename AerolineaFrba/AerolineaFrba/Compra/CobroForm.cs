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
        public int clienteId;
        public bool administrador;

        public CobroForm()
        {
            InitializeComponent();
        }

        public CobroForm(List<Pasajero> pasajerosParams, int vueloIdParam, bool administrador)
        {
            InitializeComponent();
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
        }

        private void llenarPasajerosCombo()
        { 
            int index = 0;
            foreach(Pasajero pasajero in pasajeros) 
            {
                this.pasajerosCombo.Items.Insert(index, pasajero.Nombre + ' ' + pasajero.Apellido);
                index = index + 1;
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
            this.dni.Clear();
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
            this.pasajerosCombo.SelectedIndex = -1;
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
            if (this.pasajerosCombo.SelectedIndex != -1) 
            {
                this.dni.Text = pasajeros[pasajerosCombo.SelectedIndex].Dni.ToString();
                this.nombre.Text = pasajeros[pasajerosCombo.SelectedIndex].Nombre;
                this.apellido.Text = pasajeros[pasajerosCombo.SelectedIndex].Apellido;
                this.fechaNacimiento.Value = pasajeros[pasajerosCombo.SelectedIndex].FechaNacimiento;
                this.direccion.Text = pasajeros[pasajerosCombo.SelectedIndex].Direccion;
                this.telefono.Text = pasajeros[pasajerosCombo.SelectedIndex].Telefono.ToString();
                this.mail.Text = pasajeros[pasajerosCombo.SelectedIndex].Mail;
                this.clienteId = pasajeros[pasajerosCombo.SelectedIndex].Id;
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (compradorValido()) 
            {
                if (clienteId == 0)
                {
                    this.clientesTableAdapter1.Insert(nombre.Text, apellido.Text, Convert.ToInt32(dni.Text), direccion.Text, Convert.ToInt32(telefono.Text), mail.Text, fechaNacimiento.Value, true);
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
    }
}
