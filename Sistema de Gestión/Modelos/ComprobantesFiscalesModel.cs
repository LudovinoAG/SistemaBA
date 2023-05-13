using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gestión.Modelos
{
    class ComprobantesFiscalesModel
    {

        public int Cantidad_Comprobantes { get; set; }

        public string ModoComprobante { get; set; }

        public static DateTime VencimientoComprobante { get; set; }

        public List<VW_VerComprobantesFiscales> ComprobantesFiscales { get; set; }

        public void AgregarComprobantes(int Desde, int Hasta, int Cantidad, string FechaVencimiento,
            string Estatus, string Serie, string Tipo)
        {
            using (BAComprobantesFiscalesEntities CF = new BAComprobantesFiscalesEntities())
            {
                try
                {
                    var InsertarComprobante = CF.SP_InsertarComprobantes(Desde, Hasta, Cantidad,
                        DateTime.Parse(FechaVencimiento), Estatus, Serie, Tipo);

                    MessageBox.Show("Se ha insertado el rango de comprobantes correctamente.", "Comprobantes",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("No fue posible insertar el comprobante. " + Ex.Message, "Comprobantes",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public List<string> CalcularCantidadComprobantes(int desde, int hasta, string serie, string tipo)
        {
            var Comprobantes = this.VerComprobantes().SingleOrDefault();
            List<string> Rangos = new List<string>();
            if (Comprobantes != null)
            {
                while (desde <= hasta)
                {
                    this.Cantidad_Comprobantes++;
                    Rangos.Add(Comprobantes.Serie + Comprobantes.Tipo + desde.ToString().PadLeft(8, '0'));
                    desde++;
                }
                this.Cantidad_Comprobantes = Rangos.Count();
            }
            else
            {
                while (desde <= hasta)
                {
                    this.Cantidad_Comprobantes++;
                    Rangos.Add(serie + tipo + desde.ToString().PadLeft(8, '0'));
                    desde++;
                }
                this.Cantidad_Comprobantes = Rangos.Count();
            }
            if (this.Cantidad_Comprobantes == 0)
            {
                this.ModoComprobante = "Desactivado";
            }

            return Rangos.ToList();

        }

        public List<VW_VerComprobantesFiscales> VerComprobantes()
        {
            using (BAComprobantesFiscalesEntities CF = new BAComprobantesFiscalesEntities())
            {
                //var orueba = new List<VW_VerComprobantesFiscales>(1);
                try
                {
                    ComprobantesFiscales = CF.VW_VerComprobantesFiscales.ToList();
                    if (ComprobantesFiscales.Count!=0)
                    {
                        return ComprobantesFiscales;
                    }
                    else
                    {
                        MessageBox.Show("No existe comprobante fiscal activado.", "Comprobante Fiscal",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //VW_VerComprobantesFiscales item = new VW_VerComprobantesFiscales();
                        //DateTime FechaNeutra = new DateTime();
                        //ComprobantesFiscales.SingleOrDefault().Estatus_Comprobante = "Desactivado";
                        //ComprobantesFiscales.SingleOrDefault().Fecha_Vencimiento_Comprobante = DateTime.Parse(FechaNeutra.ToString("dd/MM/yyyy"));
                        //orueba.Add(ComprobantesFiscales);
                    }
                       
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("No fue posible cargar los comprobantes. " + Ex.Message,"Comprobantes",
                        MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return ComprobantesFiscales;
                }
                return ComprobantesFiscales;
            }
        }

        public string CargarNuevoComprobante()
        {
            int result = ValidarFechaComprobante();
            try
            {
                ComprobantesFiscales = this.VerComprobantes().ToList();
                if (ComprobantesFiscales.Count!=0)
                {
                    this.ModoComprobante = ComprobantesFiscales.SingleOrDefault().Estatus_Comprobante; //this.VerComprobantes().SingleOrDefault().Estatus_Comprobante;
                    if (this.ModoComprobante != "Desactivado")
                    {
                        int Desde = ComprobantesFiscales.SingleOrDefault().Comprobante_Desde; //this.VerComprobantes().SingleOrDefault().Comprobante_Desde;
                        var Nuevo = Desde + (int)ComprobantesFiscales.SingleOrDefault().Cantidad_Comprobantes_Usados; //this.VerComprobantes().SingleOrDefault().Cantidad_Comprobantes_Usados;
                        string Patron = ComprobantesFiscales.SingleOrDefault().Serie + ComprobantesFiscales.SingleOrDefault().Tipo; //this.VerComprobantes().SingleOrDefault().Serie + this.VerComprobantes().SingleOrDefault().Tipo;
                        return Patron + Nuevo.ToString().PadLeft(8, '0');
                    }
                    else
                    {
                        if (result == 1)
                        {
                            MessageBox.Show($"El rango de comprobantes fiscales ha vencido,\npara continuar con NCF" +
                                $"debe configurar un nuevo rango, por el momento se activara la factura sin NCF.",
                                "NCF Vencido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show($"El rango de comprobante fiscal esta desactivado, \n" +
                                $"por el momento se activara la factura sin NCF.",
                                "NCF Desactivado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("No existe comprobante fiscal activado.", "Comprobante Fiscal",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return "B0000000000";
                }
              
                
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No existe comprobante fiscal activado. " + Ex.Source, "Comprobante Fiscal", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ModoComprobante = "Desactivado";
                return "B0000000000";
                
            }
            return "B0000000000";
        }

        public void ActualizarComprobanteUsado()
        {
            ComprobantesFiscales = VerComprobantes();
            int ComprobanteUsados = (int)ComprobantesFiscales.SingleOrDefault().Cantidad_Comprobantes_Usados;
            string ModoComprobante = ComprobantesFiscales.SingleOrDefault().Estatus_Comprobante;
            int IDComprobante = (int)ComprobantesFiscales.SingleOrDefault().id_Comprobante;

            if (ModoComprobante != "Desactivado")
            {
                using (BAComprobantesFiscalesEntities CF = new BAComprobantesFiscalesEntities())
                {
                    try
                    {
                        ComprobanteUsados++;
                        CF.SP_ActualizarUsoComprobante(IDComprobante, ComprobanteUsados);
                       
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("No fue posible Actualizar la secuencia del comprobante. " + Ex.Message, "Comprobantes",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("La opción de Comprobante fiscal esta desactivado,\n" +
                    "debido a que el rango se ha agotado o ha vencido.", "Comprobante Fiscal",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

        public int ValidarFechaComprobante()
        {
            using (BAComprobantesFiscalesEntities CF = new BAComprobantesFiscalesEntities())
            {
                int Desactivado = 0;
                try
                {
                    ComprobantesFiscales = VerComprobantes();
                    if (ComprobantesFiscales.Count != 0)
                    {
                        Desactivado = CF.SP_DesactivarComprobante(ComprobantesFiscales.SingleOrDefault().id_Comprobante);
                        VencimientoComprobante = ComprobantesFiscales.SingleOrDefault().Fecha_Vencimiento_Comprobante;
                        return Desactivado;
                    }
                    else
                    {
                        MessageBox.Show("No existe un rango de comprobantes fiscales disponible.", "Atencion",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    

                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible validar vencimiento comprobantes. " + ex.Message, "Comprobantes",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //VencimientoComprobante = DateTime.Parse("00/00/0000");
                return Desactivado;
            }
            
        }

        public bool ActualizarInfoComprobante(int desde, int hasta, int CantidadNCF, DateTime FechaVencimiento, int ProximoNCF, 
            string Estatus, string Serie, string Tipo)
        {
            try
            {
                using(BAComprobantesFiscalesEntities CF = new BAComprobantesFiscalesEntities())
                {
                    CF.SP_ActualizarInfoComprobanteFiscal(desde, hasta, CantidadNCF, FechaVencimiento, ProximoNCF, Estatus, Serie, Tipo);
                    return true;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No fue posible actualizar la información del comprobante " + Ex, "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }
    }
}
