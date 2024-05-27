
namespace AppSistemaContable.UI.Mantenimientos
{
    partial class FrmPlanillaPago
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.dgvPlanillaPago = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cREARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lIMPIARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eLIMINARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtEmpresaId = new System.Windows.Forms.TextBox();
            this.txtPlanilla = new System.Windows.Forms.TextBox();
            this.eNVIARCORREOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePlanilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpresaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanillaPago)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Planilla";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Empresa Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Desde";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(365, 113);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(68, 13);
            this.lblFechaHasta.TabIndex = 4;
            this.lblFechaHasta.Text = "Fecha Hasta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha Pago";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estado";
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Location = new System.Drawing.Point(441, 166);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaPago.TabIndex = 7;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(441, 107);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaHasta.TabIndex = 8;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(442, 49);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDesde.TabIndex = 9;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(442, 215);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(15, 14);
            this.chkEstado.TabIndex = 10;
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // dgvPlanillaPago
            // 
            this.dgvPlanillaPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanillaPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NombrePlanilla,
            this.EmpresaId,
            this.FechaDesde,
            this.FechaHasta,
            this.FechaPago,
            this.Estado});
            this.dgvPlanillaPago.Location = new System.Drawing.Point(22, 248);
            this.dgvPlanillaPago.Name = "dgvPlanillaPago";
            this.dgvPlanillaPago.Size = new System.Drawing.Size(741, 131);
            this.dgvPlanillaPago.TabIndex = 11;
            this.dgvPlanillaPago.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanillaPago_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sALIRToolStripMenuItem,
            this.cREARToolStripMenuItem,
            this.eDITARToolStripMenuItem,
            this.lIMPIARToolStripMenuItem,
            this.eLIMINARToolStripMenuItem,
            this.eNVIARCORREOToolStripMenuItem,
            this.pDFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // cREARToolStripMenuItem
            // 
            this.cREARToolStripMenuItem.Name = "cREARToolStripMenuItem";
            this.cREARToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cREARToolStripMenuItem.Text = "CREAR";
            this.cREARToolStripMenuItem.Click += new System.EventHandler(this.cREARToolStripMenuItem_Click);
            // 
            // eDITARToolStripMenuItem
            // 
            this.eDITARToolStripMenuItem.Name = "eDITARToolStripMenuItem";
            this.eDITARToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.eDITARToolStripMenuItem.Text = "EDITAR";
            // 
            // lIMPIARToolStripMenuItem
            // 
            this.lIMPIARToolStripMenuItem.Name = "lIMPIARToolStripMenuItem";
            this.lIMPIARToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.lIMPIARToolStripMenuItem.Text = "LIMPIAR";
            this.lIMPIARToolStripMenuItem.Click += new System.EventHandler(this.lIMPIARToolStripMenuItem_Click);
            // 
            // eLIMINARToolStripMenuItem
            // 
            this.eLIMINARToolStripMenuItem.Name = "eLIMINARToolStripMenuItem";
            this.eLIMINARToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.eLIMINARToolStripMenuItem.Text = "ELIMINAR";
            this.eLIMINARToolStripMenuItem.Click += new System.EventHandler(this.eLIMINARToolStripMenuItem_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(149, 49);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(200, 20);
            this.txtId.TabIndex = 13;
            // 
            // txtEmpresaId
            // 
            this.txtEmpresaId.Location = new System.Drawing.Point(149, 165);
            this.txtEmpresaId.Name = "txtEmpresaId";
            this.txtEmpresaId.Size = new System.Drawing.Size(200, 20);
            this.txtEmpresaId.TabIndex = 14;
            // 
            // txtPlanilla
            // 
            this.txtPlanilla.Location = new System.Drawing.Point(149, 110);
            this.txtPlanilla.Name = "txtPlanilla";
            this.txtPlanilla.Size = new System.Drawing.Size(200, 20);
            this.txtPlanilla.TabIndex = 15;
            // 
            // eNVIARCORREOToolStripMenuItem
            // 
            this.eNVIARCORREOToolStripMenuItem.Name = "eNVIARCORREOToolStripMenuItem";
            this.eNVIARCORREOToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.eNVIARCORREOToolStripMenuItem.Text = "ENVIAR CORREO";
            this.eNVIARCORREOToolStripMenuItem.Click += new System.EventHandler(this.eNVIARCORREOToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pDFToolStripMenuItem
            // 
            this.pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            this.pDFToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.pDFToolStripMenuItem.Text = "PDF ";
            this.pDFToolStripMenuItem.Click += new System.EventHandler(this.pDFToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Correo";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(149, 208);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 17;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // NombrePlanilla
            // 
            this.NombrePlanilla.HeaderText = "NombrePlanilla";
            this.NombrePlanilla.Name = "NombrePlanilla";
            // 
            // EmpresaId
            // 
            this.EmpresaId.HeaderText = "EmpresaId";
            this.EmpresaId.Name = "EmpresaId";
            // 
            // FechaDesde
            // 
            this.FechaDesde.HeaderText = "FechaDesde";
            this.FechaDesde.Name = "FechaDesde";
            // 
            // FechaHasta
            // 
            this.FechaHasta.HeaderText = "FechaHasta";
            this.FechaHasta.Name = "FechaHasta";
            // 
            // FechaPago
            // 
            this.FechaPago.HeaderText = "FechaPago";
            this.FechaPago.Name = "FechaPago";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // FrmPlanillaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 391);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPlanilla);
            this.Controls.Add(this.txtEmpresaId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dgvPlanillaPago);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaPago);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPlanillaPago";
            this.Text = "FrmPlanillaPago";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPlanillaPago_FormClosed);
            this.Load += new System.EventHandler(this.FrmPlanillaPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanillaPago)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.DataGridView dgvPlanillaPago;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtEmpresaId;
        private System.Windows.Forms.TextBox txtPlanilla;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cREARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lIMPIARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eLIMINARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eNVIARCORREOToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePlanilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpresaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}