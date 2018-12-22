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

namespace Institucion_Comercial.proveedores
{
    public partial class consultaProveedores : Form
    {
        public consultaProveedores()
        {
            InitializeComponent();
        }

        private void consultaProveedores_Load(object sender, EventArgs e)
        {
            tablaProveedores.DataSource=Buscar("").Tables[0];
            tablaProveedores.Columns[0].HeaderText = "Código";
            tablaProveedores.Columns[1].HeaderText = "Nombre";
            tablaProveedores.Columns[2].HeaderText = "DUI";
            tablaProveedores.Columns[3].HeaderText = "Dirección";
            tablaProveedores.Columns[3].HeaderText = "Teléfono";
        }

        public DataSet Buscar(string campo) {
            DataSet ds = new DataSet();
            try
            {
                string cmd = "Select * from instituciones_financieras.proveedor " +
                    "where id_proveedor like '%" + campo + "%' or nombre like '%" + campo + "%' or dui like '%" + campo + "%' or telefono like '%" + campo + "%'";
                ds = Utilidades.Ejecutar(cmd);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            return ds;
        }

        private void txtbuscar_KeyUp(object sender, KeyEventArgs e)
        {
            tablaProveedores.DataSource = Buscar(txtbuscar.Text.Trim()).Tables[0];
        }
    }
}
