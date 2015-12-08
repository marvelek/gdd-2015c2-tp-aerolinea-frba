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
        }

        private void AeronavesForm_Load(object sender, EventArgs e)
        {
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

        private void Buscar_Click(object sender, EventArgs e)
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
    }
}
