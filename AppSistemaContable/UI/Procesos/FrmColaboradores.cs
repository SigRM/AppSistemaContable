using AppSistemaContable.Entidades;
using AppSistemaContable.Enumeradores;
using AppSistemaContable.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSistemaContable.UI.Procesos
{
    public partial class FrmColaboradores : Form
    {
        private ErrorProvider oErrorProvider = new ErrorProvider();
        Utiles utiles = new Utiles();

        public FrmColaboradores()
        {
            InitializeComponent();
        }

        //pdf
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            ExportarGrid exportar = new ExportarGrid();
            exportar.ExportarPDF2(dataGridView1, "Nueva Planilla");
        }

        //email
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            try
            {
                //Si txtCedula es diferente de vacio envia correo
                if (!txtID.Equals(""))
                {

                    //Construye los datos en una tabla por medio de HTML
                    String mensaje = "";
                    //Se crea una tabla algunos datos importantes para tomar en cuenta
                    //<tr>  definir una fila | <th> define un encabezado | <td> define una celda </tr> Cierre de fila | </th> Cierre de Encabezado  | </td>  Cierre de Celda  | <br>  Salto
                    mensaje += "<table width=100% border=1 cellpadding=0 cellspacing=0>";
                    //Se define una fila con una columna que dice UTN Ingreso
                    mensaje += "<tr><td bgcolor=#004080 style='color:white; padding:4px;' width=40%><strong><div align=center>Magic Book Library</div></strong></td>";
                    //Se define una columna con estilo de color que indica mensaje
                    mensaje += "<td style='padding:4px;'>This is a confirmation email for your new account in our bookstore.</td></tr>";
                    mensaje += "</table><br>"; //Cierre de tabla y realiza un saldo

                    //Creación de otra tabla 
                    mensaje += "<table width=100% border=1 cellpadding=0 cellspacing=0>";
                    //Creacion de fila y se agrega un encabezado con los datos de ESTOS SON SUS DATOS
                    mensaje += "<tr><th colspan=6 style='padding:4px;'>This is your information</th></tr>";
                    //CREACION DE FILA NUEVO
                    mensaje += "<tr>";
                    //CREACION DE CELDA CON EL TITULO CEDULA    "ENCABEZADO"
                    mensaje += "<th bgcolor=#004080 style='color:white; padding:4px;'><div align=center>ID</div></th>";
                    //CREACION DE CELDA CON EL TIUTLO DE NOMBRE    "ENCABEZADO"
                    mensaje += "<th bgcolor=#004080 style='color:white; padding:4px;'><div align=center>NAME</div></th>";
                    //CREACION DE CELDA CON TITULO DE EDAD   "ENCABEZADO"
                    mensaje += "<th bgcolor=#004080 style='color:white; padding:4px;'><div align=center>EMAIL</div></th>";
                    //CREACION DE CELDA CON TITULO DE EDAD   "ENCABEZADO"
                    mensaje += "<th bgcolor=#004080 style='color:white; padding:4px;'><div align=center>ADDRESSL</div></th>";
                    //CREACION DE CELDA CON TITULO DE EDAD   "ENCABEZADO"
                    mensaje += "<th bgcolor=#004080 style='color:white; padding:4px;'><div align=center>PHONE</div></th>";
                    //fIN DE FILA CREADA
                    mensaje += "</tr>";
                    //CRAECION DE NUEVA FILA
                    mensaje += "<tr>";
                    //SE AGREGAN LOS VALORES EN CELDAS NUEVAS CONSTRUYENDO EL STRING
                    mensaje += String.Format("<td style='padding:4px;'><div align=center>{0}</div></td>", txtID.Text);
                    mensaje += String.Format("<td style='padding:4px;'><div align=center>{0}</div></td>", txtNombre.Text);
                    mensaje += String.Format("<td style='padding:4px;'><div align=center>{0}</div></td>", txtEmail.Text);
                    mensaje += String.Format("<td style='padding:4px;'><div align=center>{0}</div></td>", txtSalarioHora.Text);
                    mensaje += String.Format("<td style='padding:4px;'><div align=center>{0}</div></td>", txtTelefono.Text);

                    mensaje += "</tr>";
                    //FIN DE CREACION DE TABLA
                    mensaje += "</table>";


                    String asunto = "Colaborador incluido";
                  
                    String ruta = "";
                    String adjunto = ruta;
                    String receptor = txtEmail.Text;
                    EnviarCorreo envioCorreo = new EnviarCorreo();
                    envioCorreo.enviarCorreoGmail(mensaje.ToString(), receptor, asunto, adjunto);

                }
                else
                {
                    MessageBox.Show("El correo no puede ser enviado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(utiles.mensajeCatch(er), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            if (LeerDatos.Es_Cadena(this.txtNombre))
            {
                errorProvider1.SetError(this.txtNombre, String.Empty);
                this.txtNombre.BackColor = Color.Honeydew;
            }
            else
            {
                errorProvider1.SetError(this.txtNombre, "Solo letras!!!");
                this.txtNombre.BackColor = Color.MistyRose;
            }
        }


        private void LimpiarControles()
        {
            try
            {
                txtNombre.Clear();
                txtApellidos.Clear();
                txtID.Clear();
                txtDireccion.Clear();
                txtDepartamento.Clear();
                txtSupervisor.Clear();
                txtPuesto.Clear();
                txtSalarioHora.Text = "0";
                txtTelefono.Clear();
                dtpFechaNacimiento.Value = DateTime.Today;
                dtpFechaIngreso.Value = DateTime.Today;
                txtEmail.Clear();
                txtCuentaIBAN.Clear();
                cmbRoles.SelectedIndex = 0; ;
                txtUsuario.Clear();
                txtContrasena.Clear();
                // chkEstado.

            }
            catch (Exception error)
            {
                MessageBox.Show("Error al limpiar controles " + error.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetUI(char pOpcion)
        {
            //Inactivar botones de menu
          /*  foreach (ToolStripButton item in this.toolStrip1.Items)
            {
                item.Enabled = false;
            }*/
            //Inactivar controles
            txtNombre.Enabled = false;
            txtApellidos.Enabled = false;
            txtID.Enabled = false;
            txtDepartamento.Enabled = false;
            txtSupervisor.Enabled = false;
            txtPuesto.Enabled = false;
            txtSalarioHora.Enabled = false;
            txtTelefono.Enabled = false;
            dtpFechaNacimiento.Enabled = false;
            dtpFechaIngreso.Enabled = false;
            txtEmail.Enabled = false;
            txtCuentaIBAN.Enabled = false;
            cmbRoles.Enabled = false;
            txtUsuario.Enabled = false;
            txtContrasena.Enabled = false;
            //chkEstado

            switch (pOpcion)
            {
                case 'C': //Create
                    btnEditar.Enabled = true;
                    btnAgregar.Enabled = true;
                    btnSalir.Enabled = true;

                    txtNombre.Enabled = true;
                    txtApellidos.Enabled = true;
                    txtID.Enabled = true;
                    txtDepartamento.Enabled = true;
                    txtSupervisor.Enabled = true;
                    txtPuesto.Enabled = true;
                    txtSalarioHora.Enabled = true;
                    txtTelefono.Enabled = true;
                    dtpFechaNacimiento.Enabled = true;
                    dtpFechaIngreso.Enabled = true;
                    txtEmail.Enabled = true;
                    txtCuentaIBAN.Enabled = true;
                    cmbRoles.Enabled = true;
                    txtUsuario.Enabled = true;
                    txtContrasena.Enabled = true;
                    // chkEstado.

                    txtID.Focus();

                    break;
                case 'U': //UPDATE
                    btnLimpiar.Enabled = true;
                    btnSalir.Enabled = true;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;

                    txtNombre.Enabled = true;
                    txtApellidos.Enabled = true;
                    txtID.Enabled = false;
                    txtDepartamento.Enabled = true;
                    txtSupervisor.Enabled = true;
                    txtPuesto.Enabled = true;
                    txtSalarioHora.Enabled = true;
                    txtTelefono.Enabled = true;
                    dtpFechaNacimiento.Enabled = true;
                    dtpFechaIngreso.Enabled = true;
                    txtEmail.Enabled = true;
                    txtCuentaIBAN.Enabled = true;
                    cmbRoles.Enabled = true;
                    txtUsuario.Enabled = true;
                    txtContrasena.Enabled = true;
                    // chkEstado.

                    txtNombre.Focus();
                    break;
                case 'D': //DELETE
                    btnLimpiar.Enabled = true;
                    btnSalir.Enabled = true;
                    btnEliminar.Enabled = true;

                    txtNombre.Enabled = false;
                    txtApellidos.Enabled = false;
                    txtID.Enabled = false;
                    txtDepartamento.Enabled = false;
                    txtSupervisor.Enabled = false;
                    txtPuesto.Enabled = false;
                    txtSalarioHora.Enabled = false;
                    txtTelefono.Enabled = false;
                    dtpFechaNacimiento.Enabled = false;
                    dtpFechaIngreso.Enabled = false;
                    txtEmail.Enabled = false;
                    txtCuentaIBAN.Enabled = false;
                    cmbRoles.Enabled = false;
                    txtUsuario.Enabled = false;
                    txtContrasena.Enabled = false;
                    // chkEstado.
                    break;
            }

        }

        private void RefrescarLista()
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                this.AplicarFormatoDataGridView();
                dataGridView1.DataSource = BLL.BLLColaboradores.SelectAll();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al Refrescar la tabla " + error.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CrearActualizarDatos()
        {
            Colaboradores colaboradores = new Colaboradores();
            Roles roles = (Roles)this.cmbRoles.SelectedItem;
            Puestos puesto = (Puestos) cmbPuestos.SelectedItem;

            colaboradores.Identificacion = txtID.Text;
            colaboradores.Nombre = txtNombre.Text;
            colaboradores.Apellidos = txtApellidos.Text;
            colaboradores.FechaNacimiento = dtpFechaNacimiento.Value;
            colaboradores.Direccion = txtDireccion.Text;
            colaboradores.FechaIngreso = dtpFechaNacimiento.Value;
            colaboradores.Departamento = txtDepartamento.Text;
            colaboradores.SalarioHora = decimal.Parse(txtSalarioHora.Text);
            colaboradores.Fotografia = (byte[])pictureBox1.Tag;
            colaboradores.CorreoElectronico = txtEmail.Text;
            colaboradores.SupervisorACargo = int.Parse(txtSupervisor.Text);
            colaboradores.CuentaIBAN = txtCuentaIBAN.Text;
            colaboradores.Usuario = txtUsuario.Text;
            colaboradores.Contrasena = txtContrasena.Text;
            colaboradores.Rol = roles;
            colaboradores.Puesto = puesto; 

            //Guardar los datos
            BLL.BLLColaboradores.CREATE(colaboradores);
            //Refrescar pantalla
            RefrescarLista();
            //Limpiamos ambiente
            ResetUI('C');
            //Limpiamos controles
            LimpiarControles();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            ResetUI('C');
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            CrearActualizarDatos();
        }

        private void FrmColaboradores_Load(object sender, EventArgs e)
        {
            //Cargar ComboBox
            cmbRoles.Items.Add(new Roles() { Codigo = 'A', Nombre = Enums.RolesColaborador.Administrador.ToString() });
            cmbRoles.Items.Add(new Roles() { Codigo = 'C', Nombre = Enums.RolesColaborador.Colaborador.ToString() });
            cmbRoles.Items.Add(new Roles() { Codigo = 'S', Nombre = Enums.RolesColaborador.Supervisor.ToString() });

            //Cargar ComboBox
            cmbPuestos.Items.Add(new Puestos() { Codigo = 'A', NombrePuesto = Enums.Puesto.Analista.ToString() });
            cmbPuestos.Items.Add(new Puestos() { Codigo = 'A', NombrePuesto = Enums.Puesto.Asistente.ToString() });
            cmbPuestos.Items.Add(new Puestos() { Codigo = 'G', NombrePuesto = Enums.Puesto.Gerente.ToString() });
            cmbPuestos.Items.Add(new Puestos() { Codigo = 'C', NombrePuesto = Enums.Puesto.Contador.ToString() });
            cmbPuestos.Items.Add(new Puestos() { Codigo = 'S', NombrePuesto = Enums.Puesto.SoporteTecnico.ToString() });
            //Refrescar lista
            RefrescarLista();
            //Preparar el ambiente
            ResetUI('C');
            //Cargar combos
            cargarCombos();
            //Limpiar controles
            LimpiarControles();
        }

        private void cargarCombos()
        {
            cmbRoles.DataSource = BLL.BLLRoles.SelectAll();
            cmbPuestos.DataSource = BLL.BLLPuestos.SelectAll();

        }

        private void txtSalarioHora_Leave(object sender, EventArgs e)
        {
            //this.txtSalarioUSD.Text = txtSalarioCRC.Text;
            double tipoCambioVenta = 1;
            ServiceBCCR services = new ServiceBCCR();
            List<Dolar> cambioDolar = services.GetDolar(DateTime.Today, DateTime.Today, "v").ToList();
            if (cambioDolar != null)
            {
                tipoCambioVenta = cambioDolar[0].Monto;
            }
            this.txtSalarioHora.Text = Math.Round((Double.Parse(this.txtSalarioHora.Text) / tipoCambioVenta), 2).ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                // Mostrar el Dialogo de archivos
                OpenFileDialog opt = new OpenFileDialog();
                // Parametros del dialogo
                opt.Title = "Seleccione la imagen";
                opt.SupportMultiDottedExtensions = true;
                opt.DefaultExt = "*.jpg";
                opt.Filter = "Archivos de Imagenes (*.jpg)|*.jpg| All files (*.*)|*.*";
                opt.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                opt.FileName = "";

                if (opt.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        this.pictureBox1.ImageLocation = opt.FileName;
                        this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                        byte[] cadenaBytes = File.ReadAllBytes(opt.FileName);

                        this.pictureBox1.Tag = (byte[])cadenaBytes;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:  " + ex.Message);
                    }
                }
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);
                msg.AppendFormat("InnerException {0}\n", er.InnerException);
                msg.AppendFormat("StackTrace     {0}\n", er.StackTrace);
                msg.AppendFormat("TargetSite     {0}\n", er.TargetSite);
                //MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.oErrorProvider.SetError(this.pictureBox1, msg.ToString());
            }
        }

        private void AplicarFormatoDataGridView()
        {
            // Color de fondo Blanco
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            // Color intercalado Gris Claro
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            // Sin bordes
            this.dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            // Color de elemento seleccionado verde marino    
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            // Color de letra seleccionada blanco
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            // WrpMode = false
            this.dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            // Columnas centradas
            // Seleccion de fila cuando se selecciona alguna celda
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Permitir al usuario cambiar tamano de columnas
            this.dataGridView1.AllowUserToResizeColumns = true;
            // Auto Resize Columnas
            foreach (DataGridViewColumn col in this.dataGridView1.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            Roles roles = cmbRoles.SelectedItem as Roles;
            cmbRoles.DataSource = BLL.BLLRoles.SelectAll(); 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            BLL.BLLColaboradores.DELETE(id);
            RefrescarLista();
            ResetUI('C');
            LimpiarControles();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dataGridView1.SelectedRows.Count == 1)
                {
                    //Creamos instancia de usuarios
                    Colaboradores oUsuario = new Colaboradores();
                    oUsuario = this.dataGridView1.SelectedRows[0].DataBoundItem as Colaboradores;  //Asignamos el valor seleccionado
                                                                                                   //Asignamos los valores a cada control
                    this.txtID.Text = oUsuario.Identificacion.ToString();
                    this.txtNombre.Text = oUsuario.Nombre.ToString();
                    this.txtApellidos.Text = oUsuario.Apellidos.ToString();
                    this.dtpFechaNacimiento.Value = oUsuario.FechaNacimiento;
                    this.txtDireccion.Text = oUsuario.Direccion.ToString();
                    this.dtpFechaIngreso.Value = oUsuario.FechaIngreso;
                    this.txtDepartamento.Text = oUsuario.Departamento.ToString();
                    this.txtSalarioHora.Text = oUsuario.SalarioHora.ToString();
                    this.txtEmail.Text = oUsuario.CorreoElectronico.ToString();
                    this.txtSupervisor.Text = oUsuario.SupervisorACargo.ToString();                   
                    this.txtCuentaIBAN.Text = oUsuario.CuentaIBAN.ToString();
                    this.txtUsuario.Text = oUsuario.Usuario.ToString();
                    this.txtContrasena.Text = oUsuario.Contrasena.ToString();
                    this.chkEstado.Text = oUsuario.Estado.ToString();
                    this.cmbRoles.Text = oUsuario.Rol.ToString();
                    this.txtPuesto.Text = oUsuario.Puesto.ToString();


                    if (oUsuario.Rol.Equals('A'))
                        this.cmbRoles.Text = Enums.RolesColaborador.Administrador.ToString();

                    if (oUsuario.Rol.Equals('S'))
                        this.cmbRoles.Text = Enums.RolesColaborador.Supervisor.ToString();

                    if (oUsuario.Rol.Equals('C'))
                        this.cmbRoles.Text = Enums.RolesColaborador.Colaborador.ToString();


                    if (oUsuario.Fotografia != null)
                    {
                        this.pictureBox1.Image = new Bitmap(new MemoryStream(oUsuario.Fotografia));
                        this.pictureBox1.Tag = oUsuario.Fotografia;
                        this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }

                    if (oUsuario.Puesto.Equals('A'))
                        this.cmbPuestos.Text = Enums.Puesto.Analista.ToString();

                    if (oUsuario.Puesto.Equals('S'))
                        this.cmbPuestos.Text = Enums.Puesto.Asistente.ToString();

                    if (oUsuario.Puesto.Equals('C'))
                        this.cmbPuestos.Text = Enums.Puesto.Contador.ToString();

                   
                    if (oUsuario.Puesto.Equals('C'))
                        this.cmbPuestos.Text = Enums.Puesto.SoporteTecnico.ToString();

                    // Reset UI
                    this.ResetUI('U');
                }
            }
            catch (NullReferenceException)
            {
                // Do nothing;
            }
        }

        private void cmbPuestos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Puestos puestos = cmbPuestos.SelectedItem as Puestos;
            cmbPuestos.DataSource = BLL.BLLPuestos.SelectAll(); 
        }
    }
}



