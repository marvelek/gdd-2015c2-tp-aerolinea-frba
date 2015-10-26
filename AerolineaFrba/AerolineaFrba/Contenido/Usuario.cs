using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AerolineaFrba.GD2C2015DataSetTableAdapters;

namespace AerolineaFrba.Content
{
    class Usuario
    {

        private UsuariosTableAdapter usuariosTableAdapter = new UsuariosTableAdapter();
        private GD2C2015DataSet dataSet = new GD2C2015DataSet();
        private GD2C2015DataSet.UsuariosRow usuarioRow;

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

        private String nombre;
        public String Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        private byte[] password;
        public byte[] Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        private int rol;
        public int Rol
        {
            get
            {
                return rol;
            }

            set
            {
                rol = value;
            }
        }

        private int intentosFallidos;
        public int IntentosFallidos
        {
            get
            {
                return intentosFallidos;
            }

            set
            {
                intentosFallidos = value;
            }
        }

        private int activo;
        public int Activo
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

        public Usuario buscar(String nombre)
        {
            Usuario usr;
            this.usuariosTableAdapter.Fill(this.dataSet.Usuarios);
            GD2C2015DataSet.UsuariosRow[] result = (GD2C2015DataSet.UsuariosRow[])this.dataSet.Usuarios.Select("usu_nombre='" + nombre + "'");
            if (result.Length != 0)
            {
                usuarioRow = result.First();
                usr = new Usuario();

                //Usuario u = getCliente(usuarioRow.usu_id);
                //{
                //    //Es el administrador!
                //    u = new Usuario();
                //}
                usr.Id = usuarioRow.usu_id;
                usr.Activo = usuarioRow.usu_activo;
                usr.IntentosFallidos = usuarioRow.usu_intentos_logueo_fallidos;
                usr.Password = usuarioRow.usu_password;
                usr.Nombre = usuarioRow.usu_nombre;
                //usr.Rol = buscarRol(usuarioRow.rol_id);
                
                return usr;
            }
            else
            {
                return null;
            }
        }

        public void update()
        {
            this.usuariosTableAdapter.Fill(this.dataSet.Usuarios);
            GD2C2015DataSet.UsuariosRow row = (GD2C2015DataSet.UsuariosRow)this.dataSet.Usuarios.Select("usu_nombre='" + nombre + "'").First();
            row.usu_nombre = this.Nombre;
            row.usu_password = this.Password;
            row.rol_id = this.Rol;
            row.usu_intentos_logueo_fallidos = this.IntentosFallidos;
            row.usu_activo = this.Activo;

            usuariosTableAdapter.Update(row);
        }

    }
}
