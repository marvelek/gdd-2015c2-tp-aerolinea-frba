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
        private int[] matriculasArray;
        private int[] ciudadesArray;

        public RegistroLlegadaDestinoForm()
        {
            InitializeComponent();
            this.fechaLlegada.Value = DateTime.Today;
            this.fillMatriculas();
            this.fillCiudades();
        }

        private void fillCiudades()
        {
            this.ciudadOrigen.Items.Clear();
            this.ciudadDestino.Items.Clear();
            this.ciudadesTableAdapter.Fill(this.dataSet.Ciudades);
            GD2C2015DataSet.CiudadesRow[] rows = (GD2C2015DataSet.CiudadesRow[])dataSet.Ciudades.Select("ciu_activo=1");
            ciudadesArray = new int[rows.Count()];
            int index = 0;
            foreach (GD2C2015DataSet.CiudadesRow row in rows)
            {
                string aux = row.ciu_descripcion;
                this.ciudadOrigen.Items.Insert(index, aux);
                this.ciudadDestino.Items.Insert(index, aux);
                ciudadesArray[index] = row.ciu_id;
                index = index + 1;
            }
        }

        private void fillMatriculas()
        {
            this.matricula.Items.Clear();
            this.aeronavesTableAdapter.Fill(this.dataSet.Aeronaves);
            GD2C2015DataSet.AeronavesRow[] rows = (GD2C2015DataSet.AeronavesRow[])dataSet.Aeronaves.Select("aer_activo=1");
            matriculasArray = new int[rows.Count()];
            int index = 0;
            foreach (GD2C2015DataSet.AeronavesRow row in rows)
            {
                string aux = row.aer_matricula;
                this.matricula.Items.Insert(index, aux);
                matriculasArray[index] = row.aer_id;
                index = index + 1;
            }
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            if (this.valido())
            {
                int vueloId = this.obtenerVueloId();
                DateTime fechaLlegada = this.fechaLlegada.Value;

                this.vuelosTableAdapter.Fill(this.dataSet.Vuelos);
                GD2C2015DataSet.VuelosRow row = (GD2C2015DataSet.VuelosRow)this.dataSet.Vuelos.Select("vue_id='" + vueloId + "'").First();

                this.vuelosTableAdapter.Update(row.ruta_id, row.aeronave_id, row.vue_fecha_salida, row.vue_fecha_llegada_estimada, fechaLlegada, row.vue_id, row.ruta_id, row.aeronave_id, row.vue_fecha_salida, row.vue_fecha_llegada_estimada, null, vueloId);
                this.vuelosTableAdapter.Fill(this.dataSet.Vuelos);

                MessageBox.Show("Se registro la llegada del vuelo " + vueloId + " correctamente");
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

            if (this.matricula.Text == "" || this.matricula.SelectedIndex == -1)
            {
                error = "La matricula no puede ser nula\n";
            }
            if (this.ciudadOrigen.Text == "" || this.ciudadOrigen.SelectedIndex == -1)
            {
                error = error + "Debe seleccionar una ciudad origen\n";
            }
            if (this.ciudadDestino.Text == "" || this.ciudadDestino.SelectedIndex == -1)
            {
                error = error + "Debe seleccionar una ciudad destino\n";
            }
            if (error != null)
            {
                MessageBox.Show(error);
                return false;
            }
            else
            {
                if (this.aeronaveNoTeniaQueLlegar())
                {
                    error = error + "La aeronave ingresada no tiene un viaje asignado para llegar a la ciudad ingresada\n";
                }
                if (error != null)
                {
                    MessageBox.Show(error);
                    return false;
                }
            }
            return true;
        }

        private bool aeronaveNoTeniaQueLlegar()
        {
            bool result = false;
            if (this.obtenerVueloId() == 0)
            {
                result = true;
            }
            return result;
        }

        private int obtenerVueloId()
        {
            int result = 0;
            int rutaId = 0;
            int aeronaveId = this.matriculasArray[this.matricula.SelectedIndex];
            int ciudadOrigenId = this.ciudadesArray[this.ciudadOrigen.SelectedIndex];
            int ciudadDestinoId = this.ciudadesArray[this.ciudadDestino.SelectedIndex];

            this.rutasTableAdapter.Fill(this.dataSet.Rutas);
            GD2C2015DataSet.RutasRow[] rows1 = (GD2C2015DataSet.RutasRow[])this.dataSet.Rutas.Select("ciudad_origen_id='" + ciudadOrigenId + "' AND ciudad_destino_id='" + ciudadDestinoId + "'");
            if (rows1.Length > 0)
            {
                rutaId = rows1.First().rut_id;
                this.vuelosTableAdapter.Fill(this.dataSet.Vuelos);
                GD2C2015DataSet.VuelosRow[] rows2 = (GD2C2015DataSet.VuelosRow[])this.dataSet.Vuelos.Select("ruta_id='" + rutaId + "' AND aeronave_id='" + aeronaveId + "' AND vue_fecha_llegada IS NULL");
                if (rows2.Length > 1)
                {
                    foreach (GD2C2015DataSet.VuelosRow row in rows2)
                    {
                        if (this.fechaLlegada.Value.Subtract(row.vue_fecha_llegada_estimada).Hours > 24)
                        {
                            result = row.vue_id;
                        }
                    }
                    if (result == 0)
                    {
                        result = rows2.Last().vue_id;
                    }
                }
                else if (rows2.Length == 1)
                {
                    result = rows2.First().vue_id;
                }
            }

            return result;
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            this.fechaLlegada.Value = DateTime.Today;
            this.matricula.ResetText();
            this.ciudadOrigen.ResetText();
            this.ciudadDestino.ResetText();
        }
    }
}
