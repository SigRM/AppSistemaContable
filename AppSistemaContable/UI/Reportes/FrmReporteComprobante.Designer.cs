
namespace AppSistemaContable.UI.Reportes
{
    partial class FrmReporteComprobante
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
            this.DsFuenteDatods = new AppSistemaContable.UI.Reportes.DsFuenteDatods();
            this.PlanillaEncabezadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PlanillaEncabezadoTableAdapter = new AppSistemaContable.UI.Reportes.DsFuenteDatodsTableAdapters.PlanillaEncabezadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DsFuenteDatods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlanillaEncabezadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PlanillaEncabezadoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppSistemaContable.UI.Reportes.rptComprobante.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DsFuenteDatods
            // 
            this.DsFuenteDatods.DataSetName = "DsFuenteDatods";
            this.DsFuenteDatods.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PlanillaEncabezadoBindingSource
            // 
            this.PlanillaEncabezadoBindingSource.DataMember = "PlanillaEncabezado";
            this.PlanillaEncabezadoBindingSource.DataSource = this.DsFuenteDatods;
            // 
            // PlanillaEncabezadoTableAdapter
            // 
            this.PlanillaEncabezadoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteComprobante";
            this.Text = "FrmComprobante";
            this.Load += new System.EventHandler(this.FrmReporteComprobante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsFuenteDatods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlanillaEncabezadoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PlanillaEncabezadoBindingSource;
        private DsFuenteDatods DsFuenteDatods;
        private DsFuenteDatodsTableAdapters.PlanillaEncabezadoTableAdapter PlanillaEncabezadoTableAdapter;
    }
}