using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Gestión.Modelos;
using System.Windows.Forms;

namespace Sistema_de_Gestión.Modelos
{
    class ReportesModel
    {
        public int Cliente { get; set; }
        public string ModoReporte { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public static int NumFacturaReporte { get; set; }

        public List<VW_VerFacturas> VerFactura { get; set; }

        public List<SP_VerFacturaID_Result> VerFacturaID { get; set; }

        public List<SP_BuscarClienteCodigo_Result> Clientes { get; set; }

        public List<SP_ReporteConducesRegistrados_Result> ConducesRegistrados { get; set; }

        public List<SP_BuscarClienteCodigo_Result> BuscarClientes(string codigoCliente)
        {
            try
            {
                using (BAFacturacionEntities BC = new BAFacturacionEntities())
                {
                    Clientes = BC.SP_BuscarClienteCodigo(codigoCliente).ToList();
                    return Clientes;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No fue posible buscar el cliente indicado","Aviso",MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return Clientes;
            }
        }

        public List<SP_ReporteConducesRegistrados_Result> VerConducesRegistrados(int Cliente, string ModoReporte, DateTime FechaInicio, DateTime FechaFin)
        {
            try
            {
                using (BAReportesEntities RE = new BAReportesEntities())
                {
                    ConducesRegistrados = RE.SP_ReporteConducesRegistrados(Cliente, ModoReporte, FechaInicio, FechaFin).ToList();
                    return ConducesRegistrados.ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No fue posible buscar los conduces registrados","Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return ConducesRegistrados.ToList();
            }
        }

        public void BuscarFactura(DataGridView dgvReporteFacturas, int NumFactura)
        {
            if (NumFactura.ToString()!="")
            {
                using (BAFacturacionEntities RE = new BAFacturacionEntities())
                {

                    try
                    {


                       VerFacturaID = RE.SP_VerFacturaID(NumFactura).ToList();



                        if (VerFacturaID.Count != 0)
                        {

                            dgvReporteFacturas.DataSource = null;
                            dgvReporteFacturas.DataSource = VerFacturaID.ToList();
                            //dgvReporteFacturas.Columns["SubTotal"].DefaultCellStyle.Format = "C2";
                            //dgvReporteFacturas.Columns["TotalFactura"].DefaultCellStyle.Format = "C2";
                            //dgvReporteFacturas.Columns["Descuento"].DefaultCellStyle.Format = "C2";
                            //dgvReporteFacturas.Columns["ITBIS"].DefaultCellStyle.Format = "C2";


                        }
                        else
                        {
                            MessageBox.Show("No se ha encontrado la factura indicada.", "Atención",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                    catch (Exception Ex)
                    {

                        MessageBox.Show("No fue posible cargar las facturas en la lista. " + Ex.Message, "Atención",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }


                }
            }
           
        }

        public List<VW_VerFacturas> LoadTopFacturas()
        {
            try
            {
                using (BAReportesEntities FE = new BAReportesEntities())
                {
                    //Traer las ultimas 5 facturas recientes
                    VerFactura = FE.VW_VerFacturas.Take(10).OrderByDescending(t=> t.Fecha).ToList();
                    return VerFactura;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No fue posible cargar las facturas en la lista. " + Ex.Message, "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return VerFactura;
            }
        }

        public void LoadFiltros(ComboBox cboFiltros)
        {
            string[] Filtros = new string[] { "Num. Factura"};
            cboFiltros.Items.AddRange(Filtros);
            cboFiltros.SelectedIndex = 0;
        }

        public DataGridViewColumnCollection FormatoColumnasFacturas(DataGridViewColumnCollection ColumnasFacturas)
        {
            ColumnasFacturas["EstatusFactura"].HeaderText = "Estatus Factura";
            ColumnasFacturas["SubTotal"].HeaderText = "Sub-Total";
            ColumnasFacturas["TotalFactura"].HeaderText = "Total Factura";
            ColumnasFacturas["MontoPagado"].HeaderText = "Monto Pagado";
            ColumnasFacturas["MontoPendiente"].HeaderText = "Monto Pendiente";
            ColumnasFacturas["MetodoPago"].HeaderText = "Metodo Pago";

            ColumnasFacturas["SubTotal"].DefaultCellStyle.Format = "C";
            ColumnasFacturas["TotalFactura"].DefaultCellStyle.Format = "C";
            ColumnasFacturas["MontoPagado"].DefaultCellStyle.Format = "C";
            ColumnasFacturas["MontoPendiente"].DefaultCellStyle.Format = "C";
            ColumnasFacturas["Descuento"].DefaultCellStyle.Format = "C";
            ColumnasFacturas["ITBIS"].DefaultCellStyle.Format = "C";

            return ColumnasFacturas;
        } 

        public DataGridViewColumnCollection FormatoColumnasConduces(DataGridViewColumnCollection ColumnaConduces)
        {
            ColumnaConduces["SubTotal"].DefaultCellStyle.Format = "C2";
            return ColumnaConduces;
        }
    }
}
