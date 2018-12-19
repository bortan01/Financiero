namespace Institucion_Comercial
{
    partial class RegistrarEmpleado
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtzona = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdui = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnivel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(152, 66);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(188, 20);
            this.txtid.TabIndex = 13;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(152, 96);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(188, 20);
            this.txtnombre.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(152, 126);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(188, 20);
            this.txtapellido.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellido";
            // 
            // txtzona
            // 
            this.txtzona.Location = new System.Drawing.Point(152, 155);
            this.txtzona.Name = "txtzona";
            this.txtzona.Size = new System.Drawing.Size(188, 20);
            this.txtzona.TabIndex = 2;
            this.txtzona.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Zona";
            // 
            // txtdui
            // 
            this.txtdui.Location = new System.Drawing.Point(152, 187);
            this.txtdui.Name = "txtdui";
            this.txtdui.Size = new System.Drawing.Size(188, 20);
            this.txtdui.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "DUI";
            // 
            // txtcontra
            // 
            this.txtcontra.Location = new System.Drawing.Point(152, 217);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(188, 20);
            this.txtcontra.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Contraseña";
            // 
            // txtnivel
            // 
            this.txtnivel.Location = new System.Drawing.Point(152, 249);
            this.txtnivel.Name = "txtnivel";
            this.txtnivel.Size = new System.Drawing.Size(188, 20);
            this.txtnivel.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nivel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(112, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Registrar Empleado";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(75, 292);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(133, 23);
            this.btnguardar.TabIndex = 15;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(215, 291);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(125, 23);
            this.btncancelar.TabIndex = 16;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // RegistrarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 359);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtnivel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdui);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtzona);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Name = "RegistrarEmpleado";
            this.Text = "RegistrarEmpleado";
            this.Load += new System.EventHandler(this.RegistrarEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtzona;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdui;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcontra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnivel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncancelar;
    }
}