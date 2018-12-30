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
    public partial class ReporteInventario : Form
    {
        public ReporteInventario()
        {
            InitializeComponent();
        }

        private void ReporteInventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetInventario.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.DataSetInventario.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
