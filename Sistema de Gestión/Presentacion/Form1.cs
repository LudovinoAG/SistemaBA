﻿using System;
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
        FacturacionModel FM = new FacturacionModel();

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
                frmMantenimiento.WindowState = FormWindowState.Normal;

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
                frmMantenimiento.WindowState = FormWindowState.Normal;
            }

        }

        private void mnuPrincipalFacturacion_Click(object sender, EventArgs e)
        {
            if (!FC.ValidarVentanaAbierta("Facturación"))
            {
                Facturación frmFacturacion = new Facturación();
                frmFacturacion.MdiParent = this;
                frmFacturacion.Show();
                frmFacturacion.WindowState = FormWindowState.Normal;
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
                frmEmpleados.WindowState = FormWindowState.Normal;
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
                frmCategorias.WindowState = FormWindowState.Normal;
            }
        }

        private void mnuPrincipalProveedores_Click(object sender, EventArgs e)
        {
            if (!FC.ValidarVentanaAbierta("frmMantenimientoProveedores"))
            {   //Abrir formulario de Proveedores
                frmMantenimientoProveedores frmProveedores = new frmMantenimientoProveedores();
                frmProveedores.MdiParent = this;
                frmProveedores.Show();
                frmProveedores.WindowState = FormWindowState.Normal;

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
                frmReportes.WindowState = FormWindowState.Normal;
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
                frmCotiza.WindowState = FormWindowState.Normal;
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
                frmVehiculos.WindowState = FormWindowState.Normal;
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
                frmPedidos.WindowState = FormWindowState.Normal;
            }
        }

        private void redaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FC.ValidarVentanaAbierta("frmReportePedidos"))
            {
                frmRedaccionesClientes frmPedidosReportes = new frmRedaccionesClientes();
                frmPedidosReportes.MdiParent = this;
                frmPedidosReportes.Show();
                frmPedidosReportes.WindowState = FormWindowState.Normal;
            }
        }

        private void mnuReportesFacturasProforma_Click(object sender, EventArgs e)
        {
            if (!FC.ValidarVentanaAbierta("frmVerProforma"))
            {
                frmVerProforma frmVerProforma = new frmVerProforma();
                frmVerProforma.MdiParent = this;
                frmVerProforma.Show();
                frmVerProforma.WindowState = FormWindowState.Normal;
            }
        }

        private async void listadoGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FC.ValidarVentanaAbierta("frmListadoGeneralClientes"))
            {
                //Abrir formulario de Configuraciones
                Mostrar();
                Task otask = new Task(Cargando);
                otask.Start();
                frmListadoGeneralClientes frmReportes = new frmListadoGeneralClientes();
                frmReportes.MdiParent = this;
                frmReportes.Show();
                await otask;
                Cerrar();
            }
        }

        private async void listadoGeneralToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!FC.ValidarVentanaAbierta("frmListadoProductos"))
            {
                //Abrir formulario de Configuraciones
                Mostrar();
                Task otask = new Task(Cargando);
                otask.Start();
                frmListadoProductos frmReportes = new frmListadoProductos();
                frmReportes.MdiParent = this;
                frmReportes.Show();
                await otask;
                Cerrar();
            }
        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FC.ValidarVentanaAbierta("frmReporteConducesRegistradoClientes"))
            {
                frmReporteConducesRegistradoClientes frmVerConduces = new frmReporteConducesRegistradoClientes();
                frmVerConduces.MdiParent = this;
                frmVerConduces.Show();
                frmVerConduces.WindowState = FormWindowState.Normal;
            }
        }
    }
}