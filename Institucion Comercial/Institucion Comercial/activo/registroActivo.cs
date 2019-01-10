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
    public partial class registroActivo : Form
    {
        public registroActivo()
        {
            InitializeComponent();
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
            
            registroTipo.Show();
            

        }

        private void button4_Click(object sender, EventArgs e)//registro sucursal
        {
            registroInstitucion registroInst = new registroInstitucion();

            registroInst.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            registroDepartamento registroDepartamento = new registroDepartamento();
            registroDepartamento.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        } 
    }
}
