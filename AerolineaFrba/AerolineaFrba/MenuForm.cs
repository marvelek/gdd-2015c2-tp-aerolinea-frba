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
                if (f.Id == 0) //ADMIN
                {
                    // this.adminMenu.Visible = true;

                }
                if (f.Id == 1) // CLIENTE
                {
                    
                }
            }
        }

        private void ocultarMenus()
        {
            // ocultar todos los menus
        }

    }
}
