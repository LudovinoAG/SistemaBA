using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gestión.Modelos
{
    class PedidosModel
    {

        public decimal SubTotal { get; set; }
        public decimal Costo { get; set; }

        public decimal ITBISPro { get; set; }
        public decimal CapacidadTotal { get; set; }

        public decimal capacidad { get; set; }
        public decimal Cantidad { get; set; }
        public decimal SumaSubTotales { get; set; }
        public decimal ITBIS { get; set; }
        public decimal DESC { get; set; }
        public decimal TotalGeneral { get; set; }
        public int IDChofer { get; set; }
        public int IDProducto { get; set; }
        public int IDVehiculo { get; set; }
        public int IDMedida { get; set; }
        public int IDFactura { get; set; }
        public int IDConduce { get; set; }
        public int Conduce { get; set; }
        public static string Placa { get; set; }
        public static int CantidadChofer { get; set; }
        public decimal OrometroInicio { get; set; }
        public decimal OrometroFinal { get; set; }

        public int MetodoPago { get; set; }
        public int TipoCliente { get; set; }
        public int TipoFactura { get; set; }
        public int IDCliente { get; set; }
        public int EstatusPedido { get; set; }

        public int CountPedidos { get; set; }

        public static string Empresa { get; set; }
        public static string Rnc { get; set; }
        public static string NombreContacto { get; set; }
        public static string TelContacto { get; set; }
        public static string Direccion { get; set; }
        public static string Correo { get; set; }
        public static string Condiciones { get; set; }

        public int IDBuscadoMatricula { get; set; }

        public DateTime FechaConduce { get; set; }

        public void AgregarProducto(decimal cantidad, int IDProducto, string medida, int IDMedida, 
            string producto, string descripcion, decimal costo, decimal subtotal, decimal ITBISProducto, DataGridView dgvFacturar)
        {
            int NuevoRegistro = dgvFacturar.Rows.Add();
            dgvFacturar.Rows[NuevoRegistro].Cells["Cantidad"].Value = cantidad;
            dgvFacturar.Rows[NuevoRegistro].Cells["IDProducto"].Value = IDProducto;
            dgvFacturar.Rows[NuevoRegistro].Cells["Medida"].Value = medida;
            dgvFacturar.Rows[NuevoRegistro].Cells["IDMedida"].Value = IDMedida;
            dgvFacturar.Rows[NuevoRegistro].Cells["Producto"].Value = producto;
            dgvFacturar.Rows[NuevoRegistro].Cells["ITBISProducto"].Value = ITBISProducto;
            dgvFacturar.Rows[NuevoRegistro].Cells["CNum"].Value = NuevoRegistro;

            if (IDMedida==2)
            {
                dgvFacturar.Rows[NuevoRegistro].Cells["Descripción"].Value = ($"Alquiler de {descripcion}");
            }
            else if (IDMedida == 1)
            {
                dgvFacturar.Rows[NuevoRegistro].Cells["Descripción"].Value = descripcion;
            }
            
            dgvFacturar.Rows[NuevoRegistro].Cells["Costo"].Value = string.Format("{0:N}", costo);
            dgvFacturar.Rows[NuevoRegistro].Cells["SubTotal"].Value = string.Format("{0:N}", subtotal);


        }

        public void ActualizarTotales(DataGridView dgvFactura, TextBox Subtotales, TextBox TotalGeneral, TextBox ITBIS,
           CheckBox CKITBIS)
        {
            this.SumaSubTotales = 0;
            this.ITBISPro = 0;
            if (CKITBIS.CheckState == CheckState.Checked)
            {
                for (var i = 0; i < dgvFactura.Rows.Count; i++)
                {

                    //string[] Valor = dgvFactura.Rows[i].Cells["SubTotal"].Value.ToString().Split('$');
                    this.SumaSubTotales += Convert.ToDecimal(dgvFactura.Rows[i].Cells["SubTotal"].Value);
                    this.ITBISPro += Convert.ToDecimal(dgvFactura.Rows[i].Cells["ITBISProducto"].Value);
                    this.TotalGeneral = (this.SumaSubTotales - this.DESC) + this.ITBISPro;
                }
            }
            else
            {
                for (var i = 0; i < dgvFactura.Rows.Count; i++)
                {

                    //string[] Valor = dgvFactura.Rows[i].Cells["SubTotal"].Value.ToString().Split('$');
                    this.SumaSubTotales += Convert.ToDecimal(dgvFactura.Rows[i].Cells["SubTotal"].Value);
                    this.ITBISPro = 0.00m;
                    this.TotalGeneral = (this.SumaSubTotales - this.DESC) + this.ITBISPro;
                }
            }


            Subtotales.Text = string.Format("{0:N}", this.SumaSubTotales);
            TotalGeneral.Text = string.Format("{0:N}", this.TotalGeneral);
            ITBIS.Text = string.Format("{0:N}", this.ITBISPro);
        }

        public void AgregarChoferFactura(DataGridView dgvChoferes, int IDFila, int Conduce, int Chofer,
          int Vehiculo, int Producto, int Medida, int Factura, int CantidadViaje, decimal Capacidad, string Placa,
          decimal OrometroInicio, decimal OrometroFinal, DateTime FechaConduce)
        {
            //Tabla de informacion referencial
            int entradachoferes = dgvChoferes.Rows.Add();
            dgvChoferes.Rows[entradachoferes].Cells["ID"].Value = IDFila;
            dgvChoferes.Rows[entradachoferes].Cells["Conduce"].Value = Conduce;
            dgvChoferes.Rows[entradachoferes].Cells["Chofer"].Value = Chofer;
            dgvChoferes.Rows[entradachoferes].Cells["Vehiculo"].Value = Vehiculo;
            dgvChoferes.Rows[entradachoferes].Cells["id_Producto"].Value = Producto;
            dgvChoferes.Rows[entradachoferes].Cells["id_Medida"].Value = Medida;
            dgvChoferes.Rows[entradachoferes].Cells["id_Factura"].Value = Factura;
            dgvChoferes.Rows[entradachoferes].Cells["clCantidadChofer"].Value = CantidadViaje;
            dgvChoferes.Rows[entradachoferes].Cells["clSCapacidad"].Value = Capacidad;
            dgvChoferes.Rows[entradachoferes].Cells["Placa"].Value = Placa;
            dgvChoferes.Rows[entradachoferes].Cells["clOrometroInicio"].Value = OrometroInicio;
            dgvChoferes.Rows[entradachoferes].Cells["clOrometroFinal"].Value = OrometroFinal;
            dgvChoferes.Rows[entradachoferes].Cells["cFechaConduce"].Value = FechaConduce;


        }

        public void ResetCamposChofer(Control.ControlCollection controles)
        {
            var CboChofer = controles.OfType<ComboBox>().ToList();
            var cboVehiculo = controles.OfType<ComboBox>().ToList();
            var txtConduce = controles.OfType<TextBox>().ToList();
            var UDViajes = controles.OfType<NumericUpDown>().Where(t => t.Name == "UDViajes").SingleOrDefault();
            var DatePick = controles.OfType<DateTimePicker>().ToList();

            if (CboChofer!=null)
            {
                foreach (var item in CboChofer)
                {
                    item.SelectedIndex = 0;
                }
            }

            if (cboVehiculo!=null)
            {
                foreach (var item in cboVehiculo)
                {
                    item.SelectedIndex = 0;
                }
            }


            if (UDViajes!=null)
            {
                UDViajes.Value = 1;
            }

            if (txtConduce != null)
            {
                foreach (var item in txtConduce)
                {
                    item.Text = "0";
                }
            }

            if (DatePick!=null)
            {
                foreach (var item in DatePick)
                {
                    item.Value = DateTime.Now;
                }
            }
            


        }

        public void LimpiarPedido(Control.ControlCollection Controles, DataGridView Choferes, DataGridView Factura,
            DataGridView ListaChoferes, CheckBox ITBIS)
        {
            var TextBoxClientes = Controles.OfType<TextBox>().Where(t => t.TabIndex <= 7);
            var TextBoxMontos = Controles.OfType<TextBox>().Where(t => Convert.ToString(t.Tag) == "Totales");


            foreach (var item in TextBoxClientes)
            {
                item.Clear();
            }

            foreach (DataGridViewRow item in Factura.Rows)
            {
                Factura.Rows.Clear();
            }

            foreach (DataGridViewRow item in Choferes.Rows)
            {
                Choferes.Rows.Clear();
            }

            foreach (DataGridViewRow item in ListaChoferes.Rows)
            {
                ListaChoferes.Rows.Clear();
            }

            foreach (var item in TextBoxMontos)
            {
                item.Text = "0.00";
            }

            //Marcar el ITBIS por defecto.
            ITBIS.Checked = true;

        }

        public bool InsertarPedido(int IDCliente, int idConduce, int idEstatusPedido,decimal SubTotal, 
            decimal totalPedido, decimal ITBISPedido,decimal DescuentoPedido,
            DataGridView dgvFactura,DataGridView dgvChoferes, DataGridView dgvListaChoferes)
        {
            try
            {
                using (BAPedidosEntities PM = new BAPedidosEntities())
                {
                    PM.SP_InsertarPedido(IDCliente, idEstatusPedido, SubTotal, totalPedido, 
                        ITBISPedido,DescuentoPedido,Condiciones);

                    //PM.SP_InsertarFacturaProforma(IDCliente, Empresa, Rnc, NombreContacto, TelContacto,
                    //    Direccion, Correo, Condiciones);

                    //int RegPedidos = FilaPedidos.Index + 1;
                    int totalPedidos = dgvFactura.Rows.Count;
                        int totalConduces = dgvChoferes.Rows.Count;


                        for (int i = 0; i < totalPedidos; i++)
                        {
                            //int ID_Detalles_Pedido = (int)PM.VW_VerUltimoNumeroPedido.SingleOrDefault().UltimoNumeroPedido;

                            int IDProducto = (int)dgvFactura.Rows[i].Cells["IDProducto"].Value;
                            decimal CantidadProducto = (decimal)dgvFactura.Rows[i].Cells["Cantidad"].Value;
                            int IDMedida = (int)dgvFactura.Rows[i].Cells["IDMedida"].Value;
                            string PedidoDescripcion = dgvFactura.Rows[i].Cells["Descripción"].Value.ToString();
                            decimal PrecioPedido = decimal.Parse(dgvFactura.Rows[i].Cells["Costo"].Value.ToString());
                            decimal SubTotalFilas = decimal.Parse(dgvFactura.Rows[i].Cells["SubTotal"].Value.ToString());
                            decimal ITBISProducto = decimal.Parse(dgvFactura.Rows[i].Cells["ITBISProducto"].Value.ToString());

                        for (int c = 0; c < totalConduces; c++)
                            {

                                if ((dgvFactura.Rows[i].Index)+1 == (int)dgvChoferes.Rows[c].Cells["ID"].Value)
                                {
                                    int RegPedidos = i + 1;
                                    int RegConduces = c + 1;

                                    PM.SP_InsertarDetallesPedido(RegPedidos, IDCliente, IDProducto, IDMedida, CantidadProducto,
                                        PrecioPedido, SubTotalFilas, PedidoDescripcion, RegConduces, ITBISProducto);

                                    int IDEmpleado = (int)dgvChoferes.Rows[c].Cells["Chofer"].Value;
                                    int NumConduce = Convert.ToInt32(dgvListaChoferes.Rows[c].Cells["clConduce"].Value);
                                    IDProducto = (int)dgvChoferes.Rows[c].Cells["id_Producto"].Value;
                                    int IDVehiculo = (int)dgvChoferes.Rows[c].Cells["Vehiculo"].Value;
                                    IDMedida = (int)dgvChoferes.Rows[c].Cells["id_Medida"].Value;
                                    int CantidadViajesPedido = (int)dgvChoferes.Rows[c].Cells["clCantidadChofer"].Value;
                                    decimal OrometroInicio = (decimal)dgvChoferes.Rows[c].Cells["clOrometroInicio"].Value;
                                    decimal OrometroFinal = (decimal)dgvChoferes.Rows[c].Cells["clOrometroFinal"].Value;
                                    DateTime FechaConduce = (DateTime)dgvChoferes.Rows[c].Cells["cFechaConduce"].Value;
                                    decimal CapacidadConduce = (decimal)dgvChoferes.Rows[c].Cells["clsCapacidad"].Value;

                                

                                PM.SP_InsertarConducesPedidos(IDCliente, IDEmpleado, NumConduce, IDProducto, IDVehiculo, IDMedida,
                                    CantidadViajesPedido, RegConduces, OrometroInicio, OrometroFinal, FechaConduce, CapacidadConduce);

                                    using(BARedaccionesEntities RM = new BARedaccionesEntities())
                                    {
                                        string Placa = dgvChoferes.Rows[c].Cells["Placa"].Value.ToString();
                                        string NameProducto = dgvListaChoferes.Rows[c].Cells["clProducto"].Value.ToString();
                                        decimal Capacidad = (decimal)dgvChoferes.Rows[c].Cells["clsCapacidad"].Value;
                                        string Medida = dgvListaChoferes.Rows[c].Cells["clMedida"].Value.ToString();
                                        decimal m3Total = Capacidad * CantidadViajesPedido;
                                        //decimal Total = PrecioPedido * m3Total;
                                    
                                        RM.SP_InsertarRedaccion(Placa, NumConduce, NameProducto, 
                                            CantidadViajesPedido,Capacidad, Medida, m3Total, PrecioPedido,
                                            totalPedido, IDCliente,1);
                                    }

                                }

                            }

                        }

                    this.TotalGeneral = 0;
                    this.SumaSubTotales = 0;

                }

                
            }
            catch (Exception ex)
            {

                MessageBox.Show("No fue posible registrar el pedido actual. " + ex.Message + ex.InnerException, "Pedidos", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        public bool ValidarCamposFactura(Control.ControlCollection Controles,
           Control.ControlCollection PanelChoferes, Control.ControlCollection PanelConduces)
        {
            var TextBoxCliente = Controles.OfType<TextBox>().Where(t => t.TabIndex <= 7);
            var PanelChofer = PanelChoferes.OfType<ComboBox>().OrderBy(t => t.TabIndex <= 2);
            var Conduce = PanelChoferes.OfType<TextBox>().Where(t => t.Tag.ToString() == "Conduce").SingleOrDefault();
            var GridFactura = Controles.OfType<DataGridView>();
            var dgvConduces = PanelConduces.OfType<DataGridView>();

            foreach (var item in TextBoxCliente)
            {
                if (string.IsNullOrEmpty(item.Text))
                {
                    MessageBox.Show($"El campo {item.Tag} no puede estar vacio", "Atencion",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            foreach (var item in GridFactura)
            {
                if (item.Rows.Count == 0)
                {
                    MessageBox.Show($"Debe agregar algun producto al pedido", "Atencion",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            foreach (var item in dgvConduces)
            {
                if (item.Rows.Count == 0)
                {
                    MessageBox.Show($"Debe agregar al pedido un conduce", "Atencion",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            return true;

        }

        public bool ActualizarPedidos(int Pedido, int Cliente, int idConduce, int DetallesPedidos, int NumConduce, decimal Cantidad, int Medidas,
            int Producto, string Descripcion, decimal Costo, decimal Subtotal, decimal ITBIS, DateTime FechaConduce, int Chofer, 
            int Vehiculo, int Viajes)
        {
            try
            {
                using(BAPedidosEntities PE = new BAPedidosEntities())
                {
                    PE.SP_ActualizarPedidos(Pedido, Cliente, idConduce, DetallesPedidos, NumConduce, Cantidad, Medidas, Producto,
                        Descripcion, Costo, Subtotal, ITBIS, FechaConduce, Chofer, Vehiculo, Viajes);

                    return true;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No fue posible actualizar el pedido indicado " + Ex.Message, "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }
        }


        public bool EliminarPedidos(int Pedido, int Cliente, int idConduce, int DetallesPedidos)
        {
            try
            {
                using(BAPedidosEntities PE = new BAPedidosEntities())
                {
                    PE.SP_DeleteInfoPedidos(Pedido, Cliente, idConduce, DetallesPedidos);
                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No fue posible eliminar el pedido indicado", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }
        }

        public int CargarNuevoPedido()
        {
            int Ultimo = 0;
            using (BAPedidosEntities FT = new BAPedidosEntities())
            {

                try
                {

                    var LastPedidosNum = FT.VW_VerUltimoNumeroPedido.SingleOrDefault();
                    if (LastPedidosNum != null)
                    {
                        Ultimo = Convert.ToInt32(LastPedidosNum.UltimoNumeroPedido);
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

        public List<SP_BuscarClienteCodigo_Result> BuscarClienteCodigo(string CodigoCliente)
        {
            using (BAPedidosEntities PM = new BAPedidosEntities())
            {
                try
                {
                    var Cliente = PM.SP_BuscarClienteCodigo(CodigoCliente).ToList();
                    return Cliente;

                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible buscar el cliente " + ex.Message + ex.InnerException);
                    return null;
                }
            }

        }

        public List<VW_ListarVehiculos> VehiculosFactura()
        {
            using (BAPedidosEntities PM = new BAPedidosEntities())
            {
                try
                {
                    return PM.VW_ListarVehiculos.ToList();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible cargar los vehiculos. " + ex.Message);
                    return null;
                }
            }
        }

        public List<VW_ListarVehiculos> VehiculosFactura(string Matricula)
        {
            if (Matricula!="")
            {
                using (BAPedidosEntities PM = new BAPedidosEntities())
                {
                    try
                    {
                        IDBuscadoMatricula = PM.VW_ListarVehiculos.Where(t => t.Matricula == Matricula).SingleOrDefault().ID;
                        return PM.VW_ListarVehiculos.ToList();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"No fue posible encontrar el vehiculo por la placa [{Matricula}]." + ex.Message);
                        return null;
                    }
                }
            }
            else
            {
                return null;
            }
           
        }

        public List<VW_EmpleadosFactura> EmpleadosFactura()
        {
            using (BAPedidosEntities PM = new BAPedidosEntities())
            {
                try
                {
                    return PM.VW_EmpleadosFactura.ToList();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible cargar los choferes. " + ex.Message);
                    return null;
                }
            }
        }

        public List<VW_ListarMedidas> MedidasFactura()
        {
            using (BAPedidosEntities PM = new BAPedidosEntities())
            {
                try
                {
                    return PM.VW_ListarMedidas.ToList();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible cargar las Medidas. " + ex.Message);
                    return null;
                }
            }
        }

        public List<VW_ProductosFactura> ProductosFactura()
        {
            using (BAPedidosEntities PM = new BAPedidosEntities())
            {
                try
                {
                    return PM.VW_ProductosFactura.ToList();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible cargar los productos en la factura. " + ex.Message);
                    return null;
                }
            }
        }

        public int BuscarConduce(int conduce)
        {
            try
            {
                using(BAPedidosEntities PE = new BAPedidosEntities())
                {
                    var resultado = PE.SearchConduce(conduce).ToList();
                    if (resultado.Count!=0)
                    {
                        return 1;
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No fue posible realizar la búsqueda del conduce. " + Ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return 0;
        }
        public decimal CalcularSubtotal(int Medida, decimal cantidad, decimal costo)
        {

                this.Cantidad = cantidad;
                this.Costo = costo;
                this.SubTotal = 0;
                this.SubTotal = this.Costo * this.Cantidad;
                this.ITBISPro = this.SubTotal * 0.18m;

                return this.SubTotal;


        }

        public bool ConduceExiste (int Conduce, DataGridView dgvChoferes)
        {
            for(int i = 0;i < dgvChoferes.Rows.Count; i++)
            {
                if ((int)dgvChoferes.Rows[i].Cells["Conduce"].Value == Conduce)
                {
                    MessageBox.Show($"El conduce [{Conduce}] ya existe en el detalle de este pedido.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return true;
                }

            }

            int ResulConduce = BuscarConduce(Conduce);

            if (ResulConduce != 0)
            {
                MessageBox.Show($"El conduce [{Conduce}] ya se encuentra asociado a un cliente, \n" +
                    $"por favor valide o introduzca un nuevo conduce", "Aviso",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return true;
            }

            return false;
        }

    }
}
