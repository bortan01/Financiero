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
    public partial class tablaDepre : Form
    {
        String cod = "";
        public tablaDepre()
        {
            InitializeComponent();
            
        }

        public  tablaDepre(String cod)
        {
            InitializeComponent();
            this.cod = cod;
            llenarDatos();
        }

        public void llenarDatos( )
        {
            string cmd = String.Format("SELECT "+
"instituciones_financieras.activo.id_activo AS cod, " +
"instituciones_financieras.tipo_activo.nombre + ' - ' + instituciones_financieras.clasificacion.nombre AS tipo, " +
"instituciones_financieras.departamento.nombre AS depto, " +
"instituciones_financieras.sucursal.nombre AS sucu, " +
"instituciones_financieras.estado.nombre, " +
"instituciones_financieras.empleado.nombre + ' ' + instituciones_financieras.empleado.apellido AS enca, " +
"instituciones_financieras.activo.fecha_adquisicion AS fecha, " +
"instituciones_financieras.activo.estado AS estado, " +
"instituciones_financieras.clasificacion.tiempo_depreciacion AS dpre , "+
"instituciones_financieras.activo.correlativo as costo " +
"FROM " +
"instituciones_financieras.activo " +
"INNER JOIN instituciones_financieras.tipo_activo ON instituciones_financieras.activo.id_tipo = instituciones_financieras.tipo_activo.id_tipo " +
"INNER JOIN instituciones_financieras.departamento ON instituciones_financieras.activo.id_depto = instituciones_financieras.departamento.id_departamento " +
"INNER JOIN instituciones_financieras.sucursal ON instituciones_financieras.departamento.id_sucursal = instituciones_financieras.sucursal.id_sucursal " +
"INNER JOIN instituciones_financieras.estado ON instituciones_financieras.activo.id_estado = instituciones_financieras.estado.id_estado " +
"INNER JOIN instituciones_financieras.empleado ON instituciones_financieras.activo.id_usuario = instituciones_financieras.empleado.id_empleado " +
"INNER JOIN instituciones_financieras.clasificacion ON instituciones_financieras.tipo_activo.id_clasificacion = instituciones_financieras.clasificacion.id_clasificacion " +
"WHERE " +
"instituciones_financieras.activo.id_activo = '"+cod+"'");
            DataSet ds = Utilidades.Ejecutar(cmd);
            int tiempo = Convert.ToInt32(ds.Tables[0].Rows[0]["dpre"]);
            double costo = Convert.ToDouble(ds.Tables[0].Rows[0]["costo"].ToString());
            double depre = costo / tiempo;
            double depreAcum = depre;
            double libro = costo - depre;
            textBoxcodigo.Text = ds.Tables[0].Rows[0][0].ToString();
            textBoxTipo.Text = ds.Tables[0].Rows[0][1].ToString();
            textBoxSucu.Text = ds.Tables[0].Rows[0][3].ToString();
            textBoxDepartamento.Text = ds.Tables[0].Rows[0][2].ToString();
            textBoxEncargado.Text = ds.Tables[0].Rows[0][5].ToString();
            textBoxCosto.Text = "$ "+ds.Tables[0].Rows[0][9].ToString();
            textBoxEstado.Text = ds.Tables[0].Rows[0][7].ToString();
            dateTimePicker1.Value = Convert.ToDateTime( ds.Tables[0].Rows[0]["fecha"]);
            int anio = dateTimePicker1.Value.Year;

            for (int i=0; i<tiempo; i++)
            {
                tblcompras.Rows.Insert(tblcompras.RowCount, anio, depre, depreAcum, libro);
                anio++;
                depreAcum = depreAcum + depre;
                libro = libro - depre;
            }
           


            //MessageBox.Show("" + ds.Tables[0].Rows[0][0].ToString());
            //codigo = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString().Trim());
        }

        private void tablaDepre_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
