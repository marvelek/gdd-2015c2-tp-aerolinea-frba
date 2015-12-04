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
        private int[] rutasArray;
        private int[] aeronavesArray;

        public GenerarViajeForm()
        {
            InitializeComponent();
            this.fechaSalida.Value = DateTime.Today;
            this.fechaLlegadaEstimada.Value = DateTime.Today;
            this.fillRutas();
            this.fillAeronaves();
        }

        private void fillAeronaves()
        {
            this.aeronaves.Items.Clear();
            this.aeronavesTableAdapter.Fill(this.dataSet.Aeronaves);
            this.tipos_ServicioTableAdapter.Fill(this.dataSet.Tipos_Servicio);
            GD2C2015DataSet.AeronavesRow[] rows = (GD2C2015DataSet.AeronavesRow[])dataSet.Aeronaves.Select("aer_activo=1");
            aeronavesArray = new int[rows.Count()];
            int index = 0;
            foreach (GD2C2015DataSet.AeronavesRow row in rows)
            {
                string aux = row.aer_matricula + " - " + row.aer_modelo + " - " + row.Tipos_ServicioRow.tip_descripcion;
                this.aeronaves.Items.Insert(index, aux);
                aeronavesArray[index] = row.aer_id;
                index = index + 1;
            }

        }

        private void fillRutas()
        {
            this.rutas.Items.Clear();
            this.ciudadesTableAdapter.Fill(this.dataSet.Ciudades);
            this.rutasTableAdapter.Fill(this.dataSet.Rutas);
            GD2C2015DataSet.RutasRow[] rows = (GD2C2015DataSet.RutasRow[])dataSet.Rutas.Select("rut_activo=1");
            rutasArray = new int[rows.Count()];
            int index = 0;
            foreach (GD2C2015DataSet.RutasRow row in rows){
                string aux = row.CiudadesRowByFK__Rutas__ciudad_or__6B79F03D.ciu_descripcion + " - " + row.CiudadesRowByFK__Rutas__ciudad_de__6C6E1476.ciu_descripcion + " - " + row.rut_codigo.ToString();
                this.rutas.Items.Insert(index, aux);
                rutasArray[index] = row.rut_id;
                index = index + 1;
            }
        }

        private void GenerarViajeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void generar_Click(object sender, EventArgs e)
        {
            if (this.valido())
            {
                int aeronaveId = this.aeronavesArray[this.aeronaves.SelectedIndex];
                int rutaId = this.rutasArray[this.rutas.SelectedIndex];
                this.vuelosTableAdapter.Insert(rutaId, aeronaveId, this.fechaSalida.Value, this.fechaLlegadaEstimada.Value, null, true);
                this.vuelosTableAdapter.Fill(this.dataSet.Vuelos);
                MessageBox.Show("El viaje ha sido guardado correctamente");
                this.Close();
            }
            else
            {
                return;
            }
        }

        private bool valido()
        {
            string error = null;

            if (this.rutas.Text == "" || this.rutas.SelectedIndex == -1)
            {
                error = "La ruta no puede ser nula\n";
            }
            if (this.aeronaves.Text == "" || this.aeronaves.SelectedIndex == -1)
            {
                error = error + "Debe seleccionar un aeronave\n";
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
                if (this.serviciosNoConcuerdan())
                {
                    error = error + "El servicio del aeronave no concuerda con el servicio de la ruta\n";
                }
                if (this.aeronaveNoDisponible())
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

        private bool aeronaveNoDisponible()
        {
            bool result = false;
            int aeronaveId = this.aeronavesArray[this.aeronaves.SelectedIndex];
            DateTime fecha = this.fechaSalida.Value;
            this.vuelosTableAdapter.Fill(this.dataSet.Vuelos);
            GD2C2015DataSet.VuelosRow[] row = (GD2C2015DataSet.VuelosRow[])this.dataSet.Vuelos.Select("aeronave_id='" + aeronaveId + "' AND vue_fecha_salida='" + fecha + "'");
            if (row.Length > 0)
            {
                result = true;
            }
            return result;
        }

        private bool serviciosNoConcuerdan()
        {
            bool result = false;
            int aeronaveId = this.aeronavesArray[this.aeronaves.SelectedIndex];
            int rutaId = this.rutasArray[this.rutas.SelectedIndex];
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
            this.rutas.ResetText();
            this.aeronaves.ResetText();
            this.fechaSalida.Value = DateTime.Today;
            this.fechaLlegadaEstimada.Value = DateTime.Today;
        }
    }
}
