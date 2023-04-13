
namespace Sistema_de_Gestión.Presentacion
{
    partial class frmPagarFactura
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
            this.lblNumFactura = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMetodos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConceptoPago = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalPagado = new System.Windows.Forms.TextBox();
            this.gbTransferencia = new System.Windows.Forms.GroupBox();
            this.cboBancoTransferencia = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCuentaOrigen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gbCheque = new System.Windows.Forms.GroupBox();
            this.cboBancos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumCheque = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbEfectivo = new System.Windows.Forms.GroupBox();
            this.lblEfectivo = new System.Windows.Forms.Label();
            this.cmdAplicarPago = new System.Windows.Forms.Button();
            this.lblTotalFactura = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gbPago = new System.Windows.Forms.GroupBox();
            this.rbAbonoPago = new System.Windows.Forms.RadioButton();
            this.rbTotalPago = new System.Windows.Forms.RadioButton();
            this.lblBanco = new System.Windows.Forms.Label();
            this.lblMontoPendiente = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbTransferencia.SuspendLayout();
            this.gbCheque.SuspendLayout();
            this.gbEfectivo.SuspendLayout();
            this.gbPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumFactura
            // 
            this.lblNumFactura.BackColor = System.Drawing.Color.White;
            this.lblNumFactura.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFactura.ForeColor = System.Drawing.Color.DimGray;
            this.lblNumFactura.Location = new System.Drawing.Point(12, 39);
            this.lblNumFactura.Name = "lblNumFactura";
            this.lblNumFactura.Size = new System.Drawing.Size(250, 20);
            this.lblNumFactura.TabIndex = 19;
            this.lblNumFactura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Num. Factura";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 14);
            this.label3.TabIndex = 22;
            this.label3.Text = "Metodo Pago:";
            // 
            // cboMetodos
            // 
            this.cboMetodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMetodos.FormattingEnabled = true;
            this.cboMetodos.Location = new System.Drawing.Point(16, 221);
            this.cboMetodos.Name = "cboMetodos";
            this.cboMetodos.Size = new System.Drawing.Size(163, 21);
            this.cboMetodos.TabIndex = 24;
            this.cboMetodos.SelectedIndexChanged += new System.EventHandler(this.cboMetodos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 14);
            this.label2.TabIndex = 26;
            this.label2.Text = "Concepto Pago:";
            // 
            // txtConceptoPago
            // 
            this.txtConceptoPago.Location = new System.Drawing.Point(370, 135);
            this.txtConceptoPago.MaxLength = 65;
            this.txtConceptoPago.Multiline = true;
            this.txtConceptoPago.Name = "txtConceptoPago";
            this.txtConceptoPago.Size = new System.Drawing.Size(204, 55);
            this.txtConceptoPago.TabIndex = 27;
            this.txtConceptoPago.Tag = "Concepto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(415, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 14);
            this.label4.TabIndex = 28;
            this.label4.Text = "Total a pagar:";
            // 
            // txtTotalPagado
            // 
            this.txtTotalPagado.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPagado.Location = new System.Drawing.Point(417, 213);
            this.txtTotalPagado.Name = "txtTotalPagado";
            this.txtTotalPagado.ReadOnly = true;
            this.txtTotalPagado.Size = new System.Drawing.Size(157, 28);
            this.txtTotalPagado.TabIndex = 29;
            this.txtTotalPagado.Tag = "Total Pagado";
            this.txtTotalPagado.Text = "0.00";
            this.txtTotalPagado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalPagado_KeyPress);
            // 
            // gbTransferencia
            // 
            this.gbTransferencia.BackColor = System.Drawing.Color.Transparent;
            this.gbTransferencia.Controls.Add(this.cboBancoTransferencia);
            this.gbTransferencia.Controls.Add(this.label8);
            this.gbTransferencia.Controls.Add(this.txtCuentaOrigen);
            this.gbTransferencia.Controls.Add(this.label9);
            this.gbTransferencia.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTransferencia.Location = new System.Drawing.Point(297, 352);
            this.gbTransferencia.Name = "gbTransferencia";
            this.gbTransferencia.Size = new System.Drawing.Size(244, 82);
            this.gbTransferencia.TabIndex = 26;
            this.gbTransferencia.TabStop = false;
            this.gbTransferencia.Text = "Detalle Transferencia:";
            this.gbTransferencia.Visible = false;
            // 
            // cboBancoTransferencia
            // 
            this.cboBancoTransferencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBancoTransferencia.FormattingEnabled = true;
            this.cboBancoTransferencia.Location = new System.Drawing.Point(93, 51);
            this.cboBancoTransferencia.Name = "cboBancoTransferencia";
            this.cboBancoTransferencia.Size = new System.Drawing.Size(139, 22);
            this.cboBancoTransferencia.TabIndex = 3;
            this.cboBancoTransferencia.SelectedIndexChanged += new System.EventHandler(this.cboBancoTransferencia_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Khaki;
            this.label8.Location = new System.Drawing.Point(49, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 14);
            this.label8.TabIndex = 2;
            this.label8.Text = "Banco:";
            // 
            // txtCuentaOrigen
            // 
            this.txtCuentaOrigen.Location = new System.Drawing.Point(93, 25);
            this.txtCuentaOrigen.Name = "txtCuentaOrigen";
            this.txtCuentaOrigen.Size = new System.Drawing.Size(139, 21);
            this.txtCuentaOrigen.TabIndex = 1;
            this.txtCuentaOrigen.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Khaki;
            this.label9.Location = new System.Drawing.Point(6, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 14);
            this.label9.TabIndex = 0;
            this.label9.Text = "Cuenta Origen:";
            // 
            // gbCheque
            // 
            this.gbCheque.BackColor = System.Drawing.Color.Transparent;
            this.gbCheque.Controls.Add(this.cboBancos);
            this.gbCheque.Controls.Add(this.label6);
            this.gbCheque.Controls.Add(this.txtNumCheque);
            this.gbCheque.Controls.Add(this.label5);
            this.gbCheque.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCheque.Location = new System.Drawing.Point(18, 348);
            this.gbCheque.Name = "gbCheque";
            this.gbCheque.Size = new System.Drawing.Size(244, 82);
            this.gbCheque.TabIndex = 30;
            this.gbCheque.TabStop = false;
            this.gbCheque.Text = "Detalle Cheque:";
            this.gbCheque.Visible = false;
            // 
            // cboBancos
            // 
            this.cboBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBancos.FormattingEnabled = true;
            this.cboBancos.Location = new System.Drawing.Point(88, 51);
            this.cboBancos.Name = "cboBancos";
            this.cboBancos.Size = new System.Drawing.Size(139, 24);
            this.cboBancos.TabIndex = 3;
            this.cboBancos.SelectedIndexChanged += new System.EventHandler(this.cboBancos_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Khaki;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 14);
            this.label6.TabIndex = 2;
            this.label6.Text = "Banco:";
            // 
            // txtNumCheque
            // 
            this.txtNumCheque.Location = new System.Drawing.Point(89, 25);
            this.txtNumCheque.Name = "txtNumCheque";
            this.txtNumCheque.Size = new System.Drawing.Size(139, 23);
            this.txtNumCheque.TabIndex = 1;
            this.txtNumCheque.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Khaki;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Num. Cheque:";
            // 
            // gbEfectivo
            // 
            this.gbEfectivo.BackColor = System.Drawing.Color.Transparent;
            this.gbEfectivo.Controls.Add(this.lblEfectivo);
            this.gbEfectivo.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEfectivo.Location = new System.Drawing.Point(18, 261);
            this.gbEfectivo.Name = "gbEfectivo";
            this.gbEfectivo.Size = new System.Drawing.Size(244, 82);
            this.gbEfectivo.TabIndex = 32;
            this.gbEfectivo.TabStop = false;
            this.gbEfectivo.Text = "Detalle:";
            // 
            // lblEfectivo
            // 
            this.lblEfectivo.AutoSize = true;
            this.lblEfectivo.BackColor = System.Drawing.Color.Transparent;
            this.lblEfectivo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEfectivo.ForeColor = System.Drawing.Color.Black;
            this.lblEfectivo.Location = new System.Drawing.Point(20, 32);
            this.lblEfectivo.Name = "lblEfectivo";
            this.lblEfectivo.Size = new System.Drawing.Size(205, 21);
            this.lblEfectivo.TabIndex = 32;
            this.lblEfectivo.Text = "Pago recibido en efectivo";
            // 
            // cmdAplicarPago
            // 
            this.cmdAplicarPago.BackColor = System.Drawing.SystemColors.Control;
            this.cmdAplicarPago.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.BotonPagarFacturaReporte;
            this.cmdAplicarPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdAplicarPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdAplicarPago.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdAplicarPago.FlatAppearance.BorderSize = 0;
            this.cmdAplicarPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdAplicarPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.cmdAplicarPago.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAplicarPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdAplicarPago.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdAplicarPago.Location = new System.Drawing.Point(415, 248);
            this.cmdAplicarPago.Name = "cmdAplicarPago";
            this.cmdAplicarPago.Size = new System.Drawing.Size(159, 105);
            this.cmdAplicarPago.TabIndex = 95;
            this.cmdAplicarPago.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdAplicarPago.UseVisualStyleBackColor = false;
            this.cmdAplicarPago.Click += new System.EventHandler(this.cmdAplicarPago_Click);
            this.cmdAplicarPago.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmdAplicarPago_MouseDown);
            this.cmdAplicarPago.MouseLeave += new System.EventHandler(this.cmdAplicarPago_MouseLeave);
            this.cmdAplicarPago.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmdAplicarPago_MouseMove);
            // 
            // lblTotalFactura
            // 
            this.lblTotalFactura.BackColor = System.Drawing.Color.White;
            this.lblTotalFactura.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFactura.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotalFactura.Location = new System.Drawing.Point(12, 119);
            this.lblTotalFactura.Name = "lblTotalFactura";
            this.lblTotalFactura.Size = new System.Drawing.Size(250, 20);
            this.lblTotalFactura.TabIndex = 97;
            this.lblTotalFactura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Silver;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(250, 16);
            this.label11.TabIndex = 96;
            this.label11.Text = "Total Factura";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodigoCliente
            // 
            this.lblCodigoCliente.BackColor = System.Drawing.Color.White;
            this.lblCodigoCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCliente.ForeColor = System.Drawing.Color.DimGray;
            this.lblCodigoCliente.Location = new System.Drawing.Point(12, 79);
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            this.lblCodigoCliente.Size = new System.Drawing.Size(250, 20);
            this.lblCodigoCliente.TabIndex = 99;
            this.lblCodigoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Silver;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(250, 16);
            this.label12.TabIndex = 98;
            this.label12.Text = "Cliente";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbPago
            // 
            this.gbPago.BackColor = System.Drawing.Color.Transparent;
            this.gbPago.Controls.Add(this.rbAbonoPago);
            this.gbPago.Controls.Add(this.rbTotalPago);
            this.gbPago.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPago.Location = new System.Drawing.Point(370, 54);
            this.gbPago.Name = "gbPago";
            this.gbPago.Size = new System.Drawing.Size(204, 55);
            this.gbPago.TabIndex = 100;
            this.gbPago.TabStop = false;
            this.gbPago.Text = "Pago:";
            // 
            // rbAbonoPago
            // 
            this.rbAbonoPago.AutoSize = true;
            this.rbAbonoPago.Location = new System.Drawing.Point(109, 22);
            this.rbAbonoPago.Name = "rbAbonoPago";
            this.rbAbonoPago.Size = new System.Drawing.Size(65, 18);
            this.rbAbonoPago.TabIndex = 1;
            this.rbAbonoPago.Text = "ABONO";
            this.rbAbonoPago.UseVisualStyleBackColor = true;
            this.rbAbonoPago.CheckedChanged += new System.EventHandler(this.rbAbonoPago_CheckedChanged);
            // 
            // rbTotalPago
            // 
            this.rbTotalPago.AutoSize = true;
            this.rbTotalPago.Checked = true;
            this.rbTotalPago.Location = new System.Drawing.Point(34, 22);
            this.rbTotalPago.Name = "rbTotalPago";
            this.rbTotalPago.Size = new System.Drawing.Size(59, 18);
            this.rbTotalPago.TabIndex = 0;
            this.rbTotalPago.TabStop = true;
            this.rbTotalPago.Text = "TOTAL";
            this.rbTotalPago.UseVisualStyleBackColor = true;
            this.rbTotalPago.CheckedChanged += new System.EventHandler(this.rbTotalPago_CheckedChanged);
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Location = new System.Drawing.Point(13, 20);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(0, 13);
            this.lblBanco.TabIndex = 101;
            this.lblBanco.Visible = false;
            // 
            // lblMontoPendiente
            // 
            this.lblMontoPendiente.BackColor = System.Drawing.Color.White;
            this.lblMontoPendiente.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoPendiente.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMontoPendiente.Location = new System.Drawing.Point(12, 159);
            this.lblMontoPendiente.Name = "lblMontoPendiente";
            this.lblMontoPendiente.Size = new System.Drawing.Size(250, 31);
            this.lblMontoPendiente.TabIndex = 103;
            this.lblMontoPendiente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Silver;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(12, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(250, 16);
            this.label10.TabIndex = 102;
            this.label10.Text = "Monto Pendiente";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPagarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.FondoPagoFacturaFinal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(597, 360);
            this.Controls.Add(this.lblMontoPendiente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblBanco);
            this.Controls.Add(this.gbPago);
            this.Controls.Add(this.lblCodigoCliente);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.gbEfectivo);
            this.Controls.Add(this.lblTotalFactura);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmdAplicarPago);
            this.Controls.Add(this.gbCheque);
            this.Controls.Add(this.gbTransferencia);
            this.Controls.Add(this.txtTotalPagado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConceptoPago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboMetodos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNumFactura);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPagarFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pagar Factura";
            this.Load += new System.EventHandler(this.frmPagarFactura_Load);
            this.gbTransferencia.ResumeLayout(false);
            this.gbTransferencia.PerformLayout();
            this.gbCheque.ResumeLayout(false);
            this.gbCheque.PerformLayout();
            this.gbEfectivo.ResumeLayout(false);
            this.gbEfectivo.PerformLayout();
            this.gbPago.ResumeLayout(false);
            this.gbPago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNumFactura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMetodos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConceptoPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalPagado;
        private System.Windows.Forms.GroupBox gbTransferencia;
        private System.Windows.Forms.ComboBox cboBancoTransferencia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCuentaOrigen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbCheque;
        private System.Windows.Forms.ComboBox cboBancos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumCheque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbEfectivo;
        private System.Windows.Forms.Label lblEfectivo;
        private System.Windows.Forms.Button cmdAplicarPago;
        private System.Windows.Forms.Label lblTotalFactura;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCodigoCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gbPago;
        private System.Windows.Forms.RadioButton rbAbonoPago;
        private System.Windows.Forms.RadioButton rbTotalPago;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.Label lblMontoPendiente;
        private System.Windows.Forms.Label label10;
    }
}