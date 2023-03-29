using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Gestión.Modelos;
using Sistema_de_Gestión.Presentacion;

namespace Sistema_de_Gestión
{
    public partial class frmPrincipal : Form
    {
        Funciones FC = new Funciones();
        LoadingReportes frmCargarReporte;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Mostrar en la barra de estado el usuario y perfil conectado a la aplicación
            BarEstado.Items[0].Text = "Usuario: " + EntrarLogin.UsuarioActual + " | Perfil: " + EntrarLogin.PerfilActual;
            if (EntrarLogin.PerfilActual=="Usuario")
            {
                mnuPrincipalConfiguracion.Visible = false;
                mnuPrincipalEmpleados.Visible = false;
                mnuPrincipalCategorias.Visible = false;
                mnuPrincipalProveedores.Visible = false;

            }

        }



        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Cerrar toda la aplicación
            Application.ExitThread();
        }

        private void mnuPrincipalProductos_Click(object sender, EventArgs e)
        {
            if (!FC.ValidarVentanaAbierta("frmMantenimientoProductos"))
            {
                //Abrir formulario de Productos
                frmMantenimientoProductos frmMantenimiento = new frmMantenimientoProductos();
                frmMantenimiento.MdiParent = this;
                frmMantenimiento.Show();
            }

        }

        private void mnuPrincipalClientes_Click(object sender, EventArgs e)
        {
            //Abrir formulario de Clientes
            if (!FC.ValidarVentanaAbierta("frmMantenimientoClientes"))
            {
                frmMantenimientoClientes frmMantenimiento = new frmMantenimientoClientes();
                frmMantenimiento.MdiParent = this;
                frmMantenimiento.Show();
            }

        }

        private void mnuPrincipalFacturacion_Click(object sender, EventArgs e)
        {
            if (!FC.ValidarVentanaAbierta("Facturación"))
            {
                Facturación frmFacturacion = new Facturación();
                frmFacturacion.MdiParent = this;
                frmFacturacion.Show();
            }

        }

        private void mnuPrincipalEmpleados_Click(object sender, EventArgs e)
        {
            if (!FC.ValidarVentanaAbierta("frmMantenimientoEmpleados"))
            {
                //Abrir formulario de Empleados
                frmMantenimientoEmpleados frmEmpleados = new frmMantenimientoEmpleados();
                frmEmpleados.MdiParent = this;
                frmEmpleados.Show();
            }

        }

        private void mnuPrincipalCategorias_Click(object sender, EventArgs e)
        {
            if (!FC.ValidarVentanaAbierta("frmMantenimientoCategorias"))
            {
                //Abrir formulario de Categorias
                frmMantenimientoCategorias frmCategorias = new frmMantenimientoCategorias();
                frmCategorias.MdiParent = this;
                frmCategorias.Show();
            }
        }

        private void mnuPrincipalProveedores_Click(object sender, EventArgs e)
        {
            if (!FC.ValidarVentanaAbierta("frmMantenimientoProveedores"))
            {   //Abrir formulario de Proveedores
                frmMantenimientoProveedores frmProveedores = new frmMantenimientoProveedores();
                frmProveedores.MdiParent = this;
                frmProveedores.Show();

            }

        }

        private void mnuPrincipalConfiguracion_Click(object sender, EventArgs e)
        {
            if (!FC.ValidarVentanaAbierta("frmConfiguraciones"))
            {
                //Abrir formulario de Configuraciones
                frmConfiguraciones frmConfiguraciones = new frmConfiguraciones();
                frmConfiguraciones.ShowDialog();
            }

        }


        private void mnuVerFacturasGeneral_Click(object sender, EventArgs e)
        {
            if (!FC.ValidarVentanaAbierta("frmReportes"))
            {
                //Abrir formulario de Configuraciones
                frmReportesFacturas frmReportes = new frmReportesFacturas();
                frmReportes.MdiParent = this;
                frmReportes.Show();
            }
        }

        private async void mnuFacturaPendientes_Click(object sender, EventArgs e)
        {
            if (!FC.ValidarVentanaAbierta("frmReportesFacturasPendientes"))
            {
                //Abrir formulario de Configuraciones
                Mostrar();
                Task otask = new Task(Cargando);
                otask.Start();
                frmReporteFacturasPendientes frmReportes = new frmReporteFacturasPendientes();
                frmReportes.MdiParent = this;
                frmReportes.Show();
                await otask;
                Cerrar();
            }
        }

        public void Cargando()
        {
            Thread.Sleep(2000);
        }

        private void Mostrar()
        {
            frmCargarReporte = new LoadingReportes();
            frmCargarReporte.Show();
            frmCargarReporte.TopMost = true;
        }

        private void Cerrar()
        {
            if (frmCargarReporte != null)
            {
                frmCargarReporte.Close();
            }
        }

        private void mnuPrincipalCotizacion_Click(object sender, EventArgs e)
        {
            if (!FC.ValidarVentanaAbierta("frmCotización"))
            {
                //Abrir formulario de Cotizaciones
                frmCotización frmCotiza = new frmCotización();
                frmCotiza.MdiParent = this;
                frmCotiza.Show();
            }
        }

        private void toolUsuario_Click(object sender, EventArgs e)
        {
            frmCambiarClave frmCambiar = new frmCambiarClave();
            frmCambiar.ShowDialog();
        }

        private void mnuPrincipalVehiculos_Click(object sender, EventArgs e)
        {
            if (!FC.ValidarVentanaAbierta("frmMantenimientoVehiculos"))
            {
                frmMantenimientoVehiculos frmVehiculos = new frmMantenimientoVehiculos();
                frmVehiculos.MdiParent = this;
                frmVehiculos.Show();
            }

        }

        private void mnuPrincipalAcercaDe_Click(object sender, EventArgs e)
        {
            if (!FC.ValidarVentanaAbierta("frmAcercaDe"))
            {
                //Abrir formulario AcercaDe
                frmAcercaDe frmAcerca = new frmAcercaDe();
                frmAcerca.ShowDialog();
            }
        }

        private void mnuPrincipalPedidos_Click(object sender, EventArgs e)
        {
            if (!FC.ValidarVentanaAbierta("frmPedidos"))
            {
                frmPedidos frmPedidos = new frmPedidos();
                frmPedidos.MdiParent = this;
                frmPedidos.Show();
            }
        }

        private void redaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FC.ValidarVentanaAbierta("frmReportePedidos"))
            {
                frmRedaccionesClientes frmPedidosReportes = new frmRedaccionesClientes();
                frmPedidosReportes.MdiParent = this;
                frmPedidosReportes.Show();
            }
        }

        private void mnuReportesFacturasProforma_Click(object sender, EventArgs e)
        {
            if (!FC.ValidarVentanaAbierta("frmVerProforma"))
            {
                frmVerProforma frmVerProforma = new frmVerProforma();
                frmVerProforma.MdiParent = this;
                frmVerProforma.Show();
            }
        }
    }
}