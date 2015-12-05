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

        public CanjeMillasForm(int clienteIdParam, int dni)
        {
            InitializeComponent();
            clienteId = clienteIdParam;
            if (clienteId != 0)
            {
                this.dni.Text = dni.ToString();
                this.button1_Click(this, null);
            }
        }

        private void CanjeMillasForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.gD2C2015DataSet.Productos);
            this.clientesTableAdapter1.Fill(this.gD2C2015DataSet.Clientes);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if (this.valido())
                {
                    DataGridViewRow row = productosGrid.Rows[e.RowIndex];
                    DataGridViewCell productoIdCell = row.Cells[0];
                    int cantidadACanjear = Convert.ToInt32(this.cantidad.Text);
                    int millas = Convert.ToInt32(row.Cells[2].Value);
                    int stock = Convert.ToInt32(row.Cells[3].Value);
                    int cantidadMillasTotal = cantidadACanjear * millas;
                    
                    if (cantidadACanjear > stock)
                    {
                        MessageBox.Show("No hay stock suficiente del producto");
                    }
                    else if (cantidadACanjear*millas > millasAcumuladas)
                    {
                        MessageBox.Show("Las millas acumuladas no alcanzan para realizar el canje");
                    }
                    else
                    {
                        //TODO: hacer el canje
                        MessageBox.Show("Se hizo el canje correctamente");
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
            if (this.cantidad.Text == "" || !validador.IsNumber(this.cantidad.Text))
            {
                error = error + "La cantidad no puede ser nulo y solo debe contener numeros\n";
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
                    BusquedaClienteForm form = new BusquedaClienteForm(this.dni.Text);
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
                }
            }
        }
    }
}
