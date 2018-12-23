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

        public static string Registrar(String cmd)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=instituciones_financieras;Integrated Security=True");
                con.Open();
                SqlCommand comando = new SqlCommand(cmd, con);
                comando.ExecuteNonQuery();
                return "Registro Completado";
            }
            catch (Exception ex) {
                return ex.Message;
            }

        }

        
    }
}
