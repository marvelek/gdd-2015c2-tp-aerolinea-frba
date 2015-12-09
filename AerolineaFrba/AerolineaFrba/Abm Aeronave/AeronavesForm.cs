using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.Abm_Aeronave;
using AerolineaFrba.Contenido;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class AeronavesForm : Form
    {

        public AeronavesForm()
        {
            InitializeComponent();
            this.tipos_ServicioTableAdapter.Fill(this.gD2C2015DataSet.Tipos_Servicio);
            List<Tipo_Servicio> tipos_servicios = Tipo_Servicio.getTipos_Servicio();
            foreach (Tipo_Servicio f in tipos_servicios)
            {
                this.servicioCombo.Items.Insert(f.Id - 1, f.Descripcion);
            }
            this.estadoCombo.SelectedIndex = 0;
            this.servicioCombo.SelectedIndex = 3;
            this.servicioCombo.Refresh();
            
        }

        private void AeronavesForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Tipos_Servicio' Puede moverla o quitarla según sea necesario.
            this.tipos_ServicioTableAdapter.Fill(this.gD2C2015DataSet.Tipos_Servicio);
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Aeronaves' Puede moverla o quitarla según sea necesario.
            this.aeronavesTableAdapter.Fill(this.gD2C2015DataSet.Aeronaves);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Alta_Click(object sender, EventArgs e)
        {
            AltaAeronave form = new AltaAeronave();
            form.ShowDialog();
            this.Close();
        }

        //TODO ejemplo
        private void Buscar_Click(object sender, EventArgs e)
        {
            if ((this.MatriculaBox.Text != "") || (Convert.ToString(this.estadoCombo.SelectedItem) != "") ||
                (this.modeloBox.Text != "") || (this.fabricanteBox.Text != "") ||
                (this.precioKgDesde.Text != "") || (this.precioKgHasta.Text != "") || (Convert.ToString(this.servicioCombo.SelectedItem) != ""))
            {
                String precioKgDesde = "0";
                String precioKgHasta = "0";
                
                if (this.precioKgDesde.Text != "") {
                    precioKgDesde = this.precioKgDesde.Text;
                }
                if (this.precioKgHasta.Text != "") {
                    precioKgHasta = this.precioKgHasta.Text;
                }

                String selectedIndexServicios = "0";
                if (Convert.ToString(this.servicioCombo.SelectedItem) != "" &&
                         Convert.ToString(this.servicioCombo.SelectedItem) != "Todos")
                {
                    selectedIndexServicios = this.servicioCombo.SelectedIndex.ToString();
                }


                this.aeronavesTableAdapter.FillByBuscarMany(this.gD2C2015DataSet.Aeronaves,
                    selectedIndexServicios, this.modeloBox.Text,
                    this.MatriculaBox.Text, this.fabricanteBox.Text,
                     Convert.ToDecimal(precioKgDesde), Convert.ToDecimal(precioKgHasta), this.estadoCombo.SelectedItem.ToString());
            }
            else
            {
                this.aeronavesTableAdapter.Fill(this.gD2C2015DataSet.Aeronaves);
            }
        }


        private void Buscar_Click_old(object sender, EventArgs e)
        {
            if (this.MatriculaBox.Text != "")
            {
                this.aeronavesTableAdapter.FillBy1(this.gD2C2015DataSet.Aeronaves, MatriculaBox.Text);
            }
            else
            {
                this.aeronavesTableAdapter.Fill(this.gD2C2015DataSet.Aeronaves);
            }
        }

        private void FueraServicio_Click(object sender, EventArgs e)
        {
            Int32 aer_id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            String aer_activa = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            if (aer_activa.Equals("True"))
            {

                if (new Aeronave().aeronaveYaFS(aer_id))
                {
                    MessageBox.Show("Aeronave Fuera de Servicio. Debe esperar a que vuelva a estar activa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
                }
                else
                {
                    BajaAeronavesFSForm bajaForm = new BajaAeronavesFSForm(aer_id);
                    bajaForm.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Aeronave Inactiva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BajaDef_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una Aeronave", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {

                Int32 aer_id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                String aer_activa = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                if (aer_activa.Equals("True")) {
                   
                    Aeronave aer = new Aeronave();
                    if (aer.tieneVuelosPendientes(aer_id))
                    {
                       BajaPendientesDefForm form =  new BajaPendientesDefForm(aer_id);
                       form.ShowDialog();
                       this.Close();
                    }
                    else
                    {
                        aer.bajaDefinitiva(aer_id);
                        MessageBox.Show("La aeronave fue dada de baja definitiva.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AeronavesForm_Load(null, null);
                    }
                } else {
                    MessageBox.Show("Aeronave inactiva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void MatriculaBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                Buscar_Click(sender, null);
            } 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void precioKgHasta_TextChanged(object sender, EventArgs e)
        {

        }

        private void modeloBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscar_Click(sender, null);
            } 
        }

        private void k(object sender, EventArgs e)
        {

        }

        private void fabricanteBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscar_Click(sender, null);
            } 
        }

        private void precioKgDesde_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscar_Click(sender, null);
            } 
        }

        private void precioKgHasta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscar_Click(sender, null);
            } 
        }

        private void servicioCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
