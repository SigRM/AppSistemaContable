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

namespace AppSistemaContable.UI.Mantenimientos
{
    public partial class FrmPlanillaEncabezado : Form
    {
        public FrmPlanillaEncabezado()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string compraOVenta = "";
            if (this.rdbCompra.Checked)
            {
                compraOVenta = "c";
            }
            else
            {
                compraOVenta = "v";
            }
            ServiceBCCR services = new ServiceBCCR();
            dgvTipoCambio.DataSource = services.GetDolar(this.dtpInicial.Value, this.dtpFinal.Value, compraOVenta);
        }
    }
}
