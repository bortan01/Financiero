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
            this.DataTableActivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetActivo = new Institucion_Comercial.activo.DataSetActivo();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTableActivoTableAdapter = new Institucion_Comercial.activo.DataSetActivoTableAdapters.DataTableActivoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSucursal = new System.Windows.Forms.ComboBox();
            this.comboBoxDepartamento = new System.Windows.Forms.ComboBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableActivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetActivo)).BeginInit();
            this.SuspendLayout();
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
            // DataTableActivoTableAdapter
            // 
            this.DataTableActivoTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtro";
            // 
            // comboBoxSucursal
            // 
            this.comboBoxSucursal.FormattingEnabled = true;
            this.comboBoxSucursal.Location = new System.Drawing.Point(27, 47);
            this.comboBoxSucursal.Name = "comboBoxSucursal";
            this.comboBoxSucursal.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSucursal.TabIndex = 2;
            // 
            // comboBoxDepartamento
            // 
            this.comboBoxDepartamento.FormattingEnabled = true;
            this.comboBoxDepartamento.Location = new System.Drawing.Point(241, 47);
            this.comboBoxDepartamento.Name = "comboBoxDepartamento";
            this.comboBoxDepartamento.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDepartamento.TabIndex = 3;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(455, 47);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipo.TabIndex = 4;
            // 
            // repoInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 572);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.comboBoxDepartamento);
            this.Controls.Add(this.comboBoxSucursal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "repoInv";
            this.Text = "repoInv";
            this.Load += new System.EventHandler(this.repoInv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTableActivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetActivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTableActivoBindingSource;
        private DataSetActivo DataSetActivo;
        private DataSetActivoTableAdapters.DataTableActivoTableAdapter DataTableActivoTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSucursal;
        private System.Windows.Forms.ComboBox comboBoxDepartamento;
        private System.Windows.Forms.ComboBox comboBoxTipo;
    }
}