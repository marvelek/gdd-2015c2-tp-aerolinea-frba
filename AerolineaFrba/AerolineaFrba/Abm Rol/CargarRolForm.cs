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

namespace AerolineaFrba.Abm_Rol
{
    public partial class CargarRolForm : Form
    {
        Rol rol = null;
        RolesTableAdapter rolesTableAdapter = new RolesTableAdapter();
        Funciones_RolesTableAdapter funcionesRolesTableAdapter = new Funciones_RolesTableAdapter();
        GD2C2015DataSet dataSet = new GD2C2015DataSet();

        public CargarRolForm(Rol rol)
        {
            InitializeComponent();

            List<Funcionalidad> funciones = Funcionalidad.getFunciones();
            foreach (Funcionalidad f in funciones)
            {
                this.checkedListBox1.Items.Insert(f.Id-1, f.Descripcion);
            }
            this.checkedListBox1.Refresh();

            if (rol != null)
            {
                this.rol = rol;
                this.checkBox1.Checked = rol.Activo;
                this.descripcion.Text = rol.Descripcion;
                List<Funcionalidad> funcionalidades = rol.buscarFuncionalidades(rol.Id);
                foreach (Funcionalidad f in funcionalidades)
                {
                    this.checkedListBox1.SetItemChecked(f.Id-1, true);
                }
            }
            else
            {
                this.checkBox1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.valido())
            {

                if (rol != null)
                {
                    // update

                    this.rolesTableAdapter.Fill(this.dataSet.Roles);
                    GD2C2015DataSet.RolesRow[] result = (GD2C2015DataSet.RolesRow[])this.dataSet.Roles.Select("rol_descripcion='" + this.descripcion.Text + "' AND rol_id <> " + rol.Id);
                    if (result.Length > 0)
                    {
                        MessageBox.Show("Ya existe otro rol con esa descripción\n");
                        return;
                    }

                    this.rolesTableAdapter.rolModificar(this.descripcion.Text, this.checkBox1.Checked, this.rol.Id);
                    this.funcionesRolesTableAdapter.funcionesRolesBorrar(this.rol.Id);
                }
                else
                {
                    this.rolesTableAdapter.Fill(this.dataSet.Roles);
                    GD2C2015DataSet.RolesRow[] result = (GD2C2015DataSet.RolesRow[])this.dataSet.Roles.Select("rol_descripcion='" + this.descripcion.Text + "'");
                    if (result.Length > 0)
                    {
                        MessageBox.Show("Ya existe el rol con esa descripción\n");
                        return;
                    }

                    // insert
                    this.rol = new Rol();
                    this.rol.Id = Convert.ToInt32(this.rolesTableAdapter.rolInsertar(this.descripcion.Text));
                }

                foreach (object itemChecked in this.checkedListBox1.CheckedItems)
                {
                    int funcId = this.checkedListBox1.Items.IndexOf(itemChecked) + 1;
                    if (funcId != 0)
                    {
                        this.funcionesRolesTableAdapter.funcionesRolesInsertar(funcId, this.rol.Id);
                    }
                }
                this.rolesTableAdapter.Fill(this.dataSet.Roles);
                this.funcionesRolesTableAdapter.Fill(this.dataSet.Funciones_Roles);

                MessageBox.Show("El rol ha sido guardado correctamente");
                this.Close();
            }
            else
            {
                return;
            }
        }

        private bool valido()
        {
            Utiles validador = new Utiles();
            string error = null;
            if (this.descripcion.Text == "")
            {
                error = "El nombre del Rol no puede ser nulo\n";
            }
            if (this.checkedListBox1.CheckedItems.Count < 1)
            {
                error = error + "Debe seleccionar por lo menos una funcion\n";
            }
            if (error != null)
            {
                MessageBox.Show(error);
                return false;
            }
            return true;
        }

        private void CargarRolForm_Load(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
