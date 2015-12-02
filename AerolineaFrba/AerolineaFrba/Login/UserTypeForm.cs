using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Login
{
    public partial class UserTypeForm : Form
    {
        public UserTypeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm menu = new LoginForm();
            menu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            menu.setPermisos(0);
            menu.ShowDialog();
        }
    }
}
