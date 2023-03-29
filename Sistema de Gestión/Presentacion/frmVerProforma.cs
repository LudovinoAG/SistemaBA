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
    public partial class frmVerProforma : Form
    {
        ProformaFactura PF = new ProformaFactura();
        public frmVerProforma()
        {
            InitializeComponent();
        }

        private void cmdBuscarCliente_Click(object sender, EventArgs e)
        {
            if ((txtCodigoCliente.Text != "") && (txtCodigoCliente.TextLength==txtCodigoCliente.MaxLength))
            {
                PF.VerClienteProforma(txtCodigoCliente.Text);
                ProformaFactura.IDCliente = PF.ClienteProforma.Single().ID;
                ProformaFactura.Nombre_Cliente = PF.ClienteProforma.Single().Empresa;
                TxtRNC.Text = PF.ClienteProforma.Single().RNC;
                txtCliente.Text = PF.ClienteProforma.Single().Empresa;
                txtContactos.Text = PF.ClienteProforma.Single().NombreContacto;
                txtTelefonos.Text = PF.ClienteProforma.Single().TelefonoContactos;
            }
            else
            {
                MessageBox.Show("De indicar un codigo valido de cliente", "Buscar Cliente",
                    MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txtCodigoCliente.Focus();
            }

        }

        private void cmdBuscarPedido_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text!="")
            {
                PF.VerPedidoProforma(ProformaFactura.IDCliente, dtpFechaInicio.Value, dtpFechaFin.Value);
                dgvPedidos.DataSource = null;
                dgvPedidos.DataSource = PF.PedidoProforma.ToList();
                dgvPedidos.ClearSelection();

                //Establecer los montos
                txtSubTotal.Text = PF.PedidoProforma.ToList().Sum(x => x.SubTotal).Value.ToString("0,0.00");
                TxtDescuento.Text = PF.PedidoProforma.ToList().Sum(x => x.Descuento).Value.ToString("0,0.00");
                txtITBIS.Text = PF.PedidoProforma.ToList().Sum(x => x.ITBIS).Value.ToString("0,0.00");
                txtTotal.Text = PF.PedidoProforma.ToList().Sum(x => x.TotalPedido).Value.ToString("0,0.00");

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
        }

        private void cmdVerProforma_Click(object sender, EventArgs e)
        {
            frmVistaProforma VistaProformo= new frmVistaProforma();
            //int NumFactura = int.Parse(txtNumFactura.Text);
            //VistaRedaccion = NumFactura;
            ProformaFactura.FechaInicio = dtpFechaInicio.Value;
            ProformaFactura.FechaFin = dtpFechaFin.Value;

            frmVistaProforma.idCliente = ProformaFactura.IDCliente;
            frmVistaProforma.idPedido = ProformaFactura.IDPedido;
            frmVistaProforma.FechaInicio = ProformaFactura.FechaInicio;
            frmVistaProforma.FechaFin = ProformaFactura.FechaFin;
            VistaProformo.Show();
        }

        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPedidos.RowCount != 0)
            {
                ProformaFactura.IDPedido = (int)dgvPedidos.Rows[e.RowIndex].Cells[0].Value;
                PF.VerConduceProforma(ProformaFactura.IDCliente, ProformaFactura.IDPedido,
                    dtpFechaInicio.Value, dtpFechaFin.Value);

                dgvConduceProforma.DataSource = null;
                dgvConduceProforma.DataSource = PF.ConduceProforma.ToList();
            }
        }
    }
}
