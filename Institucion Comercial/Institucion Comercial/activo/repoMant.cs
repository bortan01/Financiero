using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace Institucion_Comercial.activo
{
    public partial class repoMant : Form
    {
        String cod;
        public repoMant(String cod)
        {
            InitializeComponent();
            this.cod = cod;
        }

        private void repoMant_Load(object sender, EventArgs e)
        {

            //this.DataTableActivoTableAdapter.Fill(this.DataSetActivo.DataTableActivo);
            this.dataTableManttenimineto1.Fill(this.dataSetMant1.DataTablemantzdfd);
            this.encaTableAdapter1.Fill(this.dataSetMant1.enca);
            this.activosTableAdapter1.Fill(this.dataSetMant1.activos);
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetmantenimiepto", this.dataSetMant1.DataTablemantzdfd.DefaultView));
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("encas", this.dataSetMant1.enca.DefaultView));
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("act", this.dataSetMant1.activos.DefaultView));
            ReportParameter p1 = new ReportParameter("id", cod);
            reportViewer1.LocalReport.SetParameters(p1);
            this.reportViewer1.RefreshReport();
        }
    }
}
