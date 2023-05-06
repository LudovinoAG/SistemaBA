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
    public partial class frmMantenimientoPedidos : Form
    {
        FacturacionModel FM = new FacturacionModel();
        PedidosModel PM = new PedidosModel();
        public frmMantenimientoPedidos()
        {
            InitializeComponent();
            ResetCriteriosBusqueda();
            LoadProductos();
            LoadMedidas();
            LoadEmpleados();
            LoadVehiculos();
        }

        private void LoadProductos()
        {

            cboProducto.ValueMember = "ID";
            cboProducto.DisplayMember = "Producto";
            cboProducto.DataSource = PM.ProductosFactura().ToList();
        }

        private void LoadMedidas()
        {

            cboMedidas.ValueMember = "ID";
            cboMedidas.DisplayMember = "Medida";
            cboMedidas.DataSource = PM.MedidasFactura().ToList();
        }

        private void LoadEmpleados()
        {

            cboChoferes.ValueMember = "ID";
            cboChoferes.DisplayMember = "Chofer";
            cboChoferes.DataSource = PM.EmpleadosFactura().ToList();
        }

        private void LoadVehiculos()
        {

            cboVehiculos.ValueMember = "ID";
            cboVehiculos.DisplayMember = "Descripcion";
            cboVehiculos.DataSource = PM.VehiculosFactura().ToList();
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
                        //txtDesc.Text = FacturacionModel.DescuentoFactura.ToString("C");
                        //txtITBIS.Text = FacturacionModel.ITBISFactura.ToString("C");
                        FacturacionModel.TotalFactura = FacturacionModel.ITBISFactura + FacturacionModel.SubTotalFactura;
                        //TxtTotalGeneral.Text = FacturacionModel.TotalFactura.ToString("C");

                        FM.FormatPedidosFacturar(dgvPedidosFacturar.Columns, dgvConducesFactura.Columns);
                        FM.FormatPedidosFacturar(dgvPedidosFacturar.Rows, dgvConducesFactura.Rows);
                    }


                }

                lblMsgCarga.Text = "Listo";
                lblMsgCarga.BackColor = Color.Transparent;
                cmdBuscarPedido.Enabled = true;

            }

        }

        private void cmdBuscarPedido_Click(object sender, EventArgs e)
        {
            //Iniciar las tarea principal
            Task Pedidos = BuscarPedidos();
            cmdBuscarPedido.Enabled = false;
            lblMsgCarga.Text = "Buscando...";
            lblMsgCarga.BackColor = Color.DarkRed;


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

        private void cmdResetCriterios_Click(object sender, EventArgs e)
        {
            ResetCriteriosBusqueda();
        }

        private void cboCriterioPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCriterioPedidos.SelectedIndex == 0)
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
            if (cboModoReporte.SelectedIndex == 0)
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

        private bool ValidarCriterios()
        {
            if (txtCodigoCliente.Text != "")
            {
                if (nUpDownConduces.Value != 0)
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

        private void dgvPedidosFacturar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
       
            if (dgvPedidosFacturar.RowCount != 0)
            {
                //Obtener el valor de las columnas y asignarlas a los controles
                //Reset Campos conduces
                ResetCamposConduces();
                //Seleccionar la primera fila de la lista de conduces asociados
                dgvConducesFactura.Rows[0].Selected = true;
                //Detalles de Pedidos a facturar
                int indexP = cboProducto.FindStringExact(dgvPedidosFacturar.Rows[e.RowIndex].Cells["Producto"].Value.ToString());
                cboProducto.SelectedIndex = indexP;

                int indexM = cboMedidas.FindStringExact(dgvPedidosFacturar.Rows[e.RowIndex].Cells["Medida"].Value.ToString());
                cboMedidas.SelectedIndex = indexM;

                nUpDownCantidad.Value = (decimal)dgvPedidosFacturar.Rows[e.RowIndex].Cells["Cantidad"].Value;
                dtpFechaConduce.Value = (DateTime)dgvPedidosFacturar.Rows[e.RowIndex].Cells["FechaConduce"].Value;

                decimal precio = (decimal)dgvPedidosFacturar.Rows[e.RowIndex].Cells["Precio"].Value;
                txtPrecio.Text = precio.ToString("N");

                decimal ITBIS = (decimal)dgvPedidosFacturar.Rows[e.RowIndex].Cells["ITBIS"].Value;
                txtITBIS.Text = ITBIS.ToString("N");

                decimal SubTotal = (decimal)dgvPedidosFacturar.Rows[e.RowIndex].Cells["SubTotal"].Value;
                txtSubTotal.Text = SubTotal.ToString("N");

                decimal Total = (decimal)dgvPedidosFacturar.Rows[e.RowIndex].Cells["TotalPedido"].Value;
                txtTotal.Text = Total.ToString("N");

                int PedidoSeleccionado = (int)dgvPedidosFacturar.SelectedRows[0].Cells["NumPedido"].Value;

                txtPedidoSeleccionado.Text = PedidoSeleccionado.ToString();

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

        private void dgvConducesFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Al seleccionar la fila llenar los campos
            txtDescripcion.Text = dgvConducesFactura.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
            txtNumConduce.Text = dgvConducesFactura.Rows[e.RowIndex].Cells["NumeroConduce"].Value.ToString();

            int indexC = cboChoferes.FindStringExact(dgvConducesFactura.Rows[e.RowIndex].Cells["Chofer"].Value.ToString());
            cboChoferes.SelectedIndex = indexC;

            int indexV = cboVehiculos.FindStringExact(dgvConducesFactura.Rows[e.RowIndex].Cells["Vehiculo"].Value.ToString());
            cboVehiculos.SelectedIndex = indexV;

            nUpDownViajes.Value = (int)dgvConducesFactura.Rows[e.RowIndex].Cells["Viajes"].Value;
            decimal Subtotal = (decimal)dgvConducesFactura.Rows[e.RowIndex].Cells["SubTotal"].Value;
            txtSubTotalConduce.Text = Subtotal.ToString("N");

            decimal ITBIS = (decimal)dgvConducesFactura.Rows[e.RowIndex].Cells["ITBIS"].Value;
            txtITBISConduce.Text = ITBIS.ToString("N");

            int ConduceSeleccionado = (int)dgvConducesFactura.SelectedRows[0].Cells["NumeroConduce"].Value;
            txtConduceSeleccionado.Text = ConduceSeleccionado.ToString();

        }


        private void ResetCamposConduces()
        {
            txtDescripcion.Text = "";
            txtNumConduce.Text = "";
            cboChoferes.SelectedIndex = 0;
            cboVehiculos.SelectedIndex = 0;
            nUpDownViajes.Value = 1;
            txtSubTotalConduce.Text = "0.00";
            txtITBISConduce.Text = "0.00";
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
