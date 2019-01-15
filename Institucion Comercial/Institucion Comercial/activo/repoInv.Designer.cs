namespace Institucion_Comercial.activo
{
    partial class repoInv
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTableActivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetActivo = new Institucion_Comercial.activo.DataSetActivo();
            this.DataTableActivoTableAdapter = new Institucion_Comercial.activo.DataSetActivoTableAdapters.DataTableActivoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableActivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetActivo)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTableActivoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Institucion_Comercial.activo.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 86);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1126, 474);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataTableActivoBindingSource
            // 
            this.DataTableActivoBindingSource.DataMember = "DataTableActivo";
            this.DataTableActivoBindingSource.DataSource = this.DataSetActivo;
            // 
            // DataSetActivo
            // 
            this.DataSetActivo.DataSetName = "DataSetActivo";
            this.DataSetActivo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTableActivoTableAdapter
            // 
            this.DataTableActivoTableAdapter.ClearBeforeFill = true;
            // 
            // repoInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 572);
            this.Controls.Add(this.reportViewer1);
            this.Name = "repoInv";
            this.Text = "repoInv";
            this.Load += new System.EventHandler(this.repoInv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTableActivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetActivo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTableActivoBindingSource;
        private DataSetActivo DataSetActivo;
        private DataSetActivoTableAdapters.DataTableActivoTableAdapter DataTableActivoTableAdapter;
    }
}