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
    public partial class registroDepartamento : Form
    {
        public int tipo = 0;
        public registroDepartamento()
        {
            InitializeComponent();
            cargarCombo();
            llenarId("001");
        }

        private void registroDepartamento_Load(object sender, EventArgs e)
        {

        }

        public void llenarId(String clasi)
        {
            int codigo = 0;
            try
            {

                string cmd = String.Format("SELECT COUNT(1) FROM instituciones_financieras.departamento WHERE instituciones_financieras.departamento.id_sucursal =  "+clasi);
                DataSet ds = Utilidades.Ejecutar(cmd);
                codigo = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString().Trim());

                textBoxCodigo.Text = calcularCod(codigo + 1);

            }
            catch (Exception error)
            {
                //MessageBox.Show(error.Message);
            }
        }

        private String calcularCod(int n)
        {
            String clas = comboBoxSucu.SelectedValue.ToString()+ "-";
           
               
            if (n / 10 == 0)
                return clas + "00" + n;
            else
                if (n / 100 > 0)
                return clas + n;
            return clas + "0" + n;
        }

        public void cargarCombo()
        {
            try
            {
                DataTable dt = Utilidades.LlenarCombos("Select * from instituciones_financieras.sucursal");
                comboBoxSucu.DataSource = dt;
                comboBoxSucu.ValueMember = "id_sucursal";
                comboBoxSucu.DisplayMember = "nombre";
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
            }

            // MessageBox.Show("" + cbClasificacion.SelectedValue);

        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text.Trim();
            string clasificacion = comboBoxSucu.SelectedValue.ToString();
            string proveedor = textBoxCodigo.Text.Trim();

            string sql = "Insert into instituciones_financieras.departamento " +
                 "(nombre, id_sucursal, id_departamento)" +
                " values('" + nombre + "','" + clasificacion + "','" + proveedor + "')";
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
                    textBoxNombre.Text = "";
                    llenarId("001");
                }

            }
        }

        private void comboBoxSucu_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarId(comboBoxSucu.SelectedValue+"");
        }
    }
}
