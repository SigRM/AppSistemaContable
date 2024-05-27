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
    public partial class FrmReporteSolicitudVacaciones : Form
    {
        public FrmReporteSolicitudVacaciones()
        {
            InitializeComponent();
        }

        private void FrmReporteSolicitudVacaciones_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DsFuenteDatods.SolicitudesVacaciones' table. You can move, or remove it, as needed.
            this.SolicitudesVacacionesTableAdapter.Fill(this.DsFuenteDatods.SolicitudesVacaciones);

            this.reportViewer1.RefreshReport();
        }
    }
}
