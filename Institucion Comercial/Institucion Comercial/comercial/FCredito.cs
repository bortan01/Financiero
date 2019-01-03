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
    public partial class FCredito : Form
    {
        string idVenta = "";
        public FCredito(string id)
        {
            InitializeComponent();
            this.idVenta = id;
        }

        private void FCredito_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DetalleCredito.DataTable1' Puede moverla o quitarla según sea necesario.
            //this.DataTable1TableAdapter.Fill(this.DetalleCredito.DataTable1);
            ReportParameter p1 = new ReportParameter("idVenta", idVenta);
            reportViewer1.LocalReport.SetParameters(p1);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
