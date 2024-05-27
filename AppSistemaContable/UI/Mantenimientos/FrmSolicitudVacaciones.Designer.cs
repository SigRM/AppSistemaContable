
namespace AppSistemaContable.UI.Mantenimientos
{
    partial class FrmSolicitudVacaciones
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBxObservaciones = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.groupBxSolicitud = new System.Windows.Forms.GroupBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCrear = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.dgvSolitudVacaciones = new System.Windows.Forms.DataGridView();
            this.IdColaborador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaSolicitarDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaSolicitarHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadDias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nupCantDias = new System.Windows.Forms.NumericUpDown();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.txtIdColaborador = new System.Windows.Forms.TextBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.lblIdColaborador = new System.Windows.Forms.Label();
            this.lblCantDias = new System.Windows.Forms.Label();
            this.dtpSolicitud = new System.Windows.Forms.DateTimePicker();
            this.lblFechaSolicitud = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBxObservaciones.SuspendLayout();
            this.groupBxSolicitud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolitudVacaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBxObservaciones);
            this.splitContainer1.Panel1.Controls.Add(this.groupBxSolicitud);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1093, 361);
            this.splitContainer1.SplitterDistance = 259;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBxObservaciones
            // 
            this.groupBxObservaciones.Controls.Add(this.label1);
            this.groupBxObservaciones.Controls.Add(this.txtObservaciones);
            this.groupBxObservaciones.Location = new System.Drawing.Point(12, 236);
            this.groupBxObservaciones.Name = "groupBxObservaciones";
            this.groupBxObservaciones.Size = new System.Drawing.Size(231, 88);
            this.groupBxObservaciones.TabIndex = 5;
            this.groupBxObservaciones.TabStop = false;
            this.groupBxObservaciones.Text = "Observaciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aprobadas / Rechazadas";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(9, 39);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(200, 20);
            this.txtObservaciones.TabIndex = 0;
            // 
            // groupBxSolicitud
            // 
            this.groupBxSolicitud.Controls.Add(this.dtpHasta);
            this.groupBxSolicitud.Controls.Add(this.dtpDesde);
            this.groupBxSolicitud.Controls.Add(this.lblHasta);
            this.groupBxSolicitud.Controls.Add(this.lblDesde);
            this.groupBxSolicitud.Location = new System.Drawing.Point(12, 33);
            this.groupBxSolicitud.Name = "groupBxSolicitud";
            this.groupBxSolicitud.Size = new System.Drawing.Size(231, 161);
            this.groupBxSolicitud.TabIndex = 1;
            this.groupBxSolicitud.TabStop = false;
            this.groupBxSolicitud.Text = "Solicitud Vacaciones";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(6, 122);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 3;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(9, 55);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 2;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(6, 93);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(35, 13);
            this.lblHasta.TabIndex = 1;
            this.lblHasta.Text = "Hasta";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(6, 25);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(38, 13);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvSolitudVacaciones);
            this.splitContainer2.Panel2.Controls.Add(this.nupCantDias);
            this.splitContainer2.Panel2.Controls.Add(this.chkEstado);
            this.splitContainer2.Panel2.Controls.Add(this.txtIdColaborador);
            this.splitContainer2.Panel2.Controls.Add(this.lblestado);
            this.splitContainer2.Panel2.Controls.Add(this.lblIdColaborador);
            this.splitContainer2.Panel2.Controls.Add(this.lblCantDias);
            this.splitContainer2.Panel2.Controls.Add(this.dtpSolicitud);
            this.splitContainer2.Panel2.Controls.Add(this.lblFechaSolicitud);
            this.splitContainer2.Size = new System.Drawing.Size(830, 361);
            this.splitContainer2.SplitterDistance = 49;
            this.splitContainer2.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCrear,
            this.btnActualizar,
            this.btnEliminar,
            this.toolStripButton9,
            this.toolStripButton10});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(386, 49);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCrear
            // 
            this.btnCrear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCrear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(52, 24);
            this.btnCrear.Text = "Crear &";
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(83, 24);
            this.btnActualizar.Text = "Actualizar &";
            // 
            // btnEliminar
            // 
            this.btnEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(67, 24);
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(99, 24);
            this.toolStripButton9.Text = "Exportar PDF";
            this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(53, 24);
            this.toolStripButton10.Text = "&Cerrar";
            this.toolStripButton10.Click += new System.EventHandler(this.toolStripButton10_Click);
            // 
            // dgvSolitudVacaciones
            // 
            this.dgvSolitudVacaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolitudVacaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColaborador,
            this.FechaSolicitud,
            this.FechaSolicitarDesde,
            this.FechaSolicitarHasta,
            this.CantidadDias,
            this.Observaciones,
            this.Estado});
            this.dgvSolitudVacaciones.Location = new System.Drawing.Point(28, 134);
            this.dgvSolitudVacaciones.Name = "dgvSolitudVacaciones";
            this.dgvSolitudVacaciones.Size = new System.Drawing.Size(736, 150);
            this.dgvSolitudVacaciones.TabIndex = 11;
            this.dgvSolitudVacaciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolitudVacaciones_CellDoubleClick);
            // 
            // IdColaborador
            // 
            this.IdColaborador.HeaderText = "Id";
            this.IdColaborador.Name = "IdColaborador";
            // 
            // FechaSolicitud
            // 
            this.FechaSolicitud.HeaderText = "FechaSolicitud";
            this.FechaSolicitud.Name = "FechaSolicitud";
            // 
            // FechaSolicitarDesde
            // 
            this.FechaSolicitarDesde.HeaderText = "Desde";
            this.FechaSolicitarDesde.Name = "FechaSolicitarDesde";
            // 
            // FechaSolicitarHasta
            // 
            this.FechaSolicitarHasta.HeaderText = "Hasta";
            this.FechaSolicitarHasta.Name = "FechaSolicitarHasta";
            // 
            // CantidadDias
            // 
            this.CantidadDias.HeaderText = "CantidadDias";
            this.CantidadDias.Name = "CantidadDias";
            // 
            // Observaciones
            // 
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // nupCantDias
            // 
            this.nupCantDias.Location = new System.Drawing.Point(481, 31);
            this.nupCantDias.Name = "nupCantDias";
            this.nupCantDias.Size = new System.Drawing.Size(120, 20);
            this.nupCantDias.TabIndex = 10;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(481, 72);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(15, 14);
            this.chkEstado.TabIndex = 9;
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // txtIdColaborador
            // 
            this.txtIdColaborador.Location = new System.Drawing.Point(137, 66);
            this.txtIdColaborador.Name = "txtIdColaborador";
            this.txtIdColaborador.Size = new System.Drawing.Size(200, 20);
            this.txtIdColaborador.TabIndex = 8;
            this.txtIdColaborador.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtIdColaborador_KeyUp);
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(376, 73);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(40, 13);
            this.lblestado.TabIndex = 7;
            this.lblestado.Text = "Estado";
            // 
            // lblIdColaborador
            // 
            this.lblIdColaborador.AutoSize = true;
            this.lblIdColaborador.Location = new System.Drawing.Point(25, 73);
            this.lblIdColaborador.Name = "lblIdColaborador";
            this.lblIdColaborador.Size = new System.Drawing.Size(76, 13);
            this.lblIdColaborador.TabIndex = 6;
            this.lblIdColaborador.Text = "Id Colaborador";
            // 
            // lblCantDias
            // 
            this.lblCantDias.AutoSize = true;
            this.lblCantDias.Location = new System.Drawing.Point(376, 31);
            this.lblCantDias.Name = "lblCantDias";
            this.lblCantDias.Size = new System.Drawing.Size(86, 13);
            this.lblCantDias.TabIndex = 5;
            this.lblCantDias.Text = "Cantidad de dias";
            // 
            // dtpSolicitud
            // 
            this.dtpSolicitud.Location = new System.Drawing.Point(137, 25);
            this.dtpSolicitud.Name = "dtpSolicitud";
            this.dtpSolicitud.Size = new System.Drawing.Size(200, 20);
            this.dtpSolicitud.TabIndex = 4;
            // 
            // lblFechaSolicitud
            // 
            this.lblFechaSolicitud.AutoSize = true;
            this.lblFechaSolicitud.Location = new System.Drawing.Point(25, 31);
            this.lblFechaSolicitud.Name = "lblFechaSolicitud";
            this.lblFechaSolicitud.Size = new System.Drawing.Size(95, 13);
            this.lblFechaSolicitud.TabIndex = 4;
            this.lblFechaSolicitud.Text = "Fecha de Solicitud";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmSolicitudVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 361);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmSolicitudVacaciones";
            this.Text = "FrmSolicitudVacaciones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSolicitudVacaciones_FormClosed);
            this.Load += new System.EventHandler(this.FrmSolicitudVacaciones_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBxObservaciones.ResumeLayout(false);
            this.groupBxObservaciones.PerformLayout();
            this.groupBxSolicitud.ResumeLayout(false);
            this.groupBxSolicitud.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolitudVacaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBxObservaciones;
        private System.Windows.Forms.GroupBox groupBxSolicitud;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCrear;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.Label lblFechaSolicitud;
        private System.Windows.Forms.DataGridView dgvSolitudVacaciones;
        private System.Windows.Forms.NumericUpDown nupCantDias;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.TextBox txtIdColaborador;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Label lblIdColaborador;
        private System.Windows.Forms.Label lblCantDias;
        private System.Windows.Forms.DateTimePicker dtpSolicitud;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColaborador;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaSolicitarDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaSolicitarHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadDias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtObservaciones;
    }
}