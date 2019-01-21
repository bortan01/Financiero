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
    public partial class listDepre : Form
    {
        DateTime fecha;
        public listDepre()
        {
            InitializeComponent();
            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void listDepre_Load(object sender, EventArgs e)
        {
            tablaProductos.DataSource = Buscar0("").Tables[0];
            tablaProductos.Columns[0].HeaderText = "Codigo";
            tablaProductos.Columns[1].HeaderText = "Fecha";
            tablaProductos.Columns[2].HeaderText = "Costo";
            tablaProductos.Columns[3].HeaderText = "Numero de encargados";
            tablaProductos.Columns[4].HeaderText = "Numero de activos";
        }

        public DataSet Buscar(string campo)
        {
            DataSet ds = new DataSet();
            try
            {
                string cmd = "SELECT instituciones_financieras.mantenimiento.id_mantenimiento," +
"instituciones_financieras.mantenimiento.fecha, instituciones_financieras.mantenimiento.costo, " +
"Count(instituciones_financieras.encargado.nombre) AS encargado, " +
"Count(instituciones_financieras.activo_mant.idactivo_mant) AS activo " +
" FROM instituciones_financieras.mantenimiento " +
"INNER JOIN instituciones_financieras.mant_encar ON instituciones_financieras.mant_encar.idmant_encar = instituciones_financieras.mantenimiento.id_mantenimiento " +
"INNER JOIN instituciones_financieras.encargado ON instituciones_financieras.mant_encar.encarg_mant = instituciones_financieras.encargado.id_encargado " +
"INNER JOIN instituciones_financieras.activo_mant ON instituciones_financieras.activo_mant.mant_activo = instituciones_financieras.mantenimiento.id_mantenimiento " +
"WHERE instituciones_financieras.mantenimiento.fecha LIKE '"+campo+"' GROUP BY instituciones_financieras.mantenimiento.fecha,instituciones_financieras.mantenimiento.id_mantenimiento, " +
"instituciones_financieras.mantenimiento.costo";
                ds = Utilidades.Ejecutar(cmd);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            return ds;
        }

        public DataSet Buscar0(string campo)
        {
            DataSet ds = new DataSet();
            try
            {
                string cmd = "SELECT instituciones_financieras.mantenimiento.id_mantenimiento," +
"instituciones_financieras.mantenimiento.fecha, instituciones_financieras.mantenimiento.costo, " +
"Count(instituciones_financieras.encargado.nombre) AS encargado, " +
"Count(instituciones_financieras.activo_mant.idactivo_mant) AS activo " +
" FROM instituciones_financieras.mantenimiento " +
"INNER JOIN instituciones_financieras.mant_encar ON instituciones_financieras.mant_encar.idmant_encar = instituciones_financieras.mantenimiento.id_mantenimiento " +
"INNER JOIN instituciones_financieras.encargado ON instituciones_financieras.mant_encar.encarg_mant = instituciones_financieras.encargado.id_encargado " +
"INNER JOIN instituciones_financieras.activo_mant ON instituciones_financieras.activo_mant.mant_activo = instituciones_financieras.mantenimiento.id_mantenimiento " +
" GROUP BY instituciones_financieras.mantenimiento.fecha,instituciones_financieras.mantenimiento.id_mantenimiento, " +
"instituciones_financieras.mantenimiento.costo";
                ds = Utilidades.Ejecutar(cmd);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            return ds;
        }

        private void tablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            repoMant td = new repoMant(tablaProductos.Rows[tablaProductos.CurrentRow.Index].Cells[0].Value + "");
            td.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            fecha = (dateTimePicker1.Value);
            
            tablaProductos.DataSource = Buscar(fecha.ToString("yyyy-MM-dd") + "").Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            repoMant td = new repoMant(tablaProductos.Rows[tablaProductos.CurrentRow.Index].Cells[0].Value + "");
            td.ShowDialog();
        }
    }
}
