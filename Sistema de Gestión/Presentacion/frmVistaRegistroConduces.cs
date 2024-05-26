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
    public partial class frmVistaRegistroConduces : Form
    {
        public static int Cliente { get; set; }
        public static string ModoReporte { get; set; }
        public static DateTime FechaInicio { get; set; }
        public static DateTime FechaFin { get; set; }
        public frmVistaRegistroConduces()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DSReportes ds = new DSReportes();

            DSReportesTableAdapters.SP_ReporteConducesRegistradosTableAdapter taRegistroConduces = new
                DSReportesTableAdapters.SP_ReporteConducesRegistradosTableAdapter();

            /*DSReportesTableAdapters.SP_VerConducesProformaTableAdapter taConducesProforma = new
                DSReportesTableAdapters.SP_VerConducesProformaTableAdapter();
            */

            taRegistroConduces.Fill(ds.SP_ReporteConducesRegistrados, Cliente, ModoReporte, FechaInicio, FechaFin);
            /*
            taConducesProforma.Fill(ds.SP_VerConducesProforma, idCliente, idPedido, ModoReporte, EstatusPedido,
                FechaInicio, FechaFin);
            */
            crvReporteConducesRegistrados1.SetDataSource(ds);

            crystalReportViewer1.ReportSource = crvReporteConducesRegistrados1;
        }
    }
}
