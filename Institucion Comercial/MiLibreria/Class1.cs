using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace MiLibreria
{
    public class Utilidades
    {
        public static DataTable LlenarCombos(String cmd)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=instituciones_financieras;Integrated Security=True");
            con.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd, con);
            dp.Fill(dt);
            con.Close();
            return dt;
        }

        public static String InsertarImagen(double total, DateTime fecha, System.IO.MemoryStream imagen)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=instituciones_financieras;Integrated Security=True");
            try
            {
                
                con.Open();

                SqlCommand comando = new SqlCommand("Insert into compras(total,fecha_compra,comprobante) " +
                    "values (@total, @fecha, @comprobante)", con);
                comando.Parameters.Add("@total", SqlDbType.Money);
                comando.Parameters.Add("@fecha", SqlDbType.Date);
                comando.Parameters.Add("@comprobante", SqlDbType.Image);

                comando.Parameters["@total"].Value = total;
                comando.Parameters["@fecha"].Value = fecha.Date;
                comando.Parameters["@comprobante"].Value = imagen.GetBuffer();
                comando.ExecuteNonQuery();
                return "Exito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                con.Close();
            }

        }

        public static DataSet Ejecutar(String cmd)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=instituciones_financieras;Integrated Security=True");
            con.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter dp = new SqlDataAdapter(cmd, con);
            dp.Fill(ds);
            con.Close();
            return ds;
        }
        public static SqlConnection obtenerConexion() {
            SqlConnection Conexion = new SqlConnection("Data Source=.;Initial Catalog=instituciones_financieras;Integrated Security=True");
            Conexion.Open();
            return Conexion;
        }


        public static string Registrar(String cmd)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=instituciones_financieras;Integrated Security=True");
            try
            {
                
                con.Open();
                SqlCommand comando = new SqlCommand(cmd, con);
                comando.ExecuteNonQuery();
                return "Registro Completado";
            }
            catch (Exception ex) {
                return ex.Message;
            }
            finally
            {
                con.Close();
            }

        }

        
    }
}
