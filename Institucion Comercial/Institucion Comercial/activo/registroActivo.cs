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
            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker1.Value = DateTime.Now;
        }

        public void llenarId()
        {
            String codigo = "AFF-";
            int correlativo = 0;
            if (comboBoxDepto.Items.Count>0 && comboBoxTipo.Items.Count > 0 )
            {
                codigo = codigo + comboBoxDepto.SelectedValue + "-" + comboBoxTipo.SelectedValue.ToString().Substring(0, 4) + "-";
            }
            //

            try
            {

                string cmd = String.Format("SELECT Count(1) FROM instituciones_financieras.activo WHERE instituciones_financieras.activo.id_activo LIKE '"+codigo+"%'" );
                DataSet ds = Utilidades.Ejecutar(cmd);
                correlativo = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString().Trim());

                textBoxCodigo.Text = codigo+ calcularCod(correlativo + 1);

            }
            catch (Exception error)
            {
               // MessageBox.Show(error.Message);
            }
            
        }

        private String calcularCod(int n)
        {
           

            if (n / 10 == 0)
                return  "00" + n;
            else
                if (n / 100 > 0)
                return  ""+n;
            return  "0" + n;
        }

        public void cargarComboDepto(String s)
        {
            try
            {//departamento
                DataTable dt = Utilidades.LlenarCombos("Select * from instituciones_financieras.departamento WHERE instituciones_financieras.departamento.id_sucursal = " + s);
                comboBoxDepto.DataSource = dt;
                comboBoxDepto.ValueMember = "id_departamento";
                comboBoxDepto.DisplayMember = "nombre";
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
            }
        }

            public void cargarCombo()
        {
            try
            {//para tipo
                DataTable dt = Utilidades.LlenarCombos("SELECT instituciones_financieras.tipo_activo.nombre,instituciones_financieras.tipo_activo.correlativo + CONVERT(VARCHAR, instituciones_financieras.tipo_activo.id_tipo) as correlativo FROM instituciones_financieras.tipo_activo");
                comboBoxTipo.DataSource = dt;
                comboBoxTipo.ValueMember = "correlativo";
                comboBoxTipo.DisplayMember = "nombre";
            //sucursal
                dt = Utilidades.LlenarCombos("Select * from instituciones_financieras.sucursal");
                comboBoxSucu.DataSource = dt;
                comboBoxSucu.ValueMember = "id_sucursal";
                comboBoxSucu.DisplayMember = "nombre";               

                //encargado
                dt = Utilidades.LlenarCombos("SELECT instituciones_financieras.empleado.id_empleado, instituciones_financieras.empleado.nombre + ' ' + instituciones_financieras.empleado.apellido as nombre from instituciones_financieras.empleado");
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
               // MessageBox.Show(e.Message);
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
            cargarCombo();
            cargarComboDepto("001");

        }

        private void button4_Click(object sender, EventArgs e)//registro sucursal
        {
            registroInstitucion registroInst = new registroInstitucion();
            registroInst.ShowDialog();
            cargarCombo();
            cargarComboDepto("001");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            registroDepartamento registroDepartamento = new registroDepartamento();
            registroDepartamento.ShowDialog();
            cargarCombo();
            cargarComboDepto("001");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBoxSucu_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            comboBoxDepto.DataSource = null;
            comboBoxDepto.Items.Clear();
            cargarComboDepto(comboBoxSucu.SelectedValue + "");
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
            string msj = "";
            string codigo = textBoxCodigo.Text.Trim();
            int tipo = Convert.ToInt32( comboBoxTipo.SelectedValue.ToString().Substring(4,1));
           
            string sucu = comboBoxSucu.SelectedValue.ToString();
            string depto = comboBoxDepto.SelectedValue.ToString();
            string encargado = comboBoxEnca.SelectedValue.ToString();
            string proveedor = comboBoxProve.SelectedValue.ToString();
            string estado = comboBoxEstado.SelectedValue.ToString();
            string precio = textBoxPrecio.Text.Trim();
            int unidades = Convert.ToInt32( textBoxUnidades.Text.Trim());
            string descripcion = txtdireccion.Text.Trim();
            DateTime fecha = (dateTimePicker1.Value.Date);
            //DateTime fecha = DateTime.ParseExact(dateTimePicker1.Value.ToString(), "dd/MM/yyyy H:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

            for (int i = 0; i< unidades; i++) { 
            string sql = "Insert into instituciones_financieras.activo " +
                 "(id_activo, id_tipo,  id_depto,  id_estado, id_usuario, id_proveedor, fecha_adquisicion, descripcion, correlativo, estado)" +
                " values('" + codigo + "','" + tipo +  "','" +depto + "','" + estado+ "','" + encargado + "','" + proveedor + "','" + fecha.ToString("yyyy-MM-dd") + "','" + descripcion + "','" + precio + "', 'Disponible')";
            msj = Utilidades.Registrar(sql);
                llenarId();
                codigo = textBoxCodigo.Text.Trim();
            }
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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textBoxPrecio.Text = "";
            textBoxUnidades.Text = "";
            txtdireccion.Text = "";

        }
    }
}
