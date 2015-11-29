﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.Contenido;
using AerolineaFrba.GD2C2015DataSetTableAdapters;

namespace AerolineaFrba.Abm_Ruta
{
    public partial class CargarRutaForm : Form
    {
        Ruta ruta = null;
        RutasTableAdapter rutasTableAdapter = new RutasTableAdapter();
        Tipos_Servicio_RutasTableAdapter tipos_servicio_RutasTableAdapter = new Tipos_Servicio_RutasTableAdapter();
        GD2C2015DataSet dataSet = new GD2C2015DataSet();

        public CargarRutaForm(Ruta ruta)
        {
            InitializeComponent();

            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Rutas' Puede moverla o quitarla según sea necesario.
            this.rutasTableAdapter1.Fill(this.gD2C2015DataSet.Rutas);
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Tipos_Servicio' Puede moverla o quitarla según sea necesario.
            this.tipos_ServicioTableAdapter.Fill(this.gD2C2015DataSet.Tipos_Servicio);
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Ciudades' Puede moverla o quitarla según sea necesario.
            this.ciudadesTableAdapter.Fill(this.gD2C2015DataSet.Ciudades);

            this.ciudadDestino.Refresh();
            this.ciudadOrigen.Refresh();

            List<Tipo_Servicio> tipos_servicios = Tipo_Servicio.getTipos_Servicio();
            foreach (Tipo_Servicio f in tipos_servicios)
            {
                this.checkedListBox1.Items.Insert(f.Id - 1, f.Descripcion);
            }
            this.checkedListBox1.Refresh();

            if (ruta != null)
            {
                this.ruta = ruta;
                this.activo.Checked = ruta.Activo;
                this.codigo.Text = ruta.Codigo.ToString();                              
                this.precioKg.Text = ruta.PrecioKg.ToString();
                this.precioBase.Text = ruta.PrecioBase.ToString();                            
                this.ciudadOrigen.SelectedValue = ruta.CiudadOrigen;
                this.ciudadDestino.SelectedValue = ruta.CiudadDestino;
                
                List<Tipo_Servicio> tiposDeServicio = ruta.buscarTiposServicio(ruta.Id);
                foreach (Tipo_Servicio ts in tiposDeServicio)
                {                    
                        this.checkedListBox1.SetItemChecked(ts.Id - 1, true);               
                }

            }
            else
            {
                this.activo.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CargarRutaForm_Load(object sender, EventArgs e)
        {
            /*// TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Rutas' Puede moverla o quitarla según sea necesario.
            this.rutasTableAdapter1.Fill(this.gD2C2015DataSet.Rutas);
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Tipos_Servicio' Puede moverla o quitarla según sea necesario.
            this.tipos_ServicioTableAdapter.Fill(this.gD2C2015DataSet.Tipos_Servicio);
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Ciudades' Puede moverla o quitarla según sea necesario.
            this.ciudadesTableAdapter.Fill(this.gD2C2015DataSet.Ciudades);*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.valido())
            {
                if (ruta != null)
                {                    
                    // update
                    this.rutasTableAdapter.rutaModificar(Convert.ToInt16(this.ciudadDestino.SelectedValue), Convert.ToInt16(this.ciudadOrigen.SelectedValue), Convert.ToDecimal(this.codigo.Text), Convert.ToDecimal(this.precioKg.Text), Convert.ToDecimal(this.precioBase.Text), Convert.ToBoolean(this.activo.Checked), this.ruta.Id);
                    this.tipos_servicio_RutasTableAdapter.tipos_Servicio_RutasBorrar(this.ruta.Id);
                }
                else
                {
                    // insert
                    this.ruta = new Ruta();
                    this.ruta.Id = Convert.ToInt16(this.rutasTableAdapter.rutaInsertar(Convert.ToInt16(this.ciudadOrigen.Text), Convert.ToInt16(this.ciudadDestino.Text), Convert.ToDecimal(this.codigo.Text), Convert.ToDecimal(this.precioKg.Text), Convert.ToDecimal(this.precioBase.Text)));
                }

                foreach (object itemChecked in this.checkedListBox1.CheckedItems)
                {
                    int tipo_servicio_id = this.checkedListBox1.Items.IndexOf(itemChecked) + 1;
                    if (tipo_servicio_id != 0)
                    {
                        this.tipos_servicio_RutasTableAdapter.tipo_Servicio_RutaInsertar(tipo_servicio_id, this.ruta.Id);
                    }
                }
                this.rutasTableAdapter.Fill(this.dataSet.Rutas);
                this.tipos_servicio_RutasTableAdapter.Fill(this.dataSet.Tipos_Servicio_Rutas);

                MessageBox.Show("La ruta ha sido guardado correctamente");
                this.Close();
            }
            else
            {
                return;
            }
        }

        private bool valido()
        {
            Utiles validador = new Utiles();
            string error = null;

            if (this.codigo.Text == "")
            {
                error = "El código de ruta no pueder ser nulo.\n";
            }
            if (this.checkedListBox1.CheckedItems.Count < 1)
            {
                error = error + "Debe seleccionar por lo menos un tipo de servicio.\n";
            }

            if (this.ciudadOrigen.SelectedValue == "")
            {
                error = error + "Debe seleccionar una ciudad de origen.\n";
            }

            if (this.ciudadDestino.SelectedValue == "")
            {
                error = error + "Debe seleccionar una ciudad de destino.\n";
            }

            if (this.precioKg.Text == "")
            {
                error = error + "Debe ingresar un precio por Kg.\n";
            }

            if (this.precioBase.Text == "")
            {
                error = error + "Debe ingresar un precio base.\n";
            }

            if (error != null)
            {
                MessageBox.Show(error);
                return false;
            }
            return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ciudadOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fKRutasciudador6B79F03DBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}