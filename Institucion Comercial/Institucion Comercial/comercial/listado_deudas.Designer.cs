namespace Institucion_Comercial.comercial
{
    partial class listado_deudas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPagar = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTADO DE CREDITOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(257, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CLIENTE : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(340, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(729, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.c2,
            this.c3,
            this.c6,
            this.c4,
            this.c7,
            this.c5,
            this.c8,
            this.Column1});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 125);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(993, 241);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(31, 384);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 23);
            this.btnPagar.TabIndex = 5;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.button2_Click);
            // 
            // c1
            // 
            this.c1.HeaderText = "Código de Venta";
            this.c1.Name = "c1";
            // 
            // c2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.c2.DefaultCellStyle = dataGridViewCellStyle2;
            this.c2.HeaderText = "Nombre Cliente";
            this.c2.Name = "c2";
            this.c2.Width = 172;
            // 
            // c3
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.c3.DefaultCellStyle = dataGridViewCellStyle3;
            this.c3.HeaderText = "Estado";
            this.c3.Name = "c3";
            // 
            // c6
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.c6.DefaultCellStyle = dataGridViewCellStyle4;
            this.c6.HeaderText = "Cuota";
            this.c6.Name = "c6";
            // 
            // c4
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.c4.DefaultCellStyle = dataGridViewCellStyle5;
            this.c4.HeaderText = "Mora Acumulada";
            this.c4.Name = "c4";
            // 
            // c7
            // 
            this.c7.HeaderText = "Capital Acumulado";
            this.c7.Name = "c7";
            // 
            // c5
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.c5.DefaultCellStyle = dataGridViewCellStyle6;
            this.c5.HeaderText = "Total";
            this.c5.Name = "c5";
            // 
            // c8
            // 
            this.c8.HeaderText = "Saldo Actual";
            this.c8.Name = "c8";
            // 
            // Column1
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column1.HeaderText = "Fecha Vencimiento";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // listado_deudas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 450);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "listado_deudas";
            this.Text = "listado_deudas";
            this.Load += new System.EventHandler(this.listado_deudas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c6;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4;
        private System.Windows.Forms.DataGridViewTextBoxColumn c7;
        private System.Windows.Forms.DataGridViewTextBoxColumn c5;
        private System.Windows.Forms.DataGridViewTextBoxColumn c8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}