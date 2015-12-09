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
            aer.Id = aerId;
            this.motivo = motivo;
            this.fechaHasta = fechaHasta;
        }

        private void reemplazarBut_Click(object sender, EventArgs e)
        {

            GD2C2015DataSet.AeronavesDataTable result = aer.buscarAeronavesDeReemplazo(aer.Id, fechaHasta);
            if (result.Count == 0)
            {
                MessageBox.Show("No existen aeronaves de reemplazo. Por favor de de alta una nueva aeronave o cancele los vuelos pendientes.", "Info", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                AeronavesReemplazo form = new AeronavesReemplazo(aer.Id, motivo, fechaHasta);
                form.ShowDialog();
            }
            this.Close();
        }

        private void CancelarVueBut_Click(object sender, EventArgs e)
        {
            aer.cancelarVuelosFs(aer.Id, motivo,fechaHasta);
            MessageBox.Show("Los vuelos fueron cancelados y inactivó la aeronave hasta la fecha indicada.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }
    }
}
