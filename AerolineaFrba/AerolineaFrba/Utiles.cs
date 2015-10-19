using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba
{
    class Utiles
    {
        public static byte[] encriptar(string password)
        {
            byte[] data = new byte[32];
            System.Security.Cryptography.SHA256 sha = new System.Security.Cryptography.SHA256Managed();
            data = StringToBytes(password);
            return sha.ComputeHash(data);
        }

        public static byte[] StringToBytes(String cadena)
        {
            System.Text.ASCIIEncoding codificador = new System.Text.ASCIIEncoding();
            return codificador.GetBytes(cadena);
        }

        public virtual DateTime getFecha()
        {
            return AerolineaFrba.Properties.Settings.Default.FechaSistema;
        }
    }
}
