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
    public partial class mostrar_incobrables : Form
    {
        public mostrar_incobrables()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            String idVenta2 = txtVenta.Text.ToString().Trim();

            try
            {
                DataSet Ds;
                String sql = string.Format("SELECT instituciones_financieras.venta.id_venta,instituciones_financieras.cliente.nombre + ' '+instituciones_financieras.cliente.apellido as nombre, instituciones_financieras.venta.estado,instituciones_financieras.venta.cuota , instituciones_financieras.venta.mora_acumulada,instituciones_financieras.venta.intereses_acumulados, instituciones_financieras.venta.cuota + instituciones_financieras.venta.mora_acumulada + instituciones_financieras.venta.intereses_acumulados as deuda,instituciones_financieras.venta.proximo_pago,instituciones_financieras.venta.saldo_actual FROM instituciones_financieras.cliente InNER JOIN instituciones_financieras.detalle_compra ON instituciones_financieras.detalle_compra.id_cliente = instituciones_financieras.cliente.id_cliente INNER JOIN instituciones_financieras.venta ON instituciones_financieras.detalle_compra.id_venta = instituciones_financieras.venta.id_venta where (instituciones_financieras.venta.estado = 'NORMAL' OR instituciones_financieras.venta.estado = 'MORA') and venta.tipo = 'CREDITO' AND venta.id_venta = '" + idVenta2 + "'  ORDER BY id_venta DESC");
                Ds = Utilidades.Ejecutar(sql);
                dataGridView1.Columns[8].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView1.Columns[3].DefaultCellStyle.Format = "###,##0.00";
                dataGridView1.Columns[4].DefaultCellStyle.Format = "###,##0.00";
                dataGridView1.Columns[5].DefaultCellStyle.Format = "###,##0.00";
                dataGridView1.Columns[6].DefaultCellStyle.Format = "###,##0.00";

                foreach (DataRow Fila in Ds.Tables[0].Rows)
                {
                    dataGridView1.Rows.Add(Fila[0], Fila[1], Fila[2], Fila[3], Fila[4], Fila[5], Fila[6], Fila[8], Fila[7]);

                }
            }
            catch (Exception ers)
            {
                MessageBox.Show("VENTA NO ENCONTRADA");
            }
        }

        private void mostrar_incobrables_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }

        public void llenarTabla()
        {
            dataGridView1.Rows.Clear();
            DataSet Ds;
            String sql = string.Format("SELECT instituciones_financieras.venta.id_venta,instituciones_financieras.cliente.nombre + ' '+instituciones_financieras.cliente.apellido as nombre, instituciones_financieras.venta.estado,instituciones_financieras.venta.cuota , instituciones_financieras.venta.mora_acumulada,instituciones_financieras.venta.intereses_acumulados, instituciones_financieras.venta.cuota + instituciones_financieras.venta.mora_acumulada + instituciones_financieras.venta.intereses_acumulados as deuda,instituciones_financieras.venta.proximo_pago,instituciones_financieras.venta.saldo_actual FROM instituciones_financieras.cliente InNER JOIN instituciones_financieras.detalle_compra ON instituciones_financieras.detalle_compra.id_cliente = instituciones_financieras.cliente.id_cliente INNER JOIN instituciones_financieras.venta ON instituciones_financieras.detalle_compra.id_venta = instituciones_financieras.venta.id_venta where (instituciones_financieras.venta.estado = 'INCOBRABLE') and venta.tipo = 'CREDITO' ORDER BY id_venta DESC");
            Ds = Utilidades.Ejecutar(sql);
            dataGridView1.Columns[8].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns[3].DefaultCellStyle.Format = "###,##0.00";
            dataGridView1.Columns[4].DefaultCellStyle.Format = "###,##0.00";
            dataGridView1.Columns[5].DefaultCellStyle.Format = "###,##0.00";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "###,##0.00";

            foreach (DataRow Fila in Ds.Tables[0].Rows)
            {
                dataGridView1.Rows.Add(Fila[0], Fila[1], Fila[2], Fila[3], Fila[4], Fila[5], Fila[6], Fila[8], Fila[7]);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            llenarTabla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int filaSeleccionada = dataGridView1.CurrentRow.Index;
            int id_venta = Convert.ToInt32(dataGridView1.Rows[filaSeleccionada].Cells[0].Value);

            try
            {
                String sql = "UPDATE instituciones_financieras.venta SET estado='NORMAL' WHERE id_venta ='" + id_venta + "'";
                String msj = Utilidades.Registrar(sql);

                if (msj.Equals("Registro Completado"))
                {
                    MessageBox.Show("VENTA RESTAURADA");
                    dataGridView1.Rows.Clear();
                    //           VerificarFecha();
                    llenarTabla();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}
