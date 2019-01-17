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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.comboBoxSucursal = new System.Windows.Forms.ComboBox();
            this.comboBoxDepartamento = new System.Windows.Forms.ComboBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.DataTableActivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetActivo = new Institucion_Comercial.activo.DataSetActivo();
            this.DataTableActivoTableAdapter = new Institucion_Comercial.activo.DataSetActivoTableAdapters.DataTableActivoTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableActivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetActivo)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSucursal
            // 
            this.comboBoxSucursal.FormattingEnabled = true;
            this.comboBoxSucursal.Location = new System.Drawing.Point(27, 47);
            this.comboBoxSucursal.Name = "comboBoxSucursal";
            this.comboBoxSucursal.Size = new System.Drawing.Size(155, 21);
            this.comboBoxSucursal.TabIndex = 2;
            this.comboBoxSucursal.SelectedIndexChanged += new System.EventHandler(this.comboBoxSucursal_SelectedIndexChanged);
            // 
            // comboBoxDepartamento
            // 
            this.comboBoxDepartamento.FormattingEnabled = true;
            this.comboBoxDepartamento.Location = new System.Drawing.Point(241, 47);
            this.comboBoxDepartamento.Name = "comboBoxDepartamento";
            this.comboBoxDepartamento.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDepartamento.TabIndex = 3;
            this.comboBoxDepartamento.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartamento_SelectedIndexChanged);
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(455, 47);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipo.TabIndex = 4;
            this.comboBoxTipo.Visible = false;
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
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Institucion_Comercial.activo.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 98);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1147, 462);
            this.reportViewer1.TabIndex = 5;
            // 
            // reportViewer2
            // 
            reportDataSource9.Name = "DataSet1";
            reportDataSource9.Value = this.DataTableActivoBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Institucion_Comercial.activo.Report1.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 98);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1147, 462);
            this.reportViewer2.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(27, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(53, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Filtros";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // reportViewer3
            // 
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "Institucion_Comercial.activo.Report3a.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(0, 98);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(1147, 462);
            this.reportViewer3.TabIndex = 8;
            // 
            // repoInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 572);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.comboBoxDepartamento);
            this.Controls.Add(this.comboBoxSucursal);
            this.Name = "repoInv";
            this.Text = "repoInv";
            this.Load += new System.EventHandler(this.repoInv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTableActivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetActivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource DataTableActivoBindingSource;
        private DataSetActivo DataSetActivo;
        private DataSetActivoTableAdapters.DataTableActivoTableAdapter DataTableActivoTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxSucursal;
        private System.Windows.Forms.ComboBox comboBoxDepartamento;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.CheckBox checkBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
    }
}