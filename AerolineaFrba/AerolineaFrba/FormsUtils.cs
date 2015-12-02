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
    class FormsUtils
    {

        private static Form lastForm;
        private static Form actualForm;
        private static List<Form> formList = new List<Form>();
        private static int position;


        //seteo cual es la ventana principal
        public static void initForm(Form initForm)
        {
            formList.Add(initForm);
            initForm.MdiParent = MenuForm.ActiveForm;
            initForm.Show();
        }

        //esta funcion abre una ventana nueva seteando la anterior para luego poder volver atras
        public static void openNewForm(Form newForm)
        {
            position = formList.Count();
            lastForm = formList[position - 1];
            lastForm.Hide();
            formList.Add(newForm);
            newForm.MdiParent = MenuForm.ActiveForm;
            newForm.Show();
        }


        //esta funcion permite volver a la ventana anterior
        public static void backLastForm()
        {
            position = formList.Count();
            if (position > 0)
            {
                lastForm = formList[position - 2];
                actualForm = formList[position - 1];
                actualForm.Close();
                formList.RemoveAt(position - 1);
                lastForm.Show();
            }
        }
        public static Form getVentanaAnterior()
        {
            position = formList.Count();
            return formList[position - 2];
        }

        //esta funcion permite volver al menu principal
        public static void backInitForm()
        {
            position = formList.Count();
            actualForm = formList[position - 1];
            actualForm.Hide();
            while (position > 2)
            {
                formList.RemoveAt(position - 1);
                position = position - 1;
            }
            position = formList.Count();
            actualForm = formList[position - 1];
            actualForm.Show();
        }
      


    }
}
