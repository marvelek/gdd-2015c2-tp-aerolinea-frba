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
        private ArribosTableAdapter arribosTableAdapter = new ArribosTableAdapter();
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
            
            GD2C2015DataSet.CiudadesDataTable ciudadOrigen =  this.ciudadesTableAdapter.GetDataByDescripcionLower(origen.Text);

            GD2C2015DataSet.CiudadesDataTable ciudadDestino = this.ciudadesTableAdapter.GetDataByDescripcionLower(destino.Text);
            
            if (this.valido(aeronave, ciudadOrigen, ciudadDestino))
            {
                this.origen.Text = ciudadOrigen.First().ciu_descripcion;
                this.destino.Text = ciudadDestino.First().ciu_descripcion;
                arribosTableAdapter.Fill(dataSet.Arribos);
                int ciudad_origen_id = ciudadOrigen.First().ciu_id;
                int ciudad_destino_id = ciudadDestino.First().ciu_id;

                GD2C2015DataSet.RutasDataTable ruta = this.rutasTableAdapter.GetDataByOrigenDestino(ciudad_origen_id, ciudad_destino_id);

                int ruta_id = 0;
                   
                if (ruta.Count() > 0) 
                {
                    ruta_id = ruta.First().rut_id;
                }

                int aeronave_id = aeronave.First().aer_id;
                int destino_correcto = 0;
                DateTime fechaLlegada = this.fechaLlegada.Value;

                GD2C2015DataSet.VuelosDataTable vuelos = this.vuelosTableAdapter.GetDataByOrigenDestinoAeronave(ciudad_origen_id, aeronave_id, fechaLlegada);
                GD2C2015DataSet.VuelosRow vuelo = null;
                if(vuelos.Count() >= 1) 
                {
                    foreach (GD2C2015DataSet.VuelosRow row in vuelos) 
                    {
                        if (row.ruta_id == ruta_id)
                        {
                            vuelo = row;
                            destino_correcto = 1;
                        }
                    }

                    if (vuelo == null)
                    {
                        vuelo = vuelos.Last();
                    }

                    vuelo.vue_fecha_llegada = fechaLlegada;
                    vuelosTableAdapter.Update(vuelo);
                    arribosTableAdapter.Insert(aeronave_id, ciudad_origen_id, ciudad_destino_id, fechaLlegada, destino_correcto);

                    if (destino_correcto == 1)
                    {
                        MessageBox.Show("Se registró la llegada correctamente");
                    }
                    else 
                    {
                        MessageBox.Show("Se registró la llegada pero el vuelo no debería haber llegado a este aeropuerto");
                    }
                } else if (vuelos.Count() == 0)
                {
                    arribosTableAdapter.Insert(aeronave_id, ciudad_origen_id, ciudad_destino_id, fechaLlegada, destino_correcto);
                    MessageBox.Show("Se registró la llegada pero no se encontró un vuelo registrado");
                }
                this.limpiar_Click(this, null);
            }
        }

        private bool valido(GD2C2015DataSet.AeronavesRow[] aeronave, GD2C2015DataSet.CiudadesDataTable origen, GD2C2015DataSet.CiudadesDataTable destino)
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
            else if (origen.Count == 0) 
            {
                error = error + "No existe la ciudad de origen\n";
            }

            if (this.destino.Text == "")
            {
                error = error + "Debe seleccionar una ciudad destino\n";
            }
            else if (destino.Count == 0)
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
        }
    }
}
