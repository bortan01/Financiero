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
    public partial class registroInstitucion : Form
    {
        public int tipo = 0;
        public registroInstitucion()
        {
            InitializeComponent();
            llenarId();
        }

        private void registroInstitucion_Load(object sender, EventArgs e)
        {

        }

        public void llenarId()
        {           
            try
            {
                int codigo = 0;
                string cmd = String.Format("sELECT COUNT(1) FROM instituciones_financieras.sucursal");
                DataSet ds = Utilidades.Ejecutar(cmd);
                codigo = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString().Trim());
                textCodigo.Text = calcularCod(codigo+1);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }


        private String calcularCod(int n)
        {
           
            if (n / 10 == 0)
                return  "00" + n;
            else
                if (n / 100 > 0)
                return "" + n;
            return  "0" + n;
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = textNombre.Text.Trim();
            string codigo = textCodigo.Text.Trim();
            string direc = textDireccion.Text.Trim();
            string tel = textTelefono.Text.Trim();

            string sql = "Insert into instituciones_financieras.sucursal " +
                 "(nombre, id_sucursal, direccion, telefono)" +
                " values('" + nombre + "','" + codigo + "','" + direc +"','"+tel+ "')";
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
                   
                }

            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textDireccion.Text = "";
            textNombre.Text = "";
            textTelefono.Text = "";
        }
    }
}
