using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Gestión.Modelos;
using System.Windows.Forms;

namespace Sistema_de_Gestión.Modelos
{
    class Categorias
    {

        public string Modo { get; set; }
        public int TotalCategorias { get; set; }
        

        public void InsertarCategorias(string Nombre, string Descripcion)
        {

            using (BACategorias DB = new BACategorias())
            {
                try
                {
                    //Llamado al procedimiento almacenado
                    var Resultado = DB.SP_InsertarCategorias(Nombre, Descripcion);

                    MessageBox.Show("Se ha insertado la categoria correctamente", "Nueva Categoria",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible insertar la nueva categoria " + ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public void ActualizarCategoria(int ID, string Nombre, string Descripcion)
        {
            using (BACategorias DB = new BACategorias())
            {
                try
                {
                    var Resultado = DB.SP_ActualizarCategorias(ID,Nombre,Descripcion);

                    MessageBox.Show("La categoria [" + Nombre + "] se actualizó correctamente.", "Categoria actualizada",
                                MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible actualizar la categoria. " + ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        public bool EliminarCategoria(int ID)
        {
            using (BACategorias DB = new BACategorias())
            {
                try
                {

                    var resp = MessageBox.Show("¿Realmente desea eliminar el producto # [" + ID + "] del sistema?", "Eliminando",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resp == DialogResult.Yes)
                    {
                        var EliminarProducto = DB.SP_EliminarCategorias(ID);
                        MessageBox.Show("Se ha eliminado la categoria con la ID [" + ID + "] correctamente", "Categoria Eliminada",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        return false;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("No fue posible eliminar la categoria " + ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;

                }
            }
            return true;
        }

        

        public void LoadFiltros(ComboBox cboFiltros)
        {
            string[] Filtros = new string[] { "Ninguno", "ID", "Categoria" };
            cboFiltros.Items.AddRange(Filtros);
            cboFiltros.SelectedIndex = 0;
        }



        public List<VW_ListaCategorias> ListarCategorias()
        {

            using (BACategorias CA = new BACategorias())
            {
                try
                {
                    return CA.VW_ListaCategorias.ToList();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible listar las categorias " + ex.Message, "Sistema de Gestión", 
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return CA.VW_ListaCategorias.ToList();
                }
            }

        }


        public void ListarDetallesCategoria(string Filtro, string ValorBuscar, DataGridView dgvCategoria)
        {
            using (BACategorias CA = new BACategorias())
            {
                try
                {
                    //Obtener todos los elementos de la lista
                    var lstCategorias = CA.VW_ListaCategorias.OrderBy(t => t.Nom_Categoria).ToList();            
                    var lstNuevoListado = lstCategorias;
                    //lstNuevoListado.Take(2);


                    if (ValorBuscar != "")
                    {
                        
                        if (Filtro == "Categoria")
                        {
                            lstNuevoListado = lstCategorias.Where(filtro => filtro.Nom_Categoria.StartsWith(ValorBuscar.ToUpper())).ToList();

                        }
                        else if (Filtro == "ID")
                        {
                            lstNuevoListado = lstCategorias.Where(filtro => filtro.id_CategoriaProducto.ToString() == 
                            ValorBuscar.ToUpper()).ToList();


                        }
                    }

            
                    //Cargar el dataGridView
                    dgvCategoria.DataSource = null;
                    dgvCategoria.DataSource = lstNuevoListado;
                    this.TotalCategorias = dgvCategoria.Rows.Count;

                    dgvCategoria.Columns[0].HeaderText = "ID";
                    dgvCategoria.Columns[1].HeaderText = "Categoria";
                    dgvCategoria.Columns[2].HeaderText = "Descripción";

                    dgvCategoria.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgvCategoria.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible listar el detalle de las categorias " + ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
