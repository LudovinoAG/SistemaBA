
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerProforma));
            this.label8 = new System.Windows.Forms.Label();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtTelefonos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContactos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtRNC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdVerProforma = new System.Windows.Forms.Button();
            this.dgvConduceProforma = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.gbTotales = new System.Windows.Forms.GroupBox();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdBuscarPedido = new System.Windows.Forms.Button();
            this.cmdResetCriterios = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboEstatusPedidos = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.nUpDownPedidos = new System.Windows.Forms.NumericUpDown();
            this.cboCriterioPedidos = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cboModoReporte = new System.Windows.Forms.ComboBox();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cmdBuscarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdFacturacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConduceProforma)).BeginInit();
            this.gbTotales.SuspendLayout();
            this.StatusBarProforma.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownPedidos)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(10, 114);
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
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
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
            this.dgvPedidos.Location = new System.Drawing.Point(12, 128);
            this.dgvPedidos.MultiSelect = false;
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(722, 235);
            this.dgvPedidos.TabIndex = 93;
            this.dgvPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_CellClick);
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.Khaki;
            this.txtCliente.Enabled = false;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(313, 36);
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
            this.txtCodigoCliente.Location = new System.Drawing.Point(87, 36);
            this.txtCodigoCliente.MaxLength = 7;
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(103, 24);
            this.txtCodigoCliente.TabIndex = 73;
            this.txtCodigoCliente.Tag = "Codigo";
            this.txtCodigoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoCliente_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DarkRed;
            this.label20.Location = new System.Drawing.Point(35, 40);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 16);
            this.label20.TabIndex = 86;
            this.label20.Text = "Codigo:";
            // 
            // txtTelefonos
            // 
            this.txtTelefonos.BackColor = System.Drawing.Color.Khaki;
            this.txtTelefonos.Enabled = false;
            this.txtTelefonos.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonos.Location = new System.Drawing.Point(515, 66);
            this.txtTelefonos.MaxLength = 60;
            this.txtTelefonos.Name = "txtTelefonos";
            this.txtTelefonos.Size = new System.Drawing.Size(158, 21);
            this.txtTelefonos.TabIndex = 79;
            this.txtTelefonos.Tag = "Telefonos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(480, 69);
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
            this.txtContactos.Location = new System.Drawing.Point(313, 67);
            this.txtContactos.MaxLength = 80;
            this.txtContactos.Name = "txtContactos";
            this.txtContactos.Size = new System.Drawing.Size(161, 21);
            this.txtContactos.TabIndex = 77;
            this.txtContactos.Tag = "Contactos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(245, 70);
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
            this.TxtRNC.Location = new System.Drawing.Point(87, 67);
            this.TxtRNC.MaxLength = 15;
            this.TxtRNC.Name = "TxtRNC";
            this.TxtRNC.Size = new System.Drawing.Size(145, 21);
            this.TxtRNC.TabIndex = 76;
            this.TxtRNC.Tag = "RNC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(46, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 75;
            this.label3.Text = "RNC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(254, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 72;
            this.label2.Text = "Empresa:";
            // 
            // cmdVerProforma
            // 
            this.cmdVerProforma.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.BotonVerProforma;
            this.cmdVerProforma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdVerProforma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdVerProforma.Location = new System.Drawing.Point(12, 337);
            this.cmdVerProforma.Name = "cmdVerProforma";
            this.cmdVerProforma.Size = new System.Drawing.Size(229, 52);
            this.cmdVerProforma.TabIndex = 98;
            this.cmdVerProforma.UseVisualStyleBackColor = true;
            this.cmdVerProforma.Click += new System.EventHandler(this.cmdVerProforma_Click);
            this.cmdVerProforma.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmdVerProforma_MouseDown);
            this.cmdVerProforma.MouseLeave += new System.EventHandler(this.cmdVerProforma_MouseLeave);
            this.cmdVerProforma.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmdVerProforma_MouseMove);
            // 
            // dgvConduceProforma
            // 
            this.dgvConduceProforma.AllowUserToAddRows = false;
            this.dgvConduceProforma.AllowUserToDeleteRows = false;
            this.dgvConduceProforma.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvConduceProforma.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvConduceProforma.BackgroundColor = System.Drawing.Color.WhiteSmoke;
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
            this.dgvConduceProforma.Location = new System.Drawing.Point(13, 386);
            this.dgvConduceProforma.MultiSelect = false;
            this.dgvConduceProforma.Name = "dgvConduceProforma";
            this.dgvConduceProforma.ReadOnly = true;
            this.dgvConduceProforma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConduceProforma.Size = new System.Drawing.Size(721, 180);
            this.dgvConduceProforma.TabIndex = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(11, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 13);
            this.label7.TabIndex = 101;
            this.label7.Text = "CONDUCES ASOCIADOS AL PEDIDO:";
            // 
            // gbTotales
            // 
            this.gbTotales.BackColor = System.Drawing.Color.Transparent;
            this.gbTotales.Controls.Add(this.txtTotal);
            this.gbTotales.Controls.Add(this.label12);
            this.gbTotales.Controls.Add(this.TxtDescuento);
            this.gbTotales.Controls.Add(this.label11);
            this.gbTotales.Controls.Add(this.txtITBIS);
            this.gbTotales.Controls.Add(this.label10);
            this.gbTotales.Controls.Add(this.txtSubTotal);
            this.gbTotales.Controls.Add(this.label9);
            this.gbTotales.Location = new System.Drawing.Point(759, 427);
            this.gbTotales.Name = "gbTotales";
            this.gbTotales.Size = new System.Drawing.Size(252, 133);
            this.gbTotales.TabIndex = 102;
            this.gbTotales.TabStop = false;
            this.gbTotales.Text = "Total Pendientes:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.Khaki;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(101, 102);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(133, 21);
            this.txtTotal.TabIndex = 7;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(51, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 15);
            this.label12.TabIndex = 6;
            this.label12.Text = "Total:";
            // 
            // TxtDescuento
            // 
            this.TxtDescuento.BackColor = System.Drawing.Color.Khaki;
            this.TxtDescuento.Enabled = false;
            this.TxtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescuento.Location = new System.Drawing.Point(101, 76);
            this.TxtDescuento.Name = "TxtDescuento";
            this.TxtDescuento.Size = new System.Drawing.Size(133, 21);
            this.TxtDescuento.TabIndex = 5;
            this.TxtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(15, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "Descuento:";
            // 
            // txtITBIS
            // 
            this.txtITBIS.BackColor = System.Drawing.Color.Khaki;
            this.txtITBIS.Enabled = false;
            this.txtITBIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtITBIS.Location = new System.Drawing.Point(101, 50);
            this.txtITBIS.Name = "txtITBIS";
            this.txtITBIS.Size = new System.Drawing.Size(133, 21);
            this.txtITBIS.TabIndex = 3;
            this.txtITBIS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(49, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "ITBIS:";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.Color.Khaki;
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(101, 24);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(133, 21);
            this.txtSubTotal.TabIndex = 1;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(21, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sub-Total:";
            // 
            // StatusBarProforma
            // 
            this.StatusBarProforma.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolProformaEstado,
            this.toolProformaPedidosRegistrados,
            this.toolProformaConducesRegistrados});
            this.StatusBarProforma.Location = new System.Drawing.Point(0, 576);
            this.StatusBarProforma.Name = "StatusBarProforma";
            this.StatusBarProforma.Size = new System.Drawing.Size(1030, 22);
            this.StatusBarProforma.TabIndex = 103;
            this.StatusBarProforma.Text = "statusStrip1";
            // 
            // toolProformaEstado
            // 
            this.toolProformaEstado.AutoSize = false;
            this.toolProformaEstado.BackColor = System.Drawing.Color.Transparent;
            this.toolProformaEstado.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolProformaEstado.Name = "toolProformaEstado";
            this.toolProformaEstado.Size = new System.Drawing.Size(80, 17);
            this.toolProformaEstado.Text = "Listo";
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
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.cmdBuscarPedido);
            this.groupBox3.Controls.Add(this.cmdResetCriterios);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.cmdVerProforma);
            this.groupBox3.Location = new System.Drawing.Point(759, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 399);
            this.groupBox3.TabIndex = 104;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Criterios de búsqueda:";
            // 
            // cmdBuscarPedido
            // 
            this.cmdBuscarPedido.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.BotonBuscarPedidosProforma;
            this.cmdBuscarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdBuscarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdBuscarPedido.Location = new System.Drawing.Point(12, 283);
            this.cmdBuscarPedido.Name = "cmdBuscarPedido";
            this.cmdBuscarPedido.Size = new System.Drawing.Size(112, 48);
            this.cmdBuscarPedido.TabIndex = 106;
            this.cmdBuscarPedido.UseVisualStyleBackColor = true;
            this.cmdBuscarPedido.Click += new System.EventHandler(this.cmdBuscarPedido_Click);
            this.cmdBuscarPedido.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmdBuscarPedido_MouseDown);
            this.cmdBuscarPedido.MouseLeave += new System.EventHandler(this.cmdBuscarPedido_MouseLeave);
            this.cmdBuscarPedido.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmdBuscarPedido_MouseMove);
            // 
            // cmdResetCriterios
            // 
            this.cmdResetCriterios.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.BotonResetCriteriosProforma;
            this.cmdResetCriterios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdResetCriterios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdResetCriterios.Location = new System.Drawing.Point(129, 283);
            this.cmdResetCriterios.Name = "cmdResetCriterios";
            this.cmdResetCriterios.Size = new System.Drawing.Size(112, 48);
            this.cmdResetCriterios.TabIndex = 105;
            this.cmdResetCriterios.UseVisualStyleBackColor = true;
            this.cmdResetCriterios.Click += new System.EventHandler(this.cmdResetCriterios_Click);
            this.cmdResetCriterios.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmdResetCriterios_MouseDown);
            this.cmdResetCriterios.MouseLeave += new System.EventHandler(this.cmdResetCriterios_MouseLeave);
            this.cmdResetCriterios.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmdResetCriterios_MouseMove);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.cboEstatusPedidos);
            this.groupBox4.Location = new System.Drawing.Point(12, 90);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(229, 56);
            this.groupBox4.TabIndex = 103;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Estatus:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Por:";
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.nUpDownPedidos);
            this.groupBox5.Controls.Add(this.cboCriterioPedidos);
            this.groupBox5.Location = new System.Drawing.Point(12, 24);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(229, 56);
            this.groupBox5.TabIndex = 102;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pedidos:";
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
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.cboModoReporte);
            this.groupBox6.Controls.Add(this.dtpFechaFin);
            this.groupBox6.Controls.Add(this.dtpFechaInicio);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Location = new System.Drawing.Point(12, 156);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(229, 121);
            this.groupBox6.TabIndex = 101;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Fechas:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 13);
            this.label14.TabIndex = 106;
            this.label14.Text = "Por:";
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
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 13);
            this.label15.TabIndex = 102;
            this.label15.Text = "Fin:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 63);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 101;
            this.label16.Text = "Inicio:";
            // 
            // cmdBuscarCliente
            // 
            this.cmdBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("cmdBuscarCliente.Image")));
            this.cmdBuscarCliente.Location = new System.Drawing.Point(196, 35);
            this.cmdBuscarCliente.Name = "cmdBuscarCliente";
            this.cmdBuscarCliente.Size = new System.Drawing.Size(36, 26);
            this.cmdBuscarCliente.TabIndex = 85;
            this.cmdBuscarCliente.UseVisualStyleBackColor = true;
            this.cmdBuscarCliente.Click += new System.EventHandler(this.cmdBuscarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 105;
            this.label1.Text = "Buscar cliente";
            // 
            // cmdFacturacion
            // 
            this.cmdFacturacion.Location = new System.Drawing.Point(651, 363);
            this.cmdFacturacion.Name = "cmdFacturacion";
            this.cmdFacturacion.Size = new System.Drawing.Size(75, 23);
            this.cmdFacturacion.TabIndex = 106;
            this.cmdFacturacion.Text = "FACT";
            this.cmdFacturacion.UseVisualStyleBackColor = true;
            this.cmdFacturacion.Click += new System.EventHandler(this.cmdFacturacion_Click);
            // 
            // frmVerProforma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.FondoProforma;
            this.ClientSize = new System.Drawing.Size(1030, 598);
            this.Controls.Add(this.cmdFacturacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtCodigoCliente);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.StatusBarProforma);
            this.Controls.Add(this.cmdBuscarCliente);
            this.Controls.Add(this.gbTotales);
            this.Controls.Add(this.txtTelefonos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvConduceProforma);
            this.Controls.Add(this.txtContactos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.TxtRNC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmVerProforma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura Proforma";
            this.Load += new System.EventHandler(this.frmVerProforma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConduceProforma)).EndInit();
            this.gbTotales.ResumeLayout(false);
            this.gbTotales.PerformLayout();
            this.StatusBarProforma.ResumeLayout(false);
            this.StatusBarProforma.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownPedidos)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvPedidos;
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
        private System.Windows.Forms.DataGridView dgvConduceProforma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbTotales;
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmdBuscarPedido;
        private System.Windows.Forms.Button cmdResetCriterios;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboEstatusPedidos;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown nUpDownPedidos;
        private System.Windows.Forms.ComboBox cboCriterioPedidos;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboModoReporte;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdFacturacion;
    }
}