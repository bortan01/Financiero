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

namespace Institucion_Comercial.activo
{
    public partial class repoInv : Form
    {
        public repoInv()
        {
            InitializeComponent();
            cargarCombo();
        }

        private void repoInv_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetActivo.DataTableActivo' Puede moverla o quitarla según sea necesario.
            this.DataTableActivoTableAdapter.Fill(this.DataSetActivo.DataTableActivo);

            this.reportViewer1.RefreshReport();
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
    }
}
