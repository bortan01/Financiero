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

namespace Institucion_Comercial.inventarios
{
    public partial class reporteCompras : Form
    {
        public reporteCompras()
        {
            InitializeComponent();
        }

        private void reporteCompras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetInventario.Compras' Puede moverla o quitarla según sea necesario.
            try
            {
                this.ComprasTableAdapter.Fill(this.DataSetInventario.Compras);
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportParameter p1 = new ReportParameter("fechaInicio",txtinicio.Value.Date.ToString());
            ReportParameter p2 = new ReportParameter("fechaFin", txtfin.Value.Date.ToString());
            reportViewer1.LocalReport.SetParameters(p1);
            reportViewer1.LocalReport.SetParameters(p2);
            reportViewer1.RefreshReport();
        }
    }
}
