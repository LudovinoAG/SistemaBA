using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Gestión.Modelos;
using System.Windows.Forms;

namespace Sistema_de_Gestión.Modelos
{
    class VehiculosModel
    {
        public string Modo { get; set; }
        public static int TotalVehiculos { get; set; }
        public static int VehiculosActivos { get; set; }
        public static int VehiculosInactivos { get; set; }
        public static int IDSeleccionado { get; set; }


        public List<VW_VerListaVehiculos> listaVehiculos(string Filtro, string ValorBuscar)
        {
            using (BAVehiculosEntities VE = new BAVehiculosEntities())
            {
                try
                {
                    //Obtener todos los elementos de la lista
                    var lstVehiculos = VE.VW_VerListaVehiculos.OrderBy(t => t.Marca).ToList();
                    var lstNuevoListado = lstVehiculos;

                    if (ValorBuscar != "")
                    {
                        if (Filtro == "Marca")
                        {
                            lstNuevoListado = lstVehiculos.Where(filtro => filtro.Marca.StartsWith(ValorBuscar.ToUpper())).ToList();

                        }
                        else if (Filtro == "Modelo")
                        {
                            lstNuevoListado = lstVehiculos.Where(filtro => filtro.Modelo.StartsWith(ValorBuscar.ToUpper())).ToList();

                        }
                        else if (Filtro == "ID")
                        {
                            lstNuevoListado = lstVehiculos.Where(filtro => filtro.ID.ToString() == ValorBuscar.ToUpper()).ToList();

                        }
                    }

                    TotalVehiculos = lstNuevoListado.Count;
                    VehiculosActivos = lstNuevoListado.Where(t => t.Estatus == "ACTIVO").Count();
                    VehiculosInactivos = lstNuevoListado.Where(t => t.Estatus == "INACTIVO").Count();
                    return lstNuevoListado.OrderBy(t=> t.ID).ToList();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("No fue posible listar el detalle de los vehiculos. " + Ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return null;
                }
            }
        }

        public void InsertarVehiculo(string Marca, string Modelo, string Descripcion, string Matricula, int idSeguro,
            DateTime FechaEmisionSeguro, DateTime FechaVencimientoSeguro, int Estatus, int Capacidad)
        {
            using (BAVehiculosEntities VE = new BAVehiculosEntities())
            {
                try
                {
                    VE.SP_InsertarVehiculos(Marca, Modelo, Descripcion, Matricula, idSeguro, FechaEmisionSeguro,
                        FechaVencimientoSeguro, Estatus, Capacidad);

                    MessageBox.Show($"Se ha registrado el vehiculo {Descripcion} correctamente", "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("No fue posible insertar el nuevo vehiculo. " + Ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        public void ActualizarVehiculo(int ID, string Marca, string Modelo, string Descripcion, string Matricula, 
            int idSeguro, DateTime FechaEmisionSeguro, DateTime FechaVencimientoSeguro, int Estatus, int Capacidad)
        {
            using (BAVehiculosEntities VE = new BAVehiculosEntities())
            {
                try
                {
                    VE.SP_ActualizarVehiculos(ID,Marca, Modelo, Descripcion, Matricula, idSeguro, FechaEmisionSeguro,
                        FechaVencimientoSeguro, Estatus, Capacidad);

                    MessageBox.Show($"Ha sido actualizado el vehiculo {Descripcion} correctamente", "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("No fue posible actualizar el vehiculo. " + Ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        public bool EliminarVehiculo(int ID)
        {
            using (BAVehiculosEntities VE = new BAVehiculosEntities())
            {
                try
                {
                    VE.SP_EliminarVehiculo(ID);

                    MessageBox.Show($"Se ha eliminado el vehiculo con la ID {ID} correctamente", "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("No fue posible eliminar el vehiculo. " + Ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
        }

        public void LoadFiltros(ComboBox cboFiltros)
        {
            string[] Filtros = new string[] { "Ninguno", "ID", "Marca", "Modelo" };
            cboFiltros.Items.AddRange(Filtros);
            cboFiltros.SelectedIndex = 0;
        }

        public void estatusVehiculos(ComboBox cboEstatus)
        {
            using (BAVehiculosEntities VE = new BAVehiculosEntities())
            {
                try
                {
                    var EstatusVehiculo = VE.VW_ListaEstatusVehiculos.ToList();

                    cboEstatus.DisplayMember = "NombreEstatus";
                    cboEstatus.ValueMember = "ID";
                    cboEstatus.DataSource = EstatusVehiculo;

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("No fue posible listar los estatus vehicular. " + Ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public void seguroVehicular(ComboBox cboSeguro)
        {
            using (BAVehiculosEntities VE = new BAVehiculosEntities())
            {
                try
                {
                    var SeguroVehiculo = VE.VW_ListaSeguroVehicular.ToList();
                    cboSeguro.DisplayMember = "Nom_SeguroVehicular";
                    cboSeguro.ValueMember = "id_SeguroVehicular";
                    cboSeguro.DataSource = SeguroVehiculo;

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("No fue posible listar los seguros vehicular. " + Ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

    }
}
