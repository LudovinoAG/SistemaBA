using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Gestión.Modelos;
using System.Windows.Forms;

namespace Sistema_de_Gestión.Modelos
{
    class Clientes
    {
        public string Modo { get; set; }
        public int TotalClientes { get; set; }
        public int CantidadMostrar { get; set; }

        public void ListarClientes(string Filtro, string ValorBuscar, DataGridView dgvClientes, int Limite)
        {
            using (BAClientesModel DB = new BAClientesModel())
            {
                try
                {
                    //Obtener todos los elementos de la lista
                    this.CantidadMostrar = Limite;
                    this.TotalClientes = DB.VW_ListaClientes.OrderBy(t => t.Primer_Nombre).Count();
                    var lstClientes = DB.VW_ListaClientes.OrderBy(t=> t.Primer_Nombre).Take(this.CantidadMostrar);
                    var lstNuevoListado = lstClientes.ToList();

                    if (ValorBuscar != "")
                    {
                        if (Filtro == "ID")
                        {
                            lstNuevoListado = lstClientes.Where(filtro =>
                            filtro.ID.ToString()==ValorBuscar).ToList();

                        }

                        else if (Filtro == "Codigo")
                        {
                            lstNuevoListado = lstClientes.Where(filtro => filtro.Codigo.StartsWith(ValorBuscar)).ToList();

                        }

                        else if (Filtro == "Empresa")
                        {
                            lstNuevoListado = lstClientes.Where(filtro => filtro.Empresa.StartsWith(ValorBuscar)).ToList();

                        }

                        else if (Filtro == "Proyecto")
                        {
                            lstNuevoListado = lstClientes.Where(filtro => filtro.Proyecto.StartsWith(ValorBuscar)).ToList();

                        }

                        else if (Filtro == "RNC")
                        {
                            lstNuevoListado = lstClientes.Where(filtro => filtro.RNC.StartsWith(ValorBuscar)).ToList();

                        }

                        else if (Filtro == "Cedula")
                        {
                            lstNuevoListado = lstClientes.Where(filtro => filtro.Cedula.StartsWith(ValorBuscar)).ToList();

                        }

                        else if (Filtro == "Primer Nombre")
                        {
                            lstNuevoListado = lstClientes.Where(filtro => filtro.Primer_Nombre.StartsWith(ValorBuscar)).ToList();

                        }

                        else if (Filtro == "Segundo Nombre")
                        {
                            lstNuevoListado = lstClientes.Where(filtro => filtro.Segundo_Nombre.StartsWith(ValorBuscar)).ToList();

                        }

                        else if (Filtro == "Primer Apellido")
                        {
                            lstNuevoListado = lstClientes.Where(filtro => filtro.Primer_Apellido.StartsWith(ValorBuscar)).ToList();

                        }

                        else if (Filtro == "Segundo Apellido")
                        {
                            lstNuevoListado = lstClientes.Where(filtro => filtro.Segundo_Apellido.StartsWith(ValorBuscar)).ToList();

                        }

                        else if (Filtro == "Tipo")
                        {
                            lstNuevoListado = lstClientes.Where(filtro => filtro.Tipo_Cliente.StartsWith(ValorBuscar)).ToList();

                        }

                        else if (Filtro == "Telefono Principal")
                        {
                            lstNuevoListado = lstClientes.Where(filtro => filtro.Tel_Principal.StartsWith(ValorBuscar)).ToList();

                        }
                    }

                    //Cargar el dataGridView
                    dgvClientes.DataSource = null;
                    dgvClientes.DataSource = lstNuevoListado.OrderBy(t=> t.ID).ToList();





                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible cargar el listado de Clientes. " + ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        public bool InsertarClientes(string Empresa, string Proyecto, string RNC, string Cedula,
            string PrimerNombre,string SegundoNombre, string PrimerApellido, string SegundoApellido, int TipoCliente, 
            string TelefonoPrincipal,int Extension, string TelefonoSecundario, string Calle, int Numero, 
            string PuntoReferencia, int Ciudad,int CodigoPostal, string Correo, string Web, string Observacion)
        {
            using (BAClientesModel DB = new BAClientesModel())
            {
                try
                {
                    //Llamado al procedimiento almacenado
                    var Resultado = DB.SP_InsertarClientes(Empresa, Proyecto, RNC, Cedula, PrimerNombre, SegundoNombre,
                        PrimerApellido, SegundoApellido, TipoCliente, TelefonoPrincipal, Extension, TelefonoSecundario,
                        Calle, Numero, PuntoReferencia, Ciudad, CodigoPostal, Correo, Web, Observacion);

                    MessageBox.Show($"Se ha insertado el Cliente correctamente [{Empresa}].", "Nuevo Cliente",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible insertar el nuevo Cliente " + ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                    
                }
            }
            return true;
        }
        

        public bool ActualizarClientes(int ID,string Empresa, string Proyecto, string RNC, string Cedula,
            string PrimerNombre, string SegundoNombre, string PrimerApellido, string SegundoApellido, int TipoCliente,
            string TelefonoPrincipal, int Extension, string TelefonoSecundario, string Calle, int Numero,
            string PuntoReferencia, int Ciudad, int CodigoPostal, string Correo, string Web, string Observacion)
        {
            using (BAClientesModel DB = new BAClientesModel())
            {
                try
                {
                    var Resultado = DB.SP_ActualizarClientes(ID, ID, Empresa, Proyecto, RNC, Cedula, PrimerNombre, SegundoNombre,
                        PrimerApellido, SegundoApellido, TipoCliente, TelefonoPrincipal, Extension, TelefonoSecundario,
                        Calle, Numero, PuntoReferencia, Ciudad, CodigoPostal, Correo, Web, Observacion);

                    MessageBox.Show("El Cliente [" + Empresa + "] se actualizó correctamente.", "Cliente actualizado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible actualizar el Cliente. " + ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }


            }
            return true;
        }


        public bool EliminarCliente(int ID)
        {
            using (BAClientesModel PV = new BAClientesModel())
            {
                try
                {
                    var resp = MessageBox.Show("¿Realmente desea eliminar el cliente # [" + ID + "] del sistema?", "Eliminando",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resp == DialogResult.Yes)
                    {
                        var EliminarProducto = PV.EliminarCliente(ID);
                        MessageBox.Show("Se ha eliminado el cliente con la ID [" + ID + "] correctamente", "Cliente Eliminado",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        return false;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("No fue posible eliminar el cliente " + ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;

                }
            }
            return true;
        }
        public void CargarCantidadVista(ComboBox cboViews)
        {
            object[] RegistroMostrar = new object[] { 5, 10, 15, 20, 25, 30, 50, 100 };
            cboViews.Items.AddRange(RegistroMostrar);
            cboViews.SelectedIndex = 0;
        }

        public void LoadFiltros(ComboBox cboFiltros)
        {
            string[] Filtros = new string[] { "Ninguno", "ID", "Codigo", "Empresa", "Proyecto", "RNC","Cedula", 
                "Primer Nombre", "Segundo Nombre", "Primer Apellido", "Segundo Apellido", "Tipo", "Telefono Principal"};
            cboFiltros.Items.AddRange(Filtros);
            cboFiltros.SelectedIndex = 0;
        }

        public void ListarTipoClientes(ComboBox cboTipo)
        {
            using (BAClientesModel TP = new BAClientesModel())
            {
                try
                {
                    cboTipo.Items.Add("Elegir...");

                    var lstTipo = TP.VW_ListaTipoClientes.ToArray();
                    foreach (var item in lstTipo)
                    {
                       cboTipo.Items.Add(item.Tip_Cliente);
                    }

                    cboTipo.SelectedIndex = 0;
                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible listar los tipos de clientes. " + ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
        }

        public void ListarCiudades(ComboBox cboCiudades)
        {
            using (BAClientesModel LC = new BAClientesModel())
            {
                try
                {
                    cboCiudades.Items.Add("Elegir...");

                    var lstCiudades = LC.VW_ListaCiudades.ToArray();
                    foreach (var item in lstCiudades)
                    {
                        cboCiudades.Items.Add(item.Nom_Ciudad);
                    }

                    cboCiudades.SelectedIndex = 0;

                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible listar las ciudades. " + ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public void Paginacion()
        {

        }


    }
}
