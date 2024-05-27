
namespace AppSistemaContable.UI
{
    partial class FrmControlMarcas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.lblCargar = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.dgvControlMarcas = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(155, 27);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.ReadOnly = true;
            this.txtRuta.Size = new System.Drawing.Size(380, 20);
            this.txtRuta.TabIndex = 0;
            this.txtRuta.Click += new System.EventHandler(this.txtRuta_Click);
            // 
            // lblCargar
            // 
            this.lblCargar.AutoSize = true;
            this.lblCargar.Location = new System.Drawing.Point(37, 34);
            this.lblCargar.Name = "lblCargar";
            this.lblCargar.Size = new System.Drawing.Size(112, 13);
            this.lblCargar.TabIndex = 1;
            this.lblCargar.Text = "Cargar Control Marcas";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(541, 25);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // dgvControlMarcas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aqua;
            this.dgvControlMarcas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvControlMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControlMarcas.Location = new System.Drawing.Point(29, 93);
            this.dgvControlMarcas.Name = "dgvControlMarcas";
            this.dgvControlMarcas.Size = new System.Drawing.Size(587, 350);
            this.dgvControlMarcas.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmControlMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 455);
            this.Controls.Add(this.dgvControlMarcas);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lblCargar);
            this.Controls.Add(this.txtRuta);
            this.Name = "FrmControlMarcas";
            this.Text = "Control Marcas";
            this.Load += new System.EventHandler(this.FrmControlMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label lblCargar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DataGridView dgvControlMarcas;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}