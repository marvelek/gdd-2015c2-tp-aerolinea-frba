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
    public partial class BajaAeronavesFSForm : Form
    {

        private Aeronave aer;
        public BajaAeronavesFSForm(int aerId)
        {
            InitializeComponent();
            aer = new Aeronave();
            aer.Id = aerId;
        }

        private void BajaAeronavesFSForm_Load(object sender, EventArgs e)
        {

        }

        private void ContinuarBut_Click(object sender, EventArgs e)
        {
            String motivo = this.motivoBox.Text;
            if (motivo == "")
            {
                MessageBox.Show("Debe completar un motivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.fechaHastaPicker.Value.CompareTo(DateTime.Now) < 0)
            {
                MessageBox.Show("Debe insertar una fecha futura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (aer.tieneVuelosPendientesFS(aer.Id, this.fechaHastaPicker.Value))
            {
                BajaPendientesFSForm form = new BajaPendientesFSForm(aer.Id, motivo, this.fechaHastaPicker.Value);
                form.ShowDialog();
                this.Close();
            }
            else
            {
                aer.fueraDeServicioHasta(aer.Id, motivo, this.fechaHastaPicker.Value);
                this.Close();
            }
        }

        private void CancelarBut_Click(object sender, EventArgs e)
        {

        }

        private void fechaHastaPicker_Validating(object sender, CancelEventArgs e)
        {
            if (this.fechaHastaPicker.Value.CompareTo(DateTime.Now) <= 0)
            {
                MessageBox.Show("Debe insertar una fecha futura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
