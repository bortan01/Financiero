namespace Institucion_Comercial.activo
{
    partial class registroInstitucion
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
            this.label1 = new System.Windows.Forms.Label();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(139, 31);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.ReadOnly = true;
            this.textCodigo.Size = new System.Drawing.Size(275, 20);
            this.textCodigo.TabIndex = 1;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(139, 71);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(275, 20);
            this.textNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(139, 153);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(275, 20);
            this.textTelefono.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefono";
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(139, 113);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(275, 20);
            this.textDireccion.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Direccion";
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(112, 196);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(75, 23);
            this.buttonRegistrar.TabIndex = 8;
            this.buttonRegistrar.Text = "REGISTRAR";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(271, 196);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // registroInstitucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 244);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.label1);
            this.Name = "registroInstitucion";
            this.Text = "Registro Sucursal";
            this.Load += new System.EventHandler(this.registroInstitucion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}