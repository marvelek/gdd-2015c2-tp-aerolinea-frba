using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AerolineaFrba.GD2C2015DataSetTableAdapters;
using AerolineaFrba.Contenido;

namespace AerolineaFrba.Contenido
{
    public class Aeronave
    {
        private AeronavesTableAdapter aeronavesTableAdapter = new AeronavesTableAdapter();
        private VuelosTableAdapter vuelosTableAdapter = new VuelosTableAdapter();
        private GD2C2015DataSet dataSet = new GD2C2015DataSet();
        private GD2C2015DataSet.AeronavesRow aeronaveRow;

        private int id;
        private bool activo;
        private string fabricante;
        private decimal kg_disponibles;

        private string matricula;
        public string Matricula
        {
            get
            {
                return matricula;
            }
            set
            {
                matricula = value;
            }

        }


        private string modelo;
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

        public GD2C2015DataSet.AeronavesDataTable buscarAeronavesDeReemplazo(int aerId, DateTime fechaHasta)
        {
            return this.aeronavesTableAdapter.GetDataByReemplazo(aerId, fechaHasta);
        }


        public Aeronave buscarByMatricula(String matricula)
        {
            try
            {
                Aeronave aer;
                this.aeronavesTableAdapter.Fill(this.dataSet.Aeronaves);
                GD2C2015DataSet.AeronavesDataTable result = aeronavesTableAdapter.GetDataBy41(matricula);

                if (result.Count != 0)
                {
                    aeronaveRow = result.First();
                    aer = new Aeronave();
                    aer.Id = aeronaveRow.aer_id;
                    aer.activo = aeronaveRow.aer_activo;
                    aer.fabricante = aeronaveRow.aer_fabricante;
                    aer.kg_disponibles = aeronaveRow.aer_kg_disponibles;
                    aer.matricula = aeronaveRow.aer_matricula;
                    aer.modelo = aeronaveRow.aer_modelo;


                    return aer;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
            return null;
        }


        public void fueraDeServicioHasta(int aerId, String motivo, DateTime fechaHasta)
        {
            try
            {
                aeronavesTableAdapter.AeronavesIniciarFueraDeServicio(aerId, motivo, fechaHasta);
            }
            catch (Exception e)
            {

                e.ToString();
            }

        }

        public void bajaDefinitiva(int aerId)
        {
            try
            {
                aeronavesTableAdapter.AeronavesBajaDefinitiva(aerId);
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }

        public Boolean aeronaveYaFS(int aerId)
        {
            try
            {
                
                this.aeronavesTableAdapter.Fill(this.dataSet.Aeronaves);
                GD2C2015DataSet.AeronavesDataTable result = aeronavesTableAdapter.GetDataByAerFSActualmente(aerId);

                if (result.Count != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
            return false;
        }

        public bool tieneVuelosPendientes(int aerId) {
            GD2C2015DataSet.VuelosDataTable result = obtenerVuelosFuturosAer(aerId);
            if (result.Count == 0)
            {
                return false;
            }
            else {
                return true;
            }
        
        }

        public bool tieneVuelosPendientesFS(int aerId, DateTime fechaHasta)
        {
            GD2C2015DataSet.VuelosDataTable result = obtenerVuelosFuturosAerFs(aerId, fechaHasta);
            if (result.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public GD2C2015DataSet.VuelosDataTable obtenerVuelosFuturosAer(int aerId)
        {

            this.vuelosTableAdapter.Fill(this.dataSet.Vuelos);
            return vuelosTableAdapter.GetDataByVuelosFuturosVyAer(aerId);
        }

        public void cancelarVuelosDef(int aerId) {
            this.aeronavesTableAdapter.AeronavesCancelacionBajaDef(aerId);
        }

        public void cancelarVuelosFs(int aerId, String motivo, DateTime fechaHasta)
        {
            this.aeronavesTableAdapter.AeronavesCancelacionBajaFS(aerId, motivo, fechaHasta);
        }

        public GD2C2015DataSet.VuelosDataTable obtenerVuelosFuturosAerFs(int aerId, DateTime fechaHasta)
        {
            this.vuelosTableAdapter.Fill(this.dataSet.Vuelos);
            return vuelosTableAdapter.GetDataByVuelosFuturosByAerFS(aerId, fechaHasta);
        }

    }
}

    

