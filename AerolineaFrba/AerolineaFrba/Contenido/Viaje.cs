using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AerolineaFrba.GD2C2015DataSetTableAdapters;

namespace AerolineaFrba.Contenido
{
    public class Viaje
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

        private int rutaId;
        public int RutaId
        {
            get
            {
                return rutaId;
            }

            set
            {
                rutaId = value;
            }
        }

        private int aeronaveId;
        public int AeronaveId
        {
            get
            {
                return aeronaveId;
            }

            set
            {
                aeronaveId = value;
            }
        }

        private DateTime fechaSalida;
        public DateTime FechaSalida
        {
            get
            {
                return fechaSalida;
            }

            set
            {
                fechaSalida = value;
            }
        }

        private DateTime fechaLlegada;
        public DateTime FechaLlegada
        {
            get
            {
                return fechaLlegada;
            }

            set
            {
                fechaLlegada = value;
            }
        }

        private DateTime fechaLlegadaEstimada;
        public DateTime FechaLlegadaEstimada
        {
            get
            {
                return fechaLlegadaEstimada;
            }

            set
            {
                fechaLlegadaEstimada = value;
            }
        }

        private VuelosTableAdapter vuelosTableAdapter = new VuelosTableAdapter();
        private GD2C2015DataSet dataSet = new GD2C2015DataSet();

    }
}
