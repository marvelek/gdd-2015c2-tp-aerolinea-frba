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

namespace AerolineaFrba.Listado_Estadistico
{
    public partial class ListadoEstadisticoForm : Form
    {
        int mes1 = 1;
        int mes2 = 6;
            
        public ListadoEstadisticoForm()
        {
            InitializeComponent();
            this.comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Convert.ToString(comboBox1.SelectedItem))
            {
                case "Top 5 de los destinos con más pasajes comprados.":                    
                        this.dataGridView5.Visible = false;
                        this.dataGridView4.Visible = false;
                        this.dataGridView3.Visible = false;
                        this.dataGridView2.Visible = false;
                        this.dataGridView1.Visible = true;
                        break;                    
                case "Top 5 de los destinos con aeronaves más vacías.":                    
                        this.dataGridView5.Visible = false;
                        this.dataGridView4.Visible = false;
                        this.dataGridView3.Visible = true;
                        this.dataGridView2.Visible = false;
                        this.dataGridView1.Visible = false;
                        break;
                case "Top 5 de los Clientes con más puntos acumulados a la fecha.":                    
                        this.dataGridView5.Visible = false;
                        this.dataGridView4.Visible = true;
                        this.dataGridView3.Visible = false;
                        this.dataGridView2.Visible = false;
                        this.dataGridView1.Visible = false;
                        break;
                case "Top 5 de los destinos con pasajes cancelados.":                    
                        this.dataGridView5.Visible = false;
                        this.dataGridView4.Visible = false;
                        this.dataGridView3.Visible = false;
                        this.dataGridView2.Visible = true;
                        this.dataGridView1.Visible = false;
                        break;
                case "Top 5 de las aeronaves con mayor cantidad de días fuera de servicio.":                    
                      this.dataGridView5.Visible = true;
                      this.dataGridView4.Visible = false;
                      this.dataGridView3.Visible = false;
                      this.dataGridView2.Visible = false;
                      this.dataGridView1.Visible = false;
                      break;
                default:                    
                        this.dataGridView5.Visible = false;
                        this.dataGridView4.Visible = false;
                        this.dataGridView3.Visible = false;
                        this.dataGridView2.Visible = false;
                        this.dataGridView1.Visible = true;
                        break;

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //this.radioButton2 = !(this.radioButton1);
            if (radioButton1.Checked)
            {
            this.mes1 = 1;
            this.mes2 = 6;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)        
        {
            //this.radioButton1 = this.radioButton2;
            if (radioButton2.Checked)
            {
                this.mes1 = 7;
                this.mes2 = 12;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.valido())
            {                    
                switch (Convert.ToString(comboBox1.SelectedItem))
                {
                    case "Top 5 de los destinos con más pasajes comprados.":                        
                        this.estadisticaDestinosPasajesTableAdapter.Fill(this.gD2C2015DataSet.estadisticaDestinosPasajes, Convert.ToInt32(this.año.Text), this.mes1, this.mes2);
                        break;
                    case "Top 5 de los destinos con aeronaves más vacías.":
                        this.estadisticaDestinosButacasTableAdapter.Fill(this.gD2C2015DataSet.estadisticaDestinosButacas, Convert.ToInt32(this.año.Text), this.mes1, this.mes2);                        
                        break;
                    case "Top 5 de los Clientes con más puntos acumulados a la fecha.":
                        this.estadisticaClientesMillasTableAdapter.Fill(this.gD2C2015DataSet.estadisticaClientesMillas, Convert.ToInt32(this.año.Text), this.mes1, this.mes2);                        
                        break;
                    case "Top 5 de los destinos con pasajes cancelados.":
                        this.estadisticaDestinosCanceladosTableAdapter.Fill(this.gD2C2015DataSet.estadisticaDestinosCancelados, Convert.ToInt32(this.año.Text), this.mes1, this.mes2);                        
                        break;
                    case "Top 5 de las aeronaves con mayor cantidad de días fuera de servicio.":
                        this.estadisticaAeronavesFueraDeServicioTableAdapter.Fill(this.gD2C2015DataSet.estadisticaAeronavesFueraDeServicio, Convert.ToInt32(this.año.Text), this.mes1, this.mes2);                        
                        break;
                    default:
                        this.estadisticaDestinosPasajesTableAdapter.Fill(this.gD2C2015DataSet.estadisticaDestinosPasajes, Convert.ToInt32(this.año.Text), this.mes1, this.mes2);
                        break;

                }                    
            }
        }

        private bool valido()
        {
            Utiles validador = new Utiles();
            string error = null;

            if (this.año.Text == "") { this.año.Text = "0"; }

            if (Convert.ToString(this.comboBox1.SelectedItem) == "")
            {
                error = "Debe seleccionar un listado para consultar.\n";
            }            
            if (!validador.IsNumber(this.año.Text) || Convert.ToInt32(this.año.Text) < (Convert.ToInt32(DateTime.Today.Year) - 10))
            {
                error = error + "El año ingresado es inválido, debe tener sólo números y no puede ser mayor a 10 años.\n";
            }      
            if (error != null)
            {
                MessageBox.Show(error);
                return false;
            }
            return true;
        }

        private void ListadoEstadisticoForm_Load(object sender, EventArgs e)
        {
                       

        }
    }
}
