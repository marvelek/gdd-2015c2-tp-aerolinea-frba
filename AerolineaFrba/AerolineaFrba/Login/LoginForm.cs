using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.Registro_de_Usuario;
using AerolineaFrba.Contenido;

namespace AerolineaFrba.Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        private void entrar_Click(object sender, EventArgs e)
        {
            // 1 es Verdadero
            // 0 es falso
            if (this.password.Text == "")
            {
                MessageBox.Show("Tenes que ingresar una password");
                return;
            }

            if (this.usuario.Text == "")
            {
                MessageBox.Show("Debe ingresar un usuario");
                return;
            }

            Usuario usr = new Usuario();
            usr = usr.buscar(this.usuario.Text);

            if (usr != null)
            {
                if (usr.IntentosFallidos >= 3)
                {
                    MessageBox.Show("Su usuario fue inhabilitado. Comunicate con el administrador");
                    return;
                }

                byte[] data = Utiles.encriptar(this.password.Text);

                if (!(usr.Password.SequenceEqual(data)))
                {
                    MessageBox.Show("Clave Incorrecta");
                    usr.IntentosFallidos = usr.IntentosFallidos + 1;
                    usr.update();

                    if (usr.IntentosFallidos > 3)
                    {
                        MessageBox.Show("Supero la cantidad de intentos. Su usuario fue inhabilitado. Comunicate con el administrador");
                        return;
                    }
                    return;
                }

            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
                return;
            }

            usr.IntentosFallidos = 0;
            usr.update();

            MenuForm menu = new MenuForm();
            menu.setPermisos(1);
            this.Hide();
            menu.ShowDialog();
            this.Close();

        }

    }
}
