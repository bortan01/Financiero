namespace Institucion_Comercial.comercial
{
    partial class venta_contado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Text = "Juan PedroTenorio Arreoza";
            // 
            // button3
            // 
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(28, 420);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 23);
            this.button5.TabIndex = 38;
            this.button5.Text = "Finalizar Compra";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // venta_contado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 474);
            this.Controls.Add(this.button5);
            this.Name = "venta_contado";
            this.Text = "venta_contado";
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.txtBuscarCliente, 0);
            this.Controls.SetChildIndex(this.txtDuiCliente, 0);
            this.Controls.SetChildIndex(this.txtNombreCliente, 0);
            this.Controls.SetChildIndex(this.txtNitCliente, 0);
            this.Controls.SetChildIndex(this.txtTelefonoCliente, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.txtEmpleado, 0);
            this.Controls.SetChildIndex(this.txtBuscarProducto, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.t1, 0);
            this.Controls.SetChildIndex(this.t2, 0);
            this.Controls.SetChildIndex(this.t3, 0);
            this.Controls.SetChildIndex(this.t4, 0);
            this.Controls.SetChildIndex(this.txtCantidad, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.txtTotal, 0);
            this.Controls.SetChildIndex(this.button5, 0);
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
    }
}