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
    public partial class frmViajesChofer : Form, IFormularios
    {
        DiseñoInterface DI = new DiseñoInterface();
        public IFormularios CantidadViajes { get; set; }

        public void DetallesViajesChofer(string PRODUCTO, int CANTIDAD, string NUMFACT, 
            int CONDUCE, string CHOFER)
        {
            lblProducto.Text = PRODUCTO;
            lblCantidad.Text = CANTIDAD.ToString();
            lblFactura.Text = NUMFACT;
            lblConduce.Text = CONDUCE.ToString();
            lblChofer.Text = CHOFER;
        }
        void IFormularios.NuevaFecha(string fecha)
        {
            throw new NotImplementedException();
        }

        void IFormularios.CantidadViaje(int cantidad)
        {
            throw new NotImplementedException();
        }
        public frmViajesChofer()
        {
            InitializeComponent();
        }


        private void cmdInsertar_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdInsertar, 1);
        }

        private void cmdInsertar_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(cmdInsertar, 0);
        }

        private void cmdInsertar_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdInsertar, 2);
        }

        private void cmdInsertar_Click(object sender, EventArgs e)
        {
            CantidadViajes.CantidadViaje((int)UDCantidadViajes.Value);
            this.Close();
        }
    }
}
