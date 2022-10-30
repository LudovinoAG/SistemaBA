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
        public static int IDCliente { get; set; }
        public static int IDPedido { get; set; }

        public List<SP_VerRedaccionClienteID_Result> VerRedaccionCliente(int Cliente)
        {
            try
            {
                using(BARedaccionesEntities RE = new BARedaccionesEntities())
                {
                    Redacciones = RE.SP_VerRedaccionClienteID(Cliente).ToList();
                    if (Redacciones.Count!=0)
                    {
                        return Redacciones;
                    }
                    else
                    {
                        MessageBox.Show($"No se encontrarón pedidos pendientes para el cliente con el codigo C{Cliente.ToString().PadLeft(6,'0')}",
                            "Buscar pedidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        return Redacciones;
                    }
                    
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No fue posible vonsultar los pedidos del cliente. " + Ex.Message,"Consulta de Pedidos", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return Redacciones;
            }
        }


        public List<SP_VerDetalleRedaccion_Result> VerDetallesRedaccion(int Pedido)
        {
            try
            {
                using (BARedaccionesEntities RE = new BARedaccionesEntities())
                {
                    RedaccionesDetalles = RE.SP_VerDetalleRedaccion(Pedido).ToList();
                    if (RedaccionesDetalles.Count != 0)
                    {
                        return RedaccionesDetalles;
                    }
                    else
                    {
                        MessageBox.Show($"No se encontrarón detalles del pedidos {Pedido.ToString().PadLeft(6, '0')}",
                            "Buscar pedidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        return RedaccionesDetalles;
                    }

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No fue posible vonsultar los pedidos del cliente. " + Ex.Message, "Consulta de Pedidos",
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
    }
}
