namespace Institucion_Comercial.activo
{
    partial class registroTipo
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
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbClasificacion = new System.Windows.Forms.ComboBox();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(116, 75);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(178, 20);
            this.textNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo";
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(116, 27);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.ReadOnly = true;
            this.textCodigo.Size = new System.Drawing.Size(178, 20);
            this.textCodigo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Clasificacion";
            // 
            // cbClasificacion
            // 
            this.cbClasificacion.FormattingEnabled = true;
            this.cbClasificacion.Location = new System.Drawing.Point(116, 134);
            this.cbClasificacion.Name = "cbClasificacion";
            this.cbClasificacion.Size = new System.Drawing.Size(178, 21);
            this.cbClasificacion.TabIndex = 5;
            this.cbClasificacion.SelectedIndexChanged += new System.EventHandler(this.cbClasificacion_SelectedIndexChanged_1);
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(56, 184);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(75, 23);
            this.buttonRegistrar.TabIndex = 6;
            this.buttonRegistrar.Text = "REGISTRAR";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(228, 184);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // registroTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 229);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.cbClasificacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label1);
            this.Name = "registroTipo";
            this.Text = "registroTipo";
            this.Load += new System.EventHandler(this.registroTipo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbClasificacion;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}