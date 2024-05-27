
namespace AppSistemaContable.UI.Reportes
{
    partial class FrmReporteSolicitudVacaciones
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
            this.SolicitudesVacacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SolicitudesVacacionesTableAdapter = new AppSistemaContable.UI.Reportes.DsFuenteDatodsTableAdapters.SolicitudesVacacionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DsFuenteDatods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SolicitudesVacacionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SolicitudesVacacionesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppSistemaContable.UI.Reportes.rptSolicitudVacaciones.rdlc";
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
            // SolicitudesVacacionesBindingSource
            // 
            this.SolicitudesVacacionesBindingSource.DataMember = "SolicitudesVacaciones";
            this.SolicitudesVacacionesBindingSource.DataSource = this.DsFuenteDatods;
            // 
            // SolicitudesVacacionesTableAdapter
            // 
            this.SolicitudesVacacionesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteSolicitudVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteSolicitudVacaciones";
            this.Text = "FrmReporteSolicitudVacaciones";
            this.Load += new System.EventHandler(this.FrmReporteSolicitudVacaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsFuenteDatods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SolicitudesVacacionesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SolicitudesVacacionesBindingSource;
        private DsFuenteDatods DsFuenteDatods;
        private DsFuenteDatodsTableAdapters.SolicitudesVacacionesTableAdapter SolicitudesVacacionesTableAdapter;
    }
}