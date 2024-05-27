
namespace AppSistemaContable
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.btnCatalogos = new System.Windows.Forms.ToolStripDropDownButton();
            this.calcularPlanillaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMantenimientos = new System.Windows.Forms.ToolStripSplitButton();
            this.colaboradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deduccionPercepcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deduccionPercepcionColaboradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planillaPagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudVacacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planillaEncabezadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRepotes = new System.Windows.Forms.ToolStripSplitButton();
            this.reportePlanillasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteColaboradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteSolicitudVacacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnControlMarcas = new System.Windows.Forms.ToolStripButton();
            this.btnAcercaDe = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir,
            this.btnCatalogos,
            this.btnMantenimientos,
            this.btnRepotes,
            this.btnControlMarcas,
            this.btnAcercaDe});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 62);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(33, 59);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnCatalogos
            // 
            this.btnCatalogos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcularPlanillaToolStripMenuItem});
            this.btnCatalogos.Image = ((System.Drawing.Image)(resources.GetObject("btnCatalogos.Image")));
            this.btnCatalogos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCatalogos.Name = "btnCatalogos";
            this.btnCatalogos.Size = new System.Drawing.Size(103, 59);
            this.btnCatalogos.Text = "Catalogos";
            // 
            // calcularPlanillaToolStripMenuItem
            // 
            this.calcularPlanillaToolStripMenuItem.Name = "calcularPlanillaToolStripMenuItem";
            this.calcularPlanillaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.calcularPlanillaToolStripMenuItem.Text = "Calcular Planilla";
            // 
            // btnMantenimientos
            // 
            this.btnMantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colaboradoresToolStripMenuItem,
            this.deduccionPercepcionToolStripMenuItem,
            this.deduccionPercepcionColaboradorToolStripMenuItem,
            this.empresaToolStripMenuItem,
            this.planillaPagoToolStripMenuItem,
            this.puestosToolStripMenuItem,
            this.solicitudVacacionesToolStripMenuItem,
            this.planillaEncabezadoToolStripMenuItem});
            this.btnMantenimientos.Image = ((System.Drawing.Image)(resources.GetObject("btnMantenimientos.Image")));
            this.btnMantenimientos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMantenimientos.Name = "btnMantenimientos";
            this.btnMantenimientos.Size = new System.Drawing.Size(140, 59);
            this.btnMantenimientos.Text = "Mantenimientos";
            // 
            // colaboradoresToolStripMenuItem
            // 
            this.colaboradoresToolStripMenuItem.Name = "colaboradoresToolStripMenuItem";
            this.colaboradoresToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.colaboradoresToolStripMenuItem.Text = "Colaboradores";
            this.colaboradoresToolStripMenuItem.Click += new System.EventHandler(this.colaboradoresToolStripMenuItem_Click);
            // 
            // deduccionPercepcionToolStripMenuItem
            // 
            this.deduccionPercepcionToolStripMenuItem.Name = "deduccionPercepcionToolStripMenuItem";
            this.deduccionPercepcionToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.deduccionPercepcionToolStripMenuItem.Text = "Deduccion Percepcion";
            this.deduccionPercepcionToolStripMenuItem.Click += new System.EventHandler(this.deduccionPercepcionToolStripMenuItem_Click);
            // 
            // deduccionPercepcionColaboradorToolStripMenuItem
            // 
            this.deduccionPercepcionColaboradorToolStripMenuItem.Name = "deduccionPercepcionColaboradorToolStripMenuItem";
            this.deduccionPercepcionColaboradorToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.deduccionPercepcionColaboradorToolStripMenuItem.Text = "Deduccion Percepcion Colaborador";
            this.deduccionPercepcionColaboradorToolStripMenuItem.Click += new System.EventHandler(this.deduccionPercepcionColaboradorToolStripMenuItem_Click);
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.empresaToolStripMenuItem.Text = "Empresa";
            this.empresaToolStripMenuItem.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // planillaPagoToolStripMenuItem
            // 
            this.planillaPagoToolStripMenuItem.Name = "planillaPagoToolStripMenuItem";
            this.planillaPagoToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.planillaPagoToolStripMenuItem.Text = "PlanillaPago";
            this.planillaPagoToolStripMenuItem.Click += new System.EventHandler(this.planillaPagoToolStripMenuItem_Click);
            // 
            // puestosToolStripMenuItem
            // 
            this.puestosToolStripMenuItem.Name = "puestosToolStripMenuItem";
            this.puestosToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.puestosToolStripMenuItem.Text = "Puestos";
            this.puestosToolStripMenuItem.Click += new System.EventHandler(this.puestosToolStripMenuItem_Click);
            // 
            // solicitudVacacionesToolStripMenuItem
            // 
            this.solicitudVacacionesToolStripMenuItem.Name = "solicitudVacacionesToolStripMenuItem";
            this.solicitudVacacionesToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.solicitudVacacionesToolStripMenuItem.Text = "Solicitud Vacaciones";
            this.solicitudVacacionesToolStripMenuItem.Click += new System.EventHandler(this.solicitudVacacionesToolStripMenuItem_Click);
            // 
            // planillaEncabezadoToolStripMenuItem
            // 
            this.planillaEncabezadoToolStripMenuItem.Name = "planillaEncabezadoToolStripMenuItem";
            this.planillaEncabezadoToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.planillaEncabezadoToolStripMenuItem.Text = "PlanillaEncabezado";
            this.planillaEncabezadoToolStripMenuItem.Click += new System.EventHandler(this.planillaEncabezadoToolStripMenuItem_Click);
            // 
            // btnRepotes
            // 
            this.btnRepotes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportePlanillasToolStripMenuItem,
            this.reporteColaboradoresToolStripMenuItem,
            this.reporteSolicitudVacacionesToolStripMenuItem});
            this.btnRepotes.Image = ((System.Drawing.Image)(resources.GetObject("btnRepotes.Image")));
            this.btnRepotes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRepotes.Name = "btnRepotes";
            this.btnRepotes.Size = new System.Drawing.Size(99, 59);
            this.btnRepotes.Text = "Reportes";
            this.btnRepotes.ButtonClick += new System.EventHandler(this.btnRepotes_ButtonClick);
            // 
            // reportePlanillasToolStripMenuItem
            // 
            this.reportePlanillasToolStripMenuItem.Name = "reportePlanillasToolStripMenuItem";
            this.reportePlanillasToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.reportePlanillasToolStripMenuItem.Text = "Reporte Planillas";
            this.reportePlanillasToolStripMenuItem.Click += new System.EventHandler(this.reportePlanillasToolStripMenuItem_Click);
            // 
            // reporteColaboradoresToolStripMenuItem
            // 
            this.reporteColaboradoresToolStripMenuItem.Name = "reporteColaboradoresToolStripMenuItem";
            this.reporteColaboradoresToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.reporteColaboradoresToolStripMenuItem.Text = "Reporte Comprobante";
            this.reporteColaboradoresToolStripMenuItem.Click += new System.EventHandler(this.reporteColaboradoresToolStripMenuItem_Click);
            // 
            // reporteSolicitudVacacionesToolStripMenuItem
            // 
            this.reporteSolicitudVacacionesToolStripMenuItem.Name = "reporteSolicitudVacacionesToolStripMenuItem";
            this.reporteSolicitudVacacionesToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.reporteSolicitudVacacionesToolStripMenuItem.Text = "Reporte Solicitud Vacaciones";
            this.reporteSolicitudVacacionesToolStripMenuItem.Click += new System.EventHandler(this.reporteSolicitudVacacionesToolStripMenuItem_Click);
            // 
            // btnControlMarcas
            // 
            this.btnControlMarcas.Image = ((System.Drawing.Image)(resources.GetObject("btnControlMarcas.Image")));
            this.btnControlMarcas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnControlMarcas.Name = "btnControlMarcas";
            this.btnControlMarcas.Size = new System.Drawing.Size(122, 59);
            this.btnControlMarcas.Text = "Control Marcas";
            this.btnControlMarcas.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.Image = ((System.Drawing.Image)(resources.GetObject("btnAcercaDe.Image")));
            this.btnAcercaDe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Size = new System.Drawing.Size(93, 59);
            this.btnAcercaDe.Text = "Acerca de";
            this.btnAcercaDe.Click += new System.EventHandler(this.btnAcercaDe_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Location = new System.Drawing.Point(693, 25);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(0, 13);
            this.lblFechaHora.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFechaHora);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripSplitButton btnMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem colaboradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deduccionPercepcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deduccionPercepcionColaboradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planillaPagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitudVacacionesToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.ToolStripDropDownButton btnCatalogos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton btnAcercaDe;
        private System.Windows.Forms.ToolStripButton btnControlMarcas;
        private System.Windows.Forms.ToolStripMenuItem calcularPlanillaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton btnRepotes;
        private System.Windows.Forms.ToolStripMenuItem planillaEncabezadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportePlanillasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteColaboradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteSolicitudVacacionesToolStripMenuItem;
    }
}

