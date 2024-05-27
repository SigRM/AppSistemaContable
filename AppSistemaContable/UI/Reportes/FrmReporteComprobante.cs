using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSistemaContable.UI.Reportes
{
    public partial class FrmReporteComprobante : Form
    {
        public FrmReporteComprobante()
        {
            InitializeComponent();
        }

        private void FrmReporteComprobante_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DsFuenteDatods.PlanillaEncabezado' table. You can move, or remove it, as needed.
            this.PlanillaEncabezadoTableAdapter.Fill(this.DsFuenteDatods.PlanillaEncabezado);

            this.reportViewer1.RefreshReport();
        }
    }
}
