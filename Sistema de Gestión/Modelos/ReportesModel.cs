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



        public void BuscarFactura(DataGridView dgvReporteFacturas, string Filtro, string Valor,DateTime FechaInicio,
            DateTime FechaFinal)
        {
            using (BAReportesEntities RE =  new BAReportesEntities())
            {

                try
                {
                    var lstFacturas = RE.VW_VerFacturas.OrderBy(t => t.id_Factura);
                    var lstNuevoListado = lstFacturas.ToList();

                        if (Filtro == "Num. Factura")
                        {

                            lstNuevoListado = lstFacturas.Where(filtro =>
                                filtro.id_Factura.ToString() == Valor).ToList();
                        }
                        else if (Filtro == "NCF")
                        {
                            lstNuevoListado = lstFacturas.Where(filtro =>
                                filtro.NCF.ToString() == Valor).ToList();
                        }
                        else if (Filtro == "RNC")
                        {
                            lstNuevoListado = lstFacturas.Where(filtro =>
                                filtro.RNC.ToString() == Valor).ToList();
                        }
                        else if (Filtro == "Empresa")
                        {
                            lstNuevoListado = lstFacturas.Where(filtro =>
                                filtro.Empresa.StartsWith(Valor)).ToList();
                        }
                        else if (Filtro == "Fecha Factura")
                        {
                            var NuevoInicio = FechaInicio.Date;
                            var NuevoFin = FechaFinal.Date;
                            lstNuevoListado = lstFacturas.Where(filtro =>
                                filtro.FechaFactura >= NuevoInicio && filtro.FechaFactura <= NuevoFin).ToList();
                        }

                    if (lstNuevoListado.Count != 0)
                    {

                        dgvReporteFacturas.DataSource = null;
                        dgvReporteFacturas.DataSource = lstNuevoListado;

                        dgvReporteFacturas.Columns[0].HeaderText = "Num. Factura";
                        dgvReporteFacturas.Columns[0].DefaultCellStyle.Format = "00000#";
                        dgvReporteFacturas.Columns["SubTotalFactura"].DefaultCellStyle.Format = "C2";
                        dgvReporteFacturas.Columns["TotalFactura"].DefaultCellStyle.Format = "C2";
                        dgvReporteFacturas.Columns["Descuento"].DefaultCellStyle.Format = "C2";
                        dgvReporteFacturas.Columns["ITBIS"].DefaultCellStyle.Format = "C2";


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


        public void LoadFiltros(ComboBox cboFiltros)
        {
            string[] Filtros = new string[] { "Ninguno", "Num. Factura", "NCF", "RNC", "Empresa", "Fecha Factura"};
            cboFiltros.Items.AddRange(Filtros);
            cboFiltros.SelectedIndex = 0;
        }
    }
}
