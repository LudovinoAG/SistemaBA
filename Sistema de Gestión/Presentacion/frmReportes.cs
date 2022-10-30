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
    public partial class frmReportesFacturas : Form
    {
        ReportesModel RM = new ReportesModel();
        DiseñoInterface DI = new DiseñoInterface();
        Loading frmCargar;

        static public string FacturaNumero_Pagar {get;set;}
        static public string Cliente_Pagar { get; set; }
        static public decimal TotalFactura_Pagar { get; set; }
        public frmReportesFacturas()
        {
            InitializeComponent();
            RM.LoadFiltros(cboFiltrar);
        }

        private void cboFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFiltrar.SelectedIndex==5)
            {
                grbFechas.Visible = true;
                txtBuscar.Text = "";
                txtBuscar.Visible = false;
                dgvReporteFacturas.DataSource = null;
                cmdBuscar.Location = new Point(657, 17);
            }
            else if(cboFiltrar.SelectedIndex == 0)
            {
                grbFechas.Visible = false;
                txtBuscar.Text = "";
                txtBuscar.Visible = true;
                txtBuscar.Enabled = false;
                dgvReporteFacturas.DataSource = null;
                cmdBuscar.Location = new Point(510, 17);
            }
            else
            {
                grbFechas.Visible = false;
                txtBuscar.Text = "";
                txtBuscar.Visible = true;
                txtBuscar.Enabled = true;
                dgvReporteFacturas.DataSource = null;
                cmdBuscar.Location = new Point(510, 17);
            }
        }

        private async void cmdBuscar_Click(object sender, EventArgs e)
        {
            lblSeleccionado.Text = "";
            MostrarMensaje();
            Task otask = new Task(Cargando);
            otask.Start();
            if (cboFiltrar.Text == "Fecha Factura")
            {
                RM.BuscarFactura(dgvReporteFacturas, cboFiltrar.Text, "", dtpFechaInicio.Value, dptFechaFin.Value);
            }
            else
            {
                RM.BuscarFactura(dgvReporteFacturas, cboFiltrar.Text, txtBuscar.Text, dtpFechaInicio.Value, dptFechaFin.Value);
            }
            await(otask);
            CambiarMensaje();
            if (dgvReporteFacturas.Rows.Count!=0)
            {
                lblSeleccionado.Text = "Factura seleccionada " + dgvReporteFacturas.SelectedRows[0].Cells["id_Factura"].Value.ToString().PadLeft(6, '0');

            }

        }

        private void cmdBuscar_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdBuscar, 1);
        }

        private void cmdBuscar_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(cmdBuscar, 0);
        }

        private void cmdBuscar_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdBuscar, 2);
        }

        private void cmdCerrarReporteFacturas_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdCerrarReporteFacturas, 1);
        }

        private void cmdCerrarReporteFacturas_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(cmdCerrarReporteFacturas, 0);
        }

        private void cmdCerrarReporteFacturas_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdCerrarReporteFacturas, 2);
        }

        private void cmdVerFacturaReporte_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdVerFacturaReporte, 1);
        }

        private void cmdVerFacturaReporte_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(cmdVerFacturaReporte, 0);
        }

        private void cmdVerFacturaReporte_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdVerFacturaReporte, 2);
        }

        private async void cmdVerFacturaReporte_Click(object sender, EventArgs e)
        {
            if (dgvReporteFacturas.Rows.Count!=0)
            {
                if (dgvReporteFacturas.SelectedRows[0].Selected)
                {
                    Mostrar();
                    Task otask = new Task(Cargando);
                    otask.Start();
                    frmVistaFactura VistaFactura = new frmVistaFactura();
                    int NumFactura = (int)dgvReporteFacturas.SelectedRows[0].Cells["id_Factura"].Value;
                    VistaFactura.idFactura = NumFactura;
                    VistaFactura.Show();
                    await otask;
                    Cerrar();
                }
                else
                {
                    MessageBox.Show("No ha seleccionado una factura de la lista", "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No existen facturas en el listado", "Aviso", MessageBoxButtons.OK,
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

        private void MostrarMensaje()
        {
            if (cboFiltrar.Text != "Fecha Factura")
            {
                lblSeleccionado.Text = $"Buscando la factura {txtBuscar.Text.PadLeft(6, '0')} por favor espere un momento...";

            }
            else
            {
                lblSeleccionado.Text = $"Buscando la factura desde la fecha {dtpFechaInicio.Text} hasta " +
                    $"{dptFechaFin.Text} por favor espere un momento...";
            }
        }

        private void CambiarMensaje()
        {
            lblSeleccionado.Text = $"No ha seleccionado una factura por el momento.";
        }

        private void Cerrar()
        {
            if (frmCargar != null)
            {
                frmCargar.Close();
            }
        }

        private void dgvReporteFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string NumFactura = dgvReporteFacturas.SelectedRows[0].Cells["id_Factura"].Value.ToString();
                lblSeleccionado.Text = $"Factura seleccionada {NumFactura.PadLeft(6,'0')}";
            }
        }

        private void cmdCerrarReporteFacturas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReportesFacturas_Load(object sender, EventArgs e)
        {

        }

        private void CmdPagarFactura_Click(object sender, EventArgs e)
        {
            if (dgvReporteFacturas.Rows.Count!=0)
            {
                if (dgvReporteFacturas.SelectedRows[0].Cells["Nom_Estatus"].Value.ToString() != "PAGADA")
                {
                    frmPagarFactura frmPagarFactura = new frmPagarFactura();
                    FacturaNumero_Pagar = dgvReporteFacturas.SelectedRows[0].Cells["id_Factura"].Value.ToString().PadLeft(6, '0');
                    Cliente_Pagar = dgvReporteFacturas.SelectedRows[0].Cells["Empresa"].Value.ToString();
                    TotalFactura_Pagar = (decimal)dgvReporteFacturas.SelectedRows[0].Cells["TotalFactura"].Value;

                    frmPagarFactura.ShowDialog();

                    cboFiltrar.SelectedIndex = 0;
                    lblSeleccionado.Text = "No ha seleccionado factura en el momento";

                }
                else
                {
                    MessageBox.Show("La factura seleccionada no esta pendiente", "Pagar Factura",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
           


        }

        private void CmdPagarFactura_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(CmdPagarFactura, 1);
        }

        private void CmdPagarFactura_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(CmdPagarFactura, 0);
        }

        private void CmdPagarFactura_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(CmdPagarFactura, 2);
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                cmdBuscar_Click(sender, e);
            }
        }
    }
}
