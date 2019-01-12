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
    public partial class registroActivo : Form
    {
        public int tipo = 0;
        public registroActivo()
        {
            InitializeComponent();
            cargarCombo();
            cargarComboDepto("001");
            llenarId();
        }

        public void llenarId()
        {
            String codigo = "AFF-";
            codigo = codigo + comboBoxDepto.SelectedValue +"-"+comboBoxTipo.SelectedValue+"-";
            textBoxCodigo.Text = codigo;
        }

        public void cargarComboDepto(String s)
        {
            try
            {//departamento
                DataTable dt = Utilidades.LlenarCombos("Select * from instituciones_financieras.departamento WHERE instituciones_financieras.departamento.id_sucursal = " + s);
                comboBoxDepto.DataSource = dt;
                comboBoxDepto.ValueMember = "id_depto";
                comboBoxDepto.DisplayMember = "nombre";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

            public void cargarCombo()
        {
            try
            {//para tipo
                DataTable dt = Utilidades.LlenarCombos("Select * from instituciones_financieras.tipo_activo");
                comboBoxTipo.DataSource = dt;
                comboBoxTipo.ValueMember = "correlativo";
                comboBoxTipo.DisplayMember = "nombre";
            //sucursal
                dt = Utilidades.LlenarCombos("Select * from instituciones_financieras.sucursal");
                comboBoxSucu.DataSource = dt;
                comboBoxSucu.ValueMember = "id_sucursal";
                comboBoxSucu.DisplayMember = "nombre";               

                //encargado
                dt = Utilidades.LlenarCombos("Select * from instituciones_financieras.empleado");
                comboBoxEnca.DataSource = dt;
                comboBoxEnca.ValueMember = "id_empleado";
                comboBoxEnca.DisplayMember = "nombre";

                //proveedor
                dt = Utilidades.LlenarCombos("Select * from instituciones_financieras.proveedor");
                comboBoxProve.DataSource = dt;
                comboBoxProve.ValueMember = "id_proveedor";
                comboBoxProve.DisplayMember = "nombre";

                //estado
                dt = Utilidades.LlenarCombos("Select * from instituciones_financieras.estado");
                comboBoxEstado.DataSource = dt;
                comboBoxEstado.ValueMember = "id_estado";
                comboBoxEstado.DisplayMember = "nombre";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void registroActivo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//registro tipo
        {
            
            registroTipo registroTipo = new registroTipo();
            
            registroTipo.ShowDialog();
            

        }

        private void button4_Click(object sender, EventArgs e)//registro sucursal
        {
            registroInstitucion registroInst = new registroInstitucion();

            registroInst.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            registroDepartamento registroDepartamento = new registroDepartamento();
            registroDepartamento.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBoxSucu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarComboDepto(comboBoxSucu.SelectedValue+"");
            llenarId();
        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarId();
        }

        private void comboBoxDepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarId();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            string codigo = textBoxCodigo.Text.Trim();
            int tipo = Convert.ToInt32( comboBoxTipo.SelectedValue.ToString().Substring(0,1));
           
            string sucu = comboBoxSucu.SelectedValue.ToString();
            string depto = comboBoxDepto.SelectedValue.ToString();
            string encargado = comboBoxEnca.SelectedValue.ToString();
            string proveedor = comboBoxProve.SelectedValue.ToString();
            string estado = comboBoxEstado.SelectedValue.ToString();
            string precio = textBoxPrecio.Text.Trim();
            string unidades = textBoxUnidades.Text.Trim();
            string descripcion = txtdireccion.Text.Trim();
            DateTime fecha = (dateTimePicker1.Value);
            

            string sql = "Insert into instituciones_financieras.activo " +
                 "(id_activo, id_tipo, id_departamento, id_depto, id_institucion, id_estado, id_usuario, id_proveedor, fecha_adquisicion, descripcion)" +
                " values('" + codigo + "','" + tipo + "','" + 1 + "','" +depto + "','" + sucu + "','" + estado+ "','" + encargado + "','" + proveedor + "','" + fecha + "','" + descripcion + "')";
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
                    //textNombre.Text = "";
                   
                }

            }
        }
    }
}
