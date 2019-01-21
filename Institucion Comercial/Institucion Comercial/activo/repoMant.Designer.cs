namespace Institucion_Comercial.activo
{
    partial class repoMant
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetMant1 = new Institucion_Comercial.activo.DataSetMant();
            this.dataTableManttenimineto1 = new Institucion_Comercial.activo.DataSetMantTableAdapters.DataTableManttenimineto();
            this.encaTableAdapter1 = new Institucion_Comercial.activo.DataSetMantTableAdapters.encaTableAdapter();
            this.activosTableAdapter1 = new Institucion_Comercial.activo.DataSetMantTableAdapters.activosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMant1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Institucion_Comercial.activo.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetMant1
            // 
            this.dataSetMant1.DataSetName = "DataSetMant";
            this.dataSetMant1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableManttenimineto1
            // 
            this.dataTableManttenimineto1.ClearBeforeFill = true;
            // 
            // encaTableAdapter1
            // 
            this.encaTableAdapter1.ClearBeforeFill = true;
            // 
            // activosTableAdapter1
            // 
            this.activosTableAdapter1.ClearBeforeFill = true;
            // 
            // repoMant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "repoMant";
            this.Text = "repoMant";
            this.Load += new System.EventHandler(this.repoMant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMant1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetMant dataSetMant1;
        private DataSetMantTableAdapters.DataTableManttenimineto dataTableManttenimineto1;
        private DataSetMantTableAdapters.encaTableAdapter encaTableAdapter1;
        private DataSetMantTableAdapters.activosTableAdapter activosTableAdapter1;
    }
}