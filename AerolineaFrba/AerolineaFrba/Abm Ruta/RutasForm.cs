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

namespace AerolineaFrba.Abm_Ruta
{
    public partial class RutasForm : Form
    {
        public RutasForm()
        {
            InitializeComponent();
        }

        private void RutasForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Rutas' Puede moverla o quitarla según sea necesario.         
            this.rutasTableAdapter.Fill(this.gD2C2015DataSet.Rutas);
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
           
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            Ruta ruta = new Ruta();
            ruta.Id = Convert.ToInt16(data.Rows[data.CurrentRow.Index].Cells[0].Value);
            ruta.Codigo = Convert.ToDecimal(data.Rows[data.CurrentRow.Index].Cells[1].Value);
            ruta.CiudadOrigen = Convert.ToInt16(data.Rows[data.CurrentRow.Index].Cells[2].Value);
            ruta.CiudadDestino = Convert.ToInt16(data.Rows[data.CurrentRow.Index].Cells[3].Value);
            ruta.PrecioKg = Convert.ToDecimal(data.Rows[data.CurrentRow.Index].Cells[5].Value);
            ruta.PrecioBase = Convert.ToDecimal(data.Rows[data.CurrentRow.Index].Cells[6].Value);
            ruta.Activo = Convert.ToBoolean(data.Rows[data.CurrentRow.Index].Cells[7].Value);
            new CargarRutaForm(ruta).ShowDialog();
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void carga_Click_1(object sender, EventArgs e)
        {
            new CargarRutaForm(null).ShowDialog();
        }

        private void buscar_Click_1(object sender, EventArgs e)
        {
            if (this.descripcion.Text != "")
            {
                //this.rutasTableAdapter.FillBy(this.gD2C2015DataSet.Rutas, this.descripcion.Text);
            }
            else
            {
                this.rutasTableAdapter.Fill(this.gD2C2015DataSet.Rutas);
            }
        }

        private void limpiar_Click_1(object sender, EventArgs e)
        {
            this.descripcion.Clear();
        }

        private void descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void eliminar_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(data.Rows[data.CurrentRow.Index].Cells[0].Value);
            //this.rutasTableAdapter.bajaLogicaRuta(id);
            // Aca tendria que tener un trigger que se dispare y le saque este rol a los usuarios que lo tengan
            this.rutasTableAdapter.Fill(this.gD2C2015DataSet.Rutas);
        }
    }
}
