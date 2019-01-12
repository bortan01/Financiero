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
    public partial class registroTipo : Form
    {
        public int tipo=0;
        public registroTipo()
        {           
            InitializeComponent();
            cargarCombo();
            llenarId("1");
        }
        public void cargarCombo()
        {
            try
            {
                DataTable dt = Utilidades.LlenarCombos("Select * from instituciones_financieras.clasificacion");
                cbClasificacion.DataSource = dt;
                cbClasificacion.ValueMember = "id_clasificacion";
                cbClasificacion.DisplayMember = "nombre";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

           // MessageBox.Show("" + cbClasificacion.SelectedValue);

        }

        public void llenarId(String clasi)
        {
            int codigo = 0;
            try
            {
                
                string cmd = String.Format("SELECT COUNT(1) FROM instituciones_financieras.tipo_activo INNER JOIN instituciones_financieras.clasificacion ON instituciones_financieras.tipo_activo.id_clasificacion = instituciones_financieras.clasificacion.id_clasificacion WHERE instituciones_financieras.tipo_activo.id_clasificacion = "+clasi);
                DataSet ds = Utilidades.Ejecutar(cmd);
                codigo = Convert.ToInt32( ds.Tables[0].Rows[0][0].ToString().Trim());
               
                textCodigo.Text = calcularCod(codigo+1);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void cbClasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void registroTipo_Load(object sender, EventArgs e)
        {

        }

        private void cbClasificacion_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                String s = cbClasificacion.SelectedValue + "";
                llenarId(s);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
           
        }
        

        private String calcularCod(int n)
        {
            String clas="000";
            if (cbClasificacion.SelectedValue.ToString() == "1")
                clas = "100-";
            if (cbClasificacion.SelectedValue.ToString() == "2")
                clas = "200-";
            if (cbClasificacion.SelectedValue.ToString() == "3")
                clas = "300-";
            if (cbClasificacion.SelectedValue.ToString() == "4")
                clas = "400-";

            if (n / 10 == 0)
                return clas+"00" + n;
            else
                if (n / 100 > 0)
                return clas + n;
            return clas+"0"+n;
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = textNombre.Text.Trim();
            string clasificacion = cbClasificacion.SelectedValue.ToString();
            string proveedor = textCodigo.Text.Trim();
            
            string sql = "Insert into instituciones_financieras.tipo_activo " +
                 "(nombre, id_clasificacion, correlativo)" +
                " values('" + nombre + "','" + clasificacion + "','" + proveedor +  "')";
            string msj = Utilidades.Registrar(sql);
            MessageBox.Show(msj);
            if (msj.Equals("Registro Completado"))
            {
                if (this.tipo == 0)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    textNombre.Text = "";
                    llenarId("1");
                }

            }
        }
    }
}
