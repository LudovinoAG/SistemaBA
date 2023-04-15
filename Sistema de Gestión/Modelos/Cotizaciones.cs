using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Gestión.Modelos;
using System.Windows.Forms;

namespace Sistema_de_Gestión.Modelos
{
    class Cotizaciones
    {
        public static double SubTotalCotizacion { get; set; }
        public static double TotalGeneralCotizacion { get; set; }
        public static double ITBISCotizacion { get; set; }

        public static int IDCliente { get; set; }

        public List<SP_BuscarClienteCodigo_Result> BuscarCliente { get; set; }

        public List<SP_BuscarClienteCodigo_Result> SPBuscarCliente(string CodCliente)
        {
            try
            {
                using(BAFacturacionEntities FE = new BAFacturacionEntities())
                {
                    BuscarCliente = FE.SP_BuscarClienteCodigo(CodCliente).ToList();
                    if (BuscarCliente.Count!=0)
                    {
                        IDCliente = BuscarCliente.SingleOrDefault().ID_Cliente;
                    }
                    else
                    {
                        MessageBox.Show($"No se ha encontrado el cliente [C{CodCliente.PadLeft(6,'0')}]", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    
                    return BuscarCliente;
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"No fue posible buscar el cliente indicado en el sistema","Aviso",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                return BuscarCliente;
            }
        }

        public void AgregarProductoCotizacion(int cantidad, int IDProducto, string medida, int IDMedida, string producto, string descripcion, decimal costo,
           decimal subtotal, DataGridView dgvCotizacion)
        {
   
            if (IDProducto!=1)
            {
                int NuevoRegistro = dgvCotizacion.Rows.Add();
                dgvCotizacion.Rows[NuevoRegistro].Cells["Cantidad"].Value = cantidad;
                dgvCotizacion.Rows[NuevoRegistro].Cells["IDProducto"].Value = IDProducto;
                dgvCotizacion.Rows[NuevoRegistro].Cells["Medida"].Value = medida;
                dgvCotizacion.Rows[NuevoRegistro].Cells["IDMedida"].Value = IDMedida;
                dgvCotizacion.Rows[NuevoRegistro].Cells["Producto"].Value = producto;
                dgvCotizacion.Rows[NuevoRegistro].Cells["Descripción"].Value = descripcion;
                dgvCotizacion.Rows[NuevoRegistro].Cells["Costo"].Value = string.Format("{0:N}", costo);
                dgvCotizacion.Rows[NuevoRegistro].Cells["SubTotal"].Value = string.Format("{0:N}", subtotal);
                SubTotalCotizacion += (double)subtotal;
            }
            else
            {
                MessageBox.Show("Debe indicar un producto válido", "Agregar Producto",MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);
            }
            

        }

        public bool InsertarCotizacion(int idCliente, double Descuento, double SubTotalCotiza, double ITBIS,
            double TotalCotizacion, DateTime FechaCotizacion, DateTime HoraCotizacion, int idUsuario,
            DataGridView dgvCotizacion)
        {
            try
            {
                using (BACotizacionesEntities CT = new BACotizacionesEntities())
                {
                    CT.SP_InsertarCotizacion(idCliente, Descuento, SubTotalCotiza, ITBIS, TotalCotizacion,
                        FechaCotizacion, HoraCotizacion, idUsuario);

                    foreach (DataGridViewRow FilaCotizacion in dgvCotizacion.Rows)
                    {
                        int IDProducto = (int)FilaCotizacion.Cells["IDProducto"].Value;
                        int CantidadProducto = (int)FilaCotizacion.Cells["Cantidad"].Value;
                        int IDMedida = (int)FilaCotizacion.Cells["IDMedida"].Value;
                        string Descripcion = FilaCotizacion.Cells["Descripción"].Value.ToString();
                        decimal Precio = decimal.Parse(FilaCotizacion.Cells["Costo"].Value.ToString());
                        decimal SubTotalFilas = decimal.Parse(FilaCotizacion.Cells["SubTotal"].Value.ToString());

                        CT.SP_InsertarDetallesCotizacion(CantidadProducto, IDMedida, IDProducto, Descripcion,
                            Precio, SubTotalFilas);
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("No fue posible registrar la cotización actual. " + ex.Message, "Cotización", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        public void LimpiarCotizacion(Control.ControlCollection Controles, DataGridView Cotizacion,CheckBox ITBIS)
        {
            var TextBoxClientes = Controles.OfType<TextBox>().Where(t=> t.TabIndex >=1 && t.TabIndex <=7);
            var TextBoxMontos = Controles.OfType<TextBox>().Where(t => t.TabIndex >= 8 && t.TabIndex <=11);


            foreach (var item in TextBoxClientes)
            {
                item.Clear();
            }

            foreach (DataGridViewRow item in Cotizacion.Rows)
            {
                Cotizacion.Rows.Clear();
            }


            foreach (var item in TextBoxMontos)
            {
                item.Text = "0.00";
            }

            //Marcar el ITBIS por defecto.
            ITBIS.Checked = true;

        }

        public int CargarNuevaCotizacion()
        {
            int Ultimo = 0;
            using (BACotizacionesEntities CT = new BACotizacionesEntities())
            {

                try
                {

                    var LastCotizaNum = CT.VW_VerUltimoNumeroCotizacion.SingleOrDefault();
                    if (LastCotizaNum != null)
                    {
                        Ultimo = Convert.ToInt32(LastCotizaNum.UltimoNumeroCotizacion);
                    }
                    else
                    {
                        Ultimo++;
                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible consultar el número de Cotización. " + ex.Message, "Cotización",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                return Ultimo;
            }
        }

        public List<VW_ListarMedidas> LoadMedidas { get; set; }

        public List<VW_ProductosFactura> LoadProductos { get; set; }

        public List<VW_ListarMedidas> BuscarMedidas()
        {
            try
            {
                using(BAPedidosEntities PE = new BAPedidosEntities())
                {
                    LoadMedidas = PE.VW_ListarMedidas.ToList();
                    return LoadMedidas;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No fue posible cargar las medidas." + Ex.Message, "Avsio",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return LoadMedidas;
            }
        }

        public List<VW_ProductosFactura> BuscarProductos()
        {
            try
            {
                using (BAFacturacionEntities PE = new BAFacturacionEntities())
                {
                    LoadProductos = PE.VW_ProductosFactura.ToList();
                    return LoadProductos;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No fue posible cargar los productos." + Ex.Message, "Avsio",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return LoadProductos;
            }
        }



    }
}
