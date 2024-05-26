
namespace Sistema_de_Gestión.Presentacion
{
    partial class frmListadoProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dsReportes1 = new Sistema_de_Gestión.DSReportes();
            this.crvListadoProductos1 = new Sistema_de_Gestión.CRVListadoProductos();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.vW_ListaGeneralProductosReportesTableAdapter1 = new Sistema_de_Gestión.DSReportesTableAdapters.VW_ListaGeneralProductosReportesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportes1)).BeginInit();
            this.SuspendLayout();
            // 
            // dsReportes1
            // 
            this.dsReportes1.DataSetName = "DSReportes";
            this.dsReportes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowCopyButton = false;
            this.crystalReportViewer1.ShowGotoPageButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.ShowTextSearchButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // vW_ListaGeneralProductosReportesTableAdapter1
            // 
            this.vW_ListaGeneralProductosReportesTableAdapter1.ClearBeforeFill = true;
            // 
            // frmListadoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "frmListadoProductos";
            this.Text = "Listado General de Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dsReportes1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DSReportes dsReportes1;
        private CRVListadoProductos crvListadoProductos1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private DSReportesTableAdapters.VW_ListaGeneralProductosReportesTableAdapter vW_ListaGeneralProductosReportesTableAdapter1;
    }
}