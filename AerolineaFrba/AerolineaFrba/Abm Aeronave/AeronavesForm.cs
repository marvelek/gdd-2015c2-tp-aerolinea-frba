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
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una Aeronave", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                Int32 aer_id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
  
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

            }
        }
    }
}
