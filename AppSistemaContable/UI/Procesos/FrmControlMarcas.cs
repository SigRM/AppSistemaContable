using AppSistemaContable.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;

namespace AppSistemaContable.UI
{
    public partial class FrmControlMarcas : Form
    {
     // Declarar property
     private static readonly log4net.ILog _MyLogControlEventos =
     log4net.LogManager.GetLogger("MyControlEventos");


    public FrmControlMarcas()
        {
            InitializeComponent();
        }
     
        private void txtRuta_Click(object sender, EventArgs e)
        {
            try
            {
                // Mostrar el Dialogo de archivos
                OpenFileDialog opt = new OpenFileDialog();
                // Parametros del dialogo
                opt.Title = "Seleccione el archivo JSON";
                opt.SupportMultiDottedExtensions = true;
                opt.DefaultExt = "*.json";
                opt.Filter = "Archivo JSON(*.json)|*.json";
                opt.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                opt.FileName = "";

                if (opt.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        this.txtRuta.Text = opt.FileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:  " + ex.Message);
                        _MyLogControlEventos.Info("Error, archivo invalido");
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
                this.errorProvider1.SetError(this.txtRuta, msg.ToString());
            }
        }

        private void btnCargar_Click(object sender, EventArgs e) //Revisar este metodo
        {
            //Validar primero si tiene datos txt
            if(txtRuta.Text.ToString().Equals(""))
            {
                MessageBox.Show("La ruta debe seleccionarse primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error("Error, debe colocarse en el cursor de la izquierda");
                return;
            }

            ControlMarcas cm = new ControlMarcas();
            cm.ObtenerMarcas(txtRuta.Text);
            dgvControlMarcas.DataSource = BLL.BLLControlMarcas.SelectAll();
        }

        private void FrmControlMarcas_Load(object sender, EventArgs e)
        {

        }
    }
}

