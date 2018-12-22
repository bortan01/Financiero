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
    public partial class SeleccionarProducto : plantillas.consultas
    {
        public SeleccionarProducto()
        {
            InitializeComponent();
        }

        private void consulta_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textConsulta.Text.Trim()) == false)
            {
                //MessageBox.Show("va por aqui");
                try
                {
                    DataSet ds;
                    String sql = "select * from instituciones_financieras.producto where nombre like ('%" + textConsulta.Text + "%')";
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

        private void SeleccionarProducto_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LlenarDAtaGV("producto").Tables[0];
        }
    }
}
