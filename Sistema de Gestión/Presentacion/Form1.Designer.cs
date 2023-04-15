
namespace Sistema_de_Gestión
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuPrincipalClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalVehiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalFacturacion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalCotizacion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFacturaPendientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVerFacturasGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportesFacturasProforma = new System.Windows.Forms.ToolStripMenuItem();
            this.redaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalConfiguracion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.BarEstado = new System.Windows.Forms.StatusStrip();
            this.toolUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuPrincipal.SuspendLayout();
            this.BarEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mnuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mnuPrincipal.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuPrincipal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrincipalClientes,
            this.mnuPrincipalEmpleados,
            this.mnuPrincipalProductos,
            this.mnuPrincipalCategorias,
            this.mnuPrincipalProveedores,
            this.mnuPrincipalVehiculos,
            this.mnuPrincipalPedidos,
            this.mnuPrincipalFacturacion,
            this.mnuPrincipalCotizacion,
            this.mnuPrincipalReportes,
            this.mnuPrincipalConfiguracion,
            this.mnuPrincipalAcercaDe});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(1370, 32);
            this.mnuPrincipal.TabIndex = 1;
            this.mnuPrincipal.Text = "Principal";
            // 
            // mnuPrincipalClientes
            // 
            this.mnuPrincipalClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mnuPrincipalClientes.Image = global::Sistema_de_Gestión.RecursosBA.Clientes21;
            this.mnuPrincipalClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuPrincipalClientes.Name = "mnuPrincipalClientes";
            this.mnuPrincipalClientes.Size = new System.Drawing.Size(84, 28);
            this.mnuPrincipalClientes.Text = "Clientes";
            this.mnuPrincipalClientes.Click += new System.EventHandler(this.mnuPrincipalClientes_Click);
            // 
            // mnuPrincipalEmpleados
            // 
            this.mnuPrincipalEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mnuPrincipalEmpleados.Image = global::Sistema_de_Gestión.RecursosBA.Empleados2;
            this.mnuPrincipalEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuPrincipalEmpleados.Name = "mnuPrincipalEmpleados";
            this.mnuPrincipalEmpleados.Size = new System.Drawing.Size(100, 28);
            this.mnuPrincipalEmpleados.Text = "Empleados";
            this.mnuPrincipalEmpleados.Click += new System.EventHandler(this.mnuPrincipalEmpleados_Click);
            // 
            // mnuPrincipalProductos
            // 
            this.mnuPrincipalProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mnuPrincipalProductos.Image = global::Sistema_de_Gestión.RecursosBA.Productos2;
            this.mnuPrincipalProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuPrincipalProductos.Name = "mnuPrincipalProductos";
            this.mnuPrincipalProductos.Size = new System.Drawing.Size(96, 28);
            this.mnuPrincipalProductos.Text = "Productos";
            this.mnuPrincipalProductos.Click += new System.EventHandler(this.mnuPrincipalProductos_Click);
            // 
            // mnuPrincipalCategorias
            // 
            this.mnuPrincipalCategorias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mnuPrincipalCategorias.Image = global::Sistema_de_Gestión.RecursosBA.Categorizar2;
            this.mnuPrincipalCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuPrincipalCategorias.Name = "mnuPrincipalCategorias";
            this.mnuPrincipalCategorias.Size = new System.Drawing.Size(98, 28);
            this.mnuPrincipalCategorias.Text = "Categorías";
            this.mnuPrincipalCategorias.Click += new System.EventHandler(this.mnuPrincipalCategorias_Click);
            // 
            // mnuPrincipalProveedores
            // 
            this.mnuPrincipalProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mnuPrincipalProveedores.Image = global::Sistema_de_Gestión.RecursosBA.Proveedores2;
            this.mnuPrincipalProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuPrincipalProveedores.Name = "mnuPrincipalProveedores";
            this.mnuPrincipalProveedores.Size = new System.Drawing.Size(108, 28);
            this.mnuPrincipalProveedores.Text = "Proveedores";
            this.mnuPrincipalProveedores.Click += new System.EventHandler(this.mnuPrincipalProveedores_Click);
            // 
            // mnuPrincipalVehiculos
            // 
            this.mnuPrincipalVehiculos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mnuPrincipalVehiculos.Image = global::Sistema_de_Gestión.RecursosBA.Logo;
            this.mnuPrincipalVehiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuPrincipalVehiculos.Name = "mnuPrincipalVehiculos";
            this.mnuPrincipalVehiculos.Size = new System.Drawing.Size(93, 28);
            this.mnuPrincipalVehiculos.Text = "Vehiculos";
            this.mnuPrincipalVehiculos.Click += new System.EventHandler(this.mnuPrincipalVehiculos_Click);
            // 
            // mnuPrincipalPedidos
            // 
            this.mnuPrincipalPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mnuPrincipalPedidos.Image = global::Sistema_de_Gestión.RecursosBA.Pedidos;
            this.mnuPrincipalPedidos.Name = "mnuPrincipalPedidos";
            this.mnuPrincipalPedidos.Size = new System.Drawing.Size(85, 28);
            this.mnuPrincipalPedidos.Text = "Pedidos";
            this.mnuPrincipalPedidos.Click += new System.EventHandler(this.mnuPrincipalPedidos_Click);
            // 
            // mnuPrincipalFacturacion
            // 
            this.mnuPrincipalFacturacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mnuPrincipalFacturacion.Image = global::Sistema_de_Gestión.RecursosBA.Facturacion21;
            this.mnuPrincipalFacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuPrincipalFacturacion.Name = "mnuPrincipalFacturacion";
            this.mnuPrincipalFacturacion.Size = new System.Drawing.Size(103, 28);
            this.mnuPrincipalFacturacion.Text = "Facturación";
            this.mnuPrincipalFacturacion.Click += new System.EventHandler(this.mnuPrincipalFacturacion_Click);
            // 
            // mnuPrincipalCotizacion
            // 
            this.mnuPrincipalCotizacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mnuPrincipalCotizacion.Image = global::Sistema_de_Gestión.RecursosBA.Cotizacion2;
            this.mnuPrincipalCotizacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuPrincipalCotizacion.Name = "mnuPrincipalCotizacion";
            this.mnuPrincipalCotizacion.Size = new System.Drawing.Size(97, 28);
            this.mnuPrincipalCotizacion.Text = "Cotización";
            this.mnuPrincipalCotizacion.Click += new System.EventHandler(this.mnuPrincipalCotizacion_Click);
            // 
            // mnuPrincipalReportes
            // 
            this.mnuPrincipalReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturasToolStripMenuItem,
            this.redaccionesToolStripMenuItem});
            this.mnuPrincipalReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mnuPrincipalReportes.Image = global::Sistema_de_Gestión.RecursosBA.Reportes2;
            this.mnuPrincipalReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuPrincipalReportes.Name = "mnuPrincipalReportes";
            this.mnuPrincipalReportes.Size = new System.Drawing.Size(89, 28);
            this.mnuPrincipalReportes.Text = "Reportes";
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFacturaPendientes,
            this.mnuVerFacturasGeneral,
            this.mnuReportesFacturasProforma});
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.facturasToolStripMenuItem.Text = "Facturas";
            // 
            // mnuFacturaPendientes
            // 
            this.mnuFacturaPendientes.Image = global::Sistema_de_Gestión.RecursosBA.BotonVerFacturaReporte;
            this.mnuFacturaPendientes.Name = "mnuFacturaPendientes";
            this.mnuFacturaPendientes.Size = new System.Drawing.Size(230, 30);
            this.mnuFacturaPendientes.Text = "Pendientes a pago x clientes";
            this.mnuFacturaPendientes.Click += new System.EventHandler(this.mnuFacturaPendientes_Click);
            // 
            // mnuVerFacturasGeneral
            // 
            this.mnuVerFacturasGeneral.Image = ((System.Drawing.Image)(resources.GetObject("mnuVerFacturasGeneral.Image")));
            this.mnuVerFacturasGeneral.Name = "mnuVerFacturasGeneral";
            this.mnuVerFacturasGeneral.Size = new System.Drawing.Size(230, 30);
            this.mnuVerFacturasGeneral.Text = "Buscar";
            this.mnuVerFacturasGeneral.Click += new System.EventHandler(this.mnuVerFacturasGeneral_Click);
            // 
            // mnuReportesFacturasProforma
            // 
            this.mnuReportesFacturasProforma.Name = "mnuReportesFacturasProforma";
            this.mnuReportesFacturasProforma.Size = new System.Drawing.Size(230, 30);
            this.mnuReportesFacturasProforma.Text = "Proforma";
            this.mnuReportesFacturasProforma.Click += new System.EventHandler(this.mnuReportesFacturasProforma_Click);
            // 
            // redaccionesToolStripMenuItem
            // 
            this.redaccionesToolStripMenuItem.Name = "redaccionesToolStripMenuItem";
            this.redaccionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redaccionesToolStripMenuItem.Text = "Redacciones";
            this.redaccionesToolStripMenuItem.Click += new System.EventHandler(this.redaccionesToolStripMenuItem_Click);
            // 
            // mnuPrincipalConfiguracion
            // 
            this.mnuPrincipalConfiguracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mnuPrincipalConfiguracion.Image = global::Sistema_de_Gestión.RecursosBA.Configuracion2;
            this.mnuPrincipalConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuPrincipalConfiguracion.Name = "mnuPrincipalConfiguracion";
            this.mnuPrincipalConfiguracion.Size = new System.Drawing.Size(117, 28);
            this.mnuPrincipalConfiguracion.Text = "Configuración";
            this.mnuPrincipalConfiguracion.Click += new System.EventHandler(this.mnuPrincipalConfiguracion_Click);
            // 
            // mnuPrincipalAcercaDe
            // 
            this.mnuPrincipalAcercaDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mnuPrincipalAcercaDe.Image = global::Sistema_de_Gestión.RecursosBA.aboutInfo2;
            this.mnuPrincipalAcercaDe.Name = "mnuPrincipalAcercaDe";
            this.mnuPrincipalAcercaDe.Size = new System.Drawing.Size(94, 28);
            this.mnuPrincipalAcercaDe.Text = "Acerca De";
            this.mnuPrincipalAcercaDe.Click += new System.EventHandler(this.mnuPrincipalAcercaDe_Click);
            // 
            // BarEstado
            // 
            this.BarEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolUsuario});
            this.BarEstado.Location = new System.Drawing.Point(0, 687);
            this.BarEstado.Name = "BarEstado";
            this.BarEstado.Size = new System.Drawing.Size(1370, 22);
            this.BarEstado.TabIndex = 10;
            this.BarEstado.Text = "statusStrip1";
            // 
            // toolUsuario
            // 
            this.toolUsuario.AutoToolTip = true;
            this.toolUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.toolUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolUsuario.ForeColor = System.Drawing.Color.DarkRed;
            this.toolUsuario.Image = ((System.Drawing.Image)(resources.GetObject("toolUsuario.Image")));
            this.toolUsuario.IsLink = true;
            this.toolUsuario.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.toolUsuario.Name = "toolUsuario";
            this.toolUsuario.Size = new System.Drawing.Size(16, 17);
            this.toolUsuario.ToolTipText = "Cambiar contraseña";
            this.toolUsuario.Click += new System.EventHandler(this.toolUsuario_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.FondoContenedorFinal2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1370, 709);
            this.Controls.Add(this.BarEstado);
            this.Controls.Add(this.mnuPrincipal);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "Sistema de Gestión Botes y Agregados EDWIN | ISMAEL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.BarEstado.ResumeLayout(false);
            this.BarEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuPrincipalClientes;
        private System.Windows.Forms.ToolStripMenuItem mnuPrincipalEmpleados;
        private System.Windows.Forms.ToolStripMenuItem mnuPrincipalProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuPrincipalCategorias;
        private System.Windows.Forms.ToolStripMenuItem mnuPrincipalProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuPrincipalFacturacion;
        public System.Windows.Forms.StatusStrip BarEstado;
        public System.Windows.Forms.ToolStripStatusLabel toolUsuario;
        private System.Windows.Forms.ToolStripMenuItem mnuPrincipalReportes;
        private System.Windows.Forms.ToolStripMenuItem mnuPrincipalConfiguracion;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFacturaPendientes;
        private System.Windows.Forms.ToolStripMenuItem mnuVerFacturasGeneral;
        private System.Windows.Forms.ToolStripMenuItem mnuPrincipalCotizacion;
        private System.Windows.Forms.ToolStripMenuItem mnuPrincipalVehiculos;
        private System.Windows.Forms.ToolStripMenuItem mnuPrincipalAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem mnuPrincipalPedidos;
        private System.Windows.Forms.ToolStripMenuItem redaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuReportesFacturasProforma;
    }
}

