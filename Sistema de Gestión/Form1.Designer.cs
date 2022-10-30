
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
            this.mnuSistema = new System.Windows.Forms.MenuStrip();
            this.mnuSistemas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSistemasFacturacion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mnuBotonFacturar = new System.Windows.Forms.ToolStripButton();
            this.mnuSistema.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuSistema
            // 
            this.mnuSistema.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSistemas});
            this.mnuSistema.Location = new System.Drawing.Point(0, 0);
            this.mnuSistema.Name = "mnuSistema";
            this.mnuSistema.Size = new System.Drawing.Size(800, 24);
            this.mnuSistema.TabIndex = 1;
            this.mnuSistema.Text = "menuStrip1";
            // 
            // mnuSistemas
            // 
            this.mnuSistemas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSistemasFacturacion});
            this.mnuSistemas.Name = "mnuSistemas";
            this.mnuSistemas.Size = new System.Drawing.Size(65, 20);
            this.mnuSistemas.Text = "Sistemas";
            this.mnuSistemas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // mnuSistemasFacturacion
            // 
            this.mnuSistemasFacturacion.Name = "mnuSistemasFacturacion";
            this.mnuSistemasFacturacion.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.mnuSistemasFacturacion.Size = new System.Drawing.Size(222, 22);
            this.mnuSistemasFacturacion.Text = "Facturación";
            this.mnuSistemasFacturacion.Click += new System.EventHandler(this.mnuSistemasFacturacion_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBotonFacturar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mnuBotonFacturar
            // 
            this.mnuBotonFacturar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuBotonFacturar.Image = ((System.Drawing.Image)(resources.GetObject("mnuBotonFacturar.Image")));
            this.mnuBotonFacturar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuBotonFacturar.Name = "mnuBotonFacturar";
            this.mnuBotonFacturar.Size = new System.Drawing.Size(23, 22);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mnuSistema);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuSistema;
            this.Name = "frmPrincipal";
            this.Text = "Sistema de Gestión B & A";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuSistema.ResumeLayout(false);
            this.mnuSistema.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuSistema;
        private System.Windows.Forms.ToolStripMenuItem mnuSistemas;
        private System.Windows.Forms.ToolStripMenuItem mnuSistemasFacturacion;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton mnuBotonFacturar;
    }
}

