
namespace AppSistemaContable.UI.Mantenimientos
{
    partial class FrmPlanillaEncabezado
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvTipoCambio = new System.Windows.Forms.DataGridView();
            this.lblInicio = new System.Windows.Forms.Label();
            this.rdbCompra = new System.Windows.Forms.RadioButton();
            this.rdbVenta = new System.Windows.Forms.RadioButton();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lbltipoConsulta = new System.Windows.Forms.Label();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoCambio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConsultar);
            this.groupBox2.Controls.Add(this.dgvTipoCambio);
            this.groupBox2.Controls.Add(this.lblInicio);
            this.groupBox2.Controls.Add(this.rdbCompra);
            this.groupBox2.Controls.Add(this.rdbVenta);
            this.groupBox2.Controls.Add(this.dtpInicial);
            this.groupBox2.Controls.Add(this.lblFinal);
            this.groupBox2.Controls.Add(this.lbltipoConsulta);
            this.groupBox2.Controls.Add(this.dtpFinal);
            this.groupBox2.Location = new System.Drawing.Point(11, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(778, 118);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo Cambio";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(293, 65);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(127, 27);
            this.btnConsultar.TabIndex = 23;
            this.btnConsultar.Text = "Consulta";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvTipoCambio
            // 
            this.dgvTipoCambio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoCambio.Location = new System.Drawing.Point(473, 48);
            this.dgvTipoCambio.Name = "dgvTipoCambio";
            this.dgvTipoCambio.RowHeadersWidth = 72;
            this.dgvTipoCambio.Size = new System.Drawing.Size(218, 65);
            this.dgvTipoCambio.TabIndex = 11;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(13, 23);
            this.lblInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(65, 13);
            this.lblInicio.TabIndex = 16;
            this.lblInicio.Text = "Fecha Inicio";
            // 
            // rdbCompra
            // 
            this.rdbCompra.AutoSize = true;
            this.rdbCompra.Checked = true;
            this.rdbCompra.Location = new System.Drawing.Point(134, 75);
            this.rdbCompra.Margin = new System.Windows.Forms.Padding(2);
            this.rdbCompra.Name = "rdbCompra";
            this.rdbCompra.Size = new System.Drawing.Size(61, 17);
            this.rdbCompra.TabIndex = 21;
            this.rdbCompra.TabStop = true;
            this.rdbCompra.Text = "Compra";
            this.rdbCompra.UseVisualStyleBackColor = true;
            // 
            // rdbVenta
            // 
            this.rdbVenta.AutoSize = true;
            this.rdbVenta.Location = new System.Drawing.Point(201, 75);
            this.rdbVenta.Margin = new System.Windows.Forms.Padding(2);
            this.rdbVenta.Name = "rdbVenta";
            this.rdbVenta.Size = new System.Drawing.Size(53, 17);
            this.rdbVenta.TabIndex = 22;
            this.rdbVenta.Text = "Venta";
            this.rdbVenta.UseVisualStyleBackColor = true;
            // 
            // dtpInicial
            // 
            this.dtpInicial.Location = new System.Drawing.Point(134, 23);
            this.dtpInicial.Margin = new System.Windows.Forms.Padding(2);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(218, 20);
            this.dtpInicial.TabIndex = 19;
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(390, 30);
            this.lblFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(62, 13);
            this.lblFinal.TabIndex = 17;
            this.lblFinal.Text = "Fecha Final";
            // 
            // lbltipoConsulta
            // 
            this.lbltipoConsulta.AutoSize = true;
            this.lbltipoConsulta.Location = new System.Drawing.Point(13, 75);
            this.lbltipoConsulta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltipoConsulta.Name = "lbltipoConsulta";
            this.lbltipoConsulta.Size = new System.Drawing.Size(72, 13);
            this.lbltipoConsulta.TabIndex = 20;
            this.lbltipoConsulta.Text = "Tipo Consulta";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Location = new System.Drawing.Point(473, 23);
            this.dtpFinal.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(218, 20);
            this.dtpFinal.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Id PlanillaPago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Total Gastos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Total Pagar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(516, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Salario Neto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Total pagar USD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Total Ingresos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 38;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(363, 201);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 39;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(363, 147);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 40;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(602, 150);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 41;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(602, 197);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 42;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(145, 201);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 43;
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(145, 264);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(130, 20);
            this.textBox7.TabIndex = 44;
            this.textBox7.Text = "$";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(709, 150);
            this.dataGridView1.TabIndex = 45;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(638, 259);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(108, 28);
            this.btnCalcular.TabIndex = 46;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // FrmPlanillaEncabezado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmPlanillaEncabezado";
            this.Text = "Planilla Encabezado";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoCambio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvTipoCambio;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.RadioButton rdbCompra;
        private System.Windows.Forms.RadioButton rdbVenta;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lbltipoConsulta;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCalcular;
    }
}