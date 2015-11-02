using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AerolineaFrba.GD2C2015DataSetTableAdapters;

namespace AerolineaFrba.Contenido
{
    class Funcionalidad
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

        public static List<Funcionalidad> getFuncionalidadesRol(int rolId)
        {
            GD2C2015DataSet dataSet = new GD2C2015DataSet();
            FuncionesTableAdapter funcionesTA = new FuncionesTableAdapter();
            funcionesTA.Fill(dataSet.Funciones);
            Funciones_RolesTableAdapter funcionesRolesTA = new Funciones_RolesTableAdapter();
            funcionesRolesTA.Fill(dataSet.Funciones_Roles);

            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();

            GD2C2015DataSet.Funciones_RolesRow[] funcs = (GD2C2015DataSet.Funciones_RolesRow[])dataSet.Funciones_Roles.Select("rol_id='" + rolId + "'");
            foreach (GD2C2015DataSet.Funciones_RolesRow func in funcs)
            {
                GD2C2015DataSet.FuncionesRow funcion = (GD2C2015DataSet.FuncionesRow)dataSet.Funciones.Select("fun_id='" + func.funcion_id + "'").First();
                Funcionalidad f = new Funcionalidad();
                f.Id = funcion.fun_id;
                f.Descripcion = funcion.fun_descripcion;
                funcionalidades.Add(f);
            }
            return funcionalidades;
        }

    }
}
