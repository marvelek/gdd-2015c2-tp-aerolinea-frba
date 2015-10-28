using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AerolineaFrba.GD2C2015DataSetTableAdapters;

namespace AerolineaFrba.Contenido
{
    class Rol
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

        private RolesTableAdapter rolTableAdapter = new RolesTableAdapter;
        private Funciones_RolesTableAdapter funcionesRolTableAdapter = new Funciones_RolesTableAdapter();
        private FuncionesTableAdapter funcionesTableAdapter = new FuncionesTableAdapter();
        private UsuariosTableAdapter usuariosTableAdapter = new UsuariosTableAdapter();
        private GD2C2015DataSet dataSet = new GD2C2015DataSet();

        public void crearRol(String nombre, List<Funcionalidad> funcionalidades)
        {
            this.rolTableAdapter.Insert(nombre, true);
            int id = 0;
            this.rolTableAdapter.Fill(this.dataSet.Roles);
            if (this.dataSet.Roles.Select("rol_descripcion='" + nombre + "'").Length != 0)
            {
                GD2C2015DataSet.RolesRow row = (GD2C2015DataSet.RolesRow)this.dataSet.Roles.Select("rol_descripcion='" + nombre + "'").First();
                id = row.rol_id;
            }
            foreach (Funcionalidad f in funcionalidades)
            {
                if (id != 0)
                {
                    this.funcionesRolTableAdapter.Insert(f.Id, id);
                }
            }
        }

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
            GD2C2015DataSet.FuncionesDataTable data = new GD2C2015DataSet.FuncionesDataTable();
            data = this.funcionesTableAdapter.buscarFuncionalidadesRol(id);
            System.Data.DataRowCollection rows = data.Rows;
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
            foreach (GD2C2015DataSet.FuncionesRow row in rows)
            {
                Funcionalidad f = new Funcionalidad();
                f.Id = row.fun_id;
                f.Descripcion = row.fun_descripcion;
                funcionalidades.Add(f);
            }
            return funcionalidades;
        }

        public void modificarRol(String nombre, List<Funcionalidad> funcionalidades, int id)
        {
            this.rolTableAdapter.Fill(this.dataSet.Roles);
            GD2C2015DataSet.RolesRow row = (GD2C2015DataSet.RolesRow)this.dataSet.Roles.Select("rol_id='" + id + "'").First();
            String nombreOriginal = row.rol_descripcion;
            bool activo = row.rol_activo;
            this.rolTableAdapter.Update(nombre, activo, id, nombreOriginal, activo);

            this.funcionesRolTableAdapter.Fill(this.dataSet.Funciones_Roles);
            while (this.dataSet.Funciones_Roles.Select("rol_id='" + id + "'").Length != 0)
            {
                GD2C2015DataSet.Funciones_RolesRow rowF = (GD2C2015DataSet.Funciones_RolesRow)this.dataSet.Funciones_Roles.Select("rol_id='" + id + "'").First();
                this.funcionesRolTableAdapter.Delete(id, rowF.funcion_id);
                this.funcionesRolTableAdapter.Fill(this.dataSet.Funciones_Roles);
            }

            foreach (Funcionalidad f in funcionalidades)
            {
                this.funcionesRolTableAdapter.Insert(id, f.Id);
            }
        }

        public void bajaLogica(int id)
        {
            this.rolTableAdapter.Fill(this.dataSet.Roles);
            GD2C2015DataSet.RolesRow row = (GD2C2015DataSet.RolesRow)this.dataSet.Roles.Select("rol_id='" + id + "'").First();
            String nombre = row.rol_descripcion;
            bool activo = row.rol_activo;
            this.rolTableAdapter.Update(nombre, false, id, nombre, activo);
            
            this.usuariosTableAdapter.Fill(this.dataSet.Usuarios);
            while (this.dataSet.Usuarios.Select("rol_id='" + id + "'").Length != 0)
            {
                GD2C2015DataSet.UsuariosRow rowU = (GD2C2015DataSet.UsuariosRow) this.dataSet.Usuarios.Select("rol_id='" + id + "'").First();
                this.usuariosTableAdapter.Update(rowU.usu_nombre, rowU.usu_password, null, rowU.usu_intentos_logueo_fallidos, rowU.usu_activo, rowU.usu_id, rowU.usu_nombre, rowU.usu_password, rowU.rol_id, rowU.usu_intentos_logueo_fallidos, rowU.usu_activo);
                this.usuariosTableAdapter.Fill(this.dataSet.Usuarios);
            }
        }

    }
}
