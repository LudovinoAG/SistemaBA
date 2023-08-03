using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Gestión.Modelos;
using System.Windows.Forms;

namespace Sistema_de_Gestión.Modelos
{
    class FacturacionModel
    {

        public static int IDCliente { get; set; }
        public static string NombreCliente { get; set; }
        public static int TipoCliente { get; set; }
        public static string Correo { get; set; }
        public static string Direccion { get; set; }
        public static string RNC { get; set; }
        public static string Telefonos { get; set; }
        public static string Contactos { get; set; }
        public static int IDTipoFactura { get; set; }
        public static string NCF { get; set; }
        public static int EstatusFactura { get; set; }
        public static double SubTotalFactura { get; set; }
        public static double TotalFactura { get; set; }
        public static int IDModoPago { get; set; }
        public static double DescuentoFactura { get; set; }
        public static double ITBISFactura { get; set; }
        public static DateTime FechaFactura { get; set; }
        public static TimeSpan HoraFactura { get; set; }
        public static DateTime FechaVencimientoFactura { get; set; }
        public static string NotasFactura { get; set; }
        public static int IDUsuario { get; set; }
        public static int IDPago { get; set; }
        public static int IDPedido { get; set; }
        public static string ModoReporte { get; set; }
        public static int EstatusPedido { get; set; }
        public static int NumConduce { get; set; }
        public static DateTime FechaInicio { get; set; }
        public static DateTime FechaFin { get; set; }
        public static int IDFactura { get; set; }
        public static DateTime VencimientoNCF { get; set; }

        public List<SP_BuscarClienteFacturar_Result> ClienteFactura { get; set; }
        public List<SP_BuscarPedidosClienteFacturar_Result> PedidosClientesFacturar { get; set; }

        public List<SP_BuscarConducesFactura_Result> ConducesFacturar { get; set; }

        public List<SP_BuscarClienteFacturar_Result> BuscarClienteFacturar(int ID_Cliente)
        {
            try
            {
                using(BAFacturacionEntities FE = new BAFacturacionEntities())
                {
                    string codigoCliente = $"C{ID_Cliente.ToString().PadLeft(6, '0')}";
                    ClienteFactura = FE.SP_BuscarClienteFacturar(ID_Cliente).ToList();
                    if (ClienteFactura.Count!=0)
                    {
                        IDCliente = ClienteFactura.SingleOrDefault().ID;
                        NombreCliente = ClienteFactura.SingleOrDefault().Empresa;
                        TipoCliente = ClienteFactura.SingleOrDefault().TipoCliente;
                        Correo = ClienteFactura.SingleOrDefault().Correo;
                        Direccion = ClienteFactura.SingleOrDefault().Direccion;
                        Contactos = ClienteFactura.SingleOrDefault().Contacto;
                        Telefonos = ClienteFactura.SingleOrDefault().Telefonos;
                        RNC = ClienteFactura.SingleOrDefault().RNC;

                        return ClienteFactura;
                    }
                    else
                    {
                        MessageBox.Show($"No se encuentra el cliente indicado [{codigoCliente}]", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        
                    }

                    return ClienteFactura;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No fue posible buscar el cliente indicado. " + Ex.Message, "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return ClienteFactura;
            }
        }

        public List<SP_BuscarPedidosClienteFacturar_Result> BuscarPedidosClienteFacturar(int IDCliente, int IDPedido,
            string ModoReporte, int EstatusPedido, DateTime FechaInicio, DateTime FechaFin, int Conduce)
        {
            try
            {
                using (BAFacturacionEntities FE = new BAFacturacionEntities()) 
                {
                    PedidosClientesFacturar = FE.SP_BuscarPedidosClienteFacturar(IDCliente, IDPedido, ModoReporte,
                        EstatusPedido, FechaInicio, FechaFin, Conduce).ToList();
                    if (PedidosClientesFacturar.Count!=0)
                    {
                        SubTotalFactura = (double)PedidosClientesFacturar.Sum(t => t.SubTotal).Value;
                        return PedidosClientesFacturar;
                    }
                    else
                    {
                        MessageBox.Show($"No se encuentran pedidos pendientes a facturar para el cliente [{NombreCliente}]",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return PedidosClientesFacturar;
                    }
                   
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No fue posible buscar los pedidos indicados del cliente. " + Ex.Message, "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return PedidosClientesFacturar;
            }
        }

        public List<SP_BuscarConducesFactura_Result> BuscarConducesFactura(int IDCliente, int IDPedido,
            string ModoReporte, int EstatusPedido, DateTime FechaInicio, DateTime FechaFin, int Conduce)
        {
            try
            {
                using (BAFacturacionEntities FE = new BAFacturacionEntities())
                {
                    ConducesFacturar = FE.SP_BuscarConducesFactura(IDCliente, IDPedido, ModoReporte,
                        EstatusPedido, FechaInicio, FechaFin, Conduce).ToList();
                   
                    return ConducesFacturar;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No fue posible buscar los conduces indicados del cliente. " + Ex.Message, "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return ConducesFacturar;
            }
        }

        public bool InsertarFactura(int TipoFactura, string NCF, int IDCliente, int EsatusFactura,
            double SubtotalFact, double Descuento, double ITBIS, double TotalFactura, int MetodoPago, 
            DateTime FechaFactura, DateTime FechaVencimientoFactura, TimeSpan HoraFactura, string NotaFactura, 
            int Usuario, int Pago, DataGridView dgvPedidoFacturar, DataGridView dgvConduceFactura, DateTime VencimientoNCF)
        {
            try
            {
                using (BAFacturacionEntities FM = new BAFacturacionEntities())
                {
                    
                    FM.SP_InsertarFactura(TipoFactura, NCF, IDCliente, EsatusFactura, SubtotalFact, 
                        TotalFactura, MetodoPago, Descuento,ITBIS, FechaFactura, HoraFactura, FechaVencimientoFactura, 
                        NotaFactura, Usuario, Pago, VencimientoNCF);

                    foreach (DataGridViewRow FilaFactura in dgvPedidoFacturar.Rows)
                    {
                        
           
                            int Pedido = (int)FilaFactura.Cells["NumPedido"].Value;
                            decimal SubTotalFilas = (decimal)FilaFactura.Cells["SubTotal"].Value;
                            decimal FilaDescuento = (decimal)FilaFactura.Cells["Descuento"].Value;
                            decimal FilaITBIS = (decimal)FilaFactura.Cells["ITBIS"].Value;
                            decimal FilaTotalPedidos = (decimal)FilaFactura.Cells["TotalPedido"].Value;
                            string FilaCondicion = FilaFactura.Cells["Condicion"].Value.ToString();
                            string FilaEstatus = FilaFactura.Cells["Estatus"].Value.ToString();

                            FM.SP_InsertarDetallesFactura(SubTotalFilas, FilaDescuento, FilaITBIS, FilaTotalPedidos,
                                FilaCondicion, FilaEstatus, Pedido);
                            FM.SP_CambiarEstadoPedido(IDCliente, 2, IDFactura);
                       

                      
                    }

                    foreach (DataGridViewRow FilaConduces in dgvConduceFactura.Rows)
                    {
               
                            DateTime FechaPedido = (DateTime)FilaConduces.Cells["FechaPedido"].Value;
                            DateTime FechaConduce = (DateTime)FilaConduces.Cells["FechaConduce"].Value;
                            string NombreEmpleado = FilaConduces.Cells["Chofer"].Value.ToString();
                            int NumConduce = (int)FilaConduces.Cells["NumeroConduce"].Value;
                            string NombreVehiculo = FilaConduces.Cells["Vehiculo"].Value.ToString();
                            string Placa = FilaConduces.Cells["Placa"].Value.ToString();
                            decimal Capacidad = (decimal)FilaConduces.Cells["Capacidad"].Value;
                            string NombreProducto = FilaConduces.Cells["Productos"].Value.ToString();
                            int CantidadViajes = (int)FilaConduces.Cells["Viajes"].Value;
                            decimal Cantidad = (decimal)FilaConduces.Cells["Cantidad"].Value;
                            string NombreMedida = FilaConduces.Cells["Medidas"].Value.ToString();
                            decimal Precio = (decimal)FilaConduces.Cells["Precio"].Value;
                            decimal SubTotal = (decimal)FilaConduces.Cells["SubTotal"].Value;
                            decimal FilaITBIS = (decimal)FilaConduces.Cells["ITBIS"].Value;
                            string Descripcion = FilaConduces.Cells["Descripcion"].Value.ToString();
                            string Estatus = FilaConduces.Cells["Estatus"].Value.ToString();

                            FM.SP_InsertarConduces(FechaPedido, FechaConduce, NombreEmpleado, NumConduce, NombreVehiculo, Placa, Capacidad,
                                NombreProducto, CantidadViajes, Cantidad, NombreMedida, Precio, SubTotal, FilaITBIS, Descripcion, Estatus);
                   
                      

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("No fue posible registrar la factura actual. " + ex.Message, "Facturación", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        public int CargarNuevaFactura()
        {
            int Ultimo = 0;
            using (BAFacturacionEntities FT = new BAFacturacionEntities())
            {
                
                try
                {
                    
                    var LastFactNum = FT.VW_VerUltimoNumeroFactura.SingleOrDefault();
                    if (LastFactNum !=null)
                    {
                        Ultimo = Convert.ToInt32(LastFactNum.UltimoNumeroFactura);
                    }
                    else
                    {
                        Ultimo++;
                    }
                    

                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible consultar el número de factura. " + ex.Message, "Facturación",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                return Ultimo;
            }
        }

        public List<SP_VerFacturaID_Result> VerFactura(int NumFactura)
        {
            using (BAFacturacionEntities FT = new BAFacturacionEntities())
            {
                try
                {
                    return FT.SP_VerFacturaID(NumFactura).ToList();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible visualizar la factura " + ex.Message);
                    return null;
                }
            }
        }

        public List<SP_VerDetalleFactura_Result> VerDetallesFactura(int NumFactura)
        {
            using (BAFacturacionEntities FT = new BAFacturacionEntities())
            {
                try
                {
                    return FT.SP_VerDetalleFactura(NumFactura).ToList();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible visualizar el detalle de la factura " + ex.Message);
                    return null;
                }
            }
        }

        public List<SP_VerConduceFacturaDetails_Result> VerDetallesConduceFactura (int NumFactura)
        {
            try
            {
                using(BAFacturacionEntities FT = new BAFacturacionEntities())
                {
                    return FT.SP_VerConduceFacturaDetails(NumFactura).ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No fue posible obtener los detalles del conduce de la factura", "Aviso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return null;

            }
        }

        public List<VW_ListarBancos> ListarBancos()
        {
            using (BAFacturacionEntities FT = new BAFacturacionEntities())
            {
                try
                {
                    return FT.VW_ListarBancos.ToList();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("No fue posible listar los bancos " + Ex.Message);
                    return null;
                }
            }
        }

        public List<VW_ListarMetodos> ListarMetodos()
        {
            using (BAFacturacionEntities FT = new BAFacturacionEntities())
            {
                try
                {
                    return FT.VW_ListarMetodos.ToList();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("No fue posible listar los metodos " + Ex.Message);
                    return null;
                }
            }
        }

        public List<VW_ListaTipoFactura> ListarTipoFactura()
        {
            try
            {
                using(BAFacturacionEntities FT = new BAFacturacionEntities())
                {
                    return FT.VW_ListaTipoFactura.ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No fue posible listar los tipos de factura", "Tipo de Factura", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return null;
            }
        }

        public List<VW_ListaEstatusFactura> ListarEstatusFactura()
        {
            try
            {
                using (BAFacturacionEntities FT = new BAFacturacionEntities())
                {
                    return FT.VW_ListaEstatusFactura.ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No fue posible listar los estatus de factura", "Estatus de Factura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public bool PagarFactura(int idFactura, int idModoPago, string Concepto, int NumCheque, int idBanco, 
            string CuentaOrigen, double TotalPago, DateTime FechaPago, string TipoPago, int Usuario)
        {
            using (BAFacturacionEntities FT = new BAFacturacionEntities())
            {
                try
                {
                    FT.SP_RealizarPagoFactura(idFactura, idModoPago, Concepto, NumCheque, idBanco, CuentaOrigen,
                    TotalPago, FechaPago, TipoPago, Usuario);

                    MessageBox.Show($"La factura {idFactura.ToString().PadLeft(6,'0')} ha sido pagada correctamente", "Pago Efectuado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true;

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("No fue posible aplicar el pago. " + Ex.Message, "Realizar Pago", 
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return false;
                }
            }
        }

        public decimal VerMontoPendienteFactura(int IDFactura)
        {
            using (BAFacturacionEntities FT = new BAFacturacionEntities())
            {
                var MontoPendiente = FT.SP_VerMontoPendienteFactura(IDFactura).SingleOrDefault();
                if (MontoPendiente!=null)
                {
                    return MontoPendiente.Value;
                }
                else
                {
                    return 0;
                }
                
            }
        }

        public void CambiarEstadoPedido(int Cliente, int NuevoEstado, int idFactura)
        {
            try
            {
                using (BAFacturacionEntities FE = new BAFacturacionEntities())
                {
                    FE.SP_CambiarEstadoPedido(Cliente, NuevoEstado, idFactura);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No fue posible realizar cambios en pedidos", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void LimpiarFactura(Control.ControlCollection CamposClientes, Control.ControlCollection CamposTotales, 
            RadioButton OpcionesPago, Control.ControlCollection FechasFactura, CheckBox ChkITBIS, DataGridView dgvPedidos,
            DataGridView dgvConduce)
        {
            var InfoCliente = CamposClientes.OfType<TextBox>().ToList();
            var InfoTotales = CamposTotales.OfType<TextBox>().Where(t=> t.TabStop==false).ToList();
            var Fechas = FechasFactura.OfType<TextBox>().ToList();

            foreach (var item in InfoCliente)
            {
                item.Clear();
            }

            //Reset variables estaticas
            IDCliente = 0;
            NombreCliente = null;
            Correo = null;
            RNC = null;
            Direccion = null;
            Telefonos = null;
            Contactos = null;
            EstatusFactura = 0;
            EstatusPedido = 0;
            IDPedido = 0;
            SubTotalFactura = 0;
            TotalFactura = 0;
            ITBISFactura = 0;
            DescuentoFactura = 0;

            foreach (var item in InfoTotales)
            {
                item.Text = "$0.00";
            }


            foreach (var item in Fechas)
            {
                item.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }

            OpcionesPago.Checked = true;
            ChkITBIS.Checked = false;
            dgvPedidos.DataSource = null;
            dgvConduce.DataSource = null;


 

        }

        public int BuscarIDCliente(string Empresa)
        {
            try
            {
                using (BAFacturacionEntities FM = new BAFacturacionEntities())
                {
                   return FM.SP_BuscarIDCliente(Empresa).Single().Value;
                  
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No fue posible buscar el cliente indicado", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
        }

        public void FormatPedidosFacturar(DataGridViewColumnCollection dgvPedidos, 
            DataGridViewColumnCollection dgvConduce)
        {
            dgvPedidos["SubTotal"].DefaultCellStyle.Format = "C";
            dgvPedidos["TotalPedido"].DefaultCellStyle.Format = "C";
            dgvPedidos["Descuento"].DefaultCellStyle.Format = "C";
            dgvPedidos["ITBIS"].DefaultCellStyle.Format = "C";
            dgvPedidos["SubTotal"].HeaderText = "Sub-Total";
            dgvPedidos["NumPedido"].HeaderText = "Num. Pedido";

            dgvConduce["NumeroConduce"].HeaderText = "Conduce";

        }

        public void FormatPedidosFacturar(DataGridViewRowCollection dgvPedidos,
           DataGridViewRowCollection dgvConduce)
        {
            List<int> FilaPares = new List<int>();
            List<int> FilaImpares = new List<int>();
            for (int i = 0; i < dgvPedidos.Count; i++)
            {
                int Resultado = i % 2;
                if (Resultado!=1)
                {
                    FilaPares.Add(i);
                }
                else
                {
                    FilaImpares.Add(i);
                }
                
            }

            foreach (var item in FilaPares)
            {
                dgvPedidos[item].DefaultCellStyle.BackColor = System.Drawing.Color.Khaki;
            }

            foreach (var item in FilaImpares)
            {
                dgvPedidos[item].DefaultCellStyle.BackColor = System.Drawing.Color.White;
            }

            //Limpiar los valores almacenados
            FilaPares.Clear();
            FilaImpares.Clear();

            for (int i = 0; i < dgvConduce.Count; i++)
            {
                int Resultado = i % 2;
                if (Resultado != 1)
                {
                    FilaPares.Add(i);
                }
                else
                {
                    FilaImpares.Add(i);
                }

            }

            foreach (var item in FilaPares)
            {
                dgvConduce[item].DefaultCellStyle.BackColor = System.Drawing.Color.Khaki;
            }

            foreach (var item in FilaImpares)
            {
                dgvConduce[item].DefaultCellStyle.BackColor = System.Drawing.Color.White;
            }




        }

        public bool ActualizarFactura(int NumFactura, int Tipo, string NCF, int Estatus, int Cliente, decimal SubTotalFactura, decimal Descuento,
            decimal ITBISFactura, decimal TotalFactura, decimal MontoPagado, DateTime FechaFactura, DateTime FechaVencimientoFactura, 
            string NotaFactura,int Conduce, string Chofer, string Vehiculo, string Placa, decimal Capacidad, string Producto, string Descripcion, 
            decimal Cantidad,string Medidas, decimal Precio, decimal SubtotalConduce, decimal ITBISConduce, int Viajes)
        {
            try
            {
                using(BAFacturacionEntities FM = new BAFacturacionEntities())
                {
                    FM.SP_ActualizarFactura(NumFactura,Tipo, NCF, Cliente, Estatus,SubTotalFactura,Descuento,ITBISFactura,TotalFactura,MontoPagado,
                        FechaFactura, FechaVencimientoFactura, NotaFactura, Conduce, Chofer, Vehiculo, Placa, Capacidad, Producto,
                        Descripcion, Cantidad, Medidas, Precio, SubtotalConduce, ITBISConduce, Viajes);
                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No fue posible actualizar la factura con la información provista", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }



        public bool EliminarFactura(int NumFactura)
        {
            try
            {
                using(BAFacturacionEntities FM = new BAFacturacionEntities())
                {
                    FM.SP_EliminarFactura(NumFactura);
                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No fue posible eliminar la factura", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }


    }
}
