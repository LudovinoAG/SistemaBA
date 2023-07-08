
namespace Sistema_de_Gestión.Presentacion
{
    partial class frmActualizarFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizarFactura));
            this.dtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.cmdAplicar = new System.Windows.Forms.Button();
            this.lblNumFactura = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTipoFactura = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNCF = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboEstatusFactura = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtITBIS = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.dgvDetallesFactura = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtMontoPagado = new System.Windows.Forms.TextBox();
            this.lblPagado = new System.Windows.Forms.Label();
            this.txtMontoPendiente = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cboChoferes = new System.Windows.Forms.ComboBox();
            this.txtConduce = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cboVehiculos = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.nupCapacidad = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.NupCantidad = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.cboMedidas = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtSubTotalConduce = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtITBISConduce = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NupCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaFactura
            // 
            this.dtpFechaFactura.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFactura.Location = new System.Drawing.Point(560, 105);
            this.dtpFechaFactura.Name = "dtpFechaFactura";
            this.dtpFechaFactura.Size = new System.Drawing.Size(103, 20);
            this.dtpFechaFactura.TabIndex = 1;
            this.dtpFechaFactura.Value = new System.DateTime(2023, 6, 20, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Factura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Vencimiento:";
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(560, 131);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(103, 20);
            this.dtpFechaVencimiento.TabIndex = 5;
            this.dtpFechaVencimiento.Value = new System.DateTime(2023, 6, 20, 0, 0, 0, 0);
            // 
            // cmdAplicar
            // 
            this.cmdAplicar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAplicar.Location = new System.Drawing.Point(695, 555);
            this.cmdAplicar.Name = "cmdAplicar";
            this.cmdAplicar.Size = new System.Drawing.Size(129, 40);
            this.cmdAplicar.TabIndex = 7;
            this.cmdAplicar.Text = "GUARDAR";
            this.cmdAplicar.UseVisualStyleBackColor = true;
            this.cmdAplicar.Click += new System.EventHandler(this.cmdAplicar_Click);
            // 
            // lblNumFactura
            // 
            this.lblNumFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFactura.Location = new System.Drawing.Point(83, 12);
            this.lblNumFactura.Name = "lblNumFactura";
            this.lblNumFactura.Size = new System.Drawing.Size(50, 16);
            this.lblNumFactura.TabIndex = 9;
            this.lblNumFactura.Text = "0";
            this.lblNumFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(820, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mantenimiento";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Location = new System.Drawing.Point(12, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(932, 4);
            this.panel2.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Factura Num:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tipo de Factura:";
            // 
            // cboTipoFactura
            // 
            this.cboTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoFactura.FormattingEnabled = true;
            this.cboTipoFactura.Location = new System.Drawing.Point(98, 47);
            this.cboTipoFactura.Name = "cboTipoFactura";
            this.cboTipoFactura.Size = new System.Drawing.Size(148, 21);
            this.cboTipoFactura.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "NCF:";
            // 
            // txtNCF
            // 
            this.txtNCF.Location = new System.Drawing.Point(98, 78);
            this.txtNCF.Name = "txtNCF";
            this.txtNCF.Size = new System.Drawing.Size(148, 20);
            this.txtNCF.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(98, 108);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(148, 20);
            this.txtCliente.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Estatus:";
            // 
            // cboEstatusFactura
            // 
            this.cboEstatusFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstatusFactura.FormattingEnabled = true;
            this.cboEstatusFactura.Location = new System.Drawing.Point(98, 138);
            this.cboEstatusFactura.Name = "cboEstatusFactura";
            this.cboEstatusFactura.Size = new System.Drawing.Size(148, 21);
            this.cboEstatusFactura.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(282, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Sub-Total:";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(342, 47);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(103, 20);
            this.txtSubTotal.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(276, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Descuento:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(342, 76);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(103, 20);
            this.txtDescuento.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(301, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "ITBIS:";
            // 
            // txtITBIS
            // 
            this.txtITBIS.Location = new System.Drawing.Point(342, 105);
            this.txtITBIS.Name = "txtITBIS";
            this.txtITBIS.Size = new System.Drawing.Size(103, 20);
            this.txtITBIS.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(304, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(342, 134);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(103, 20);
            this.txtTotal.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(679, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Nota:";
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(716, 50);
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(228, 48);
            this.txtNota.TabIndex = 30;
            // 
            // dgvDetallesFactura
            // 
            this.dgvDetallesFactura.AllowUserToAddRows = false;
            this.dgvDetallesFactura.AllowUserToDeleteRows = false;
            this.dgvDetallesFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDetallesFactura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDetallesFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesFactura.Location = new System.Drawing.Point(15, 197);
            this.dgvDetallesFactura.MultiSelect = false;
            this.dgvDetallesFactura.Name = "dgvDetallesFactura";
            this.dgvDetallesFactura.ReadOnly = true;
            this.dgvDetallesFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetallesFactura.Size = new System.Drawing.Size(648, 150);
            this.dgvDetallesFactura.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Detalles de la factura:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 365);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Detalles de conduces:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 382);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 213);
            this.dataGridView1.TabIndex = 33;
            // 
            // txtMontoPagado
            // 
            this.txtMontoPagado.Location = new System.Drawing.Point(560, 49);
            this.txtMontoPagado.Name = "txtMontoPagado";
            this.txtMontoPagado.Size = new System.Drawing.Size(103, 20);
            this.txtMontoPagado.TabIndex = 36;
            // 
            // lblPagado
            // 
            this.lblPagado.AutoSize = true;
            this.lblPagado.Location = new System.Drawing.Point(479, 52);
            this.lblPagado.Name = "lblPagado";
            this.lblPagado.Size = new System.Drawing.Size(80, 13);
            this.lblPagado.TabIndex = 35;
            this.lblPagado.Text = "Monto Pagado:";
            // 
            // txtMontoPendiente
            // 
            this.txtMontoPendiente.Location = new System.Drawing.Point(560, 76);
            this.txtMontoPendiente.Name = "txtMontoPendiente";
            this.txtMontoPendiente.Size = new System.Drawing.Size(103, 20);
            this.txtMontoPendiente.TabIndex = 38;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(468, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "Monto Pendiente:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(704, 223);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "Chofer:";
            // 
            // cboChoferes
            // 
            this.cboChoferes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChoferes.FormattingEnabled = true;
            this.cboChoferes.Location = new System.Drawing.Point(751, 221);
            this.cboChoferes.Name = "cboChoferes";
            this.cboChoferes.Size = new System.Drawing.Size(193, 21);
            this.cboChoferes.TabIndex = 40;
            // 
            // txtConduce
            // 
            this.txtConduce.Location = new System.Drawing.Point(751, 193);
            this.txtConduce.Name = "txtConduce";
            this.txtConduce.Size = new System.Drawing.Size(116, 20);
            this.txtConduce.TabIndex = 42;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(692, 195);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 13);
            this.label18.TabIndex = 41;
            this.label18.Text = "Conduce:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(694, 252);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 13);
            this.label19.TabIndex = 43;
            this.label19.Text = "Vehiculo:";
            // 
            // cboVehiculos
            // 
            this.cboVehiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVehiculos.FormattingEnabled = true;
            this.cboVehiculos.Location = new System.Drawing.Point(751, 250);
            this.cboVehiculos.Name = "cboVehiculos";
            this.cboVehiculos.Size = new System.Drawing.Size(193, 21);
            this.cboVehiculos.TabIndex = 44;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(708, 281);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 13);
            this.label20.TabIndex = 45;
            this.label20.Text = "Placa:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(751, 278);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(116, 20);
            this.txtPlaca.TabIndex = 46;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(684, 310);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 13);
            this.label21.TabIndex = 47;
            this.label21.Text = "Capacidad:";
            // 
            // nupCapacidad
            // 
            this.nupCapacidad.DecimalPlaces = 2;
            this.nupCapacidad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nupCapacidad.Location = new System.Drawing.Point(751, 308);
            this.nupCapacidad.Name = "nupCapacidad";
            this.nupCapacidad.Size = new System.Drawing.Size(92, 20);
            this.nupCapacidad.TabIndex = 48;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(694, 365);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 13);
            this.label22.TabIndex = 49;
            this.label22.Text = "Producto:";
            // 
            // cboProducto
            // 
            this.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(751, 362);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(193, 21);
            this.cboProducto.TabIndex = 50;
            // 
            // NupCantidad
            // 
            this.NupCantidad.DecimalPlaces = 2;
            this.NupCantidad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.NupCantidad.Location = new System.Drawing.Point(751, 417);
            this.NupCantidad.Name = "NupCantidad";
            this.NupCantidad.Size = new System.Drawing.Size(92, 20);
            this.NupCantidad.TabIndex = 52;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(695, 419);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(52, 13);
            this.label23.TabIndex = 51;
            this.label23.Text = "Cantidad:";
            // 
            // cboMedidas
            // 
            this.cboMedidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMedidas.FormattingEnabled = true;
            this.cboMedidas.Location = new System.Drawing.Point(751, 444);
            this.cboMedidas.Name = "cboMedidas";
            this.cboMedidas.Size = new System.Drawing.Size(92, 21);
            this.cboMedidas.TabIndex = 54;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(697, 447);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(50, 13);
            this.label24.TabIndex = 53;
            this.label24.Text = "Medidas:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(751, 471);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(92, 20);
            this.txtPrecio.TabIndex = 56;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(707, 474);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(40, 13);
            this.label25.TabIndex = 55;
            this.label25.Text = "Precio:";
            // 
            // txtSubTotalConduce
            // 
            this.txtSubTotalConduce.Location = new System.Drawing.Point(751, 497);
            this.txtSubTotalConduce.Name = "txtSubTotalConduce";
            this.txtSubTotalConduce.Size = new System.Drawing.Size(92, 20);
            this.txtSubTotalConduce.TabIndex = 58;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(694, 500);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(53, 13);
            this.label26.TabIndex = 57;
            this.label26.Text = "SubTotal:";
            // 
            // txtITBISConduce
            // 
            this.txtITBISConduce.Location = new System.Drawing.Point(751, 523);
            this.txtITBISConduce.Name = "txtITBISConduce";
            this.txtITBISConduce.Size = new System.Drawing.Size(92, 20);
            this.txtITBISConduce.TabIndex = 60;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(710, 526);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(37, 13);
            this.label27.TabIndex = 59;
            this.label27.Text = "ITBIS:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(751, 390);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(193, 20);
            this.txtDescripcion.TabIndex = 62;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(681, 393);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(66, 13);
            this.label28.TabIndex = 61;
            this.label28.Text = "Descripción:";
            // 
            // frmActualizarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 607);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.txtITBISConduce);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtSubTotalConduce);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.cboMedidas);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.NupCantidad);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.cboProducto);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.nupCapacidad);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cboVehiculos);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtConduce);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cboChoferes);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtMontoPendiente);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtMontoPagado);
            this.Controls.Add(this.lblPagado);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDetallesFactura);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtITBIS);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboEstatusFactura);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNCF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboTipoFactura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNumFactura);
            this.Controls.Add(this.cmdAplicar);
            this.Controls.Add(this.dtpFechaVencimiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmActualizarFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.frmActualizarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NupCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpFechaFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.Button cmdAplicar;
        private System.Windows.Forms.Label lblNumFactura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTipoFactura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNCF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboEstatusFactura;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtITBIS;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.DataGridView dgvDetallesFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMontoPagado;
        private System.Windows.Forms.Label lblPagado;
        private System.Windows.Forms.TextBox txtMontoPendiente;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboChoferes;
        private System.Windows.Forms.TextBox txtConduce;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cboVehiculos;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown nupCapacidad;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.NumericUpDown NupCantidad;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cboMedidas;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtSubTotalConduce;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtITBISConduce;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label28;
    }
}