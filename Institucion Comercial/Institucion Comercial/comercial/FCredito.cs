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
    public partial class FCredito : Form
    {
        public FCredito()
        {
            InitializeComponent();
        }

        private void FCredito_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DetalleCredito.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.DetalleCredito.DataTable1);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
