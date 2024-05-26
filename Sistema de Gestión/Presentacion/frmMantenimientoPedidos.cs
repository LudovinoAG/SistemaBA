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
                cmdBuscarPedido.Enabled = false;
                lblMsgCarga.Text = "Buscando...";
                lblMsgCarga.BackColor = Color.DarkRed;

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
                        //txtSubTotal.Text = FacturacionModel.SubTotalFactura.ToString("C");
                        FacturacionModel.ITBISFactura = (FacturacionModel.SubTotalFactura - FacturacionModel.DescuentoFactura) * 0.18;
                        //txtDesc.Text = FacturacionModel.DescuentoFactura.ToString("C");
                        //txtITBIS.Text = FacturacionModel.ITBISFactura.ToString("C");
                        FacturacionModel.TotalFactura = FacturacionModel.ITBISFactura + FacturacionModel.SubTotalFactura;
                        //TxtTotalGeneral.Text = FacturacionModel.TotalFactura.ToString("C");

                        FM.FormatPedidosFacturar(dgvPedidosFacturar.Columns, dgvConducesFactura.Columns);
                        FM.FormatPedidosFacturar(dgvPedidosFacturar.Rows, dgvConducesFactura.Rows);
                        //Formatear columnas detalles
                        FormatearColumnasDetalles(dgvConducesFactura.Columns);
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
                int PedidoSeleccionado = (int)dgvPedidosFacturar.SelectedRows[0].Cells["NumPedido"].Value;

                txtPedidoSeleccionado.Text = PedidoSeleccionado.ToString();

                FM.BuscarConducesFactura(FacturacionModel.IDCliente, PedidoSeleccionado,
                    FacturacionModel.ModoReporte, FacturacionModel.EstatusPedido,
                    FacturacionModel.FechaInicio, FacturacionModel.FechaFin, FacturacionModel.NumConduce);


                dgvConducesFactura.DataSource = null;
                dgvConducesFactura.DataSource = FM.ConducesFacturar.ToList();
                dgvConducesFactura.ClearSelection();

                //Formatear columnas detalles
                FormatearColumnasDetalles(dgvConducesFactura.Columns);
                FM.FormatPedidosFacturar(dgvPedidosFacturar.Rows, dgvConducesFactura.Rows);
            }



        }

        private void FormatearColumnasDetalles(DataGridViewColumnCollection Columnas)
        {
            Columnas["ID"].HeaderText = "Registro";
            Columnas["FechaPedido"].HeaderText = "Fecha Pedido";
            Columnas["FechaConduce"].HeaderText = "Fecha Conduce";
            Columnas["NumeroConduce"].HeaderText = "Conduce";
            Columnas["Precio"].DefaultCellStyle.Format = "C2";
            Columnas["SubTotal"].DefaultCellStyle.Format = "C2";
            Columnas["ITBIS"].DefaultCellStyle.Format = "C2";

        }

        private void dgvConducesFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Al seleccionar la fila llenar los campos

            int ConduceSeleccionado = (int)dgvConducesFactura.SelectedRows[0].Cells["ID"].Value;
            txtConduceSeleccionado.Text = ConduceSeleccionado.ToString();

            dtpFechaConduce.Value = (DateTime)dgvConducesFactura.Rows[e.RowIndex].Cells["FechaConduce"].Value;
            txtNumConduce.Text = dgvConducesFactura.Rows[e.RowIndex].Cells["NumeroConduce"].Value.ToString();
            nUpDownCantidad.Value = (decimal)dgvConducesFactura.Rows[e.RowIndex].Cells["Cantidad"].Value;
            int indexM = cboMedidas.FindStringExact(dgvConducesFactura.Rows[e.RowIndex].Cells["Medidas"].Value.ToString());
            cboMedidas.SelectedIndex = indexM;
            int indexP = cboProducto.FindStringExact(dgvConducesFactura.Rows[e.RowIndex].Cells["Productos"].Value.ToString());
            cboProducto.SelectedIndex = indexP;
            decimal precio = (decimal)dgvConducesFactura.Rows[e.RowIndex].Cells["Precio"].Value;
            txtPrecio.Text = precio.ToString("N");
            nUpDownViajes.Value = (int)dgvConducesFactura.Rows[e.RowIndex].Cells["Viajes"].Value;
            decimal Subtotal = (decimal)dgvConducesFactura.Rows[e.RowIndex].Cells["SubTotal"].Value;
            txtSubTotalConduce.Text = Subtotal.ToString("N");
            decimal ITBIS = (decimal)dgvConducesFactura.Rows[e.RowIndex].Cells["ITBIS"].Value;
            txtITBISConduce.Text = ITBIS.ToString("N");
            int indexC = cboChoferes.FindStringExact(dgvConducesFactura.Rows[e.RowIndex].Cells["Chofer"].Value.ToString());
            cboChoferes.SelectedIndex = indexC;
            int indexV = cboVehiculos.FindStringExact(dgvConducesFactura.Rows[e.RowIndex].Cells["Vehiculo"].Value.ToString());
            cboVehiculos.SelectedIndex = indexV;
            nUpDownCapacidad.Value = (decimal)dgvConducesFactura.Rows[e.RowIndex].Cells["Capacidad"].Value;
            txtDescripcion.Text = dgvConducesFactura.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();

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
            lblOldSubTotal.Text = "0.00";
        }

        private void ResetCamposPedidos()
        {
            txtPedidoSeleccionado.Clear();
            txtConduceSeleccionado.Clear();
            cboProducto.SelectedIndex = 0;
            nUpDownCantidad.Value = 1;
            cboMedidas.SelectedIndex = 0;
            dtpFechaConduce.Value = DateTime.Now.Date;
            txtPrecio.Text = "0.00";
        }

        private void ResetInfoCliente()
        {
            txtCliente.Clear();
            txtContactos.Clear();
            txtTelefonos.Clear();
            TxtRNC.Clear();
            txtDirección.Clear();
            txtCorreo.Clear();

            dgvPedidosFacturar.DataSource = null;
            dgvConducesFactura.DataSource = null;
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (txtPedidoSeleccionado.Text!="" && txtConduceSeleccionado.Text!="")
            {
                int Pedido = int.Parse(txtPedidoSeleccionado.Text);
                int Cliente = int.Parse(txtCodigoCliente.Text);
                int idConduce = int.Parse(txtConduceSeleccionado.Text);
                int idDetallesPedidos = idConduce;
                int NumConduce = Convert.ToInt16(txtNumConduce.Text);
                decimal Cantidad = nUpDownCantidad.Value;
                int Medida = (int)cboMedidas.SelectedValue;
                int Producto = (int)cboProducto.SelectedValue;
                string Descripcion = txtDescripcion.Text;
                decimal costo = decimal.Parse(txtPrecio.Text);
                decimal SubTotal = decimal.Parse(txtSubTotalConduce.Text);
                decimal itbis = decimal.Parse(txtITBISConduce.Text);
                DateTime FechaConduce = dtpFechaConduce.Value;
                int Chofer = (int)cboChoferes.SelectedValue;
                int Vehiculo = (int)cboVehiculos.SelectedValue;
                int Viajes = (int)nUpDownViajes.Value;
                decimal Capacidad = nUpDownCapacidad.Value;

                if (PM.ActualizarPedidos(Pedido, Cliente, idConduce, idDetallesPedidos, NumConduce, Cantidad, Medida,
                    Producto, Descripcion, costo, SubTotal, itbis, FechaConduce, Chofer, Vehiculo, Viajes, Capacidad))
                {
                    MessageBox.Show("Se han actualizado las informaciones del pedido correctamente", "Actualizado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetCamposConduces();
                    ResetCamposPedidos();
                    ResetInfoCliente();
                    cmdBuscarPedido_Click(sender, e);


                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un conduce del listado", "Aviso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void nUpDownViajes_ValueChanged(object sender, EventArgs e)
        {

            //decimal SubTotal = PM.CalcularSubtotal(cboMedidas.SelectedIndex, nUpDownCantidad.Value, decimal.Parse(txtPrecio.Text));
            decimal NuevaCantidad = nUpDownCantidad.Value * nUpDownViajes.Value;
            decimal SubTotal = decimal.Parse(txtPrecio.Text) * NuevaCantidad;
            txtSubTotalConduce.Text = SubTotal.ToString("N");

        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (txtPedidoSeleccionado.Text != "" && txtConduceSeleccionado.Text != "")
            {
                int Pedido = int.Parse(txtPedidoSeleccionado.Text);
                int Cliente = int.Parse(txtCodigoCliente.Text);
                int idConduce = int.Parse(txtConduceSeleccionado.Text);
                int idDetallesPedidos = idConduce;

                if (PM.EliminarPedidos(Pedido, Cliente, idConduce, idDetallesPedidos))
                {
                    MessageBox.Show($"Se ha eliminado el conduce al cliente [{txtCliente.Text}] correctamente. " +
                        $"\n Pedido #: {Pedido} " +
                        $"\n Conduce #: {txtNumConduce.Text} " +
                        $"\n Descripción: {txtDescripcion.Text}", "Eliminado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetCamposConduces();
                    ResetCamposPedidos();
                    ResetInfoCliente();
                    cmdBuscarPedido_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un conduce del listado", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtCodigoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                cmdBuscarPedido_Click(sender, e);
            }
        }

        

        private void nUpDownCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                decimal SubTotal = PM.CalcularSubtotal(cboMedidas.SelectedIndex, nUpDownCantidad.Value, decimal.Parse(txtPrecio.Text));
                txtSubTotalConduce.Text = SubTotal.ToString("N");
            }

        }
    }
}
