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
    public partial class frmMantenimientoProveedores : Form
    {
        DiseñoInterface DI = new DiseñoInterface();
        Proveedores BAProveedores = new Proveedores();
        Funciones FC = new Funciones();
        public frmMantenimientoProveedores()
        {
            InitializeComponent();
            LoadProveedores("", "");
            BAProveedores.LoadFiltros(cboFiltrar);
            BAProveedores.Modo = "Insertando";
        }


        private void LoadProveedores(string Filtro, string ValorBuscar)
        {
            BAProveedores.ListarProveedoresDetalles(Filtro, ValorBuscar, dgvProveedores);
            StbMantProveedores.Items[0].Text = "Total Proveedores: " + BAProveedores.TotalProveedores.ToString();
        }

        private void cmdGuadar_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdGuardar, 1);
        }

        private void cmdGuadar_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(cmdGuardar, 0);
        }

        private void cmdGuadar_MouseDown(object sender, MouseEventArgs e)
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


        private void cmdInsertar_Click(object sender, EventArgs e)
        {
            if (BAProveedores.Modo == "Insertando")
            {
                if (FC.ValidacionCampos(this.Name, Controls))
                {

                    //Insertar los proveedores
                    BAProveedores.InsertarProveedor(txtProveedor.Text, txtRNC.Text, txtNumContacto.Text,
                        int.Parse(txtComision.Text), txtDescripcion.Text);

                    //Limpiar y resetear los campos de formulario
                    FC.LimpiarCampos(Controls);

                    //Actualizar listado de Proveedores
                    LoadProveedores(cboFiltrar.Text, txtBuscar.Text);

                    BAProveedores.Modo = "Insertando";
                }
            }
            else
            {
                var resp = MessageBox.Show("Se encuentra actualmente en el modo de edición \n" +
                    "¿Desea limpiar los campos y cambiar al modo de Inserción?", "Aviso",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resp == DialogResult.Yes)
                {
                    BAProveedores.Modo = "Insertando";
                    FC.LimpiarCampos(Controls);
                }
            }

        }

        private void MostrarEdicion(DataGridViewSelectedRowCollection dgvProveedores)
        {
            txtProveedor.Text = dgvProveedores[0].Cells["Nom_Proveedor"].Value.ToString();
            txtRNC.Text = dgvProveedores[0].Cells["Rnc_Proveedor"].Value.ToString();
            txtNumContacto.Text = dgvProveedores[0].Cells["Contacto_Proveedor"].Value.ToString();
            txtComision.Text = dgvProveedores[0].Cells["Comision_Definida"].Value.ToString();
            txtDescripcion.Text = dgvProveedores[0].Cells["Des_Proveedor"].Value.ToString();

            LblID.Text = dgvProveedores[0].Cells["id_Proveedor"].Value.ToString();
        }


        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarEdicion(dgvProveedores.SelectedRows);
            BAProveedores.Modo = "Editando";
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (BAProveedores.Modo == "Editando")
            {
                if (FC.ValidacionCampos(this.Name, Controls))
                {
                    BAProveedores.ActualizarProveedor(int.Parse(LblID.Text), txtProveedor.Text, txtRNC.Text,
                        txtNumContacto.Text, int.Parse(txtComision.Text), txtDescripcion.Text);

                    FC.LimpiarCampos(Controls);

                    LoadProveedores(cboFiltrar.Text, txtBuscar.Text);

                    BAProveedores.Modo = "Insertando";

                }
            }
            else
            {
                MessageBox.Show("Para actualizar debe seleccionar un proveedor de la tabla.", "Sistema de Gestión",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (BAProveedores.Modo == "Editando")
            {

                if (BAProveedores.EliminarProveedor(int.Parse(LblID.Text)))
                {
                    LoadProveedores(cboFiltrar.Text, txtBuscar.Text);
                    FC.LimpiarCampos(Controls);
                    BAProveedores.Modo = "Insertando";
                }

            }
            else
            {
                MessageBox.Show("Para eliminar debe seleccionar un proveedor de la tabla.", "Sistema de Gestión",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            //Cargar los productos según filtro y valor
            //BAProductos.LimpiarCampos(Controls);
            LoadProveedores(cboFiltrar.Text, txtBuscar.Text);
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
        }

        private void frmMantenimientoProveedores_Load(object sender, EventArgs e)
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
    }
}
