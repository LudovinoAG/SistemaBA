using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gestión.Modelos
{
    public class Productos
    {

        public string Modo { get; set; }
        public int TotalProductos { get; set; }
        public int ProductosDisponiles { get; set; }
        public int ProductosAgotados { get; set; }
        public int ProductosEnUso { get; set; }
        public int ProductosEnMantenimiento { get; set; }
        public int ProductosDesactivado { get; set; }

        public void ListarProductos(string Filtro, string ValorBuscar,DataGridView dgvPRODUCTOS)
        {
            using (BAProductosEntities DB = new BAProductosEntities())
            {
                try
                {
                    //Obtener todos los elementos de la lista
                    var lstProductos = DB.VW_ListaGeneralProductos.OrderBy(t => t.Producto).ToList();
                    var lstNuevoListado = lstProductos;

                    if (ValorBuscar!="")
                    {
                        if (Filtro == "Codigo")
                        {
                            lstNuevoListado = lstProductos.Where(filtro => filtro.Codigo.StartsWith(ValorBuscar.ToUpper())).ToList();

                        }
                        else if (Filtro == "Producto")
                        {
                            lstNuevoListado = lstProductos.Where(filtro => filtro.Producto.StartsWith(ValorBuscar.ToUpper())).ToList();

                        }
                        else if (Filtro == "ID")
                        {
                            lstNuevoListado = lstProductos.Where(filtro => filtro.ID.ToString()==ValorBuscar.ToUpper()).ToList();

                        }
                    }
                   

                    this.TotalProductos = lstNuevoListado.Count();
                    this.ProductosDisponiles = lstNuevoListado.Where(disponibles => disponibles.Estado == "DISPONIBLE").Count();
                    this.ProductosAgotados = lstNuevoListado.Where(disponibles => disponibles.Estado == "AGOTADO").Count();
                    this.ProductosEnUso = lstNuevoListado.Where(disponibles => disponibles.Estado == "EN USO").Count();
                    this.ProductosEnMantenimiento = lstNuevoListado.Where(disponibles => disponibles.Estado == "EN MANTENIMIENTO").Count();
                    this.ProductosDesactivado = lstNuevoListado.Where(disponibles => disponibles.Estado == "DESACTIVADO").Count();

                    //Cargar el dataGridView
                    dgvPRODUCTOS.DataSource = null;
                    dgvPRODUCTOS.DataSource = lstNuevoListado;
                    dgvPRODUCTOS.Columns["Producto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgvPRODUCTOS.Columns["Descripción"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgvPRODUCTOS.Columns["Precio"].DefaultCellStyle.Format = "RD$#,#0.00";

                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible cargar el listado de productos. " + ex.Message, "Sistema de Gestión", 
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
        }

        public void ListarEstatusProductos(ComboBox cboEstatus)
        {
            cboEstatus.Items.Add("Elegir...");

            using (BAProductosEntities PT = new BAProductosEntities())
            {
                var lstEstatus = PT.VW_ListaEstatusProductos.ToArray();
                foreach (var item in lstEstatus)
                {
                    cboEstatus.Items.Add(item.Est_Producto);
                }

                cboEstatus.SelectedIndex = 0;
            }
        }

        public void InsertarProductos(int idCategoria, int idProveedor, string Nombre, string Descripcion, 
                    decimal Precio, int idEstatus)
        {

            using (BAProductosEntities DB = new BAProductosEntities())
            {
                try
                {
                    //Llamado al procedimiento almacenado
                    var Resultado = DB.SP_InsertarProductos(idCategoria, idProveedor, Nombre, Descripcion, Precio, idEstatus);

                    MessageBox.Show("Se ha insertado el producto correctamente", "Nuevo Producto", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible insertar el producto " + ex.Message, "Sistema de Gestión", 
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public void ActualizarProducto(int ID, string Nombre, string Descripcion, decimal Precio,
            int Categoria, int Proveedor, int IDEstatus)
        {
            using (BAProductosEntities DB = new BAProductosEntities())
            {
                try
                {
                    var Resultado = DB.SP_ActualizarProducto(ID, Categoria, Proveedor, Nombre,
                            Descripcion, Precio, IDEstatus);

                    MessageBox.Show("El producto [" + Nombre + "] se actualizó correctamente.", "Producto actualizado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible actualizar el producto. " + ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

               
            }
        }

        public bool EliminarProducto(int ID)
        {
            using (BAProductosEntities PT = new BAProductosEntities())
            {
                try
                {
                    var resp = MessageBox.Show("¿Realmente desea eliminar el producto # [" + ID + "] del sistema?", "Eliminando",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resp==DialogResult.Yes)
                    {
                        var EliminarProducto = PT.SP_EliminarProducto(ID);
                        MessageBox.Show("Se ha eliminado el producto con la ID [" + ID + "] correctamente", "Producto Eliminado",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        return false;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("No fue posible eliminar el producto " + ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;

                }
            }
            return true;
        }

        public void LimpiarCampos(Control.ControlCollection control)
        {
            var CamposTXT = control.OfType<TextBox>().OrderBy(t => t.TabIndex);
            var ListasCBO = control.OfType<ComboBox>().OrderBy(t => t.TabIndex);
            var LBL = control.OfType<Label>().Where(t => t.Name=="LblID").Single();

            //Limpiar todos los TextBox
            foreach (var Camp in CamposTXT)
            {
                Camp.Clear();
            }

            //Restablecer la seleccion de los ComboBox a 0
            foreach (var Lst in ListasCBO)
            {
                if (Lst.SelectedIndex!= -1)
                {
                    Lst.SelectedIndex = 0;
                }
                
            }

            //Limpiar LabelID
            LBL.Text = "";
            this.Modo = "Insertando";
            
        }
        
        public bool ValidacionCampos(string formName, Control.ControlCollection control)
        {
            var CamposTXT = control.OfType<TextBox>().OrderBy(t=> t.TabIndex);
            var ListasCBO = control.OfType<ComboBox>().OrderBy(t=> t.TabIndex);

            switch (formName)
            {
                case "frmMantenimientoProductos":
                    foreach (var item in CamposTXT)
                    {
                        if (!string.IsNullOrEmpty(item.Text))
                        {
                            if (item.Name=="txtProducto")
                            {
                                if (item.TextLength>5 || !string.IsNullOrEmpty(item.Text))
                                {

                                    foreach (var itemCBO in ListasCBO)
                                    {
                                        if (itemCBO.Text == "Elegir...")
                                        {
                                            MessageBox.Show("Debe indicar una opción valida en [" + itemCBO.Tag + "] para continuar.",
                                               "Sistema de Gestión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            return false;
                                        }
                                    }

                                }
                                else
                                {
                                    return false;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("El campo [" + item.Tag + "] no puede estar vacio.", "Sistema de Gestión", 
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }

                   

                    break; 

            }
         
            return true;
            

        }

        public void LoadFiltros(ComboBox cboFiltros)
        {
            string[] Filtros = new string[]{"Ninguno","ID","Codigo","Producto" };
            cboFiltros.Items.AddRange(Filtros);
            cboFiltros.SelectedIndex = 0;
        }



        
    }
}
