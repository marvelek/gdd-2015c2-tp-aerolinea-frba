using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;

namespace AerolineaFrba
{
    class ConexionSQL
    {


        public static string schema = "MILANESA";
        /// <summary>
        /// Realiza la conexion a la base de datos.
        /// </summary>
        /// <param name="cn"></param>
        /// <param name="cm"></param>

        private static SqlConnection cn;
        public static bool conectarABaseDeDatos()
        {
            try
            {
                cn = new SqlConnection("Data Source=(local)" + "\\" + "SQLSERVER2012;Initial Catalog=GD2C2015;User ID=gd;Password=gd2015;");
                cn.Open();
                return true;
            }
            catch
            {
                MessageBox.Show("No se puede conectar a la base de datos");
                return false;
            }

        }

        public static SqlConnection getCn()
        {
            return cn;
        }

        public static string getSchema()
        {
            return schema;
        }

        /// <summary>
        /// Realiza una consulta.
        /// </summary>
        /// <param name="procedure">Consulta.</param>
        /// <returns></returns>
        public static DataTable getTablaPorConsulta(string consulta)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cn = getCn();
                SqlCommand cmd = new SqlCommand(consulta, cn);
                cmd.CommandTimeout = 2000;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable obtenerTablaSegunProcedure(string procedure, List<string> args, params object[] values)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cn = getCn();
                SqlCommand cmd = new SqlCommand(procedure, cn);
                cmd.CommandTimeout = 1000;
                cmd.CommandType = CommandType.StoredProcedure;
                if (_validateArgumentsAndParameters(args, values))
                {
                    _loadSqlCommand(args, values, cmd);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static bool executeProcedure(string procedure, List<string> args, params object[] values)
        {
            try
            {
                SqlDataReader dr;
                SqlConnection cn = getCn();
                SqlCommand cmd = new SqlCommand(procedure, cn);
                cmd.CommandTimeout = 1000;
                cmd.CommandType = CommandType.StoredProcedure;
                if (_validateArgumentsAndParameters(args, values))
                {
                    _loadSqlCommand(args, values, cmd);
                }
                dr = cmd.ExecuteReader();
                dr.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static int executeProcedureWithReturnValue(string procedure, List<string> args, params object[] values)
        {
            try
            {
                SqlConnection cn = getCn();
                SqlCommand cmd = new SqlCommand(procedure, cn);
                cmd.CommandTimeout = 1000;
                cmd.CommandType = CommandType.StoredProcedure;
                if (_validateArgumentsAndParameters(args, values))
                {
                    _loadSqlCommand(args, values, cmd);
                }
                cmd.Parameters.Add("@retorno", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                return (int)cmd.Parameters["@retorno"].Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

        private static bool _validateArgumentsAndParameters(List<string> args, params object[] values)
        {
            if (args != null && values != null)
            {
                if (args.Count != values.Length)
                {
                    throw new ApplicationException();
                }
                return true;
            }
            return false;
        }
        private static void _loadSqlCommand(List<string> args, object[] values, SqlCommand cm)
        {
            for (int i = 0; i < args.Count; i++)
            {
                cm.Parameters.AddWithValue(args[i], values[i]);
            }
        }
    }
}
