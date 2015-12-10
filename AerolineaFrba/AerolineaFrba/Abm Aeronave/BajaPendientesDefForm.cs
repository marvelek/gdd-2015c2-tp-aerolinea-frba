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
        private DateTime fechaHasta;
        public BajaPendientesDefForm(int aerId)
        {
            InitializeComponent();
            aer = new Aeronave();
            aer.Id = aerId;
        }

        private void reemplazarBut_Click(object sender, EventArgs e)
        {
            fechaHasta = DateTime.MaxValue;
            GD2C2015DataSet.AeronavesDataTable result = aer.buscarAeronavesDeReemplazo(aer.Id, fechaHasta);
            if (result.Count == 0)
            {
                MessageBox.Show("No existen aeronaves de reemplazo. Por favor de de alta una nueva aeronave o cancele los vuelos pendientes.", "Info", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {

                AeronavesReemplazo form = new AeronavesReemplazo(aer.Id, "Baja Definitiva");
                form.ShowDialog();
            }
            this.Close();
        }

        private void CancelarVueBut_Click(object sender, EventArgs e)
        {
            aer.cancelarVuelosDef(aer.Id);
            this.Close();
            MessageBox.Show("Todos los vuelos fueron cancelados. Se inactivó la aeronave.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
