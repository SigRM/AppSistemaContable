
namespace AppSistemaContable.UI.Reportes
{
    partial class FrmReportePlanillas
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
            this.dsFuenteDatods1 = new AppSistemaContable.UI.Reportes.DsFuenteDatods();
            this.tableAdapterManager1 = new AppSistemaContable.UI.Reportes.DsFuenteDatodsTableAdapters.TableAdapterManager();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DsFuenteDatods = new AppSistemaContable.UI.Reportes.DsFuenteDatods();
            this.PlanillasPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PlanillasPagoTableAdapter = new AppSistemaContable.UI.Reportes.DsFuenteDatodsTableAdapters.PlanillasPagoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsFuenteDatods1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsFuenteDatods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlanillasPagoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dsFuenteDatods1
            // 
            this.dsFuenteDatods1.DataSetName = "DsFuenteDatods";
            this.dsFuenteDatods1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.PlanillasPagoTableAdapter = this.PlanillasPagoTableAdapter;
            this.tableAdapterManager1.UpdateOrder = AppSistemaContable.UI.Reportes.DsFuenteDatodsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PlanillasPagoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppSistemaContable.UI.Reportes.rptPlanilla.rdlc";
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
            // PlanillasPagoBindingSource
            // 
            this.PlanillasPagoBindingSource.DataMember = "PlanillasPago";
            this.PlanillasPagoBindingSource.DataSource = this.DsFuenteDatods;
            // 
            // PlanillasPagoTableAdapter
            // 
            this.PlanillasPagoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportePlanillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportePlanillas";
            this.Text = "FrmReportePlanillas";
            this.Load += new System.EventHandler(this.FrmReportePlanillas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsFuenteDatods1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsFuenteDatods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlanillasPagoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DsFuenteDatods dsFuenteDatods1;
        private DsFuenteDatodsTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DsFuenteDatodsTableAdapters.PlanillasPagoTableAdapter PlanillasPagoTableAdapter;
        private System.Windows.Forms.BindingSource PlanillasPagoBindingSource;
        private DsFuenteDatods DsFuenteDatods;
    }
}