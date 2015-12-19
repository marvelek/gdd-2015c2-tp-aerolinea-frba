using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Devolucion
{
    public partial class DevolucionForm : Form
    {
        public DevolucionForm()
        {
            InitializeComponent();           
            this.comboBox1.SelectedIndex = 0;
        }

        private void DevolucionForm_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {            
            switch (Convert.ToString(comboBox1.SelectedItem))
            {
                case "VENTAS":
                    this.grillaVenta.Visible = true;
                    this.grillaPaquete.Visible = false;
                    this.grillaPasaje.Visible = false;
                    break;
                case "PAQUETES":
                    this.grillaVenta.Visible = false;
                    this.grillaPaquete.Visible = true;
                    this.grillaPasaje.Visible = false;
                    break;
                case "PASAJES":
                    this.grillaVenta.Visible = false;
                    this.grillaPaquete.Visible = false;
                    this.grillaPasaje.Visible = true;
                    break;
                default:
                    this.grillaVenta.Visible = true;
                    this.grillaPaquete.Visible = false;
                    this.grillaPasaje.Visible = false;
                    this.ventasTableAdapter.Fill(this.gD2C2015DataSet.Ventas);
                    break;          

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            switch (Convert.ToString(comboBox1.SelectedItem))
            {
                case "VENTAS":
                    int ventaActivo = Convert.ToInt32(grillaVenta.Rows[grillaVenta.CurrentRow.Index].Cells[5].Value);
                    if (ventaActivo == 1)
                    {
                        int idVenta = Convert.ToInt32(grillaVenta.Rows[grillaVenta.CurrentRow.Index].Cells[0].Value);
                        this.ventasTableAdapter.ventaCancelacion(idVenta);
                        this.ventasTableAdapter.FillBy(this.gD2C2015DataSet.Ventas, this.codigo.Text);
                        MessageBox.Show("La venta ha sido cancelada correctamente.");
                    }
                    else { MessageBox.Show("La venta ha sido cancelada previamente."); }
                    break;
                case "PAQUETES":
                    int paqActivo = Convert.ToInt32(grillaPaquete.Rows[grillaPaquete.CurrentRow.Index].Cells[7].Value);
                    if (paqActivo == 1)
                    {
                        int idPaquete = Convert.ToInt32(grillaPaquete.Rows[grillaPaquete.CurrentRow.Index].Cells[0].Value);
                        this.paquetesTableAdapter.paqueteCancelacion(idPaquete);
                        this.paquetesTableAdapter.FillBy(this.gD2C2015DataSet.Paquetes, this.codigo.Text);
                        MessageBox.Show("El paquete ha sido cancelado correctamente.");
                    }
                    else { MessageBox.Show("El paquete ha sido cancelado previamente."); }
                    break;
                case "PASAJES":
                    int pasActivo = Convert.ToInt32(grillaPasaje.Rows[grillaPasaje.CurrentRow.Index].Cells[7].Value);
                    if (pasActivo == 1)
                    {                   
                        int idPasaje = Convert.ToInt32(grillaPasaje.Rows[grillaPasaje.CurrentRow.Index].Cells[0].Value);                   
                        this.pasajesTableAdapter.pasajeCancelacion(idPasaje);
                        this.pasajesTableAdapter.FillBy(this.gD2C2015DataSet.Pasajes, this.codigo.Text);
                        MessageBox.Show("El pasaje ha sido cancelado correctamente.");
                    }
                    else { MessageBox.Show("El pasaje ha sido cancelado previamente."); }
                    break;                    
                default:
                    int venActivo = Convert.ToInt32(grillaVenta.Rows[grillaVenta.CurrentRow.Index].Cells[5].Value);
                    if (venActivo == 1)
                    {
                        int id = Convert.ToInt32(grillaVenta.Rows[grillaVenta.CurrentRow.Index].Cells[0].Value);
                        this.ventasTableAdapter.ventaCancelacion(id);
                        this.ventasTableAdapter.FillBy(this.gD2C2015DataSet.Ventas, this.codigo.Text);
                        MessageBox.Show("La venta ha sido cancelada correctamente");
                    }
                    else { MessageBox.Show("La venta ha sido cancelada previamente."); }
                    break;

            }                            
        }

        private void grillaPasaje_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grillaPasaje.Rows[grillaPasaje.CurrentRow.Index].Cells[2].Value == null)
            {
                button1.Enabled = false;
            }
            else {
                button1.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.codigo.Text != "")
            {
                switch (Convert.ToString(comboBox1.SelectedItem))
               {
                  case "VENTAS":                    
                       this.ventasTableAdapter.FillBy(this.gD2C2015DataSet.Ventas, this.codigo.Text);
                       break;
                   case "PAQUETES":
                       this.paquetesTableAdapter.FillBy(this.gD2C2015DataSet.Paquetes, this.codigo.Text);
                       break;
                   case "PASAJES":
                       this.pasajesTableAdapter.FillBy(this.gD2C2015DataSet.Pasajes, this.codigo.Text);
                       break;
                   default:
                       this.ventasTableAdapter.FillBy(this.gD2C2015DataSet.Ventas, this.codigo.Text);
                       break;
               }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un código para mostrar."); 
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.codigo.Clear();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idVenta; 
            string codigo = null;     
            int devolucion;
            switch (Convert.ToString(comboBox1.SelectedItem))
            {
                case "VENTAS":                                       
                    MessageBox.Show("Para ver una cancelación debe seleccionar un paquete o un pasaje.");  
                    break;
                case "PAQUETES":
                    idVenta = Convert.ToInt32(grillaPaquete.Rows[grillaPaquete.CurrentRow.Index].Cells[3].Value);
                    codigo = Convert.ToString(grillaPaquete.Rows[grillaPaquete.CurrentRow.Index].Cells[4].Value);
                    if (Convert.ToString(grillaPaquete.Rows[grillaPaquete.CurrentRow.Index].Cells[2].Value) == "")
                    {
                        MessageBox.Show("Debe seleccionar un paquete cancelado.");    
                        break;
                    }
                    devolucion = Convert.ToInt32(grillaPaquete.Rows[grillaPaquete.CurrentRow.Index].Cells[2].Value);
                    new VistaDevolucionForm(Convert.ToString(comboBox1.SelectedItem), idVenta, codigo, devolucion).ShowDialog();
                    break;
                case "PASAJES":
                    idVenta = Convert.ToInt32(grillaPasaje.Rows[grillaPasaje.CurrentRow.Index].Cells[3].Value);
                    codigo = Convert.ToString(grillaPasaje.Rows[grillaPasaje.CurrentRow.Index].Cells[5].Value);
                    if (Convert.ToString(grillaPasaje.Rows[grillaPasaje.CurrentRow.Index].Cells[2].Value) == "")                    
                    {
                        MessageBox.Show("Debe seleccionar un pasaje cancelado.");
                        break;
                    }
                    devolucion = Convert.ToInt32(grillaPasaje.Rows[grillaPasaje.CurrentRow.Index].Cells[2].Value);
                    new VistaDevolucionForm(Convert.ToString(comboBox1.SelectedItem), idVenta, codigo, devolucion).ShowDialog();
                    break;                    
                default:
                    MessageBox.Show("Para ver una cancelación debe seleccionar un paquete o un pasaje."); 
                    break;

            }                        
        }

        private void grillaPaquete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grillaPaquete.Rows[grillaPaquete.CurrentRow.Index].Cells[2].Value == null)
            {
                button1.Enabled = false;
            }
            else {
                button1.Enabled = true;
            }       
        }
    }
}
