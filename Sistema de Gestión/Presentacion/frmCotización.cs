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
using System.Threading;

namespace Sistema_de_Gestión.Presentacion
{
    public partial class frmCotización : Form
    {
        FacturacionModel FM = new FacturacionModel();
        Cotizaciones CT = new Cotizaciones();
        LoadingCotizacion frmCargar;
        DiseñoInterface DI = new DiseñoInterface();
        public frmCotización()
        {
            InitializeComponent();
        }

      
        private async void cmdRegistrar_Click(object sender, EventArgs e)
        {

                DateTime Hora =  DateTime.Now.ToLocalTime();
                DateTime Fecha = DateTime.Now.Date;

            if (CT.InsertarCotizacion(FacturacionModel.IDCliente, decimal.Parse(txtDesc.Text), decimal.Parse(txtSubTotal.Text),
                decimal.Parse(txtITBIS.Text), decimal.Parse(TxtTotalGeneral.Text), Fecha, Hora, EntrarLogin.IDActual,
                dgvCotizacion))
            {
                MessageBox.Show($"Se ha registrado la cotización {txtNumCotizacion.Text} correctamente.",
                    "Cotización Registrada",MessageBoxButtons.OK,MessageBoxIcon.Information);

                Mostrar();
                Task otask = new Task(Cargando);
                otask.Start();
                frmVistaCotizacion VistaCotizacion = new frmVistaCotizacion();
                int NumCotizacion = int.Parse(txtNumCotizacion.Text);
                VistaCotizacion.idCotizacion = NumCotizacion;
                VistaCotizacion.Show();
                await otask;
                Cerrar();


                CT.LimpiarCotizacion(Controls, dgvCotizacion, CKITBIS);
                txtNumCotizacion.Text = CT.CargarNuevaCotizacion().ToString().PadLeft(6, '0');
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

        private void cmdNuevaCotización_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdNuevaCotización, 1);
        }

        private void cmdNuevaCotización_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(cmdNuevaCotización, 0);
        }

        private void cmdNuevaCotización_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdNuevaCotización, 2);
        }

        private void cmdRegistrar_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdRegistrar, 1);
        }

        private void cmdRegistrar_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(cmdRegistrar, 0);
        }

        private void cmdRegistrar_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdRegistrar, 2);
        }

        private void cmdBuscarCotizacion_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdBuscarCotizacion, 1);
        }

        private void cmdBuscarCotizacion_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(cmdBuscarCotizacion, 0);
        }

        private void cmdBuscarCotizacion_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdBuscarCotizacion, 2);
        }

        private void cmdSalirCotizacion_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdSalirCotizacion, 1);
        }

        private void cmdSalirCotizacion_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(cmdSalirCotizacion, 0);
        }

        private void cmdSalirCotizacion_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdSalirCotizacion, 2);
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(button1, 1);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(button1, 0);
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(button1, 2);
        }

        private void cmdNuevaCotización_Click(object sender, EventArgs e)
        {
            CT.LimpiarCotizacion(Controls, dgvCotizacion, CKITBIS);
            txtNumCotizacion.Text = CT.CargarNuevaCotizacion().ToString().PadLeft(6, '0');
        }

        private void cmdSalirCotizacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdBuscarCotizacion_Click(object sender, EventArgs e)
        {
            //Abrir dialogo para buscar cotizacion por codigo
            frmBuscarCotizacion BC = new frmBuscarCotizacion();
            BC.ShowDialog();
        }
    }
}
