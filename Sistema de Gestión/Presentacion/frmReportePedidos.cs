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
    public partial class frmRedaccionesClientes : Form
    {
        PedidosModel PM = new PedidosModel();
        RedaccionesModel RM = new RedaccionesModel();

        public frmRedaccionesClientes()
        {
            InitializeComponent();
        }

        private void cmdBuscarCliente_Click(object sender, EventArgs e)
        {
            var Cliente = PM.BuscarClienteCodigo(txtCodigoCliente.Text).SingleOrDefault();
            if (Cliente!=null)
            {
                TxtRNC.Text = Cliente.RNC;
                txtTelefonos.Text = Cliente.Telefonos;
                txtDirección.Text = Cliente.Dirección;
                txtCliente.Text = Cliente.Cliente;
                txtContactos.Text = Cliente.Contactos;
                txtProyecto.Text = Cliente.Proyecto;
                RedaccionesModel.IDCliente = Cliente.ID_Cliente;
            }
            else
            {
                MessageBox.Show($"No se encontro el cliente {txtCodigoCliente.Text}", "Buscar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void LoadPedidosCliente(int IDCliente)
        {
            dgvPedidos.DataSource = RM.VerRedaccionCliente(IDCliente);
        }

        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RedaccionesModel.IDPedido = (int)dgvPedidos.SelectedRows[0].Cells["Num_Pedido"].Value;
            dgvDetallesPedidos.DataSource = null;
            dgvDetallesPedidos.DataSource = RM.VerDetallesRedaccion(RedaccionesModel.IDPedido);

            dgvConducePedidos.DataSource = null;
            dgvConducePedidos.DataSource = RM.VerConducesPedidos(RedaccionesModel.IDPedido);

            lblPedidoSeleccionado.Text = $"Detalles del pedido: [#{RedaccionesModel.IDPedido.ToString().PadLeft(6, '0')}]" +
                $" para el cliente: {dgvPedidos.SelectedRows[0].Cells["Empresa"].Value}";

            //Formatear columnas detalles
            FormatearColumnasDetalles();
        }

        private void cmdBuscarPedido_Click(object sender, EventArgs e)
        {
            LoadPedidosCliente(RedaccionesModel.IDCliente);
            FormatearColumnasPedidos();

        }


        private void FormatearColumnasPedidos()
        {
            dgvPedidos.Columns["Sub_Total"].DefaultCellStyle.Format = "C2";
            dgvPedidos.Columns["ITBIS"].DefaultCellStyle.Format = "C2";
            dgvPedidos.Columns["Descuento"].DefaultCellStyle.Format = "C2";
            dgvPedidos.Columns["TotalPedido"].DefaultCellStyle.Format = "C2";
        }

        private void FormatearColumnasDetalles()
        {
            dgvDetallesPedidos.Columns["Precio"].DefaultCellStyle.Format = "C2";
            dgvDetallesPedidos.Columns["SubTotal"].DefaultCellStyle.Format = "C2";
        }

        private void cmdVerRedaccion_Click(object sender, EventArgs e)
        {
            frmVistaRedacciones VistaRedaccion = new frmVistaRedacciones();
            //int NumFactura = int.Parse(txtNumFactura.Text);
            //VistaRedaccion = NumFactura;
            VistaRedaccion.Show();
        }
    }
}