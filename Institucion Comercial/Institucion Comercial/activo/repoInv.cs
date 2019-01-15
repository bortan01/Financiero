using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Institucion_Comercial.activo
{
    public partial class repoInv : Form
    {
        public repoInv()
        {
            InitializeComponent();
        }

        private void repoInv_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetActivo.DataTableActivo' Puede moverla o quitarla según sea necesario.
            this.DataTableActivoTableAdapter.Fill(this.DataSetActivo.DataTableActivo);

            this.reportViewer1.RefreshReport();
        }
    }
}
