using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Gestión.Modelos;
using System.Windows.Forms;

namespace Sistema_de_Gestión.Modelos
{
    public class Proveedores
    {

        public string Modo { get; set; }
        public int TotalProveedores { get; set; }

        public List<VW_ListaProveedores> CargarProveedores()
        {

            using (BAProveedoresEntities PD = new BAProveedoresEntities())
            {
                try
                {
                    return PD.VW_ListaProveedores.ToList();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible listar los proveedores " + ex.Message, "Sistema de Gestión", 
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return PD.VW_ListaProveedores.ToList();
                }


            }
        }


        public void ListarProveedoresDetalles(string Filtro, string ValorBuscar, DataGridView dgvProveedores)
        {
            using (BAProveedoresEntities DB = new BAProveedoresEntities())
            {
                try
                {
                    //Obtener todos los elementos de la lista
                    var lstProveedor = DB.VW_ListaProveedores.OrderBy(t => t.Nom_Proveedor).ToList();
                    var lstNuevoListado = lstProveedor;

                    if (ValorBuscar != "")
                    {
                        if (Filtro == "Proveedor")
                        {
                            lstNuevoListado = lstProveedor.Where(filtro => 
                            filtro.Nom_Proveedor.StartsWith(ValorBuscar.ToUpper())).ToList();

                        }

                        else if (Filtro == "ID")
                        {
                            lstNuevoListado = lstProveedor.Where(filtro => filtro.id_Proveedor.ToString() 
                            == ValorBuscar.ToUpper()).ToList();

                        }

                        else if (Filtro == "RNC")
                        {
                            lstNuevoListado = lstProveedor.Where(filtro => filtro.Rnc_Proveedor.StartsWith(ValorBuscar)).ToList();

                        }
                    }

                    this.TotalProveedores = lstNuevoListado.Count();

                    //Cargar el dataGridView
                    dgvProveedores.DataSource = null;
                    dgvProveedores.DataSource = lstNuevoListado;
                    dgvProveedores.Columns["id_Proveedor"].HeaderText = "ID";
                    dgvProveedores.Columns["Nom_Proveedor"].HeaderText = "Proveedor";
                    dgvProveedores.Columns["Rnc_Proveedor"].HeaderText = "RNC";
                    dgvProveedores.Columns["Contacto_Proveedor"].HeaderText = "Telefono";
                    dgvProveedores.Columns["Comision_Definida"].HeaderText = "Comisión";
                    dgvProveedores.Columns["Des_Proveedor"].HeaderText = "Descripción";

                    dgvProveedores.Columns["Nom_Proveedor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgvProveedores.Columns["Rnc_Proveedor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgvProveedores.Columns["Contacto_Proveedor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgvProveedores.Columns["Des_Proveedor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                    dgvProveedores.Columns["id_Proveedor"].DisplayIndex = 0;

                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible cargar el listado de proveedores. " + ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        public void InsertarProveedor(string Nombre, string RNC,string Telefono, 
            int Comision, string Descripcion)
        {

            using (BAProveedoresEntities DB = new BAProveedoresEntities())
            {
                try
                {
                    //Llamado al procedimiento almacenado
                    var Resultado = DB.SP_InsertarProveedor(Nombre.ToUpper(), RNC, Telefono, Comision, Descripcion);

                    MessageBox.Show("Se ha insertado el proveedor correctamente", "Nuevo Proveedor",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible insertar el proveedor " + ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public void ActualizarProveedor(int ID, string Nombre, string RNC, string Telefono,
           int Comision, string Descripcion)
        {
            using (BAProveedoresEntities DB = new BAProveedoresEntities())
            {
                try
                {
                    var Resultado = DB.SP_ActualizarProveedor(ID, Nombre.ToUpper(), RNC, Telefono,
                            Comision, Descripcion);

                    MessageBox.Show("El proveedor [" + Nombre + "] se actualizó correctamente.", "Proveedor actualizado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible actualizar el proveedor. " + ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        public bool EliminarProveedor(int ID)
        {
            using (BAProveedoresEntities PV = new BAProveedoresEntities())
            {
                try
                {
                    var resp = MessageBox.Show("¿Realmente desea eliminar el proveedor # [" + ID + "] del sistema?", "Eliminando",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resp == DialogResult.Yes)
                    {
                        var EliminarProducto = PV.SP_EliminarProveedor(ID);
                        MessageBox.Show("Se ha eliminado el proveedor con la ID [" + ID + "] correctamente", "Proveedor Eliminado",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        return false;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("No fue posible eliminar el proveedor " + ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;

                }
            }
            return true;
        }

        public void LoadFiltros(ComboBox cboFiltros)
        {
            string[] Filtros = new string[] { "Ninguno", "ID", "Proveedor", "RNC" };
            cboFiltros.Items.AddRange(Filtros);
            cboFiltros.SelectedIndex = 0;
        }
    }
}
