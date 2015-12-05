using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.Canje_Millas;

namespace AerolineaFrba.Consulta_Millas
{
    public partial class BusquedaClienteForm : Form
    {

        private string retorno;
        public BusquedaClienteForm(string dni, string retornoParam)
        {
            InitializeComponent();
            retorno = retornoParam;
            this.dni.Text = dni;
            this.dni.Enabled = false;
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            if (valido()) 
            {
                string nombreCliente = nombre.Text;
                string apellidoCliente = apellido.Text;
                int dniCliente = Convert.ToInt32(dni.Text);

                GD2C2015DataSet.ClientesDataTable cliente = this.clientesTableAdapter1.GetDataByDniNombreApellido(dniCliente, nombreCliente, apellidoCliente);

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
                    int clienteId = cliente.First().cli_id;
                    int clienteDni = cliente.First().cli_dni;

                    if (retorno == "Consulta")
                    {
                        ConsultaMillasForm form = new ConsultaMillasForm(clienteId, clienteDni);
                        form.MdiParent = this.MdiParent;
                        form.Show();
                        this.Close();
                    }
                    else {
                        CanjeMillasForm form = new CanjeMillasForm(clienteId, clienteDni);
                        form.MdiParent = this.MdiParent;
                        form.Show();
                        this.Close();
                    }
                }
            }
        }

        private Boolean valido() 
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
