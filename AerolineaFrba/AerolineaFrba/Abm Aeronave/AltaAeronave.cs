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
using AerolineaFrba.GD2C2015DataSetTableAdapters;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class AltaAeronave : Form
    {

        GD2C2015DataSet dataSet = new GD2C2015DataSet();
        private Aeronave aeronave = null;

        public AltaAeronave()
        {
            InitializeComponent();
            this.tipos_ServicioTableAdapter.Fill(this.gD2C2015DataSet.Tipos_Servicio);
            List<Tipo_Servicio> tipos_servicios = Tipo_Servicio.getTipos_Servicio();
            foreach (Tipo_Servicio f in tipos_servicios)
            {
                this.ComboTipoServicio.Items.Insert(f.Id - 1, f.Descripcion);
            }
            this.ComboTipoServicio.Refresh();

        }

        public AltaAeronave(Aeronave aeronave)
        {
            InitializeComponent();
            this.tipos_ServicioTableAdapter.Fill(this.gD2C2015DataSet.Tipos_Servicio);
            List<Tipo_Servicio> tipos_servicios = Tipo_Servicio.getTipos_Servicio();
            foreach (Tipo_Servicio f in tipos_servicios)
            {
                this.ComboTipoServicio.Items.Insert(f.Id - 1, f.Descripcion);
            }
            this.ComboTipoServicio.Refresh();

            this.aeronave = aeronave;
            this.matriculaText.Text = aeronave.Matricula;
            this.modeloText.Text = aeronave.Modelo;
            this.FabricateTextBox.Text = aeronave.Fabricante;
            this.ComboTipoServicio.SelectedIndex = aeronave.TipoServicio - 1;
            this.kgEncomientasText.Text = Convert.ToString(aeronave.Kg_disponibles);
            this.dateTimePickerAlta.Value = aeronave.FechaAlta;

            // consigue las butacas pasillo y ventanilla para mostrar
            this.butacasTableAdapter.Fill(this.dataSet.Butacas);
            GD2C2015DataSet.ButacasRow[] dataPasillo = (GD2C2015DataSet.ButacasRow[])this.dataSet.Butacas.Select("aeronave_id='"+ this.aeronave.Id + "' AND but_tipo='Pasillo' AND but_activo=1");
            int cantPasillo = dataPasillo.Length;
            this.ButacasPasilloText.Text = Convert.ToString(cantPasillo);
            this.aeronave.ButacasPasillo = cantPasillo;
            GD2C2015DataSet.ButacasRow[] dataVentanilla = (GD2C2015DataSet.ButacasRow[])this.dataSet.Butacas.Select("aeronave_id='" + this.aeronave.Id + "' AND but_tipo='Ventanilla' AND but_activo=1");
            int cantVentanilla = dataPasillo.Length;
            this.ButacasVentanillaText.Text = Convert.ToString(cantVentanilla);
            this.aeronave.ButacasVentanilla = cantVentanilla;
            
            // inhabilita los campos que no se modifican (Fecha alta y tipo de servicio)
            this.dateTimePickerAlta.Enabled = false;
            this.ComboTipoServicio.Enabled = false;

        }



        private void AltaAeronave_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Tipos_Servicio' Puede moverla o quitarla según sea necesario.
            this.tipos_ServicioTableAdapter.Fill(this.gD2C2015DataSet.Tipos_Servicio);
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Butacas' Puede moverla o quitarla según sea necesario.
            this.butacasTableAdapter.Fill(this.gD2C2015DataSet.Butacas);
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Aeronaves' Puede moverla o quitarla según sea necesario.
            this.aeronavesTableAdapter.Fill(this.gD2C2015DataSet.Aeronaves);
        }


        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (this.valido())
            {
                // despues de que si es valido, comprueba si this.aeronave != null (entonces es una modificacion y hacer lo que corresponda)
                if (this.aeronave != null)
                {
                    Double kgEncomiendas = Double.Parse(this.kgEncomientasText.Text);
                    Int32 butacasVentanilla = Int32.Parse(this.ButacasVentanillaText.Text);
                    Int32 butacasPasillo = Int32.Parse(this.ButacasPasilloText.Text);
                    if (Convert.ToDecimal(kgEncomiendas) < this.aeronave.Kg_disponibles || butacasVentanilla < this.aeronave.ButacasVentanilla || butacasPasillo < this.aeronave.ButacasPasillo)
                    {
                        MessageBox.Show("Solo es posible aumentar los Kg disponibles y las cantidades de las butacas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    this.modificarAeronave();
                }
                else
                {
                    if (matriculaExistente(this.matriculaText.Text))
                    {
                        MessageBox.Show("La matricula ya existe o es inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    this.crearAeronave();
                    String.Format("{0:yyyyMMdd HH:mm:ss}", this.dateTimePickerAlta.Value);
                }
            }
            else
            {
                return;
            }
        }

        private void modificarAeronave()
        {
            Double kgEncomiendas = Double.Parse(this.kgEncomientasText.Text);
            Int32 butacasVentanilla = Int32.Parse(this.ButacasVentanillaText.Text);
            Int32 butacasPasillo = Int32.Parse(this.ButacasPasilloText.Text);
            Int32 tipoServicio = (Int32)this.ComboTipoServicio.SelectedIndex + 1;
            String matricula = this.matriculaText.Text;
            String modelo = this.modeloText.Text;
            String fabricante = this.FabricateTextBox.Text;

            // ACA FALTA el UPDATE de las aeronaves y las butacas


        }

        private void crearAeronave()
        {
            Double kgEncomiendas = Double.Parse(this.kgEncomientasText.Text);
            Int32 butacasVentanilla = Int32.Parse(this.ButacasVentanillaText.Text);
            Int32 butacasPasillo = Int32.Parse(this.ButacasPasilloText.Text);
            Int32 tipoServicio = (Int32)this.ComboTipoServicio.SelectedIndex + 1;
            String matricula = this.matriculaText.Text;
            String modelo = this.modeloText.Text;
            String fabricante = this.FabricateTextBox.Text;

            aeronavesTableAdapter.AeronavesInsert(tipoServicio, matricula, modelo, Convert.ToDecimal(kgEncomiendas), fabricante);

            Aeronave aer = new Aeronave();
            aer = aer.buscarByMatricula(matricula);
            if (aer != null)
            {

                crearButacas(aer.Id, butacasPasillo, butacasVentanilla);
                MessageBox.Show("La Aeronave se guardo exitosamente");
                limpiarCampos();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al guardar la Aeronave.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool valido()
        {
            String errores = "";

            if (this.kgEncomientasText.Text == "")
            {
                errores = "Kg Encomiendas. ";
            }

            if (this.ButacasPasilloText.Text == "")
            { 
                errores = errores + "Butacas Pasillo. "; 
            }

            if (this.ButacasVentanillaText.Text == "")
            { 
                errores = errores + "Butacas Ventanilla. "; 
            }

            if (this.ComboTipoServicio.SelectedIndex < 0)
            {
                errores = errores + "Tipo de Servicio. ";
            }

            if (this.matriculaText.Text == "")
            {
                errores = errores + "Matricula. ";
            }
            
            if (this.modeloText.Text == "")
            {
                errores = errores + "Modelo. ";
            }
            
            if (this.FabricateTextBox.Text == "")
            {
                errores = errores + "Fabricante. ";
            }
            if (errores != "")
            {
                MessageBox.Show("Debe completar los siguientes campos: " + errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void crearButacas(Int32 idAeronave, Int32 butacasPasillo, Int32 butacasVentana) {

            Int32 butacaNumero = 1;

            for (Int32 i = 1; i <= butacasPasillo; i++)
            {
                this.butacasTableAdapter.ButacasInsert(idAeronave, butacaNumero-1,"Pasillo");
                butacaNumero = butacaNumero+1;
            }

            for (Int32 i = 1; i <= butacasVentana; i++)
            {
                this.butacasTableAdapter.ButacasInsert(idAeronave, butacaNumero-1,"Ventanilla");
                butacaNumero = butacaNumero+1;
            }


        }
        private bool matriculaExistente(String matricula)
        {

            Aeronave aer = new Aeronave();
            aer = aer.buscarByMatricula(matricula);

            if (aer == null)
            {
                return false;
            }
            return true;
        }
        private void buttonVolver_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            this.Close();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            this.matriculaText.Clear();
            this.modeloText.Clear();
            this.ButacasPasilloText.Clear();
            this.ButacasVentanillaText.Clear();
            this.dateTimePickerAlta.ResetText();
            this.FabricateTextBox.Clear();
            this.kgEncomientasText.Clear();
            this.ComboTipoServicio.SelectedIndex = -1;
        }

        private void ButacasPasilloText_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utiles.onlyNumbers(e);
        }

        private void ButacasVentanillaText_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utiles.onlyNumbers(e);
        }

        private void kgEncomientasText_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utiles.numbersAndComa(kgEncomientasText, e);
        }

        private void ButacasPasilloText_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
