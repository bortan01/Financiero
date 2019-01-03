using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
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
        public static String id_venta;
        public static String id_plan;
        public static double penitencia;
        private void button3_Click(object sender, EventArgs e)
        {
            if (cont_fila >0)
            {
                totalPrima = total * 0.25;
                txtPrima.Text = totalPrima.ToString();


                DataSet ds;
                 id_plan = comboCuota.SelectedValue.ToString();
                String sql = "select * from instituciones_financieras.plan_pago where instituciones_financieras.plan_pago.id_plan = '" + id_plan.ToString() + "'";

                ds = Utilidades.Ejecutar(sql);
                double toal1 = Convert.ToDouble(txtTotal.Text.ToString());
                double prima1 = Convert.ToDouble(txtPrima.Text.ToString());
                double porcentaje = (Convert.ToDouble(ds.Tables[0].Rows[0]["tasa"].ToString().Trim())) / 100;
                int meses = Convert.ToInt32(ds.Tables[0].Rows[0]["cuotas"].ToString().Trim());
                double penitencia = (toal1 - prima1);
                penitencia = (porcentaje * penitencia) + penitencia;
                penitencia = (penitencia / meses);
                txtCuota.Text = penitencia.ToString();
            }
            
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
                    id_plan = comboCuota.SelectedValue.ToString();
                    String sql = "select * from instituciones_financieras.plan_pago where instituciones_financieras.plan_pago.id_plan = '" + id_plan.ToString() + "'";

                    ds = Utilidades.Ejecutar(sql);
                    double toal1 = Convert.ToDouble(txtTotal.Text.ToString());
                    double prima1 = Convert.ToDouble(txtPrima.Text.ToString());
                    double porcentaje = (Convert.ToDouble(ds.Tables[0].Rows[0]["tasa"].ToString().Trim())) / 100;
                    int meses = Convert.ToInt32(ds.Tables[0].Rows[0]["cuotas"].ToString().Trim());
                    penitencia = (toal1 - prima1);
                    penitencia = (porcentaje * penitencia) + penitencia;
                    penitencia = (penitencia / meses);
                    txtCuota.Text = penitencia.ToString();
                }

                


             }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text.ToString() != ""  )
            {
                totalPrima = total * 0.25;
                txtPrima.Text = totalPrima.ToString();

                DataSet ds;
                String id_plan = comboCuota.SelectedValue.ToString();
                String sql = "select * from instituciones_financieras.plan_pago where instituciones_financieras.plan_pago.id_plan = '" + id_plan.ToString() + "'";

                ds = Utilidades.Ejecutar(sql);
                double toal1 = Convert.ToDouble(txtTotal.Text.ToString());
                double prima1 = Convert.ToDouble(txtPrima.Text.ToString());
                double porcentaje = (Convert.ToDouble(ds.Tables[0].Rows[0]["tasa"].ToString().Trim())) / 100;
                int meses = Convert.ToInt32(ds.Tables[0].Rows[0]["cuotas"].ToString().Trim());
                double penitencia = (toal1 - prima1);
                penitencia = (porcentaje * penitencia) + penitencia;
                penitencia = (penitencia / meses);
                txtCuota.Text = penitencia.ToString();
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (cont_fila > 0 && Convert.ToDecimal(txtTotal.Text.ToString().Trim()) > 0)
            {
                DataSet ds;
                String id_plan = comboCuota.SelectedValue.ToString();
                String sql = "select * from instituciones_financieras.plan_pago where instituciones_financieras.plan_pago.id_plan = '" + id_plan.ToString() + "'";
                ds = Utilidades.Ejecutar(sql);

                String Id_empleado = Login.codigo.ToString().Trim();
                String Prestamo_original = (txtTotal.Text.ToString());
                Prestamo_original = Prestamo_original.Replace(",",".");
                DateTime fecha = DateTime.Today;
                DateTime proximoPago = fecha.AddDays(30);

                double toal1 = Convert.ToDouble(txtTotal.Text.ToString());
                double prima1 = Convert.ToDouble(txtPrima.Text.ToString());
                double porcentaje = (Convert.ToDouble(ds.Tables[0].Rows[0]["tasa"].ToString().Trim())) / 100;
                int meses = Convert.ToInt32(ds.Tables[0].Rows[0]["cuotas"].ToString().Trim());
                double penitencia = (toal1 - prima1);
                String PrimerPago = prima1.ToString();
                PrimerPago = PrimerPago.Replace(",",".");

                penitencia = (porcentaje * penitencia) + penitencia;
                String SaldoActual = penitencia.ToString();
                SaldoActual = SaldoActual.Replace(",", ".");


                penitencia = (penitencia / meses);
                String cuotaX = penitencia.ToString();
                cuotaX = cuotaX.Replace(",",".");


                sql = "INSERT INTO instituciones_financieras.venta ( id_plan, id_empleado, prestamo_original, saldo_actual, mora_acumulada, intereses_acumulados, estado,tipo,fecha,proximo_pago,cuota)" +
                                                                    " VALUES ( '"+id_plan+"','"+Id_empleado+"','"+Prestamo_original+"','"+SaldoActual+"','0','0','NORMAL', 'CREDITO', '"+ fecha.ToString("yyyy-MM-dd") + "','"+ proximoPago.ToString("yyyy-MM-dd") + "', '"+cuotaX+"')";

                string msj = Utilidades.Registrar(sql);
               
                ///con este sql recuperamos el ultimo registro que hemos realizado 
                sql = "SELECT * FROM instituciones_financieras.venta WHERE id_venta = (SELECT MAX(id_venta) from instituciones_financieras.venta)";
                
                ds = Utilidades.Ejecutar(sql);
                id_venta = ds.Tables[0].Rows[0]["id_venta"].ToString().Trim();
                /// esto es para guardar la clave foranea en el pago  

                sql = "insert into instituciones_financieras.pago (id_venta,monto,fecha) values ('" + id_venta + "','" + PrimerPago + "','" + fecha.ToString("yyyy-MM-dd") + "')";
                msj = Utilidades.Registrar(sql);
                ///para guardar la foranea de venta y cliente 
                ///
                sql = "insert into instituciones_financieras.detalle_compra (id_venta,id_cliente) values ('" + id_venta + "','" + id_cliente + "')";
                msj = Utilidades.Registrar(sql);
                ////esta es para guardar el detalle venta, la relacion de producto y venta 

                foreach (DataGridViewRow Fila in dataCompra.Rows)
                {
                    String id_pro = Convert.ToString(Fila.Cells[0].Value);
                    int cant_pro = Convert.ToInt16(Fila.Cells[3].Value);
                    sql = "insert into instituciones_financieras.detalle_venta (id_venta,id_producto,cantidad) values ('" + id_venta + "','" + id_pro + "','" + cant_pro + "')";
                    msj = Utilidades.Registrar(sql);

                    ////para quitarle la cantidad al inventario 
                    sql = "UPDATE instituciones_financieras.inventario SET cantidad = cantidad-" + cant_pro + " WHERE id_producto ='" + id_pro + "'";
                    msj = Utilidades.Registrar(sql);
                }



                MessageBox.Show(msj);
                if (msj.Equals("Registro Completado"))
                {
                    FCredito re = new FCredito();
                    re.ShowDialog();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
          


            FCredito re = new FCredito("54");
                  re.ShowDialog();
        }
    }
}
