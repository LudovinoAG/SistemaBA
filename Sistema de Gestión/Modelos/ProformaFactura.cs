using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gestión.Modelos
{
    class ProformaFactura
    {
        public static DateTime FechaInicio { get; set; }
        public static DateTime FechaFin { get; set; }
        public static int IDCliente { get; set; }
        public static int IDPedido { get; set; }
        public static int EstatusPedido { get; set; }
        public static string ModoReporte { get; set; }

        public static string Nombre_Cliente { get; set; }
        public List<SP_BuscarClienteProforma_Result> ClienteProforma { get; set; }
        public List<SP_ProformaBuscarPedidosPendientesCliente_Result> PedidoProforma { get; set; }

        public List<SP_ProformaBuscarConducesPorPedido_Result> ConduceProforma { get; set; }


        public List<SP_BuscarClienteProforma_Result> VerClienteProforma(string cod_cliente)
        {
            try
            {
                using (BAPedidosEntities PE = new BAPedidosEntities())
                {
                    ClienteProforma = PE.SP_BuscarClienteProforma(cod_cliente).ToList();
                    if (ClienteProforma.Count != 0)
                    {

                        return ClienteProforma;
                    }
                    else
                    {
                        MessageBox.Show($"No se encontró al cliente con el codigo {cod_cliente.ToString().PadLeft(6, '0')}",
                            "Buscar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        return ClienteProforma;
                    }

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No fue posible acceder al registro de los clientes. " + Ex.Message, 
                    "Consulta de Clientes",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return ClienteProforma;
            }
        }

        public List<SP_ProformaBuscarPedidosPendientesCliente_Result> VerPedidoProforma(int id_cliente,
            int id_Pedido,string ModoReporte, int Estatus, DateTime FechaInicio, DateTime FechaFin)
        {
            try
            {
                using (BAPedidosEntities PE = new BAPedidosEntities())
                {
                    PedidoProforma = PE.SP_ProformaBuscarPedidosPendientesCliente(id_cliente, id_Pedido,
                        ModoReporte, Estatus,FechaInicio.Date, FechaFin.Date).ToList();
                    if (PedidoProforma.Count != 0)
                    {
                        return PedidoProforma;
                    }
                    else
                    {
                        MessageBox.Show($"No se encontró los pedidos del cliente [{Nombre_Cliente}]",
                            "Buscar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        return PedidoProforma;
                    }

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No fue posible consultar los pedidos del cliente. " + Ex.Message,"Consulta de Pedidos",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return PedidoProforma;
            }
        }

        public List<SP_ProformaBuscarConducesPorPedido_Result> VerConduceProforma(int id_cliente, int id_pedido,
            string ModoReporte, int Estatus,DateTime FechaInicio, DateTime FechaFin)
        {
            try
            {
                using (BAPedidosEntities PE = new BAPedidosEntities())
                {
                    ConduceProforma = PE.SP_ProformaBuscarConducesPorPedido(id_cliente, id_pedido, ModoReporte,
                        Estatus,FechaInicio.Date, FechaFin.Date).ToList();
                    if (ConduceProforma.Count != 0)
                    {
                        return ConduceProforma;
                    }
                    else
                    {
                        MessageBox.Show($"No se encontró los conduces del pedido numero [{Nombre_Cliente}]",
                            "Buscar Conduce", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        return ConduceProforma;
                    }

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No fue posible consultar los conduces del pedido. " + Ex.Message, 
                    "Consulta de Conduces",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return ConduceProforma;
            }
        }


        public void DefaultValueProforms(ComboBox Pedidos, ComboBox Estatus, ComboBox Modo,
            DateTimePicker FechaInicio, DateTimePicker FechaFin, NumericUpDown Pedido)
        {
            IDPedido = 0;
            ModoReporte = "Todas";
            EstatusPedido = 0;

            Pedidos.SelectedIndex = 0;
            Estatus.SelectedIndex = 0;
            Modo.SelectedIndex = 0;
            FechaInicio.Value = DateTime.Today;
            FechaFin.Value = DateTime.Today;
            Pedido.Value = 1;
        }
    }
}
