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
using Sistema_de_Gestión.Presentacion;

namespace Sistema_de_Gestión.Presentacion
{
    public partial class frmVerProforma : Form
    {
        ProformaFactura PF = new ProformaFactura();
        Funciones FC = new Funciones();
        DiseñoInterface DI = new DiseñoInterface();
        FacturacionModel FM = new FacturacionModel();
        
        public frmVerProforma()
        {
            InitializeComponent();

        }

        private void cmdBuscarCliente_Click(object sender, EventArgs e)
        {
            if (txtCodigoCliente.Text != "")
            {
                _ = FC.EjecutarAccion(PF, $"C{ txtCodigoCliente.Text.PadLeft(6, '0')}", toolProformaEstado, cmdBuscarCliente);
                if (PF.ClienteProforma.Count!=0)
                {
                    FC.LimpiarCampos(Controls);
                    FC.LimpiarCampos(gbTotales.Controls);
                    //Limpiar DataGridView
                    ProformaFactura.IDCliente = PF.ClienteProforma.Single().ID;
                    ProformaFactura.Nombre_Cliente = PF.ClienteProforma.Single().Empresa;
                    TxtRNC.Text = PF.ClienteProforma.Single().RNC;
                    txtCliente.Text = PF.ClienteProforma.Single().Empresa;
                    txtContactos.Text = PF.ClienteProforma.Single().NombreContacto;
                    txtTelefonos.Text = PF.ClienteProforma.Single().TelefonoContactos;
                }
               
            }
            else
            {
                MessageBox.Show("De indicar un codigo valido de cliente", "Buscar Cliente",
                    MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txtCodigoCliente.Focus();
            }

        }

        private void cmdVerProforma_Click(object sender, EventArgs e)
        {
            
            if (!FC.ValidarVentanaAbierta($"Vista Factura Proforma - {txtCliente.Text}"))
            {
                if (dgvPedidos.RowCount!=0)
                {
                    if (txtCliente.Text != "")
                    {
                        frmVistaProforma VistaProformo = new frmVistaProforma();
                        LoadingReportes LoadReport = new LoadingReportes();

                        ValidarCriterios();


                        //Ejecutar la siguiente tarea
                        FC.Ejecutar(VistaProformo, LoadReport,txtCliente.Text);
                    }
                    else
                    {
                        MessageBox.Show($"Debe indicar un cliente a visualizar.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtCodigoCliente.Focus();
                    }
                 
                }
                else
                {
                    MessageBox.Show($"No existen pedidos para visualizar de este cliente [{txtCliente.Text}]", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
            else
            {
                MessageBox.Show("Ya se esta visualizando la factura proforma indicada", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }


        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPedidos.RowCount!=0 && e.RowIndex>=0)
            {
                ProformaFactura.IDPedido = (int)dgvPedidos.Rows[e.RowIndex].Cells[0].Value;
                PF.VerConduceProforma(ProformaFactura.IDCliente, ProformaFactura.IDPedido,
                    ProformaFactura.ModoReporte,ProformaFactura.EstatusPedido,ProformaFactura.FechaInicio,
                    ProformaFactura.FechaFin);

                toolProformaConducesRegistrados.Text = $"Conduces: {PF.ConduceProforma.Count()}";

                dgvConduceProforma.DataSource = null;
                dgvConduceProforma.DataSource = PF.ConduceProforma.ToList();
                dgvConduceProforma.ClearSelection();
            }
        }

        private void frmVerProforma_Load(object sender, EventArgs e)
        {
            //Carga los valores por defectos
            LoadDefaultValue();

        }

        private void cmdBuscarPedido_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text != "")
            {
                ValidarCriterios();

                _ = FC.EjecutarAccion(PF,toolProformaEstado, cmdBuscarPedido, ProformaFactura.IDCliente,
                    ProformaFactura.IDPedido,ProformaFactura.ModoReporte,ProformaFactura.EstatusPedido,
                    ProformaFactura.FechaInicio,ProformaFactura.FechaFin);

                dgvPedidos.DataSource = null;
                dgvConduceProforma.DataSource = null;
                dgvPedidos.DataSource = PF.PedidoProforma.ToList();
                dgvPedidos.ClearSelection();
                toolProformaConducesRegistrados.Text = "Conduces: 0";

                //Establecer los montos
                txtSubTotal.Text = PF.PedidoProforma.ToList().Sum(x => x.SubTotal).Value.ToString("0,0.00");
                TxtDescuento.Text = PF.PedidoProforma.ToList().Sum(x => x.Descuento).Value.ToString("0,0.00");
                txtITBIS.Text = PF.PedidoProforma.ToList().Sum(x => x.ITBIS).Value.ToString("0,0.00");
                txtTotal.Text = PF.PedidoProforma.ToList().Sum(x => x.TotalPedido).Value.ToString("0,0.00");
                toolProformaPedidosRegistrados.Text = $"Pedidos registrados: {PF.PedidoProforma.Count()}";

                //Cambiar nombre de encabezado de columnas
                dgvPedidos.Columns["NumPedido"].HeaderText = "Pedido #";
                dgvPedidos.Columns["FechaPedido"].HeaderText = "Fecha";
                dgvPedidos.Columns["TotalPedido"].HeaderText = "Total";
                dgvPedidos.Columns["SubTotal"].HeaderText = "Sub-Total";

                //Cambiar formato de las columna a moneda
                dgvPedidos.Columns["Precio"].DefaultCellStyle.Format = "N";
                dgvPedidos.Columns["SubTotal"].DefaultCellStyle.Format = "N";
                dgvPedidos.Columns["Descuento"].DefaultCellStyle.Format = "N";
                dgvPedidos.Columns["ITBIS"].DefaultCellStyle.Format = "N";
                dgvPedidos.Columns["TotalPedido"].DefaultCellStyle.Format = "N";
            }
            else
            {
                MessageBox.Show("Debe buscar primero el cliente a consultar", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCodigoCliente.Focus();
            }
        }

        private void cboCriterioPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCriterioPedidos.SelectedIndex==0)
            {
                ProformaFactura.IDPedido = 0;
                nUpDownPedidos.Enabled = false;
            }
            else
            {
                ProformaFactura.IDPedido = (int)nUpDownPedidos.Value;
                nUpDownPedidos.Enabled = true;
            }
            
        }

        private void nUpDownPedidos_ValueChanged(object sender, EventArgs e)
        {
            ProformaFactura.IDPedido = (int)nUpDownPedidos.Value;
        }

        private void cboEstatusPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProformaFactura.EstatusPedido = cboEstatusPedidos.SelectedIndex;
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
            ProformaFactura.ModoReporte = cboModoReporte.SelectedText;
        }

        private void LoadDefaultValue()
        {
            PF.DefaultValueProforms(cboCriterioPedidos, cboEstatusPedidos, cboModoReporte,
                dtpFechaInicio, dtpFechaFin, nUpDownPedidos);
        }

        private void ValidarCriterios()
        {
            ProformaFactura.IDCliente = PF.ClienteProforma.Single().ID;

            //Establecer el valor del ID Pedido segun sea necesario
            if (cboCriterioPedidos.SelectedIndex==0)
            {
                ProformaFactura.IDPedido = 0;
            }
            else
            {
                ProformaFactura.IDPedido = (int)nUpDownPedidos.Value;
            }

            ProformaFactura.EstatusPedido = cboEstatusPedidos.SelectedIndex;
            ProformaFactura.ModoReporte = cboModoReporte.Text;
            ProformaFactura.FechaInicio = dtpFechaInicio.Value;
            ProformaFactura.FechaFin = dtpFechaFin.Value;

            frmVistaProforma.idCliente = ProformaFactura.IDCliente;
            frmVistaProforma.idPedido = ProformaFactura.IDPedido;
            frmVistaProforma.EstatusPedido = ProformaFactura.EstatusPedido;
            frmVistaProforma.ModoReporte = ProformaFactura.ModoReporte;
            frmVistaProforma.FechaInicio = ProformaFactura.FechaInicio;
            frmVistaProforma.FechaFin = ProformaFactura.FechaFin;


        }

        private void txtCodigoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            FC.SoloNumeros(e);
            if (e.KeyChar==13)
            {
                cmdBuscarCliente_Click(sender,e);
            }
        }

        private void cmdResetCriterios_Click(object sender, EventArgs e)
        {
            LoadDefaultValue();
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

        private void cmdVerProforma_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdVerProforma, 1);
        }

        private void cmdVerProforma_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(cmdVerProforma, 0);
        }

        private void cmdVerProforma_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdVerProforma, 2);
        }

        private void cmdFacturacion_Click(object sender, EventArgs e)
        {
            FacturacionModel.IDCliente = ProformaFactura.IDCliente;
            FacturacionModel.NombreCliente = txtCliente.Text;
            


            Facturación Factura = new Facturación();
            Factura.Show();
        }
    }
}
