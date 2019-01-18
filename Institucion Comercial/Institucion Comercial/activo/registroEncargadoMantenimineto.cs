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
    public partial class registroEncargadoMantenimineto : Form
    {
        int tipo = 0;
        public registroEncargadoMantenimineto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text.Trim() != "" &&
                textBoxCorreo.Text.Trim() != "" &&
                textBoxDireccion.Text.Trim() != "" &&
                textBoxTelefono.Text.Trim() != ""  )
            {
                
                int id= new Random().Next(0, 1000);
                string sql = "Insert into instituciones_financieras.encargado " +
                     "(id_encargado, nombre, direccion, telefono , correo)" +
                    " values('" + id+ "','" + textBoxNombre.Text.Trim() + "','" + textBoxDireccion.Text.Trim() + "','" + textBoxTelefono.Text.Trim() + "','" + textBoxCorreo.Text.Trim() + "')";
                string msj = Utilidades.Registrar(sql);
                MessageBox.Show(msj);
                if (msj.Equals("Registro Completado"))
                {
                    if (this.tipo == 0)
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                       
                    }

                }
            }
        }
    }
}
