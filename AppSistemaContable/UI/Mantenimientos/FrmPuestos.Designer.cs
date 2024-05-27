
namespace AppSistemaContable.UI.Mantenimientos
{
    partial class FrmPuestos
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
            this.dgvPuestos = new System.Windows.Forms.DataGridView();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.chkestado = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cREARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCTUALIZARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lIMPIARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eLIMINARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPuestos
            // 
            this.dgvPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuestos.Location = new System.Drawing.Point(34, 191);
            this.dgvPuestos.Name = "dgvPuestos";
            this.dgvPuestos.Size = new System.Drawing.Size(416, 150);
            this.dgvPuestos.TabIndex = 0;
            this.dgvPuestos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPuestos_CellDoubleClick);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(45, 79);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(45, 118);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre Puesto";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(45, 160);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "Estado";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(147, 72);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(159, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(147, 111);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(159, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // chkestado
            // 
            this.chkestado.AutoSize = true;
            this.chkestado.Location = new System.Drawing.Point(147, 160);
            this.chkestado.Name = "chkestado";
            this.chkestado.Size = new System.Drawing.Size(15, 14);
            this.chkestado.TabIndex = 6;
            this.chkestado.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sALIRToolStripMenuItem,
            this.cREARToolStripMenuItem,
            this.aCTUALIZARToolStripMenuItem,
            this.lIMPIARToolStripMenuItem,
            this.eLIMINARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(479, 24);
            this.menuStrip1.TabIndex = 7;
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
            // aCTUALIZARToolStripMenuItem
            // 
            this.aCTUALIZARToolStripMenuItem.Name = "aCTUALIZARToolStripMenuItem";
            this.aCTUALIZARToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.aCTUALIZARToolStripMenuItem.Text = "ACTUALIZAR";
            this.aCTUALIZARToolStripMenuItem.Click += new System.EventHandler(this.aCTUALIZARToolStripMenuItem_Click);
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmPuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 353);
            this.Controls.Add(this.chkestado);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.dgvPuestos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPuestos";
            this.Text = "Mantenimiento Puestos";
            this.Load += new System.EventHandler(this.FrmPuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPuestos;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckBox chkestado;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cREARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aCTUALIZARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eLIMINARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lIMPIARToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}