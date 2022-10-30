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

        public int VencimientoComprobante { get; set; }

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
                var orueba = new List<VW_VerComprobantesFiscales>(1);
                try
                {
                    var Resultado = CF.VW_VerComprobantesFiscales.ToList();
                    if (Resultado.Count!=0)
                    {
                        return Resultado;
                    }
                    else
                    {
                        VW_VerComprobantesFiscales item = new VW_VerComprobantesFiscales();
                        item.Estatus_Comprobante = "Desactivado";
                        item.Fecha_Vencimiento_Comprobante = DateTime.Now;
                        orueba.Add(item);
                    }
                       
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("No fue posible cargar los comprobantes. " + Ex.Message,"Comprobantes",
                        MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return null;
                }
                return orueba;
            }
        }

        public string CargarNuevoComprobante()
        {
            this.ValidarFechaComprobante();
            try
            {
                this.ModoComprobante = this.VerComprobantes().SingleOrDefault().Estatus_Comprobante;

                if (this.ModoComprobante != "Desactivado")
                {
                    int Desde = this.VerComprobantes().SingleOrDefault().Comprobante_Desde;
                    var Nuevo = Desde + (int)this.VerComprobantes().SingleOrDefault().Cantidad_Comprobantes_Usados;
                    string Patron = this.VerComprobantes().SingleOrDefault().Serie + this.VerComprobantes().SingleOrDefault().Tipo;
                    return Patron + Nuevo.ToString().PadLeft(8, '0');
                }

                return "B0000000000";
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No existe comprobante fiscal activado. " + Ex.Source, "Comprobante Fiscal", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ModoComprobante = "Desactivado";
                return "B0000000000";
                
            }

        }


        public void ActualizarComprobanteUsado()
        {
            int ComprobanteUsados = (int)this.VerComprobantes().SingleOrDefault().Cantidad_Comprobantes_Usados;
            string ModoComprobante = this.VerComprobantes().SingleOrDefault().Estatus_Comprobante;
            int IDComprobante = (int)this.VerComprobantes().SingleOrDefault().id_Comprobante;

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
                    var ID = this.VerComprobantes().SingleOrDefault();
                    if (ID!=null)
                    {
                        Desactivado = CF.SP_DesactivarComprobante(ID.id_Comprobante);
                        return Desactivado;
                    }
                    

                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible validar vencimiento comprobantes. " + ex.Message, "Comprobantes",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                return Desactivado;
            }
            
        }
    }
}
