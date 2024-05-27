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
    public partial class FrmSolicitudVacaciones : Form
    {
        //Se crean las variables para la instancia del formulario
        public static bool HayInstancia = false;
        public static FrmSolicitudVacaciones InstanciaActiva = null;
        LeerDatos leerDatos = new LeerDatos();
        List<SolicitudesVacaciones> solicitudList = new List<SolicitudesVacaciones>(); //Se crea una instancia a la clase clientes como tipo lista
        private ErrorProvider oErrorProvider = new ErrorProvider();


        public FrmSolicitudVacaciones()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método que permite guardar la información en el archivo solicitudVacaciones.txt
        /// </summary>
        private void grabarArchivo()
        {
            try
            {
                dgvSolitudVacaciones.DataSource = null;  //Limpiar el datagrid
                dgvSolitudVacaciones.Rows.Clear();//Limpiar el datagrid

                StreamWriter archivo = new StreamWriter("solicituVacaciones.txt", true); //Abre el archivo y agrega el append del mismo

                //Verificar si el orden afecta                
                archivo.WriteLine(txtIdColaborador.Text + ";" + dtpSolicitud.Text.ToString().ToUpper() + ";" + dtpDesde.Text.ToString().ToUpper() + ";" + dtpHasta.Text.ToString().ToUpper() + ";" + txtObservaciones.Text.ToString().ToLower() + chkEstado.Text.ToString().ToLower() + nupCantDias.Text.ToString().ToLower());//Se agregan al registro
                archivo.Close(); //Cierra el archivo
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtIdColaborador.Text.Equals(""))
                {
                    bool resultado = solicitudList.Exists(x => x.IdColaborador.ToString() == txtIdColaborador.Text.ToString());//Validamos si existe en la lista
                    //Utilizando LinQ se consulta si existe el valor a borrar
                    if (resultado)
                    {
                        for (int i = 0; i < dgvSolitudVacaciones.Rows.Count; i++)//Se recorre el contenido de todas las filas del grid menos 1 dado a que el grid mantiene la linea de carga activa si se elimina la opción de agregar linea en el grid entonces se procede a quitar el menos 1
                        {
                            if (txtIdColaborador.Text == dgvSolitudVacaciones.Rows[i].Cells[0].Value.ToString())
                            {//Si el dato de la cedula indicado es igual al valor que apunta la fila en la columna 0= Cedula
                                dgvSolitudVacaciones.Rows.RemoveAt(i); //Elimina la línea del grid que está apuntando
                                GrabarBorrado(); //Realiza proceso de eliminado del archivo
                                MessageBox.Show("Solicitud eliminada", "Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);//Muestra mensaje
                            }
                        }
                        //  this.FrmCustomers_Load(null, null);//Hacemos instancia del load
                    }
                }
                else
                {
                    errorProvider1.SetError(txtIdColaborador, "Espacio obligatorio");
                }
                limpirDatos();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                bool resultado = solicitudList.Exists(x => x.IdColaborador.ToString() == txtIdColaborador.Text.ToString());//Validamos si existe en la lista
                if (resultado)
                {
                    MessageBox.Show("El ID  " + txtIdColaborador.Text + " ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtIdColaborador.Text.ToString() == string.Empty)
                {//Si el campo txtCedula está vacio
                    errorProvider1.SetError(txtIdColaborador, "Espacio Obligatorio"); //En caso de que estuviese vacío activa el control error provider
                    return; //regresa a pantalla
                }

                //Antes de grabar validamos los datos
                // Validar Id
                if (string.IsNullOrEmpty(FormatStrings.GetDNINoFormat(this.txtIdColaborador.Text)))
                {
                    errorProvider1.SetError(this.txtIdColaborador, "Numero de Id Incorrecto");
                    return;
                }


                grabarArchivo(); //Graba el archivo
                //Se muestra dato en el grid view
                this.dgvSolitudVacaciones.Rows.Add(txtIdColaborador.Text, dtpSolicitud.Text, dtpDesde.Text, dtpHasta.Text, nupCantDias.Text, txtObservaciones.Text, chkEstado.Text); //Agrega los valores de cedula, nombre y edad
                this.FrmSolicitudVacaciones_Load(null, null);


                limpirDatos();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        public void limpirDatos()
        {
            txtIdColaborador.Clear();

        }

        private void FrmSolicitudVacaciones_Load(object sender, EventArgs e)
        {
            txtIdColaborador.Focus();  //Coloca el accionar del focus en el control textbox de la cedula
            HayInstancia = true; //Definición de variables para la instancia de carga de pantalla
            InstanciaActiva = this;
            solicitudList.Clear(); //Limpiamos los datos
            errorProvider1.Clear();

            try
            {
                //Consulta si el archivo clientes.txt no existe 
                if (!File.Exists("solicitudVacaciones.txt"))
                {
                    StreamWriter archivo = new StreamWriter("solicitudVacaciones.txt");//En caso de no existir lo crea
                    archivo.Close();//Cierra el archivo
                }
                else
                {
                    StreamReader archivo = new StreamReader("solicitudVacaciones.txt");//Hace lectura del archivo plano
                    while (!archivo.EndOfStream) //Recorre el archivo
                    {
                        String datos = archivo.ReadLine();//Recorre los registros (cedula, nombre,edad, correo electrónico)
                        String[] registros = datos.Split(';');//Se realiza un split de los datos obtenidos
                        SolicitudesVacaciones cli = new SolicitudesVacaciones();//Se crea instancia de clientes
                        cli.IdColaborador = int.Parse(registros[0].ToString());//Se asignan los valores a la instancia
                        cli.FechaSolicitud = DateTime.Parse(registros[1].ToString());
                        cli.FechaSolicitarDesde = DateTime.Parse(registros[2].ToString());
                        cli.FechaSolicitarHasta = DateTime.Parse(registros[3].ToString());
                        cli.CantidadDias = int.Parse(registros[4].ToString());
                        cli.Observaciones = registros[5];
                        cli.Estado = Boolean.Parse(registros[6].ToString());
                        solicitudList.Add(cli);//Se le agrega a la lista la instancia creada
                        //Formas de cargar un grid
                        //1- Por medio de agregacion
                        dgvSolitudVacaciones.Rows.Add(cli.IdColaborador, cli.FechaSolicitud, cli.FechaSolicitarDesde, cli.FechaSolicitarHasta, cli.CantidadDias, cli.Observaciones, cli.Estado); //Agrega los datos en el grid view
                    }
                    archivo.Close();//Cierra el archivo
                    //2- Por medio del Dataset según una lista, para utilizar esta opcion se recomienda que no tenga columnas creadas
                    //var listaGrid = clientesList;
                    //dgvDatos.AutoGenerateColumns = true;
                    //dgvDatos.DataSource = listaGrid;
                }
                limpirDatos();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void GrabarBorrado()
        {
            try
            {
                dgvSolitudVacaciones.DataSource = null;  //Limpiar el datagrid
                dgvSolitudVacaciones.Rows.Clear();//Limpiar el datagrid

                File.WriteAllText("solicitudVacaciones.txt", "");
                StreamWriter archivo = new StreamWriter("solicitudVacaciones.txt", true);//Realiza lectura del archivo y permite agregar datos (append)
                                                                                         //Proceso para recorrer lo contenido en el grid
                                                                                         //for (int i = 0; i < dgvDatos.Rows.Count; i++) //Realiza recorrido de filas (validar si tiene el habilitar agregar filas para dejar o eliminar el -1)
                                                                                         //{
                                                                                         //    archivo.WriteLine(dgvDatos.Rows[i].Cells[0].Value.ToString()); //Escribe en el archivo según apunte la fila y la columna correspondiente
                                                                                         //    archivo.WriteLine(dgvDatos.Rows[i].Cells[1].Value.ToString());
                                                                                         //    archivo.WriteLine(dgvDatos.Rows[i].Cells[2].Value.ToString());
                                                                                         //}

                //Utilizando LinQ
                List<SolicitudesVacaciones> lista = solicitudList.Where(x => x.ToString() != txtIdColaborador.Text).ToList();//Obtenemos la lista de todos los registros donde la cedula sea diferente a lo que tiene la cedula del campo textCedula
                foreach (var item in lista)//Se recorre la lista de datos
                {
                    archivo.WriteLine(item.IdColaborador.ToString() + ";" + item.FechaSolicitud.ToString() + ";" + item.FechaSolicitarDesde.ToString() + ";" + item.FechaSolicitarHasta.ToString() + ";" + item.CantidadDias.ToString() + item.Observaciones.ToString() + item.Estado.ToString() + ";");//Se agregan al registro
                }
                archivo.Close();// Se cierra el registro
                solicitudList.Clear();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void FrmSolicitudVacaciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Se inactivan las variables creadas
            HayInstancia = false;
            InstanciaActiva = null;
        }

        private void dgvSolitudVacaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvSolitudVacaciones.Rows.Count; i++) //Realiza recorrido de filas (validar si tiene el habilitar agregar filas para dejar o eliminar el -1)
                {
                    txtIdColaborador.Text = this.dgvSolitudVacaciones.CurrentRow.Cells[0].Value.ToString();//Muestra los datos de la fila seleccionada y lo coloca en el campo Cedula
                    dtpSolicitud.Text = this.dgvSolitudVacaciones.CurrentRow.Cells[1].Value.ToString();
                    dtpDesde.Text = this.dgvSolitudVacaciones.CurrentRow.Cells[3].Value.ToString();
                    dtpHasta.Text = this.dgvSolitudVacaciones.CurrentRow.Cells[4].Value.ToString();
                    nupCantDias.Text = this.dgvSolitudVacaciones.CurrentRow.Cells[5].Value.ToString();
                    txtObservaciones.Text = this.dgvSolitudVacaciones.CurrentRow.Cells[4].Value.ToString();
                    chkEstado.Text = this.dgvSolitudVacaciones.CurrentRow.Cells[5].Value.ToString();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void txtIdColaborador_KeyUp(object sender, KeyEventArgs e)
        {
            if (LeerDatos.Es_Numero(this.txtIdColaborador))
            {
                errorProvider1.SetError(this.txtIdColaborador, String.Empty);
                this.txtIdColaborador.BackColor = Color.Honeydew;
            }
            else
            {
                errorProvider1.SetError(this.txtIdColaborador, "Solo Numeros!!!");
                this.txtIdColaborador.BackColor = Color.MistyRose;
            }
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            ExportarGrid exportar = new ExportarGrid();
            exportar.ExportarPDF2(dgvSolitudVacaciones, "Nueva Solicitud de Vacaciones");
        }

        private void cmbOservaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
