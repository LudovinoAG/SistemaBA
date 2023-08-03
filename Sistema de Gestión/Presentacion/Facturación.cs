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
using Sistema_de_Gestión.Presentacion;
using System.Globalization;
using System.Threading;

namespace Sistema_de_Gestión
{
    public partial class Facturación : Form
    {
        FacturacionModel FM = new FacturacionModel();
        ComprobantesFiscalesModel CF = new ComprobantesFiscalesModel();
        DiseñoInterface DI = new DiseñoInterface();
        Funciones FC = new Funciones();
        ProformaFactura PF = new ProformaFactura();

        public string NotasFactura { get; set; }

        public void NuevaFecha(string fecha)
        {
            txtFechaLimitePago.Text = fecha;
        }


        public void DetallesViajesChofer(string PRODUCTO, int CANTIDAD, string NUMFACT,int CONDUCE, string CHOFER){}

        public Facturación()
        {
            InitializeComponent();
            ActualizarVentana();
            ResetCriteriosBusqueda();
        }

        private void ActualizarVentana()
        {


            txtFechaFactura.Text = DateTime.Now.ToShortDateString();
            txtFechaLimitePago.Text = DateTime.Now.ToShortDateString();
        }

        private void rdbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEfectivo.Checked==true)
            {
                txtFechaLimitePago.Text = DateTime.Now.ToShortDateString();
                FacturacionModel.IDModoPago = 1;
            }
        }

        private void rdbCheque_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCheque.Checked == true)
            {
                txtFechaLimitePago.Text = DateTime.Now.ToShortDateString();
                FacturacionModel.IDModoPago = 2;
            }
        }

        private void rbTransferencia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTransferencia.Checked == true)
            {
                txtFechaLimitePago.Text = DateTime.Now.ToShortDateString();
                FacturacionModel.IDModoPago = 4;
            }
        }

        private void rdbCredito_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCredito.Checked == true)
            {
                frmDialogoVencimientoFactura frmDialogo = new frmDialogoVencimientoFactura();
                FacturacionModel.IDModoPago = 3;
                frmDialogo.ShowDialog();
                txtFechaLimitePago.Text = FacturacionModel.FechaVencimientoFactura.ToString("dd/MM/yyyy");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Abrir dialogo para nuscar factura por codigo
            frmBuscarFactura BF = new frmBuscarFactura();
            BF.ShowDialog();
        }

        private void cmdVerFactura_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdVerFactura, 1);
        }

        private void cmdVerFactura_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(cmdVerFactura, 0);
        }

        private void cmdVerFactura_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdVerFactura, 2);
        }

        private void cmdFacturaSinComprobante_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdFacturaSinComprobante, 1);
        }

        private void cmdFacturaSinComprobante_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(cmdFacturaSinComprobante, 0);
        }

        private void cmdFacturaSinComprobante_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdFacturaSinComprobante, 2);
        }

        private void cmdFacturar_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdFacturar, 1);
        }

        private void cmdFacturar_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(cmdFacturar, 0);
        }

        private void cmdFacturar_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdFacturar, 2);
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(button3, 1);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(button3, 0);
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(button3, 2);
        }

        
        private async Task BuscarPedidos()
        {
            //Llamar y pasar los parametros a los procedimientos para obtener el cliente y sus pedidos

            if (ValidarCriterios())
            {
                
                await Task.Run(() =>
                {
                    FM.BuscarClienteFacturar(FacturacionModel.IDCliente);
                });

                if (FM.ClienteFactura.Count != 0)
                {
                    await Task.Run(() =>
                    {
                        FM.BuscarPedidosClienteFacturar(FacturacionModel.IDCliente, FacturacionModel.IDPedido,
                        FacturacionModel.ModoReporte, FacturacionModel.EstatusPedido, FacturacionModel.FechaInicio,
                        FacturacionModel.FechaFin, FacturacionModel.NumConduce);
                    });


                    if (FM.PedidosClientesFacturar.Count != 0)
                    {
                        await Task.Run(() =>
                        {
                            FM.BuscarConducesFactura(FacturacionModel.IDCliente, FacturacionModel.IDPedido, FacturacionModel.ModoReporte,
                            FacturacionModel.EstatusPedido, FacturacionModel.FechaInicio, FacturacionModel.FechaFin, 
                            FacturacionModel.NumConduce);
                        });


                        //Limpiar todo el contenido de los datagridviews
                        dgvPedidosFacturar.DataSource = "";
                        dgvPedidosFacturar.Columns.Clear();
                        dgvConducesFactura.DataSource = "";
                        dgvConducesFactura.Columns.Clear();

                        //Llenar el DatagridView con los pedidos según criterio
                        dgvPedidosFacturar.DataSource = FM.PedidosClientesFacturar.ToList();
                        //Llenar el DatagridView con los conduces según criterio
                        dgvConducesFactura.DataSource = FM.ConducesFacturar.ToList();

                        //Llenar los campos del cliente
                        txtCliente.Text = FacturacionModel.NombreCliente;
                        txtContactos.Text = FacturacionModel.Contactos;
                        txtTelefonos.Text = FacturacionModel.Telefonos;
                        txtDirección.Text = FacturacionModel.Direccion;
                        txtCorreo.Text = FacturacionModel.Correo;
                        TxtRNC.Text = FacturacionModel.RNC;

                        //Llenar los totales
                        txtSubTotal.Text = FacturacionModel.SubTotalFactura.ToString("C");
                        FacturacionModel.ITBISFactura = (FacturacionModel.SubTotalFactura - FacturacionModel.DescuentoFactura) * 0.18;
                        txtDesc.Text = FacturacionModel.DescuentoFactura.ToString("C");
                        txtITBIS.Text = FacturacionModel.ITBISFactura.ToString("C");
                        FacturacionModel.TotalFactura = FacturacionModel.ITBISFactura + FacturacionModel.SubTotalFactura;
                        TxtTotalGeneral.Text = FacturacionModel.TotalFactura.ToString("C");

                        FM.FormatPedidosFacturar(dgvPedidosFacturar.Columns, dgvConducesFactura.Columns);
                        FM.FormatPedidosFacturar(dgvPedidosFacturar.Rows, dgvConducesFactura.Rows);
                    }


                }

                lblMsgCarga.Text = "Listo";
                lblMsgCarga.BackColor = Color.Transparent;
                cmdBuscarPedido.Enabled = true;

            }

        }

        private  void cmdBuscarPedido_Click(object sender, EventArgs e)
        {
            //Iniciar las tarea principal
            Task Pedidos = BuscarPedidos();
            cmdBuscarPedido.Enabled = false;
            lblMsgCarga.Text = "Buscando...";
            lblMsgCarga.BackColor = Color.DarkRed;
           

        }

        private void cboCriterioPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCriterioPedidos.SelectedIndex==0)
            {
                FacturacionModel.IDPedido = 0;
                nUpDownPedidos.Enabled = false;
            }
            else
            {
                nUpDownPedidos.Enabled = true;
                FacturacionModel.IDPedido = (int)nUpDownPedidos.Value;
            }
        }

        private void cboEstatusPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            FacturacionModel.EstatusFactura = cboEstatusPedidos.SelectedIndex;
        }

        private void cboModoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboModoReporte.SelectedIndex==0)
            {
                dtpFechaInicio.Enabled = false;
                dtpFechaFin.Enabled = false;
            }
            else
            {
                dtpFechaInicio.Enabled = true;
                dtpFechaFin.Enabled = true;
            }

            FacturacionModel.ModoReporte = cboModoReporte.Text;
        }

        private void ResetCriteriosBusqueda()
        {
            cboCriterioPedidos.SelectedIndex = 0;
            cboCriterioConduces.SelectedIndex = 0;
            nUpDownPedidos.Value = 1;
            cboEstatusPedidos.SelectedIndex = 1;
            cboModoReporte.SelectedIndex = 0;
            dtpFechaInicio.Value.ToShortDateString();
            dtpFechaFin.Value.ToShortDateString();
            txtCodigoCliente.Clear();
        }

        private bool ValidarCriterios()
        {
            if (txtCodigoCliente.Text!="")
            {
                if (nUpDownConduces.Value!=0)
                {
                    if (nUpDownPedidos.Value != 0)
                    {
                        FacturacionModel.IDCliente = int.Parse(txtCodigoCliente.Text);
                        if (!nUpDownPedidos.Enabled)
                        {
                            FacturacionModel.IDPedido = 0;
                        }
                        else
                        {
                            FacturacionModel.IDPedido = (int)nUpDownPedidos.Value;
                        }

                        if (!nUpDownConduces.Enabled)
                        {
                            FacturacionModel.NumConduce = 0;
                        }
                        else
                        {
                            FacturacionModel.NumConduce = (int)nUpDownConduces.Value;
                        }

                        FacturacionModel.EstatusPedido = 1;

                        FacturacionModel.ModoReporte = cboModoReporte.Text;

                        FacturacionModel.FechaInicio = dtpFechaInicio.Value;
                        FacturacionModel.FechaFin = dtpFechaFin.Value;

                    }
                    else
                    {
                        MessageBox.Show("Debe indicar un numero de pedido valido", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Debe indicar un numero de conduce valido", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                

            }
            else
            {
                MessageBox.Show("Debe indicar el codigo del cliente a consultar", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCodigoCliente.Focus();
                return false;
            }

            return true;
        }

        private void cmdResetCriterios_Click(object sender, EventArgs e)
        {
            ResetCriteriosBusqueda();
        }

        private void cboCriterioConduces_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCriterioConduces.SelectedIndex == 0)
            {
                FacturacionModel.NumConduce = 0;
                nUpDownConduces.Enabled = false;
            }
            else
            {
                nUpDownConduces.Enabled = true;
                FacturacionModel.NumConduce = (int)nUpDownConduces.Value;
            }
        }

        private void cmdFacturar_Click(object sender, EventArgs e)
        {
            if (FacturacionModel.IDCliente!=0)
            {
                if (dgvPedidosFacturar.Rows.Count != 0)
                {
                    DialogResult Resp = MessageBox.Show("¿Desea agregar una nota a esta factura?", "Nota factura",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (Resp == DialogResult.Yes)
                    {
                        frmNotaFactura Nota = new frmNotaFactura();
                        Nota.ShowDialog();
                        FacturacionModel.NotasFactura = frmNotaFactura.NotaFactura;
                    }
                    else
                    {
                        FacturacionModel.NotasFactura = "";
                    }

                    RevisarParametrosFactura(groupOpt.Controls);

                    //Almacenar el ID de la factura generada
                    FacturacionModel.IDFactura = int.Parse(txtNumFactura.Text);




                    if (FM.InsertarFactura(FacturacionModel.IDTipoFactura, FacturacionModel.NCF,
                        FacturacionModel.IDCliente, FacturacionModel.EstatusFactura, FacturacionModel.SubTotalFactura,
                        FacturacionModel.DescuentoFactura, FacturacionModel.ITBISFactura, FacturacionModel.TotalFactura,
                        FacturacionModel.IDModoPago, FacturacionModel.FechaFactura, FacturacionModel.FechaVencimientoFactura,
                        FacturacionModel.HoraFactura, FacturacionModel.NotasFactura, FacturacionModel.IDUsuario, FacturacionModel.IDPago,
                        dgvPedidosFacturar, dgvConducesFactura, ComprobantesFiscalesModel.VencimientoComprobante))
                    {

                        MessageBox.Show($"Se ha registrado correctamente la factura al cliente [{FacturacionModel.NombreCliente}].",
                            "Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        if (FacturacionModel.IDTipoFactura != 1)
                        {
                            //Registra el comprobante usado en este numero de factura
                            CF.ActualizarComprobanteUsado();
                            //Generar nueva factura NCF
                            NuevaFacturaNCF();
                        }
                        else
                        {
                            NuevaFacturaSinNCF();
                        }
                        
                        Loading frmCargar = new Loading();
                        frmVistaFactura frmFactura = new frmVistaFactura();
                        FC.Ejecutar(frmFactura, frmCargar, txtCliente.Text);

                    }
                }
                else
                {
                    MessageBox.Show($"No existen pedidos en en listado para facturar",
                        "Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodigoCliente.Focus();
                }

            }
            else
            {
                MessageBox.Show($"Debe indicar un cliente a facturar",
                    "Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodigoCliente.Focus();
            }
            
           
        }

        private void CKITBIS_CheckedChanged(object sender, EventArgs e)
        {
            if (CKITBIS.Checked)
            {
                FacturacionModel.ITBISFactura = (FacturacionModel.SubTotalFactura - FacturacionModel.DescuentoFactura) * 0.18;
                FacturacionModel.TotalFactura = FacturacionModel.SubTotalFactura + FacturacionModel.ITBISFactura;

                TxtTotalGeneral.Text = FacturacionModel.TotalFactura.ToString("C");
                txtITBIS.Text = FacturacionModel.ITBISFactura.ToString("C");
            }
            else
            {
                FacturacionModel.ITBISFactura = 0;
                FacturacionModel.TotalFactura = FacturacionModel.SubTotalFactura - FacturacionModel.DescuentoFactura;

                TxtTotalGeneral.Text = FacturacionModel.TotalFactura.ToString("C");
                txtITBIS.Text = FacturacionModel.ITBISFactura.ToString("C");
            }
        }

        private void RevisarParametrosFactura(Control.ControlCollection CondicionPago)
        {
            var OpcionMarcada = CondicionPago.OfType<RadioButton>().Where(t => t.Checked == true).SingleOrDefault();

            DateTime FechaNeutra = new DateTime();
            FacturacionModel.IDModoPago = int.Parse(OpcionMarcada.Tag.ToString());
            FacturacionModel.IDTipoFactura = int.Parse(lblTipoNCF.Tag.ToString());
            FacturacionModel.EstatusFactura = 2;
            FacturacionModel.TipoCliente = FM.ClienteFactura.SingleOrDefault().TipoCliente;
            FacturacionModel.NCF = txtNCF.Text;
            FacturacionModel.IDCliente = FM.ClienteFactura.SingleOrDefault().ID;
            FacturacionModel.FechaFactura = DateTime.Parse(DateTime.Parse(txtFechaFactura.Text).ToString("yyyy/MM/dd"));
            FacturacionModel.FechaVencimientoFactura = DateTime.Parse(DateTime.Parse(txtFechaLimitePago.Text).ToString("yyyy/MM/dd"));
            FacturacionModel.HoraFactura = TimeSpan.Parse(DateTime.Now.ToString("H:mm:ss"));
            FacturacionModel.IDUsuario = 1;
            FacturacionModel.IDPago = 0;
            ComprobantesFiscalesModel.VencimientoComprobante = (FacturacionModel.IDTipoFactura != 1) ?
                ComprobantesFiscalesModel.VencimientoComprobante : DateTime.Parse(FechaNeutra.ToString("dd/MM/yyyy"));

        }

        private void Facturación_Load(object sender, EventArgs e)
        {
            NuevaFacturaNCF();
        }

        private void NuevaFacturaNCF()
        {
            txtNCF.Text = CF.CargarNuevoComprobante();
            if (txtNCF.Text!="B0000000000")
            {
                //Obtener un nuevo numero de factura
                txtNumFactura.Text = FM.CargarNuevaFactura().ToString().PadLeft(6, '0');
                FacturacionModel.IDTipoFactura = 2;
                //Limpiar campos de factura
                FM.LimpiarFactura(PanelCliente.Controls, splitContainer1.Panel2.Controls,
                    rdbEfectivo, gbFechasFactura.Controls, CKITBIS, dgvPedidosFacturar,
                   dgvConducesFactura);
                //Colocar los criterios por defecto
                ResetCriteriosBusqueda();
                lblVencimientoComprobante.Text = ComprobantesFiscalesModel.VencimientoComprobante.ToString("dd/MM/yyyy");
                lblTituloFechaComprobante.Visible = true;
                lblTipoNCF.Tag = FacturacionModel.IDTipoFactura;
                lblTipoNCF.Text = "Crédito Fiscal";
            }
            else
            {
                NuevaFacturaSinNCF();
            }
           

        }

        private void NuevaFacturaSinNCF()
        {
            FacturacionModel.IDTipoFactura = 1;
            //Limpiar campos de factura
            FM.LimpiarFactura(PanelCliente.Controls, splitContainer1.Panel2.Controls,
                rdbEfectivo, gbFechasFactura.Controls, CKITBIS, dgvPedidosFacturar,
               dgvConducesFactura);
            //Colocar los criterios por defecto
            ResetCriteriosBusqueda();
            //Obtener un nuevo numero de factura
            txtNumFactura.Text = FM.CargarNuevaFactura().ToString().PadLeft(6, '0');
            txtNCF.Text = "B0000000000";
            lblTipoNCF.Text = "Consumidor Final";
            lblVencimientoComprobante.Text = null;
            lblTituloFechaComprobante.Visible = false;
            lblTipoNCF.Tag = FacturacionModel.IDTipoFactura;
        }

        private void cmdVerFactura_Click(object sender, EventArgs e)
        {
            NuevaFacturaNCF();
        }

        private void cmdFacturaSinComprobante_Click(object sender, EventArgs e)
        {
            NuevaFacturaSinNCF();
        }

        private void cmdBuscarPedido_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdBuscarPedido, 1);
        }

        private void cmdBuscarPedido_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(cmdBuscarPedido, 0);
        }

        private void cmdBuscarPedido_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdBuscarPedido, 2);
        }

        private void txtCodigoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                cmdBuscarPedido_Click(sender, e);
            }
            //Permitir solo numeros
            FC.SoloNumeros(e);

        }

        private void cmdResetCriterios_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdResetCriterios, 1);
        }

        private void cmdResetCriterios_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(cmdResetCriterios, 0);
        }

        private void cmdResetCriterios_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdResetCriterios, 2);
        }

        private void txtDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            FC.SoloNumeros(e);
        }

        private void dgvPedidosFacturar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPedidosFacturar.RowCount != 0)
            {
                int PedidoSeleccionado = (int)dgvPedidosFacturar.SelectedRows[0].Cells["NumPedido"].Value;

                FM.BuscarConducesFactura(FacturacionModel.IDCliente, PedidoSeleccionado,
                    FacturacionModel.ModoReporte, FacturacionModel.EstatusPedido,
                    FacturacionModel.FechaInicio, FacturacionModel.FechaFin, FacturacionModel.NumConduce);


                dgvConducesFactura.DataSource = null;
                dgvConducesFactura.DataSource = FM.ConducesFacturar.ToList();
                dgvConducesFactura.ClearSelection();


                //Formatear columnas detalles
                //FormatearColumnasDetalles();
            }
        }
    }
}
