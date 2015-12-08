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
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Ciudades' Puede moverla o quitarla según sea necesario.
            this.ciudadesTableAdapter.Fill(this.gD2C2015DataSet.Ciudades);
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Rutas' Puede moverla o quitarla según sea necesario.         
            this.rutasTableAdapter.Fill(this.gD2C2015DataSet.Rutas);                     
            this.comboBox1.SelectedIndex = 0;
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
            ruta.CiudadDestino = Convert.ToInt16(data.Rows[data.CurrentRow.Index].Cells[4].Value);
            ruta.PrecioKg = Convert.ToDecimal(data.Rows[data.CurrentRow.Index].Cells[6].Value);
            ruta.PrecioBase = Convert.ToDecimal(data.Rows[data.CurrentRow.Index].Cells[7].Value);
            ruta.Activo = Convert.ToBoolean(data.Rows[data.CurrentRow.Index].Cells[8].Value);
            new CargarRutaForm(ruta).ShowDialog();

            this.rutasTableAdapter.Fill(this.gD2C2015DataSet.Rutas);
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
            if ((this.descripcion.Text != "") || (Convert.ToString(this.comboBox1.SelectedItem) != "") || (this.ciudadOrigen.Text != "") || (this.ciudadDestino.Text != "") || (this.precioKgDesde.Text != "") || (this.precioKgHasta.Text != "") || (this.precioBaseDesde.Text != "") || (this.precioBaseHasta.Text != ""))
            {
                if (this.precioKgDesde.Text == "") { this.precioKgDesde.Text = "0"; }
                if (this.precioKgHasta.Text == "") { this.precioKgHasta.Text = "0"; }
                if (this.precioBaseDesde.Text == "") { this.precioBaseDesde.Text = "0"; }
                if (this.precioBaseHasta.Text == "") { this.precioBaseHasta.Text = "0"; }

                this.rutasTableAdapter.FillBy(this.gD2C2015DataSet.Rutas, this.descripcion.Text, Convert.ToString(this.comboBox1.SelectedItem), this.ciudadOrigen.Text, this.ciudadDestino.Text,  
                     Convert.ToDecimal(this.precioKgDesde.Text), Convert.ToDecimal(this.precioKgHasta.Text), Convert.ToDecimal(this.precioBaseDesde.Text), Convert.ToDecimal(this.precioBaseHasta.Text));
            }
            else
            {
                this.rutasTableAdapter.Fill(this.gD2C2015DataSet.Rutas);
            }
        }

        private void limpiar_Click_1(object sender, EventArgs e)
        {
            this.descripcion.Clear();
            this.ciudadDestino.Clear();
            this.ciudadOrigen.Clear();
            this.precioKgDesde.Clear();
            this.precioKgHasta.Clear();
            this.precioBaseDesde.Clear();
            this.precioBaseHasta.Clear();
            this.comboBox1.SelectedIndex = 0;
            this.rutasTableAdapter.Fill(this.gD2C2015DataSet.Rutas);
        }

        private void descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void eliminar_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(data.Rows[data.CurrentRow.Index].Cells[0].Value);
            this.rutasTableAdapter.rutaBajaLogica(id);
            // Aca tendria que tener un trigger que se dispare y le saque este rol a los usuarios que lo tengan
            this.rutasTableAdapter.Fill(this.gD2C2015DataSet.Rutas);
            MessageBox.Show("La ruta ha sido borrada correctamente");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void precioKgDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(Convert.ToInt16(e.KeyChar).ToString());

            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < precioKgDesde.Text.Length; i++)
            {
                if (precioKgDesde.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }


            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;

        }

        private void precioKgHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(Convert.ToInt16(e.KeyChar).ToString());

            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < precioKgHasta.Text.Length; i++)
            {
                if (precioKgHasta.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }


            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;

        }

        private void precioBaseDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(Convert.ToInt16(e.KeyChar).ToString());

            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < precioBaseDesde.Text.Length; i++)
            {
                if (precioBaseDesde.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }


            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;

        }

        private void precioBaseHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(Convert.ToInt16(e.KeyChar).ToString());

            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < precioBaseHasta.Text.Length; i++)
            {
                if (precioBaseHasta.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }


            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;

        }
    }
}
