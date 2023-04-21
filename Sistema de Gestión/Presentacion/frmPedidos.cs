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
    
    public partial class frmPedidos : Form
    {
        PedidosModel PM = new PedidosModel();
        DiseñoInterface DI = new DiseñoInterface();
        Funciones FC = new Funciones();
        public static decimal CapacidadTotalVendida { get; set; }
        public static decimal NuevoSubTotal { get; set; }
        public frmPedidos()
        {
            InitializeComponent();
        }

        private void LoadChoferes()
        {
            var Resultado = PM.EmpleadosFactura().ToList();

            cboChofer.DisplayMember = "Chofer";
            cboChofer.ValueMember = "ID";
            cboChofer.DataSource = Resultado;
            txtFlota.Text = Resultado.SingleOrDefault(n => n.ID == (int)cboChofer.SelectedValue).Celular;

            cboChoferAlquiler.DisplayMember = "Chofer";
            cboChoferAlquiler.ValueMember = "ID";
            cboChoferAlquiler.DataSource = Resultado;
            txtFlotaAlquiler.Text = Resultado.SingleOrDefault(n => n.ID == (int)cboChoferAlquiler.SelectedValue).Celular;

        }

        private void LoadVehiculos()
        {
            var Resultado = PM.VehiculosFactura().Where(t=>t.Capacidad!=1).ToList();
            var ResultadoAlquiler = PM.VehiculosFactura().Where(t => t.Capacidad==1).ToList();

            cboVehiculos.DisplayMember = "Descripcion";
            cboVehiculos.ValueMember = "ID";
            cboVehiculos.DataSource = Resultado;
            txtPlaca.Text = Resultado.SingleOrDefault(n => n.ID == (int)cboVehiculos.SelectedValue).Matricula;

            cboVehiculoAlquiler.DisplayMember = "Descripcion";
            cboVehiculoAlquiler.ValueMember = "ID";
            cboVehiculoAlquiler.DataSource = ResultadoAlquiler;
        }

        private void LoadMedidas()
        {
            var Resultado = PM.MedidasFactura().ToList();

            cboMedida.DisplayMember = "Medida";
            cboMedida.ValueMember = "ID";
            cboMedida.DataSource = Resultado;
        }

        private void LoadProductosFactura()
        {
            List<VW_ProductosFactura> Resultado = new List<VW_ProductosFactura>();

            if (tabControl1.SelectedTab.Name=="tpMateriales")
            {
                Resultado = PM.ProductosFactura().Where(t => t.Codigo.Substring(0, 4) != "MAQU").ToList();
            }
            else if (tabControl1.SelectedTab.Name == "tpAlquiler")
            {
                Resultado = PM.ProductosFactura().Where(t => t.Codigo.Substring(0, 4) == "MAQU").ToList();
            }

            cboProductos.DisplayMember = "Producto";
            cboProductos.ValueMember = "ID";
            cboProductos.DataSource = Resultado;

        }

        private void CargarNuevoPedido()
        {
            txtNumPedido.Text = PM.CargarNuevoPedido().ToString("000000");
            txtFechaPedido.Text = DateTime.Now.ToShortDateString();
            rdbEfectivo.Checked = true;
        }

        private void cmdBuscarCliente_Click(object sender, EventArgs e)
        {
            string CodigoCliente = $"C{txtCodigoCliente.Text.PadLeft(6, '0')}";
            var Resultado = PM.BuscarClienteCodigo(CodigoCliente).SingleOrDefault();

            //Llenar los campos con el resultado
            if (!string.IsNullOrEmpty(txtCodigoCliente.Text))
            {
                if (Resultado != null)
                {
                    txtCodigoCliente.Text = CodigoCliente;
                    txtCodigoCliente.SelectAll();
                    txtCodigoCliente.Focus();
                    txtCliente.Text = Resultado.Cliente;
                    TxtRNC.Text = Resultado.RNC;
                    txtContactos.Text = Resultado.Contactos;
                    txtTelefonos.Text = Resultado.Telefonos;
                    txtCorreo.Text = Resultado.Correo;
                    txtDirección.Text = Resultado.Dirección;
                    PM.TipoCliente = Resultado.TipoCliente;
                    PM.IDCliente = Resultado.ID_Cliente;
                }
                else
                {
                    MessageBox.Show($"No se encontro el cliente con el codigo {CodigoCliente}", "Buscar cliente",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Debe indicar un codigo de cliente para realizar la búsqueda", "Buscar cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void frmPedidos_Load(object sender, EventArgs e)
        {
            CargarNuevoPedido();
            this.LoadChoferes();
            this.LoadVehiculos();
            this.LoadMedidas();
            this.LoadProductosFactura();
           
        }

        private void cboChofer_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Resultado = PM.EmpleadosFactura().ToList();
            txtFlota.Text = Resultado.SingleOrDefault(n => n.ID == (int)cboChofer.SelectedValue).Celular;
        }

        private void cboVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Resultado = PM.VehiculosFactura().ToList();
            txtPlaca.Text = Resultado.SingleOrDefault(n => n.ID == (int)cboVehiculos.SelectedValue).Matricula;
            txtCapacidad.Text = Resultado.SingleOrDefault(n => n.ID == (int)cboVehiculos.SelectedValue).Capacidad.ToString();

        }

        private void cboProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Resultado = PM.ProductosFactura().ToList();

            txtDescripcion.Text = Resultado.SingleOrDefault(n => n.ID == (int)cboProductos.SelectedValue).Descripcion;
            decimal Costo = Resultado.SingleOrDefault(n => n.ID == (int)cboProductos.SelectedValue).Precio;
            decimal SubTotal = PM.CalcularSubtotal(cboMedida.SelectedIndex, UdCantidad.Value, Costo);

            txtCosto.Text = string.Format("{0:N}", Costo);
            txtNuevoSubTotal.Text = string.Format("{0:N}", SubTotal);
        }

        private void UdCantidad_Click(object sender, EventArgs e)
        {
            var Resultado = PM.ProductosFactura().ToList();
            decimal Costo = Resultado.SingleOrDefault(n => n.ID == (int)cboProductos.SelectedValue).Precio;
            decimal SubTotal = PM.CalcularSubtotal(cboMedida.SelectedIndex, UdCantidad.Value, Costo);

            txtCosto.Text = string.Format("{0:N}", Costo);
            txtNuevoSubTotal.Text = string.Format("{0:N}", SubTotal);
        }

        private void UdCantidad_ValueChanged(object sender, EventArgs e)
        {
            UdCantidad_Click(sender,e);
        }

        private void UdCantidad_Leave(object sender, EventArgs e)
        {
            UdCantidad_Click(sender, e);
        }

        private void UdCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                UdCantidad_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PM.AgregarProducto(UdCantidad.Value, (int)cboProductos.SelectedValue, cboMedida.Text,
               (int)cboMedida.SelectedValue, cboProductos.Text, txtDescripcion.Text, decimal.Parse(txtCosto.Text),
               decimal.Parse(txtNuevoSubTotal.Text), dgvFactura);

            //Limpiar Entradas
            UdCantidad.Value = UdCantidad.Minimum;
            cboMedida.SelectedIndex = 0;
            cboProductos.SelectedIndex = 0;

            PM.DESC = decimal.Parse(txtDesc.Text);
            PM.ITBIS = decimal.Parse(txtITBIS.Text);
            PM.ActualizarTotales(dgvFactura, txtSubTotal, TxtTotalGeneral, txtITBIS, CKITBIS);
        }

        private void cmdAgregarInfoChofer_Click(object sender, EventArgs e)
        {
            if (cboChofer.SelectedIndex != -1)
            {
                if (cboVehiculos.SelectedIndex != -1)
                {
                    if (dgvFactura.Rows.Count != 0)
                    {
                        if (!string.IsNullOrEmpty(txtConduce.Text) && txtConduce.Text.Length == 5)
                        {
                            if (!PM.ConduceExiste(int.Parse(txtConduce.Text),dgvChoferes))
                            {
                                PedidosModel.CantidadChofer = (int)UDViajes.Value;
                                PedidosModel.Placa = txtPlaca.Text;

                                int Fila = dgvFactura.SelectedRows[0].Index + 1;
                                PM.Conduce = int.Parse(txtConduce.Text);
                                PM.IDChofer = (int)cboChofer.SelectedValue;
                                PM.IDProducto = (int)dgvFactura.SelectedRows[0].Cells["IDProducto"].Value;
                                PM.IDFactura = int.Parse(txtNumPedido.Text);
                                PM.IDMedida = (int)dgvFactura.SelectedRows[0].Cells["IDMedida"].Value;
                                PM.IDVehiculo = (int)cboVehiculos.SelectedValue;
                                PM.capacidad = int.Parse(txtCapacidad.Text);
                                PM.OrometroInicio = decimal.Parse(txtOrometroInicio.Text);
                                PM.OrometroFinal = decimal.Parse(txtOrometroFinal.Text);
                                PM.FechaConduce = dtpFechaConduce.Value;

                                PM.AgregarChoferFactura(dgvChoferes, Fila, PM.Conduce, PM.IDChofer, PM.IDVehiculo,
                                    PM.IDProducto, PM.IDMedida, PM.IDFactura, PedidosModel.CantidadChofer, PM.capacidad,
                                    PedidosModel.Placa, PM.OrometroInicio, PM.OrometroFinal, PM.FechaConduce);

                                int NuevaEntrada = dgvListaChoferes.Rows.Add();
                                dgvListaChoferes.Rows[NuevaEntrada].Cells["clChofer"].Value = cboChofer.Text;
                                dgvListaChoferes.Rows[NuevaEntrada].Cells["clConduce"].Value = txtConduce.Text;
                                dgvListaChoferes.Rows[NuevaEntrada].Cells["clVehiculo"].Value = cboVehiculos.Text;
                                dgvListaChoferes.Rows[NuevaEntrada].Cells["clProducto"].Value = dgvFactura.SelectedRows[0].Cells["Producto"].Value;
                                dgvListaChoferes.Rows[NuevaEntrada].Cells["clFactura"].Value = txtNumPedido.Text;
                                dgvListaChoferes.Rows[NuevaEntrada].Cells["clMedida"].Value = cboMedida.Text;
                                dgvListaChoferes.Rows[NuevaEntrada].Cells["clCantidad"].Value = dgvFactura.SelectedRows[0].Cells["Cantidad"].Value;
                                dgvListaChoferes.Rows[NuevaEntrada].Cells["clNum"].Value = dgvFactura.SelectedRows[0].Index + 1;
                                dgvListaChoferes.Rows[NuevaEntrada].Cells["clCantidad"].Value = PedidosModel.CantidadChofer;
                                dgvListaChoferes.Rows[NuevaEntrada].Cells["Capacidad"].Value = txtCapacidad.Text;
                                dgvListaChoferes.Rows[NuevaEntrada].Cells["clsPlaca"].Value = PedidosModel.Placa;
                                dgvListaChoferes.Rows[NuevaEntrada].Cells["FechaConduce"].Value = PM.FechaConduce;

                                //Agregar conduce a la descripcion del producto seleccionado
                                dgvFactura.SelectedRows[0].Cells["Descripción"].Value += ", CON.#" + txtConduce.Text;
                                CapacidadTotalVendida += (decimal)dgvFactura.SelectedRows[0].Cells["Cantidad"].Value * UDViajes.Value;
                                NuevoSubTotal = Convert.ToDecimal(dgvFactura.SelectedRows[0].Cells["Costo"].Value) * CapacidadTotalVendida;
                                dgvFactura.SelectedRows[0].Cells["SubTotal"].Value = string.Format("{0:N}", NuevoSubTotal);
                                PM.ResetCamposChofer(tpMateriales.Controls);

                                //Actualizar totales
                                PM.DESC = decimal.Parse(txtDesc.Text);
                                PM.ITBIS = decimal.Parse(txtITBIS.Text);
                                PM.ActualizarTotales(dgvFactura, txtSubTotal, TxtTotalGeneral, txtITBIS, CKITBIS);
                            }
                            else
                            {
                                txtConduce.SelectAll();
                                txtConduce.Focus();
                            }
                           
                        }
                        else
                        {
                            MessageBox.Show("Debe indicar un numero de conduce valido", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtConduce.Focus();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Debe agregar un producto a la factura", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cboProductos.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Debe Seleccionar un Vehiculo antes de agregar.", "Agregar Vehiculo",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboVehiculos.Focus();
                }

            }
            else
            {
                MessageBox.Show("Debe Seleccionar un Chofer antes de agregar.", "Agregar Chofer",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboChofer.Focus();
            }


        }

        private void dgvFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvFactura.Columns["Accion"].Index)
            {

                for (int i = dgvFactura.Rows.Count-1; i >= 0; i--)
                {
                    for(int j = dgvChoferes.Rows.Count-1; j >= 0; j--)
                    {
                        if ((int)dgvFactura.Rows[e.RowIndex].Cells["IDProducto"].Value==(int)dgvChoferes.Rows[j].Cells["id_Producto"].Value)
                        {
                            dgvChoferes.Rows.Remove(dgvChoferes.Rows[j]);
                            dgvListaChoferes.Rows.Remove(dgvListaChoferes.Rows[j]);
                        }
                    }
                    break;
                }
                dgvFactura.Rows.RemoveAt(e.RowIndex);
                PM.TotalGeneral = 0.00m;
                PM.ITBIS = 0.00m;

                PM.ActualizarTotales(dgvFactura, txtSubTotal, TxtTotalGeneral, txtITBIS, CKITBIS);

            }
        }

        private void cmdRegistrarPedido_Click(object sender, EventArgs e)
        {
            if (PM.ValidarCamposFactura(this.Controls, tabControl1.Controls, this.groupBox2.Controls))
            {
                PM.EstatusPedido = 1;
                PedidosModel.Empresa = txtCliente.Text;
                PedidosModel.Rnc = TxtRNC.Text;
                PedidosModel.NombreContacto = txtContactos.Text;
                PedidosModel.TelContacto = txtTelefonos.Text.Substring(0,12);
                PedidosModel.Correo = txtCorreo.Text;
                PedidosModel.Direccion = txtDirección.Text;

                if (PM.InsertarPedido(PM.IDCliente,PM.IDConduce,PM.EstatusPedido,decimal.Parse(txtSubTotal.Text),
                    decimal.Parse(TxtTotalGeneral.Text),decimal.Parse(txtITBIS.Text), decimal.Parse(txtDesc.Text),
                    dgvFactura,dgvChoferes,dgvListaChoferes))
                {
                    MessageBox.Show("Se ha registrado el pedido correctamente", "Registro Pedidos", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    PM.LimpiarPedido(this.Controls, dgvChoferes, dgvFactura, dgvListaChoferes, CKITBIS);
          

                    CargarNuevoPedido();
                }
            }
        }

        private void cmdCerrarVentanaPedido_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdRegistrarPedido_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdRegistrarPedido, 1);
        }

        private void cmdRegistrarPedido_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(cmdRegistrarPedido, 0);
        }

        private void cmdRegistrarPedido_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdRegistrarPedido, 2);
        }

        private void cmdCerrarVentanaPedido_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdCerrarVentanaPedido, 1);
        }

        private void cmdCerrarVentanaPedido_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(cmdCerrarVentanaPedido, 0);
        }

        private void cmdCerrarVentanaPedido_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdCerrarVentanaPedido, 2);
        }

        private void cmdAgregarInfoChofer_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdAgregarInfoChofer, 1);
        }

        private void cmdAgregarInfoChofer_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(cmdAgregarInfoChofer, 0);
        }

        private void cmdAgregarInfoChofer_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdAgregarInfoChofer, 2);
        }

        private void txtCosto_Leave(object sender, EventArgs e)
        {
            PM.CalcularSubtotal(cboMedida.SelectedIndex, UdCantidad.Value, decimal.Parse(txtCosto.Text));
            txtNuevoSubTotal.Text = string.Format("{0:N}", PM.SubTotal);
            txtCosto.Text = string.Format("{0:N}", PM.Costo);
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PM.CalcularSubtotal(cboMedida.SelectedIndex, UdCantidad.Value, decimal.Parse(txtCosto.Text));
                txtNuevoSubTotal.Text = string.Format("{0:N}", PM.SubTotal);
                txtCosto.Text = string.Format("{0:N}", PM.Costo);
            }
        }

        private void CKITBIS_CheckedChanged(object sender, EventArgs e)
        {
            txtDesc_Leave(sender, e);
        }

        private void txtDesc_Leave(object sender, EventArgs e)
        {
            PM.DESC = decimal.Parse(txtDesc.Text);
            PM.ITBIS = decimal.Parse(txtITBIS.Text);
            PM.ActualizarTotales(dgvFactura, txtSubTotal, TxtTotalGeneral, txtITBIS, CKITBIS);
        }

        private void rdbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEfectivo.Checked == true)
            {
                PedidosModel.Condiciones = rdbEfectivo.Text;
            }
        }

        private void rdbCheque_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCheque.Checked == true)
            {
                PedidosModel.Condiciones = rdbCheque.Text;
            }
        }

        private void rbTransferencia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTransferencia.Checked == true)
            {
                PedidosModel.Condiciones = rbTransferencia.Text;
            }
        }

        private void rdbCredito_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCredito.Checked == true)
            {
                PedidosModel.Condiciones = rdbCredito.Text;
            }
        }

        private void cboChoferAlquiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Resultado = PM.EmpleadosFactura().ToList();
            txtFlotaAlquiler.Text = Resultado.SingleOrDefault(n => n.ID == (int)cboChoferAlquiler.SelectedValue).Celular;
        }

        private void cmdAgregarConduceAlquiler_Click(object sender, EventArgs e)
        {
            if (cboChoferAlquiler.SelectedIndex!=-1)
            {
                if (dgvFactura.RowCount != 0)
                {
                    if (!string.IsNullOrEmpty(txtConduceAlquiler.Text) && txtConduceAlquiler.TextLength == 5)
                    {
                        int Fila = dgvFactura.SelectedRows[0].Index + 1;
                        PM.Conduce = int.Parse(txtConduceAlquiler.Text);
                        PM.IDChofer = (int)cboChoferAlquiler.SelectedValue;
                        PM.IDProducto = (int)dgvFactura.SelectedRows[0].Cells["IDProducto"].Value;
                        PM.IDFactura = int.Parse(txtNumPedido.Text);
                        PM.IDMedida = (int)dgvFactura.SelectedRows[0].Cells["IDMedida"].Value;
                        PM.IDVehiculo = (int)cboVehiculoAlquiler.SelectedValue;
                        PM.capacidad = int.Parse(txtCapacidad.Text);
                        PM.OrometroInicio = decimal.Parse(txtOrometroInicio.Text);
                        PM.OrometroFinal = decimal.Parse(txtOrometroFinal.Text);
                        PM.FechaConduce = dtpFechaConduceAlquiler.Value;

                        PM.AgregarChoferFactura(dgvChoferes, Fila, PM.Conduce, PM.IDChofer, PM.IDVehiculo,
                            PM.IDProducto, PM.IDMedida, PM.IDFactura, 1, 0,
                            "-", PM.OrometroInicio, PM.OrometroFinal, PM.FechaConduce);

                        int NuevaEntrada = dgvListaChoferes.Rows.Add();
                        dgvListaChoferes.Rows[NuevaEntrada].Cells["clChofer"].Value = cboChoferAlquiler.Text;
                        dgvListaChoferes.Rows[NuevaEntrada].Cells["clConduce"].Value = txtConduceAlquiler.Text;
                        dgvListaChoferes.Rows[NuevaEntrada].Cells["clVehiculo"].Value = cboVehiculoAlquiler.Text;
                        dgvListaChoferes.Rows[NuevaEntrada].Cells["clProducto"].Value = dgvFactura.SelectedRows[0].Cells["Producto"].Value;
                        dgvListaChoferes.Rows[NuevaEntrada].Cells["clFactura"].Value = txtNumPedido.Text;
                        dgvListaChoferes.Rows[NuevaEntrada].Cells["clMedida"].Value = dgvFactura.SelectedRows[0].Cells["Medida"].Value;
                        dgvListaChoferes.Rows[NuevaEntrada].Cells["clCantidad"].Value = dgvFactura.SelectedRows[0].Cells["Cantidad"].Value;
                        dgvListaChoferes.Rows[NuevaEntrada].Cells["clNum"].Value = dgvFactura.SelectedRows[0].Index + 1;
                        dgvListaChoferes.Rows[NuevaEntrada].Cells["clCantidad"].Value = 0;
                        dgvListaChoferes.Rows[NuevaEntrada].Cells["Capacidad"].Value = 0;
                        dgvListaChoferes.Rows[NuevaEntrada].Cells["clsPlaca"].Value = "-";
                        dgvListaChoferes.Rows[NuevaEntrada].Cells["OrometroInicio"].Value = PM.OrometroInicio;
                        dgvListaChoferes.Rows[NuevaEntrada].Cells["OrometroFinal"].Value = PM.OrometroFinal;
                        dgvListaChoferes.Rows[NuevaEntrada].Cells["FechaConduce"].Value = PM.FechaConduce;
                        
                        //Agregar conduce a la descripcion del producto seleccionado
                        dgvFactura.SelectedRows[0].Cells["Descripción"].Value += ", CON.#" + txtConduceAlquiler.Text;
                        //decimal CapacidadTotalVendida = (decimal)dgvFactura.SelectedRows[0].Cells["Cantidad"].Value * UDViajes.Value;
                        //decimal NuevoSubTotal = Convert.ToDecimal(dgvFactura.SelectedRows[0].Cells["Costo"].Value) * CapacidadTotalVendida;
                        //dgvFactura.SelectedRows[0].Cells["SubTotal"].Value = string.Format("{0:N}", NuevoSubTotal);
                        PM.ResetCamposChofer(tpAlquiler.Controls);

                        //Actualizar totales
                        PM.DESC = decimal.Parse(txtDesc.Text);
                        PM.ITBIS = decimal.Parse(txtITBIS.Text);
                        PM.ActualizarTotales(dgvFactura, txtSubTotal, TxtTotalGeneral, txtITBIS, CKITBIS);
                    }
                    else
                    { 
                        MessageBox.Show("Debe indicar un numero de conduce valido", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtConduce.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Debe agregar un producto a la factura", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboProductos.Focus();
                }

            }
            else
            {
                MessageBox.Show("Debe Seleccionar un Chofer antes de agregar.", "Agregar Chofer",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboChofer.Focus();
            }

        }


        private void txtCodigoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                cmdBuscarCliente_Click(sender, e);
            }

            FC.SoloNumeros(e);


        }

        private void txtOrometroFinal_TextChanged(object sender, EventArgs e)
        {
            if (txtOrometroFinal.Text!="")
            {
                decimal nuevoValor = decimal.Parse(txtOrometroFinal.Text) - decimal.Parse(txtOrometroInicio.Text);

                if (nuevoValor>0)
                {
                    UdCantidad.Value = nuevoValor;
                }

                
            }
            
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage.Name=="tpAlquiler")
            {
                cboMedida.SelectedIndex = 1;
                
            }
            else if (e.TabPage.Name == "tpMateriales")
            {
                cboMedida.SelectedIndex = 0;
            }

            LoadProductosFactura();
        }

    }
}