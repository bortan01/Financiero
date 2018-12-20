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

namespace Institucion_Comercial.plantillas
{
    public partial class consultas : Form
    {
        public consultas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public DataSet LlenarDAtaGV(String tabla) {
            DataSet Ds;
            String sql = string.Format("SELECT * FROM instituciones_financieras." +tabla);
            Ds = Utilidades.Ejecutar(sql);

            return Ds;

        } 

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            else {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
 