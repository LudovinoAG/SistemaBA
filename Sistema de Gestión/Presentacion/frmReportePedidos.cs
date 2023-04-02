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
        RedaccionesModel RM = new RedaccionesModel();

        public frmRedaccionesClientes()
        {
            InitializeComponent();
        }

        private void cmdBuscarCliente_Click(object sender, EventArgs e)
        {
            string CodCliente = $"C{txtCodigoCliente.Text.PadLeft(6, '0')}";
            if (txtCodigoCliente.Text!="")
            {
                
                RM.VerCliendeRedaccion(CodCliente);
                if (RedaccionesModel.ClienteRedaccion.Count!=0)
                {
                    TxtRNC.Text = RedaccionesModel.ClienteRedaccion.Single().RNC;
                    txtCliente.Text = RedaccionesModel.ClienteRedaccion.Single().Empresa;
                    txtTelefonos.Text = RedaccionesModel.ClienteRedaccion.Single().TelefonoContactos;
                    txtContactos.Text = RedaccionesModel.ClienteRedaccion.Single().NombreContacto;
                    txtProyecto.Text = RedaccionesModel.ClienteRedaccion.Single().Proyecto;
                    RedaccionesModel.IDCliente = RedaccionesModel.ClienteRedaccion.Single().ID;
                }
                else
                {
                    MessageBox.Show($"No se encontro al cliente con el codigo [{CodCliente}].", "Aviso",
                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigoCliente.Focus();
                }

              
            }
            else
            {
                MessageBox.Show($"El codigo introducido {CodCliente} es invalido.", "Aviso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCodigoCliente.Focus();
            }


        }


        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvPedidos.RowCount!=0)
            {
                int PedidoSeleccionado = (int)dgvPedidos.SelectedRows[0].Cells["Num_Pedido"].Value;

                RM.VerDetallesRedaccion(RedaccionesModel.IDCliente, PedidoSeleccionado,
                    RedaccionesModel.ModoReporte, RedaccionesModel.EstatudPedido,
                    RedaccionesModel.FechaInicio, RedaccionesModel.FechaFin);


                dgvDetallesPedidos.DataSource = null;
                dgvDetallesPedidos.DataSource = RedaccionesModel.RedaccionesDetalles.ToList();
                dgvDetallesPedidos.ClearSelection();


                lblPedidoSeleccionado.Text = $"Conduces asociados al pedido #: " +
                    $"[{RedaccionesModel.IDPedido.ToString().PadLeft(6, '0')}]";

                //Formatear columnas detalles
                FormatearColumnasDetalles();
            }
          
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

            ValidarCriterios();

            VistaRedaccion.Show();
        }

        private void cmdBuscarPedido_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text!="")
            {
                ValidarCriterios();

 
                RM.VerRedaccionCliente(RedaccionesModel.IDCliente, RedaccionesModel.IDPedido,
                    RedaccionesModel.ModoReporte, cboEstatusPedidos.SelectedIndex,
                    RedaccionesModel.FechaInicio, RedaccionesModel.FechaFin);
    

                dgvPedidos.DataSource = null;
                dgvDetallesPedidos.DataSource = null;
                lblPedidoSeleccionado.Text = "Conduces asociados al pedido #:";
                dgvPedidos.DataSource = RedaccionesModel.Redacciones.ToList();
                
            }
            
            FormatearColumnasPedidos();
        }

        private void cboCriterioPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCriterioPedidos.SelectedIndex==0)
            {
                nUpDownPedidos.Enabled = false;
                RedaccionesModel.IDPedido = 0;

            }
            else
            {
                nUpDownPedidos.Enabled = true;
                RedaccionesModel.IDPedido = (int)nUpDownPedidos.Value;
            }
        }

        private void nUpDownPedidos_ValueChanged(object sender, EventArgs e)
        {
            RedaccionesModel.IDPedido = (int)nUpDownPedidos.Value;
        }

        private void cboEstatusPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {

            RedaccionesModel.EstatudPedido = cboEstatusPedidos.SelectedIndex;
          
        }

        private void cboModoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {

            RedaccionesModel.ModoReporte = cboModoReporte.SelectedText;
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
            
        }

        private void frmRedaccionesClientes_Load(object sender, EventArgs e)
        {
            LoadDefaultValue();
        }

        private void LoadDefaultValue()
        {
            RM.DefaultValueRedactions(cboCriterioPedidos, cboEstatusPedidos, cboModoReporte,
                dtpFechaInicio, dtpFechaFin, nUpDownPedidos);
        }

        private void ValidarCriterios()
        {
            RedaccionesModel.IDCliente = RedaccionesModel.ClienteRedaccion.Single().ID;

            //Establecer el valor del ID Pedido segun sea necesario
            if (cboCriterioPedidos.SelectedIndex == 0)
            {
                RedaccionesModel.IDPedido = 0;
            }
            else
            {
                RedaccionesModel.IDPedido = (int)nUpDownPedidos.Value;
            }

            RedaccionesModel.EstatudPedido = cboEstatusPedidos.SelectedIndex;
            RedaccionesModel.ModoReporte = cboModoReporte.Text;
            RedaccionesModel.FechaInicio = dtpFechaInicio.Value;
            RedaccionesModel.FechaFin = dtpFechaFin.Value;

            frmVistaRedacciones.idCliente = RedaccionesModel.IDCliente;
            frmVistaRedacciones.idPedido = RedaccionesModel.IDPedido;
            frmVistaRedacciones.EstatusPedido = RedaccionesModel.EstatudPedido;
            frmVistaRedacciones.ModoReporte = RedaccionesModel.ModoReporte;
            frmVistaRedacciones.FechaInicio = RedaccionesModel.FechaInicio;
            frmVistaRedacciones.FechaFin = RedaccionesModel.FechaFin;


        }
    }
}