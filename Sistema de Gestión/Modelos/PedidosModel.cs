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
        public int Cantidad { get; set; }
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
        public static int CantidadChofer { get; set; }
        public int MetodoPago { get; set; }
        public int TipoCliente { get; set; }
        public int TipoFactura { get; set; }
        public int IDCliente { get; set; }
        public int EstatusPedido { get; set; }


        public void AgregarProducto(int cantidad, int IDProducto, string medida, int IDMedida, string producto, string descripcion, decimal costo,
           decimal subtotal, DataGridView dgvFacturar)
        {
            int NuevoRegistro = dgvFacturar.Rows.Add();
            dgvFacturar.Rows[NuevoRegistro].Cells["Cantidad"].Value = cantidad;
            dgvFacturar.Rows[NuevoRegistro].Cells["IDProducto"].Value = IDProducto;
            dgvFacturar.Rows[NuevoRegistro].Cells["Medida"].Value = medida;
            dgvFacturar.Rows[NuevoRegistro].Cells["IDMedida"].Value = IDMedida;
            dgvFacturar.Rows[NuevoRegistro].Cells["Producto"].Value = producto;
            dgvFacturar.Rows[NuevoRegistro].Cells["Descripción"].Value = descripcion;
            dgvFacturar.Rows[NuevoRegistro].Cells["Costo"].Value = string.Format("{0:N}", costo);
            dgvFacturar.Rows[NuevoRegistro].Cells["SubTotal"].Value = string.Format("{0:N}", subtotal);


        }

        public void ActualizarTotales(DataGridView dgvFactura, TextBox Subtotales, TextBox TotalGeneral, TextBox ITBIS,
           CheckBox CKITBIS)
        {
            this.SumaSubTotales = 0;
            if (CKITBIS.CheckState == CheckState.Checked)
            {
                for (var i = 0; i < dgvFactura.Rows.Count; i++)
                {

                    //string[] Valor = dgvFactura.Rows[i].Cells["SubTotal"].Value.ToString().Split('$');
                    this.SumaSubTotales += Convert.ToDecimal(dgvFactura.Rows[i].Cells["SubTotal"].Value);
                    this.ITBIS = (this.SumaSubTotales - this.DESC) * 18 / 100;
                    this.TotalGeneral = (this.SumaSubTotales - this.DESC) + this.ITBIS;
                }
            }
            else
            {
                for (var i = 0; i < dgvFactura.Rows.Count; i++)
                {

                    //string[] Valor = dgvFactura.Rows[i].Cells["SubTotal"].Value.ToString().Split('$');
                    this.SumaSubTotales += Convert.ToDecimal(dgvFactura.Rows[i].Cells["SubTotal"].Value);
                    this.ITBIS = 0.00m;
                    this.TotalGeneral = (this.SumaSubTotales - this.DESC) + this.ITBIS;
                }
            }


            Subtotales.Text = string.Format("{0:N}", this.SumaSubTotales);
            TotalGeneral.Text = string.Format("{0:N}", this.TotalGeneral);
            ITBIS.Text = string.Format("{0:N}", this.ITBIS);
        }

        public void AgregarChoferFactura(DataGridView dgvChoferes, int IDFila, int Conduce, int Chofer,
          int Vehiculo, int Producto, int Medida, int Factura, int CantidadViaje)
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

        }

        public void ResetCamposChofer(Control.ControlCollection controles)
        {
            var CboChofer = controles.OfType<ComboBox>().Where(t => t.Name == "cboChofer");
            var cboVehiculo = controles.OfType<ComboBox>().Where(t => t.Name == "cboVehiculos");
            var txtConduce = controles.OfType<TextBox>().Where(t => t.Name == "txtConduce");
            var UDViajes = controles.OfType<NumericUpDown>().Where(t => t.Name == "UDViajes").SingleOrDefault();

            foreach (var item in CboChofer)
            {
                item.SelectedIndex = 0;
            }

            foreach (var item in cboVehiculo)
            {
                item.SelectedIndex = 0;
            }

            foreach (var item in txtConduce)
            {
                item.Text = "0";
            }

            UDViajes.Value = 1;


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
            DataGridView dgvFactura,DataGridView dgvChoferes)
        {
            try
            {
                using (BAPedidosEntities PM = new BAPedidosEntities())
                {
                    PM.SP_InsertarPedido(IDCliente, idEstatusPedido, SubTotal, totalPedido, 
                        ITBISPedido,DescuentoPedido);

                    foreach (DataGridViewRow FilaPedidos in dgvFactura.Rows)
                    {
                        int IDProducto = (int)FilaPedidos.Cells["IDProducto"].Value;
                        int CantidadProducto = (int)FilaPedidos.Cells["Cantidad"].Value;
                        int IDMedida = (int)FilaPedidos.Cells["IDMedida"].Value;
                        string PedidoDescripcion = FilaPedidos.Cells["Descripción"].Value.ToString();
                        decimal PrecioPedido = decimal.Parse(FilaPedidos.Cells["Costo"].Value.ToString());
                        decimal SubTotalFilas = decimal.Parse(FilaPedidos.Cells["SubTotal"].Value.ToString());

                        PM.SP_InsertarDetallesPedido(IDProducto, IDMedida, CantidadProducto, PrecioPedido, SubTotalFilas,
                            PedidoDescripcion);
                    }

                    foreach (DataGridViewRow FilaChoferes in dgvChoferes.Rows)
                    {
                        int IDEmpleado = (int)FilaChoferes.Cells["Chofer"].Value;
                        int NumConduce = (int)FilaChoferes.Cells["Conduce"].Value;
                        int IDProducto = (int)FilaChoferes.Cells["id_Producto"].Value;
                        int IDVehiculo = (int)FilaChoferes.Cells["Vehiculo"].Value;
                        int IDMedida = (int)FilaChoferes.Cells["id_Medida"].Value;
                        int CantidadViajesPedido = (int)FilaChoferes.Cells["clCantidadChofer"].Value;

                        PM.SP_InsertarConducesPedidos(IDEmpleado, NumConduce, IDProducto, IDVehiculo, IDMedida, 
                            CantidadViajesPedido);

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("No fue posible registrar el pedido actual. " + ex.Message, "Pedidos", MessageBoxButtons.OK,
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

        public decimal CalcularSubtotal(int cantidad, decimal costo)
        {

            this.Cantidad = cantidad;
            this.Costo = costo;
            this.SubTotal = 0;
            this.SubTotal = this.Costo * this.Cantidad;

            return this.SubTotal;
        }



    }
}
