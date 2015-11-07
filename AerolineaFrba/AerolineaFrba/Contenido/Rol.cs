using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AerolineaFrba.GD2C2015DataSetTableAdapters;

namespace AerolineaFrba.Contenido
{
    public class Rol
    {
        private int id;
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        private String descripcion;
        public String Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        private bool activo;
        public bool Activo
        {
            get
            {
                return activo;
            }

            set
            {
                activo = value;
            }
        }

        private RolesTableAdapter rolTableAdapter = new RolesTableAdapter();
        private Funciones_RolesTableAdapter funcionesRolTableAdapter = new Funciones_RolesTableAdapter();
        private FuncionesTableAdapter funcionesTableAdapter = new FuncionesTableAdapter();
        private UsuariosTableAdapter usuariosTableAdapter = new UsuariosTableAdapter();
        private GD2C2015DataSet dataSet = new GD2C2015DataSet();

        public Rol buscarRol(int rolId)
        {
            Rol rol;
            this.rolTableAdapter.Fill(this.dataSet.Roles);
            if (this.dataSet.Roles.Select("rol_id='" + rolId + "'").Length != 0)
            {
                GD2C2015DataSet.RolesRow row = (GD2C2015DataSet.RolesRow)this.dataSet.Roles.Select("rol_id='" + rolId + "'").First();
                rol = new Rol();
                rol.Activo = row.rol_activo;
                rol.Descripcion = row.rol_descripcion;
                rol.Id = row.rol_id;

                return rol;
            }
            return null;
        }

        public List<Funcionalidad> buscarFuncionalidades(int id)
        {
            List<Funcionalidad> funcionalidades = Funcionalidad.getFuncionalidadesRol(id);
            return funcionalidades;
        }

    }
}
