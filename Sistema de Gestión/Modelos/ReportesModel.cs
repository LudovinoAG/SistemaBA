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
        public static int NumFacturaReporte { get; set; }

        public List<VW_VerFacturas> VerFactura { get; set; }

        public List<SP_VerFacturaID_Result> VerFacturaID { get; set; }

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
                    VerFactura = FE.VW_VerFacturas.Take(5).ToList();
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
    }
}
