namespace Institucion_Comercial.inventarios
{
    partial class reporteCompras
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ComprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetInventario = new Institucion_Comercial.inventarios.DataSetInventario();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ComprasTableAdapter = new Institucion_Comercial.inventarios.DataSetInventarioTableAdapters.ComprasTableAdapter();
            this.txtinicio = new System.Windows.Forms.DateTimePicker();
            this.txtfin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ComprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // ComprasBindingSource
            // 
            this.ComprasBindingSource.DataMember = "Compras";
            this.ComprasBindingSource.DataSource = this.DataSetInventario;
            // 
            // DataSetInventario
            // 
            this.DataSetInventario.DataSetName = "DataSetInventario";
            this.DataSetInventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ComprasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Institucion_Comercial.inventarios.reporteCompras.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 117);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(594, 333);
            this.reportViewer1.TabIndex = 0;
            // 
            // ComprasTableAdapter
            // 
            this.ComprasTableAdapter.ClearBeforeFill = true;
            // 
            // txtinicio
            // 
            this.txtinicio.Location = new System.Drawing.Point(41, 62);
            this.txtinicio.Name = "txtinicio";
            this.txtinicio.Size = new System.Drawing.Size(200, 20);
            this.txtinicio.TabIndex = 1;
            // 
            // txtfin
            // 
            this.txtfin.Location = new System.Drawing.Point(296, 62);
            this.txtfin.Name = "txtfin";
            this.txtfin.Size = new System.Drawing.Size(200, 20);
            this.txtfin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "De";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "A";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reporteCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfin);
            this.Controls.Add(this.txtinicio);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reporteCompras";
            this.Text = "reporteCompras";
            this.Load += new System.EventHandler(this.reporteCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ComprasBindingSource;
        private DataSetInventario DataSetInventario;
        private DataSetInventarioTableAdapters.ComprasTableAdapter ComprasTableAdapter;
        private System.Windows.Forms.DateTimePicker txtinicio;
        private System.Windows.Forms.DateTimePicker txtfin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}