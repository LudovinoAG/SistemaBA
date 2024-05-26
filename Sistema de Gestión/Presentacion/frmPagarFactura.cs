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
    public partial class frmPagarFactura : Form
    {
        FacturacionModel FT = new FacturacionModel();
        Funciones FC = new Funciones();
        DiseñoInterface DI = new DiseñoInterface();
        public frmPagarFactura()
        {
            InitializeComponent();
            this.LoadBancos();
            this.LoadMetodos();
        }

        private void LoadDatosFactura()
        {
            lblNumFactura.Text = frmReportesFacturas.FacturaNumero_Pagar;
            lblCodigoCliente.Text = frmReportesFacturas.Cliente_Pagar;
            lblTotalFactura.Text = string.Format("{0:C}",frmReportesFacturas.TotalFactura_Pagar);
            

            if (FT.VerMontoPendienteFactura(int.Parse(frmReportesFacturas.FacturaNumero_Pagar))==0)
            {
                lblMontoPendiente.Text = string.Format("{0:C}", frmReportesFacturas.TotalFactura_Pagar);
                txtTotalPagado.Text = string.Format("{0:N}", frmReportesFacturas.TotalFactura_Pagar);
            }
            else
            {
                lblMontoPendiente.Text = string.Format("{0:C}",
                FT.VerMontoPendienteFactura(int.Parse(frmReportesFacturas.FacturaNumero_Pagar)));

                txtTotalPagado.Text = string.Format("{0:N}",
                FT.VerMontoPendienteFactura(int.Parse(frmReportesFacturas.FacturaNumero_Pagar)));
            }
           
        }

        private void LoadBancos()
        {
            cboBancos.DisplayMember = "Banco";
            cboBancos.ValueMember = "ID";
            cboBancos.DataSource = FT.ListarBancos();

            cboBancoTransferencia.DisplayMember = "Banco";
            cboBancoTransferencia.ValueMember = "ID";
            cboBancoTransferencia.DataSource = FT.ListarBancos();

        }

        private void LoadMetodos()
        {
            cboMetodos.DisplayMember = "MODO";
            cboMetodos.ValueMember = "ID";
            cboMetodos.DataSource = FT.ListarMetodos();
        }

        private void cboMetodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMetodos.SelectedIndex==1)
            {
                gbCheque.Location = new Point(18, 261);
                gbTransferencia.Visible = false;
                gbEfectivo.Visible = false;
                gbCheque.Visible = true;


            }
            else if (cboMetodos.SelectedIndex == 2)
            {
                gbTransferencia.Location = new Point(18, 261);
                gbCheque.Visible = false;
                gbEfectivo.Visible = false;
                gbTransferencia.Visible = true;

            }
            else
            {
                gbEfectivo.Location = new Point(18, 261);
                gbCheque.Visible = false;
                gbTransferencia.Visible = false;
                gbEfectivo.Visible = true;
               
            }
            txtCuentaOrigen.Text = "0";
            txtNumCheque.Text = "0";
        }

        private void frmPagarFactura_Load(object sender, EventArgs e)
        {
            LoadDatosFactura();
        }

        private void cmdAplicarPago_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show($"¿Realmente desea aplicar el pago a la factura No. " +
                $"[{lblNumFactura.Text}]?\npor el monto de {string.Format(txtTotalPagado.Text,"C")}", "Pago de factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(DialogResult == DialogResult.Yes)
            {
                double numero;
                double TotalPago = 0;
                int NumFactura = int.Parse(lblNumFactura.Text);
                int ModoPago = (int)cboMetodos.SelectedValue;
                double TotalFactura;
                if (double.TryParse(txtTotalPagado.Text, out numero))
                {
                    TotalPago = numero;
                }

                if (FT.VerMontoPendienteFactura(int.Parse(frmReportesFacturas.FacturaNumero_Pagar)) == 0)
                {
                    TotalFactura = (double)frmReportesFacturas.TotalFactura_Pagar;
                }
                else
                {
                    TotalFactura = (double)FT.VerMontoPendienteFactura(int.Parse(frmReportesFacturas.FacturaNumero_Pagar));
                }


                if (this.ComprobarMontos(this.ValidarTipoPago(gbPago.Controls), TotalFactura, TotalPago))
                {
                    DateTime FechaActual = DateTime.Now.Date;
                    string TipoPago = this.ValidarTipoPago(gbPago.Controls);

                    if (ModoPago != 1)
                    {
                        if (FT.PagarFactura(NumFactura, ModoPago, txtConceptoPago.Text, int.Parse(txtNumCheque.Text),
                            int.Parse(lblBanco.Text), txtCuentaOrigen.Text, TotalPago, FechaActual, TipoPago, EntrarLogin.IDActual))
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        FT.PagarFactura(NumFactura, ModoPago, txtConceptoPago.Text, 0,
                            0, "", TotalPago, FechaActual, TipoPago, EntrarLogin.IDActual);

                        this.Close();
                    }
                }
            }
            
           

        }

        private void cboBancoTransferencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBanco.Text = cboBancoTransferencia.SelectedValue.ToString();
        }

        private void cboBancos_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBanco.Text = cboBancos.SelectedValue.ToString();
        }

        private string ValidarTipoPago(Control.ControlCollection Opciones)
        {
            var OPT = Opciones.OfType<RadioButton>().Where(t=> t.Checked==true).SingleOrDefault();

            return OPT.Text;
        }

        private void rbAbonoPago_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAbonoPago.Checked==true)
            {
                txtTotalPagado.ReadOnly = false;
                txtTotalPagado.Text = "0.00";
            }
        }

        private void rbTotalPago_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTotalPago.Checked == true)
            {
                txtTotalPagado.ReadOnly = true;

                if (FT.VerMontoPendienteFactura(int.Parse(frmReportesFacturas.FacturaNumero_Pagar)) == 0)
                {
                    txtTotalPagado.Text = string.Format("{0:N}", frmReportesFacturas.TotalFactura_Pagar);
                }
                else
                {

                    txtTotalPagado.Text = string.Format("{0:N}",
                    FT.VerMontoPendienteFactura(int.Parse(frmReportesFacturas.FacturaNumero_Pagar)));
                }

            }
        }

        private bool ComprobarMontos(string Tipo, double TotalFactura, double TotalPago)
        {
            switch (Tipo)
            {
                    case "ABONO":
                        if (TotalPago > TotalFactura)
                        {
                            MessageBox.Show("El monto a pagar es mayor al monto pendiente", "Pagar Factura",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtTotalPagado.Focus();
                            return false;
                        }
                        else if (TotalPago == TotalFactura)
                        {
                            DialogResult Respuesta = MessageBox.Show("Esta realizando el pago total de la factura, " +
                                "¿Desea continuar?", "Pagar Factura",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (Respuesta==DialogResult.Yes)
                            {
                                rbTotalPago.Checked = true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else if (TotalPago==0 || TotalPago.ToString()=="")
                        {
                            MessageBox.Show("Debe introducir un monto válido", "Pagar Factura",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtTotalPagado.Focus();
                            return false;
                    }
                    break;
            }
            
            return true;
        }

        private void txtTotalPagado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = FC.SoloNumeros(e);
        }

        private void cmdAplicarPago_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdAplicarPago,1);
        }

        private void cmdAplicarPago_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(cmdAplicarPago, 0);
        }

        private void cmdAplicarPago_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdAplicarPago, 2);
        }
    }
}
