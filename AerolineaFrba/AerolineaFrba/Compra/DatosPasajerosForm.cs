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
using AerolineaFrba.GD2C2015DataSetTableAdapters;
using AerolineaFrba.Consulta_Millas;

namespace AerolineaFrba.Compra
{
    public partial class DatosPasajerosForm : Form
    {
        private int clienteId;
        private int vueloId;
        private int cantidadPasajeros;
        private int pesoEncomienda;
        public List<Pasajero> pasajeros;
        public Pasajero responsableEncomienda;
        public bool administrador;
        public clienteDisponibleParaVueloTableAdapter clienteDiponibleParaVueloTableAdapter = new clienteDisponibleParaVueloTableAdapter();

        private ClientesTableAdapter clientesTableAdapter = new ClientesTableAdapter();

        public DatosPasajerosForm()
        {
            InitializeComponent();
        }

        public DatosPasajerosForm(int vuelo_id, int cantidad_pasajeros, int peso_encomienda, bool administrador)
        {
            InitializeComponent();
            this.administrador = administrador;
            this.clienteId = 0;
            this.vueloId = vuelo_id;
            this.pasajeros = new List<Pasajero>();
            this.cantidadPasajeros = cantidad_pasajeros;
            this.pesoEncomienda = peso_encomienda;
            this.clientesTableAdapter.Fill(this.gD2C2015DataSet.Clientes);
            this.butacasDisponiblesTableAdapter.Fill(this.gD2C2015DataSet.ButacasDisponibles, vuelo_id);
            this.pasajeroGrupo.Text = "Pasajero 1 de " + cantidadPasajeros;

            if (peso_encomienda != 0)
            {
                this.butacaLabel.Hide();
                this.butacas.Hide();
                this.pasajeroGrupo.Text = "Responsable de Encomienda";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.valido())
            {
                Pasajero pasajero = new Pasajero();
                pasajero.Dni = Convert.ToInt32(this.dni.Text);
                pasajero.Nombre = this.nombre.Text;
                pasajero.Apellido = this.apellido.Text;
                pasajero.Direccion = this.direccion.Text;
                pasajero.Mail = this.mail.Text;
                pasajero.Telefono = Convert.ToInt32(this.telefono.Text);
                pasajero.FechaNacimiento = this.fechaNacimiento.Value;
                pasajero.Id = this.clienteId;
                int butacaId = (int)this.butacas.SelectedValue;
                pasajero.ButacaId = butacaId;
                pasajero.ButacaString = this.butacas.Text;

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
                    GD2C2015DataSet.ClientesRow cliente = (GD2C2015DataSet.ClientesRow)this.gD2C2015DataSet.Clientes.Select("cli_id='" + clienteId + "'").First();
                    cliente.cli_apellido = apellido.Text;
                    cliente.cli_nombre = nombre.Text;
                    cliente.cli_dni = Convert.ToInt32(dni.Text);
                    cliente.cli_direccion = direccion.Text;
                    cliente.cli_mail = mail.Text;
                    cliente.cli_telefono = Convert.ToInt32(telefono.Text);
                    cliente.cli_fecha_nacimiento = fechaNacimiento.Value;
                    clientesTableAdapter1.Update(cliente);
                }

                if (pesoEncomienda > 0 && responsableEncomienda == null)
                {
                    responsableEncomienda = pasajero;
                    responsableEncomienda.PesoPaquete = pesoEncomienda;
                    MessageBox.Show("Responsable de Encomienda cargado");
                }
                else
                {
                    pasajeros.Add(pasajero);
                    MessageBox.Show("Pasajero " + pasajeros.Count() + " cargado");
                }
                
                if (this.pasajeros.Count >= this.cantidadPasajeros)
                {
                    CobroForm form = new CobroForm(this.pasajeros, responsableEncomienda, vueloId, administrador);
                    form.MdiParent = this.MdiParent;
                    form.Show();
                    this.Close();
                }
                else
                {
                    limpiarDatos();
                    this.dni.Clear();
                    this.butacas.SelectedIndex = 0;
                    int numeroDeProximoPasajero = this.pasajeros.Count() + 1;
                    pasajeroGrupo.Text = "Pasajero " + numeroDeProximoPasajero + " de " + cantidadPasajeros;
                    this.butacaLabel.Show();
                    this.butacas.Show();
                    gD2C2015DataSet.ButacasDisponibles.RemoveButacasDisponiblesRow(gD2C2015DataSet.ButacasDisponibles.FindBybut_id(butacaId));
                }
            }
        }

        private bool valido()
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
            if (responsableEncomienda != null && this.cantidadPasajeros > 0 && this.butacas.Text == "" || this.butacas.SelectedIndex == -1)
            {
                error = error + "Debe seleccionar una butaca\n";
            }
            if (!this.clienteDisponible())
            {
                error = error + "El ya tiene un vuelo programado para las fechas del vuelo seleccionado\n";
            }
            if (error != null)
            {
                MessageBox.Show(error);
                return false;
            }
            return true;
        }

        private bool clienteDisponible()
        {

            if (clienteId == 0 || responsableEncomienda == null && pesoEncomienda > 0)
            {
                return true;
            }
            else
            {
                GD2C2015DataSet.clienteDisponibleParaVueloDataTable clientes = clienteDiponibleParaVueloTableAdapter.GetData(clienteId, vueloId);
                return clientes.Rows.Count == 1;
            }
        }

        private void dni_TextChanged(object sender, EventArgs e)
        {
            try {
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
                    }
                    else if (result.Length > 1)
                    {
                        this.buscar.Show();
                        MessageBox.Show("Ingrese el nombre y apellido y presione el botón Buscar");
                    }
                    else
                    {
                        limpiarDatos();
                    }
                }
                else
                {
                    limpiarDatos();
                }
            } 
            catch (System.OverflowException)
            {

            }
        }

        private void limpiarDatos() {
            this.nombre.Clear();
            this.apellido.Clear();
            this.direccion.Clear();
            this.telefono.Clear();
            this.mail.Clear();
            this.fechaNacimiento.ResetText();
            this.clienteId = 0;
        }

        private void DatosPasajerosForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter1.Fill(this.gD2C2015DataSet.Clientes);

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
