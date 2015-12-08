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
    public partial class ResumenForm : Form
    {
        public ResumenForm(List<Pasajero> pasajeros, Pasajero responsableEncomienda, int vueloId, decimal totalAPagar)
        {
            InitializeComponent();
            inicializarLabel(vueloId, totalAPagar);
            llenarGrillaPasajes(pasajeros);
            llenarGrillaPaquete(responsableEncomienda);
        }

        private void inicializarLabel(int codigoVuelo, decimal toalAPagar)
        {
            this.codigo.Text = codigoVuelo.ToString();
            this.montoAbonado.Text = toalAPagar.ToString(); 
        }

        private void llenarGrillaPasajes(List<Pasajero> pasajeros)
        {
            foreach (Pasajero pasajero in pasajeros) 
            {
                this.pasajesGrid.Rows.Add(pasajero.Nombre + ' ' + pasajero.Apellido, pasajero.CodigoPasaje, pasajero.ButacaString, pasajero.Precio);
            }
        }

        private void llenarGrillaPaquete(Pasajero responsableEncomienda)
        {
            if (responsableEncomienda != null)
            {
                this.paqueteGrid.Show();
                this.grupoEncomienda.Show();
                this.paqueteGrid.Rows.Add(responsableEncomienda.Nombre + ' ' + responsableEncomienda.Apellido, responsableEncomienda.CodigoPasaje, responsableEncomienda.PesoPaquete, responsableEncomienda.Precio);
            }
            else
            {
                this.paqueteGrid.Hide();
                this.grupoEncomienda.Hide();
            }
            
        }
    }
}
