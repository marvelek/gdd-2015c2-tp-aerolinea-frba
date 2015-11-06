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

namespace AerolineaFrba.Abm_Rol
{
    public partial class RolesForm : Form
    {
        public RolesForm()
        {
            InitializeComponent();
        }

        private void RolesForm_Load(object sender, EventArgs e)
        {
            this.rolesTableAdapter.Fill(this.gD2C2015DataSet.Roles);
        }

        private void carga_Click(object sender, EventArgs e)
        {
            new CargarRolForm(null).ShowDialog();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if (this.descripcion.Text != "")
            {
                this.rolesTableAdapter.FillBy(this.gD2C2015DataSet.Roles, this.descripcion.Text);
            }
            else
            {
                this.rolesTableAdapter.Fill(this.gD2C2015DataSet.Roles);
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            this.descripcion.Clear();
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            Rol rol = new Rol();
            rol.Id = Convert.ToInt16(data.Rows[data.CurrentRow.Index].Cells[0].Value);
            rol.Descripcion = Convert.ToString(data.Rows[data.CurrentRow.Index].Cells[1].Value);
            rol.Activo = Convert.ToBoolean(data.Rows[data.CurrentRow.Index].Cells[2].Value);
            new CargarRolForm(rol).ShowDialog();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(data.Rows[data.CurrentRow.Index].Cells[0].Value);
            this.rolesTableAdapter.bajaLogicaRol(id);
            // Aca tendria que tener un trigger que se dispare y le saque este rol a los usuarios que lo tengan
            this.rolesTableAdapter.Fill(this.gD2C2015DataSet.Roles);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
        }
    }
}
