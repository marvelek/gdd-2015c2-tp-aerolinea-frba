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
        private VuelosTableAdapter vuelosTableAdapter = new VuelosTableAdapter();
        GD2C2015DataSet dataSet = new GD2C2015DataSet();
        private Aeronave aeronave = null;
        private bool tieneVuelosVendidos = false;

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
            try
            {
                this.dateTimePickerAlta.Value = aeronave.FechaAlta;
            }
            catch { }

            // consigue las butacas pasillo y ventanilla para mostrar
            this.butacasTableAdapter.Fill(this.dataSet.Butacas);
            GD2C2015DataSet.ButacasRow[] dataPasillo = (GD2C2015DataSet.ButacasRow[])this.dataSet.Butacas.Select("aeronave_id='"+ this.aeronave.Id + "' AND but_tipo='Pasillo' AND but_activo=1");
            int cantPasillo = dataPasillo.Length;
            this.ButacasPasilloText.Text = Convert.ToString(cantPasillo);
            this.aeronave.ButacasPasillo = cantPasillo;
            GD2C2015DataSet.ButacasRow[] dataVentanilla = (GD2C2015DataSet.ButacasRow[])this.dataSet.Butacas.Select("aeronave_id='" + this.aeronave.Id + "' AND but_tipo='Ventanilla' AND but_activo=1");
            int cantVentanilla = dataVentanilla.Length;
            this.ButacasVentanillaText.Text = Convert.ToString(cantVentanilla);
            this.aeronave.ButacasVentanilla = cantVentanilla;

            // verifica si tiene vuelos asignados
            this.vuelosTableAdapter.Fill(this.dataSet.Vuelos);
            GD2C2015DataSet.VuelosRow[] rows = (GD2C2015DataSet.VuelosRow[])this.dataSet.Vuelos.Select("aeronave_id='" + this.aeronave.Id + "'");
            if (rows.Length > 0)
            {
                this.tieneVuelosVendidos = true;
            }

            // inhabilita los campos que no se modifican (Fecha alta y tipo de servicio)
            this.dateTimePickerAlta.Enabled = false;
            if (this.tieneVuelosVendidos)
            {
                this.modeloText.Enabled = false;
                this.FabricateTextBox.Enabled = false;
                this.ComboTipoServicio.Enabled = false;
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
            if (this.valido())
            {
                // despues de que si es valido, comprueba si this.aeronave != null (entonces es una modificacion y hacer lo que corresponda)
                if (this.aeronave != null)
                {
                    Double kgEncomiendas = Double.Parse(this.kgEncomientasText.Text);
                    Int32 butacasVentanilla = Int32.Parse(this.ButacasVentanillaText.Text);
                    Int32 butacasPasillo = Int32.Parse(this.ButacasPasilloText.Text);
                    if ((this.tieneVuelosVendidos) && (Convert.ToDecimal(kgEncomiendas) < this.aeronave.Kg_disponibles || butacasVentanilla < this.aeronave.ButacasVentanilla || butacasPasillo < this.aeronave.ButacasPasillo))
                    {
                        MessageBox.Show("Solo es posible aumentar los Kg disponibles y las cantidades de las butacas porque tiene vuelos asignados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (this.verificarMatriculaNoDuplicada(this.aeronave.Id, this.matriculaText.Text))
                    {
                        MessageBox.Show("La matricula ingresada ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            int butVentAgregar = 0;
            int butPasAgregar = 0;

            if (this.tieneVuelosVendidos)
            {
                butVentAgregar = butacasVentanilla - this.aeronave.ButacasVentanilla;
                butPasAgregar = butacasPasillo - this.aeronave.ButacasPasillo;
            }
            else
            {
                butVentAgregar = butacasVentanilla;
                butPasAgregar = butacasPasillo;
            }

            this.aeronavesTableAdapter.Fill(this.dataSet.Aeronaves);
            GD2C2015DataSet.AeronavesRow row = (GD2C2015DataSet.AeronavesRow)this.dataSet.Aeronaves.Select("aer_id='"+ this.aeronave.Id + "'").First();
            row.tipo_servicio_id = tipoServicio;
            row.aer_matricula = matricula;
            row.aer_modelo = modelo;
            row.aer_kg_disponibles = Convert.ToDecimal(kgEncomiendas);
            row.aer_fabricante = fabricante;
            this.aeronavesTableAdapter.Update(row);
            this.aeronavesTableAdapter.Fill(this.dataSet.Aeronaves);
            if (butVentAgregar > 0 || butPasAgregar > 0)
            {
                this.butacasTableAdapter.Fill(this.dataSet.Butacas);
                GD2C2015DataSet.ButacasRow[] rows = (GD2C2015DataSet.ButacasRow[])this.dataSet.Butacas.Select("aeronave_id='" + this.aeronave.Id + "'");
                if (!this.tieneVuelosVendidos)
                {
                    // Aca se eliminan todas las butacas existentes relacionadas a la aeronave

                    foreach (GD2C2015DataSet.ButacasRow but in rows)
                    {
                        this.butacasTableAdapter.Delete(but.but_id, but.aeronave_id, but.but_numero, but.but_tipo, but.but_piso, but.but_activo);
                    }
                    this.butacasTableAdapter.Fill(this.dataSet.Butacas);
                    crearButacas(1, this.aeronave.Id, butPasAgregar, butVentAgregar);
                }
                else
                {
                    crearButacas(rows.Length + 1, this.aeronave.Id, butPasAgregar, butVentAgregar);
                }
            }
            MessageBox.Show("La Aeronave se guardo exitosamente");
            limpiarCampos();
            this.Close();
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

                crearButacas(1, aer.Id, butacasPasillo, butacasVentanilla);
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
            Utiles validador = new Utiles();
            String errores = "";

            if ((this.kgEncomientasText.Text == "") || (!validador.IsNumber(this.kgEncomientasText.Text)))
            {
                errores = "Kg Encomiendas. ";
            }

            if ((this.ButacasPasilloText.Text == "") || (!validador.IsNumber(this.ButacasPasilloText.Text)))
            { 
                errores = errores + "Butacas Pasillo. "; 
            }

            if ((this.ButacasVentanillaText.Text == "") || (!validador.IsNumber(this.ButacasVentanillaText.Text)))
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
                MessageBox.Show("Debe completar los siguientes campos(o completarlos con valores validos): " + errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void crearButacas(Int32 butacaNumero, Int32 idAeronave, Int32 butacasPasillo, Int32 butacasVentana)
        {

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
        private bool verificarMatriculaNoDuplicada(int id, string matricula)
        {
            Aeronave aer = new Aeronave();
            aer = aer.buscarByMatricula(matricula);

            if (aer == null)
            {
                return false;
            }
            if (aer.Id.Equals(id))
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
