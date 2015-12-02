using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace AerolineaFrba
{
    class Funciones
    {

        public static void onlyNumbers(KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        public static void numbersAndComa(TextBox text, KeyPressEventArgs e)
        {
            
            if (!((char.IsDigit(e.KeyChar)) || ((e.KeyChar == ',') && !text.Text.Contains(',')) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }


        public static void llenarCombobox(ComboBox combo,String valueMember, String display, String query)
        {
            DataTable dt = new DataTable();
            dt = ConexionSQL.getTablaPorConsulta(query);
            combo.Items.Clear();
            combo.DataSource = dt;
            combo.ValueMember = valueMember;
            combo.DisplayMember = display;
            combo.SelectedIndex = -1;
        }
    }
}
