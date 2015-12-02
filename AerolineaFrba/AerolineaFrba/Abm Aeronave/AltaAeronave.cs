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
            validarCamposYCrearAeronave();
            String.Format("{0:yyyyMMdd HH:mm:ss}", this.dateTimePickerAlta.Value);
        }

        private void validarCamposYCrearAeronave()
        {

            Double kgEncomiendas = 0;
            Int32 butacasVentanilla = 0;
            Int32 butacasPasillo = 0;
            Int32 tipoServicio = 0;
            String errores = "";

            if (this.kgEncomientasText.Text != "") {
                kgEncomiendas = Double.Parse(this.kgEncomientasText.Text);
            } else {
                errores = "Kg Encomiendas. ";
            }

            if (this.ButacasPasilloText.Text != "") {
                butacasPasillo = Int32.Parse(this.ButacasPasilloText.Text);
            }
            else { errores = errores + "Butacas Pasillo. "; }

            if (this.ButacasVentanillaText.Text != "")
            {
                butacasVentanilla = Int32.Parse(this.ButacasVentanillaText.Text);
            }
            else { errores = errores + "Butacas Ventanilla. "; }
            
            if (this.ComboTipoServicio.SelectedIndex == null)
            {
                errores = errores + "Tipo de Servicio. ";
            }
            else
            {
                tipoServicio = (Int32)this.ComboTipoServicio.SelectedIndex;
                if (tipoServicio < 0)
                {
                    errores = errores + "Tipo de Servicio.2 ";
                }
            }
            
            String matricula = this.matriculaText.Text;
            if (matricula == "") {
                errores = errores + "Matricula. ";
            }
            String modelo = this.modeloText.Text;
            if (modelo == "")
            {
                errores = errores + "Modelo. ";
            }
            String fabricante = this.FabricateTextBox.Text;
            if (fabricante == "")
            {
                errores = errores + "Fabricante. ";
            }
            if (errores != "")
            {
                MessageBox.Show("Debe completar los siguientes campos: "+errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (matriculaExistente(matricula))
            {
                MessageBox.Show("La matricula ya existe o es inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {

                aeronavesTableAdapter.AeronavesInsert(tipoServicio, matricula, modelo, Convert.ToDecimal(kgEncomiendas), fabricante, true);

                DataTable dt = new DataTable();
                dt = ConexionSQL.getTablaPorConsulta(@"select AER_ID from " + ConexionSQL.getSchema() + @".aeronaves where 
                UPPER(AER_MATRICULA) = UPPER('" + matricula + "')");

                Int32 idAeronave = 0;
                if (dt.Rows.Count != 0)
                {
                   idAeronave = Convert.ToInt32( dt.Rows[0].ItemArray[0]);
                   crearButacas(idAeronave, butacasPasillo, butacasVentanilla);
                   MessageBox.Show("La Aeronave se guardo exitosamente");
                   limpiarCampos();
                }
                else {
                    MessageBox.Show("Error al guardar la Aeronave.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

             }

        }

        private void crearButacas(Int32 idAeronave, Int32 butacasPasillo, Int32 butacasVentana) {

            Int32 butacaNumero = 1;

            for (Int32 i = 1; i <= butacasPasillo; i++)
            {
                this.butacasTableAdapter.ButacasInsert(idAeronave, butacaNumero,"Pasillo");
                butacaNumero = butacaNumero++;
            }

            for (Int32 i = 1; i <= butacasVentana; i++)
            {
                this.butacasTableAdapter.ButacasInsert(idAeronave, butacaNumero,"Ventanilla");
                butacaNumero = butacaNumero++;
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
            FormsUtils.backLastForm();
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
            Funciones.onlyNumbers(e);
        }

        private void ButacasVentanillaText_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.onlyNumbers(e);
        }

        private void kgEncomientasText_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.numbersAndComa(kgEncomientasText, e);
        }

    }
}
