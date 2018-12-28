namespace Institucion_Comercial.comercial
{
    partial class venta_credito
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
            this.label15 = new System.Windows.Forms.Label();
            this.txtPrima = new System.Windows.Forms.TextBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.comboCuota = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCuota = new System.Windows.Forms.TextBox();
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
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(604, 428);
            this.txtTotal.Size = new System.Drawing.Size(101, 20);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(214, 431);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "Prima ($)";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // txtPrima
            // 
            this.txtPrima.Enabled = false;
            this.txtPrima.Location = new System.Drawing.Point(268, 428);
            this.txtPrima.Name = "txtPrima";
            this.txtPrima.Size = new System.Drawing.Size(111, 20);
            this.txtPrima.TabIndex = 39;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(81, 499);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(120, 23);
            this.btnFinalizar.TabIndex = 40;
            this.btnFinalizar.Text = "Finalizar Compra";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // comboCuota
            // 
            this.comboCuota.FormattingEnabled = true;
            this.comboCuota.Location = new System.Drawing.Point(46, 428);
            this.comboCuota.Name = "comboCuota";
            this.comboCuota.Size = new System.Drawing.Size(155, 21);
            this.comboCuota.TabIndex = 42;
            this.comboCuota.SelectedIndexChanged += new System.EventHandler(this.comboCuota_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 431);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "Plan";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(394, 431);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 44;
            this.label17.Text = "Cuota";
            // 
            // txtCuota
            // 
            this.txtCuota.Enabled = false;
            this.txtCuota.Location = new System.Drawing.Point(435, 428);
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.Size = new System.Drawing.Size(111, 20);
            this.txtCuota.TabIndex = 45;
            // 
            // venta_credito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 571);
            this.Controls.Add(this.txtCuota);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.comboCuota);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.txtPrima);
            this.Controls.Add(this.label15);
            this.Name = "venta_credito";
            this.Text = "venta_credito";
            this.Load += new System.EventHandler(this.venta_credito_Load);
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
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.txtPrima, 0);
            this.Controls.SetChildIndex(this.btnFinalizar, 0);
            this.Controls.SetChildIndex(this.comboCuota, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            this.Controls.SetChildIndex(this.txtCuota, 0);
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPrima;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.ComboBox comboCuota;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCuota;
    }
}