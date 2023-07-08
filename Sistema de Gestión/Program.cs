using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Gestión.Presentacion;

namespace Sistema_de_Gestión
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmLogin());
            //Application.Run(new frmNuevoProducto());
            //Application.Run(new frmMantenimientoProductos());
            //Application.Run(new Facturación());
            //Application.Run(new frmMantenimientoCategorias());
            //Application.Run(new frmMantenimientoProveedores());
            //Application.Run(new frmPrincipal());
            //Application.Run(new frmVistaFactura());
            Application.Run(new frmReportesFacturas());
            //Application.Run(new frmPagarFactura());
            //Application.Run(new frmMantenimientoVehiculos());
            //Application.Run(new frmNotaFactura());
            //Application.Run(new frmAcercaDe());
            //Application.Run(new frmPedidos());
            //Application.Run(new frmRedaccionesClientes());
            //Application.Run(new frmVerProforma());
            //Application.Run(new frmCotización());
            //Application.Run(new frmMantenimientoPedidos());
            //Application.Run(new frmReporteConducesRegistradoClientes());
            //Application.Run(new frmActualizarFactura());
            


        }
    }
}
