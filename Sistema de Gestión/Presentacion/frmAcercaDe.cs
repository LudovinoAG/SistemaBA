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
    public partial class frmAcercaDe : Form
    {
        DiseñoInterface DI = new DiseñoInterface();
        public frmAcercaDe()
        {
            InitializeComponent();
        }

        private void frmAcercaDe_Load(object sender, EventArgs e)
        {
            LoadInfoApp();
        }

        private void LoadInfoApp()
        {

            lblProducto.Text = Application.ProductName;
            lblVersion.Text = Application.ProductVersion;
            LblAutor.Text = Application.CompanyName;
            txtDescripcion.Text = "Sistema para gestionar las operaciones de la empresa en el proceso de " +
                "facturación de los servicios suministrado asi como la automatización de la misma.";
            lblMarca.Text = "Copyright @ Todos los derechos reservados 2022-" + DateTime.Now.Year;
        }


        private void cmdSalir_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdSalir, 1);
        }

        private void cmdSalir_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(cmdSalir, 0);
        }

        private void cmdSalir_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdSalir, 2);
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
