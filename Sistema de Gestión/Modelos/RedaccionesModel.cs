using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Gestión.Modelos;
using System.Windows.Forms;

namespace Sistema_de_Gestión.Modelos
{
    class RedaccionesModel
    {

        public static List<SP_VerRedaccionClienteID_Result> Redacciones { get; set; }
        public static List<SP_VerDetalleRedaccion_Result> RedaccionesDetalles { get; set; }
        public static List<SP_VerConducesPedidos_Result> ConducesPedidos { get; set; }
        public static List<SP_BuscarClienteRedaccion_Result> ClienteRedaccion { get; set; }
        public static int IDCliente { get; set; }
        public static int IDPedido { get; set; }
        public static string ModoReporte { get; set; }
        public static int EstatudPedido { get; set; }
        public static DateTime FechaInicio { get; set; }
        public static DateTime FechaFin { get; set; }

        
        public List<SP_VerRedaccionClienteID_Result> VerRedaccionCliente(int Cliente, int idPedido,
            string ModoReporte,int estatus, DateTime FechaInicio, DateTime FechaFin)
        {
            try
            {
                using(BARedaccionesEntities RE = new BARedaccionesEntities())
                {
                    Redacciones = RE.SP_VerRedaccionClienteID(Cliente, idPedido, ModoReporte, estatus, 
                        FechaInicio, FechaFin).ToList();
                    return Redacciones;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No fue posible consultar los pedidos del cliente. " + Ex.Message,"Consulta de Pedidos", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return Redacciones;
            }
        }
        
        public List<SP_VerDetalleRedaccion_Result> VerDetallesRedaccion(int Cliente, int Pedido,string ModoReporte,
            int EstatudPedido, DateTime FechaInicio, DateTime FechaFin)
        {
            try
            {
                using (BARedaccionesEntities RE = new BARedaccionesEntities())
                {
                    RedaccionesDetalles = RE.SP_VerDetalleRedaccion(Cliente,Pedido, ModoReporte,
                        EstatudPedido, FechaInicio, FechaFin).ToList();
                    if (RedaccionesDetalles.Count != 0)
                    {
                        return RedaccionesDetalles;
                    }
                    else
                    {
                        MessageBox.Show($"No se encontrarón detalles del pedidos {Cliente.ToString().PadLeft(6, '0')}",
                            "Buscar pedidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        return RedaccionesDetalles;
                    }

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No fue posible consultar los pedidos del cliente. " + Ex.Message, "Consulta de Pedidos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return RedaccionesDetalles;
            }
        }

        public List<SP_VerConducesPedidos_Result> VerConducesPedidos(int Pedido)
        {
            try
            {
                using (BARedaccionesEntities RE = new BARedaccionesEntities())
                {
                    ConducesPedidos = RE.SP_VerConducesPedidos(Pedido).ToList();
                    if (ConducesPedidos.Count != 0)
                    {
                        return ConducesPedidos;
                    }
                    else
                    {
                        MessageBox.Show($"No se encontrarón conduces del pedidos {Pedido.ToString().PadLeft(6, '0')}",
                            "Buscar conduces", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        return ConducesPedidos;
                    }

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No fue posible vonsultar los pedidos del cliente. " + Ex.Message, "Consulta de Pedidos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return ConducesPedidos;
            }
        }

        public List<SP_BuscarClienteRedaccion_Result> VerCliendeRedaccion(string Cod_Cliente)
        {
            try
            {
                using(BARedaccionesEntities RE = new BARedaccionesEntities())
                {
                    ClienteRedaccion = RE.SP_BuscarClienteRedaccion(Cod_Cliente).ToList();
                    return ClienteRedaccion;
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"No se encontro al cliente [{Cod_Cliente}] en el sistema", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return ClienteRedaccion;
            }
        }


        public void DefaultValueRedactions(ComboBox Pedidos, ComboBox Estatus, ComboBox Modo, 
            DateTimePicker FechaInicio, DateTimePicker FechaFin, NumericUpDown Pedido)
        {
            IDPedido = 0;
            ModoReporte = "Todas";
            EstatudPedido = 0;

            Pedidos.SelectedIndex = 0;
            Estatus.SelectedIndex = 0;
            Modo.SelectedIndex = 0;
            FechaInicio.Value = DateTime.Today;
            FechaFin.Value = DateTime.Today;
            Pedido.Value = 1;
        }
    }
}
