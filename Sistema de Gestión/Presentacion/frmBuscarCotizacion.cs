using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Sistema_de_Gestión.Modelos;

namespace Sistema_de_Gestión.Presentacion
{
    public partial class frmBuscarCotizacion : Form
    {
        DiseñoInterface DI = new DiseñoInterface();
        LoadingCotizacion frmCargar;
        public frmBuscarCotizacion()
        {
            InitializeComponent();
        }

        private async void cmdMostrar_Click(object sender, EventArgs e)
        {

            //Mostrar la factura indicada
            if (txtCodigoCotizacion.Value != 0)
            {
                Mostrar();
                Task otask = new Task(Cargando);
                otask.Start();
                frmVistaCotizacion VistaCotizacion = new frmVistaCotizacion();
                int NumCotizacion = (int)txtCodigoCotizacion.Value;
                VistaCotizacion.idCotizacion = NumCotizacion;
                VistaCotizacion.Show();
                await otask;
                Cerrar();
                this.Close();
                VistaCotizacion.TopMost = true;
            }
            else
            {
                MessageBox.Show("Debe indicar un número de cotización valido", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        public void Cargando()
        {
            Thread.Sleep(2000);
        }

        private void Mostrar()
        {
            frmCargar = new LoadingCotizacion();
            frmCargar.Show();
            frmCargar.TopMost = true;
        }

        private void Cerrar()
        {
            if (frmCargar != null)
            {
                frmCargar.Close();
            }
        }
    }
}
