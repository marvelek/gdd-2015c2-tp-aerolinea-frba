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
    public partial class DatosPasajerosForm : Form
    {
        private int vueloId;
        private int cantidadPasajeros;
        private int pesoEncomienda;
        private Pasajero[] pasajeros;

        public DatosPasajerosForm()
        {
            InitializeComponent();
        }

        public DatosPasajerosForm(int vuelo_id, int cantidad_pasajeros, int peso_encomienda)
        {
            InitializeComponent();
            this.vueloId = vuelo_id;
            this.cantidadPasajeros = cantidad_pasajeros;
            this.pasajeros = new Pasajero[cantidad_pasajeros];
            this.pesoEncomienda = peso_encomienda;
        }
    }
}
