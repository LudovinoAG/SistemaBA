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
        FacturacionModel FM = new FacturacionModel();
        Funciones FC = new Funciones();
        Loading frmCargar;

        static public string FacturaNumero_Pagar {get;set;}
        static public string Cliente_Pagar { get; set; }
        static public decimal TotalFactura_Pagar { get; set; }

        public static string TipoFacturaReporte { get; set; }
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
                txtBuscar.Enabled = true;
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
            if (txtBuscar.Text != "")
            {
                lblSeleccionado.Text = "";
                MostrarMensaje();
                Task otask = new Task(Cargando);
                otask.Start();
        
                ReportesModel.NumFacturaReporte = int.Parse(txtBuscar.Text);
                RM.BuscarFactura(dgvReporteFacturas, ReportesModel.NumFacturaReporte);

                await (otask);
                CambiarMensaje();
                if (dgvReporteFacturas.Rows.Count != 0)
                {
                    lblSeleccionado.Text = "Factura seleccionada " + dgvReporteFacturas.SelectedRows[0].Cells["NumFactura"].Value.ToString().PadLeft(6, '0');

                }
            }
            else
            {
                MessageBox.Show("Debe indicar un numero de factura a buscar", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBuscar.Focus();
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
            DI.BTMouseEvent(CmdModificarFactura, 1);
        }

        private void cmdCerrarReporteFacturas_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(CmdModificarFactura, 0);
        }

        private void cmdCerrarReporteFacturas_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(CmdModificarFactura, 2);
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
                    FacturacionModel.IDFactura = int.Parse(dgvReporteFacturas.SelectedRows[0].Cells["NumFactura"].Value.ToString());
                    TipoFacturaReporte = dgvReporteFacturas.SelectedRows[0].Cells["TipoFactura"].Value.ToString();
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

        private void frmReportesFacturas_Load(object sender, EventArgs e)
        {
            dgvReporteFacturas.DataSource = RM.LoadTopFacturas().ToList();
            RM.FormatoColumnasFacturas(dgvReporteFacturas.Columns);
        }

        private void CmdPagarFactura_Click(object sender, EventArgs e)
        {
            if (dgvReporteFacturas.Rows.Count!=0)
            {
                if (dgvReporteFacturas.SelectedRows[0].Cells["EstatusFactura"].Value.ToString() != "PAGADA")
                {
                    frmPagarFactura frmPagarFactura = new frmPagarFactura();
                    FacturaNumero_Pagar = dgvReporteFacturas.SelectedRows[0].Cells["NumFactura"].Value.ToString().PadLeft(6, '0');
                    Cliente_Pagar = dgvReporteFacturas.SelectedRows[0].Cells["Empresa"].Value.ToString();
                    TotalFactura_Pagar = decimal.Parse(dgvReporteFacturas.SelectedRows[0].Cells["TotalFactura"].Value.ToString());

                    frmPagarFactura.ShowDialog();

                    cboFiltrar.SelectedIndex = 0;
                    dgvReporteFacturas.DataSource = null;
                    txtBuscar.Clear();
                    lblSeleccionado.Text = "No ha seleccionado factura en el momento";

                }
                else
                {
                    MessageBox.Show($"La factura [{FacturaNumero_Pagar}] seleccionada ya esta pagada totalmente.", "Pagar Factura",
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

            if (cboFiltrar.SelectedIndex == 1)
            {
                FC.SoloNumeros(e);
            }

            else if (cboFiltrar.SelectedIndex == 5)
            {
                FC.SoloTexto(e);
            }
        }

        private void dgvReporteFacturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                int NumFactura = int.Parse(dgvReporteFacturas.SelectedRows[0].Cells["NumFactura"].Value.ToString());
                ReportesModel.NumFacturaReporte = NumFactura;

                lblSeleccionado.Text = $"Factura seleccionada {NumFactura.ToString().PadLeft(6, '0')}";
            }
        }

        private void CmdModificarFactura_Click(object sender, EventArgs e)
        {
            if (dgvReporteFacturas.Rows.Count != -1)
            {

                int NumFactura = int.Parse(dgvReporteFacturas.SelectedRows[0].Cells["NumFactura"].Value.ToString());
                ObtenerInfoFactura(NumFactura);

            }
        }

        private void ObtenerInfoFactura(int Num)
        {
            frmActualizarFactura frmActualizar = new frmActualizarFactura();

            DateTime FechaFactura = (DateTime)dgvReporteFacturas.SelectedRows[0].Cells["Fecha"].Value;
            DateTime FechaVencimiento = (DateTime)dgvReporteFacturas.SelectedRows[0].Cells["FechaVencimiento"].Value;

            
            frmActualizar.NumFactura = Num;
            frmActualizar.TipoFactura = dgvReporteFacturas.SelectedRows[0].Cells["TipoFactura"].Value.ToString();
            frmActualizar.NCF = dgvReporteFacturas.SelectedRows[0].Cells["NCF"].Value.ToString();
            frmActualizar.Cliente = dgvReporteFacturas.SelectedRows[0].Cells["Empresa"].Value.ToString();
            frmActualizar.EstatusFactura = dgvReporteFacturas.SelectedRows[0].Cells["EstatusFactura"].Value.ToString();
            frmActualizar.SubTotal = decimal.Parse(dgvReporteFacturas.SelectedRows[0].Cells["SubTotal"].Value.ToString());
            frmActualizar.Descuento = decimal.Parse(dgvReporteFacturas.SelectedRows[0].Cells["Descuento"].Value.ToString());
            frmActualizar.ITBIS = decimal.Parse(dgvReporteFacturas.SelectedRows[0].Cells["ITBIS"].Value.ToString());
            frmActualizar.Total = decimal.Parse(dgvReporteFacturas.SelectedRows[0].Cells["TotalFactura"].Value.ToString());
            frmActualizar.MontoPendiente = decimal.Parse(dgvReporteFacturas.SelectedRows[0].Cells["MontoPendiente"].Value.ToString());
            frmActualizar.MontoPagado = decimal.Parse(dgvReporteFacturas.SelectedRows[0].Cells["MontoPagado"].Value.ToString());
            frmActualizar.NotaFactura = dgvReporteFacturas.SelectedRows[0].Cells["Nota"].Value.ToString();
            frmActualizar.FechaFactura = FechaFactura;
            frmActualizar.FechaVencimiento = FechaVencimiento;
            frmActualizar.ID = FM.BuscarIDCliente(frmActualizar.Cliente);



            frmActualizar.ShowDialog();
            dgvReporteFacturas.DataSource = RM.LoadTopFacturas().ToList();
            RM.FormatoColumnasFacturas(dgvReporteFacturas.Columns);

        }

    }
}
