using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Gestión.Modelos;

namespace Sistema_de_Gestión.Presentacion
{
    public partial class frmBuscarFactura : Form
    {
        DiseñoInterface DI = new DiseñoInterface();
        Loading frmCargar;
        public frmBuscarFactura()
        {
            InitializeComponent();
        }

        private async void cmdMostrar_Click(object sender, EventArgs e)
        {
            //Mostrar la factura indicada
            if (txtCodigoFactura.Value!=0)
            {
                Mostrar();
                Task otask = new Task(Cargando);
                otask.Start();
                frmVistaFactura VistaFactura = new frmVistaFactura();
                int NumFactura = (int)txtCodigoFactura.Value;
                VistaFactura.idFactura = NumFactura;
                VistaFactura.Show();
                await otask;
                Cerrar();
                this.Close();
                VistaFactura.TopMost = true;
            }
            else
            {
                MessageBox.Show("Debe indicar un número de factura valido", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
        public void Cargando()
        {
            Thread.Sleep(2000);
        }

        private void Mostrar()
        {
            frmCargar = new Loading();
            frmCargar.Show();
            frmCargar.TopMost = true;
        }

        private void Cerrar()
        {
            if (frmCargar!=null)
            {
                frmCargar.Close();
            }  
        }

        private void cmdMostrar_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdMostrar, 1);
        }

        private void cmdMostrar_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(cmdMostrar, 0);
        }

        private void cmdMostrar_MouseClick(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdMostrar, 2);
        }
    }
}
