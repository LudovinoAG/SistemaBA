
namespace Sistema_de_Gestión.Presentacion
{
    partial class frmReportesFacturas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.grbFechas = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dptFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFiltrar = new System.Windows.Forms.ComboBox();
            this.dgvReporteFacturas = new System.Windows.Forms.DataGridView();
            this.cmdVerFacturaReporte = new System.Windows.Forms.Button();
            this.cmdCerrarReporteFacturas = new System.Windows.Forms.Button();
            this.lblSeleccionado = new System.Windows.Forms.Label();
            this.CmdPagarFactura = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grbFechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cmdBuscar);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.grbFechas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboFiltrar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 62);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar una factura:";
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.BotonBuscarReporte;
            this.cmdBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdBuscar.Location = new System.Drawing.Point(657, 17);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(97, 35);
            this.cmdBuscar.TabIndex = 8;
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            this.cmdBuscar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmdBuscar_MouseDown);
            this.cmdBuscar.MouseLeave += new System.EventHandler(this.cmdBuscar_MouseLeave);
            this.cmdBuscar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmdBuscar_MouseMove);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(295, 23);
            this.txtBuscar.MaxLength = 255;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(204, 24);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // grbFechas
            // 
            this.grbFechas.Controls.Add(this.label4);
            this.grbFechas.Controls.Add(this.dptFechaFin);
            this.grbFechas.Controls.Add(this.label3);
            this.grbFechas.Controls.Add(this.dtpFechaInicio);
            this.grbFechas.Location = new System.Drawing.Point(285, 9);
            this.grbFechas.Name = "grbFechas";
            this.grbFechas.Size = new System.Drawing.Size(366, 43);
            this.grbFechas.TabIndex = 5;
            this.grbFechas.TabStop = false;
            this.grbFechas.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hasta:";
            // 
            // dptFechaFin
            // 
            this.dptFechaFin.CustomFormat = "dd/mm/yyyy";
            this.dptFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dptFechaFin.Location = new System.Drawing.Point(234, 14);
            this.dptFechaFin.Name = "dptFechaFin";
            this.dptFechaFin.Size = new System.Drawing.Size(120, 24);
            this.dptFechaFin.TabIndex = 7;
            this.dptFechaFin.Value = new System.DateTime(2022, 9, 12, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Desde:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CustomFormat = "dd/mm/yyyy";
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(60, 14);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(120, 24);
            this.dtpFechaInicio.TabIndex = 5;
            this.dtpFechaInicio.Value = new System.DateTime(2022, 9, 12, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtrar por:";
            // 
            // cboFiltrar
            // 
            this.cboFiltrar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFiltrar.FormattingEnabled = true;
            this.cboFiltrar.Location = new System.Drawing.Point(84, 23);
            this.cboFiltrar.Name = "cboFiltrar";
            this.cboFiltrar.Size = new System.Drawing.Size(140, 24);
            this.cboFiltrar.TabIndex = 0;
            this.cboFiltrar.SelectedIndexChanged += new System.EventHandler(this.cboFiltrar_SelectedIndexChanged);
            // 
            // dgvReporteFacturas
            // 
            this.dgvReporteFacturas.AllowUserToAddRows = false;
            this.dgvReporteFacturas.AllowUserToDeleteRows = false;
            this.dgvReporteFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvReporteFacturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvReporteFacturas.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReporteFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReporteFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReporteFacturas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReporteFacturas.Location = new System.Drawing.Point(16, 111);
            this.dgvReporteFacturas.MultiSelect = false;
            this.dgvReporteFacturas.Name = "dgvReporteFacturas";
            this.dgvReporteFacturas.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReporteFacturas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReporteFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReporteFacturas.Size = new System.Drawing.Size(789, 271);
            this.dgvReporteFacturas.TabIndex = 6;
            this.dgvReporteFacturas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReporteFacturas_CellClick);
            // 
            // cmdVerFacturaReporte
            // 
            this.cmdVerFacturaReporte.BackColor = System.Drawing.SystemColors.Control;
            this.cmdVerFacturaReporte.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.BotonVerFacturaReporte;
            this.cmdVerFacturaReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdVerFacturaReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdVerFacturaReporte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdVerFacturaReporte.FlatAppearance.BorderSize = 0;
            this.cmdVerFacturaReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdVerFacturaReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.cmdVerFacturaReporte.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVerFacturaReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdVerFacturaReporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdVerFacturaReporte.Location = new System.Drawing.Point(481, 388);
            this.cmdVerFacturaReporte.Name = "cmdVerFacturaReporte";
            this.cmdVerFacturaReporte.Size = new System.Drawing.Size(159, 105);
            this.cmdVerFacturaReporte.TabIndex = 91;
            this.cmdVerFacturaReporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdVerFacturaReporte.UseVisualStyleBackColor = false;
            this.cmdVerFacturaReporte.Click += new System.EventHandler(this.cmdVerFacturaReporte_Click);
            this.cmdVerFacturaReporte.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmdVerFacturaReporte_MouseDown);
            this.cmdVerFacturaReporte.MouseLeave += new System.EventHandler(this.cmdVerFacturaReporte_MouseLeave);
            this.cmdVerFacturaReporte.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmdVerFacturaReporte_MouseMove);
            // 
            // cmdCerrarReporteFacturas
            // 
            this.cmdCerrarReporteFacturas.BackColor = System.Drawing.SystemColors.Control;
            this.cmdCerrarReporteFacturas.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.BotonCerrarVentana;
            this.cmdCerrarReporteFacturas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdCerrarReporteFacturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdCerrarReporteFacturas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdCerrarReporteFacturas.FlatAppearance.BorderSize = 0;
            this.cmdCerrarReporteFacturas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdCerrarReporteFacturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.cmdCerrarReporteFacturas.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrarReporteFacturas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdCerrarReporteFacturas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdCerrarReporteFacturas.Location = new System.Drawing.Point(646, 388);
            this.cmdCerrarReporteFacturas.Name = "cmdCerrarReporteFacturas";
            this.cmdCerrarReporteFacturas.Size = new System.Drawing.Size(159, 105);
            this.cmdCerrarReporteFacturas.TabIndex = 92;
            this.cmdCerrarReporteFacturas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdCerrarReporteFacturas.UseVisualStyleBackColor = false;
            this.cmdCerrarReporteFacturas.Click += new System.EventHandler(this.cmdCerrarReporteFacturas_Click);
            this.cmdCerrarReporteFacturas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmdCerrarReporteFacturas_MouseDown);
            this.cmdCerrarReporteFacturas.MouseLeave += new System.EventHandler(this.cmdCerrarReporteFacturas_MouseLeave);
            this.cmdCerrarReporteFacturas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmdCerrarReporteFacturas_MouseMove);
            // 
            // lblSeleccionado
            // 
            this.lblSeleccionado.BackColor = System.Drawing.Color.Khaki;
            this.lblSeleccionado.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionado.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSeleccionado.Location = new System.Drawing.Point(16, 388);
            this.lblSeleccionado.Name = "lblSeleccionado";
            this.lblSeleccionado.Size = new System.Drawing.Size(248, 103);
            this.lblSeleccionado.TabIndex = 93;
            this.lblSeleccionado.Text = "No ha seleccionado una factura por el momento.";
            this.lblSeleccionado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CmdPagarFactura
            // 
            this.CmdPagarFactura.BackColor = System.Drawing.SystemColors.Control;
            this.CmdPagarFactura.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.BotonPagarFacturaReporte;
            this.CmdPagarFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CmdPagarFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmdPagarFactura.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CmdPagarFactura.FlatAppearance.BorderSize = 0;
            this.CmdPagarFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.CmdPagarFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.CmdPagarFactura.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdPagarFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CmdPagarFactura.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CmdPagarFactura.Location = new System.Drawing.Point(316, 388);
            this.CmdPagarFactura.Name = "CmdPagarFactura";
            this.CmdPagarFactura.Size = new System.Drawing.Size(159, 105);
            this.CmdPagarFactura.TabIndex = 94;
            this.CmdPagarFactura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CmdPagarFactura.UseVisualStyleBackColor = false;
            this.CmdPagarFactura.Click += new System.EventHandler(this.CmdPagarFactura_Click);
            this.CmdPagarFactura.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CmdPagarFactura_MouseDown);
            this.CmdPagarFactura.MouseLeave += new System.EventHandler(this.CmdPagarFactura_MouseLeave);
            this.CmdPagarFactura.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CmdPagarFactura_MouseMove);
            // 
            // frmReportesFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.FondoReporteFacturas;
            this.ClientSize = new System.Drawing.Size(819, 500);
            this.Controls.Add(this.CmdPagarFactura);
            this.Controls.Add(this.lblSeleccionado);
            this.Controls.Add(this.cmdCerrarReporteFacturas);
            this.Controls.Add(this.cmdVerFacturaReporte);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvReporteFacturas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmReportesFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.frmReportesFacturas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbFechas.ResumeLayout(false);
            this.grbFechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteFacturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFiltrar;
        private System.Windows.Forms.DataGridView dgvReporteFacturas;
        private System.Windows.Forms.GroupBox grbFechas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dptFechaFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Button cmdVerFacturaReporte;
        private System.Windows.Forms.Button cmdCerrarReporteFacturas;
        private System.Windows.Forms.Label lblSeleccionado;
        private System.Windows.Forms.Button CmdPagarFactura;
    }
}