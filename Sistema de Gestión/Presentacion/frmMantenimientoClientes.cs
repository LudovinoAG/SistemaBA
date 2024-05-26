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
    public partial class frmMantenimientoClientes : Form
    {
        Clientes Client = new Clientes();
        Funciones FC = new Funciones();
        DiseñoInterface DI = new DiseñoInterface();

        public frmMantenimientoClientes()
        {
            InitializeComponent();
            Client.LoadFiltros(cboFiltrar);
            Client.CargarCantidadVista(cboViewRecord);
            LoadClientes("Ninguno", "", 5);
            Client.Modo = "Insertando";
            Client.ListarTipoClientes(cboTipoClientes);
            Client.ListarCiudades(cboCiudades);

        }

        private void LoadClientes(string Filtro, string ValorBuscar, int Limite) 
        {
            Client.ListarClientes(Filtro, ValorBuscar, dgvClientes, Limite);
            lblTotalClientes.Text = "Total Clientes: " + Client.TotalClientes.ToString();
        }

        private void LoadClientes(string Filtro, string ValorBuscar)
        {
            Client.ListarClientes(Filtro, ValorBuscar, dgvClientes, 5);
            lblTotalClientes.Text = "Total Clientes: " + Client.TotalClientes.ToString();
        }

        private void cmdInsertar_Click(object sender, EventArgs e)
        {
            if (Client.Modo == "Insertando")
            {
                if (FC.ValidacionCampos(this.Name, Controls))
                {

                    //Insertar los productos
                    if(Client.InsertarClientes(txtEmpresa.Text, txtProyecto.Text, txtRNC.Text, txtCedula.Text, 
                        txtPrimerNombre.Text,txtSegundoNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text, 
                        cboTipoClientes.SelectedIndex,txtTelefonoPrincipal.Text, int.Parse(txtExtension.Text), 
                        txtTelefonoSecundario.Text, txtCalle.Text, int.Parse(txtNumero.Text),txtPuntoReferencia.Text, 
                        cboCiudades.SelectedIndex, int.Parse(txtZipCode.Text), txtCorreo.Text, txtWeb.Text,
                        txtObservacion.Text))
                    {
                        //Limpiar y resetear los campos de formulario
                        FC.LimpiarCampos(Controls);
                        ResetFields();

                        //Actualizar listado de clientes
                        LoadClientes(cboFiltrar.Text, txtBuscar.Text, int.Parse(cboViewRecord.Text));
                        Client.Modo = FC.Modo;
                    }

                   
                }
            }
            else
            {
                var resp = MessageBox.Show("Se encuentra actualmente en el modo de edición \n" +
                    "¿Desea limpiar los campos y cambiar al modo de Inserción?", "Aviso",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resp == DialogResult.Yes)
                {
                    FC.LimpiarCampos(Controls);
                    Client.Modo = "Insertando";
                }
            }

        }

        private void MostrarEdicion(DataGridViewSelectedRowCollection dgvClientes)
        {
            txtEmpresa.Text = dgvClientes[0].Cells["Empresa"].Value.ToString();
            txtProyecto.Text = dgvClientes[0].Cells["Proyecto"].Value.ToString();
            txtRNC.Text = dgvClientes[0].Cells["RNC"].Value.ToString();
            txtCedula.Text = dgvClientes[0].Cells["Cedula"].Value.ToString();
            txtPrimerNombre.Text = dgvClientes[0].Cells["Primer_Nombre"].Value.ToString();
            txtSegundoNombre.Text = dgvClientes[0].Cells["Segundo_Nombre"].Value.ToString();
            txtPrimerApellido.Text = dgvClientes[0].Cells["Primer_Apellido"].Value.ToString();
            txtSegundoApellido.Text = dgvClientes[0].Cells["Segundo_Apellido"].Value.ToString();
            cboTipoClientes.SelectedItem = dgvClientes[0].Cells["Tipo_Cliente"].Value.ToString();
            txtTelefonoPrincipal.Text = dgvClientes[0].Cells["Tel_Principal"].Value.ToString();
            txtExtension.Text = dgvClientes[0].Cells["Extensión"].Value.ToString();
            txtTelefonoSecundario.Text = dgvClientes[0].Cells["Tel_Secundario"].Value.ToString();
            txtCalle.Text = dgvClientes[0].Cells["Calle"].Value.ToString();
            txtNumero.Text = dgvClientes[0].Cells["Numero"].Value.ToString();
            txtPuntoReferencia.Text = dgvClientes[0].Cells["Punto_Referencia"].Value.ToString();
            cboCiudades.SelectedItem = dgvClientes[0].Cells["Ciudad"].Value.ToString();
            txtZipCode.Text = dgvClientes[0].Cells["Codigo_Postal"].Value.ToString();
            txtCorreo.Text = dgvClientes[0].Cells["Correo"].Value.ToString();
            txtWeb.Text = dgvClientes[0].Cells["Web"].Value.ToString();
            txtObservacion.Text = dgvClientes[0].Cells["Observación"].Value.ToString();

            LblID.Text = dgvClientes[0].Cells["ID"].Value.ToString();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                MostrarEdicion(dgvClientes.SelectedRows);
                Client.Modo = "Editando";
            }

        }

        private void cboFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cambiar el estatus del textbox según la opción marcada
            if (cboFiltrar.SelectedIndex != 0)
            {
                txtBuscar.Enabled = true;
            }
            else
            {
                txtBuscar.Enabled = false;
                //Ejecutar el metodo del textBox
                txtBuscar_TextChanged(sender, e);
            }
            //Limpiar el TextBox
            txtBuscar.Clear();
            FC.LimpiarCampos(Controls);
            Client.Modo = "Insertando";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                LoadClientes(cboFiltrar.Text, txtBuscar.Text);
            }
            else
            {
                LoadClientes(cboFiltrar.Text, txtBuscar.Text, int.Parse(cboViewRecord.Text));
            }

        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (Client.Modo == "Editando")
            {
                if (FC.ValidacionCampos(this.Name, Controls))
                {
                    if(Client.ActualizarClientes(int.Parse(LblID.Text), txtEmpresa.Text, txtProyecto.Text, txtRNC.Text, txtCedula.Text,
                        txtPrimerNombre.Text, txtSegundoNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text,
                        cboTipoClientes.SelectedIndex, txtTelefonoPrincipal.Text, int.Parse(txtExtension.Text),
                        txtTelefonoSecundario.Text, txtCalle.Text, int.Parse(txtNumero.Text), txtPuntoReferencia.Text,
                        cboCiudades.SelectedIndex, int.Parse(txtZipCode.Text), txtCorreo.Text, txtWeb.Text,
                        txtObservacion.Text))
                    {
                        FC.LimpiarCampos(Controls);

                        LoadClientes(cboFiltrar.Text, txtBuscar.Text, int.Parse(cboViewRecord.Text));

                        Client.Modo = FC.Modo;
                    }

                }
            }
            else
            {
                MessageBox.Show("Para actualizar debe seleccionar un cliente de la tabla.", "Sistema de Gestión",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (Client.Modo == "Editando")
            {

                if (Client.EliminarCliente(int.Parse(LblID.Text)))
                {
                    LoadClientes(cboFiltrar.Text, txtBuscar.Text,int.Parse(cboViewRecord.Text));
                    FC.LimpiarCampos(Controls);
                    Client.Modo = FC.Modo;
                }

            }
            else
            {
                MessageBox.Show("Para eliminar debe seleccionar un cliente de la tabla.", "Sistema de Gestión",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmdGuardar_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdGuardar, 1);
        }

        private void cmdGuardar_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(cmdGuardar, 0);
        }

        private void cmdGuardar_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdGuardar, 2);
        }

        private void cmdEliminar_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdEliminar, 1);
        }

        private void cmdEliminar_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(cmdEliminar, 0);
        }

        private void cmdEliminar_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdEliminar, 2);
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

        private void frmMantenimientoClientes_Load(object sender, EventArgs e)
        {
            if (EntrarLogin.PerfilActual == "Usuario")
            {
                cmdEliminar.Enabled = false;
                cmdEliminar.BackgroundImage = null;
                cmdEliminar.Text = "Restringido";

                cmdGuardar.Enabled = false;
                cmdGuardar.BackgroundImage = null;
                cmdGuardar.Text = "Restringido";

            }
        }

        private void cboTipoClientes_SelectedIndexChanged(object sender, EventArgs e)
        {


            ResetFields();

        }

        private void cboViewRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadClientes(cboFiltrar.Text, txtBuscar.Text, int.Parse(cboViewRecord.Text));
        }

        private void ResetFields()
        {
            txtExtension.Text = "0";
            txtNumero.Text = "0";
            txtZipCode.Text = "0";
            txtTelefonoPrincipal.Text = "000-000-0000";
            txtTelefonoSecundario.Text = "000-000-0000";
            txtRNC.Text = "0-00-000000-0";
            txtCedula.Text = "000-0000000-0";
            cboCiudades.SelectedItem = "Santo Domingo";

        }
    }
}
