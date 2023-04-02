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
    public partial class frmVistaProforma : Form
    {
        public static int idPedido { get; set; }
        public static int idCliente { get; set; }
        public static int EstatusPedido { get; set; }
        public static string ModoReporte { get; set; }
        public static DateTime FechaInicio { get; set; }
        public static DateTime FechaFin { get; set; }
        public frmVistaProforma()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DSReportes ds = new DSReportes();

            DSReportesTableAdapters.SP_ViewQueryPreformTableAdapter taQueryProform = new
                DSReportesTableAdapters.SP_ViewQueryPreformTableAdapter();

            DSReportesTableAdapters.SP_VerConducesProformaTableAdapter taConducesProforma = new
                DSReportesTableAdapters.SP_VerConducesProformaTableAdapter();

            taQueryProform.Fill(ds.SP_ViewQueryPreform, idCliente, idPedido, ModoReporte, EstatusPedido,
                FechaInicio, FechaFin);
            taConducesProforma.Fill(ds.SP_VerConducesProforma, idCliente, idPedido, ModoReporte, EstatusPedido,
                FechaInicio, FechaFin);

            crvProforma1.SetDataSource(ds);

            crystalReportViewer1.ReportSource = crvProforma1;
    
        }
    }
}
