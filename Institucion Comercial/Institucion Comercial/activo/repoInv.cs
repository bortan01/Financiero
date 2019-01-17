using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiLibreria;
using Microsoft.Reporting.WinForms;

namespace Institucion_Comercial.activo
{
    public partial class repoInv : Form
    {
        public repoInv()
        {
            InitializeComponent();
            cargarCombo();
            this.reportViewer2.Show();
            this.reportViewer3.Hide();
            comboBoxSucursal.Enabled=false;
            comboBoxDepartamento.Enabled = false;
            comboBoxTipo.Enabled = false;
        }

        private void repoInv_Load(object sender, EventArgs e)
        {
            this.DataTableActivoTableAdapter.Fill(this.DataSetActivo.DataTableActivo);

            

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", this.DataSetActivo.sucursal.DefaultView));
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", this.DataSetActivo.DataTableActivo.DefaultView));
            this.reportViewer3.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", this.DataSetActivo.DataTableActivo.DefaultView));
            ReportParameter p1 = new ReportParameter("sucursal", "002");
            this.reportViewer1.LocalReport.SetParameters(p1);
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();

            // TODO: esta línea de código carga datos en la tabla 'DataSetActivo.DataTableActivo' Puede moverla o quitarla según sea necesario.

            this.reportViewer3.RefreshReport();
        }

        public void cargarCombo()
        {//para tipo
            DataTable dt = Utilidades.LlenarCombos("SELECT instituciones_financieras.tipo_activo.nombre,instituciones_financieras.tipo_activo.id_tipo FROM instituciones_financieras.tipo_activo");
            comboBoxTipo.DataSource = dt;
            comboBoxTipo.ValueMember = "id_tipo";
            comboBoxTipo.DisplayMember = "nombre";
            DataRow dt2r = dt.NewRow();
            dt2r["id_tipo"] = "0";
            dt2r["nombre"] = "Tipo";
            dt.Rows.InsertAt(dt2r, 0);
            //sucursal
            dt = Utilidades.LlenarCombos("Select * from instituciones_financieras.sucursal");
            DataRow dtr = dt.NewRow();
            dtr["id_sucursal"] = "0";
            dtr["nombre"] = "Sucursal";
            dt.Rows.InsertAt(dtr, 0);
            comboBoxSucursal.DataSource = dt;
            comboBoxSucursal.ValueMember = "id_sucursal";
            comboBoxSucursal.DisplayMember = "nombre";
           

        }
        public void cargarComboDepto(String s)
        {
            try
            {//departamento
                DataTable dt = Utilidades.LlenarCombos("Select * from instituciones_financieras.departamento WHERE instituciones_financieras.departamento.id_sucursal = " + s);
                comboBoxDepartamento.DataSource = dt;
                comboBoxDepartamento.ValueMember = "id_departamento";
                comboBoxDepartamento.DisplayMember = "nombre";
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
            }
        }

        private void comboBoxSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSucursal.SelectedValue.ToString() == "0")
            {
                comboBoxDepartamento.Enabled = false;
                this.reportViewer2.RefreshReport();
                this.reportViewer2.Show();
                this.reportViewer1.Hide();
                this.reportViewer3.Hide();

            }
            else {
            comboBoxDepartamento.Enabled = true;
            cargarComboDepto(comboBoxSucursal.SelectedValue + "");
            ReportParameter p1 = new ReportParameter("sucursal", comboBoxSucursal.SelectedValue+"");
            reportViewer1.LocalReport.SetParameters(p1);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.Show();
            this.reportViewer2.Hide();
            this.reportViewer3.Hide();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                this.reportViewer2.Show();
                this.reportViewer2.RefreshReport();
                this.reportViewer1.Hide();
                this.reportViewer3.Hide();
                comboBoxSucursal.Enabled = false;
                comboBoxDepartamento.Enabled = false;
                comboBoxTipo.Enabled = false;
            }
            else
            {
                comboBoxSucursal.Enabled = true;
                
                comboBoxTipo.Enabled = true;
                this.reportViewer1.Show();
                this.reportViewer1.RefreshReport();
                this.reportViewer2.Hide();
                this.reportViewer3.Hide();
            }
        }

        private void comboBoxDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReportParameter p1 = new ReportParameter("sucursal", comboBoxSucursal.SelectedValue + "");
            ReportParameter p2 = new ReportParameter("depto", comboBoxDepartamento.SelectedValue + "");
            reportViewer3.LocalReport.SetParameters(p1);
            reportViewer3.LocalReport.SetParameters(p2);
            this.reportViewer3.RefreshReport();
            this.reportViewer3.Show();

            this.reportViewer2.Hide();
            this.reportViewer1.Hide();
        }
    }
}
