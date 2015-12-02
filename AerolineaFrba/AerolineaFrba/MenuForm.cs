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
using AerolineaFrba.Abm_Rol;
using AerolineaFrba.Abm_Ruta;
using AerolineaFrba.Abm_Aeronave;
using AerolineaFrba.Generacion_Viaje;
using AerolineaFrba.Registro_Llegada_Destino;
using AerolineaFrba.Compra;
using AerolineaFrba.Devolucion;
using AerolineaFrba.Consulta_Millas;
using AerolineaFrba.Canje_Millas;
using AerolineaFrba.Listado_Estadistico;

namespace AerolineaFrba
{
    public partial class MenuForm : Form
    {
        Usuario user;

        public MenuForm()
        {
            InitializeComponent();
        }

        public void cargaDatosUsuario(Usuario user)
        {
            this.user = user;
            validaDatosUsuario();
        }

        private void validaDatosUsuario()
        {
            List<Funcionalidad> funcionalidades = Funcionalidad.getFuncionalidadesRol(user.Rol.Id);
            ocultarMenus();
            foreach (Funcionalidad f in funcionalidades)
            {
                if (f.Id == 1) //ADMIN
                {
                    this.rolesToolStripMenuItem.Visible = true;
                    this.rutaAereaToolStripMenuItem.Visible = true;
                    this.aeronavesToolStripMenuItem.Visible = true;
                    this.generarViajeToolStripMenuItem.Visible = true;
                    this.registroDeLlegadaADestinoToolStripMenuItem.Visible = true;
                    this.compraToolStripMenuItem.Visible = true;
                    this.cancelacionDevolucionToolStripMenuItem.Visible = true;
                    this.consultaDeMillasToolStripMenuItem.Visible = true;
                    this.canjeDeMillasToolStripMenuItem.Visible = true;
                    this.listadoEstadisticoToolStripMenuItem.Visible = true;
                }
                else // CLIENTE
                {
                    this.compraToolStripMenuItem.Visible = true;
                }
            }
        }

        private void ocultarMenus()
        {
            // ocultar todos los menus
            this.rolesToolStripMenuItem.Visible = false;
            this.rutaAereaToolStripMenuItem.Visible = false;
            this.aeronavesToolStripMenuItem.Visible = false;
            this.generarViajeToolStripMenuItem.Visible = false;
            this.registroDeLlegadaADestinoToolStripMenuItem.Visible = false;
            this.compraToolStripMenuItem.Visible = false;
            this.cancelacionDevolucionToolStripMenuItem.Visible = false;
            this.consultaDeMillasToolStripMenuItem.Visible = false;
            this.canjeDeMillasToolStripMenuItem.Visible = false;
            this.listadoEstadisticoToolStripMenuItem.Visible = false;
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RolesForm form = new RolesForm();
            form.ShowDialog();
        }

        private void rutaAereaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RutasForm form = new RutasForm();
            form.ShowDialog();
        }

        private void aeronavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormsUtils.openNewForm(new AltaAeronave());
        }

        private void generarViajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerarViajeForm form = new GenerarViajeForm();
            form.ShowDialog();
        }

        private void registroDeLlegadaADestinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroLlegadaDestinoForm form = new RegistroLlegadaDestinoForm();
            form.ShowDialog();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompraForm form = new CompraForm();
            form.ShowDialog();
        }

        private void cancelacionDevolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevolucionForm form = new DevolucionForm();
            form.ShowDialog();
        }

        private void consultaDeMillasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaMillasForm form = new ConsultaMillasForm();
            form.ShowDialog();
        }

        private void canjeDeMillasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CanjeMillasForm form = new CanjeMillasForm();
            form.ShowDialog();
        }

        private void listadoEstadisticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoEstadisticoForm form = new ListadoEstadisticoForm();
            form.ShowDialog();
        }

    }
}
