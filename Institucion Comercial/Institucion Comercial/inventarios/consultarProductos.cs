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
    public partial class consultarProductos : Form
    {
        public consultarProductos()
        {
            InitializeComponent();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            tablaProductos.DataSource = Buscar(txtbuscar.Text.ToString()).Tables[0];
        }

        private void consultarProductos_Load(object sender, EventArgs e)
        {
            tablaProductos.DataSource = Buscar("").Tables[0];
            tablaProductos.Columns[0].HeaderText = "Código";
            tablaProductos.Columns[1].HeaderText = "Nombre";
            tablaProductos.Columns[2].HeaderText = "Descripcion";
            tablaProductos.Columns[3].HeaderText = "Proveedor";
            tablaProductos.Columns[3].HeaderText = "Precio";
        }

        public DataSet Buscar(string campo)
        {
            DataSet ds = new DataSet();
            try
            {
                string cmd = "Select prod.id_producto, prod.nombre, prod.descripcion, prov.nombre, prod.precio_compra from instituciones_financieras.producto as prod, instituciones_financieras.proveedor as prov " +
                    "where prod.id_producto like '%" + campo + "%' or prod.nombre like '%" + campo + "%' or prod.descripcion like '%" + campo + "%' or prod.precio_compra like '%" + campo + "%' or prod.precio_venta like '%" + campo + "%' or prov.nombre like '%" + campo + "%'";
                ds = Utilidades.Ejecutar(cmd);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            return ds;
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (tablaProductos.Rows.Count==0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
