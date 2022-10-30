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
    public partial class frmVistaCotizacion : Form
    {
        public int idCotizacion { get; set; }
        public frmVistaCotizacion()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

            DSReportes ds = new DSReportes();
            DSReportesTableAdapters.SP_VerCotizacionTableAdapter taCotizacion = new
                DSReportesTableAdapters.SP_VerCotizacionTableAdapter();

            DSReportesTableAdapters.SP_VerDetalleCotizacionTableAdapter taDetallesCotización = new
                DSReportesTableAdapters.SP_VerDetalleCotizacionTableAdapter();

            taCotizacion.Fill(ds.SP_VerCotizacion,this.idCotizacion);
            taDetallesCotización.Fill(ds.SP_VerDetalleCotizacion, this.idCotizacion);

            crvCotizacion1.SetDataSource(ds);

            crystalReportViewer1.ReportSource = crvCotizacion1;
        }

        private void frmVistaCotizacion_Load(object sender, EventArgs e)
        {

        }
    }
}
