using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Gestión.Modelos;

namespace Sistema_de_Gestión.Presentacion
{
    public partial class frmVistaRedacciones : Form
    {
        RedaccionesModel RM = new RedaccionesModel();
        DSReportes ds = new DSReportes();

        public static int idPedido { get; set; }
        public static int idCliente { get; set; }
        public static int EstatusPedido { get; set; }
        public static string ModoReporte { get; set; }
        public static DateTime FechaInicio { get; set; }
        public static DateTime FechaFin { get; set; }
        public frmVistaRedacciones()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

            DSReportesTableAdapters.SP_VisualizarRedaccionClienteTableAdapter taRedaccion = new
                DSReportesTableAdapters.SP_VisualizarRedaccionClienteTableAdapter();

            taRedaccion.Fill(ds.SP_VisualizarRedaccionCliente, idCliente,
                idPedido, ModoReporte, EstatusPedido,
                FechaInicio, FechaFin);

            crvRedacciones1.SetDataSource(ds);

            crystalReportViewer1.ReportSource = crvRedacciones1;
        }

        private void frmVistaRedacciones_Load(object sender, EventArgs e)
        {

        }
    }
}
