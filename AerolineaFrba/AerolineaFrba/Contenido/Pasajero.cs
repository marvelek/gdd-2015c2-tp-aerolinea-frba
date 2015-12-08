using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Contenido
{
    public class Pasajero
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

        private int dni;
        public int Dni
        {
            get
            {
                return dni;
            }

            set
            {
                dni = value;
            }
        }

        private int telefono;
        public int Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
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

        private String apellido;
        public String Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        private String direccion;
        public String Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        private String mail;
        public String Mail
        {
            get
            {
                return mail;
            }

            set
            {
                mail = value;
            }
        }

        private DateTime fechaNacimiento;
        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }

            set
            {
                fechaNacimiento = value;
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

        private int butacaId;
        public int ButacaId
        {
            get
            {
                return butacaId;
            }

            set
            {
                butacaId = value;
            }
        }
        private string butacaString;
        public string ButacaString
        {
            get
            {
                return butacaString;
            }

            set
            {
                butacaString = value;
            }
        }
        private int codigoPasaje;
        public int CodigoPasaje
        {
            get
            {
                return codigoPasaje;
            }

            set
            {
                codigoPasaje = value;
            }
        }
        private int pesoPaquete;
        public int PesoPaquete
        {
            get
            {
                return pesoPaquete;
            }

            set
            {
                pesoPaquete = value;
            }
        }
        private decimal precio;
        public decimal Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }
    }
}
