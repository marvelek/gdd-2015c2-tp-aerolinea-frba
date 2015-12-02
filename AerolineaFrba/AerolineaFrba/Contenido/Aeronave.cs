using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AerolineaFrba.GD2C2015DataSetTableAdapters;
using AerolineaFrba.Contenido;

namespace AerolineaFrba.Contenido
{
   public class Aeronave
    {
       private AeronavesTableAdapter aeronavesTableAdapter = new AeronavesTableAdapter();
       private GD2C2015DataSet dataSet = new GD2C2015DataSet();
       private GD2C2015DataSet.AeronavesRow aeronaveRow;

       private int id;
       private bool activo;
       private string fabricante;
       private DateTime fecha_alta;
       private DateTime fecha_baja_def;
       private DateTime fecha_fs;
       private DateTime fecha_reinicio;
       private decimal kg_disponibles;
       private string matricula;
       private string modelo;
       private int Id 
       
       {
           get {
               return id;
           }
           set
           {
               id = value;
           }

       }

       public Aeronave buscarByMatricula(String matricula) {
           try
           {
               Aeronave aer;
               this.aeronavesTableAdapter.Fill(this.dataSet.Aeronaves);
               GD2C2015DataSet.AeronavesDataTable result = aeronavesTableAdapter.GetDataBy1(matricula);
            
            if (result.Count != 0)
            {
                aeronaveRow = result.First();
               aer = new Aeronave();
               aer.Id = aeronaveRow.aer_id;
               aer.activo = aeronaveRow.aer_activo;
               aer.fabricante= aeronaveRow.aer_fabricante;
               aer.fecha_alta=aeronaveRow.aer_fecha_alta;
               aer.fecha_baja_def=aeronaveRow.aer_fecha_baja_definitiva;
               aer.fecha_fs=aeronaveRow.aer_fecha_fuera_servicio;
               aer.fecha_reinicio=aeronaveRow.aer_fecha_reinicio_servicio;
               aer.kg_disponibles=aeronaveRow.aer_kg_disponibles;
               aer.matricula=aeronaveRow.aer_matricula;
               aer.modelo=aeronaveRow.aer_modelo;
               
              
               return aer;
           }
           else
           {
               return null;
           }
           }
           catch (Exception e)
           {
               e.ToString();
           }
           return null;
       }
    }
}
