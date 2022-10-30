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
    public partial class frmMantenimientoCategorias : Form
    {
        Categorias CA = new Categorias();
        DiseñoInterface DI = new DiseñoInterface();
        Funciones FC = new Funciones();
        public frmMantenimientoCategorias()
        {
            InitializeComponent();
            LoadCategoria("","");
            CA.LoadFiltros(cboFiltrar);
            CA.Modo = "Insertando";
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

        private void LoadCategoria(string Filtro, string ValorBuscar)
        {
            CA.ListarDetallesCategoria(Filtro, ValorBuscar, dgvCategorias);
            StbMantCategorias.Items[0].Text = "Total Categorias: " + CA.TotalCategorias.ToString();

        }

        private void MostrarEdicion(DataGridViewSelectedRowCollection dgvProductos)
        {
            txtCategoria.Text = dgvProductos[0].Cells["Nom_Categoria"].Value.ToString();
            txtDescripcion.Text = dgvProductos[0].Cells["Des_Categoria"].Value.ToString();

            LblID.Text = dgvProductos[0].Cells["id_CategoriaProducto"].Value.ToString();
        }


        private void cmdInsertar_Click(object sender, EventArgs e)
        {
            if (CA.Modo == "Insertando")
            {
                if (FC.ValidacionCampos(this.Name, Controls))
                {

                    //Insertar categorias
                    CA.InsertarCategorias(txtCategoria.Text, txtDescripcion.Text);

                    //Limpiar y resetear los campos de formulario
                    FC.LimpiarCampos(Controls);
                    CA.Modo = "Insertando";

                    //Actualizar listado de productos
                    LoadCategoria(cboFiltrar.Text, txtBuscar.Text);
                }
            }
            else
            {
                var resp = MessageBox.Show("Se encuentra actualmente en el modo de edición \n" +
                    "¿Desea limpiar los campos y cambiar al modo de Inserción?", "Aviso",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resp == DialogResult.Yes)
                {
                    CA.Modo = "Insertando";
                    FC.LimpiarCampos(Controls);
                }
            }

        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarEdicion(dgvCategorias.SelectedRows);
            CA.Modo = "Editando";
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //Cargar los productos según filtro y valor
            LoadCategoria(cboFiltrar.Text, txtBuscar.Text);
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (CA.Modo == "Editando")
            {
                if (FC.ValidacionCampos(this.Name, Controls))
                {
                    CA.ActualizarCategoria(int.Parse(LblID.Text), txtCategoria.Text, txtDescripcion.Text);
                    LoadCategoria(cboFiltrar.Text, txtBuscar.Text);

                    FC.LimpiarCampos(Controls);
                    CA.Modo = "Insertando";

                }
            }
            else
            {
                MessageBox.Show("Para actualizar debe seleccionar una categoria de la tabla.", "Sistema de Gestión",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (CA.Modo == "Editando")
            {

                if (CA.EliminarCategoria(int.Parse(LblID.Text)))
                {
                    LoadCategoria(cboFiltrar.Text, txtBuscar.Text);
                    FC.LimpiarCampos(Controls);
                    CA.Modo = "Insertando";
                }

            }
            else
            {
                MessageBox.Show("Para eliminar debe seleccionar una categoria de la tabla.", "Sistema de Gestión",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmMantenimientoCategorias_Load(object sender, EventArgs e)
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

        private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = FC.SoloTexto(e);
        }
    }
    
}
