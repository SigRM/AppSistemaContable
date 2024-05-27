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
using UTNLeccion8B.Utilities;

namespace AppSistemaContable.UI.Mantenimientos
{
    public partial class FrmPuestos : Form
    {
        List<Puestos> PuestosList = new List<Puestos>(); //Se crea una instancia a la clase clientes como tipo lista
        public FrmPuestos()
        {
            InitializeComponent();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cREARToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* try
            {
                
                bool resultado = PuestosList.Exists(x => x.Codigo.ToString() == txtCodigo.Text.ToString());//Validamos si existe en la lista
                if (resultado)
                {
                    MessageBox.Show("El codigo  " + txtCodigo.Text + " ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtCodigo.Text.ToString() == string.Empty)
                {//Si el campo txtCedula está vacio
                    errorProvider1.SetError(txtCodigo, "Espacio Obligatorio"); //En caso de que estuviese vacío activa el control error provider
                    return; //regresa a pantalla
                }

                //Antes de grabar validamos los datos
                // Validar Id
                if (string.IsNullOrEmpty(FormatStrings.GetDNINoFormat(this.txtCodigo.Text)))
                {
                    errorProvider1.SetError(this.txtCodigo, "Numero de codigo incorrecto");
                    return;
                }


             
                //Se muestra dato en el grid view
                this.dgvPuestos.Rows.Add(txtCodigo.Text, txtNombre.Text, chkestado.Text); //Agrega los valores de cedula, nombre y edad
                this.FrmPuestos_Load(null, null);


                LimpiarControles();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }*/
            CrearActualizarDatos();
        }

        private void aCTUALIZARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearActualizarDatos();
        }

        private void eLIMINARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = txtCodigo.Text;
            BLL.BLLPuestos.DELETE(id);
            RefrescarLista();
            ResetUI('C');
            LimpiarControles();
        }

        private void lIMPIARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            ResetUI('C');
        }

        private void FrmPuestos_Load(object sender, EventArgs e)
        {
            //Refrescar lista
            RefrescarLista();
            //Preparar el ambiente
            ResetUI('C');
            //Limpiar controles
            LimpiarControles();
        }

        private void AplicarFormatoDataGridView()
        {
         // Color de fondo Blanco
            this.dgvPuestos.RowsDefaultCellStyle.BackColor = Color.White;
            // Color intercalado Gris Claro
            this.dgvPuestos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            // Sin bordes
            this.dgvPuestos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            // Color de elemento seleccionado verde marino    
            this.dgvPuestos.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            // Color de letra seleccionada blanco
            this.dgvPuestos.DefaultCellStyle.SelectionForeColor = Color.White;
            // WrpMode = false
            this.dgvPuestos.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            // Columnas centradas
            // Seleccion de fila cuando se selecciona alguna celda
            this.dgvPuestos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Permitir al usuario cambiar tamano de columnas
            this.dgvPuestos.AllowUserToResizeColumns = true;
            // Auto Resize Columnas
            foreach (DataGridViewColumn col in this.dgvPuestos.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void dgvPuestos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvPuestos.Rows.Count; i++) //Realiza recorrido de filas (validar si tiene el habilitar agregar filas para dejar o eliminar el -1)
                {
                    txtCodigo.Text = this.dgvPuestos.CurrentRow.Cells[0].Value.ToString();//Muestra los datos de la fila seleccionada y lo coloca en el campo Cedula
                    txtNombre.Text = this.dgvPuestos.CurrentRow.Cells[1].Value.ToString();                    
                    chkestado.Text = this.dgvPuestos.CurrentRow.Cells[2].Value.ToString();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
          
        }

        #region Metodos Privados

        private void LimpiarControles()
        {
            try
            {
                txtCodigo.Clear();
                txtNombre.Clear();
                chkestado.Enabled = true;

            }
            catch (Exception error)
            {
                MessageBox.Show("Error al limpiar controles " + error.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetUI(char pOpcion)
        {
           
            //Inactivar controles
            txtCodigo.Enabled = false;
            txtNombre.Enabled = false;
            chkestado.Enabled = false;


            switch (pOpcion)
            {
                case 'C': //Create

                    txtCodigo.Enabled = true;
                    txtNombre.Enabled = true;
                    chkestado.Enabled = true;

                    txtCodigo.Focus();
                    break;
                case 'U': //UPDATE                

                    txtCodigo.Enabled = false;
                    txtNombre.Enabled = false;
                    chkestado.Enabled = false;
                    txtCodigo.Focus();
                    break;
                case 'D': //DELETE
                    txtCodigo.Enabled = true;
                    txtNombre.Enabled = true;
                    chkestado.Enabled = true;
                    break;
            }

        }

        private void RefrescarLista()
        {
            try
            {
                dgvPuestos.AutoGenerateColumns = true;
                this.AplicarFormatoDataGridView();
                dgvPuestos.DataSource = BLL.BLLPuestos.SelectAll();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al Refrescar la tabla " + error.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CrearActualizarDatos()
        {
            Puestos puestos = new Puestos();
                    
            //Guardar los datos
            BLL.BLLPuestos.CREATE(puestos);
            //Refrescar pantalla
            RefrescarLista();
            //Limpiamos ambiente
            ResetUI('C');
            //Limpiamos controles
            LimpiarControles();
        }
        #endregion
    }
}

