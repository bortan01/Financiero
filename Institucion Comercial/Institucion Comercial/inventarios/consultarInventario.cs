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
    public partial class consultarInventario : Form
    {
        public consultarInventario()
        {
            InitializeComponent();
            colore();

            tablaProductos.DataSource = Buscar("").Tables[0];
            tablaProductos.Columns[0].HeaderText = "Código";
            tablaProductos.Columns[1].HeaderText = "Nombre";
            tablaProductos.Columns[2].HeaderText = "Descripcion";
            tablaProductos.Columns[3].HeaderText = "Proveedor";
            tablaProductos.Columns[4].HeaderText = "Precio de Venta";
            tablaProductos.Columns[5].HeaderText = "Existencias";
            tablaProductos.Columns[6].HeaderText = "Minimo Permitido";
            
            colore();
        }

        private void consultarInventario_Load(object sender, EventArgs e)
        {
            

        }

        public void colore()
        {
            foreach (DataGridViewRow fila in tablaProductos.Rows)
            {
                if (Convert.ToInt32(fila.Cells[5].Value.ToString())< Convert.ToInt32(fila.Cells[6].Value.ToString()))
                {
                    fila.DefaultCellStyle.BackColor = Color.LightPink;
                    fila.DefaultCellStyle.ForeColor = Color.DarkRed;
                }
                if (Convert.ToInt32(fila.Cells[5].Value.ToString()) > Convert.ToInt32(fila.Cells[6].Value.ToString()))
                {
                    fila.DefaultCellStyle.BackColor = Color.LightGreen;
                    fila.DefaultCellStyle.ForeColor = Color.DarkGreen;
                }
                if (Convert.ToInt32(fila.Cells[5].Value.ToString()) == Convert.ToInt32(fila.Cells[6].Value.ToString()))
                {
                    fila.DefaultCellStyle.BackColor = Color.LightYellow;
                    fila.DefaultCellStyle.ForeColor = Color.DarkOrange;
                }
            }
        }

        public DataSet Buscar(string campo)
        {
            DataSet ds = new DataSet();
            try
            {
                string cmd = "Select prod.id_producto, prod.nombre, prod.descripcion, prov.nombre, prod.precio_venta, inv.cantidad, prod.minimo from instituciones_financieras.producto as prod, instituciones_financieras.proveedor as prov, instituciones_financieras.inventario as inv " +
                    "where (prod.id_producto like '%" + campo + "%' or prod.nombre like '%" + campo + "%' or prod.descripcion like '%" + campo + "%' or prod.precio_compra like '%" + campo + "%' or prod.precio_venta like '%" + campo + "%' or prov.nombre like '%" + campo + "%') and prod.id_producto = inv.id_producto order by inv.cantidad asc";
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
            colore();
        }
    }
}
