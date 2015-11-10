using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AerolineaFrba.GD2C2015DataSetTableAdapters;

namespace AerolineaFrba.Contenido
{
    public class Ruta
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

            private decimal codigo;
            public decimal Codigo
            {
                get
                {
                    return codigo;
                }

                set
                {
                    codigo = value;
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

            private int ciudadOrigen;
                public int CiudadOrigen
                {
                    get
                    {
                        return ciudadOrigen;
                    }

                    set
                    {
                        ciudadOrigen = value;
                    }
                }

            private int ciudadDestino;
                public int CiudadDestino
                {
                    get
                    {
                        return ciudadDestino;
                    }

                    set
                    {
                        ciudadDestino = value;
                    }
                }

                private decimal precioKg;
                public decimal PrecioKg
                {
                    get
                    {
                        return precioKg;
                    }

                    set
                    {
                        precioKg = value;
                    }
                }

                private decimal precioBase;
                public decimal PrecioBase
                {
                    get
                    {
                        return precioBase;
                    }

                    set
                    {
                        precioBase = value;
                    }
                }




            private RutasTableAdapter rutaTableAdapter = new RutasTableAdapter();
            private Tipos_Servicio_RutasTableAdapter tipos_servicio_RutasTableAdapter = new Tipos_Servicio_RutasTableAdapter();
            private Tipos_ServicioTableAdapter tipos_ServicioTableAdapter = new Tipos_ServicioTableAdapter();
            private UsuariosTableAdapter usuariosTableAdapter = new UsuariosTableAdapter();
            private GD2C2015DataSet dataSet = new GD2C2015DataSet();

            public Ruta buscarRuta(int rutaId)
            {
                Ruta ruta;
                this.rutaTableAdapter.Fill(this.dataSet.Rutas);
                if (this.dataSet.Rutas.Select("rut_id='" + rutaId + "'").Length != 0)
                {
                    GD2C2015DataSet.RutasRow row = (GD2C2015DataSet.RutasRow)this.dataSet.Rutas.Select("rut_id='" + rutaId + "'").First();
                    ruta = new Ruta();
                    ruta.Activo = row.rut_activo;
                    ruta.codigo = row.rut_codigo;
                    ruta.ciudadDestino = row.ciudad_destino_id;
                    ruta.ciudadOrigen = row.ciudad_origen_id;
                    ruta.precioKg = row.rut_precio_base_kg;
                    ruta.precioBase = row.rut_precio_base_pasaje;
                    ruta.Id = row.rut_id;

                    return ruta;
                }
                return null;
            }

            public List<Tipo_Servicio> buscarTiposServicio(int id)
            {
                List<Tipo_Servicio> tiposServicio = Tipo_Servicio.getTiposServicioRutas(id);
                return tiposServicio;
            }

        }
    }
