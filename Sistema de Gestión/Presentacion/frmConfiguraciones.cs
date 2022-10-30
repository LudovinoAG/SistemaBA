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
    public partial class frmConfiguraciones : Form
    {
        ComprobantesFiscalesModel CF = new ComprobantesFiscalesModel();
        DiseñoInterface DI = new DiseñoInterface();
        Funciones FC = new Funciones();
        EntrarLogin EL = new EntrarLogin();


        public frmConfiguraciones()
        {
            InitializeComponent();
            LoadComprobantes();
            EL.ListarPerfiles(cboPerfiles);
            EL.Modo = "Insertando";
            EL.ListarEstatus(cboEstatusUsuario);
        }

        private void LoadComprobantes()
        {
            var Resultado = CF.VerComprobantes().SingleOrDefault();
            if (Resultado!=null)
            {
                txtComprobanteDesde.Text = Resultado.Comprobante_Desde.ToString();
                txtHastaComprobante.Text = Resultado.Comprobante_Hasta.ToString();
                txtProximo.Text = Resultado.Proximo_Comprobante;
                txtCantidad.Text = Resultado.Cantidad_Comprobantes.ToString();
                dtpFechaVencimiento.Value = Resultado.Fecha_Vencimiento_Comprobante;
                txtSerie.Text = Resultado.Serie;
                txtTipo.Text = Resultado.Tipo;

                if (Resultado.Estatus_Comprobante == "Activado")
                {
                    rbActivado.Checked = true;
                }
                else
                {
                    rbDesactivado.Checked = true;
                    MessageBox.Show("El rango establecido de comprobantes fiscales se ha terminado," +
                        "solo podra generar factura sin el NCF.","Comprobante Fiscal",MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }

                if (Resultado.Cantidad_Comprobantes_Usados!=0)
                {
                    for (var i = Resultado.Cantidad_Comprobantes_Usados +1; i <= Resultado.Comprobante_Hasta; i++)
                    {
                        lstComprobantes.Items.Add(txtSerie.Text + txtTipo.Text + i.ToString().PadLeft(8,'0'));
                    }
                }
                else
                {
                    for (var i = Resultado.Comprobante_Desde; i <= Resultado.Comprobante_Hasta; i++)
                    {
                        lstComprobantes.Items.Add(txtSerie.Text + txtTipo.Text + i.ToString().PadLeft(8, '0'));
                    }
                }
            }
           
        }

        private void LoadUsuarios()
        {
            EL.ListarUsuarios(dgvUsuarios);
        }


        private void rbActivado_Click(object sender, EventArgs e)
        {
            if (rbActivado.Checked == true)
            {
                lblEstatus.Text = "Activado";
            }
        }

        private void rbDesactivado_Click(object sender, EventArgs e)
        {
            if (rbDesactivado.Checked == true)
            {
                lblEstatus.Text = "Desactivado";
            }
        }

        private void txtHastaComprobante_Leave(object sender, EventArgs e)
        {
            foreach (var item in CF.CalcularCantidadComprobantes(int.Parse(txtComprobanteDesde.Text), 
                int.Parse(txtHastaComprobante.Text),txtSerie.Text,txtTipo.Text))
            {
                lstComprobantes.Items.Add(item.ToString());
            }

            txtCantidad.Text = CF.Cantidad_Comprobantes.ToString();
            txtProximo.Text = txtComprobanteDesde.Text;
        }

        private void cmdInsertar_Click(object sender, EventArgs e)
        {
            if (FC.ValidacionCampos(this.Name, gbRangoComprobantes.Controls))
            {
                CF.AgregarComprobantes(int.Parse(txtComprobanteDesde.Text), int.Parse(txtHastaComprobante.Text),
                    int.Parse(txtCantidad.Text), dtpFechaVencimiento.Text, lblEstatus.Text, txtSerie.Text,
                    txtTipo.Text);


                FC.LimpiarCampos(Controls);

            }
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

        private void tcConfiguraciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcConfiguraciones.SelectedTab == tbpUsuarios)
            {
                LoadUsuarios();
                lblMensajeConfiguracion.Text = "Complete todos los campos para insertar un nuevo usuario al sistema";
            }
            else if (tcConfiguraciones.SelectedTab == tbpComprobanteFiscal)
            {
                lblMensajeConfiguracion.Text = "Para configurar el comprobante fiscal debe introducir la información suministrada por la DGII";
            }
        }

        private void cmdInsertUser_Click(object sender, EventArgs e)
        {
            if (EL.Modo=="Insertando")
            {
                if (FC.ValidacionCampos(this.Name, tbpUsuarios.Controls))
                {
                    EL.InsertarUsuarios(txtUsuario.Text, txtClave.Text, txtEmail.Text, (int)cboPerfiles.SelectedValue, DateTime.Now);
                    FC.LimpiarCampos(tbpUsuarios.Controls);
                    LoadUsuarios();
                }
            }
            else
            {
                DialogResult Respuesta = MessageBox.Show("Actualmente se encuentra en el modo Edición, " +
                    "¿Desea cambiar al modo inserción?","Insertar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Respuesta==DialogResult.Yes)
                {
                    FC.LimpiarCampos(tbpUsuarios.Controls);
                    EL.Modo = "Insertando";
                }
            }

        }

        private void cmdInsertUser_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdInsertUser, 1);
        }

        private void cmdInsertUser_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(cmdInsertUser, 0);
        }

        private void cmdInsertUser_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdInsertUser, 2);
        }

        private void cmdGuardarUser_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdGuardarUser, 1);
        }

        private void cmdGuardarUser_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(cmdGuardarUser, 0);
        }

        private void cmdGuardarUser_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdGuardarUser, 2);
        }

        private void cmdEliminarUser_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdEliminarUser, 1);
        }

        private void cmdEliminarUser_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(cmdEliminarUser, 0);
        }

        private void cmdEliminarUser_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdEliminarUser, 2);
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EL.Modo = "Editando";
            txtClave.Text = "0";
            txtUsuario.Text = dgvUsuarios.SelectedRows[0].Cells["Usuario"].Value.ToString();
            txtEmail.Text = dgvUsuarios.SelectedRows[0].Cells["Email"].Value.ToString();
            int Opcion = 0;
            int OpcionEstatus = 0;
            if (dgvUsuarios.SelectedRows[0].Cells["Perfil"].Value.ToString() == "Administrador")
            {
                Opcion = 1;
            }
            else if (dgvUsuarios.SelectedRows[0].Cells["Perfil"].Value.ToString() == "Usuario")
            {
                Opcion = 2;
            }
            else if (dgvUsuarios.SelectedRows[0].Cells["Perfil"].Value.ToString() == "Developer")
            {
                Opcion = 3;
            }
            cboPerfiles.SelectedValue = Opcion;
            if ((int)dgvUsuarios.SelectedRows[0].Cells["Estatus"].Value==1)
            {
                OpcionEstatus = 0;
            }
            else
            {
                OpcionEstatus = 1;
            }
            cboEstatusUsuario.SelectedIndex = OpcionEstatus;

        }

        private void cmdGuardarUser_Click(object sender, EventArgs e)
        {
            if (FC.ValidacionCampos(this.Name, tbpUsuarios.Controls))
            {
                int opcionEstatus = 0;
                if (cboEstatusUsuario.SelectedIndex==0)
                {
                    opcionEstatus = 1;
                }
                else
                {
                    opcionEstatus = 0;
                }
                EL.ActualizarUsuario((int)dgvUsuarios.SelectedRows[0].Cells["ID"].Value, txtUsuario.Text, 
                    (int)cboPerfiles.SelectedValue, txtEmail.Text,opcionEstatus);
                FC.LimpiarCampos(tbpUsuarios.Controls);
                LoadUsuarios();
                EL.Modo = "Insertando";
            }
        }

        private void cmdEliminarUser_Click(object sender, EventArgs e)
        {
            if (EL.Modo!="Insertando")
            {
                EL.DesactivarUsuario((int)dgvUsuarios.SelectedRows[0].Cells["ID"].Value,
                    dgvUsuarios.SelectedRows[0].Cells["Usuario"].Value.ToString());
                FC.LimpiarCampos(tbpUsuarios.Controls);
                LoadUsuarios();
                EL.Modo = "Insertando";
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario del listado","Eliminar",MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void frmConfiguraciones_Load(object sender, EventArgs e)
        {

        }
    }
}
