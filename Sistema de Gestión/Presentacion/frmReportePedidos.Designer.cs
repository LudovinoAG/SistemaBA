
namespace Sistema_de_Gestión.Presentacion
{
    partial class frmRedaccionesClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRedaccionesClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.txtProyecto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.dgvDetallesPedidos = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPedidoSeleccionado = new System.Windows.Forms.Label();
            this.cmdVerRedaccion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdBuscarPedido = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboEstatusPedidos = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nUpDownPedidos = new System.Windows.Forms.NumericUpDown();
            this.cboCriterioPedidos = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboModoReporte = new System.Windows.Forms.ComboBox();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesPedidos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownPedidos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.txtProyecto);
            this.gbCliente.Controls.Add(this.label1);
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
            this.gbCliente.Size = new System.Drawing.Size(756, 90);
            this.gbCliente.TabIndex = 0;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Info. Cliente:";
            // 
            // txtProyecto
            // 
            this.txtProyecto.BackColor = System.Drawing.Color.Khaki;
            this.txtProyecto.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProyecto.Location = new System.Drawing.Point(289, 52);
            this.txtProyecto.MaxLength = 60;
            this.txtProyecto.Name = "txtProyecto";
            this.txtProyecto.Size = new System.Drawing.Size(222, 21);
            this.txtProyecto.TabIndex = 90;
            this.txtProyecto.Tag = "Proyecto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(228, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 89;
            this.label1.Text = "Proyecto:";
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.Khaki;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(289, 26);
            this.txtCliente.MaxLength = 60;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(222, 21);
            this.txtCliente.TabIndex = 74;
            this.txtCliente.Tag = "Cliente";
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.BackColor = System.Drawing.Color.White;
            this.txtCodigoCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCliente.ForeColor = System.Drawing.Color.DarkRed;
            this.txtCodigoCliente.Location = new System.Drawing.Point(71, 24);
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
            this.label20.Location = new System.Drawing.Point(19, 28);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 16);
            this.label20.TabIndex = 86;
            this.label20.Text = "Codigo:";
            // 
            // cmdBuscarCliente
            // 
            this.cmdBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("cmdBuscarCliente.Image")));
            this.cmdBuscarCliente.Location = new System.Drawing.Point(180, 23);
            this.cmdBuscarCliente.Name = "cmdBuscarCliente";
            this.cmdBuscarCliente.Size = new System.Drawing.Size(36, 26);
            this.cmdBuscarCliente.TabIndex = 85;
            this.cmdBuscarCliente.UseVisualStyleBackColor = true;
            this.cmdBuscarCliente.Click += new System.EventHandler(this.cmdBuscarCliente_Click);
            // 
            // txtTelefonos
            // 
            this.txtTelefonos.BackColor = System.Drawing.Color.Khaki;
            this.txtTelefonos.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonos.Location = new System.Drawing.Point(585, 26);
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
            this.label5.Location = new System.Drawing.Point(550, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 81;
            this.label5.Text = "Tels:";
            // 
            // txtContactos
            // 
            this.txtContactos.BackColor = System.Drawing.Color.Khaki;
            this.txtContactos.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactos.Location = new System.Drawing.Point(585, 51);
            this.txtContactos.MaxLength = 80;
            this.txtContactos.Name = "txtContactos";
            this.txtContactos.Size = new System.Drawing.Size(158, 21);
            this.txtContactos.TabIndex = 77;
            this.txtContactos.Tag = "Contactos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(517, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 78;
            this.label4.Text = "Contactos:";
            // 
            // TxtRNC
            // 
            this.TxtRNC.BackColor = System.Drawing.Color.Khaki;
            this.TxtRNC.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRNC.Location = new System.Drawing.Point(71, 54);
            this.TxtRNC.MaxLength = 15;
            this.TxtRNC.Name = "TxtRNC";
            this.TxtRNC.Size = new System.Drawing.Size(144, 21);
            this.TxtRNC.TabIndex = 76;
            this.TxtRNC.Tag = "RNC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(33, 57);
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
            this.label2.Location = new System.Drawing.Point(230, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 72;
            this.label2.Text = "Empresa:";
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPedidos.Location = new System.Drawing.Point(12, 133);
            this.dgvPedidos.MultiSelect = false;
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(756, 216);
            this.dgvPedidos.TabIndex = 1;
            this.dgvPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_CellClick);
            // 
            // dgvDetallesPedidos
            // 
            this.dgvDetallesPedidos.AllowUserToAddRows = false;
            this.dgvDetallesPedidos.AllowUserToDeleteRows = false;
            this.dgvDetallesPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDetallesPedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDetallesPedidos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetallesPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetallesPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetallesPedidos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetallesPedidos.Location = new System.Drawing.Point(13, 379);
            this.dgvDetallesPedidos.MultiSelect = false;
            this.dgvDetallesPedidos.Name = "dgvDetallesPedidos";
            this.dgvDetallesPedidos.ReadOnly = true;
            this.dgvDetallesPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetallesPedidos.Size = new System.Drawing.Size(755, 160);
            this.dgvDetallesPedidos.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(10, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Listado de pedidos pendientes:";
            // 
            // lblPedidoSeleccionado
            // 
            this.lblPedidoSeleccionado.AutoSize = true;
            this.lblPedidoSeleccionado.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidoSeleccionado.ForeColor = System.Drawing.Color.DimGray;
            this.lblPedidoSeleccionado.Location = new System.Drawing.Point(11, 360);
            this.lblPedidoSeleccionado.Name = "lblPedidoSeleccionado";
            this.lblPedidoSeleccionado.Size = new System.Drawing.Size(192, 16);
            this.lblPedidoSeleccionado.TabIndex = 3;
            this.lblPedidoSeleccionado.Text = "Conduces asociados al pedido #: 0";
            // 
            // cmdVerRedaccion
            // 
            this.cmdVerRedaccion.BackColor = System.Drawing.SystemColors.Control;
            this.cmdVerRedaccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdVerRedaccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdVerRedaccion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdVerRedaccion.FlatAppearance.BorderSize = 0;
            this.cmdVerRedaccion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdVerRedaccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.cmdVerRedaccion.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVerRedaccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdVerRedaccion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdVerRedaccion.Location = new System.Drawing.Point(13, 547);
            this.cmdVerRedaccion.Name = "cmdVerRedaccion";
            this.cmdVerRedaccion.Size = new System.Drawing.Size(144, 55);
            this.cmdVerRedaccion.TabIndex = 88;
            this.cmdVerRedaccion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdVerRedaccion.UseVisualStyleBackColor = false;
            this.cmdVerRedaccion.Click += new System.EventHandler(this.cmdVerRedaccion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmdBuscarPedido);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(785, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 412);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criterios de búsqueda:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 47);
            this.button1.TabIndex = 105;
            this.button1.Text = "&Resetear Criterios";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmdBuscarPedido
            // 
            this.cmdBuscarPedido.Location = new System.Drawing.Point(16, 306);
            this.cmdBuscarPedido.Name = "cmdBuscarPedido";
            this.cmdBuscarPedido.Size = new System.Drawing.Size(229, 47);
            this.cmdBuscarPedido.TabIndex = 104;
            this.cmdBuscarPedido.Text = "&Buscar Pedidos";
            this.cmdBuscarPedido.UseVisualStyleBackColor = true;
            this.cmdBuscarPedido.Click += new System.EventHandler(this.cmdBuscarPedido_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.cboEstatusPedidos);
            this.groupBox4.Location = new System.Drawing.Point(16, 90);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(229, 56);
            this.groupBox4.TabIndex = 103;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Estatus:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Por:";
            // 
            // cboEstatusPedidos
            // 
            this.cboEstatusPedidos.FormattingEnabled = true;
            this.cboEstatusPedidos.Items.AddRange(new object[] {
            "Todos",
            "En Proceso",
            "Completado"});
            this.cboEstatusPedidos.Location = new System.Drawing.Point(46, 21);
            this.cboEstatusPedidos.Name = "cboEstatusPedidos";
            this.cboEstatusPedidos.Size = new System.Drawing.Size(170, 21);
            this.cboEstatusPedidos.TabIndex = 0;
            this.cboEstatusPedidos.SelectedIndexChanged += new System.EventHandler(this.cboEstatusPedidos_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nUpDownPedidos);
            this.groupBox3.Controls.Add(this.cboCriterioPedidos);
            this.groupBox3.Location = new System.Drawing.Point(16, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 56);
            this.groupBox3.TabIndex = 102;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pedidos:";
            // 
            // nUpDownPedidos
            // 
            this.nUpDownPedidos.Enabled = false;
            this.nUpDownPedidos.Location = new System.Drawing.Point(138, 20);
            this.nUpDownPedidos.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nUpDownPedidos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDownPedidos.Name = "nUpDownPedidos";
            this.nUpDownPedidos.Size = new System.Drawing.Size(78, 20);
            this.nUpDownPedidos.TabIndex = 1;
            this.nUpDownPedidos.Tag = "0";
            this.nUpDownPedidos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDownPedidos.ValueChanged += new System.EventHandler(this.nUpDownPedidos_ValueChanged);
            // 
            // cboCriterioPedidos
            // 
            this.cboCriterioPedidos.FormattingEnabled = true;
            this.cboCriterioPedidos.Items.AddRange(new object[] {
            "Todos",
            "Especificar"});
            this.cboCriterioPedidos.Location = new System.Drawing.Point(10, 20);
            this.cboCriterioPedidos.Name = "cboCriterioPedidos";
            this.cboCriterioPedidos.Size = new System.Drawing.Size(118, 21);
            this.cboCriterioPedidos.TabIndex = 0;
            this.cboCriterioPedidos.SelectedIndexChanged += new System.EventHandler(this.cboCriterioPedidos_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cboModoReporte);
            this.groupBox2.Controls.Add(this.dtpFechaFin);
            this.groupBox2.Controls.Add(this.dtpFechaInicio);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(16, 156);
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
            this.dtpFechaFin.CustomFormat = "yyyy/mm/dd";
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(46, 86);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(170, 20);
            this.dtpFechaFin.TabIndex = 104;
            this.dtpFechaFin.Value = new System.DateTime(2023, 3, 27, 0, 0, 0, 0);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CustomFormat = "yyyy/mm/dd";
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
            // frmRedaccionesClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 612);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdVerRedaccion);
            this.Controls.Add(this.lblPedidoSeleccionado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvDetallesPedidos);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.gbCliente);
            this.Name = "frmRedaccionesClientes";
            this.Text = "Redacciones de Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRedaccionesClientes_Load);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesPedidos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownPedidos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DataGridView dgvDetallesPedidos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPedidoSeleccionado;
        private System.Windows.Forms.Button cmdVerRedaccion;
        private System.Windows.Forms.TextBox txtProyecto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nUpDownPedidos;
        private System.Windows.Forms.ComboBox cboCriterioPedidos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboEstatusPedidos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdBuscarPedido;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboModoReporte;
    }
}