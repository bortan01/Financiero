using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiLibreria;

namespace Institucion_Comercial.comercial
{
    public partial class venta_contado : Venta
    {
        public venta_contado()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtTotal.Text.ToString().Trim()) > 0)
            {

                String Id_empleado = Login.codigo.ToString().Trim();
                String Prestamo_original = txtTotal.Text;
                DateTime fecha = DateTime.Today;
                String a = fecha.ToShortDateString();
                MessageBox.Show(a);

                string sql = "INSERT INTO instituciones_financieras.venta ( id_plan, id_empleado, prestamo_original, saldo_actual, mora_acumulada, intereses_acumulados, estado,tipo,fecha)" +
                                                                   " VALUES ( '1', '" + Id_empleado + "', '" + Prestamo_original + "', '0', '0', '0', 'FINALIZADA', 'CONTADO', '"+fecha.ToString("yyyy-MM-dd")+"')";
               
                string msj = Utilidades.Registrar(sql);
                MessageBox.Show(msj);
                if (msj.Equals("Registro Completado"))
                {

                }
            }
        }
    }
}
