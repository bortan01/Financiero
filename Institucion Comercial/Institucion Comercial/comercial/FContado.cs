using Microsoft.Reporting.WinForms;
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
    public partial class FContado : Form
        
    {
        string idVenta = "";
        public FContado(String id)
        {
            InitializeComponent();
            this.idVenta = id;
        }

        private void FContado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DetalleContado.DataTable1' Puede moverla o quitarla según sea necesario.
            ReportParameter p1 = new ReportParameter("id_venta", idVenta);
            reportViewer1.LocalReport.SetParameters(p1);

            this.DataTable1TableAdapter.Fill(this.DetalleContado.DataTable1);
            this.reportViewer1.RefreshReport();
        }
    }
}
