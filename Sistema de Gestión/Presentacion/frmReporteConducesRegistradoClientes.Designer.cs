
namespace Sistema_de_Gestión.Presentacion
{
    partial class frmReporteConducesRegistradoClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteConducesRegistradoClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbTotalGeneral = new System.Windows.Forms.GroupBox();
            this.lblTotalConduces = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cmdBuscarCliente = new System.Windows.Forms.Button();
            this.cmdVerConduces = new System.Windows.Forms.Button();
            this.cmdResetCriterios = new System.Windows.Forms.Button();
            this.cmdBuscarPedido = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboModoReporte = new System.Windows.Forms.ComboBox();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvConducesRegistrados = new System.Windows.Forms.DataGridView();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.txtProyecto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtTelefonos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtRNC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblConducesRegistrados = new System.Windows.Forms.Label();
            this.gbTotalGeneral.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConducesRegistrados)).BeginInit();
            this.gbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTotalGeneral
            // 
            this.gbTotalGeneral.BackColor = System.Drawing.Color.Transparent;
            this.gbTotalGeneral.Controls.Add(this.lblTotalConduces);
            this.gbTotalGeneral.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTotalGeneral.Location = new System.Drawing.Point(758, 505);
            this.gbTotalGeneral.Name = "gbTotalGeneral";
            this.gbTotalGeneral.Size = new System.Drawing.Size(256, 80);
            this.gbTotalGeneral.TabIndex = 110;
            this.gbTotalGeneral.TabStop = false;
            this.gbTotalGeneral.Text = "TOTAL GENERAL;";
            // 
            // lblTotalConduces
            // 
            this.lblTotalConduces.BackColor = System.Drawing.Color.Khaki;
            this.lblTotalConduces.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalConduces.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalConduces.Location = new System.Drawing.Point(6, 20);
            this.lblTotalConduces.Name = "lblTotalConduces";
            this.lblTotalConduces.Size = new System.Drawing.Size(244, 52);
            this.lblTotalConduces.TabIndex = 0;
            this.lblTotalConduces.Text = "$0.00";
            this.lblTotalConduces.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGray;
            this.label9.Location = new System.Drawing.Point(773, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(229, 59);
            this.label9.TabIndex = 109;
            this.label9.Text = "REPORTE DE CONDUCES REGISTRADOS";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.cmdVerConduces);
            this.groupBox1.Controls.Add(this.cmdResetCriterios);
            this.groupBox1.Controls.Add(this.cmdBuscarPedido);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(758, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 401);
            this.groupBox1.TabIndex = 108;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criterios de búsqueda:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cboClientes);
            this.groupBox3.Controls.Add(this.txtCodigoCliente);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.cmdBuscarCliente);
            this.groupBox3.Location = new System.Drawing.Point(18, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 93);
            this.groupBox3.TabIndex = 107;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Clientes:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 108;
            this.label10.Text = "Cliente:";
            // 
            // cboClientes
            // 
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Items.AddRange(new object[] {
            "Todos",
            "Especificar"});
            this.cboClientes.Location = new System.Drawing.Point(54, 27);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(170, 21);
            this.cboClientes.TabIndex = 107;
            this.cboClientes.SelectedIndexChanged += new System.EventHandler(this.cboClientes_SelectedIndexChanged);
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.BackColor = System.Drawing.Color.White;
            this.txtCodigoCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCliente.ForeColor = System.Drawing.Color.DarkRed;
            this.txtCodigoCliente.Location = new System.Drawing.Point(125, 54);
            this.txtCodigoCliente.MaxLength = 7;
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(59, 24);
            this.txtCodigoCliente.TabIndex = 88;
            this.txtCodigoCliente.Tag = "Codigo";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label20.ForeColor = System.Drawing.Color.DarkRed;
            this.label20.Location = new System.Drawing.Point(81, 59);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 13);
            this.label20.TabIndex = 91;
            this.label20.Text = "Codigo:";
            // 
            // cmdBuscarCliente
            // 
            this.cmdBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("cmdBuscarCliente.Image")));
            this.cmdBuscarCliente.Location = new System.Drawing.Point(187, 52);
            this.cmdBuscarCliente.Name = "cmdBuscarCliente";
            this.cmdBuscarCliente.Size = new System.Drawing.Size(36, 26);
            this.cmdBuscarCliente.TabIndex = 90;
            this.cmdBuscarCliente.UseVisualStyleBackColor = true;
            this.cmdBuscarCliente.Click += new System.EventHandler(this.cmdBuscarCliente_Click);
            // 
            // cmdVerConduces
            // 
            this.cmdVerConduces.BackColor = System.Drawing.SystemColors.Control;
            this.cmdVerConduces.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.BotonVerConduces;
            this.cmdVerConduces.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdVerConduces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdVerConduces.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdVerConduces.FlatAppearance.BorderSize = 0;
            this.cmdVerConduces.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdVerConduces.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.cmdVerConduces.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVerConduces.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdVerConduces.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdVerConduces.Location = new System.Drawing.Point(19, 335);
            this.cmdVerConduces.Name = "cmdVerConduces";
            this.cmdVerConduces.Size = new System.Drawing.Size(229, 52);
            this.cmdVerConduces.TabIndex = 106;
            this.cmdVerConduces.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdVerConduces.UseVisualStyleBackColor = false;
            this.cmdVerConduces.Click += new System.EventHandler(this.cmdVerConduces_Click);
            this.cmdVerConduces.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmdVerConduces_MouseDown);
            this.cmdVerConduces.MouseLeave += new System.EventHandler(this.cmdVerConduces_MouseLeave);
            this.cmdVerConduces.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmdVerConduces_MouseMove);
            // 
            // cmdResetCriterios
            // 
            this.cmdResetCriterios.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.BotonResetCriteriosProforma;
            this.cmdResetCriterios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdResetCriterios.Location = new System.Drawing.Point(135, 285);
            this.cmdResetCriterios.Name = "cmdResetCriterios";
            this.cmdResetCriterios.Size = new System.Drawing.Size(112, 48);
            this.cmdResetCriterios.TabIndex = 105;
            this.cmdResetCriterios.UseVisualStyleBackColor = true;
            this.cmdResetCriterios.Click += new System.EventHandler(this.cmdResetCriterios_Click);
            this.cmdResetCriterios.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmdResetCriterios_MouseDown);
            this.cmdResetCriterios.MouseLeave += new System.EventHandler(this.cmdResetCriterios_MouseLeave);
            this.cmdResetCriterios.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmdResetCriterios_MouseMove);
            // 
            // cmdBuscarPedido
            // 
            this.cmdBuscarPedido.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.BotonBuscarPedidosProforma;
            this.cmdBuscarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdBuscarPedido.Location = new System.Drawing.Point(19, 285);
            this.cmdBuscarPedido.Name = "cmdBuscarPedido";
            this.cmdBuscarPedido.Size = new System.Drawing.Size(112, 48);
            this.cmdBuscarPedido.TabIndex = 104;
            this.cmdBuscarPedido.UseVisualStyleBackColor = true;
            this.cmdBuscarPedido.Click += new System.EventHandler(this.cmdBuscarPedido_Click);
            this.cmdBuscarPedido.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmdBuscarPedido_MouseDown);
            this.cmdBuscarPedido.MouseLeave += new System.EventHandler(this.cmdBuscarPedido_MouseLeave);
            this.cmdBuscarPedido.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmdBuscarPedido_MouseMove);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cboModoReporte);
            this.groupBox2.Controls.Add(this.dtpFechaFin);
            this.groupBox2.Controls.Add(this.dtpFechaInicio);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(18, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 121);
            this.groupBox2.TabIndex = 101;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fechas:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 106;
            this.label11.Text = "Por:";
            // 
            // cboModoReporte
            // 
            this.cboModoReporte.FormattingEnabled = true;
            this.cboModoReporte.Items.AddRange(new object[] {
            "Todas",
            "Rango"});
            this.cboModoReporte.Location = new System.Drawing.Point(46, 28);
            this.cboModoReporte.Name = "cboModoReporte";
            this.cboModoReporte.Size = new System.Drawing.Size(170, 21);
            this.cboModoReporte.TabIndex = 105;
            this.cboModoReporte.SelectedIndexChanged += new System.EventHandler(this.cboModoReporte_SelectedIndexChanged);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CustomFormat = "yyyy/MM/dd";
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(46, 86);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(170, 20);
            this.dtpFechaFin.TabIndex = 104;
            this.dtpFechaFin.Value = new System.DateTime(2023, 3, 27, 0, 0, 0, 0);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CustomFormat = "yyyy/MM/dd";
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Location = new System.Drawing.Point(46, 60);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(170, 20);
            this.dtpFechaInicio.TabIndex = 103;
            this.dtpFechaInicio.Value = new System.DateTime(2023, 3, 27, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 102;
            this.label6.Text = "Fin:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 101;
            this.label7.Text = "Inicio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 16);
            this.label8.TabIndex = 107;
            this.label8.Text = "Listado de Conduces Registrados:";
            // 
            // dgvConducesRegistrados
            // 
            this.dgvConducesRegistrados.AllowUserToAddRows = false;
            this.dgvConducesRegistrados.AllowUserToDeleteRows = false;
            this.dgvConducesRegistrados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvConducesRegistrados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvConducesRegistrados.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConducesRegistrados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvConducesRegistrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConducesRegistrados.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvConducesRegistrados.Location = new System.Drawing.Point(14, 135);
            this.dgvConducesRegistrados.MultiSelect = false;
            this.dgvConducesRegistrados.Name = "dgvConducesRegistrados";
            this.dgvConducesRegistrados.ReadOnly = true;
            this.dgvConducesRegistrados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConducesRegistrados.Size = new System.Drawing.Size(726, 423);
            this.dgvConducesRegistrados.TabIndex = 104;
            // 
            // gbCliente
            // 
            this.gbCliente.BackColor = System.Drawing.Color.Transparent;
            this.gbCliente.Controls.Add(this.txtProyecto);
            this.gbCliente.Controls.Add(this.label1);
            this.gbCliente.Controls.Add(this.txtCliente);
            this.gbCliente.Controls.Add(this.txtTelefonos);
            this.gbCliente.Controls.Add(this.label5);
            this.gbCliente.Controls.Add(this.label2);
            this.gbCliente.Controls.Add(this.TxtRNC);
            this.gbCliente.Controls.Add(this.label3);
            this.gbCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(14, 14);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(718, 87);
            this.gbCliente.TabIndex = 103;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Info. Cliente:";
            // 
            // txtProyecto
            // 
            this.txtProyecto.BackColor = System.Drawing.Color.Khaki;
            this.txtProyecto.Enabled = false;
            this.txtProyecto.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProyecto.Location = new System.Drawing.Point(76, 52);
            this.txtProyecto.MaxLength = 60;
            this.txtProyecto.Name = "txtProyecto";
            this.txtProyecto.Size = new System.Drawing.Size(269, 21);
            this.txtProyecto.TabIndex = 90;
            this.txtProyecto.Tag = "Proyecto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(19, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 89;
            this.label1.Text = "Proyecto:";
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.Khaki;
            this.txtCliente.Enabled = false;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(76, 23);
            this.txtCliente.MaxLength = 60;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(269, 21);
            this.txtCliente.TabIndex = 89;
            this.txtCliente.Tag = "Cliente";
            // 
            // txtTelefonos
            // 
            this.txtTelefonos.BackColor = System.Drawing.Color.Khaki;
            this.txtTelefonos.Enabled = false;
            this.txtTelefonos.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonos.Location = new System.Drawing.Point(385, 52);
            this.txtTelefonos.MaxLength = 60;
            this.txtTelefonos.Name = "txtTelefonos";
            this.txtTelefonos.Size = new System.Drawing.Size(189, 21);
            this.txtTelefonos.TabIndex = 79;
            this.txtTelefonos.Tag = "Telefonos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(352, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 14);
            this.label5.TabIndex = 81;
            this.label5.Text = "Tels:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(18, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 87;
            this.label2.Text = "Empresa:";
            // 
            // TxtRNC
            // 
            this.TxtRNC.BackColor = System.Drawing.Color.Khaki;
            this.TxtRNC.Enabled = false;
            this.TxtRNC.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRNC.Location = new System.Drawing.Point(385, 23);
            this.TxtRNC.MaxLength = 15;
            this.TxtRNC.Name = "TxtRNC";
            this.TxtRNC.Size = new System.Drawing.Size(189, 21);
            this.TxtRNC.TabIndex = 76;
            this.TxtRNC.Tag = "RNC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(351, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 14);
            this.label3.TabIndex = 75;
            this.label3.Text = "RNC:";
            // 
            // LblConducesRegistrados
            // 
            this.LblConducesRegistrados.AutoSize = true;
            this.LblConducesRegistrados.BackColor = System.Drawing.Color.Transparent;
            this.LblConducesRegistrados.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConducesRegistrados.ForeColor = System.Drawing.Color.White;
            this.LblConducesRegistrados.Location = new System.Drawing.Point(14, 567);
            this.LblConducesRegistrados.Name = "LblConducesRegistrados";
            this.LblConducesRegistrados.Size = new System.Drawing.Size(153, 16);
            this.LblConducesRegistrados.TabIndex = 111;
            this.LblConducesRegistrados.Text = "Conduces Regisrados: 0";
            // 
            // frmReporteConducesRegistradoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.FondoProforma;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1030, 598);
            this.Controls.Add(this.LblConducesRegistrados);
            this.Controls.Add(this.gbTotalGeneral);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvConducesRegistrados);
            this.Controls.Add(this.gbCliente);
            this.Name = "frmReporteConducesRegistradoClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Conduces Registrados";
            this.Load += new System.EventHandler(this.frmReporteConducesRegistradoClientes_Load);
            this.gbTotalGeneral.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConducesRegistrados)).EndInit();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTotalGeneral;
        private System.Windows.Forms.Label lblTotalConduces;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdVerConduces;
        private System.Windows.Forms.Button cmdResetCriterios;
        private System.Windows.Forms.Button cmdBuscarPedido;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboModoReporte;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvConducesRegistrados;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button cmdBuscarCliente;
        private System.Windows.Forms.TextBox txtProyecto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefonos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtRNC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblConducesRegistrados;
    }
}