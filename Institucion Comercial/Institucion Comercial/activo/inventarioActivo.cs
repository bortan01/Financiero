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

namespace Institucion_Comercial.activo
{
    public partial class inventarioActivo : Form
    {
        public inventarioActivo()
        {
            InitializeComponent();
        }

        private void inventarioActivo_Load(object sender, EventArgs e)
        {
            tablaProductos.DataSource = Buscar("").Tables[0];
            tablaProductos.Columns[0].HeaderText = "Código";
            tablaProductos.Columns[1].HeaderText = "Tipo";
            tablaProductos.Columns[2].HeaderText = "Departamento";
            tablaProductos.Columns[3].HeaderText = "Sucursal";
            tablaProductos.Columns[3].HeaderText = "Estado";
        }

        public DataSet Buscar(string campo)
        {
            DataSet ds = new DataSet();
            try
            {
                string cmd = "SELECT instituciones_financieras.activo.id_activo, "+
"instituciones_financieras.tipo_activo.nombre, "+
"instituciones_financieras.departamento.nombre, "+
"instituciones_financieras.sucursal.nombre, "+
"instituciones_financieras.estado.nombre "+
"FROM "+
"instituciones_financieras.activo "+
"INNER JOIN instituciones_financieras.tipo_activo ON instituciones_financieras.activo.id_tipo = instituciones_financieras.tipo_activo.id_tipo "+
"INNER JOIN instituciones_financieras.departamento ON instituciones_financieras.activo.id_depto = instituciones_financieras.departamento.id_departamento "+
"INNER JOIN instituciones_financieras.sucursal ON instituciones_financieras.departamento.id_sucursal = instituciones_financieras.sucursal.id_sucursal "+
"INNER JOIN instituciones_financieras.estado ON instituciones_financieras.activo.id_estado = instituciones_financieras.estado.id_estado "+
"WHERE "+
"instituciones_financieras.activo.id_activo LIKE '%"+campo+"'";
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
    }
}
