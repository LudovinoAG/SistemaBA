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
        public int NumFactura { get; set; }
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
            FormatColums(dgvDetallesFactura.Columns);
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
            bool FacturaActualizada = FM.ActualizarFactura(int.Parse(lblNumFactura.Text), dtpFechaFactura.Value, dtpFechaVencimiento.Value);
            if (FacturaActualizada)
            {
                MessageBox.Show($"La factura Num.{NumFactura} se ha modificado con la nueva información.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
