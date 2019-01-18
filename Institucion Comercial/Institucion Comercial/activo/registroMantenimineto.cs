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
    public partial class registroMantenimineto : Form
    {
        int tipo = 0;
        public registroMantenimineto()
        {
            InitializeComponent();
            dateTimePicker1.MaxDate = DateTime.Now;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            registroEncargadoMantenimineto registroEncargado = new registroEncargadoMantenimineto();
            registroEncargado.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void registroMantenimineto_Load(object sender, EventArgs e)
        {
            textBoxCod.AutoCompleteCustomSource = LoadAutoComplete();
            textBoxCod.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxCod.AutoCompleteSource = AutoCompleteSource.CustomSource;

            textBoxEnca.AutoCompleteCustomSource = LoadAutoComplete1();
            textBoxEnca.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxEnca.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cmd = String.Format("SELECT instituciones_financieras.activo.id_activo, " +
"instituciones_financieras.tipo_activo.nombre + '-' + instituciones_financieras.clasificacion.nombre, " +
"instituciones_financieras.activo.descripcion " +
"FROM instituciones_financieras.activo " +
"INNER JOIN instituciones_financieras.tipo_activo ON instituciones_financieras.activo.id_tipo = instituciones_financieras.tipo_activo.id_tipo " +
"INNER JOIN instituciones_financieras.clasificacion ON instituciones_financieras.tipo_activo.id_clasificacion = instituciones_financieras.clasificacion.id_clasificacion WHERE activo.id_activo ='" + textBoxCod.Text + "' and instituciones_financieras.activo.estado LIKE 'Disponible'");
            DataSet ds = Utilidades.Ejecutar(cmd);
            if (ds.Tables[0].Rows.Count!=0 && !buscar(textBoxCod.Text, tblcompras) )
            {
                tblcompras.Rows.Equals(textBoxCod.Text);  //("textBoxCod.Text ");
                tblcompras.Rows.Insert(tblcompras.RowCount, ds.Tables[0].Rows[0][0].ToString(), ds.Tables[0].Rows[0][1].ToString(), ds.Tables[0].Rows[0][2].ToString());
            }
            else
            {
                MessageBox.Show("Activo no disponible o ya esta en la tabla");
            }

        }

        public Boolean buscar(String cadena, DataGridView tdv)
        {

            for (int fila = 0; fila < tdv.Rows.Count ; fila++)
            {
                for (int col = 0; col < tdv.Rows[fila].Cells.Count; col++)
                {
                    string valor = tdv.Rows[fila].Cells[col].Value.ToString();
                    if (valor == cadena)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static AutoCompleteStringCollection LoadAutoComplete()
        {
            string cmd = String.Format("SELECT instituciones_financieras.activo.id_activo FROM instituciones_financieras.activo WHERE instituciones_financieras.activo.estado LIKE 'Disponible'");
            DataSet ds = Utilidades.Ejecutar(cmd);
            DataTable dt = ds.Tables[0];

            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();

            foreach (DataRow row in dt.Rows)
            {
                stringCol.Add(Convert.ToString(row[0]));
            }

            return stringCol;
        }
        public static AutoCompleteStringCollection LoadAutoComplete1()
        {
            string cmd = String.Format("SELECT instituciones_financieras.encargado.nombre+'-'+  CONVERT(VARCHAR(4), instituciones_financieras.encargado.id_encargado) FROM instituciones_financieras.encargado");
            DataSet ds = Utilidades.Ejecutar(cmd);
            DataTable dt = ds.Tables[0];

            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();

            foreach (DataRow row in dt.Rows)
            {
                stringCol.Add(Convert.ToString(row[0]));
            }

            return stringCol;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String cod = textBoxEnca.Text.Split('-')[1];
            string cmd = String.Format("SELECT "+
"instituciones_financieras.encargado.id_encargado, " +
"instituciones_financieras.encargado.nombre, " +
"instituciones_financieras.encargado.direccion, " +
"instituciones_financieras.encargado.telefono, " +
"instituciones_financieras.encargado.correo " +
"FROM " +
"instituciones_financieras.encargado WHERE instituciones_financieras.encargado.id_encargado = "+cod+"");
            DataSet ds = Utilidades.Ejecutar(cmd);
            if (ds.Tables[0].Rows.Count != 0 && !buscar(cod, dataGridView1))
            {
                dataGridView1.Rows.Insert(dataGridView1.RowCount, ds.Tables[0].Rows[0][1].ToString(), ds.Tables[0].Rows[0][2].ToString(), ds.Tables[0].Rows[0][3].ToString(), ds.Tables[0].Rows[0][0].ToString());
            }
            else
            {
                MessageBox.Show("Encargado no registrado o ya esta en la tabla");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void limpiar()
        {
            textBoxCod.Text = "";
            textBoxCosto.Text = "";
            textBoxEnca.Text = "";
            txtdireccion.Text = "";
            dataGridView1.Rows.Clear();
            tblcompras.Rows.Clear();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            if (tblcompras.Rows.Count !=0 &&
                dataGridView1.Rows.Count != 0 &&
                txtdireccion.Text.Trim().Length > 5 &&
                textBoxCosto.Text.Trim().Length >0) { 
            int cod = new Random().Next(0, 1000);
            string valor = "";
            DateTime fecha = (dateTimePicker1.Value);
            string sql = "Insert into instituciones_financieras.mantenimiento " +
                 "(id_mantenimiento,fecha,  costo,detalle)" +
                " values('" + cod + "','" +fecha + "','" +Convert.ToDecimal( textBoxCosto.Text) + "','" + txtdireccion.Text + "')";
            string msj = Utilidades.Registrar(sql);
            //registro tabla activo_mant
            
            for (int fila = 0; fila < tblcompras.Rows.Count; fila++)
            {
                 valor = tblcompras.Rows[fila].Cells["codigo"].Value.ToString();
                sql = "Insert into instituciones_financieras.activo_mant" +
                "(idactivo_mant, mant_activo)" +
                "values('"+ valor+"','"+cod+"')";
                msj = Utilidades.Registrar(sql);
            }
            for (int fila = 0; fila < dataGridView1.Rows.Count; fila++)
            {
                valor = dataGridView1.Rows[fila].Cells[3].Value.ToString();
                sql = "Insert into instituciones_financieras.mant_encar" +
                "(idmant_encar, encarg_mant)" +
                "values('" + cod + "','" + Convert.ToInt32(valor) + "')";
                msj = Utilidades.Registrar(sql);

            }
            
    
            MessageBox.Show(msj);
            if (msj.Equals("Registro Completado"))
            {
                if (this.tipo == 0)
                {
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Error al registrar"+msj);
                }
            }
            }
            else
            {
                MessageBox.Show("Error, campos incompletos!" );
            }
        }
    }
    }
