using Institucion_Comercial.inventarios;
using Institucion_Comercial.proveedores;
using Institucion_Comercial.activo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Institucion_Comercial.Clientes;
using Institucion_Comercial.comercial;

namespace Institucion_Comercial
{
    public partial class ContenedorPrincipal : Form
    {
        private int childFormNumber = 0;

        public ContenedorPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            if (Login.codigo=="admin")
            {
                ocultar();
            }
            else
            {
                mostrar();
            }
            
        }

        public void ocultar()
        {
            this.menuActivo.Visible = false;
            this.menuClientes.Visible = false;
            this.menuProductos.Visible = false;
            this.menuPagos.Visible = false;
            this.menuProveedores.Visible = false;
            this.menuVentas.Visible = false;
        }

        public void mostrar()
        {
            this.menuActivo.Visible = true;
            this.menuClientes.Visible = true;
            this.menuProductos.Visible = true;
            this.menuPagos.Visible = true;
            this.menuProveedores.Visible = true;
            this.menuVentas.Visible = true;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarEmpleado re = new RegistrarEmpleado();
            re.MdiParent = this;
            re.Show();
        }

        private void ContenedorPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ContenedorPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            registroProveedores rp = new registroProveedores();
            rp.MdiParent = this;
            rp.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaProveedores cp = new consultaProveedores();
            cp.MdiParent = this;
            cp.Show();
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            registroProductos rp = new registroProductos(1);
            rp.MdiParent = this;
            rp.Show();
        }

        private void registrarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registroCompras rc = new registroCompras();
            rc.MdiParent = this;
            rc.Show();
        }

        private void consultarInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultarInventario ci = new consultarInventario();
            ci.MdiParent = this;
            ci.Show();
        }

        private void consultarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaCompras ci = new consultaCompras();
            ci.MdiParent = this;
            ci.Show();
        }

        private void registrarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            registroActivo ra = new registroActivo();
            ra.MdiParent = this;
            ra.Show();
        }

        private void registrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            registroClientes rc = new registroClientes();
            rc.MdiParent = this;
            rc.Show();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            consultarClientes cc = new consultarClientes();
            cc.MdiParent = this;
            cc.Show();
        }

        private void reporteDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteInventario ri = new ReporteInventario();
            ri.MdiParent = this;
            ri.Show();
        }

        private void reporteDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reporteCompras rc = new reporteCompras();
            rc.MdiParent = this;
            rc.Show();
        }

        private void manteniminetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registroMantenimineto rm = new registroMantenimineto();
            rm.MdiParent = this;
            rm.Show();
        }

        private void contadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            venta_contado vc = new venta_contado();
            vc.MdiParent = this;
            vc.Show();

        }

        private void creditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            venta_credito rc = new venta_credito();
            rc.MdiParent = this;
            rc.Show();
        }

        private void realizarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listado_deudas rc = new listado_deudas();
            rc.MdiParent = this;
            rc.Show();
        }

        private void incobrablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrar_incobrables rc = new mostrar_incobrables();
            rc.MdiParent = this;
            rc.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inventarioActivo ia = new inventarioActivo();
            ia.MdiParent = this;
            ia.Show();
        }

        private void depreciacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            depreciacion dp = new depreciacion();
            dp.MdiParent = this;
            dp.Show();
        }

        private void inventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            repoInv ri = new repoInv();
            ri.MdiParent = this;
            ri.Show();
        }

        private void depreciacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listDepre ld = new listDepre();
            ld.MdiParent = this;
            ld.Show();
        }
    }
}
