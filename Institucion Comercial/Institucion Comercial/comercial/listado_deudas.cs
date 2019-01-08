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

        public DataSet LlenarDAtaGV()
        {
            DataSet Ds;
            String sql = string.Format("SELECT instituciones_financieras.venta.id_venta,instituciones_financieras.cliente.nombre + ' '+instituciones_financieras.cliente.apellido as nombre, instituciones_financieras.venta.estado,instituciones_financieras.venta.cuota , instituciones_financieras.venta.mora_acumulada, instituciones_financieras.venta.cuota + instituciones_financieras.venta.mora_acumulada as deuda,instituciones_financieras.venta.proximo_pago FROM instituciones_financieras.cliente InNER JOIN instituciones_financieras.detalle_compra ON instituciones_financieras.detalle_compra.id_cliente = instituciones_financieras.cliente.id_cliente INNER JOIN instituciones_financieras.venta ON instituciones_financieras.detalle_compra.id_venta = instituciones_financieras.venta.id_venta where instituciones_financieras.venta.estado = 'NORMAL' OR instituciones_financieras.venta.estado = 'MORA' ORDER BY id_venta DESC");
            Ds = Utilidades.Ejecutar(sql);

            return Ds;

        }

        private void listado_deudas_Load(object sender, EventArgs e)
        {
            // dataGridView1.DataSource = LlenarDAtaGV().Tables;
            DataSet Ds;
            String sql = string.Format("SELECT instituciones_financieras.venta.id_venta,instituciones_financieras.cliente.nombre + ' '+instituciones_financieras.cliente.apellido as nombre, instituciones_financieras.venta.estado,instituciones_financieras.venta.cuota , instituciones_financieras.venta.mora_acumulada, instituciones_financieras.venta.cuota + instituciones_financieras.venta.mora_acumulada as deuda,instituciones_financieras.venta.proximo_pago FROM instituciones_financieras.cliente InNER JOIN instituciones_financieras.detalle_compra ON instituciones_financieras.detalle_compra.id_cliente = instituciones_financieras.cliente.id_cliente INNER JOIN instituciones_financieras.venta ON instituciones_financieras.detalle_compra.id_venta = instituciones_financieras.venta.id_venta where instituciones_financieras.venta.estado = 'NORMAL' OR instituciones_financieras.venta.estado = 'MORA' ORDER BY id_venta DESC");
            Ds = Utilidades.Ejecutar(sql);
            dataGridView1.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";

            foreach (DataRow  Fila in Ds.Tables[0].Rows) {
                dataGridView1.Rows.Add(Fila[0], Fila[1], Fila[2], Fila[3], Fila[4], Fila[5], Fila[6]);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int filaSeleccionada = dataGridView1.CurrentRow.Index;
            MessageBox.Show("fila seleccionada " + filaSeleccionada);
        }
    }
}
