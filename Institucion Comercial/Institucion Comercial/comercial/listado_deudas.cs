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
    public partial class listado_deudas : Form
    {
        public listado_deudas()
        {
            InitializeComponent();
        }


        public void llenarTabla() {
            // dataGridView1.DataSource = LlenarDAtaGV().Tables;
            DataSet Ds;
            String sql = string.Format("SELECT instituciones_financieras.venta.id_venta,instituciones_financieras.cliente.nombre + ' '+instituciones_financieras.cliente.apellido as nombre, instituciones_financieras.venta.estado,instituciones_financieras.venta.cuota , instituciones_financieras.venta.mora_acumulada,instituciones_financieras.venta.intereses_acumulados, instituciones_financieras.venta.cuota + instituciones_financieras.venta.mora_acumulada + instituciones_financieras.venta.intereses_acumulados as deuda,instituciones_financieras.venta.proximo_pago,instituciones_financieras.venta.saldo_actual FROM instituciones_financieras.cliente InNER JOIN instituciones_financieras.detalle_compra ON instituciones_financieras.detalle_compra.id_cliente = instituciones_financieras.cliente.id_cliente INNER JOIN instituciones_financieras.venta ON instituciones_financieras.detalle_compra.id_venta = instituciones_financieras.venta.id_venta where (instituciones_financieras.venta.estado = 'NORMAL' OR instituciones_financieras.venta.estado = 'MORA') and venta.tipo = 'CREDITO' ORDER BY id_venta DESC");
            Ds = Utilidades.Ejecutar(sql);
           // dataGridView1.Columns[8].DefaultCellStyle.Format = "dd/MM/yyyy";

            foreach (DataRow Fila in Ds.Tables[0].Rows)
            {
                dataGridView1.Rows.Add(Fila[0], Fila[1], Fila[2], Fila[3], Fila[4], Fila[5], Fila[6], Fila[8], Fila[7]);

            }
        }

        private void listado_deudas_Load(object sender, EventArgs e)
        {
            VerificarFecha();
            llenarTabla();

        }

        public void VerificarFecha() {
            String sql = "SELECT instituciones_financieras.venta.id_venta, instituciones_financieras.venta.proximo_pago,instituciones_financieras.cliente.id_cliente FROM instituciones_financieras.cliente InNER JOIN instituciones_financieras.detalle_compra ON instituciones_financieras.detalle_compra.id_cliente = instituciones_financieras.cliente.id_cliente INNER JOIN instituciones_financieras.venta ON instituciones_financieras.detalle_compra.id_venta = instituciones_financieras.venta.id_venta where instituciones_financieras.venta.estado = 'NORMAL' OR instituciones_financieras.venta.estado = 'MORA' ORDER BY id_venta DESC";
            DateTime hoy = DateTime.Today;
            DataSet Ds;
            Ds = Utilidades.Ejecutar(sql);
         
            foreach (DataRow Fila in Ds.Tables[0].Rows)
            {
                String id_venta = Convert.ToString(Fila["id_venta"].ToString().Trim());
                
                String FechaPago = Convert.ToString(Fila["proximo_pago"].ToString().Trim());
                DateTime a = DateTime.ParseExact(FechaPago, "dd/MM/yyyy H:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                 MessageBox.Show(a.ToString());
                //int Diferencia = DateTime.Compare(hoy, FechaPago);
                //if (Diferencia > 0)
                //{

                //    FechaPago = FechaPago.AddDays(30);
                //    sql = "UPDATE instituciones_financieras.venta set intereses_acumulados = intereses_acumulados + cuota,mora_acumulada = mora_acumulada + (cuota * 0.015), estado = 'MORA',proximo_pago = '" + FechaPago.ToString("yyyy-MM-dd") + "' WHERE instituciones_financieras.venta.id_venta = '" + id_venta + "'";
                //    Ds = Utilidades.Ejecutar(sql);
                //}
                //else {
                //     FechaPago = FechaPago.AddDays(30);
                //    sql = "UPDATE instituciones_financieras.venta set estado = 'MORA',proximo_pago = '" + FechaPago.ToString("yyyy-MM-dd") + "' WHERE instituciones_financieras.venta.id_venta = '" + id_venta + "'";
                //    Ds = Utilidades.Ejecutar(sql);
                //}

            }


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int filaSeleccionada = dataGridView1.CurrentRow.Index;
            //  MessageBox.Show("fila seleccionada " + filaSeleccionada);
            int id_venta = Convert.ToInt32(dataGridView1.Rows[filaSeleccionada].Cells[0].Value);
            Double total = Convert.ToDouble(dataGridView1.Rows[filaSeleccionada].Cells[5].Value);
            DateTime fecha = DateTime.Today;
            String hoy = fecha.ToString("yyyy-MM-dd");
            String monto = total.ToString();
            monto = monto.Replace(",", ".");


            try {

                String sql = "INSERT INTO instituciones_financieras.pago (id_venta, monto, fecha) VALUES ('" + id_venta + "', '" + monto + "', '" + hoy + "')";
                string msj = Utilidades.Registrar(sql);

                sql = "UPDATE instituciones_financieras.venta SET saldo_actual = saldo_actual-intereses_acumulados-mora_acumulada-cuota,intereses_acumulados=0,mora_acumulada=0  WHERE id_venta ='" + id_venta + "'";
                msj = Utilidades.Registrar(sql);

               

                if (msj.Equals("Registro Completado"))
                {
                    MessageBox.Show("PAGO REALIZADO EXITOSAMENTE");
                    dataGridView1.Rows.Clear();
                    llenarTabla();
                }
            }
            catch (Exception exq) {
                MessageBox.Show("ha ocurrido un problema " + exq.Message);
            }
        
        }
    }
}
