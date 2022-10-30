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
        public frmVistaRedacciones()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

            DSReportesTableAdapters.SP_VisualizarRedaccionClienteTableAdapter taRedaccion = new
                DSReportesTableAdapters.SP_VisualizarRedaccionClienteTableAdapter();

            taRedaccion.Fill(ds.SP_VisualizarRedaccionCliente, 7);

            crvRedacciones1.SetDataSource(ds);

            crystalReportViewer1.ReportSource = crvRedacciones1;
        }
    }
}
