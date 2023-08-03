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
    public partial class frmActualizarFactura : Form
    {
        FacturacionModel FM = new FacturacionModel();
        PedidosModel PM = new PedidosModel();
        Funciones FC = new Funciones();
        public int NumFactura { get; set; }

        public int ID { get; set; }
        public string NCF { get; set; }
        public string TipoFactura { get; set; }
        public string EstatusFactura { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal ITBIS { get; set; }
        public decimal Total { get; set; }
        public decimal MontoPagado { get; set; }
        public decimal MontoPendiente { get; set; }
        public string NotaFactura { get; set; }
        public string Cliente { get; set; }

        public DateTime FechaFactura { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public frmActualizarFactura()
        {
            InitializeComponent();
            LoadTipoFactura();
            LoadEstatusFactura();
            LoadMedidas();
            LoadChofer();
            LoadProductos();
            LoadVehiculos();
            
            
        }

        private void frmActualizarFactura_Load(object sender, EventArgs e)
        {
            /*lblNumFactura.Text = NumFactura.ToString();
            dtpFechaFactura.Value = FechaFactura;
            dtpFechaVencimiento.Value = FechaVencimiento;*/
            LoadInfoFactura();
            dgvDetallesFactura.DataSource = FM.VerDetallesFactura(NumFactura);
            dgvConduceFactura.DataSource = FM.VerDetallesConduceFactura(NumFactura).ToList();
            FormatColums(dgvConduceFactura.Columns);
            FormatColums(dgvDetallesFactura.Columns);
            ShowInfoFactura();
        }

        private void FormatColums(DataGridViewColumnCollection dataGridView)
        {
            dataGridView["SubTotal"].DefaultCellStyle.Format = "N";
            dataGridView["Precio"].DefaultCellStyle.Format = "N";
        }
        

        private void LoadInfoFactura()
        {
            int POS;

            lblNumFactura.Text = NumFactura.ToString();

            POS = cboTipoFactura.FindStringExact(TipoFactura);
            cboTipoFactura.SelectedIndex = POS;

            txtNCF.Text = NCF;
            txtCliente.Text = Cliente;
            txtClienteID.Text = ID.ToString();

            POS = cboEstatusFactura.FindStringExact(EstatusFactura);
            cboEstatusFactura.SelectedIndex = POS;

            txtSubTotal.Text = SubTotal.ToString("N");
            txtDescuento.Text = Descuento.ToString("N");
            txtITBIS.Text = ITBIS.ToString("N");
            txtTotal.Text = Total.ToString("N");

            txtMontoPagado.Text = MontoPagado.ToString("N");
            txtMontoPendiente.Text = MontoPendiente.ToString("N");
            dtpFechaFactura.Value = FechaFactura;
            dtpFechaVencimiento.Value = FechaVencimiento;
            txtNota.Text = NotaFactura.ToString();

            

        }

        private void LoadTipoFactura()
        {
            cboTipoFactura.DisplayMember = "Tipo";
            cboTipoFactura.ValueMember = "ID";
            cboTipoFactura.DataSource = FM.ListarTipoFactura();
        }

        private void LoadEstatusFactura()
        {
            cboEstatusFactura.DisplayMember = "Estatus";
            cboEstatusFactura.ValueMember = "ID";
            cboEstatusFactura.DataSource = FM.ListarEstatusFactura();
        }

        private void LoadMedidas()
        {
            cboMedidas.DisplayMember = "Medida";
            cboMedidas.ValueMember = "ID";
            cboMedidas.DataSource = PM.MedidasFactura();
        }

        private void LoadChofer()
        {
            cboChoferes.DisplayMember = "Chofer";
            cboChoferes.ValueMember = "ID";
            cboChoferes.DataSource = PM.EmpleadosFactura();
        }

        private void LoadProductos()
        {
            cboProducto.DisplayMember = "Producto";
            cboProducto.ValueMember = "ID";
            cboProducto.DataSource = PM.ProductosFactura();
        }

        private void LoadVehiculos()
        {
            cboVehiculos.DisplayMember = "Descripcion";
            cboVehiculos.ValueMember = "ID";
            cboVehiculos.DataSource = PM.VehiculosFactura();
        }


        private void cmdAplicar_Click(object sender, EventArgs e)
        {
            bool FacturaActualizada = FM.ActualizarFactura(int.Parse(lblNumFactura.Text),(int)cboTipoFactura.SelectedValue,txtNCF.Text, (int)cboEstatusFactura.SelectedValue,
                int.Parse(txtClienteID.Text), decimal.Parse(txtSubTotal.Text), decimal.Parse(txtDescuento.Text), decimal.Parse(txtITBIS.Text), decimal.Parse(txtTotal.Text),
                decimal.Parse(txtMontoPagado.Text), dtpFechaFactura.Value, dtpFechaVencimiento.Value,txtNota.Text,int.Parse(txtConduce.Text),cboChoferes.Text,
                cboVehiculos.Text,txtPlaca.Text,nupCapacidad.Value,cboProducto.Text,txtDescripcion.Text,NupCantidad.Value,cboMedidas.Text,decimal.Parse(txtPrecio.Text),
                decimal.Parse(txtSubTotalConduce.Text),decimal.Parse(txtITBISConduce.Text),(int)UpDoViajes.Value);
            if (FacturaActualizada)
            {
                MessageBox.Show($"La factura # {NumFactura} del cliente {txtCliente.Text} se ha modificado correctamente con la nueva información.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }


        private void ShowInfoFactura()
        {
            txtConduce.Text = dgvConduceFactura.SelectedRows[0].Cells["Conduce"].Value.ToString();

            int POS = cboChoferes.FindStringExact(dgvConduceFactura.SelectedRows[0].Cells["Chofer"].Value.ToString());
            cboChoferes.SelectedIndex = POS;

            POS = cboVehiculos.FindStringExact(dgvConduceFactura.SelectedRows[0].Cells["Vehiculo"].Value.ToString());
            cboVehiculos.SelectedIndex = POS;

            txtPlaca.Text = dgvConduceFactura.SelectedRows[0].Cells["Placa"].Value.ToString();
            nupCapacidad.Value = (decimal)dgvConduceFactura.SelectedRows[0].Cells["Capacidad"].Value;

            POS = cboProducto.FindStringExact(dgvConduceFactura.SelectedRows[0].Cells["Producto"].Value.ToString());
            cboProducto.SelectedIndex = POS;

            txtDescripcion.Text = dgvConduceFactura.SelectedRows[0].Cells["Descripcion"].Value.ToString();
            NupCantidad.Value = (decimal)dgvConduceFactura.SelectedRows[0].Cells["Cantidad"].Value;

            UpDoViajes.Value = (int)dgvConduceFactura.SelectedRows[0].Cells["Viajes"].Value;

            POS = cboMedidas.FindStringExact(dgvConduceFactura.SelectedRows[0].Cells["Medidas"].Value.ToString());
            cboMedidas.SelectedIndex = POS;

            decimal Precio = (decimal)dgvConduceFactura.SelectedRows[0].Cells["Precio"].Value;
            txtPrecio.Text = Precio.ToString("N");

            decimal Subtotal = (decimal)dgvConduceFactura.SelectedRows[0].Cells["SubTotal"].Value;
            txtSubTotalConduce.Text = Subtotal.ToString("N");

            decimal ITBIS = (decimal)dgvConduceFactura.SelectedRows[0].Cells["ITBIS"].Value;
            txtITBISConduce.Text = ITBIS.ToString("N");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtClienteID.Text != "" && txtClienteID.Text !="0")
            {
                string Codigo = $"C{txtClienteID.Text.PadLeft(6, '0')}";
                var Cliente = PM.BuscarClienteCodigo(Codigo).Single();
                txtCliente.Text = Cliente.Cliente;
                txtClienteID.Text = Cliente.ID_Cliente.ToString();
            }
            else
            {
                MessageBox.Show("Debe indicar un codigo valido de cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtClienteID_KeyPress(object sender, KeyPressEventArgs e)
        {
            FC.SoloNumeros(e);
        }

        private void dgvConduceFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConduceFactura.RowCount != -1)
            {
                ShowInfoFactura();

            }
        }

        private void CmdEliminar_Click(object sender, EventArgs e)
        {

            if ((lblNumFactura.Text!="" && txtClienteID.Text!="") && 
                (int.Parse(lblNumFactura.Text) != 0 && int.Parse(txtClienteID.Text) != 0))
            {
                FM.CambiarEstadoPedido(int.Parse(txtClienteID.Text), 1, int.Parse(lblNumFactura.Text));

                if (FM.EliminarFactura(int.Parse(lblNumFactura.Text)))
                {
                    MessageBox.Show($"La factura NO. [{lblNumFactura.Text}] del cliente [{txtCliente.Text}] fue eliminada correctamente.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                this.Close();
            }

           
        }
    }
}
