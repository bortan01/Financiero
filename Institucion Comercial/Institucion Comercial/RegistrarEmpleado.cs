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

namespace Institucion_Comercial
{
    public partial class RegistrarEmpleado : Form
    {
        public RegistrarEmpleado()
        {
            InitializeComponent();
            llenarId();
            
        }

        private void RegistrarEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        public void limpiar()
        {
            txtnombre.Text="";
            txtnombre.Focus();
            txtapellido.Text="";
            txtzona.Text="";
            txtdui.Text="";
            txtcontra.Text="";
            txtnivel.Text="";

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string nombre1 = txtnombre.Text.Trim();
            string apellido1 = txtapellido.Text.Trim();
            string zona1 = txtzona.Text.Trim();
            string dui1 = txtdui.Text.Trim();
            string contra1 = txtcontra.Text.Trim();
            string nivel1 = txtnivel.Text.Trim();
            string sql = "Insert into instituciones_financieras.empleado " +
                 "(nombre, apellido, zona, dui, pass, nivel)" +
                " values('"+nombre1+ "','" + apellido1 + "','" + zona1 + "','" + dui1 + "','" + contra1 + "','" + nivel1 + "')";
            string cmd = String.Format("Insert into insituciones_financieras.empleado " +
                "(nombre, apellido, zona, dui, pass, nivel) values ({0},{1},{2},{3},{4},{5})"
                , nombre1, apellido1, zona1, dui1, contra1, nivel1);
            string msj=Utilidades.Registrar(sql);
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

        public void llenarId()
        {
            try
            {
                string cmd = String.Format("SELECT IDENT_CURRENT('instituciones_financieras.empleado')+1 as IdActual");
                DataSet ds = Utilidades.Ejecutar(cmd);

                txtid.Text = ds.Tables[0].Rows[0]["IdActual"].ToString().Trim();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
    
}
