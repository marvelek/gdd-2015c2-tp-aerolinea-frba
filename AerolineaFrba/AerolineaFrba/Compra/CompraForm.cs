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
        private GD2C2015DataSet dataSet = new GD2C2015DataSet();
        private GD2C2015DataSet.CiudadesRow[] origenRow;
        private GD2C2015DataSet.CiudadesRow[] destinoRow;

        public CompraForm()
        {
            InitializeComponent();
            this.fechaViaje.Value = DateTime.Today;
        }


        private void buscar_Click(object sender, EventArgs e)
        {
            if (this.valido())
            {
                this.aeronavesTableAdapter.Fill(this.dataSet.Aeronaves);
                this.ciudadesTableAdapter.Fill(this.dataSet.Ciudades);
                this.paquetesTableAdapter.Fill(this.dataSet.Paquetes);
                this.pasajesTableAdapter.Fill(this.dataSet.Pasajes);
                this.rutasTableAdapter.Fill(this.dataSet.Rutas);
                this.ventasTableAdapter.Fill(this.dataSet.Ventas);
                this.vuelosTableAdapter.Fill(this.dataSet.Vuelos);

                // Aca usar SP de super_mega_consulta !
                this.dataGrid.Rows.Add();
            }
            else
            {
                return;
            }
        }

        private bool valido()
        {
            Utiles validador = new Utiles();
            string error = null;
            this.ciudadesTableAdapter.Fill(this.dataSet.Ciudades);
            if ( this.fechaViaje.Value.Subtract(DateTime.Today).TotalHours <= 0)
            {
                error = "La fecha debe ser posterior a ahora\n";
            }
            origenRow = (GD2C2015DataSet.CiudadesRow[])this.dataSet.Ciudades.Select("LOWER(ciu_descripcion) LIKE LOWER('%" + this.origenViaje.Text + "%')");
            if (this.origenViaje.Text == "" || origenRow.Length == 0)
            {
                error = error + "Debe ingresar una ciudad origen valida\n";
            }
            destinoRow = (GD2C2015DataSet.CiudadesRow[])this.dataSet.Ciudades.Select("LOWER(ciu_descripcion) LIKE LOWER('%" + this.destinoViaje.Text + "%')");
            if (this.destinoViaje.Text == "" || destinoRow.Length == 0)
            {
                error = error + "Debe ingresar una ciudad destino valida\n";
            }
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

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                DataGridViewRow row = dataGrid.Rows[e.RowIndex];
                DataGridViewCell cell = row.Cells["Vuelo"];

                DatosPasajerosForm form = new DatosPasajerosForm((int)cell.Value, Convert.ToInt32(this.cantidadPasajeros.Text), Convert.ToInt32(this.pesoEncomienda.Text));
                form.ShowDialog();
            }
        }
    }
}
