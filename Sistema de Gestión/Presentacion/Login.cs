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
using System.Data.SqlClient;

namespace Sistema_de_Gestión
{
    public partial class FrmLogin : Form
    {
        //Iniciar instancia de la clase EntrarLogin y frmPrincipal
        EntrarLogin login = new EntrarLogin();
        frmPrincipal form = new frmPrincipal();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void cmdEntrar_Click(object sender, EventArgs e)
        {
            //Llamada al metodo Acceso y pasandole los parametros usuario y clave
            if (login.Acceso(txtUser.Text, txtClave.Text))
            {
                //Mostrar principal y ocultar login
                this.cmdEntrar.Enabled = false;
                form.Show();
                this.Hide();
            }

        }
        

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //Ocultar la ventada principal
            form.Hide();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            //Cerrar aplicación
            this.Close();
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                cmdEntrar_Click(sender, e);
            }
        }
    }
}
