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
    public partial class AeronavesReemplazo : Form
    {

        private Aeronave aer;
        private String motivo;
        private DateTime fechaHasta;
        private bool definitiva;
        public AeronavesReemplazo(int aerId, String motivo, DateTime fechaHasta)
        {
            
            aer = new Aeronave();
            aer.Id = aerId;
            this.motivo = motivo;
            definitiva = false;
            this.fechaHasta = fechaHasta;
            InitializeComponent();
        }

        public AeronavesReemplazo(int aerId, String motivo)
        {
            aer = new Aeronave();
            aer.Id = aerId;
            InitializeComponent();
            definitiva = true;
            this.fechaHasta = DateTime.MaxValue;
        }


        private void AeronavesReemplazo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Aeronaves' Puede moverla o quitarla según sea necesario.
            this.aeronavesTableAdapter.FillByReemplazo(this.gD2C2015DataSet.Aeronaves, aer.Id, this.fechaHasta);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 aer_id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            int aerReemplazo = 1 ;
            if (definitiva)
            {
                this.aeronavesTableAdapter.AeronavesReemplazoDef(aer.Id, aerReemplazo, fechaHasta);
            }
            else {
                this.aeronavesTableAdapter.AeronavesReemplazoFS(aer.Id, aerReemplazo,motivo,fechaHasta);
            }
            MessageBox.Show("La Aeronave se reemplazó correctamente.", "Info", MessageBoxButtons.OK);
            this.Close();

        }
    }
}
