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
namespace Institucion_Comercial.comercial
{
    public partial class VentaContado : Form
    {
        public VentaContado()
        {
            InitializeComponent();
        }
        public String id_cliente ;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBuscarCliente.Text.Trim()) == false)
            {
                //MessageBox.Show("va por aqui");
                try
                {
                    DataSet ds;
                    String sql = "select * from instituciones_financieras.cliente where nombre like ('%" + txtBuscarCliente.Text + "%') or id_cliente like ('%" + txtBuscarCliente.Text + "%') ";
                    // MessageBox.Show(sql);

                    ds = Utilidades.Ejecutar(sql);
                    txtNombreCliente.Text = ds.Tables[0].Rows[0]["nombre"].ToString().Trim() + ds.Tables[0].Rows[0]["apellido"].ToString().Trim();
                    txtDuiCliente.Text = ds.Tables[0].Rows[0]["dui"].ToString().Trim();
                    txtNitCliente.Text = ds.Tables[0].Rows[0]["nit"].ToString().Trim();
                    txtTelefonoCliente.Text = ds.Tables[0].Rows[0]["telefono"].ToString().Trim();
                    id_cliente = ds.Tables[0].Rows[0]["id_cliente"].ToString().Trim();
                }
                catch (Exception error)
                {
                    MessageBox.Show("ha ocurrido un error " + error.Message);
                }
            }
        }

        private void VentaContado_Load(object sender, EventArgs e)
        {
            String sql = "select id_empleado,nombre,apellido from instituciones_financieras.empleado where id_empleado =" +Login.codigo;
            DataSet ds;
            //MessageBox.Show(sql);

            ds = Utilidades.Ejecutar(sql);
            txtEmpleado.Text = ds.Tables[0].Rows[0]["nombre"].ToString().Trim() + ds.Tables[0].Rows[0]["apellido"].ToString().Trim();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBuscarProducto.Text.Trim()) == false)
            {
                //MessageBox.Show("va por aqui");
                try
                {
                    DataSet ds;
                    String sql = "select id_producto,nombre,descripcion,precio_venta from instituciones_financieras.producto where nombre  like ('%" + txtBuscarProducto.Text + "%')   or id_producto like ('%" + txtBuscarProducto.Text + "%') ";
                    // MessageBox.Show(sql);

                    ds = Utilidades.Ejecutar(sql);
                    dataGridView1.Rows.Add(ds.Tables[0].Rows[0]["id_producto"].ToString().Trim(),
                                           ds.Tables[0].Rows[0]["nombre"].ToString().Trim(),
                                           ds.Tables[0].Rows[0]["precio_venta"].ToString().Trim(),
                                           ds.Tables[0].Rows[0]["descripcion"].ToString().Trim());
                }
                catch (Exception error)
                {
                    MessageBox.Show("ha ocurrido un error " + error.Message);
                }
            }
        }
    }
}
