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
    public partial class mod : Form
    {
        String cod;
        int tipo =0;
        public mod(String cod)
        {
            InitializeComponent();
            this.cod = cod;
            llenarDatos(cod);
        }

        private void mod_Load(object sender, EventArgs e)
        {

        }
        public void llenarDatos(String co)
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
"instituciones_financieras.clasificacion.tiempo_depreciacion AS dpre, " +
"instituciones_financieras.activo.correlativo AS costo, " +
"instituciones_financieras.activo.descripcion as des, " +
"instituciones_financieras.proveedor.nombre as prov " +
"FROM " +
"instituciones_financieras.activo " +
"INNER JOIN instituciones_financieras.tipo_activo ON instituciones_financieras.activo.id_tipo = instituciones_financieras.tipo_activo.id_tipo " +
"INNER JOIN instituciones_financieras.departamento ON instituciones_financieras.activo.id_depto = instituciones_financieras.departamento.id_departamento " +
"INNER JOIN instituciones_financieras.sucursal ON instituciones_financieras.departamento.id_sucursal = instituciones_financieras.sucursal.id_sucursal " +
"INNER JOIN instituciones_financieras.estado ON instituciones_financieras.activo.id_estado = instituciones_financieras.estado.id_estado " +
"INNER JOIN instituciones_financieras.empleado ON instituciones_financieras.activo.id_usuario = instituciones_financieras.empleado.id_empleado " +
"INNER JOIN instituciones_financieras.clasificacion ON instituciones_financieras.tipo_activo.id_clasificacion = instituciones_financieras.clasificacion.id_clasificacion " +
"INNER JOIN instituciones_financieras.proveedor ON instituciones_financieras.activo.id_proveedor = instituciones_financieras.proveedor.id_proveedor " +
"WHERE " +
"instituciones_financieras.activo.id_activo = '"+co+"' ");
            DataSet ds = Utilidades.Ejecutar(cmd);
           
            textBoxCodigo.Text = ds.Tables[0].Rows[0][0].ToString();
            textBoxTipo.Text = ds.Tables[0].Rows[0][1].ToString();
            textBoxSucu.Text = ds.Tables[0].Rows[0][3].ToString();
            textBoxDepto.Text = ds.Tables[0].Rows[0][2].ToString();
            textBoxEnca.Text = ds.Tables[0].Rows[0][5].ToString();
            textBoxPrecio.Text = "$ " + ds.Tables[0].Rows[0][9].ToString();
            textBoxEstado.Text = ds.Tables[0].Rows[0][7].ToString();
            textBoxProv.Text = ds.Tables[0].Rows[0]["prov"].ToString();
          
            txtdireccion.Text = ds.Tables[0].Rows[0]["des"].ToString();
            dateTimePicker1.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["fecha"]);

            int anio = dateTimePicker1.Value.Year;


            //MessageBox.Show("" + ds.Tables[0].Rows[0][0].ToString());
            //codigo = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString().Trim());
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
          
            string sql = "UPDATE [instituciones_financieras].[activo] SET [descripcion] = '"+txtdireccion.Text+"' WHERE [id_activo] = '" + textBoxCodigo.Text + "' ";
            String msj = Utilidades.Registrar(sql);

            msj = "Registro Actualizado";
            MessageBox.Show(msj); 
            if (msj.Equals("Registro Actualizado"))
            {
                if (this.tipo == 0)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    //textNombre.Text = "";

                }

            }
        }

        private void buttonbaja_Click(object sender, EventArgs e)
        {

            string sql = "UPDATE [instituciones_financieras].[activo] SET [estado] = 'DE BAJA' WHERE [id_activo] = '" + textBoxCodigo.Text + "' ";
            String msj = Utilidades.Registrar(sql);

            msj = "Registro Actualizado";
            MessageBox.Show(msj);
            if (msj.Equals("Registro Actualizado"))
            {
                if (this.tipo == 0)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    //textNombre.Text = "";

                }

            }
        }
    }
}
