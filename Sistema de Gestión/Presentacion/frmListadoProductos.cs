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
    public partial class frmListadoProductos : Form
    {
        DSReportes ds = new DSReportes();
        public frmListadoProductos()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            vW_ListaGeneralProductosReportesTableAdapter1.Fill(ds.VW_ListaGeneralProductosReportes);
            crvListadoProductos1.SetDataSource(ds);
            crystalReportViewer1.ReportSource = crvListadoProductos1;
        }
    }
}
