
namespace Sistema_de_Gestión.Presentacion
{
    partial class frmVerProforma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerProforma));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cmdBuscarCliente = new System.Windows.Forms.Button();
            this.txtTelefonos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContactos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtRNC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdVerProforma = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdBuscarPedido = new System.Windows.Forms.Button();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvConduceProforma = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtDescuento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtITBIS = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.StatusBarProforma = new System.Windows.Forms.StatusStrip();
            this.toolProformaEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolProformaPedidosRegistrados = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolProformaConducesRegistrados = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.gbCliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConduceProforma)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.StatusBarProforma.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(10, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 13);
            this.label8.TabIndex = 94;
            this.label8.Text = "PEDIDOS PENDIENTES ASOCIADOS AL CLIENTE:";
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedidos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPedidos.Location = new System.Drawing.Point(12, 137);
            this.dgvPedidos.MultiSelect = false;
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(999, 207);
            this.dgvPedidos.TabIndex = 93;
            this.dgvPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_CellClick);
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.txtCliente);
            this.gbCliente.Controls.Add(this.txtCodigoCliente);
            this.gbCliente.Controls.Add(this.label20);
            this.gbCliente.Controls.Add(this.cmdBuscarCliente);
            this.gbCliente.Controls.Add(this.txtTelefonos);
            this.gbCliente.Controls.Add(this.label5);
            this.gbCliente.Controls.Add(this.txtContactos);
            this.gbCliente.Controls.Add(this.label4);
            this.gbCliente.Controls.Add(this.TxtRNC);
            this.gbCliente.Controls.Add(this.label3);
            this.gbCliente.Controls.Add(this.label2);
            this.gbCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(12, 12);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(669, 89);
            this.gbCliente.TabIndex = 92;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Info. Cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.Khaki;
            this.txtCliente.Enabled = false;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(293, 23);
            this.txtCliente.MaxLength = 60;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(360, 21);
            this.txtCliente.TabIndex = 74;
            this.txtCliente.Tag = "Cliente";
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.BackColor = System.Drawing.Color.White;
            this.txtCodigoCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCliente.ForeColor = System.Drawing.Color.DarkRed;
            this.txtCodigoCliente.Location = new System.Drawing.Point(75, 23);
            this.txtCodigoCliente.MaxLength = 7;
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(103, 24);
            this.txtCodigoCliente.TabIndex = 73;
            this.txtCodigoCliente.Tag = "Codigo";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DarkRed;
            this.label20.Location = new System.Drawing.Point(23, 27);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 16);
            this.label20.TabIndex = 86;
            this.label20.Text = "Codigo:";
            // 
            // cmdBuscarCliente
            // 
            this.cmdBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("cmdBuscarCliente.Image")));
            this.cmdBuscarCliente.Location = new System.Drawing.Point(184, 22);
            this.cmdBuscarCliente.Name = "cmdBuscarCliente";
            this.cmdBuscarCliente.Size = new System.Drawing.Size(36, 26);
            this.cmdBuscarCliente.TabIndex = 85;
            this.cmdBuscarCliente.UseVisualStyleBackColor = true;
            this.cmdBuscarCliente.Click += new System.EventHandler(this.cmdBuscarCliente_Click);
            // 
            // txtTelefonos
            // 
            this.txtTelefonos.BackColor = System.Drawing.Color.Khaki;
            this.txtTelefonos.Enabled = false;
            this.txtTelefonos.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonos.Location = new System.Drawing.Point(495, 53);
            this.txtTelefonos.MaxLength = 60;
            this.txtTelefonos.Name = "txtTelefonos";
            this.txtTelefonos.Size = new System.Drawing.Size(158, 21);
            this.txtTelefonos.TabIndex = 79;
            this.txtTelefonos.Tag = "Telefonos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(460, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 81;
            this.label5.Text = "Tels:";
            // 
            // txtContactos
            // 
            this.txtContactos.BackColor = System.Drawing.Color.Khaki;
            this.txtContactos.Enabled = false;
            this.txtContactos.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactos.Location = new System.Drawing.Point(293, 54);
            this.txtContactos.MaxLength = 80;
            this.txtContactos.Name = "txtContactos";
            this.txtContactos.Size = new System.Drawing.Size(161, 21);
            this.txtContactos.TabIndex = 77;
            this.txtContactos.Tag = "Contactos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(225, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 78;
            this.label4.Text = "Contactos:";
            // 
            // TxtRNC
            // 
            this.TxtRNC.BackColor = System.Drawing.Color.Khaki;
            this.TxtRNC.Enabled = false;
            this.TxtRNC.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRNC.Location = new System.Drawing.Point(75, 54);
            this.TxtRNC.MaxLength = 15;
            this.TxtRNC.Name = "TxtRNC";
            this.TxtRNC.Size = new System.Drawing.Size(145, 21);
            this.TxtRNC.TabIndex = 76;
            this.TxtRNC.Tag = "RNC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(34, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 75;
            this.label3.Text = "RNC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(234, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 72;
            this.label2.Text = "Empresa:";
            // 
            // cmdVerProforma
            // 
            this.cmdVerProforma.Location = new System.Drawing.Point(652, 462);
            this.cmdVerProforma.Name = "cmdVerProforma";
            this.cmdVerProforma.Size = new System.Drawing.Size(140, 83);
            this.cmdVerProforma.TabIndex = 98;
            this.cmdVerProforma.Text = "Ver Proforma";
            this.cmdVerProforma.UseVisualStyleBackColor = true;
            this.cmdVerProforma.Click += new System.EventHandler(this.cmdVerProforma_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdBuscarPedido);
            this.groupBox1.Controls.Add(this.dtpFechaFin);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpFechaInicio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(713, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 88);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rango de fechas:";
            // 
            // cmdBuscarPedido
            // 
            this.cmdBuscarPedido.Location = new System.Drawing.Point(174, 21);
            this.cmdBuscarPedido.Name = "cmdBuscarPedido";
            this.cmdBuscarPedido.Size = new System.Drawing.Size(103, 48);
            this.cmdBuscarPedido.TabIndex = 100;
            this.cmdBuscarPedido.Text = "VER PEDIDOS";
            this.cmdBuscarPedido.UseVisualStyleBackColor = true;
            this.cmdBuscarPedido.Click += new System.EventHandler(this.cmdBuscarPedido_Click);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CustomFormat = "yyyy/mm/dd";
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(59, 48);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(105, 20);
            this.dtpFechaFin.TabIndex = 99;
            this.dtpFechaFin.Value = new System.DateTime(2023, 3, 29, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 98;
            this.label6.Text = "Fin:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CustomFormat = "yyyy/mm/dd";
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Location = new System.Drawing.Point(59, 22);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(105, 20);
            this.dtpFechaInicio.TabIndex = 97;
            this.dtpFechaInicio.Value = new System.DateTime(2023, 3, 29, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio:";
            // 
            // dgvConduceProforma
            // 
            this.dgvConduceProforma.AllowUserToAddRows = false;
            this.dgvConduceProforma.AllowUserToDeleteRows = false;
            this.dgvConduceProforma.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvConduceProforma.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvConduceProforma.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConduceProforma.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvConduceProforma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConduceProforma.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvConduceProforma.Location = new System.Drawing.Point(12, 368);
            this.dgvConduceProforma.MultiSelect = false;
            this.dgvConduceProforma.Name = "dgvConduceProforma";
            this.dgvConduceProforma.ReadOnly = true;
            this.dgvConduceProforma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConduceProforma.Size = new System.Drawing.Size(625, 177);
            this.dgvConduceProforma.TabIndex = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(10, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 13);
            this.label7.TabIndex = 101;
            this.label7.Text = "CONDUCES ASOCIADOS AL PEDIDO:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.TxtDescuento);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtITBIS);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtSubTotal);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(652, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 94);
            this.groupBox2.TabIndex = 102;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total Pendientes:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.Khaki;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(244, 54);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(108, 20);
            this.txtTotal.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(208, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Total:";
            // 
            // TxtDescuento
            // 
            this.TxtDescuento.BackColor = System.Drawing.Color.Khaki;
            this.TxtDescuento.Enabled = false;
            this.TxtDescuento.Location = new System.Drawing.Point(244, 28);
            this.TxtDescuento.Name = "TxtDescuento";
            this.TxtDescuento.Size = new System.Drawing.Size(108, 20);
            this.TxtDescuento.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(180, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Descuento:";
            // 
            // txtITBIS
            // 
            this.txtITBIS.BackColor = System.Drawing.Color.Khaki;
            this.txtITBIS.Enabled = false;
            this.txtITBIS.Location = new System.Drawing.Point(68, 54);
            this.txtITBIS.Name = "txtITBIS";
            this.txtITBIS.Size = new System.Drawing.Size(108, 20);
            this.txtITBIS.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(29, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "ITBIS:";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.Color.Khaki;
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(68, 28);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(108, 20);
            this.txtSubTotal.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(10, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sub-Total:";
            // 
            // StatusBarProforma
            // 
            this.StatusBarProforma.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolProformaEstado,
            this.toolProformaPedidosRegistrados,
            this.toolProformaConducesRegistrados});
            this.StatusBarProforma.Location = new System.Drawing.Point(0, 552);
            this.StatusBarProforma.Name = "StatusBarProforma";
            this.StatusBarProforma.Size = new System.Drawing.Size(1030, 22);
            this.StatusBarProforma.TabIndex = 103;
            this.StatusBarProforma.Text = "statusStrip1";
            // 
            // toolProformaEstado
            // 
            this.toolProformaEstado.AutoSize = false;
            this.toolProformaEstado.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolProformaEstado.Name = "toolProformaEstado";
            this.toolProformaEstado.Size = new System.Drawing.Size(80, 17);
            this.toolProformaEstado.Text = "LIsto";
            // 
            // toolProformaPedidosRegistrados
            // 
            this.toolProformaPedidosRegistrados.AutoSize = false;
            this.toolProformaPedidosRegistrados.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolProformaPedidosRegistrados.Name = "toolProformaPedidosRegistrados";
            this.toolProformaPedidosRegistrados.Size = new System.Drawing.Size(134, 17);
            this.toolProformaPedidosRegistrados.Text = "Pedidos registrados: 0";
            // 
            // toolProformaConducesRegistrados
            // 
            this.toolProformaConducesRegistrados.AutoSize = false;
            this.toolProformaConducesRegistrados.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolProformaConducesRegistrados.Name = "toolProformaConducesRegistrados";
            this.toolProformaConducesRegistrados.Size = new System.Drawing.Size(84, 17);
            this.toolProformaConducesRegistrados.Text = "Conduces: 0";
            // 
            // frmVerProforma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 574);
            this.Controls.Add(this.StatusBarProforma);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvConduceProforma);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdVerProforma);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.gbCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmVerProforma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura Proforma";
            this.Load += new System.EventHandler(this.frmVerProforma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConduceProforma)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.StatusBarProforma.ResumeLayout(false);
            this.StatusBarProforma.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button cmdBuscarCliente;
        private System.Windows.Forms.TextBox txtTelefonos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContactos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtRNC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdVerProforma;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdBuscarPedido;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvConduceProforma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtDescuento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtITBIS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.StatusStrip StatusBarProforma;
        private System.Windows.Forms.ToolStripStatusLabel toolProformaEstado;
        private System.Windows.Forms.ToolStripStatusLabel toolProformaPedidosRegistrados;
        private System.Windows.Forms.ToolStripStatusLabel toolProformaConducesRegistrados;
    }
}