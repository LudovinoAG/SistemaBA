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
    public partial class frmCambiarClave : Form
    {
        EntrarLogin session = new EntrarLogin();
        Funciones FC = new Funciones();
        DiseñoInterface DI = new DiseñoInterface();
        public frmCambiarClave()
        {
            InitializeComponent();
        }

        private void frmCambiarClave_Load(object sender, EventArgs e)
        {
            lblUser.Text = $"Usuario actual: {EntrarLogin.UsuarioActual}";
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (FC.ValidacionCampos(this.Name, Controls))
            {
                if (txtNuevaClave.Text == txtConfirmarClave.Text)
                {
                    if (session.CambiarClave(EntrarLogin.IDActual, txtClaveActual.Text, txtNuevaClave.Text) == 1)
                    {
                        MessageBox.Show("Ha cambiado su contraseña correctamente", "Cambio de Contraseña",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("La clave actual no es la correcta", "Cambio de Contraseña",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("La confirmación de la clave no coincide", "Cambio de Contraseña",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void cmdGuardar_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdGuardarClave, 1);
        }

        private void cmdGuardar_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(cmdGuardarClave, 0);
        }

        private void cmdGuardar_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdGuardarClave, 2);
        }
    }
}
