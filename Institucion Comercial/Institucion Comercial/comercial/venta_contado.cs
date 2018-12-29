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

        public static String id_venta;

        private void button5_Click(object sender, EventArgs e)
        {

            if (cont_fila > 0 && Convert.ToDecimal(txtTotal.Text.ToString().Trim()) > 0 )
            {

                String Id_empleado = Login.codigo.ToString().Trim();
                String Prestamo_original = txtTotal.Text;
                DateTime fecha = DateTime.Today;
                String a = fecha.ToShortDateString();
               

                string sql = "INSERT INTO instituciones_financieras.venta ( id_plan, id_empleado, prestamo_original, saldo_actual, mora_acumulada, intereses_acumulados, estado,tipo,fecha)" +
                                                                   " VALUES ( '1', '" + Id_empleado + "', '" + Prestamo_original + "', '0', '0', '0', 'FINALIZADA', 'CONTADO', '"+fecha.ToString("yyyy-MM-dd")+"')";
               
                string msj = Utilidades.Registrar(sql);


                ///con este sql recuperamos el ultimo registro que hemos realizado 
                sql = "SELECT * FROM instituciones_financieras.venta WHERE id_venta = (SELECT MAX(id_venta) from instituciones_financieras.venta)";
                DataSet ds;
                ds = Utilidades.Ejecutar(sql);
                id_venta = ds.Tables[0].Rows[0]["id_venta"].ToString().Trim();
                /// esto es para guardar la clave foranea en el pago  

                sql = "insert into instituciones_financieras.pago (id_venta,monto,fecha) values ('"+id_venta+"','"+Prestamo_original+"','"+ fecha.ToString("yyyy-MM-dd") + "')";
                msj = Utilidades.Registrar(sql);
                ///para guardar la foranea de venta y cliente 
                ///
                sql = "insert into instituciones_financieras.detalle_compra (id_venta,id_cliente) values ('"+id_venta+"','"+id_cliente+"')";
                msj = Utilidades.Registrar(sql);
                ////esta es para guardar el detalle venta, la relacion de producto y venta 

                foreach (DataGridViewRow Fila in dataCompra.Rows)
                {
                    String id_pro = Convert.ToString(Fila.Cells[0].Value);
                    int cant_pro = Convert.ToInt16(Fila.Cells[3].Value);
                    sql = "insert into instituciones_financieras.detalle_venta (id_venta,id_producto,cantidad) values ('"+id_venta+"','"+id_pro+"','"+cant_pro+"')";
                    msj = Utilidades.Registrar(sql);

                    ////para quitarle la cantidad al inventario 
                    sql = "UPDATE instituciones_financieras.inventario SET cantidad = cantidad-"+cant_pro+ " WHERE id_producto ='"+id_pro+"'";
                    msj = Utilidades.Registrar(sql);
                }



                MessageBox.Show(msj);
                if (msj.Equals("Registro Completado"))
                {

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
