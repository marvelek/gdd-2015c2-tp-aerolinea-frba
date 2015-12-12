using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.Consulta_Millas;

namespace AerolineaFrba.Canje_Millas
{
    public partial class CanjeMillasForm : Form
    {
        int clienteId;
        int millasAcumuladas;
        bool volverABuscar = false;

        public CanjeMillasForm(int clienteIdParam, int dni)
        {
            InitializeComponent();
            this.productosTableAdapter.Fill(this.gD2C2015DataSet.Productos);
            this.clientesTableAdapter1.Fill(this.gD2C2015DataSet.Clientes);
            clienteId = clienteIdParam;
            if (clienteId != 0)
            {
                this.dni.Text = dni.ToString();
                this.button1_Click(this, null);
            }
        }

        private void CanjeMillasForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (this.valido())
                {
                    DataGridViewRow row = productosGrid.Rows[e.RowIndex];
                    int productoId = Convert.ToInt32(row.Cells[0].Value);
                    int cantidadACanjear = Convert.ToInt32(row.Cells[4].Value);
                    System.Diagnostics.Debug.Write(cantidadACanjear);
                    int millas = Convert.ToInt32(row.Cells[2].Value);
                    int stock = Convert.ToInt32(row.Cells[3].Value);
                    int cantidadMillasTotal = cantidadACanjear * millas;

                    if (this.validarSeleccion(cantidadACanjear, millas, stock))
                    {
                        try
                        {
                            productosTableAdapter.canjearProducto(clienteId, productoId, cantidadACanjear);
                            MessageBox.Show("El canje se realizó correctamente.");
                            millasAcumuladas = Convert.ToInt32(this.historialMillasTableAdapter1.millasDisponibles(clienteId));
                            millasLabel.Text = millasAcumuladas.ToString();
                        }
                        catch (System.Exception)
                        {
                            MessageBox.Show("Ha ocurrido un error al canjear el producto.\nSi el error persiste póngase en contacto con el Administrador.");
                        }
                        this.productosTableAdapter.Fill(this.gD2C2015DataSet.Productos);
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
            if (error != null)
            {
                MessageBox.Show(error);
                return false;
            }
            return true;
        }

        private Boolean validarSeleccion(int cantidadACanjear, int millas, int stock)
        {
            Utiles validador = new Utiles();
            string error = null;
            if (cantidadACanjear == 0)
            {
                error = "Seleccione una cantidad a canjear\n";
            }
            if (cantidadACanjear * millas > millasAcumuladas)
            {
                error = error + ("Las millas acumuladas no alcanzan para realizar el canje\n");
            }
            if (cantidadACanjear > stock)
            {
                error = error + ("No hay stock suficiente del producto para la cantidad seleccionada\n");
            }
            if (error != null)
            {
                MessageBox.Show(error);
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.clienteId != 0 && !this.volverABuscar)
            {
                GD2C2015DataSet.ClientesRow[] result = (GD2C2015DataSet.ClientesRow[])this.gD2C2015DataSet.Clientes.Select("cli_id='" + clienteId + "'");
                GD2C2015DataSet.ClientesRow row = result.First();
                clienteId = row.cli_id;
                this.nombreLabel.Text = row.cli_nombre;
                this.apellidoLabel.Text = row.cli_apellido;
                millasAcumuladas = Convert.ToInt32(this.historialMillasTableAdapter1.millasDisponibles(clienteId));
                millasLabel.Text = millasAcumuladas.ToString();
                this.volverABuscar = true;
            } 
            else if (this.valido())
            {
                GD2C2015DataSet.ClientesRow[] result = (GD2C2015DataSet.ClientesRow[])this.gD2C2015DataSet.Clientes.Select("cli_dni='" + this.dni.Text + "' AND cli_activo=1");
                if (result.Length == 0)
                {
                    MessageBox.Show("No existe el cliente con el dni ingresado");
                    return;
                }
                else if (result.Length > 1)
                {
                    BusquedaClienteForm form = new BusquedaClienteForm(this.dni.Text, "Canje");
                    form.MdiParent = this.MdiParent;
                    form.Show();
                    this.Close();
                }
                else
                {
                    GD2C2015DataSet.ClientesRow row = result.First();
                    clienteId = row.cli_id;
                    this.nombreLabel.Text = row.cli_nombre;
                    this.apellidoLabel.Text = row.cli_apellido;
                    millasAcumuladas = Convert.ToInt32(this.historialMillasTableAdapter1.millasDisponibles(clienteId));
                    millasLabel.Text = millasAcumuladas.ToString();
                    this.volverABuscar = true;
                }
            }
        }
    }
}
