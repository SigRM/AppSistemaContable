using AppSistemaContable.Entidades;
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
using UTNLeccion8B.Utilities;

namespace AppSistemaContable.UI.Mantenimientos
{
    public partial class FrmPlanillaPago : Form
    {
        //Se crean las variables para la instancia del formulario
        public static bool HayInstancia = false;
        public static FrmPlanillaPago InstanciaActiva = null;
        Utiles utiles = new Utiles();  //Se crea una instancia a utilitarios
        LeerDatos leerDatos = new LeerDatos();
        List<PlanillaPago> planillaList = new List<PlanillaPago>(); //Se crea una instancia a la clase clientes como tipo lista
        private ErrorProvider oErrorProvider = new ErrorProvider();
        public FrmPlanillaPago()
        {
            InitializeComponent();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void cREARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                bool resultado = planillaList.Exists(x => x.Id.ToString() == txtId.Text.ToString());//Validamos si existe en la lista
                if (resultado)
                {
                    MessageBox.Show("The ID  " + txtId.Text + " already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtId.Text.ToString() == string.Empty)
                {//Si el campo txtCedula está vacio
                    errorProvider1.SetError(txtId, "Obligatory field"); //En caso de que estuviese vacío activa el control error provider
                    return; //regresa a pantalla
                }

                //Antes de grabar validamos los datos
                // Validar Cedula
                if (string.IsNullOrEmpty(FormatStrings.GetDNINoFormat(this.txtId.Text)))
                {
                    errorProvider1.SetError(this.txtId, "Incorrect");
                    return;
                }

                // ValidarNombre
                if (!LeerDatos.Es_Cadena(this.txtPlanilla))
                {
                    errorProvider1.SetError(this.txtPlanilla, "Incorrecto");
                    return;
                }

                // Validar Nombre
                if (!LeerDatos.Es_Numero(this.txtEmpresaId))
                {
                    errorProvider1.SetError(this.txtEmpresaId, "Incorrecto");
                    return;
                }

                grabarArchivo(); //Graba el archivo
                //Se muestra dato en el grid view
                this.dgvPlanillaPago.Rows.Add(txtId.Text, txtPlanilla.Text, txtEmpresaId.Text, dtpFechaDesde.Text, dtpFechaHasta.Text, dtpFechaPago.Text); //Agrega los valores 
                this.FrmPlanillaPago_Load(null, null);

                //Limpia los archivos
                // limpirDatos();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void FrmPlanillaPago_Load(object sender, EventArgs e)
        {
            txtId.Focus();  //Coloca el accionar del focus en el control textbox de la cedula
            HayInstancia = true; //Definición de variables para la instancia de carga de pantalla
            InstanciaActiva = this;
            planillaList.Clear(); //Limpiamos los datos
            errorProvider1.Clear();

            try
            {
                //Consulta si el archivo clientes.txt no existe 
                if (!File.Exists("planilla.txt"))
                {
                    StreamWriter archivo = new StreamWriter("planilla.txt");//En caso de no existir lo crea
                    archivo.Close();//Cierra el archivo
                }
                else
                {
                    StreamReader archivo = new StreamReader("planilla.txt");//Hace lectura del archivo plano
                    while (!archivo.EndOfStream) //Recorre el archivo
                    {
                        String datos = archivo.ReadLine();//Recorre los registros (cedula, nombre,edad, correo electrónico)
                        String[] registros = datos.Split(';');//Se realiza un split de los datos obtenidos
                        PlanillaPago cli = new PlanillaPago();//Se crea instancia de clientes
                        cli.Id = int.Parse(registros[0].ToString());//Se asignan los valores a la instancia
                        cli.NombrePlanilla = registros[1];
                        cli.EmpresaId = int.Parse(registros[2].ToString()); ;
                        cli.FechaDesde = DateTime.Parse(registros[3].ToString());
                        cli.FechaHasta= DateTime.Parse(registros[4].ToString()); ;
                        cli.FechaPago = DateTime.Parse(registros[5].ToString()); 
                        planillaList.Add(cli);//Se le agrega a la lista la instancia creada
                        //Formas de cargar un grid
                        //1- Por medio de agregacion
                        dgvPlanillaPago.Rows.Add(cli.Id, cli.NombrePlanilla, cli.EmpresaId, cli.FechaDesde, cli.FechaHasta, cli.FechaPago); //Agrega los datos en el grid view
                    }
                    archivo.Close();//Cierra el archivo
                    //2- Por medio del Dataset según una lista, para utilizar esta opcion se recomienda que no tenga columnas creadas
                    //var listaGrid = clientesList;
                    //dgvDatos.AutoGenerateColumns = true;
                    //dgvDatos.DataSource = listaGrid;
                }
               
            }
            catch (Exception er)
            {
                MessageBox.Show(utiles.mensajeCatch(er), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lIMPIARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEmpresaId.Clear();
            txtId.Clear();
            txtPlanilla.Clear();
            txtEmail.Clear();
        }

        private void grabarArchivo()
        {
            try
            {
                dgvPlanillaPago.DataSource = null;  //Limpiar el datagrid
                dgvPlanillaPago.Rows.Clear();//Limpiar el datagrid

                StreamWriter archivo = new StreamWriter("planilla.txt", true); //Abre el archivo y agrega el append del mismo


                archivo.WriteLine(txtId.Text + ";" + txtPlanilla.Text.ToString().ToUpper() + ";" + txtEmpresaId.Text.ToString().ToUpper(), dtpFechaDesde.ToString(), dtpFechaHasta.ToString(), dtpFechaPago.ToString());//Se agregan al registro
                archivo.Close(); //Cierra el archivo
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void eLIMINARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            BLL.BLLPlanillaPago.DELETE(id);
            
        }
        private void GrabarBorrado()
        {
            try
            {
                dgvPlanillaPago.DataSource = null;  //Limpiar el datagrid
                dgvPlanillaPago.Rows.Clear();//Limpiar el datagrid

                File.WriteAllText("planilla.txt", "");
                StreamWriter archivo = new StreamWriter("planilla.txt", true);//Realiza lectura del archivo y permite agregar datos (append)
                                                                               //Proceso para recorrer lo contenido en el grid
                                                                               //for (int i = 0; i < dgvDatos.Rows.Count; i++) //Realiza recorrido de filas (validar si tiene el habilitar agregar filas para dejar o eliminar el -1)
                                                                               //{
                                                                               //    archivo.WriteLine(dgvDatos.Rows[i].Cells[0].Value.ToString()); //Escribe en el archivo según apunte la fila y la columna correspondiente
                                                                               //    archivo.WriteLine(dgvDatos.Rows[i].Cells[1].Value.ToString());
                                                                               //    archivo.WriteLine(dgvDatos.Rows[i].Cells[2].Value.ToString());
                                                                               //}

                //Utilizando LinQ
                List<PlanillaPago> lista = planillaList.Where(x => x.ToString() != txtId.Text).ToList();//Obtenemos la lista de todos los registros donde la cedula sea diferente a lo que tiene la cedula del campo textCedula
                foreach (var item in lista)//Se recorre la lista de datos
                {
                    archivo.WriteLine(item.Id.ToString() + ";" + item.NombrePlanilla.ToString().ToUpper() + ";" + item.EmpresaId.ToString().ToUpper() + ";" + item.FechaDesde.ToString().ToUpper() + ";" + item.FechaHasta.ToString().ToLower() + ";" + item.FechaPago.ToString().ToUpper());//Se agregan al registro
                }
                archivo.Close();// Se cierra el registro
                planillaList.Clear();
            }
            catch (Exception er)
            {
                MessageBox.Show(utiles.mensajeCatch(er), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmPlanillaPago_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Se inactivan las variables creadas
            HayInstancia = false;
            InstanciaActiva = null;
        }

        private void pDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportarGrid exportar = new ExportarGrid();
            exportar.ExportarPDF2(dgvPlanillaPago, "Nuevo comprobante planilla");
        }

        private void dgvPlanillaPago_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvPlanillaPago.Rows.Count; i++) //Realiza recorrido de filas (validar si tiene el habilitar agregar filas para dejar o eliminar el -1)
                {
                    txtId.Text = this.dgvPlanillaPago.CurrentRow.Cells[0].Value.ToString();//Muestra los datos de la fila seleccionada y lo coloca en el campo Cedula
                    txtPlanilla.Text = this.dgvPlanillaPago.CurrentRow.Cells[1].Value.ToString();
                    txtEmpresaId.Text = this.dgvPlanillaPago.CurrentRow.Cells[2].Value.ToString();
                    dtpFechaDesde.Text = this.dgvPlanillaPago.CurrentRow.Cells[3].Value.ToString();
                    dtpFechaHasta.Text = this.dgvPlanillaPago.CurrentRow.Cells[4].Value.ToString();
                    dtpFechaPago.Text = this.dgvPlanillaPago.CurrentRow.Cells[4].Value.ToString();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(utiles.mensajeCatch(er), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eNVIARCORREOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Si txtCedula es diferente de vacio envia correo
                if (!txtId.Equals(""))
                {

                    //Construye los datos en una tabla por medio de HTML
                    String mensaje = "";
                    //Se crea una tabla algunos datos importantes para tomar en cuenta
                    //<tr>  definir una fila | <th> define un encabezado | <td> define una celda </tr> Cierre de fila | </th> Cierre de Encabezado  | </td>  Cierre de Celda  | <br>  Salto
                    mensaje += "<table width=100% border=1 cellpadding=0 cellspacing=0>";
                    //Se define una fila con una columna que dice UTN Ingreso
                    mensaje += "<tr><td bgcolor=#004080 style='color:white; padding:4px;' width=40%><strong><div align=center>App Sistema Contable</div></strong></td>";
                    //Se define una columna con estilo de color que indica mensaje
                    mensaje += "<td style='padding:4px;'>Nueva planilla Pago Sistema Contable.</td></tr>";
                    mensaje += "</table><br>"; //Cierre de tabla y realiza un saldo

                    //Creación de otra tabla 
                    mensaje += "<table width=100% border=1 cellpadding=0 cellspacing=0>";
                    //Creacion de fila y se agrega un encabezado con los datos de ESTOS SON SUS DATOS
                    mensaje += "<tr><th colspan=6 style='padding:4px;'>Esta es su informacion</th></tr>";
                    //CREACION DE FILA NUEVO
                    mensaje += "<tr>";
                    //CREACION DE CELDA CON EL TITULO CEDULA    "ENCABEZADO"
                    mensaje += "<th bgcolor=#004080 style='color:white; padding:4px;'><div align=center>ID</div></th>";
                    //CREACION DE CELDA CON EL TIUTLO DE NOMBRE    "ENCABEZADO"
                    mensaje += "<th bgcolor=#004080 style='color:white; padding:4px;'><div align=center>NOMBRE</div></th>";
                    //CREACION DE CELDA CON TITULO DE EDAD   "ENCABEZADO"
                    mensaje += "<th bgcolor=#004080 style='color:white; padding:4px;'><div align=center>IDEMPRESA</div></th>";
                    //CREACION DE CELDA CON TITULO DE EDAD   "ENCABEZADO"
                    mensaje += "<th bgcolor=#004080 style='color:white; padding:4px;'><div align=center>FECHADESDE</div></th>";
                    //CREACION DE CELDA CON TITULO DE EDAD   "ENCABEZADO"
                    mensaje += "<th bgcolor=#004080 style='color:white; padding:4px;'><div align=center>FECHAHASTA</div></th>";
                    //CREACION DE CELDA CON TITULO DE EDAD   "ENCABEZADO"
                    mensaje += "<th bgcolor=#004080 style='color:white; padding:4px;'><div align=center>FECHAPAGO</div></th>";
                    //fIN DE FILA CREADA
                    mensaje += "</tr>";
                    //CRAECION DE NUEVA FILA
                    mensaje += "<tr>";
                    //SE AGREGAN LOS VALORES EN CELDAS NUEVAS CONSTRUYENDO EL STRING
                    mensaje += String.Format("<td style='padding:4px;'><div align=center>{0}</div></td>", txtId.Text);
                    mensaje += String.Format("<td style='padding:4px;'><div align=center>{0}</div></td>", txtPlanilla.Text);
                    mensaje += String.Format("<td style='padding:4px;'><div align=center>{0}</div></td>", txtEmpresaId.Text);
                    mensaje += String.Format("<td style='padding:4px;'><div align=center>{0}</div></td>", dtpFechaDesde.Text);
                    mensaje += String.Format("<td style='padding:4px;'><div align=center>{0}</div></td>", dtpFechaHasta.Text);
                    mensaje += String.Format("<td style='padding:4px;'><div align=center>{0}</div></td>", dtpFechaPago.Text);

                    mensaje += "</tr>";
                    //FIN DE CREACION DE TABLA
                    mensaje += "</table>";


                    String asunto = "Planilla incluida";
                    //String ruta = Path.GetFullPath(@"..\..\Instrucciones\Practica_Leccion02.pdf");
                    String ruta = "";
                    String adjunto = ruta;
                    String receptor = txtEmail.Text;
                    EnviarCorreo envioCorreo = new EnviarCorreo();
                    envioCorreo.enviarCorreoGmail(mensaje.ToString(), receptor, asunto, adjunto);

                }
                else
                {
                    MessageBox.Show("Email cannot be send", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(utiles.mensajeCatch(er), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
