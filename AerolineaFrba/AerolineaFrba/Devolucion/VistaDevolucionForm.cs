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

namespace AerolineaFrba.Devolucion
{
    public partial class VistaDevolucionForm : Form
    {
        string tipo = null;
        int venta;
        string pasaje;
        int devolucion;
        public VistaDevolucionForm(string tipo, int venta, string pasaje, int devolucion)
        {
            InitializeComponent();

            this.tipo = tipo;
            this.venta = venta;
            this.pasaje = pasaje;
            this.devolucion = devolucion;
        }

        private void Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void VistaDevolucionForm_Load(object sender, EventArgs e)
        {
            switch (this.tipo)
            {
                case "VENTAS":
                    this.label3.Visible = false;
                    this.codigo.Visible = false;
                    break;
                case "PAQUETES":
                    this.label3.Visible = true;
                    this.label3.Text = "Código de Paquete:";
                    this.codigo.Visible = true;
                    break;
                case "PASAJES":
                    this.label3.Visible = true;
                    this.label3.Text = "Código de Pasaje:";
                    this.codigo.Visible = true;
                    break;
                default:
                    MessageBox.Show("Ha ocurrido un error. Por favor, seleccione un registro e intente de nuevo.");
                    return;                    
            }
            
            this.compra.Text = this.venta.ToString();
            this.codigo.Text = this.pasaje.ToString();
            this.Id.Text = this.devolucion.ToString();
        }

        private void Motivo_Click(object sender, EventArgs e)
        {

        }

        private void motivoData_TextChanged(object sender, EventArgs e)
        {

        }

        private void VistaDevolucionForm_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Devoluciones' Puede moverla o quitarla según sea necesario.
            this.compra.Text = this.venta.ToString();
            this.codigo.Text = this.pasaje.ToString();
            this.Id.Text = this.devolucion.ToString();
            this.devolucionesTableAdapter.devolucionBusca(Convert.ToInt16(this.devolucion.ToString()));           
        }
    }
}
