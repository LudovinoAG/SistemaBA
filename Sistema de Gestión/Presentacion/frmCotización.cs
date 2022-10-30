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

        private void frmCotización_Load(object sender, EventArgs e)
        {
            this.LoadMedidas();
            this.LoadProductosFactura();
            this.txtNumCotizacion.Text = CT.CargarNuevaCotizacion().ToString().PadLeft(6, '0');
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

        private void cboProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Resultado = FM.ProductosFactura().ToList();

            txtDescripcion.Text = Resultado.SingleOrDefault(n => n.ID == (int)cboProductos.SelectedValue).Descripcion;
            decimal Costo = Resultado.SingleOrDefault(n => n.ID == (int)cboProductos.SelectedValue).Precio;
            decimal SubTotal = FM.CalcularSubtotal(int.Parse(UdCantidad.Text), Costo);

            txtCosto.Text = string.Format("{0:N}", Costo);
            txtNuevoSubTotal.Text = string.Format("{0:N}", SubTotal);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CT.AgregarProductoCotizacion(int.Parse(UdCantidad.Text), (int)cboProductos.SelectedValue, cboMedida.Text,
            (int)cboMedida.SelectedValue, cboProductos.Text, txtDescripcion.Text, decimal.Parse(txtCosto.Text),
            decimal.Parse(txtNuevoSubTotal.Text), dgvCotizacion);

            //Limpiar Entradas
            UdCantidad.Value = 1;
            cboMedida.SelectedIndex = 0;
            cboProductos.SelectedIndex = 0;

            FM.DESC = decimal.Parse(txtDesc.Text);
            FM.ITBIS = decimal.Parse(txtITBIS.Text);
            FM.ActualizarTotales(dgvCotizacion, txtSubTotal, TxtTotalGeneral, txtITBIS, CKITBIS);
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

        private void UdCantidad_ValueChanged(object sender, EventArgs e)
        {
            UdCantidad_Click(sender, e);
        }

        private void txtDesc_Leave(object sender, EventArgs e)
        {
            FM.DESC = decimal.Parse(txtDesc.Text);
            FM.ITBIS = decimal.Parse(txtITBIS.Text);
            FM.ActualizarTotales(dgvCotizacion, txtSubTotal, TxtTotalGeneral, txtITBIS, CKITBIS);
        }

        private void txtDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDesc_Leave(sender, e);
            }
        }

        private void txtITBIS_Leave(object sender, EventArgs e)
        {
            FM.DESC = decimal.Parse(txtDesc.Text);
            FM.ITBIS = decimal.Parse(txtITBIS.Text);
            FM.ActualizarTotales(dgvCotizacion, txtSubTotal, TxtTotalGeneral, txtITBIS, CKITBIS);
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
            if (e.KeyChar == 13)
            {
                FM.CalcularSubtotal(int.Parse(UdCantidad.Text), decimal.Parse(txtCosto.Text));
                txtNuevoSubTotal.Text = string.Format("{0:N}", FM.SubTotal);
                txtCosto.Text = string.Format("{0:N}", FM.Costo);
            }
        }

        private void txtCosto_Leave(object sender, EventArgs e)
        {
            FM.CalcularSubtotal(int.Parse(UdCantidad.Text), decimal.Parse(txtCosto.Text));
            txtNuevoSubTotal.Text = string.Format("{0:N}", FM.SubTotal);
            txtCosto.Text = string.Format("{0:N}", FM.Costo);
        }

        private void cmdBuscarCliente_Click(object sender, EventArgs e)
        {
            var Resultado = FM.BuscarClienteCodigo(txtCodigoCliente.Text).SingleOrDefault();

            //Llenar los campos con el resultado
            if (!string.IsNullOrEmpty(txtCodigoCliente.Text))
            {
                if (Resultado != null)
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

        private void dgvCotizacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCotizacion.Columns["Accion"].Index)
            {
          
                dgvCotizacion.Rows.RemoveAt(e.RowIndex);
                FM.TotalGeneral = 0.00m;
                FM.ITBIS = 0.00m;

                FM.ActualizarTotales(dgvCotizacion, txtSubTotal, TxtTotalGeneral, txtITBIS, CKITBIS);


            }
        }

        private async void cmdRegistrar_Click(object sender, EventArgs e)
        {

                DateTime Hora =  DateTime.Now.ToLocalTime();
                DateTime Fecha = DateTime.Now.Date;

            if (CT.InsertarCotizacion(FM.IDCliente, decimal.Parse(txtDesc.Text), decimal.Parse(txtSubTotal.Text),
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
