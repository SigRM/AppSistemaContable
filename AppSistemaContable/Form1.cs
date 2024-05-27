using AppSistemaContable.Entidades;
using AppSistemaContable.UI;
using AppSistemaContable.UI.Mantenimientos;
using AppSistemaContable.UI.Procesos;
using AppSistemaContable.UI.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSistemaContable
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void colaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmColaboradores frm = new FrmColaboradores();
            frm.ShowDialog();
        }

        private void deduccionPercepcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeduccionPercepcionColab frm = new FrmDeduccionPercepcionColab();
            frm.ShowDialog();
        }

        private void deduccionPercepcionColaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeduccionPercepcionColab frm = new FrmDeduccionPercepcionColab();
            frm.ShowDialog();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpresa frm = new FrmEmpresa();
            frm.ShowDialog();
        }

        private void planillaPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPlanillaPago frm = new FrmPlanillaPago();
            frm.ShowDialog();
        }

        private void puestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPuestos frm = new FrmPuestos();
            frm.ShowDialog();
        }

        private void solicitudVacacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSolicitudVacaciones frm = new FrmSolicitudVacaciones();
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = "Bienvenido al App Sistema Contable";
            int valorLogin = 0;
            string usuarioDato = "";
            string claveDato = "";

            FrmLogIn ofrmLoging = new FrmLogIn(valorLogin, usuarioDato, claveDato);
            try
            {
                ofrmLoging.ShowDialog(this);
                if (ofrmLoging.DialogResult == DialogResult.Abort || ofrmLoging.DialogResult == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                this.Text = string.Format("{0} {1}", Application.ProductName, Application.ProductVersion);
                //validar el tipo de seguridad reportada
                Seguridad();

            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);
                msg.AppendFormat("InnerException {0}\n", er.InnerException);
                msg.AppendFormat("StackTrace     {0}\n", er.StackTrace);
                msg.AppendFormat("TargetSite     {0}\n", er.TargetSite);
                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Seguridad()
        {
            Colaboradores oUsuario = Colaboradores.GetInstance();
            string nombre = oUsuario.Usuario;
            string clave = oUsuario.Contrasena;
            string rol = oUsuario.rol1;

            string nombreRol = "";
            if (oUsuario.rol1.ToString() == "1")
            {
                nombreRol = "COLABORADOR";
            }
            else if (oUsuario.rol1.ToString() == "2")
            {
                nombreRol = "SUPERVISOR";
            }
            else
            {
                nombreRol = "ADMINISTRADOR";
            }

          //  string persona = "Sigrid Rojas Murillo";

            this.Text = "Sistema Contable  -- Bienvenido! ";// + persona + " Rol: " + nombreRol; SOLUCIONAR SEGURIDAD ANTES DE AGREGAR LO COMENTADO
            //   Utilities.Utiles.hablar(100, 0, this.Text);

            List<string> menus = new List<string>(); //Colaborador
            List<string> menus1 = new List<string>();//Supervisor
            List<string> menus2 = new List<string>();//Administrador

            //si el usuario es de tipo Colaborador
            menus.Add("btnCatalogos"); //Tareas
          //  menus.Add("btnMantenimientos"); //acerca de
         //   menus.Add("btnRepotes");
            menus.Add("btnAcercaDe");
            menus.Add("btnControlMarcas");
            menus.Add("btnSalir"); //Salir

            //si el usuario es de tipo Supervisor
            menus1.Add("btnCatalogos"); //Tareas
            menus1.Add("btnMantenimientos"); //acerca de
            menus1.Add("btnRepotes");
            menus1.Add("btnAcercaDe");
            menus1.Add("btnControlMarcas");
            menus1.Add("btnSalir"); //Salir

            //si el usuario es de tipo Colaborador
            menus2.Add("btnCatalogos"); //Tareas
            menus2.Add("btnMantenimientos"); //acerca de
            menus2.Add("btnRepotes");
            menus2.Add("btnAcercaDe");
            menus2.Add("btnControlMarcas");
            menus2.Add("btnSalir"); //Salir

            if (rol != null && !rol.ToString().Trim().ToUpper().Equals(""))
            {
                if (rol.ToString().ToUpper() == "ADMINISTRATOR")
                {
                    //Deshabilitar todas las opciones del menú
                    foreach (ToolStripItem opcionMenu in toolStrip1.Items) //para cada opción de la barra de menú
                    {
                        ((ToolStripItem)(opcionMenu)).Enabled = false;
                    }

                    foreach (ToolStripItem opcionMenu in toolStrip1.Items) //para cada opción de la barra de menú
                    {
                        opcionMenu.Enabled = menus.Exists(p => p.Equals(opcionMenu.Name, StringComparison.InvariantCultureIgnoreCase));
                    }
                }
                else
                {
                    if (rol.ToString().ToUpper() == "SUPERVISOR")
                    {
                        //Deshabilitar todas las opciones del menú
                        foreach (ToolStripItem opcionMenu in toolStrip1.Items) //para cada opción de la barra de menú
                        {
                            //((ToolStripMenuItem)(opcionMenu)).Enabled = false;
                            ((ToolStripItem)(opcionMenu)).Visible = false;
                        }

                        foreach (ToolStripItem opcionMenu in toolStrip1.Items) //para cada opción de la barra de menú
                        {
                            //opcionMenu.Enabled = menus1.Exists(p => p.Equals(opcionMenu.Name, StringComparison.InvariantCultureIgnoreCase));
                            opcionMenu.Visible = menus1.Exists(p => p.Equals(opcionMenu.Name, StringComparison.InvariantCultureIgnoreCase));
                        }
                    }//END EMPLOYEE
                    else
                    {
                       //Deshabilitar todas las opciones del menú
                        foreach (ToolStripItem opcionMenu in toolStrip1.Items) //para cada opción de la barra de menú
                        {
                            ((ToolStripItem)(opcionMenu)).Enabled = false;
                        }

                        foreach (ToolStripItem opcionMenu in toolStrip1.Items) //para cada opción de la barra de menú
                        {
                            opcionMenu.Enabled = menus2.Exists(p => p.Equals(opcionMenu.Name, StringComparison.InvariantCultureIgnoreCase));
                        }
                    }//END
                }
            }
        }

     

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            FrmControlMarcas frm = new FrmControlMarcas();
            frm.ShowDialog();
        }

        private void planillaEncabezadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPlanillaEncabezado frm = new FrmPlanillaEncabezado();
            frm.ShowDialog();
        }

        private void reportePlanillasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportePlanillas frm = new FrmReportePlanillas();
            frm.ShowDialog();
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            FrmAcercaDe frm = new FrmAcercaDe();
            frm.ShowDialog();
        }

        private void btnRepotes_ButtonClick(object sender, EventArgs e)
        {

        }

        private void reporteSolicitudVacacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteSolicitudVacaciones frm = new FrmReporteSolicitudVacaciones();
            frm.ShowDialog();
        }

        private void reporteColaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteComprobante frm = new FrmReporteComprobante();
            frm.ShowDialog();
        }
    }
}
