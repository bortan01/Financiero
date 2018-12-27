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

namespace Institucion_Comercial.inventarios
{
    public partial class consultaCompras : Form
    {
        public consultaCompras()
        {
            InitializeComponent();
        }

        private void consultaCompras_Load(object sender, EventArgs e)
        {
            tablaProductos.DataSource = Buscar("").Tables[0];
            
            tablaProductos.Columns[0].HeaderText = "Código";
            tablaProductos.Columns[1].HeaderText = "Fecha de Compra";
            tablaProductos.Columns[2].HeaderText = "Total";
            //tablaProductos.Columns[3].HeaderText = "Proveedor";
            //tablaProductos.Columns[4].HeaderText = "Precio de Venta";
            //tablaProductos.Columns[5].HeaderText = "Existencias";
            //tablaProductos.Columns[6].HeaderText = "Minimo Permitido";
        }

        public DataSet Buscar(string campo)
        {
            DataSet ds = new DataSet();
            try
            {
                string cmd = "Select id_compra, fecha_compra, total from compras " +
                    "where id_compra like '%" + campo + "%' or fecha_compra like '%" + campo + "%' or total like '%" + campo + "%' order by fecha_compra desc";
                ds = Utilidades.Ejecutar(cmd);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            return ds;
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            tablaProductos.DataSource = Buscar(txtbuscar.Text.ToString()).Tables[0];
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (tablaProductos.Rows.Count != 0)
            {
                string idcompra = tablaProductos.CurrentRow.Cells[0].Value.ToString();
                //MessageBox.Show(idcompra);
                detalleCompra dc = new detalleCompra(idcompra);
                dc.DialogResult = DialogResult.OK;
                dc.ShowDialog();
               

            }
        }

        private void tablaProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (tablaProductos.SelectedRows.Count > 0)
            {
                btnseleccionar.Enabled = true;
            }
            else
            {
                btnseleccionar.Enabled = false;
            }
        }
    }
}
