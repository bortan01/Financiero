using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                plan.tasa = _reader.GetFloat(1);
                plan.cuota = _reader.GetInt32(2);
                _lista.Add(plan);
            }
            return _lista;
        }
    }
}