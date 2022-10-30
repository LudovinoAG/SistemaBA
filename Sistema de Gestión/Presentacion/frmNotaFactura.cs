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
    public partial class frmNotaFactura : Form
    {
        DiseñoInterface DI = new DiseñoInterface();

        public static string NotaFactura { get; set; }


        public frmNotaFactura()
        {
            InitializeComponent();
        }

        private void cmdAgregarComentario_Click(object sender, EventArgs e)
        {
            NotaFactura = txtNota.Text;
            this.Close();
        }

        private void cmdAgregarComentario_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdAgregarComentario, 1);
        }

        private void cmdAgregarComentario_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(cmdAgregarComentario, 0);
        }

        private void cmdAgregarComentario_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdAgregarComentario, 2);
        }

        private void txtNota_TextChanged(object sender, EventArgs e)
        {
            lblLimite.Text = $"Caracteres introducidos {txtNota.TextLength} de {txtNota.MaxLength} permitidos";
        }
    }
}
