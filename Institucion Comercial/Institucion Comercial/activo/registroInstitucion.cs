﻿using System;
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
    public partial class registroInstitucion : Form
    {
        public int tipo = 0;
        public registroInstitucion()
        {
            InitializeComponent();
            llenarId();
        }

        private void registroInstitucion_Load(object sender, EventArgs e)
        {

        }

        public void llenarId()
        {           
            try
            {
                int codigo = 0;
                string cmd = String.Format("SELECT CASE WHEN (SELECT COUNT(1) FROM instituciones_financieras.sucursal ) = 0 THEN 1 ELSE IDENT_CURRENT('instituciones_financieras.sucursal ') + 1 END AS IdActual; " );
                DataSet ds = Utilidades.Ejecutar(cmd);
                codigo = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString().Trim());
                textCodigo.Text = calcularCod(codigo);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }


        private String calcularCod(int n)
        {
           
            if (n / 10 == 0)
                return  "00" + n;
            else
                if (n / 100 > 0)
                return "" + n;
            return  "0" + n;
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = textNombre.Text.Trim();
            string codigo = textCodigo.Text.Trim();
            string direc = textDireccion.Text.Trim();
            string tel = textTelefono.Text.Trim();

            string sql = "Insert into instituciones_financieras.tipo_activo " +
                 "(nombre, id_clasificacion, correlativo)" +
                " values('" + nombre + "','" + codigo + "','" + direc + "')";
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
                    textNombre.Text = "";
                   
                }

            }
        }
    }
}
