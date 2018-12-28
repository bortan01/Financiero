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
    public partial class venta_credito : Venta
    {
        public venta_credito()
        {
            InitializeComponent();
        }
        public static double totalPrima;
        private void button3_Click(object sender, EventArgs e)
        {
            if (cont_fila >0)
            {
                totalPrima = total * 0.25;
                txtPrima.Text = totalPrima.ToString();

            }
            DataSet ds;
            String id_plan = comboCuota.SelectedValue.ToString();
            String sql = "select * from instituciones_financieras.plan_pago where instituciones_financieras.plan_pago.id_plan = '" + id_plan.ToString() + "'";

            ds = Utilidades.Ejecutar(sql);
            double toal1 = Convert.ToDouble(txtTotal.Text.ToString());
            double prima1 = Convert.ToDouble(txtPrima.Text.ToString());
            double porcentaje = (Convert.ToDouble(ds.Tables[0].Rows[0]["tasa"].ToString().Trim())) / 100;
            int meses = Convert.ToInt32(ds.Tables[0].Rows[0]["cuotas"].ToString().Trim());
            double penitencia = (toal1 - prima1);
            MessageBox.Show(penitencia.ToString());

            penitencia = (porcentaje*penitencia) +penitencia;
            MessageBox.Show(penitencia.ToString());

            penitencia = (penitencia / meses);
            MessageBox.Show(penitencia.ToString());

            txtCuota.Text = penitencia.ToString();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void venta_credito_Load(object sender, EventArgs e)
        {

            comboCuota.DataSource = controladorPlan.ObtenerPlan();
            comboCuota.DisplayMember= "texto";
            comboCuota.ValueMember = "id_plan";
        }

        private void comboCuota_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboCuota.SelectedValue.ToString() != "Institucion_Comercial.comercial.plan")
            {
              

                if (txtTotal.Text.ToString() !="")
                {
                    DataSet ds;
                    String id_plan = comboCuota.SelectedValue.ToString();
                    String sql = "select * from instituciones_financieras.plan_pago where instituciones_financieras.plan_pago.id_plan = '" + id_plan.ToString() + "'";

                    ds = Utilidades.Ejecutar(sql);
                    double toal1 = Convert.ToDouble(txtTotal.Text.ToString());
                    double prima1 = Convert.ToDouble(txtPrima.Text.ToString());
                    double porcentaje = (Convert.ToDouble(ds.Tables[0].Rows[0]["tasa"].ToString().Trim())) / 100;
                    int meses = Convert.ToInt32(ds.Tables[0].Rows[0]["cuotas"].ToString().Trim());
                    double penitencia = (toal1 - prima1);
                    penitencia *= porcentaje;
                    penitencia = (penitencia / meses);
                    txtCuota.Text = penitencia.ToString();
                }

                


             }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
