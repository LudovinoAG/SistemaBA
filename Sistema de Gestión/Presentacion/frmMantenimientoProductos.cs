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
    public partial class frmMantenimientoProductos : Form
    {
        Productos BAProductos = new Productos();
        DiseñoInterface DI = new DiseñoInterface();
        Categorias BACategorias = new Categorias();
        Proveedores BAProveedores = new Proveedores();


        public frmMantenimientoProductos()
        {
            InitializeComponent();
            LoadProductos("","");
            BAProductos.ListarEstatusProductos(cboEstatus);
            BAProductos.LoadFiltros(cboFiltrar);
            ListarCategoriasProductos();
            ListarProveedoresProductos();
            BAProductos.Modo = "Insertando";
        }


        private void ListarCategoriasProductos()
        {
            cboCategoria.DisplayMember = "Nom_Categoria";
            cboCategoria.ValueMember = "id_CategoriaProducto";
            cboCategoria.DataSource = BACategorias.ListarCategorias().ToList();

        }

        private void ListarProveedoresProductos()
        {
            cboCategoria.DisplayMember = "Nom_Proveedor";
            cboCategoria.ValueMember = "id_Proveedor";
            cboCategoria.DataSource = BAProveedores.CargarProveedores().ToList();
        }


        private void frmMantenimientoProductos_Load(object sender, EventArgs e)
        {
            if (EntrarLogin.PerfilActual == "Usuario")
            {
                cmdEliminar.Enabled = false;
                cmdEliminar.BackgroundImage = null;
                cmdEliminar.Text = "Restringido";

                cmdGuardar.Enabled = false;
                cmdGuardar.BackgroundImage = null;
                cmdGuardar.Text = "Restringido";

                cmdInsertar.Enabled = false;
                cmdInsertar.BackgroundImage = null;
                cmdInsertar.Text = "Restringido";

            }
        }

        private void LoadProductos(string Filtro, string ValorBuscar)
        {
            BAProductos.ListarProductos(Filtro, ValorBuscar, dgvProductos);
            StbMantProducts.Items[0].Text = "Total de productos y servicios: " + BAProductos.TotalProductos.ToString();
            StbMantProducts.Items[1].Text = "Disponibles: " + BAProductos.ProductosDisponiles.ToString();
            StbMantProducts.Items[2].Text = "Agotados: " + BAProductos.ProductosAgotados.ToString();
            StbMantProducts.Items[3].Text = "En Uso: " + BAProductos.ProductosEnUso.ToString();
            StbMantProducts.Items[4].Text = "En Mantenimiento: " + BAProductos.ProductosEnMantenimiento.ToString();
            StbMantProducts.Items[5].Text = "Desactivados: " + BAProductos.ProductosDesactivado.ToString();
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
            if (BAProductos.Modo=="Insertando")
            {
                if (BAProductos.ValidacionCampos(this.Name, Controls))
                {

                    //Insertar los productos
                    BAProductos.InsertarProductos((int)cboCategoria.SelectedValue, (int)cboProveedor.SelectedValue,
                       txtProducto.Text, txtDescripcion.Text, decimal.Parse(txtPrecio.Text), cboEstatus.SelectedIndex, decimal.Parse(txtITBISProducto.Text));

                    //Limpiar y resetear los campos de formulario
                    BAProductos.LimpiarCampos(Controls);

                    //Actualizar listado de productos
                    LoadProductos(cboFiltrar.Text, txtBuscar.Text);
                }
            }
            else
            {
                var resp = MessageBox.Show("Se encuentra actualmente en el modo de edición \n" +
                    "¿Desea limpiar los campos y cambiar al modo de Inserción?","Aviso",
                    MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (resp == DialogResult.Yes)
                {
                    BAProductos.Modo = "Insertando";
                    BAProductos.LimpiarCampos(Controls);
                }
            }
          
        }

        private void MostrarEdicion(DataGridViewSelectedRowCollection dgvProductos)
        {
            txtProducto.Text = dgvProductos[0].Cells["Producto"].Value.ToString();
            txtDescripcion.Text = dgvProductos[0].Cells["Descripción"].Value.ToString();
            txtPrecio.Text = dgvProductos[0].Cells["Precio"].Value.ToString();
            txtITBISProducto.Text = dgvProductos[0].Cells["ITBIS"].Value.ToString();

            cboCategoria.SelectedItem = dgvProductos[0].Cells["Categoria"].Value.ToString();
            cboProveedor.SelectedItem = dgvProductos[0].Cells["Proveedor"].Value.ToString();
            cboEstatus.SelectedItem = dgvProductos[0].Cells["Estado"].Value.ToString();


            LblID.Text = dgvProductos[0].Cells["ID"].Value.ToString();
        }


        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarEdicion(dgvProductos.SelectedRows);
            BAProductos.Modo = "Editando";
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (BAProductos.Modo=="Editando")
            {
                if (BAProductos.ValidacionCampos(this.Name, Controls))
                {
                    BAProductos.ActualizarProducto(int.Parse(LblID.Text), txtProducto.Text, txtDescripcion.Text,
                        decimal.Parse(txtPrecio.Text), cboCategoria.SelectedIndex, cboProveedor.SelectedIndex,
                        cboEstatus.SelectedIndex,decimal.Parse(txtITBISProducto.Text));
                    LoadProductos(cboFiltrar.Text, txtBuscar.Text);

                    BAProductos.LimpiarCampos(Controls);
                    BAProductos.Modo = "Insertando";

                }
            }
            else
            {
                MessageBox.Show("Para actualizar debe seleccionar un producto de la tabla.", "Sistema de Gestión",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           

        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (BAProductos.Modo == "Editando")
            {

                if (BAProductos.EliminarProducto(int.Parse(LblID.Text)))
                {
                    LoadProductos(cboFiltrar.Text, txtBuscar.Text);
                    BAProductos.LimpiarCampos(Controls);
                    BAProductos.Modo = "Insertando";
                }

            }
            else
            {
                MessageBox.Show("Para eliminar debe seleccionar un producto de la tabla.", "Sistema de Gestión",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            //Cargar los productos según filtro y valor
            //BAProductos.LimpiarCampos(Controls);
            LoadProductos(cboFiltrar.Text, txtBuscar.Text);
        }

        private void cboFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Cambiar el estatus del textbox según la opción marcada
            if (cboFiltrar.SelectedIndex!=0)
            {
                txtBuscar.Enabled = true;
            }
            else
            {
                txtBuscar.Enabled = false;
                //Ejecutar el metodo del textBox
                txtBuscar_TextChanged(sender,e);
            }
            //Limpiar el TextBox
            txtBuscar.Clear();
            BAProductos.LimpiarCampos(Controls);
        }

    }
}
