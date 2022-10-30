using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gestión
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void mnuSistemasFacturacion_Click(object sender, EventArgs e)
        {
            Facturación frmFactura = new Facturación();
            frmFactura.MdiParent = this;
            frmFactura.Show();
        }
    }
}
