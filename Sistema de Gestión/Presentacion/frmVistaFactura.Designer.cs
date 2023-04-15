
namespace Sistema_de_Gestión.Presentacion
{
    partial class frmVistaFactura
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crvFactura1 = new Sistema_de_Gestión.CRVFactura();
            this.sP_VerFacturaIDTableAdapter1 = new Sistema_de_Gestión.DSReportesTableAdapters.SP_VerFacturaIDTableAdapter();
            this.sP_VerDetalleFacturaTableAdapter1 = new Sistema_de_Gestión.DSReportesTableAdapters.SP_VerDetalleFacturaTableAdapter();
            this.sP_VerDetallesConducesTableAdapter1 = new Sistema_de_Gestión.DSReportesTableAdapters.SP_VerDetallesConducesTableAdapter();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.EnableRefresh = false;
            this.crystalReportViewer1.EnableToolTips = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowCopyButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.ShowRefreshButton = false;
            this.crystalReportViewer1.ShowTextSearchButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(864, 466);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // sP_VerFacturaIDTableAdapter1
            // 
            this.sP_VerFacturaIDTableAdapter1.ClearBeforeFill = true;
            // 
            // sP_VerDetalleFacturaTableAdapter1
            // 
            this.sP_VerDetalleFacturaTableAdapter1.ClearBeforeFill = true;
            // 
            // sP_VerDetallesConducesTableAdapter1
            // 
            this.sP_VerDetallesConducesTableAdapter1.ClearBeforeFill = true;
            // 
            // frmVistaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 466);
            this.Controls.Add(this.crystalReportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmVistaFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmVistaFactura";
            this.Load += new System.EventHandler(this.frmVistaFactura_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CRVFactura crvFactura1;
        private DSReportesTableAdapters.SP_VerFacturaIDTableAdapter sP_VerFacturaIDTableAdapter1;
        private DSReportesTableAdapters.SP_VerDetalleFacturaTableAdapter sP_VerDetalleFacturaTableAdapter1;
        private DSReportesTableAdapters.SP_VerDetallesConducesTableAdapter sP_VerDetallesConducesTableAdapter1;
    }
}