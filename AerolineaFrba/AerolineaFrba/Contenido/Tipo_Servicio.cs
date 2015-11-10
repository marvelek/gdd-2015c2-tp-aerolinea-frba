using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AerolineaFrba.GD2C2015DataSetTableAdapters;

namespace AerolineaFrba.Contenido
{
    public class Tipo_Servicio
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

        public static List<Tipo_Servicio> getTiposServicioRutas(int rutaId)
        {
            GD2C2015DataSet dataSet = new GD2C2015DataSet();
            Tipos_ServicioTableAdapter tipos_ServicioTA = new Tipos_ServicioTableAdapter();
            tipos_ServicioTA.Fill(dataSet.Tipos_Servicio);
            Tipos_Servicio_RutasTableAdapter tipos_Servicio_RutasTA = new Tipos_Servicio_RutasTableAdapter();
            tipos_Servicio_RutasTA.Fill(dataSet.Tipos_Servicio_Rutas);

            List<Tipo_Servicio> tipos_Servicio = new List<Tipo_Servicio>();

            GD2C2015DataSet.Tipos_Servicio_RutasRow[] tiposServ = (GD2C2015DataSet.Tipos_Servicio_RutasRow[])dataSet.Tipos_Servicio_Rutas.Select("rut_id='" + rutaId + "'");
            foreach (GD2C2015DataSet.Tipos_Servicio_RutasRow tipServ in tiposServ)
            {
                GD2C2015DataSet.Tipos_ServicioRow tipo_Servicio = (GD2C2015DataSet.Tipos_ServicioRow)dataSet.Tipos_Servicio.Select("tip_id='" + tipServ.tipo_servicio_id + "'").First();
                Tipo_Servicio ts = new Tipo_Servicio();
                ts.Id = tipo_Servicio.tip_id;
                ts.Descripcion = tipo_Servicio.tip_descripcion;
                tipos_Servicio.Add(ts);
            }
            return tipos_Servicio;
        }


        internal static List<Tipo_Servicio> getTipos_Servicio()
        {
            GD2C2015DataSet dataSet = new GD2C2015DataSet();
            Tipos_ServicioTableAdapter tipos_ServicioTableAdapter = new Tipos_ServicioTableAdapter();
            List<Tipo_Servicio> tipos_Servicios = new List<Tipo_Servicio>();

            tipos_ServicioTableAdapter.Fill(dataSet.Tipos_Servicio);
            GD2C2015DataSet.Tipos_ServicioRow[] tipos_Servicio = (GD2C2015DataSet.Tipos_ServicioRow[])dataSet.Tipos_Servicio.Select();
            foreach (GD2C2015DataSet.Tipos_ServicioRow tipServ in tipos_Servicio)
            {
                Tipo_Servicio ts = new Tipo_Servicio();
                ts.Id = tipServ.tip_id;
                ts.Descripcion = tipServ.tip_descripcion;
                tipos_Servicios.Add(ts);
            }
            return tipos_Servicios;
        }
    }
}
