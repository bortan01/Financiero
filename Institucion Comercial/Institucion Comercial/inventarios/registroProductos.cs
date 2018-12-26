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

namespace Institucion_Comercial.inventarios
{
    public partial class registroProductos : Form
    {
        public int tipo;
        public registroProductos( int tipo)
        {
            InitializeComponent();
            cargarCombo();
            llenarId();
            this.tipo = tipo;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        public void limpiar()
        {
            txtnombre.Text = "";
            txtnombre.Focus();
            txtdescripcion.Text = "";
            txtminimo.Text = "";
            txtcompra.Text = "";
            txtventa.Text = "";
            
        }

        public void llenarId()
        {
            try
            {
                string cmd = String.Format("SELECT CASE WHEN (SELECT COUNT(1) FROM instituciones_financieras.producto) = 0 THEN 1 ELSE IDENT_CURRENT('instituciones_financieras.producto') + 1 END AS IdActual;");
                DataSet ds = Utilidades.Ejecutar(cmd);

                txtid.Text = ds.Tables[0].Rows[0]["IdActual"].ToString().Trim();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void cargarCombo()
        {
            try {
            DataTable dt = Utilidades.LlenarCombos("Select * from instituciones_financieras.proveedor");
            cbproveedor.DataSource = dt;
            cbproveedor.ValueMember = "id_proveedor";
            cbproveedor.DisplayMember = "nombre";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            MessageBox.Show(""+cbproveedor.SelectedValue);
            
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text.Trim();
            string descripcion = txtdescripcion.Text.Trim();
            string proveedor = cbproveedor.SelectedValue+"";
            string compra = txtcompra.Text.Trim();
            string venta = txtventa.Text.Trim();
            string minimo = txtminimo.Text.Trim();
            string sql = "Insert into instituciones_financieras.producto " +
                 "(nombre, descripcion, id_proveedor, precio_compra, precio_venta, minimo)" +
                " values('" + nombre + "','" + descripcion + "','" + proveedor + "','" + compra + "','" + venta + "','" + minimo + "')";
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
                    limpiar();
                    llenarId();
                }
                
            }
        }
    }
}
