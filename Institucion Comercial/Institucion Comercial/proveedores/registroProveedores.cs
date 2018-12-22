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
    public partial class registroProveedores : Form
    {
        public registroProveedores()
        {
            InitializeComponent();
            llenarId();
        }

        private void registroProveedores_Load(object sender, EventArgs e)
        {

        }
        public void llenarId()
        {
            try
            {
                string cmd = String.Format("SELECT CASE WHEN (SELECT COUNT(1) FROM instituciones_financieras.proveedor) = 0 THEN 1 ELSE IDENT_CURRENT('instituciones_financieras.proveedor') + 1 END AS IdActual;");
                DataSet ds = Utilidades.Ejecutar(cmd);

                txtid.Text = ds.Tables[0].Rows[0]["IdActual"].ToString().Trim();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void limpiar()
        {
            txtnombre.Text = "";
            txtnombre.Focus();
            txtdireccion.Text = "";
            txtdui.Text = "";
            txttelefono.Text = "";
            

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string nombre1 = txtnombre.Text.Trim();
            string direccion1 = txtdireccion.Text.Trim();
            string dui1 = txtdui.Text.Trim();
            string telefono1 = txttelefono.Text.Trim();
            string sql = "Insert into instituciones_financieras.proveedor " +
                 "(nombre, dui, direccion, telefono)" +
                " values('" + nombre1 + "','" + dui1 + "','" + direccion1 + "','" + telefono1 + "')";
            string msj = Utilidades.Registrar(sql);
            MessageBox.Show(msj);
            if (msj.Equals("Registro Completado"))
            {
                limpiar();
                llenarId();
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }

    
}
