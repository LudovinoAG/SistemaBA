using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Gestión.Presentacion;
using Sistema_de_Gestión.Properties;

namespace Sistema_de_Gestión.Modelos
{
    public class DiseñoInterface
    {
        public void BTMouseEvent(Button BT, int Evento)
        {
            switch (BT.Name)
            {
                case "cmdCerrarVentana":
                    if (Evento==1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonSalirOver;
                    }
                    else if(Evento==2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonSalirClick;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonSalir;
                    }
                    break;

                case "cmdAgregar":
                    if (Evento == 1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonAgregarOver;
                    }
                    else if (Evento == 2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonAgregarClick;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonAgregar;
                    }
                    break;

                case "cmdLimpiar":
                    if (Evento == 1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonLimpiarOver;
                    }
                    else if (Evento == 2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonLimpiarClick;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonLimpiar;
                    }
                    break;

                case "cmdGuardar":
                    if (Evento == 1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonActualizarHover;
                    }
                    else if (Evento == 2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonActualizarClick;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonActualizar;
                    }
                    break;


                case "cmdEliminar":
                    if (Evento == 1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonEliminarHover;
                    }
                    else if (Evento == 2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonEliminarClick;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonEliminar;
                    }
                    break;


                case "cmdInsertar":
                    if (Evento == 1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonInsertarOver;
                    }
                    else if (Evento == 2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonInsertarClick;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonInsertar;
                    }
                    break;

                case "cmdMostrar":
                    if (Evento == 1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonMostrarFacturaOver;
                    }
                    else if (Evento == 2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonMostrarFacturaDown;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonMostrarFactura;
                    }
                    break;

                case "cmdVerFactura":
                    if (Evento == 1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonNuevaFacturaNCFOver;
                    }
                    else if (Evento == 2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonNuevaFacturaNCFClick;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonNuevaFacturaNCF;
                    }
                    break;

                case "cmdFacturaSinComprobante":
                    if (Evento == 1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonNuevaFacturaSinNCFOver;
                    }
                    else if (Evento == 2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonNuevaFacturaSinNCFClick;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonNuevaFacturaSinNCF;
                    }
                    break;

                case "cmdFacturar":
                    if (Evento == 1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonImprimirFacturarOver;
                    }
                    else if (Evento == 2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonImprimirFacturarClick;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonImprimirFacturar;
                    }
                    break;

                case "button3":
                    if (Evento == 1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonBuscarFacturaOver;
                    }
                    else if (Evento == 2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonBuscarFacturaClick;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonBuscarFactura;
                    }
                    break;

                case "button5":
                    if (Evento == 1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonCerrarFacturaOver;
                    }
                    else if (Evento == 2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonCerrarFacturaClick;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonCerrarFactura;
                    }
                    break;

                case "cmdAgregarInfoChofer":
                    if (Evento == 1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonAgregarChoferHover;
                    }
                    else if (Evento == 2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonAgregarChoferClick;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonAgregarChofer;
                    }
                    break;

                case "button1":
                    if (Evento == 1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonAgregarEntradaOver;
                    }
                    else if (Evento == 2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonAgregarEntradaClick;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonAgregarEntrada;
                    }
                    break;

                case "cmdBuscar":
                    if (Evento == 1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonBuscarReporteOver;
                    }
                    else if (Evento == 2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonBuscarReporteClick;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonBuscarReporte;
                    }
                    break;

                case "cmdVerFacturaReporte":
                    if (Evento == 1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonVerFacturaReporteOver;
                    }
                    else if (Evento == 2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonVerFacturaReporteClick;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonVerFacturaReporte;
                    }
                    break;

                case "cmdCerrarReporteFacturas":
                    if (Evento == 1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonCerrarVentanaOver;
                    }
                    else if (Evento == 2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonCerrarVentanaClick;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonCerrarVentana;
                    }
                    break;


                case "cmdInsertUser":
                    if (Evento == 1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonInsertarOver;
                    }
                    else if (Evento == 2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonInsertarClick;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonInsertar;
                    }
                    break;

                case "cmdGuardarUser":
                    if (Evento == 1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonActualizarHover;
                    }
                    else if (Evento == 2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonActualizarClick;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonActualizar;
                    }
                    break;

                case "cmdEliminarUser":
                    if (Evento == 1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonEliminarHover;
                    }
                    else if (Evento == 2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonEliminarClick;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonEliminar;
                    }
                    break;

                case "CmdPagarFactura":
                    if (Evento == 1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonPagarFacturaReporteOver;
                    }
                    else if (Evento == 2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonPagarFacturaReporteClick;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonPagarFacturaReporte;
                    }
                    break;

                case "cmdNuevaCotización":
                    if (Evento == 1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonNuevaCotizacionOver;
                    }
                    else if (Evento == 2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonNuevaCotizacionClick;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonNuevaCotizacion;
                    }
                    break;

                case "cmdRegistrar":
                    if (Evento == 1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonGuardarCotizacionOver;
                    }
                    else if (Evento == 2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonGuardarCotizacionClick;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonGuardarCotizacion;
                    }
                    break;


                case "cmdBuscarCotizacion":
                    if (Evento == 1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonBuscarCotizacionOver;
                    }
                    else if (Evento == 2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonBuscarCotizacionClick;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonBuscarCotizacion;
                    }
                    break;

                case "cmdSalirCotizacion":
                    if (Evento == 1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonCerrarVentanaOver;
                    }
                    else if (Evento == 2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonCerrarVentanaClick;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonCerrarVentana;
                    }
                    break;

                case "cmdAgregarComentario":
                    if (Evento == 1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonAgregarComentarioOver;
                    }
                    else if (Evento == 2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonAgregarComentarioClick;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonAgregarComentario;
                    }
                    break;

                case "cmdSalir":
                    if (Evento == 1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonSalirOver;
                    }
                    else if (Evento == 2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonSalirClick;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonSalir;
                    }
                    break;

                case "cmdGuardarClave":
                    if (Evento == 1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonGuardarClaveOver;
                    }
                    else if (Evento == 2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonGuardarClaveClick;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonGuardarClave;
                    }
                    break;

                case "cmdRegistrarPedido":
                    if (Evento == 1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonRegistrarPedidoOver;
                    }
                    else if (Evento == 2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonRegistrarPedidoClick;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonRegistrarPedido;
                    }
                    break;

                case "cmdCerrarVentanaPedido":
                    if (Evento == 1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonCerrarVentanaOver;
                    }
                    else if (Evento == 2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonCerrarVentanaClick;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonCerrarVentana;
                    }
                    break;

                case "cmdAgregarConduce":
                    if (Evento == 1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonAgregarConduceOver;
                    }
                    else if (Evento == 2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonAgregarConduceClick;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonAgregarConduce;
                    }
                    break;

                case "cmdBuscarPedido":
                    if (Evento == 1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonBuscarPedidosProformaOver;
                    }
                    else if (Evento == 2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonBuscarPedidosProformaClick;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonBuscarPedidosProforma;
                    }
                    break;

                case "cmdResetCriterios":
                    if (Evento == 1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonResetCriteriosProformaOver;
                    }
                    else if (Evento == 2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonResetCriteriosProformaClick;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonResetCriteriosProforma;
                    }
                    break;

                case "cmdVerProforma":
                    if (Evento == 1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonVerProformaOver;
                    }
                    else if (Evento == 2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonVerProformaClick;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonVerProforma;
                    }
                    break;

                case "cmdVerRedaccion":
                    if (Evento == 1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonVerRedaccionOver;
                    }
                    else if (Evento == 2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonVerRedaccionClick;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonVerRedaccion;
                    }
                    break;

                case "cmdAplicarPago":
                    if (Evento == 1)
                    {
                        BT.BackgroundImage = RecursosBA.BotonPagarFacturaReporteOver;
                    }
                    else if (Evento == 2)
                    {
                        BT.BackgroundImage = RecursosBA.BotonPagarFacturaReporteClick;
                    }
                    else
                    {
                        BT.BackgroundImage = RecursosBA.BotonPagarFacturaReporte;
                    }
                    break;


                    



                default:
                    break;
            }

            
           
        }
    }
}
