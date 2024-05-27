using AppSistemaContable.Entidades;
using AppSistemaContable.Enumeradores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSistemaContable.UI.Procesos
{
    public partial class FrmLogIn : Form
    {
        private int contador = 0;
        private int indicativo = 0;
        private string userDato = "";
        private string passDato = "";
        public FrmLogIn(int pIndicativo, string pUserDato, string pPassDato)
        {
            indicativo = pIndicativo;
            userDato = pUserDato;
            passDato = pPassDato;
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Colaboradores oUser = Colaboradores.GetInstance();
                oUser.Usuario = this.txtUsuario.Text;
                oUser.Contrasena = this.txtContrasena.Text;
                oUser.rol1 = this.cmbRoles.Text; //COMO PODRIA PONERLOS DE TIPO OBJETO
               if ((oUser.rol1.ToString().Trim().ToUpper().Equals("ADMINISTRADOR") && oUser.Usuario.ToString().Trim().ToUpper().Equals("ADMIN") && oUser.Contrasena.ToString().Trim().ToUpper().Equals("123456")) ||
                    (oUser.rol1.ToString().Trim().ToUpper().Equals("SUPERVISOR") && oUser.Usuario.ToString().Trim().ToUpper().Equals("SUPERVISOR") && oUser.Contrasena.ToString().Trim().ToUpper().Equals("123456")) ||
                    (oUser.rol1.ToString().Trim().ToUpper().Equals("COLABORADOR") && oUser.Usuario.ToString().Trim().ToUpper().Equals("COLAB") && oUser.Contrasena.ToString().Trim().ToUpper().Equals("123456")))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    contador++;
                    MessageBox.Show("Usuario invalido , try No " + contador, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContrasena.Focus();
                    if (contador == 3)
                    {
                        this.DialogResult = DialogResult.Abort;
                        Close();
                    }
                }
            }
            catch (Exception error)
            {
                contador++;
                if (error.Message.Trim().Contains("Ingreso fallido") == true || error.Message.Trim().Contains("Login failed") == true)
                    MessageBox.Show("Incorrect user, try No " + contador, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Error ->" + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (contador == 3)
                {
                    this.DialogResult = DialogResult.Abort;
                    Close();
                }
            }
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            this.cmbRoles.Items.Clear();
            this.txtUsuario.Clear();
            this.txtContrasena.Clear();
            this.cmbRoles.Items.Add("Administrador");
            this.cmbRoles.Items.Add("Colaborador");
            this.cmbRoles.Items.Add("Supervisor");
            this.cmbRoles.SelectedIndex = 0;
            this.txtUsuario.Focus();         
        }


       
    }
}
