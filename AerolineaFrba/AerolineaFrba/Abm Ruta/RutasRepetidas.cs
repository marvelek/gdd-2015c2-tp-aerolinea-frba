using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Ruta
{
    public partial class RutasRepetidas : Form
    {
        public RutasRepetidas()
        {                
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.rutasRepetidas' Puede moverla o quitarla según sea necesario.
            this.rutasRepetidasTableAdapter.Fill(this.gD2C2015DataSet.rutasRepetidas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.rutasRepetidasTableAdapter.rutasRepetidasUpdate();
            return;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
