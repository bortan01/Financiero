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
    public partial class detalleCompra : Form
    {
        string idcompra = "";
        public detalleCompra(string idcompra)
        {
            InitializeComponent();
            this.idcompra = idcompra;
            cargar();
            
        }

        public void cargar()
        {
            try
            {
                DataSet ds = Buscar(idcompra);
                DateTime fecha = Convert.ToDateTime(ds.Tables[0].Rows[0]["fecha_compra"].ToString());
                txtcodigo.Text = ds.Tables[0].Rows[0]["id_compra"].ToString();
                txtfecha.Text = fecha.ToShortDateString();
                txttotal.Text = ds.Tables[0].Rows[0]["total"].ToString();
                byte[] datos = new byte[0];
                datos = (byte[])ds.Tables[0].Rows[0]["comprobante"];
                System.IO.MemoryStream imagen = new System.IO.MemoryStream(datos);
                fotocomprobante.Image = System.Drawing.Bitmap.FromStream(imagen);
                
                tablaProductos.DataSource = Detalles().Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataSet Buscar(string campo)
        {
            DataSet ds = new DataSet();
            try
            {
                string cmd = "Select * from instituciones_financieras.compras " +
                    "where id_compra = '"+campo+"'";
                ds = Utilidades.Ejecutar(cmd);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            return ds;
        }

        public DataSet Detalles()
        {
            DataSet ds = new DataSet();
            try
            {
                string cmd = "Select p.id_producto,p.nombre,p.descripcion,p.precio_compra, dc.cantidad, (dc.precio*dc.cantidad) as total from instituciones_financieras.producto as p, instituciones_financieras.detalle_compras as dc, instituciones_financieras.compras as compras where compras.id_compra = '"+idcompra+"' and dc.id_compra = compras.id_compra and p.id_producto= dc.id_producto";
                ds = Utilidades.Ejecutar(cmd);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            return ds;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
