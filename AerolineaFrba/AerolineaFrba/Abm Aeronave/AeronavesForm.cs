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

            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Columns[0].HeaderCell.Value = "ID Aeronave";
            this.dataGridView1.Columns[1].HeaderCell.Value = "Tipo de servicio";
            this.dataGridView1.Columns[2].HeaderCell.Value = "Matrícula";
            this.dataGridView1.Columns[3].HeaderCell.Value = "Modelo";
            this.dataGridView1.Columns[4].HeaderCell.Value = "Kg Disponibles";
            this.dataGridView1.Columns[5].HeaderCell.Value = "Fabricante";
            this.dataGridView1.Columns[6].HeaderCell.Value = "Fecha Desde FS";
            this.dataGridView1.Columns[7].HeaderCell.Value = "Fecha Hasta FS";
            this.dataGridView1.Columns[8].HeaderCell.Value = "Fecha Baja Definitiva";
            this.dataGridView1.Columns[9].HeaderCell.Value = "Estado";
            this.dataGridView1.Columns[10].HeaderCell.Value = "Fecha de Alta";
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
            AeronavesForm_Load(sender, e);
        }

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
                    AeronavesForm_Load(null, null);
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
                       AeronavesForm_Load(null, null);
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

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            this.estadoCombo.SelectedIndex = 0;
            this.servicioCombo.SelectedIndex = 3;
            this.servicioCombo.Refresh();
            this.MatriculaBox.Clear();
            this.modeloBox.Clear();
            this.fabricanteBox.Clear();
            this.precioKgDesde.Clear();
            this.precioKgHasta.Clear();
            this.aeronavesTableAdapter.Fill(this.gD2C2015DataSet.Aeronaves);
        }

        private void modificarButton_Click(object sender, EventArgs e)
        {
            Aeronave aeronave = new Aeronave();
            aeronave.Id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            aeronave.TipoServicio = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value);
            aeronave.Matricula = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value);
            aeronave.Modelo = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value);
            aeronave.Kg_disponibles = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value);
            aeronave.Fabricante = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value);
            aeronave.Activo = Convert.ToBoolean(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[9].Value); ;
            try
            {
                aeronave.FechaAlta = Convert.ToDateTime(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[10].Value);
            }
            catch { }
            new AltaAeronave(aeronave).ShowDialog();
            this.Buscar_Click(this, null);
        }
    }
}
