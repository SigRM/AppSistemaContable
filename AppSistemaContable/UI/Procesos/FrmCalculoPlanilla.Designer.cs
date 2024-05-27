
namespace AppSistemaContable.UI.Procesos
{
    partial class FrmCalculoPlanilla
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
            this.cmbEstadoPago = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmpresaIdPago = new System.Windows.Forms.TextBox();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpHastaPago = new System.Windows.Forms.DateTimePicker();
            this.dtpDesdePago = new System.Windows.Forms.DateTimePicker();
            this.txtPlaniPago = new System.Windows.Forms.TextBox();
            this.txtIdPlaniPago = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSalarioNeto = new System.Windows.Forms.TextBox();
            this.txtUSD = new System.Windows.Forms.TextBox();
            this.txtIdColaboradorEncab = new System.Windows.Forms.TextBox();
            this.txtNombreColabEncab = new System.Windows.Forms.TextBox();
            this.txtIdPagoEncab = new System.Windows.Forms.TextBox();
            this.txtIdPlaniEncab = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grBoxDetalle = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dgvCalculoPlanilla = new System.Windows.Forms.DataGridView();
            this.IdColaborador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreColaborador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HrsTrabajadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HrsOrdinarias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HrsExtra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalExtras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPercepciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPDF = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCorreo = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grBoxDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalculoPlanilla)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbEstadoPago
            // 
            this.cmbEstadoPago.FormattingEnabled = true;
            this.cmbEstadoPago.Location = new System.Drawing.Point(804, 66);
            this.cmbEstadoPago.Name = "cmbEstadoPago";
            this.cmbEstadoPago.Size = new System.Drawing.Size(107, 21);
            this.cmbEstadoPago.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmpresaIdPago);
            this.groupBox1.Controls.Add(this.dtpFechaPago);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtpHastaPago);
            this.groupBox1.Controls.Add(this.dtpDesdePago);
            this.groupBox1.Controls.Add(this.txtPlaniPago);
            this.groupBox1.Controls.Add(this.txtIdPlaniPago);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbEstadoPago);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(103, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(965, 105);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Planilla Pago";
            // 
            // txtEmpresaIdPago
            // 
            this.txtEmpresaIdPago.Location = new System.Drawing.Point(652, 66);
            this.txtEmpresaIdPago.Name = "txtEmpresaIdPago";
            this.txtEmpresaIdPago.Size = new System.Drawing.Size(88, 20);
            this.txtEmpresaIdPago.TabIndex = 13;
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Location = new System.Drawing.Point(652, 19);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaPago.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(581, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Fecha Pago";
            // 
            // dtpHastaPago
            // 
            this.dtpHastaPago.Location = new System.Drawing.Point(335, 63);
            this.dtpHastaPago.Name = "dtpHastaPago";
            this.dtpHastaPago.Size = new System.Drawing.Size(200, 20);
            this.dtpHastaPago.TabIndex = 9;
            // 
            // dtpDesdePago
            // 
            this.dtpDesdePago.Location = new System.Drawing.Point(335, 19);
            this.dtpDesdePago.Name = "dtpDesdePago";
            this.dtpDesdePago.Size = new System.Drawing.Size(200, 20);
            this.dtpDesdePago.TabIndex = 8;
            // 
            // txtPlaniPago
            // 
            this.txtPlaniPago.Location = new System.Drawing.Point(101, 63);
            this.txtPlaniPago.Name = "txtPlaniPago";
            this.txtPlaniPago.Size = new System.Drawing.Size(164, 20);
            this.txtPlaniPago.TabIndex = 7;
            // 
            // txtIdPlaniPago
            // 
            this.txtIdPlaniPago.Location = new System.Drawing.Point(101, 19);
            this.txtIdPlaniPago.Name = "txtIdPlaniPago";
            this.txtIdPlaniPago.Size = new System.Drawing.Size(164, 20);
            this.txtIdPlaniPago.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(761, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Estado ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(581, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Empresa Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSalarioNeto);
            this.groupBox2.Controls.Add(this.txtUSD);
            this.groupBox2.Controls.Add(this.txtIdColaboradorEncab);
            this.groupBox2.Controls.Add(this.txtNombreColabEncab);
            this.groupBox2.Controls.Add(this.txtIdPagoEncab);
            this.groupBox2.Controls.Add(this.txtIdPlaniEncab);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(103, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(965, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encabezado Planilla";
            // 
            // txtSalarioNeto
            // 
            this.txtSalarioNeto.Location = new System.Drawing.Point(652, 20);
            this.txtSalarioNeto.Name = "txtSalarioNeto";
            this.txtSalarioNeto.Size = new System.Drawing.Size(225, 20);
            this.txtSalarioNeto.TabIndex = 12;
            // 
            // txtUSD
            // 
            this.txtUSD.Location = new System.Drawing.Point(652, 64);
            this.txtUSD.Name = "txtUSD";
            this.txtUSD.Size = new System.Drawing.Size(225, 20);
            this.txtUSD.TabIndex = 11;
            // 
            // txtIdColaboradorEncab
            // 
            this.txtIdColaboradorEncab.Location = new System.Drawing.Point(418, 28);
            this.txtIdColaboradorEncab.Name = "txtIdColaboradorEncab";
            this.txtIdColaboradorEncab.Size = new System.Drawing.Size(134, 20);
            this.txtIdColaboradorEncab.TabIndex = 10;
            // 
            // txtNombreColabEncab
            // 
            this.txtNombreColabEncab.Location = new System.Drawing.Point(418, 64);
            this.txtNombreColabEncab.Name = "txtNombreColabEncab";
            this.txtNombreColabEncab.Size = new System.Drawing.Size(134, 20);
            this.txtNombreColabEncab.TabIndex = 9;
            // 
            // txtIdPagoEncab
            // 
            this.txtIdPagoEncab.Location = new System.Drawing.Point(101, 64);
            this.txtIdPagoEncab.Name = "txtIdPagoEncab";
            this.txtIdPagoEncab.Size = new System.Drawing.Size(164, 20);
            this.txtIdPagoEncab.TabIndex = 8;
            // 
            // txtIdPlaniEncab
            // 
            this.txtIdPlaniEncab.Location = new System.Drawing.Point(101, 24);
            this.txtIdPlaniEncab.Name = "txtIdPlaniEncab";
            this.txtIdPlaniEncab.Size = new System.Drawing.Size(164, 20);
            this.txtIdPlaniEncab.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(581, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Total USD";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Id PlanillaPago";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(291, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Tipo Cambio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(291, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Nombre del Colaborador";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(581, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Salario Neto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Id";
            // 
            // grBoxDetalle
            // 
            this.grBoxDetalle.Controls.Add(this.btnCalcular);
            this.grBoxDetalle.Controls.Add(this.dgvCalculoPlanilla);
            this.grBoxDetalle.Location = new System.Drawing.Point(103, 229);
            this.grBoxDetalle.Name = "grBoxDetalle";
            this.grBoxDetalle.Size = new System.Drawing.Size(966, 200);
            this.grBoxDetalle.TabIndex = 6;
            this.grBoxDetalle.TabStop = false;
            this.grBoxDetalle.Text = "Detalle";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(421, 156);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(119, 38);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            // 
            // dgvCalculoPlanilla
            // 
            this.dgvCalculoPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalculoPlanilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColaborador,
            this.NombreColaborador,
            this.HrsTrabajadas,
            this.HrsOrdinarias,
            this.HrsExtra,
            this.SalarioHora,
            this.TotalPagar,
            this.TotalExtras,
            this.TotalPercepciones});
            this.dgvCalculoPlanilla.Location = new System.Drawing.Point(6, 29);
            this.dgvCalculoPlanilla.Name = "dgvCalculoPlanilla";
            this.dgvCalculoPlanilla.Size = new System.Drawing.Size(941, 121);
            this.dgvCalculoPlanilla.TabIndex = 0;
            // 
            // IdColaborador
            // 
            this.IdColaborador.HeaderText = "Id Colaborador";
            this.IdColaborador.Name = "IdColaborador";
            // 
            // NombreColaborador
            // 
            this.NombreColaborador.HeaderText = "Nombre Colaborador";
            this.NombreColaborador.Name = "NombreColaborador";
            // 
            // HrsTrabajadas
            // 
            this.HrsTrabajadas.HeaderText = "Horas Trabajadas";
            this.HrsTrabajadas.Name = "HrsTrabajadas";
            // 
            // HrsOrdinarias
            // 
            this.HrsOrdinarias.HeaderText = "Horas Ordinarias";
            this.HrsOrdinarias.Name = "HrsOrdinarias";
            // 
            // HrsExtra
            // 
            this.HrsExtra.HeaderText = "Horas Extra";
            this.HrsExtra.Name = "HrsExtra";
            // 
            // SalarioHora
            // 
            this.SalarioHora.HeaderText = "Salario Hora";
            this.SalarioHora.Name = "SalarioHora";
            // 
            // TotalPagar
            // 
            this.TotalPagar.HeaderText = "Total Pagar";
            this.TotalPagar.Name = "TotalPagar";
            // 
            // TotalExtras
            // 
            this.TotalExtras.HeaderText = "Total Extras";
            this.TotalExtras.Name = "TotalExtras";
            // 
            // TotalPercepciones
            // 
            this.TotalPercepciones.HeaderText = "Total Percepciones";
            this.TotalPercepciones.Name = "TotalPercepciones";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Turquoise;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator8,
            this.btnAgregar,
            this.toolStripSeparator2,
            this.btnEditar,
            this.toolStripSeparator1,
            this.btnEliminar,
            this.toolStripSeparator3,
            this.btnLimpiar,
            this.toolStripSeparator4,
            this.btnPDF,
            this.toolStripSeparator5,
            this.btnCorreo,
            this.toolStripSeparator6,
            this.btnSalir,
            this.toolStripSeparator7});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(100, 441);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(97, 6);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(97, 24);
            this.btnAgregar.Text = "Agregar &";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(97, 6);
            // 
            // btnEditar
            // 
            this.btnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(97, 24);
            this.btnEditar.Text = "&Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(97, 6);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(97, 24);
            this.btnEliminar.Text = "&Eliminar";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(97, 6);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(97, 24);
            this.btnLimpiar.Text = "Limpiar &";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(97, 6);
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.White;
            this.btnPDF.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPDF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(97, 24);
            this.btnPDF.Text = "Exportar PDF";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(97, 6);
            // 
            // btnCorreo
            // 
            this.btnCorreo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCorreo.Name = "btnCorreo";
            this.btnCorreo.Size = new System.Drawing.Size(97, 20);
            this.btnCorreo.Text = "        Correo";
            this.btnCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(97, 6);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 24);
            this.btnSalir.Text = "&Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(97, 6);
            // 
            // FrmCalculoPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 441);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grBoxDetalle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCalculoPlanilla";
            this.Text = "Calculo Planilla";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grBoxDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalculoPlanilla)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEstadoPago;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpresaIdPago;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpHastaPago;
        private System.Windows.Forms.TextBox txtPlaniPago;
        private System.Windows.Forms.TextBox txtIdPlaniPago;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSalarioNeto;
        private System.Windows.Forms.TextBox txtUSD;
        private System.Windows.Forms.TextBox txtIdColaboradorEncab;
        private System.Windows.Forms.TextBox txtNombreColabEncab;
        private System.Windows.Forms.TextBox txtIdPagoEncab;
        private System.Windows.Forms.TextBox txtIdPlaniEncab;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grBoxDetalle;
        private System.Windows.Forms.DataGridView dgvCalculoPlanilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColaborador;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreColaborador;
        private System.Windows.Forms.DataGridViewTextBoxColumn HrsTrabajadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn HrsOrdinarias;
        private System.Windows.Forms.DataGridViewTextBoxColumn HrsExtra;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalExtras;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPercepciones;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DateTimePicker dtpDesdePago;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnLimpiar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnPDF;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel btnCorreo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    }
}