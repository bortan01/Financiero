using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiLibreria;

namespace Institucion_Comercial.comercial
{
    class controladorPlan
    {
        public static List<plan> ObtenerPlan()
        {
            List<plan> _lista = new List<plan>();

            SqlConnection conexion = Utilidades.obtenerConexion();

            SqlCommand _comando = new SqlCommand("select * from instituciones_financieras.plan_pago", conexion);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                plan plan = new plan();
               plan.id_plan = _reader.GetInt32(0);
            //    MessageBox.Show(plan.id_plan.ToString());
                double tasa = _reader.GetFloat(1);
                tasa = Math.Round(tasa, 2);
                double cuotas = _reader.GetInt32(2);

                plan.texto = cuotas.ToString() + " meses, tasa de " + tasa.ToString() + "%";
                _lista.Add(plan);
            }
            return _lista;
        }
    }
}