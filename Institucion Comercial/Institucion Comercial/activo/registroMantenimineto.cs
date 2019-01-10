using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Institucion_Comercial.activo
{
    public partial class registroMantenimineto : Form
    {
        public registroMantenimineto()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            registroEncargadoMantenimineto registroEncargado = new registroEncargadoMantenimineto();
            registroEncargado.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
