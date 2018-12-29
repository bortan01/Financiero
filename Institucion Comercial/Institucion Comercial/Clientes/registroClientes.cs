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
    public partial class registroClientes : Form
    {
        public registroClientes()
        {
            InitializeComponent();
            llenarId();
        }

        public void llenarId()
        {
            try
            {
                string cmd = String.Format("SELECT CASE WHEN (SELECT COUNT(1) FROM instituciones_financieras.cliente) = 0 THEN 1 ELSE IDENT_CURRENT('instituciones_financieras.cliente') + 1 END AS IdActual;");
                DataSet ds = Utilidades.Ejecutar(cmd);

                txtid.Text = ds.Tables[0].Rows[0]["IdActual"].ToString().Trim();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void llenarIdFiador()
        {
            try
            {
                string cmd = String.Format("SELECT CASE WHEN (SELECT COUNT(1) FROM instituciones_financieras.fiador) = 0 THEN 1 ELSE IDENT_CURRENT('instituciones_financieras.fiador') + 1 END AS IdActual;");
                DataSet ds = Utilidades.Ejecutar(cmd);

                txtidf.Text = ds.Tables[0].Rows[0]["IdActual"].ToString().Trim();

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
            txtcorreo.Text = "";
            txtnit.Text = "";
            txttelefono.Text = "";
            txtapellido.Text = "";
            //fiador
            txtidf.Text = "";
            txtnombref.Text = "";
            txttrabajof.Text="";
            txtdireccionf.Text = "";
            txtduif.Text = "";
            txtcorreof.Text = "";
            txtnitf.Text = "";
            txtapellidof.Text = "";
            txttelefonof.Text = "";
            checkBox1.Checked = false;

            txtnombref.ReadOnly = true;
            txtapellidof.ReadOnly = true;
            txtduif.ReadOnly = true;
            txtnitf.ReadOnly = true;
            txtcorreof.ReadOnly = true;
            txttelefonof.ReadOnly = true;
            txtdireccionf.ReadOnly = true;
            txtdireccionf.BackColor = this.BackColor;
            txttrabajof.ReadOnly = true;


        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string nombre1 = txtnombre.Text.Trim();
            string direccion1 = txtdireccion.Text.Trim();
            string dui1 = txtdui.Text.Trim();
            string telefono1 = txttelefono.Text.Trim();
            string correo = txtcorreo.Text.Trim();
            string nit = txtnit.Text.Trim();
            string apellido = txtapellido.Text.Trim();
            string sql = "Insert into instituciones_financieras.cliente " +
                 "(nombre,  apellido, direccion, dui, nit, correo, telefono)" +
                " values('" + nombre1 + "','" + apellido + "','" + direccion1 + "','" + dui1 + "','" + nit + "','" + correo + "','" + telefono1 + "')";
            string msj = Utilidades.Registrar(sql);
            if (checkBox1.Checked)
            {
                guardarFiador();
            }
            MessageBox.Show(msj);
            if (msj.Equals("Registro Completado"))
            {
                limpiar();
                llenarId();
            }
        }

        public void guardarFiador()
        {
            string nombre1 = txtnombref.Text.Trim();
            string direccion1 = txtdireccionf.Text.Trim();
            string dui1 = txtduif.Text.Trim();
            string telefono1 = txttelefonof.Text.Trim();
            string correo = txtcorreof.Text.Trim();
            string nit = txtnitf.Text.Trim();
            string apellido = txtapellidof.Text.Trim();
            string trabajp = txttrabajof.Text.Trim();
            string cliente = txtid.Text.Trim();
            string sql = "Insert into instituciones_financieras.fiador " +
                 "(id_persona_natural,  nombre, apellido, direccion, dui, nit, correo, lugar_trabajo,telefono)" +
                " values('" + cliente + "','" + nombre1 + "','" + apellido + "','" + direccion1 + "','" + dui1 + "','" + nit + "','" + correo + "','" + trabajp + "','" + telefono1 + "')";
            string msj = Utilidades.Registrar(sql);
            
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtnombref.ReadOnly) {
                txtnombref.ReadOnly = false;
                txtapellidof.ReadOnly = false;
                txtduif.ReadOnly = false;
                txtnitf.ReadOnly = false;
                txtcorreof.ReadOnly = false;
                txttelefonof.ReadOnly = false;
                txtdireccionf.ReadOnly = false;
                txtdireccionf.BackColor = Color.White;
                txttrabajof.ReadOnly = false;
                llenarIdFiador();
            }
            else
            {
                txtnombref.ReadOnly = true;
                txtapellidof.ReadOnly = true;
                txtduif.ReadOnly = true;
                txtnitf.ReadOnly = true;
                txtcorreof.ReadOnly = true;
                txttelefonof.ReadOnly = true;
                txtdireccionf.ReadOnly = true;
                txtdireccionf.BackColor = this.BackColor;
                txttrabajof.ReadOnly = true;
                txtidf.Text = "";
            }
        }
    }

}
