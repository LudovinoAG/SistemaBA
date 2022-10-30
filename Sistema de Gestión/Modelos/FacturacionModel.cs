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
        public int NCF { get; set; }
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
        public int Conduce { get; set; }
        public int CantidadChofer { get; set; }
        public int MetodoPago { get; set; }
        public int TipoCliente { get; set; }
        public int TipoFactura { get; set; }
        public int IDCliente { get; set; }
        public int FacturaPagada { get; set; }

        public DateTime FechaVencimientoFactura { get; set; }

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
            dgvFacturar.Rows[NuevoRegistro].Cells["Costo"].Value = string.Format("{0:N}",costo);
            dgvFacturar.Rows[NuevoRegistro].Cells["SubTotal"].Value = string.Format("{0:N}",subtotal);
            

        }

        public void ActualizarTotales(DataGridView dgvFactura, TextBox Subtotales, TextBox TotalGeneral,TextBox ITBIS, 
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
           

            Subtotales.Text = string.Format("{0:N}",this.SumaSubTotales);
            TotalGeneral.Text = string.Format("{0:N}",this.TotalGeneral);
            ITBIS.Text = string.Format("{0:N}", this.ITBIS);
        }

        public List<SP_BuscarClienteCodigo_Result> BuscarClienteCodigo(string CodigoCliente)
        {
            using (BAFacturacionEntities FT = new BAFacturacionEntities())
            {
                try
                {
                    var Cliente = FT.SP_BuscarClienteCodigo(CodigoCliente).ToList();
                    return Cliente;

                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible buscar el cliente " + ex.Message + ex.InnerException);
                    return null;
                }
            }

        }

        public List<VW_EmpleadosFactura> EmpleadosFactura()
        {
            using (BAFacturacionEntities FT = new BAFacturacionEntities())
            {
                try
                {
                    return FT.VW_EmpleadosFactura.ToList();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible cargar los choferes. " + ex.Message);
                    return null;
                }
            }
        }

        public List<VW_ListarVehiculos> VehiculosFactura()
        {
            using (BAFacturacionEntities FT = new BAFacturacionEntities())
            {
                try
                {
                    return FT.VW_ListarVehiculos.ToList();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible cargar los vehiculos. " + ex.Message);
                    return null;
                }
            }
        }

        public List<VW_ListarMedidas> MedidasFactura()
        {
            using (BAFacturacionEntities FT = new BAFacturacionEntities())
            {
                try
                {
                    return FT.VW_ListarMedidas.ToList();
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
            using (BAFacturacionEntities FT = new BAFacturacionEntities())
            {
                try
                {
                    return FT.VW_ProductosFactura.ToList();
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

        public void ResetCamposChofer(Control.ControlCollection controles)
        {
            var CboChofer = controles.OfType<ComboBox>().Where(t => t.Name == "cboChofer");
            var cboVehiculo = controles.OfType<ComboBox>().Where(t => t.Name == "cboVehiculos");
            var txtConduce = controles.OfType<TextBox>().Where(t => t.Name == "txtConduce");

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

            
        }

        public int VerificarMetodoPago(Control.ControlCollection MetodosPagos)
        {
            var Check = MetodosPagos.OfType<RadioButton>().SingleOrDefault(t => t.Checked==true);

            if (Check.Name=="rdbEfectivo")
            {
                this.MetodoPago = 1;
            }
            else if (Check.Name == "rdbCheque")
            {
                this.MetodoPago = 2;
            }
            else if (Check.Name == "rdbCredito")
            {
                this.MetodoPago = 3;
            }
            else if (Check.Name == "rbTransferencia")
            {
                this.MetodoPago = 4;
            }

            return this.MetodoPago;

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


        public bool InsertarFactura(int TipoCliente, int TipoFactura, string NCF, int IDCliente, string RNC,
            string TelCliente, string Nom_Cliente, string Correo, string DirCliente, string contactos, int EsatusFactura, 
            decimal SubtotalFact, decimal Descuento, decimal ITBIS, decimal TotalFactura, int MetodoPago, 
            DateTime FechaFactura, DateTime FechaVencimientoFactura, DateTime HoraFactura, string NotaFactura, 
            int Usuario, DataGridView dgvFactura,DataGridView dgvChoferes)
        {
            try
            {
                using (BAFacturacionEntities FM = new BAFacturacionEntities())
                {
                    FM.SP_InsertarFactura(TipoCliente, TipoFactura, NCF, IDCliente, RNC, TelCliente, contactos,
                        Correo, DirCliente, EsatusFactura, SubtotalFact, TotalFactura, MetodoPago, Descuento,
                        ITBIS, FechaFactura, HoraFactura, FechaVencimientoFactura, NotaFactura, Usuario);

                    foreach (DataGridViewRow FilaFactura in dgvFactura.Rows)
                    {
                        int IDProducto = (int)FilaFactura.Cells["IDProducto"].Value;
                        int CantidadProducto = (int)FilaFactura.Cells["Cantidad"].Value;
                        int IDMedida = (int)FilaFactura.Cells["IDMedida"].Value;
                        string Descripcion = FilaFactura.Cells["Descripción"].Value.ToString();
                        decimal Precio = decimal.Parse(FilaFactura.Cells["Costo"].Value.ToString());
                        decimal SubTotalFilas = decimal.Parse(FilaFactura.Cells["SubTotal"].Value.ToString());

                        FM.SP_InsertarDetallesFactura(IDProducto, CantidadProducto, IDMedida, Descripcion, Precio,
                            SubTotalFilas);
                    }

                    foreach (DataGridViewRow FilaChoferes in dgvChoferes.Rows)
                    {
                        int IDEmpleado = (int)FilaChoferes.Cells["Chofer"].Value;
                        int NumConduce = (int)FilaChoferes.Cells["Conduce"].Value;
                        int IDProducto = (int)FilaChoferes.Cells["id_Producto"].Value;
                        int IDVehiculo = (int)FilaChoferes.Cells["Vehiculo"].Value;
                        int IDMedida = (int)FilaChoferes.Cells["id_Medida"].Value;
                        int CantidadViajes = (int)FilaChoferes.Cells["clCantidadChofer"].Value;

                        FM.SP_InsertarConduces(IDEmpleado, NumConduce, IDProducto, IDVehiculo, IDMedida, CantidadViajes);

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


        public bool ValidarCamposFactura(Control.ControlCollection Controles, 
            Control.ControlCollection PanelChoferes, Control.ControlCollection PanelConduces)
        {
            var TextBoxCliente = Controles.OfType<TextBox>().Where(t => t.TabIndex <= 7);
            var PanelChofer = PanelChoferes.OfType<ComboBox>().OrderBy(t=> t.TabIndex <=2);
            var Conduce = PanelChoferes.OfType<TextBox>().Where(t=> t.Tag.ToString()=="Conduce").SingleOrDefault();
            var GridFactura = Controles.OfType<DataGridView>();
            var dgvConduces = PanelConduces.OfType<DataGridView>();

            foreach (var item in TextBoxCliente)
            {
                if (string.IsNullOrEmpty(item.Text))
                {
                    MessageBox.Show($"El campo {item.Tag} no puede estar vacio","Atencion",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            foreach (var item in GridFactura)
            {
                if (item.Rows.Count==0)
                {
                    MessageBox.Show($"Debe agregar algun producto a la factura", "Atencion",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            foreach (var item in dgvConduces)
            {
                if (item.Rows.Count == 0)
                {
                    MessageBox.Show($"Debe agregar a la factura un conduce", "Atencion",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            return true;

        }

        public void LimpiarFactura(Control.ControlCollection Controles, DataGridView Choferes, DataGridView Factura, 
            DataGridView ListaChoferes, CheckBox ITBIS, RadioButton Efectivo)
        {
            var TextBoxClientes = Controles.OfType<TextBox>().Where(t => t.TabIndex <= 7);
            var TextBoxMontos = Controles.OfType<TextBox>().Where(t => t.Tag.ToString()=="Totales");
            

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
            Efectivo.Checked = true;

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

        public bool PagarFactura(int idFactura, int idModoPago, string Concepto, int NumCheque, int idBanco, 
            string CuentaOrigen, decimal TotalPago, DateTime FechaPago, string TipoPago)
        {
            using (BAFacturacionEntities FT = new BAFacturacionEntities())
            {
                try
                {
                    FT.SP_RealizarPagoFactura(idFactura, idModoPago, Concepto, NumCheque, idBanco, CuentaOrigen,
                    TotalPago, FechaPago, TipoPago);

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

    }
}
