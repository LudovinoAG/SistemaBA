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
    public partial class Facturación : Form, IFormularios
    {
        FacturacionModel FM = new FacturacionModel();
        ComprobantesFiscalesModel CF = new ComprobantesFiscalesModel();
        DiseñoInterface DI = new DiseñoInterface();
        Loading frmCargar;

        public void NuevaFecha(string fecha)
        {
            txtFechaLimitePago.Text = fecha;
        }

        public void CantidadViaje(int cantidad)
        {
            FM.CantidadChofer = cantidad;
        }

        public void DetallesViajesChofer(string PRODUCTO, int CANTIDAD, string NUMFACT,int CONDUCE, string CHOFER){}

        public Facturación()
        {
            InitializeComponent();
            LoadChoferes();
            LoadVehiculos();
            LoadMedidas();
            LoadProductosFactura();
            ActualizarVentana();
            LoadNuevoComprobanteFiscal();
        }

        private void LoadNuevoComprobanteFiscal()
        {
            var NCF = CF.CargarNuevoComprobante();
            if (CF.ModoComprobante!="Desactivado")
            {
                FM.TipoFactura = 2;
                this.lblTipoNCF.Text = "Crédito fiscal";
                txtNCF.Visible = true;
                lblTituloNCF.Visible = true;
                txtNCF.Text = NCF;
                txtNumFactura.Text = FM.CargarNuevaFactura().ToString().PadLeft(6, '0');
            }
            else
            {
                FacturaSinComprobanteFiscal();
                MessageBox.Show("El rango de comprobantes fiscales se ha terminado o vencido, " +
                    "se abrira una factura sin comprobante fiscal.","Factura Normal", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FM.AgregarProducto(int.Parse(UdCantidad.Text),(int)cboProductos.SelectedValue, cboMedida.Text,
                (int)cboMedida.SelectedValue,cboProductos.Text, txtDescripcion.Text, decimal.Parse(txtCosto.Text), 
                decimal.Parse(txtNuevoSubTotal.Text), dgvFactura);

            //Limpiar Entradas
            UdCantidad.Value = 1;
            cboMedida.SelectedIndex = 0;
            cboProductos.SelectedIndex = 0;

            FM.DESC = decimal.Parse(txtDesc.Text);
            FM.ITBIS = decimal.Parse(txtITBIS.Text);
            FM.ActualizarTotales(dgvFactura,txtSubTotal,TxtTotalGeneral, txtITBIS,CKITBIS);

        }

        private void dgvFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dgvFactura.Columns["Accion"].Index)
            {
                Bucle:
                for (int i = 0; i < dgvChoferes.Rows.Count; i++)
                {
                    if ((int)dgvFactura.Rows[e.RowIndex].Cells["IDProducto"].Value==(int)dgvChoferes.Rows[i].Cells["ID"].Value)
                    {
                        dgvChoferes.Rows.Remove(dgvChoferes.Rows[i]);
                        dgvListaChoferes.Rows.Remove(dgvListaChoferes.Rows[i]);

                        goto Bucle;
                       
                    }
                }
                dgvFactura.Rows.RemoveAt(e.RowIndex);
                FM.TotalGeneral = 0.00m;
                FM.ITBIS = 0.00m;

                FM.ActualizarTotales(dgvFactura, txtSubTotal, TxtTotalGeneral, txtITBIS, CKITBIS);
             

            }

        }

        private void cmdBuscarCliente_Click(object sender, EventArgs e)
        {
            var Resultado = FM.BuscarClienteCodigo(txtCodigoCliente.Text).SingleOrDefault();

            //Llenar los campos con el resultado
            if (!string.IsNullOrEmpty(txtCodigoCliente.Text))
            {
                if (Resultado!=null)
                {
                    txtCliente.Text = Resultado.Cliente;
                    TxtRNC.Text = Resultado.RNC;
                    txtContactos.Text = Resultado.Contactos;
                    txtTelefonos.Text = Resultado.Telefonos;
                    txtCorreo.Text = Resultado.Correo;
                    txtDirección.Text = Resultado.Dirección;
                    FM.TipoCliente = Resultado.TipoCliente;
                    FM.IDCliente = Resultado.ID_Cliente;
                }
                else
                {
                    MessageBox.Show($"No se encontro el cliente con el codigo {txtCodigoCliente.Text}", "Buscar cliente",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Debe indicar un codigo de cliente para realizar la búsqueda", "Buscar cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

     
            
        }

        private void LoadChoferes()
        {
            var Resultado = FM.EmpleadosFactura().ToList();
            
            cboChofer.DisplayMember = "Chofer";
            cboChofer.ValueMember = "ID";
            cboChofer.DataSource = Resultado;
            txtFlota.Text = Resultado.SingleOrDefault(n=> n.ID == (int)cboChofer.SelectedValue).Celular;

        }

        private void LoadVehiculos()
        {
            var Resultado = FM.VehiculosFactura().ToList();

            cboVehiculos.DisplayMember = "Descripcion";
            cboVehiculos.ValueMember = "ID";
            cboVehiculos.DataSource = Resultado;
            txtPlaca.Text = Resultado.SingleOrDefault(n => n.ID == (int)cboVehiculos.SelectedValue).Matricula;
        }

        private void LoadMedidas()
        {
            var Resultado = FM.MedidasFactura().ToList();

            cboMedida.DisplayMember = "Medida";
            cboMedida.ValueMember = "ID";
            cboMedida.DataSource = Resultado;
        }

        private void LoadProductosFactura()
        {
            var Resultado = FM.ProductosFactura().ToList();

            cboProductos.DisplayMember = "Producto";
            cboProductos.ValueMember = "ID";
            cboProductos.DataSource = Resultado;
        }

        private void cboChofer_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Resultado = FM.EmpleadosFactura().ToList();
            txtFlota.Text = Resultado.SingleOrDefault(n => n.ID == (int)cboChofer.SelectedValue).Celular;
        }

        private void cboVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Resultado = FM.VehiculosFactura().ToList();
            txtPlaca.Text = Resultado.SingleOrDefault(n => n.ID == (int)cboVehiculos.SelectedValue).Matricula;
        }

        private void cboProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Resultado = FM.ProductosFactura().ToList();

            txtDescripcion.Text = Resultado.SingleOrDefault(n => n.ID == (int)cboProductos.SelectedValue).Descripcion;
            decimal Costo = Resultado.SingleOrDefault(n => n.ID == (int)cboProductos.SelectedValue).Precio;
            decimal SubTotal = FM.CalcularSubtotal(int.Parse(UdCantidad.Text), Costo);

            txtCosto.Text = string.Format("{0:N}", Costo);
            txtNuevoSubTotal.Text = string.Format("{0:N}", SubTotal);
        }

        private void UdCantidad_Click(object sender, EventArgs e)
        {
            var Resultado = FM.ProductosFactura().ToList();
            decimal Costo = Resultado.SingleOrDefault(n => n.ID == (int)cboProductos.SelectedValue).Precio;
            decimal SubTotal = FM.CalcularSubtotal(int.Parse(UdCantidad.Text), Costo);

            txtCosto.Text = string.Format("{0:N}", Costo);
            txtNuevoSubTotal.Text = string.Format("{0:N}", SubTotal);
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
        
        private void cmdAgregarInfoChofer_Click(object sender, EventArgs e)
        {
            if (cboChofer.SelectedIndex!=0)
            {
                if (cboVehiculos.SelectedIndex!=0)
                {
                    if (dgvFactura.Rows.Count!=0)
                    {
                        if (!string.IsNullOrEmpty(txtConduce.Text) && txtConduce.Text.Length==5)
                        {
                            //CODIGO PARA AGREGAR EL CHOFER A TABLA TEMPORAL
                            frmViajesChofer VC = new frmViajesChofer();
                            VC.CantidadViajes = this;
                            VC.DetallesViajesChofer(dgvFactura.SelectedRows[0].Cells["Producto"].Value.ToString(),
                                (int)dgvFactura.SelectedRows[0].Cells["Cantidad"].Value, txtNumFactura.Text,
                                 int.Parse(txtConduce.Text), cboChofer.Text);
                            VC.ShowDialog();
                            CantidadViaje(FM.CantidadChofer);



                            int Fila = (int)dgvFactura.SelectedRows[0].Cells["IDProducto"].Value;
                            FM.Conduce = int.Parse(txtConduce.Text);
                            FM.IDChofer = (int)cboChofer.SelectedValue;
                            FM.IDProducto = (int)dgvFactura.SelectedRows[0].Cells["IDProducto"].Value;
                            FM.IDFactura = int.Parse(txtNumFactura.Text);
                            FM.IDMedida = (int)dgvFactura.SelectedRows[0].Cells["IDMedida"].Value;
                            FM.IDVehiculo = (int)cboVehiculos.SelectedValue;


                            FM.AgregarChoferFactura(dgvChoferes, Fila, FM.Conduce, FM.IDChofer, FM.IDVehiculo,
                                FM.IDProducto, FM.IDMedida, FM.IDFactura, FM.CantidadChofer);

                            int NuevaEntrada = dgvListaChoferes.Rows.Add();
                            dgvListaChoferes.Rows[NuevaEntrada].Cells["clChofer"].Value = cboChofer.Text;
                            dgvListaChoferes.Rows[NuevaEntrada].Cells["clConduce"].Value = txtConduce.Text;
                            dgvListaChoferes.Rows[NuevaEntrada].Cells["clVehiculo"].Value = cboVehiculos.Text;
                            dgvListaChoferes.Rows[NuevaEntrada].Cells["clProducto"].Value = dgvFactura.SelectedRows[0].Cells["Producto"].Value;
                            dgvListaChoferes.Rows[NuevaEntrada].Cells["clFactura"].Value = txtNumFactura.Text;
                            dgvListaChoferes.Rows[NuevaEntrada].Cells["clMedida"].Value = cboMedida.Text;
                            dgvListaChoferes.Rows[NuevaEntrada].Cells["clCantidad"].Value = dgvFactura.SelectedRows[0].Cells["Cantidad"].Value;
                            dgvListaChoferes.Rows[NuevaEntrada].Cells["clNum"].Value = NuevaEntrada + 1;
                            dgvListaChoferes.Rows[NuevaEntrada].Cells["clCantidad"].Value = FM.CantidadChofer;

                            //Agregar conduce a la descripcion del producto seleccionado
                            dgvFactura.SelectedRows[0].Cells["Descripción"].Value += ", CON.#" + txtConduce.Text;
                            FM.ResetCamposChofer(panelChofer.Controls);
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
                        MessageBox.Show("Debe agregar un producto a la factura","Aviso",
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

        private void UdCantidad_ValueChanged(object sender, EventArgs e)
        {
            UdCantidad_Click(sender, e);
        }

        private void txtDesc_Leave(object sender, EventArgs e)
        {
           
            FM.DESC = decimal.Parse(txtDesc.Text);
            FM.ITBIS = decimal.Parse(txtITBIS.Text);
            FM.ActualizarTotales(dgvFactura, txtSubTotal, TxtTotalGeneral, txtITBIS, CKITBIS);
        }

        private void txtDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                txtDesc_Leave(sender, e);
            }
        }

        private void txtITBIS_Leave(object sender, EventArgs e)
        {
            FM.DESC = decimal.Parse(txtDesc.Text);
            FM.ITBIS = decimal.Parse(txtITBIS.Text);
            FM.ActualizarTotales(dgvFactura, txtSubTotal, TxtTotalGeneral, txtITBIS, CKITBIS);
        }

        private void txtITBIS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDesc_Leave(sender, e);
            }
        }

        private void CKITBIS_CheckedChanged(object sender, EventArgs e)
        {
            txtDesc_Leave(sender, e);
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                FM.CalcularSubtotal(int.Parse(UdCantidad.Text), decimal.Parse(txtCosto.Text));
                txtNuevoSubTotal.Text = string.Format("{0:N}",FM.SubTotal);
                txtCosto.Text = string.Format("{0:N}", FM.Costo);
            }
        }

        private void txtCosto_Leave(object sender, EventArgs e)
        {
            FM.CalcularSubtotal(int.Parse(UdCantidad.Text), decimal.Parse(txtCosto.Text));
            txtNuevoSubTotal.Text = string.Format("{0:N}", FM.SubTotal);
            txtCosto.Text = string.Format("{0:N}", FM.Costo);
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
            }
        }

        private void rdbCheque_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCheque.Checked == true)
            {
                txtFechaLimitePago.Text = DateTime.Now.ToShortDateString();
            }
        }

        private void rbTransferencia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTransferencia.Checked == true)
            {
                txtFechaLimitePago.Text = DateTime.Now.ToShortDateString();
            }
        }

        private void rdbCredito_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCredito.Checked == true)
            {
                frmDialogoVencimientoFactura frmDialogo = new frmDialogoVencimientoFactura();
                frmDialogo.NuevaFecha = this;
                frmDialogo.ShowDialog();
            }
        }

        private async void cmdFacturar_Click(object sender, EventArgs e)
        {
            if (FM.ValidarCamposFactura(this.splitContainer1.Panel2.Controls,this.panelChofer.Controls,this.groupBox2.Controls))
            {
                FM.FacturaPagada = 2;
                int MetodoPago = FM.VerificarMetodoPago(groupOpt.Controls);
                string Nota = "";
                DateTime Hora = DateTime.Now.ToLocalTime();

                DialogResult NotaFactura = MessageBox.Show("¿Desea agregar un comentario a la factura?",
                    "Facturación",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (NotaFactura == DialogResult.Yes)
                {
                    frmNotaFactura frmNota = new frmNotaFactura();
                    frmNota.ShowDialog();
                    Nota = frmNotaFactura.NotaFactura;
                }

                if(FM.InsertarFactura(FM.TipoCliente, FM.TipoFactura, txtNCF.Text, FM.IDCliente, TxtRNC.Text, txtTelefonos.Text,
                    txtCliente.Text, txtCorreo.Text, txtDirección.Text,txtContactos.Text, FM.FacturaPagada, decimal.Parse(txtSubTotal.Text),
                    decimal.Parse(txtDesc.Text),decimal.Parse(txtITBIS.Text), decimal.Parse(TxtTotalGeneral.Text), 
                    MetodoPago, DateTime.Parse(txtFechaFactura.Text), DateTime.Parse(txtFechaLimitePago.Text),Hora,
                    Nota, EntrarLogin.IDActual, dgvFactura, dgvChoferes))
                {
                    if (FM.TipoFactura!=1)
                    {
                        CF.ActualizarComprobanteUsado();
                    }

                    Mostrar();
                    Task otask = new Task(Cargando);
                    otask.Start();
                    frmVistaFactura VistaFactura = new frmVistaFactura();
                    int NumFactura = int.Parse(txtNumFactura.Text);
                    VistaFactura.idFactura = NumFactura;
                    VistaFactura.Show();
                    await otask;
                    Cerrar();


                    FM.LimpiarFactura(splitContainer1.Panel2.Controls, dgvChoferes, dgvFactura, dgvListaChoferes,CKITBIS,rdbEfectivo);
                    ActualizarVentana();
                    LoadNuevoComprobanteFiscal();
                }
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
            if (frmCargar != null)
            {
                frmCargar.Close();
            }
        }

        private void Facturación_Load(object sender, EventArgs e)
        {

        }

        private void cmdVerFactura_Click(object sender, EventArgs e)
        {
            //Nueva factura en blanco con el comprobante fiscal activado
            FM.LimpiarFactura(splitContainer1.Panel2.Controls, dgvChoferes, dgvFactura, dgvListaChoferes, CKITBIS, rdbEfectivo);
            ActualizarVentana();
            LoadNuevoComprobanteFiscal();
        }

        private void cmdFacturaSinComprobante_Click(object sender, EventArgs e)
        {
            FacturaSinComprobanteFiscal();
        }

        private void FacturaSinComprobanteFiscal()
        {
            //Cargar factura en blanco sin comrpobante fiscal activado
            FM.LimpiarFactura(splitContainer1.Panel2.Controls, dgvChoferes, dgvFactura, dgvListaChoferes, CKITBIS, rdbEfectivo);
            ActualizarVentana();
            FM.TipoFactura = 1;
            this.lblTipoNCF.Text = "Consumidor final";
            txtNCF.Text = "B0000000000";
            lblTituloNCF.Visible = false;
            txtNCF.Visible = false;
            txtNumFactura.Text = FM.CargarNuevaFactura().ToString().PadLeft(6, '0');
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Cerrar ventana de facturación
            this.Close();
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

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(button5, 1);
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(button5, 0);
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(button5, 2);
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
    }
}
