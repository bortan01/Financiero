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
    }
}
