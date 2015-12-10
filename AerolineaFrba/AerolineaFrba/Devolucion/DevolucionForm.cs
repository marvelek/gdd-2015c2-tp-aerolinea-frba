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
            //this.ventasTableAdapter.Fill(this.gD2C2015DataSet.Ventas);
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {            
            switch (Convert.ToString(comboBox1.SelectedItem))
            {
                case "VENTAS":
                    // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Ventas' Puede moverla o quitarla según sea necesario.
                    this.grillaVenta.Visible = true;
                    this.grillaPaquete.Visible = false;
                    this.grillaPasaje.Visible = false;
                    //this.ventasTableAdapter.Fill(this.gD2C2015DataSet.Ventas);
                    break;
                case "PAQUETES":
                    // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Paquetes' Puede moverla o quitarla según sea necesario.
                    this.grillaVenta.Visible = false;
                    this.grillaPaquete.Visible = true;
                    this.grillaPasaje.Visible = false;
                    //this.paquetesTableAdapter.Fill(this.gD2C2015DataSet.Paquetes);
                    break;
                case "PASAJES":
                    // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Pasajes' Puede moverla o quitarla según sea necesario.                                       
                    this.grillaVenta.Visible = false;
                    this.grillaPaquete.Visible = false;
                    this.grillaPasaje.Visible = true;
                    //this.pasajesTableAdapter.Fill(this.gD2C2015DataSet.Pasajes);
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
                    int idVenta = Convert.ToInt16(grillaVenta.Rows[grillaVenta.CurrentRow.Index].Cells[0].Value);                    
                    this.ventasTableAdapter.ventaCancelacion(idVenta);
                    this.ventasTableAdapter.FillBy(this.gD2C2015DataSet.Ventas, this.codigo.Text);
                    MessageBox.Show("La venta ha sido cancelada correctamente");                    
                    break;
                case "PAQUETES":                    
                    int idPaquete = Convert.ToInt16(grillaPaquete.Rows[grillaPaquete.CurrentRow.Index].Cells[0].Value);                    
                    this.paquetesTableAdapter.paqueteCancelacion(idPaquete);
                    this.paquetesTableAdapter.FillBy(this.gD2C2015DataSet.Paquetes, this.codigo.Text);
                    MessageBox.Show("El paquete ha sido cancelado correctamente");                     
                    break;
                case "PASAJES":                                        
                    int idPasaje = Convert.ToInt16(grillaPasaje.Rows[grillaPasaje.CurrentRow.Index].Cells[0].Value);                   
                    this.pasajesTableAdapter.pasajeCancelacion(idPasaje);
                    this.pasajesTableAdapter.FillBy(this.gD2C2015DataSet.Pasajes, this.codigo.Text);
                    MessageBox.Show("El pasaje ha sido cancelado correctamente");                     
                    break;                    
                default:
                    int id = Convert.ToInt16(grillaVenta.Rows[grillaVenta.CurrentRow.Index].Cells[0].Value);                    
                    this.ventasTableAdapter.ventaCancelacion(id);
                    this.ventasTableAdapter.FillBy(this.gD2C2015DataSet.Ventas, this.codigo.Text);
                    MessageBox.Show("La venta ha sido cancelada correctamente");                    
                    break;

            }                            
        }

        private void grillaPasaje_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.codigo.Text != "")
            {
                switch (Convert.ToString(comboBox1.SelectedItem))
               {
                  case "VENTAS":                    
                       // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Ventas' Puede moverla o quitarla según sea necesario.
                       this.ventasTableAdapter.FillBy(this.gD2C2015DataSet.Ventas, this.codigo.Text);
                       break;
                   case "PAQUETES":
                       // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Paquetes' Puede moverla o quitarla según sea necesario.
                       this.paquetesTableAdapter.FillBy(this.gD2C2015DataSet.Paquetes, this.codigo.Text);
                       break;
                   case "PASAJES":
                       // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Pasajes' Puede moverla o quitarla según sea necesario.                   
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
                /*switch (Convert.ToString(comboBox1.SelectedItem))
                {
                    case "VENTAS":                    
                        // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Ventas' Puede moverla o quitarla según sea necesario.
                        this.ventasTableAdapter.Fill(this.gD2C2015DataSet.Ventas);
                        break;
                    case "PAQUETES":
                        // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Paquetes' Puede moverla o quitarla según sea necesario.
                        this.paquetesTableAdapter.Fill(this.gD2C2015DataSet.Paquetes);
                        break;
                    case "PASAJES":
                        // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Pasajes' Puede moverla o quitarla según sea necesario.                   
                        this.pasajesTableAdapter.Fill(this.gD2C2015DataSet.Pasajes);
                        break;
                    default:
                        this.ventasTableAdapter.Fill(this.gD2C2015DataSet.Ventas);
                        break;
                }*/
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.codigo.Clear();            
            /*switch (Convert.ToString(comboBox1.SelectedItem))
            {
                case "VENTAS":
                    // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Ventas' Puede moverla o quitarla según sea necesario.
                    this.ventasTableAdapter.Fill(this.gD2C2015DataSet.Ventas);
                    break;
                case "PAQUETES":
                    // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Paquetes' Puede moverla o quitarla según sea necesario.
                    this.paquetesTableAdapter.Fill(this.gD2C2015DataSet.Paquetes);
                    break;
                case "PASAJES":
                    // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Pasajes' Puede moverla o quitarla según sea necesario.                   
                    this.pasajesTableAdapter.Fill(this.gD2C2015DataSet.Pasajes);
                    break;
                default:
                    this.ventasTableAdapter.Fill(this.gD2C2015DataSet.Ventas);
                    break;
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idVenta; 
            string codigo = null;     
            int devolucion;
            switch (Convert.ToString(comboBox1.SelectedItem))
            {
                case "VENTAS":                                       
                    //idVenta = Convert.ToInt16(grillaVenta.Rows[grillaVenta.CurrentRow.Index].Cells[0].Value);
                    //devolucion = Convert.ToInt16(grillaVenta.Rows[grillaVenta.CurrentRow.Index].Cells[0].Value);                  
                    MessageBox.Show("Para ver una cancelación debe seleccionar un paquete o un pasaje.");  
                    break;
                case "PAQUETES":
                    idVenta = Convert.ToInt32(grillaPaquete.Rows[grillaPaquete.CurrentRow.Index].Cells[2].Value);
                    codigo = Convert.ToString(grillaPaquete.Rows[grillaPaquete.CurrentRow.Index].Cells[3].Value);
                    devolucion = Convert.ToInt16(grillaPaquete.Rows[grillaPaquete.CurrentRow.Index].Cells[1].Value);
                    new VistaDevolucionForm(Convert.ToString(comboBox1.SelectedItem), idVenta, codigo, devolucion).ShowDialog();
                    break;
                case "PASAJES":
                    idVenta = Convert.ToInt32(grillaPasaje.Rows[grillaPasaje.CurrentRow.Index].Cells[3].Value);
                    codigo = Convert.ToString(grillaPasaje.Rows[grillaPasaje.CurrentRow.Index].Cells[5].Value);
                    devolucion = Convert.ToInt16(grillaPasaje.Rows[grillaPasaje.CurrentRow.Index].Cells[2].Value);
                    new VistaDevolucionForm(Convert.ToString(comboBox1.SelectedItem), idVenta, codigo, devolucion).ShowDialog();
                    break;                    
                default:
                    //idVenta = Convert.ToInt16(grillaVenta.Rows[grillaVenta.CurrentRow.Index].Cells[0].Value); 
                    MessageBox.Show("Para ver una cancelación debe seleccionar un paquete o un pasaje."); 
                    break;

            }                        
        }
    }
}
