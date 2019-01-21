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

namespace Institucion_Comercial.Clientes
{
    public partial class detalleCliente : Form
    {
        string idcliente;
        public detalleCliente(string id)
        {
            InitializeComponent();
            this.idcliente = id;
            cargar();
            cargarFiador();
        }

        public void cargar()
        {
            try
            {
                DataSet ds = Buscar(idcliente);
                //DateTime fecha = Convert.ToDateTime(ds.Tables[0].Rows[0]["fecha_compra"].ToString());
                txtid.Text = ds.Tables[0].Rows[0]["id_cliente"].ToString();
                txtnombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                txtapellido.Text = ds.Tables[0].Rows[0]["apellido"].ToString();
                txtdireccion.Text = ds.Tables[0].Rows[0]["direccion"].ToString();
                txtdui.Text = ds.Tables[0].Rows[0]["dui"].ToString();
                txtnit.Text = ds.Tables[0].Rows[0]["nit"].ToString();
                txttelefono.Text = ds.Tables[0].Rows[0]["telefono"].ToString();
                txtobservaciones.Text = ds.Tables[0].Rows[0]["observaciones"].ToString();
                txtcorreo.Text = ds.Tables[0].Rows[0]["correo"].ToString();
                lbcartera.Text = "("+ds.Tables[0].Rows[0]["cartera"].ToString().Trim()+")";
                if (ds.Tables[0].Rows[0]["cartera"].ToString().Trim().Equals("NORMAL"))
                {
                    
                    lbcartera.BackColor = Color.LightGreen;
                    lbcartera.ForeColor = Color.DarkGreen;
                }
                if (ds.Tables[0].Rows[0]["cartera"].ToString().Trim().Equals("MORA"))
                {
                    lbcartera.BackColor = Color.LightYellow;
                    lbcartera.ForeColor = Color.Orange;
                }
                if (ds.Tables[0].Rows[0]["cartera"].ToString().Trim().Equals("INCOBRABLE"))
                {
                    lbcartera.BackColor = Color.LightPink;
                    lbcartera.ForeColor = Color.DarkRed;
                }

                cargarFiador();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void cargarFiador()
        {
            try
            {
                DataSet ds = BuscarFiador(idcliente);
                //DateTime fecha = Convert.ToDateTime(ds.Tables[0].Rows[0]["fecha_compra"].ToString());
                txtidf.Text = ds.Tables[0].Rows[0]["id_fiador"].ToString();
                txtnombref.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                txtapellidof.Text = ds.Tables[0].Rows[0]["apellido"].ToString();
                txtdireccionf.Text = ds.Tables[0].Rows[0]["direccion"].ToString();
                txtduif.Text = ds.Tables[0].Rows[0]["dui"].ToString();
                txtnitf.Text = ds.Tables[0].Rows[0]["nit"].ToString();
                txttelefonof.Text = ds.Tables[0].Rows[0]["telefono"].ToString();
                txtcorreof.Text = ds.Tables[0].Rows[0]["correo"].ToString();
                txttrabajof.Text = ds.Tables[0].Rows[0]["lugar_trabajo"].ToString();
                
                

                
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public DataSet Buscar(string campo)
        {
            DataSet ds = new DataSet();
            try
            {
                string cmd = "Select * from instituciones_financieras.cliente " +
                    "where id_cliente = '" + campo + "'";
                ds = Utilidades.Ejecutar(cmd);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            return ds;
        }

        public DataSet BuscarFiador(string campo)
        {
            DataSet ds = new DataSet();
            try
            {
                string cmd = "Select * from instituciones_financieras.fiador " +
                    "where id_persona_natural = '" + campo + "'";
                ds = Utilidades.Ejecutar(cmd);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            return ds;
        }

        private void detalleCliente_Load(object sender, EventArgs e)
        {

            try {
                String sql = "SELECT instituciones_financieras.venta.estado FROM instituciones_financieras.venta INNER JOIN instituciones_financieras.detalle_compra ON instituciones_financieras.detalle_compra.id_venta = instituciones_financieras.venta.id_venta INNER JOIN instituciones_financieras.cliente ON instituciones_financieras.detalle_compra.id_cliente = instituciones_financieras.cliente.id_cliente where cliente.id_cliente = '1'  ";
                DataSet Ds;
                Ds = Utilidades.Ejecutar(sql);
                String ESTADO = "";
                foreach (DataRow Fila in Ds.Tables[0].Rows) {
                    ESTADO = Convert.ToString(Fila["estado"].ToString().Trim());
                }
                if (ESTADO != "") {
                    sql = "UPDATE instituciones_financieras.cliente set cartera = '" + ESTADO + "' WHERE instituciones_financieras.cliente.id_cliente = '" + idcliente + "'";
                    Ds = Utilidades.Ejecutar(sql);
                }
            }
            catch (Exception E) {
                MessageBox.Show(E.Message);
            }
        }
    }
}
