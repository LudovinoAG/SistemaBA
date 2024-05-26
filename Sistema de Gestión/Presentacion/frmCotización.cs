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
        Cotizaciones CT = new Cotizaciones();
        PedidosModel PM = new PedidosModel();
        LoadingCotizacion frmCargar;
        DiseñoInterface DI = new DiseñoInterface();
        public frmCotización()
        {
            InitializeComponent();
            CargarMedidas();
            CargarProductos();
            Cotizaciones.ITBISCotizacion = 0.18;

        }

      
        private async void cmdRegistrar_Click(object sender, EventArgs e)
        {

                DateTime Hora =  DateTime.Now.ToLocalTime();
                DateTime Fecha = DateTime.Now;

            if (CT.InsertarCotizacion(Cotizaciones.IDCliente, double.Parse(txtDesc.Text), double.Parse(txtSubTotal.Text),
                double.Parse(txtITBIS.Text), double.Parse(TxtTotalGeneral.Text), Fecha, Hora, EntrarLogin.IDActual,
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

        private void cmdBuscarCliente_Click(object sender, EventArgs e)
        {
            Task Clientes = BuscarCliente(txtCodigoCliente.Text);

                cmdBuscarCliente.Enabled = false;
                txtCodigoCliente.Text = "Buscando...";

            
        }

        private async Task BuscarCliente(string CodCliente)
        {
            await Task.Run(() =>
            {
                string NewCode = $"C{CodCliente.ToString().PadLeft(6, '0')}";
                CT.SPBuscarCliente(NewCode);

            });
            if (CT.BuscarCliente.Count!=0)
            {
                TxtRNC.Text = CT.BuscarCliente.SingleOrDefault().RNC;
                txtCliente.Text = CT.BuscarCliente.SingleOrDefault().Cliente;
                txtCorreo.Text = CT.BuscarCliente.SingleOrDefault().Correo;
                txtDirección.Text = CT.BuscarCliente.SingleOrDefault().Dirección;
                txtTelefonos.Text = CT.BuscarCliente.SingleOrDefault().Telefonos;
                txtContactos.Text = CT.BuscarCliente.SingleOrDefault().Contactos;
                txtCodigoCliente.Text = CT.BuscarCliente.SingleOrDefault().ID_Cliente.ToString().PadLeft(6, '0');
                cmdBuscarCliente.Enabled = true;
            }
            else
            {
                txtCodigoCliente.Text = CodCliente;
                txtCodigoCliente.Focus();
                cmdBuscarCliente.Enabled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CT.AgregarProductoCotizacion((int)UdCantidad.Value, (int)cboProductos.SelectedValue, cboMedida.Text,
                (int)cboMedida.SelectedValue, cboProductos.Text, txtDescripcion.Text, decimal.Parse(txtCosto.Text),
                decimal.Parse(txtNuevoSubTotal.Text), dgvCotizacion);
            //Sumar SubTotalGeneral Cotizacion
            CalcularTotalGeneral(dgvCotizacion);
            //Borrar los valores de los campos
            ResetCamposCotizacion();
        }
        
        private void ResetCamposCotizacion()
        {
            UdCantidad.Value = 1;
            cboProductos.SelectedIndex = 0;
            cboMedida.SelectedIndex = 0;
            cboProductos.SelectedIndex = 0;


        }

        private void CargarMedidas()
        {
            CT.BuscarMedidas();
            cboMedida.ValueMember = "ID";
            cboMedida.DisplayMember = "Medida";
            cboMedida.DataSource = CT.LoadMedidas.ToList();
        }

        private void CargarProductos()
        {
            CT.BuscarProductos();
            cboProductos.ValueMember = "ID";
            cboProductos.DisplayMember = "Producto";
            cboProductos.DataSource = CT.LoadProductos.OrderBy(t=> t.Producto).ToList();
        }

        private void CalcularSubTotal()
        {
            decimal SubTotal = (decimal.Parse(txtCosto.Text) * decimal.Parse(UdCantidad.Value.ToString()));
            txtNuevoSubTotal.Text = SubTotal.ToString("N");
        }

        private void cboProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtDescripcion.Text = CT.LoadProductos.SingleOrDefault(n => n.ID == (int)cboProductos.SelectedValue).Descripcion;
            decimal Costo = CT.LoadProductos.SingleOrDefault(n => n.ID == (int)cboProductos.SelectedValue).Precio;
            decimal SubTotal = PM.CalcularSubtotal(cboMedida.SelectedIndex, UdCantidad.Value, Costo);

            txtCosto.Text = string.Format("{0:N}", Costo);
            txtNuevoSubTotal.Text = string.Format("{0:N}", SubTotal);
        }

        private void UdCantidad_ValueChanged(object sender, EventArgs e)
        {
            CalcularSubTotal();
        }

        private void CKITBIS_CheckedChanged(object sender, EventArgs e)
        {
            if (CKITBIS.Checked)
            {
                Cotizaciones.ITBISCotizacion = 0.18;
               
            }
            else
            {
                Cotizaciones.ITBISCotizacion = 0;
                txtITBIS.Text = "0.00";
            }

            CalcularTotalGeneral(dgvCotizacion);
        }

        private void dgvCotizacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCotizacion.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {

                dgvCotizacion.Rows.RemoveAt(e.RowIndex);
                CalcularTotalGeneral(dgvCotizacion);
            }
        }

        private void CalcularTotalGeneral(DataGridView dgvCotizacion)
        {
            double ITBIS = 0;
            Cotizaciones.SubTotalCotizacion = 0;
            if (dgvCotizacion.Rows.Count!=0)
            {
                for (int i = 0; i < dgvCotizacion.Rows.Count; i++)
                {
                    Cotizaciones.SubTotalCotizacion += double.Parse(dgvCotizacion.Rows[i].Cells[7].Value.ToString());
                }

                ITBIS = (Cotizaciones.SubTotalCotizacion * Cotizaciones.ITBISCotizacion);
                Cotizaciones.TotalGeneralCotizacion = (Cotizaciones.SubTotalCotizacion - double.Parse(txtDesc.Text)) + ITBIS;
            }
            else
            {
                Cotizaciones.SubTotalCotizacion = 0;
                Cotizaciones.TotalGeneralCotizacion = 0;

            }

            txtITBIS.Text = ITBIS.ToString("N");
            txtSubTotal.Text = Cotizaciones.SubTotalCotizacion.ToString("N");
            TxtTotalGeneral.Text = Cotizaciones.TotalGeneralCotizacion.ToString("N");

        }

        private void frmCotización_Load(object sender, EventArgs e)
        {
            txtNumCotizacion.Text = CT.CargarNuevaCotizacion().ToString().PadLeft(6, '0');
        }
    }
}
