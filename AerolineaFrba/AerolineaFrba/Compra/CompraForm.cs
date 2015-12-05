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

namespace AerolineaFrba.Compra
{
    public partial class CompraForm : Form
    {
        private AeronavesTableAdapter aeronavesTableAdapter = new AeronavesTableAdapter();
        private CiudadesTableAdapter ciudadesTableAdapter = new CiudadesTableAdapter();
        private PaquetesTableAdapter paquetesTableAdapter = new PaquetesTableAdapter();
        private PasajesTableAdapter pasajesTableAdapter = new PasajesTableAdapter();
        private RutasTableAdapter rutasTableAdapter = new RutasTableAdapter();
        private VentasTableAdapter ventasTableAdapter = new VentasTableAdapter();
        private VuelosTableAdapter vuelosTableAdapter = new VuelosTableAdapter();
        private vuelos_disponiblesTableAdapter vuelosDisponiblesTableAdapter = new vuelos_disponiblesTableAdapter();
        private GD2C2015DataSet dataSet = new GD2C2015DataSet();

        public CompraForm()
        {
            InitializeComponent();
            this.fechaViaje.Value = DateTime.Today;
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            GD2C2015DataSet.CiudadesDataTable ciudadOrigen = this.ciudadesTableAdapter.GetDataByDescripcionLower(origenViaje.Text);
            GD2C2015DataSet.CiudadesDataTable ciudadDestino = this.ciudadesTableAdapter.GetDataByDescripcionLower(destinoViaje.Text);

            if (this.valido(ciudadOrigen, ciudadDestino))
            {
                this.origenViaje.Text = ciudadOrigen.First().ciu_descripcion;
                this.destinoViaje.Text = ciudadDestino.First().ciu_descripcion;
                int ciudad_origen_id = ciudadOrigen.First().ciu_id;
                int ciudad_destino_id = ciudadDestino.First().ciu_id;

                this.aeronavesTableAdapter.Fill(this.dataSet.Aeronaves);
                this.ciudadesTableAdapter.Fill(this.dataSet.Ciudades);
                this.paquetesTableAdapter.Fill(this.dataSet.Paquetes);
                this.pasajesTableAdapter.Fill(this.dataSet.Pasajes);
                this.rutasTableAdapter.Fill(this.dataSet.Rutas);
                this.ventasTableAdapter.Fill(this.dataSet.Ventas);
                this.vuelosTableAdapter.Fill(this.dataSet.Vuelos);

                GD2C2015DataSet.vuelos_disponiblesDataTable data = this.vuelosDisponiblesTableAdapter.GetData(this.fechaViaje.Value, ciudad_origen_id, ciudad_destino_id);
                foreach (GD2C2015DataSet.vuelos_disponiblesRow row in data)
                {
                    this.dataGrid.Rows.Add(row.vue_id, row.VuelosRow.AeronavesRow.Tipos_ServicioRow.tip_descripcion, row.kg_disponibles, row.butacas_disponibles);
                }
            }
            else
            {
                return;
            }
        }

        private bool valido(GD2C2015DataSet.CiudadesDataTable origen, GD2C2015DataSet.CiudadesDataTable destino)
        {
            string error = null;
            this.ciudadesTableAdapter.Fill(this.dataSet.Ciudades);
            if ( this.fechaViaje.Value.Subtract(DateTime.Today).TotalHours <= 0)
            {
                error = "La fecha debe ser posterior a ahora\n";
            }
            if (this.origenViaje.Text == "")
            {
                error = error + "Debe seleccionar una ciudad origen\n";
            }
            else if (origen.Count == 0)
            {
                error = error + "No existe la ciudad de origen\n";
            }

            if (this.destinoViaje.Text == "")
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
            return true;
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.validoVuelo())
            {

                if (e.ColumnIndex == 4)
                {
                    DataGridViewRow row = dataGrid.Rows[e.RowIndex];
                    DataGridViewCell cell = row.Cells["Vuelo"];
                    int cantPasajeros = 0;
                    if (this.cantidadPasajeros.Text != "")
                    {
                        cantPasajeros = Convert.ToInt32(this.cantidadPasajeros.Text);
                    }
                    int peso = 0;
                    if (this.pesoEncomienda.Text != "")
                    {
                        peso = Convert.ToInt32(this.pesoEncomienda.Text);
                    }
                    if (Convert.ToInt32(row.Cells["KgDisponibles"]) >= peso && Convert.ToInt32(row.Cells["ButacasLibres"]) >= cantPasajeros)
                    {
                        DatosPasajerosForm form = new DatosPasajerosForm((int)cell.Value, cantPasajeros, peso);
                        form.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("El vuelo seleccionado no cuenta con butacas disponibles como cantidad de pasajeros ingresados o kg disponibles para la encomienda ingresada");
                    }
                }
            }
        }

        private bool validoVuelo()
        {
            Utiles validador = new Utiles();
            string error = null;
            if (this.cantidadPasajeros.Text == "" && this.pesoEncomienda.Text == "")
            {
                error = error + "Debe ingresar al menos un valor en alguno de los campos: cantidad pasajeros y/o kg encomienda\n";
            }
            if (!validador.IsNumber(this.cantidadPasajeros.Text))
            {
                error = error + "El campo cantidad de pasajeros debe ser numerico\n";
            }
            if (!validador.IsNumber(this.pesoEncomienda.Text))
            {
                error = error + "El campo peso encomienda debe ser numerico\n";
            }
            if (error != null)
            {
                MessageBox.Show(error);
                return false;
            }
            return true;
        }
    }
}
