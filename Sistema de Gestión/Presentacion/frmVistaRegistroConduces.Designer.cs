﻿
namespace Sistema_de_Gestión.Presentacion
{
    partial class frmVistaRegistroConduces
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.sP_ReporteConducesRegistradosTableAdapter1 = new Sistema_de_Gestión.DSReportesTableAdapters.SP_ReporteConducesRegistradosTableAdapter();
            this.crvReporteConducesRegistrados1 = new Sistema_de_Gestión.CRVReporteConducesRegistrados();
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
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.ShowRefreshButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // sP_ReporteConducesRegistradosTableAdapter1
            // 
            this.sP_ReporteConducesRegistradosTableAdapter1.ClearBeforeFill = true;
            // 
            // frmVistaRegistroConduces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "frmVistaRegistroConduces";
            this.Text = "Vista de Conduce -";
            ((System.ComponentModel.ISupportInitialize)(this.dsReportes1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DSReportes dsReportes1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private DSReportesTableAdapters.SP_ReporteConducesRegistradosTableAdapter sP_ReporteConducesRegistradosTableAdapter1;
        private CRVReporteConducesRegistrados crvReporteConducesRegistrados1;
    }
}