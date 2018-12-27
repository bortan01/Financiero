using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Institucion_Comercial.comercial
{
    public partial class venta_credito : Venta
    {
        public venta_credito()
        {
            InitializeComponent();
        }
        public static double totalPrima;
        private void button3_Click(object sender, EventArgs e)
        {
            if (cont_fila >0)
            {
                totalPrima = total * 0.25;
                txtPrima.Text = totalPrima.ToString();
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
