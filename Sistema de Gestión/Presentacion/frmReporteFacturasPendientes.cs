using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gestión.Presentacion
{
    public partial class frmReporteFacturasPendientes : Form
    {
        DSReportes ds = new DSReportes();

        public frmReporteFacturasPendientes()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

            vW_VerReportesFacturasPendientesCreditoTableAdapter1.Fill(ds.VW_VerReportesFacturasPendientesCredito);
            crvReporteFacturasCredito1.SetDataSource(ds);
            crystalReportViewer1.ReportSource = crvReporteFacturasCredito1;

        }

        private void frmReporteFacturasPendientes_Load(object sender, EventArgs e)
        {
            
        }
    }
}
