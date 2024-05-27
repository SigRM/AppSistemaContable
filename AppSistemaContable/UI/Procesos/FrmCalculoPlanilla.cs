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
    public partial class FrmCalculoPlanilla : Form
    {
        public FrmCalculoPlanilla()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUSD.Clear();
            txtEmpresaIdPago.Clear();
            txtIdColaboradorEncab.Clear();
            txtIdPagoEncab.Clear();
            txtIdPlaniEncab.Clear();
            txtIdPlaniPago.Clear();
            txtNombreColabEncab.Clear();
            txtPlaniPago.Clear();
            txtSalarioNeto.Clear();
          
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
