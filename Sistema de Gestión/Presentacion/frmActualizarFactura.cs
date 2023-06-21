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
        public int NumFactura { get; set; }
        public DateTime FechaFactura { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public frmActualizarFactura()
        {
            InitializeComponent();
        }

        private void frmActualizarFactura_Load(object sender, EventArgs e)
        {
            lblNumFactura.Text = NumFactura.ToString();
            dtpFechaFactura.Value = FechaFactura;
            dtpFechaVencimiento.Value = FechaVencimiento;
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
