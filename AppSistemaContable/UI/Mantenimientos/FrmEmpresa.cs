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
    public partial class FrmEmpresa : Form
    {
        Utiles utiles = new Utiles();  //Se crea una instancia a utilitarios
        List<Empresa> employeeList = new List<Empresa>();
        public FrmEmpresa()
        {
            InitializeComponent();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                bool resultado = employeeList.Exists(x => x.Identificacion.ToString() == txtId.Text.ToString());//Validamos si existe en la lista
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
                    errorProvider1.SetError(this.txtId, "ID number incorrect");
                    return;
                }

                this.dataGridView1.Rows.Add(txtId.Text, cmbTipoId.Text, txtNombre.Text, txtTelefono.Text, txtDireccion.Text);
                this.FrmEmpresa_Load(null, null);

                //Limpia los archivos
                // limpirDatos();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {
            employeeList.Clear(); //Limpiamos los datos
            errorProvider1.Clear();

            try
            {
                //Consulta si el archivo clientes.txt no existe 
                if (!File.Exists("Empresa.txt"))
                {
                    StreamWriter archivo = new StreamWriter("Empresa.txt");//En caso de no existir lo crea
                    archivo.Close();//Cierra el archivo
                }
                else
                {
                    StreamReader archivo = new StreamReader("Empresa.txt");//Hace lectura del archivo plano
                    while (!archivo.EndOfStream) //Recorre el archivo
                    {
                        String datos = archivo.ReadLine();//Recorre los registros (cedula, nombre,edad, correo electrónico)
                        String[] registros = datos.Split(';');//Se realiza un split de los datos obtenidos
                        Empresa cli = new Empresa();//Se crea instancia de clientes
                        cli.Identificacion= int.Parse(registros[0].ToString());//Se asignan los valores a la instancia
                        cli.TipoIdentificacion = registros[1];
                        cli.Nombre = registros[2];
                        cli.Telefono = registros[3];
                        cli.Direccion = registros[4];
                        //cli.Logo = byte.Parse(registros[5].ToString());
                        cli.Estado = bool.Parse(registros[6].ToString());

                        employeeList.Add(cli);//Se le agrega a la lista la instancia creada
                        //Formas de cargar un grid
                        //1- Por medio de agregacion
                        dataGridView1.Rows.Add(cli.Identificacion, cli.TipoIdentificacion, cli.Nombre, cli.Telefono, cli.Direccion, cli.Estado);
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

        private void grabarArchivo()
        {
            try
            {
                dataGridView1.DataSource = null;  //Limpiar el datagrid
                dataGridView1.Rows.Clear();//Limpiar el datagrid

                StreamWriter archivo = new StreamWriter("empresa.txt", true); //Abre el archivo y agrega el append del mismo


                archivo.WriteLine(txtId.Text.ToString(), cmbTipoId.Text.ToString(), txtNombre.Text.ToString(), txtTelefono.Text.ToString(), txtDireccion.Text.ToString());
                archivo.Close(); //Cierra el archivo
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtId.Clear();
            txtDireccion.Clear();

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            BLL.BLLEmpresa.DELETE(id);
            RefrescarLista();
            
        }

        private void RefrescarLista()
        {
            try
            {
                dataGridView1.AutoGenerateColumns = true;
               // this.AplicarFormatoDataGridView();
                dataGridView1.DataSource = BLL.BLLEmpresa.SelectAll();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al Refrescar la tabla " + error.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
