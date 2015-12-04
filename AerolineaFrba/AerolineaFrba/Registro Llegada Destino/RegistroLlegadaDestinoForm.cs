using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.GD2C2015DataSetTableAdapters;

namespace AerolineaFrba.Registro_Llegada_Destino
{
    public partial class RegistroLlegadaDestinoForm : Form
    {
        private AeronavesTableAdapter aeronavesTableAdapter = new AeronavesTableAdapter();
        private CiudadesTableAdapter ciudadesTableAdapter = new CiudadesTableAdapter();
        private RutasTableAdapter rutasTableAdapter = new RutasTableAdapter();
        private VuelosTableAdapter vuelosTableAdapter = new VuelosTableAdapter();
        private GD2C2015DataSet dataSet = new GD2C2015DataSet();

        public RegistroLlegadaDestinoForm()
        {
            InitializeComponent();
            this.fechaLlegada.Value = DateTime.Today;
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            this.aeronavesTableAdapter.Fill(this.dataSet.Aeronaves);
            this.rutasTableAdapter.Fill(this.dataSet.Rutas);

            GD2C2015DataSet.AeronavesRow[] aeronave = (GD2C2015DataSet.AeronavesRow[])this.dataSet.Aeronaves.Select("aer_matricula='"+ matricula.Text + "'");
            
            this.ciudadesTableAdapter.FillByDescripcionLower(this.dataSet.Ciudades, origen.Text);
            GD2C2015DataSet.CiudadesRow[] ciudadOrigen = (GD2C2015DataSet.CiudadesRow[])this.dataSet.Ciudades.Select();

            this.ciudadesTableAdapter.FillByDescripcionLower(this.dataSet.Ciudades, destino.Text);
            GD2C2015DataSet.CiudadesRow[] ciudadDestino = (GD2C2015DataSet.CiudadesRow[])this.dataSet.Ciudades.Select();
            
            if (this.valido(aeronave, ciudadOrigen, ciudadDestino))
            {
                DateTime fechaLlegada = this.fechaLlegada.Value;

                MessageBox.Show("Se registro la llegada del vuelo " + aeronave.First().aer_id + ciudadDestino.First().ciu_descripcion  + " correctamente");
                this.Close();
            }
            else
            {
                return;
            }
        }

        private bool valido(GD2C2015DataSet.AeronavesRow[] aeronave,  GD2C2015DataSet.CiudadesRow[] origen,  GD2C2015DataSet.CiudadesRow[] destino)
        {
            string error = null;

            if (this.matricula.Text == "")
            {
                error = "La matricula no puede ser nula\n";
            } 
            else if (aeronave.Length == 0)
            {
                error = error + "No existe el aeronave con esa matrícula\n";
            }

            if (this.origen.Text == "")
            {
                error = error + "Debe seleccionar una ciudad origen\n";
            }
            else if (origen.Length == 0) 
            {
                error = error + "No existe la ciudad de origen\n";
            }

            if (this.destino.Text == "")
            {
                error = error + "Debe seleccionar una ciudad destino\n";
            }
            else if (destino.Length == 0)
            {
                error = error + "No existe la ciudad de destino\n";
            }

            if (error != null)
            {
                MessageBox.Show(error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            this.fechaLlegada.Value = DateTime.Today;
            this.matricula.ResetText();
            this.origen.ResetText();
            this.destino.ResetText();
        }

        private void RegistroLlegadaDestinoForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Aeronaves' Puede moverla o quitarla según sea necesario.
            this.aeronavesTableAdapter1.Fill(this.gD2C2015DataSet.Aeronaves);

        }
    }
}
