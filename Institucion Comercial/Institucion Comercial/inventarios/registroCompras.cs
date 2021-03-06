﻿using System;
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
    public partial class registroCompras : Form
    {
        double total2 = 0;
       
        public registroCompras()
        {
            InitializeComponent();
            
            txttotal.Text =total2.ToString();

            txtfecha.MaxDate = DateTime.Now;
            txtfecha.Value = DateTime.Now;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public DataSet Buscar(string campo)
        {
            DataSet ds = new DataSet();
            try
            {
                string cmd = "Select prod.nombre, prod.descripcion, prov.nombre, prod.precio_compra from instituciones_financieras.producto as prod, instituciones_financieras.proveedor as prov " +
                    "where prod.id_producto = '" + campo + "' and prod.id_proveedor = prov.id_proveedor";
                ds = Utilidades.Ejecutar(cmd);

                txtnombre.Text = ds.Tables[0].Rows[0][0].ToString();
                txtdescripcion.Text = ds.Tables[0].Rows[0][1].ToString();
                txtproveedor.Text = ds.Tables[0].Rows[0][2].ToString();
                txtprecio.Text = ds.Tables[0].Rows[0][3].ToString();
                txtcantidad.Focus();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            return ds;
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            agregar();
        }

        public void limpiarCampos()
        {
            txtcantidad.Value = 0;
            txtnombre.Text = "";
            txtcodigo.Text = "";
            txtcodigo.Focus();
            txtdescripcion.Text = "";
            txtproveedor.Text = "";
            txtprecio.Text = "";
        }
        public static int contador_fila = 0;
        public void agregar()
        {
            string codigo = txtcodigo.Text.ToString();
            string cantidad = txtcantidad.Value.ToString();
            string nombre = txtnombre.Text.Trim();
            string descripcion = txtdescripcion.Text.Trim();
            string proveedor = txtproveedor.Text.Trim();
            string precio = txtprecio.Text.Trim();
            double total = Convert.ToDouble(cantidad) * Convert.ToDouble(precio);
            bool existe = false;
            int num_fila = 0;
            if (contador_fila ==0) {
                tblcompras.Rows.Insert(tblcompras.RowCount, codigo, nombre, descripcion, proveedor, precio, cantidad, total);
                limpiarCampos();
                total2 += total;
                txttotal.Text = total2.ToString();
                contador_fila++;
            }
            else
            {
                foreach (DataGridViewRow fila in tblcompras.Rows)
                {
                    if (fila.Cells[0].Value.ToString() == txtcodigo.Text)
                    {
                        existe = true;
                        num_fila = fila.Index;
                        break;
                    }   
                }
                if (existe)
                {
                    tblcompras.Rows[num_fila].Cells[5].Value = (Convert.ToDouble(cantidad) + Convert.ToDouble(tblcompras.Rows[num_fila].Cells[5].Value)).ToString();
                    tblcompras.Rows[num_fila].Cells[6].Value = (Convert.ToDouble(total) + Convert.ToDouble(tblcompras.Rows[num_fila].Cells[6].Value)).ToString();
                    total2 += total;
                    txttotal.Text = total2.ToString();
                    limpiarCampos();
                }
                else
                {
                    tblcompras.Rows.Insert(tblcompras.RowCount, codigo, nombre, descripcion, proveedor, precio, cantidad, total);
                    limpiarCampos();
                    total2 += total;
                    txttotal.Text = total2.ToString();
                    contador_fila++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consultarProductos buscar = new consultarProductos();
            buscar.ShowDialog();

            if (buscar.DialogResult == DialogResult.OK)
            {
                txtcodigo.Text = buscar.tablaProductos.Rows[buscar.tablaProductos.CurrentRow.Index].Cells[0].Value.ToString();
                txtnombre.Text = buscar.tablaProductos.Rows[buscar.tablaProductos.CurrentRow.Index].Cells[1].Value.ToString();
                txtdescripcion.Text = buscar.tablaProductos.Rows[buscar.tablaProductos.CurrentRow.Index].Cells[2].Value.ToString();
                txtproveedor.Text = buscar.tablaProductos.Rows[buscar.tablaProductos.CurrentRow.Index].Cells[3].Value.ToString();
                txtprecio.Text = buscar.tablaProductos.Rows[buscar.tablaProductos.CurrentRow.Index].Cells[4].Value.ToString();
                txtcantidad.Focus();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            registroProductos nuevo = new registroProductos(0);
            nuevo.ShowDialog();

            if (nuevo.DialogResult == DialogResult.OK) {
                txtcodigo.Text = nuevo.txtid.Text.Trim();
                txtnombre.Text = nuevo.txtnombre.Text.Trim();
                txtdescripcion.Text = nuevo.txtdescripcion.Text.Trim();
                txtproveedor.Text = nuevo.cbproveedor.Text.Trim();
                txtprecio.Text = nuevo.txtcompra.Text.Trim();
                txtcantidad.Focus();
            }
        }

        private void txtcodigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscar(txtcodigo.Text);
                txtcantidad.Select(0, 1);
            }
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                
                if (this.openFileDialog1.FileName.Equals("")==false)
                {
                    txtfoto.Text = this.openFileDialog1.FileName;
                    fotocomprobante.Load( this.openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tblcompras_SelectionChanged(object sender, EventArgs e)
        {
            if (tblcompras.SelectedRows.Count>0)
            {
                btneliminar.Enabled = true;
            }
            else
            {
                btneliminar.Enabled = false;
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            tblcompras.Rows.Remove(tblcompras.CurrentRow);
            if(tblcompras.Rows.Count == 0)
            {
                btneliminar.Enabled = false;
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiarTodo();
        }

        public void limpiarTodo()
        {
            limpiarCampos();
            tblcompras.Rows.Clear();
            txttotal.Text = "";
            txtfoto.Text = "";
            this.openFileDialog1.Reset();
            btneliminar.Enabled = false;
            txtfecha.Value = txtfecha.MaxDate;
            fotocomprobante.Image = null;

        }

        private void txtcantidad_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                agregar();
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(txttotal.Text);
            DateTime fecha = (txtfecha.Value);
            System.IO.MemoryStream imagen = new System.IO.MemoryStream();
            fotocomprobante.Image.Save(imagen,System.Drawing.Imaging.ImageFormat.Jpeg);
            string resultado = Utilidades.InsertarImagen(total,fecha,imagen);
            
            if (resultado.Equals("Exito"))
            {
               // MessageBox.Show("Aqui");
                string ultimo = obtenerId();
                string msj = "";
                foreach (DataGridViewRow fila in tblcompras.Rows)
                {
                    string producto = fila.Cells[0].Value.ToString();
                    string cantidad = fila.Cells[5].Value.ToString();
                    string precio = fila.Cells[4].Value.ToString();
                    msj = Utilidades.Registrar("Insert into instituciones_financieras.detalle_compras (id_producto , id_compra, cantidad, precio) " +
                       " values ('"+producto+"', '"+ultimo+"', '"+cantidad+ "', '" + precio + "')");

                    meterInventario(producto, cantidad);

                }
                MessageBox.Show(msj);
                limpiarTodo();
            }
            else
            {
                MessageBox.Show(resultado);
            }
        }

        public void meterInventario(string prod, string cantidad)
        {
            DataSet ds;
            ds=Utilidades.Ejecutar("Select count(*) as existe from instituciones_financieras.inventario where id_producto='"+prod+"'");
            string existe = ds.Tables[0].Rows[0]["existe"].ToString();
           // MessageBox.Show(existe);
            if (existe.Equals("1"))
            {
                ds = Utilidades.Ejecutar("Select cantidad from instituciones_financieras.inventario where id_producto = '" + prod + "'");
                int cantidad2 = Convert.ToInt16(ds.Tables[0].Rows[0]["cantidad"]);
                int total = Convert.ToInt16(cantidad) + cantidad2;
               Utilidades.Registrar("Update instituciones_financieras.inventario set " +
                    "cantidad='"+total+"' where id_producto = '"+prod+"'");
            }
            else
            {
                Utilidades.Registrar("Insert into instituciones_financieras.inventario (cantidad, id_producto) " +
                    "values ('"+cantidad+"','"+prod+"')");
            }
        }

        public string obtenerId()
        {
            try
            {
                string cmd = String.Format("select max(id_compra) as IdActual from instituciones_financieras.compras");
                DataSet ds = Utilidades.Ejecutar(cmd);

               return ds.Tables[0].Rows[0]["IdActual"].ToString().Trim();

            }
            catch (Exception error)
            {
                return "0";
            }
        }
    }
}
