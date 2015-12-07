using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.GD2C2015DataSetTableAdapters;
using AerolineaFrba.Consulta_Millas;

namespace AerolineaFrba.Consulta_Millas
{
    public partial class ConsultaMillasForm : Form
    {
        public int clienteId;
        public ConsultaMillasForm(int clienteIdParam, int dni)
        {
            InitializeComponent();
            clienteId = clienteIdParam;
            if (clienteId != 0)
            {
                this.dni.Text = dni.ToString();
                this.buscar_Click(this, null);
            }
            
            this.clientesTableAdapter1.Fill(this.gD2C2015DataSet.Clientes);
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if (clienteId == 0 && this.valido())
            {
                GD2C2015DataSet.ClientesRow[] result = (GD2C2015DataSet.ClientesRow[])this.gD2C2015DataSet.Clientes.Select("cli_dni='" + this.dni.Text + "' AND cli_activo=1");
                if (result.Length == 0)
                {
                    MessageBox.Show("No existe el cliente con el dni ingresado");
                    return;
                }
                else if (result.Length > 1)
                {
                    BusquedaClienteForm form = new BusquedaClienteForm(this.dni.Text, "Consulta");
                    form.MdiParent = this.MdiParent;
                    form.Show();
                    this.Close();
                }
                else
                {
                    GD2C2015DataSet.ClientesRow row = result.First();
                    clienteId = row.cli_id;
                }
            }
            this.millas_acumuladas.Text = this.historialMillasTableAdapter.millasDisponibles(clienteId).ToString();
            this.clienteId = 0;
        }
        private Boolean valido()
        {
            Utiles validador = new Utiles();
            string error = null;
            if (this.dni.Text == "" || !validador.IsNumber(this.dni.Text))
            {
                error = "El DNI no puede ser nulo y solo debe contener numeros\n";
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
