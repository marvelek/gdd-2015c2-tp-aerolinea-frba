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

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class BajaPendientesFSForm : Form
    {

        private Aeronave aer;
        private String motivo;
        private DateTime fechaHasta; 
        public BajaPendientesFSForm(int aerId, String motivo, DateTime fechaHasta)
        {
            InitializeComponent();
            aer = new Aeronave();
            this.motivo = motivo;
            this.fechaHasta = fechaHasta;
        }

        private void reemplazarBut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No hay Aeronaves disponibles. Dé de alta una nueva para poder hacer un reemplazo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void CancelarVueBut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO. Cancelación de los vuelos de la aeronave.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
       
        }
    }
}
