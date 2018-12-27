namespace Institucion_Comercial.inventarios
{
    partial class detalleCompra
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
            this.tablaProductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fotocomprobante = new System.Windows.Forms.PictureBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotocomprobante)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaProductos
            // 
            this.tablaProductos.AllowUserToAddRows = false;
            this.tablaProductos.AllowUserToDeleteRows = false;
            this.tablaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProductos.Location = new System.Drawing.Point(12, 237);
            this.tablaProductos.Name = "tablaProductos";
            this.tablaProductos.RowHeadersVisible = false;
            this.tablaProductos.Size = new System.Drawing.Size(571, 257);
            this.tablaProductos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Detalles:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(399, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Comprobante";
            // 
            // fotocomprobante
            // 
            this.fotocomprobante.Location = new System.Drawing.Point(331, 39);
            this.fotocomprobante.Name = "fotocomprobante";
            this.fotocomprobante.Size = new System.Drawing.Size(252, 182);
            this.fotocomprobante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotocomprobante.TabIndex = 6;
            this.fotocomprobante.TabStop = false;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(102, 17);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.ReadOnly = true;
            this.txtcodigo.Size = new System.Drawing.Size(154, 20);
            this.txtcodigo.TabIndex = 7;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(102, 79);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.ReadOnly = true;
            this.txtfecha.Size = new System.Drawing.Size(154, 20);
            this.txtfecha.TabIndex = 8;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(102, 143);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(154, 20);
            this.txttotal.TabIndex = 9;
            // 
            // detalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 506);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.fotocomprobante);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaProductos);
            this.Name = "detalleCompra";
            this.Text = "detalleCompra";
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotocomprobante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox fotocomprobante;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.TextBox txttotal;
    }
}