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

namespace Institucion_Comercial.Clientes
{
    public partial class consultarClientes : Form
    {
        public consultarClientes()
        {
            InitializeComponent();
            tablaProductos.DataSource = Buscar("").Tables[0];
            tablaProductos.Columns[0].HeaderText = "Código";
            tablaProductos.Columns[1].HeaderText = "Nombre";
            tablaProductos.Columns[2].HeaderText = "Apellido";
            tablaProductos.Columns[3].HeaderText = "Direccion";
            tablaProductos.Columns[4].HeaderText = "Telefono";
            tablaProductos.Columns[5].HeaderText = "DUI";

        }

        public DataSet Buscar(string campo)
        {
            DataSet ds = new DataSet();
            try
            {
                string cmd = "Select id_cliente, nombre, apellido, direccion, telefono, dui from instituciones_financieras.cliente " +
                    "where id_cliente like '%" + campo + "%' or nombre like '%" + campo + "%' or apellido like '%" + campo + "%' or direccion like '%" + campo + "%' or telefono like '%" + campo + "%' or dui like '%" + campo + "%'";
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

        private void btndetalles_Click(object sender, EventArgs e)
        {
            string id = tablaProductos.CurrentRow.Cells[0].Value.ToString();
            detalleCliente dc = new detalleCliente(id);
            dc.ShowDialog();
        }
    }
}
