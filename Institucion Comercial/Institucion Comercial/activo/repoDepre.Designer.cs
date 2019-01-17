namespace Institucion_Comercial.activo
{
    partial class repoDepre
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
            this.DataSetActivo = new Institucion_Comercial.activo.DataSetActivo();
            this.DataTableActivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTableActivoTableAdapter = new Institucion_Comercial.activo.DataSetActivoTableAdapters.DataTableActivoTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetActivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableActivoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataSetActivo
            // 
            this.DataSetActivo.DataSetName = "DataSetActivo";
            this.DataSetActivo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTableActivoBindingSource
            // 
            this.DataTableActivoBindingSource.DataMember = "DataTableActivo";
            this.DataTableActivoBindingSource.DataSource = this.DataSetActivo;
            // 
            // DataTableActivoTableAdapter
            // 
            this.DataTableActivoTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Institucion_Comercial.activo.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Institucion_Comercial.activo.Report2a.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(800, 450);
            this.reportViewer2.TabIndex = 1;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "Institucion_Comercial.activo.Report2b.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(0, 0);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(800, 450);
            this.reportViewer3.TabIndex = 2;
            // 
            // repoDepre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "repoDepre";
            this.Text = "repoDepre";
            this.Load += new System.EventHandler(this.repoDepre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetActivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableActivoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource DataTableActivoBindingSource;
        private DataSetActivo DataSetActivo;
        private DataSetActivoTableAdapters.DataTableActivoTableAdapter DataTableActivoTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
    }
}