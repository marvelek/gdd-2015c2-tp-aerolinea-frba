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





        public virtual DateTime getFecha()
        {
            return AerolineaFrba.Properties.Settings.Default.FechaSistema;
        }
    }
}
