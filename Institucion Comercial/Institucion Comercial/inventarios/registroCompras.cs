using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Institucion_Comercial.inventarios
{
    public partial class registroCompras : Form
    {
        public registroCompras()
        {
            InitializeComponent();
            tblcompras.Columns[0].Width = 150;
            tblcompras.Columns[1].Width = 300;
            tblcompras.Columns[2].Width = 150;
            tblcompras.Columns[3].Width = 75;
            tblcompras.Columns[4].Width = 75;
            tblcompras.Columns[5].Width = 100;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
