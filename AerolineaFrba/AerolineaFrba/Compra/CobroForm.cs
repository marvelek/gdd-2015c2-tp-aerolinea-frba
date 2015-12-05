using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Compra
{
    public partial class CobroForm : Form
    {
        public Contenido.Pasajero[] pasajeros;

        public CobroForm()
        {
            InitializeComponent();
        }

        public CobroForm(Contenido.Pasajero[] pasajeros)
        {
            // TODO: Complete member initialization
            this.pasajeros = pasajeros;
        }
    }
}
