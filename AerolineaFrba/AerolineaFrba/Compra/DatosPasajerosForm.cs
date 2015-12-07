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

namespace AerolineaFrba.Compra
{
    public partial class DatosPasajerosForm : Form
    {
        private int clienteId;
        private int vueloId;
        private int cantidadPasajeros;
        private int pesoEncomienda;
        public List<Pasajero> pasajeros;
        public bool administrador;

        private ClientesTableAdapter clientesTableAdapter = new ClientesTableAdapter();
        private GD2C2015DataSet dataSet = new GD2C2015DataSet();

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
            this.clientesTableAdapter.Fill(this.dataSet.Clientes);
            this.butacasDisponiblesTableAdapter.Fill(this.gD2C2015DataSet.ButacasDisponibles, vuelo_id);
            this.pasajeroGrupo.Text = "Pasajero 1";

            if (cantidadPasajeros == 0 && peso_encomienda != 0)
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
                if (this.pasajeros.Count == 0 && pesoEncomienda != 0)
                {
                    pasajero.PesoEncomienda = this.pesoEncomienda;
                }
                else
                {
                    pasajero.PesoEncomienda = 0;
                }
                int butacaId = (int)this.butacas.SelectedValue;
                pasajero.ButacaId = butacaId;
                
                pasajeros.Add(pasajero);
                
                if (this.pasajeros.Count >= this.cantidadPasajeros)
                {
                    CobroForm form = new CobroForm(this.pasajeros, vueloId, administrador);
                    form.MdiParent = this.MdiParent;
                    form.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Pasajero cargado");
                    limpiarDatos();
                    this.butacas.SelectedIndex = 0;
                    int numeroDeProximoPasajero = this.pasajeros.Count() + 1;
                    pasajeroGrupo.Text = "Pasajero " + numeroDeProximoPasajero;
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
            if (this.butacas.Text == "" || this.butacas.SelectedIndex == -1)
            {
                error = error + "Debe seleccionar una butaca\n";
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
            try {
                Utiles validador = new Utiles();
                if (this.dni.Text != "" && validador.IsNumber(this.dni.Text))
                {
                    GD2C2015DataSet.ClientesRow[] result = (GD2C2015DataSet.ClientesRow[])this.dataSet.Clientes.Select("cli_dni='" + Convert.ToInt32(this.dni.Text) + "' AND cli_activo=1");
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
            this.dni.Clear();
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
    }
}
