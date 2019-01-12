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
    public partial class FacturaPago : Form
    {
        public FacturaPago()
        {
            InitializeComponent();
        }

        private void FacturaPago_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet2.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.DataSet2.DataTable1);
            this.reportViewer1.RefreshReport();
        }
    }
}
