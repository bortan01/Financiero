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
    public partial class SeleccionarCliente : plantillas.consultas
    {
        public SeleccionarCliente()
        {
            InitializeComponent();
        }

        private void SeleccionarCliente_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LlenarDAtaGV("cliente").Tables[0];
        }

            private void button3_Click_1(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(consulta.Text.Trim()) == false)
            {
                //MessageBox.Show("va por aqui");
                try
                {
                    DataSet ds;
                    String sql = "select * from instituciones_financieras.cliente where nombre like ('%"+textBox1.Text+"%')";
                  // MessageBox.Show(sql);

                   ds = Utilidades.Ejecutar(sql);
                   dataGridView1.DataSource = ds.Tables[0];
                }
                catch (Exception error)
                {
                    MessageBox.Show("ha ocurrido un error " + error.Message);
                }
            }
        }
    }
}
