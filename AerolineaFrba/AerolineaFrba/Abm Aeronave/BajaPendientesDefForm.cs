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
    public partial class BajaPendientesDefForm : Form
    {
        private Aeronave aer;
        public BajaPendientesDefForm(int aerId)
        {
            InitializeComponent();
            aer = new Aeronave();
            aer.Id = aerId;
        }

        private void reemplazarBut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No hay Aeronaves disponibles. De de alta una nueva e intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
       
       
        }

        private void CancelarVueBut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO. Cancelación de los vuelos de la aeronave.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
