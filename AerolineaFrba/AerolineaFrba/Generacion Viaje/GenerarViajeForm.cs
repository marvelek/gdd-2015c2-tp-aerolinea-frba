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

namespace AerolineaFrba.Generacion_Viaje
{
    public partial class GenerarViajeForm : Form
    {
        private AeronavesTableAdapter aeronavesTableAdapter = new AeronavesTableAdapter();
        private CiudadesTableAdapter ciudadesTableAdapter = new CiudadesTableAdapter();
        private RutasTableAdapter rutasTableAdapter = new RutasTableAdapter();
        private Tipos_ServicioTableAdapter tipos_ServicioTableAdapter = new Tipos_ServicioTableAdapter();
        private Tipos_Servicio_RutasTableAdapter tipos_Servicio_RutasTableAdapter = new Tipos_Servicio_RutasTableAdapter();
        private VuelosTableAdapter vuelosTableAdapter = new VuelosTableAdapter();
        private GD2C2015DataSet dataSet = new GD2C2015DataSet();

        public GenerarViajeForm()
        {
            InitializeComponent();
            this.fechaSalida.Value = DateTime.Today;
            this.fechaLlegadaEstimada.Value = DateTime.Today;
        }

        private void GenerarViajeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void generar_Click(object sender, EventArgs e)
        {
            this.aeronavesTableAdapter.Fill(this.dataSet.Aeronaves);
            this.rutasTableAdapter.Fill(this.dataSet.Rutas);

            GD2C2015DataSet.AeronavesRow[] aeronave = (GD2C2015DataSet.AeronavesRow[])this.dataSet.Aeronaves.Select("aer_matricula='" + matricula.Text + "' AND aer_activo=1");
            if (aeronave.Length == 0)
            {
                MessageBox.Show("No existe el aeronave con esa matrícula\n");
                return;
            }
            int aeronaveId = aeronave.First().aer_id;

            GD2C2015DataSet.CiudadesDataTable ciudadOrigen = this.ciudadesTableAdapter.GetDataByDescripcionLower(origen.Text);

            GD2C2015DataSet.CiudadesDataTable ciudadDestino = this.ciudadesTableAdapter.GetDataByDescripcionLower(destino.Text);

            if (this.valido(aeronaveId, ciudadOrigen, ciudadDestino))
            {
                this.origen.Text = ciudadOrigen.First().ciu_descripcion;
                this.destino.Text = ciudadDestino.First().ciu_descripcion;
                
                int rutaId = this.getRutaId(ciudadOrigen, ciudadDestino);

                try
                {
                    this.vuelosTableAdapter.Insert(rutaId, aeronaveId, this.fechaSalida.Value, this.fechaLlegadaEstimada.Value, null, true, null);
                    MessageBox.Show("El viaje ha sido guardado correctamente");
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Ha ocurrido un error al intentar registrar el viaje.\nSi el problema persiste póngase en contacto con el administrador.");
                    return;
                }
                
                this.vuelosTableAdapter.Fill(this.dataSet.Vuelos);
                this.Close();
            }
            else
            {
                return;
            }
        }

        private bool valido(int aeronaveId, GD2C2015DataSet.CiudadesDataTable origen, GD2C2015DataSet.CiudadesDataTable destino)
        {
            string error = null;

            if (this.matricula.Text == "")
            {
                error = "La matricula no puede ser nula\n";
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
            if ((this.fechaSalida.Value.Date.CompareTo(DateTime.Now.Date) < 0) || (this.fechaSalida.Value.Date.CompareTo(DateTime.Now.Date) == 0 && this.fechaSalida.Value.TimeOfDay.CompareTo(DateTime.Now.TimeOfDay) < 0))
            {
                error = error + "La fecha de salida debe ser posterior a ahora\n";
            }
            double aux = this.fechaLlegadaEstimada.Value.Subtract(this.fechaSalida.Value).TotalSeconds;
            if (aux > 86400 || aux <= 0)
            {
                error = error + "La fecha de llegada estimada no puede superar las 24hs de la fecha de salida o ser anterior\n";
            }
            if (error != null)
            {
                MessageBox.Show(error);
                return false;
            }
            else
            {
                int rutaId = this.getRutaId(origen, destino);

                if (this.serviciosNoConcuerdan(aeronaveId, rutaId))
                {
                    error = error + "El servicio del aeronave no concuerda con el servicio de la ruta\n";
                }
                if (this.aeronaveNoDisponible(aeronaveId))
                {
                    error = error + "El aeronave seleccionada no se encuentra disponible para la fecha ingresada\n";
                }
                if (error != null)
                {
                    MessageBox.Show(error);
                    return false;
                }
            }
            return true;
        }

        private int getRutaId(GD2C2015DataSet.CiudadesDataTable origen, GD2C2015DataSet.CiudadesDataTable destino)
        {
            int rutaId = 0;
            int ciudad_origen_id = origen.First().ciu_id;
            int ciudad_destino_id = destino.First().ciu_id;
            GD2C2015DataSet.RutasDataTable ruta = this.rutasTableAdapter.GetDataByOrigenDestino(ciudad_origen_id, ciudad_destino_id);
            if (ruta.Count() > 0)
            {
                rutaId = ruta.First().rut_id;
            }
            return rutaId;
        }

        private bool aeronaveNoDisponible(int aeronaveId)
        {
            bool result = false;
            DateTime fecha = this.fechaSalida.Value;
            this.vuelosTableAdapter.Fill(this.dataSet.Vuelos);
            GD2C2015DataSet.VuelosRow[] row = (GD2C2015DataSet.VuelosRow[])this.dataSet.Vuelos.Select("aeronave_id='" + aeronaveId + "' AND vue_fecha_salida='" + fecha + "'");
            if (row.Length > 0)
            {
                result = true;
            }
            return result;
        }

        private bool serviciosNoConcuerdan(int aeronaveId,int rutaId)
        {
            bool result = false;
            int tipoServicioId = 0;
            this.aeronavesTableAdapter.Fill(this.dataSet.Aeronaves);
            GD2C2015DataSet.AeronavesRow row1 = (GD2C2015DataSet.AeronavesRow)this.dataSet.Aeronaves.Select("aer_id='" + aeronaveId + "'").First();
            tipoServicioId = row1.tipo_servicio_id;
            this.tipos_Servicio_RutasTableAdapter.Fill(this.dataSet.Tipos_Servicio_Rutas);
            GD2C2015DataSet.Tipos_Servicio_RutasRow[] row2 = (GD2C2015DataSet.Tipos_Servicio_RutasRow[])this.dataSet.Tipos_Servicio_Rutas.Select("tipo_servicio_id='" + tipoServicioId + "' AND rut_id='" + rutaId + "'");
            if (row2.Length == 0)
            {
                result = true;
            }
            return result;
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            this.matricula.ResetText();
            this.origen.ResetText();
            this.destino.ResetText();
            this.fechaSalida.Value = DateTime.Today;
            this.fechaLlegadaEstimada.Value = DateTime.Today;
        }
    }
}
