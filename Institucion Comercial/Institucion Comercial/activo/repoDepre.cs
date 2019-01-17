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
    public partial class repoDepre : Form
    {
        String cod, tipo, sucu, depto, enca, valor, fecha, estado;
        String[] anio= new string[20];
        int na;
        public repoDepre(int na, String[] anio, String cod, String tipo, String sucu, String depto, String enca, String valor, String fecha, String estado)
        {
            InitializeComponent();
            this.cod = cod;
            this.tipo = tipo;
            this.depto = depto;
            this.sucu = sucu;
            this.enca = enca;
            this.valor = valor;
            this.fecha = fecha;
            this.estado = estado;
            this.anio = anio;
            this.na = na;
        }

        private void repoDepre_Load(object sender, EventArgs e)
        {
            ReportParameter p1 = new ReportParameter("codActivo", cod);
            ReportParameter p2 = new ReportParameter("tipo", tipo);
            ReportParameter p3 = new ReportParameter("sucu", sucu);
            ReportParameter p4 = new ReportParameter("depto", depto);
            ReportParameter p5 = new ReportParameter("enca", enca);
            ReportParameter p6 = new ReportParameter("valor", valor);
            ReportParameter p7 = new ReportParameter("fecha", fecha);
            ReportParameter p8 = new ReportParameter("estado", estado);

            if (na == 2)
            {
                this.reportViewer2.Hide();
                this.reportViewer3.Hide();

                ReportParameter p9 = new ReportParameter("anio1", anio[0]);
                ReportParameter p0 = new ReportParameter("anio2", anio[1]);
                reportViewer1.LocalReport.SetParameters(p1);
                reportViewer1.LocalReport.SetParameters(p2);
                reportViewer1.LocalReport.SetParameters(p3);
                reportViewer1.LocalReport.SetParameters(p4);
                reportViewer1.LocalReport.SetParameters(p5);
                reportViewer1.LocalReport.SetParameters(p6);
                reportViewer1.LocalReport.SetParameters(p7);
                reportViewer1.LocalReport.SetParameters(p8);
                reportViewer1.LocalReport.SetParameters(p9);
                reportViewer1.LocalReport.SetParameters(p0);
                this.reportViewer1.RefreshReport();

                this.reportViewer1.RefreshReport();
            }
            if (na == 4)
            {
                this.reportViewer3.Hide();
                this.reportViewer1.Hide();               
                ReportParameter p9 = new ReportParameter("anio1", anio[0]);
                ReportParameter p0 = new ReportParameter("anio2", anio[1]);
                ReportParameter p10 = new ReportParameter("anio3", anio[2]);
                ReportParameter p11 = new ReportParameter("anio4", anio[3]);
                reportViewer2.LocalReport.SetParameters(p1);
                reportViewer2.LocalReport.SetParameters(p2);
                reportViewer2.LocalReport.SetParameters(p3);
                reportViewer2.LocalReport.SetParameters(p4);
                reportViewer2.LocalReport.SetParameters(p5);
                reportViewer2.LocalReport.SetParameters(p6);
                reportViewer2.LocalReport.SetParameters(p7);
                reportViewer2.LocalReport.SetParameters(p8);
                reportViewer2.LocalReport.SetParameters(p9);
                reportViewer2.LocalReport.SetParameters(p0);
                reportViewer2.LocalReport.SetParameters(p10);
                reportViewer2.LocalReport.SetParameters(p11);
                this.reportViewer2.RefreshReport();
                this.reportViewer2.RefreshReport();
            }
            if (na == 5)
            {
                this.reportViewer2.Hide();
                this.reportViewer1.Hide();
                ReportParameter p9 = new ReportParameter("anio1", anio[0]);
                ReportParameter p0 = new ReportParameter("anio2", anio[1]);
                ReportParameter p10 = new ReportParameter("anio3", anio[2]);
                ReportParameter p11 = new ReportParameter("anio4", anio[3]);
                ReportParameter p12 = new ReportParameter("anio5", anio[4]);
                reportViewer3.LocalReport.SetParameters(p1);
                reportViewer3.LocalReport.SetParameters(p2);
                reportViewer3.LocalReport.SetParameters(p3);
                reportViewer3.LocalReport.SetParameters(p4);
                reportViewer3.LocalReport.SetParameters(p5);
                reportViewer3.LocalReport.SetParameters(p6);
                reportViewer3.LocalReport.SetParameters(p7);
                reportViewer3.LocalReport.SetParameters(p8);
                reportViewer3.LocalReport.SetParameters(p9);
                reportViewer3.LocalReport.SetParameters(p0);
                reportViewer3.LocalReport.SetParameters(p10);
                reportViewer3.LocalReport.SetParameters(p11);
                reportViewer3.LocalReport.SetParameters(p12);
                this.reportViewer3.RefreshReport();
                this.reportViewer3.RefreshReport();
            }

            /* }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }*/

            this.reportViewer3.RefreshReport();
        }
    }
}
