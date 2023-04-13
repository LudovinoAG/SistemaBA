
namespace Sistema_de_Gestión.Presentacion
{
    partial class frmCotización
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCotización));
            this.txtNumCotizacion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtDirección = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefonos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContactos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtRNC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UdCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtNuevoSubTotal = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cboMedida = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dgvCotizacion = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.CKITBIS = new System.Windows.Forms.CheckBox();
            this.TxtTotalGeneral = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtITBIS = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.cmdSalirCotizacion = new System.Windows.Forms.Button();
            this.cmdBuscarCotizacion = new System.Windows.Forms.Button();
            this.cmdNuevaCotización = new System.Windows.Forms.Button();
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdBuscarCliente = new System.Windows.Forms.Button();
            this.pbEncabezadoCotizacion = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.UdCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEncabezadoCotizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumCotizacion
            // 
            this.txtNumCotizacion.BackColor = System.Drawing.Color.White;
            this.txtNumCotizacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumCotizacion.Enabled = false;
            this.txtNumCotizacion.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCotizacion.Location = new System.Drawing.Point(1208, 48);
            this.txtNumCotizacion.MaxLength = 6;
            this.txtNumCotizacion.Name = "txtNumCotizacion";
            this.txtNumCotizacion.ReadOnly = true;
            this.txtNumCotizacion.Size = new System.Drawing.Size(127, 29);
            this.txtNumCotizacion.TabIndex = 19;
            this.txtNumCotizacion.Text = "000000";
            this.txtNumCotizacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1008, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 28);
            this.label8.TabIndex = 18;
            this.label8.Text = "COTIZACION No.";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(233, 152);
            this.txtCliente.MaxLength = 60;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(183, 20);
            this.txtCliente.TabIndex = 5;
            this.txtCliente.Tag = "Cliente";
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(70, 152);
            this.txtCodigoCliente.MaxLength = 7;
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(62, 20);
            this.txtCodigoCliente.TabIndex = 1;
            this.txtCodigoCliente.Tag = "Codigo";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(12, 155);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 16);
            this.label20.TabIndex = 86;
            this.label20.Text = "Codigo:";
            // 
            // txtDirección
            // 
            this.txtDirección.Location = new System.Drawing.Point(70, 223);
            this.txtDirección.MaxLength = 250;
            this.txtDirección.Multiline = true;
            this.txtDirección.Name = "txtDirección";
            this.txtDirección.Size = new System.Drawing.Size(346, 50);
            this.txtDirección.TabIndex = 4;
            this.txtDirección.Tag = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 84;
            this.label7.Text = "Dirección:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(233, 200);
            this.txtCorreo.MaxLength = 60;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(183, 20);
            this.txtCorreo.TabIndex = 7;
            this.txtCorreo.Tag = "Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = "Correo:";
            // 
            // txtTelefonos
            // 
            this.txtTelefonos.Location = new System.Drawing.Point(70, 200);
            this.txtTelefonos.MaxLength = 60;
            this.txtTelefonos.Name = "txtTelefonos";
            this.txtTelefonos.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonos.TabIndex = 3;
            this.txtTelefonos.Tag = "Telefonos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 81;
            this.label5.Text = "Tels:";
            // 
            // txtContactos
            // 
            this.txtContactos.Location = new System.Drawing.Point(233, 177);
            this.txtContactos.MaxLength = 80;
            this.txtContactos.Name = "txtContactos";
            this.txtContactos.Size = new System.Drawing.Size(183, 20);
            this.txtContactos.TabIndex = 6;
            this.txtContactos.Tag = "Contactos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 78;
            this.label4.Text = "Contactos:";
            // 
            // TxtRNC
            // 
            this.TxtRNC.Location = new System.Drawing.Point(70, 177);
            this.TxtRNC.MaxLength = 15;
            this.TxtRNC.Name = "TxtRNC";
            this.TxtRNC.Size = new System.Drawing.Size(100, 20);
            this.TxtRNC.TabIndex = 2;
            this.TxtRNC.Tag = "RNC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "RNC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 72;
            this.label2.Text = "Cliente:";
            // 
            // UdCantidad
            // 
            this.UdCantidad.BackColor = System.Drawing.Color.Khaki;
            this.UdCantidad.Location = new System.Drawing.Point(133, 295);
            this.UdCantidad.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.UdCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UdCantidad.Name = "UdCantidad";
            this.UdCantidad.Size = new System.Drawing.Size(55, 20);
            this.UdCantidad.TabIndex = 106;
            this.UdCantidad.Tag = "Cantidad";
            this.UdCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtNuevoSubTotal
            // 
            this.txtNuevoSubTotal.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtNuevoSubTotal.Location = new System.Drawing.Point(1164, 295);
            this.txtNuevoSubTotal.MaxLength = 12;
            this.txtNuevoSubTotal.Name = "txtNuevoSubTotal";
            this.txtNuevoSubTotal.ReadOnly = true;
            this.txtNuevoSubTotal.Size = new System.Drawing.Size(81, 20);
            this.txtNuevoSubTotal.TabIndex = 104;
            this.txtNuevoSubTotal.Tag = "SubTotal";
            this.txtNuevoSubTotal.Text = "0";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.White;
            this.label27.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Maroon;
            this.label27.Location = new System.Drawing.Point(1088, 297);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(74, 16);
            this.label27.TabIndex = 103;
            this.label27.Text = "$Sub-Total:";
            // 
            // txtCosto
            // 
            this.txtCosto.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtCosto.Location = new System.Drawing.Point(1001, 296);
            this.txtCosto.MaxLength = 12;
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(81, 20);
            this.txtCosto.TabIndex = 102;
            this.txtCosto.Tag = "Costo";
            this.txtCosto.Text = "0";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.White;
            this.label26.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Maroon;
            this.label26.Location = new System.Drawing.Point(947, 298);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(52, 16);
            this.label26.TabIndex = 101;
            this.label26.Text = "$Costo:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtDescripcion.Location = new System.Drawing.Point(693, 297);
            this.txtDescripcion.MaxLength = 60;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(248, 20);
            this.txtDescripcion.TabIndex = 100;
            this.txtDescripcion.Tag = "Descripcion";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.White;
            this.label24.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Maroon;
            this.label24.Location = new System.Drawing.Point(613, 299);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(79, 16);
            this.label24.TabIndex = 99;
            this.label24.Text = "Descripción:";
            // 
            // cboProductos
            // 
            this.cboProductos.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Location = new System.Drawing.Point(400, 295);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(202, 21);
            this.cboProductos.TabIndex = 98;
            this.cboProductos.Tag = "Productos";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.White;
            this.label23.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Maroon;
            this.label23.Location = new System.Drawing.Point(334, 297);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(64, 16);
            this.label23.TabIndex = 97;
            this.label23.Text = "Producto:";
            // 
            // cboMedida
            // 
            this.cboMedida.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.cboMedida.FormattingEnabled = true;
            this.cboMedida.Location = new System.Drawing.Point(249, 295);
            this.cboMedida.Name = "cboMedida";
            this.cboMedida.Size = new System.Drawing.Size(81, 21);
            this.cboMedida.TabIndex = 96;
            this.cboMedida.Tag = "Medida";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.White;
            this.label22.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Maroon;
            this.label22.Location = new System.Drawing.Point(192, 297);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 16);
            this.label22.TabIndex = 95;
            this.label22.Text = "Medida:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Maroon;
            this.label21.Location = new System.Drawing.Point(69, 297);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 16);
            this.label21.TabIndex = 94;
            this.label21.Text = "Cantidad:";
            // 
            // dgvCotizacion
            // 
            this.dgvCotizacion.AllowUserToAddRows = false;
            this.dgvCotizacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCotizacion.BackgroundColor = System.Drawing.Color.White;
            this.dgvCotizacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCotizacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCotizacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Medida,
            this.IDMedida,
            this.IDProducto,
            this.Producto,
            this.Descripción,
            this.Costo,
            this.SubTotal,
            this.Accion});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCotizacion.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCotizacion.Location = new System.Drawing.Point(70, 324);
            this.dgvCotizacion.MultiSelect = false;
            this.dgvCotizacion.Name = "dgvCotizacion";
            this.dgvCotizacion.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvCotizacion.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCotizacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCotizacion.Size = new System.Drawing.Size(1281, 213);
            this.dgvCotizacion.TabIndex = 93;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Cantidad.FillWeight = 31.14229F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MaxInputLength = 3;
            this.Cantidad.MinimumWidth = 35;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cantidad.Width = 104;
            // 
            // Medida
            // 
            this.Medida.FillWeight = 10.13162F;
            this.Medida.HeaderText = "Medida";
            this.Medida.MinimumWidth = 100;
            this.Medida.Name = "Medida";
            this.Medida.ReadOnly = true;
            this.Medida.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Medida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // IDMedida
            // 
            this.IDMedida.HeaderText = "IDMedida";
            this.IDMedida.Name = "IDMedida";
            this.IDMedida.ReadOnly = true;
            this.IDMedida.Visible = false;
            // 
            // IDProducto
            // 
            this.IDProducto.HeaderText = "IDProducto";
            this.IDProducto.Name = "IDProducto";
            this.IDProducto.ReadOnly = true;
            this.IDProducto.Visible = false;
            // 
            // Producto
            // 
            this.Producto.FillWeight = 10.13162F;
            this.Producto.HeaderText = "Producto";
            this.Producto.MaxInputLength = 200;
            this.Producto.MinimumWidth = 200;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Producto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Descripción
            // 
            this.Descripción.FillWeight = 73.88532F;
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.MaxInputLength = 200;
            this.Descripción.MinimumWidth = 350;
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            // 
            // Costo
            // 
            this.Costo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Costo.FillWeight = 10.13162F;
            this.Costo.HeaderText = "Costo";
            this.Costo.MaxInputLength = 20;
            this.Costo.MinimumWidth = 100;
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            this.Costo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SubTotal
            // 
            this.SubTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SubTotal.FillWeight = 139.6108F;
            this.SubTotal.HeaderText = "Sub-Total";
            this.SubTotal.MaxInputLength = 20;
            this.SubTotal.MinimumWidth = 100;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SubTotal.Width = 109;
            // 
            // Accion
            // 
            this.Accion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkRed;
            this.Accion.DefaultCellStyle = dataGridViewCellStyle2;
            this.Accion.HeaderText = "Fila";
            this.Accion.MinimumWidth = 100;
            this.Accion.Name = "Accion";
            this.Accion.ReadOnly = true;
            this.Accion.Text = "Eliminar";
            this.Accion.ToolTipText = "Eliminar Registro";
            this.Accion.UseColumnTextForButtonValue = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1134, 629);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 16);
            this.label19.TabIndex = 115;
            this.label19.Text = "Total General:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1187, 575);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 16);
            this.label18.TabIndex = 114;
            this.label18.Text = "DESC.";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1191, 602);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 16);
            this.label17.TabIndex = 113;
            this.label17.Text = "ITBIS:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1162, 549);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 16);
            this.label16.TabIndex = 112;
            this.label16.Text = "Sub-Total:";
            // 
            // CKITBIS
            // 
            this.CKITBIS.AutoSize = true;
            this.CKITBIS.Checked = true;
            this.CKITBIS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKITBIS.Location = new System.Drawing.Point(1171, 603);
            this.CKITBIS.Name = "CKITBIS";
            this.CKITBIS.Size = new System.Drawing.Size(15, 14);
            this.CKITBIS.TabIndex = 125;
            this.CKITBIS.UseVisualStyleBackColor = true;
            // 
            // TxtTotalGeneral
            // 
            this.TxtTotalGeneral.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalGeneral.Location = new System.Drawing.Point(1231, 626);
            this.TxtTotalGeneral.MaxLength = 20;
            this.TxtTotalGeneral.Name = "TxtTotalGeneral";
            this.TxtTotalGeneral.ReadOnly = true;
            this.TxtTotalGeneral.Size = new System.Drawing.Size(119, 24);
            this.TxtTotalGeneral.TabIndex = 11;
            this.TxtTotalGeneral.Tag = "Totales";
            this.TxtTotalGeneral.Text = "0.00";
            this.TxtTotalGeneral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(1231, 572);
            this.txtDesc.MaxLength = 20;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(119, 24);
            this.txtDesc.TabIndex = 9;
            this.txtDesc.Tag = "Totales";
            this.txtDesc.Text = "0.00";
            this.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtITBIS
            // 
            this.txtITBIS.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtITBIS.Location = new System.Drawing.Point(1231, 599);
            this.txtITBIS.Name = "txtITBIS";
            this.txtITBIS.ReadOnly = true;
            this.txtITBIS.Size = new System.Drawing.Size(119, 24);
            this.txtITBIS.TabIndex = 10;
            this.txtITBIS.Tag = "Totales";
            this.txtITBIS.Text = "0.00";
            this.txtITBIS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(1231, 545);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(119, 24);
            this.txtSubTotal.TabIndex = 8;
            this.txtSubTotal.Tag = "Totales";
            this.txtSubTotal.Text = "0.00";
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmdSalirCotizacion
            // 
            this.cmdSalirCotizacion.BackColor = System.Drawing.SystemColors.Control;
            this.cmdSalirCotizacion.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.BotonCerrarVentana;
            this.cmdSalirCotizacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdSalirCotizacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSalirCotizacion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdSalirCotizacion.FlatAppearance.BorderSize = 0;
            this.cmdSalirCotizacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdSalirCotizacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.cmdSalirCotizacion.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalirCotizacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdSalirCotizacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdSalirCotizacion.Location = new System.Drawing.Point(939, 545);
            this.cmdSalirCotizacion.Name = "cmdSalirCotizacion";
            this.cmdSalirCotizacion.Size = new System.Drawing.Size(159, 105);
            this.cmdSalirCotizacion.TabIndex = 120;
            this.cmdSalirCotizacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdSalirCotizacion.UseVisualStyleBackColor = false;
            this.cmdSalirCotizacion.Click += new System.EventHandler(this.cmdSalirCotizacion_Click);
            this.cmdSalirCotizacion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmdSalirCotizacion_MouseDown);
            this.cmdSalirCotizacion.MouseLeave += new System.EventHandler(this.cmdSalirCotizacion_MouseLeave);
            this.cmdSalirCotizacion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmdSalirCotizacion_MouseMove);
            // 
            // cmdBuscarCotizacion
            // 
            this.cmdBuscarCotizacion.BackColor = System.Drawing.SystemColors.Control;
            this.cmdBuscarCotizacion.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.BotonBuscarCotizacion;
            this.cmdBuscarCotizacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdBuscarCotizacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdBuscarCotizacion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdBuscarCotizacion.FlatAppearance.BorderSize = 0;
            this.cmdBuscarCotizacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdBuscarCotizacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.cmdBuscarCotizacion.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscarCotizacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdBuscarCotizacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdBuscarCotizacion.Location = new System.Drawing.Point(402, 545);
            this.cmdBuscarCotizacion.Name = "cmdBuscarCotizacion";
            this.cmdBuscarCotizacion.Size = new System.Drawing.Size(159, 105);
            this.cmdBuscarCotizacion.TabIndex = 119;
            this.cmdBuscarCotizacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdBuscarCotizacion.UseVisualStyleBackColor = false;
            this.cmdBuscarCotizacion.Click += new System.EventHandler(this.cmdBuscarCotizacion_Click);
            this.cmdBuscarCotizacion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmdBuscarCotizacion_MouseDown);
            this.cmdBuscarCotizacion.MouseLeave += new System.EventHandler(this.cmdBuscarCotizacion_MouseLeave);
            this.cmdBuscarCotizacion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmdBuscarCotizacion_MouseMove);
            // 
            // cmdNuevaCotización
            // 
            this.cmdNuevaCotización.BackColor = System.Drawing.SystemColors.Control;
            this.cmdNuevaCotización.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.BotonNuevaCotizacion;
            this.cmdNuevaCotización.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdNuevaCotización.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdNuevaCotización.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdNuevaCotización.FlatAppearance.BorderSize = 0;
            this.cmdNuevaCotización.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdNuevaCotización.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.cmdNuevaCotización.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevaCotización.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdNuevaCotización.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdNuevaCotización.Location = new System.Drawing.Point(76, 545);
            this.cmdNuevaCotización.Name = "cmdNuevaCotización";
            this.cmdNuevaCotización.Size = new System.Drawing.Size(159, 105);
            this.cmdNuevaCotización.TabIndex = 118;
            this.cmdNuevaCotización.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdNuevaCotización.UseVisualStyleBackColor = false;
            this.cmdNuevaCotización.Click += new System.EventHandler(this.cmdNuevaCotización_Click);
            this.cmdNuevaCotización.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmdNuevaCotización_MouseDown);
            this.cmdNuevaCotización.MouseLeave += new System.EventHandler(this.cmdNuevaCotización_MouseLeave);
            this.cmdNuevaCotización.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmdNuevaCotización_MouseMove);
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.BackColor = System.Drawing.SystemColors.Control;
            this.cmdRegistrar.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.BotonGuardarCotizacion;
            this.cmdRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdRegistrar.FlatAppearance.BorderSize = 0;
            this.cmdRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.cmdRegistrar.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdRegistrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdRegistrar.Location = new System.Drawing.Point(239, 545);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(159, 105);
            this.cmdRegistrar.TabIndex = 117;
            this.cmdRegistrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdRegistrar.UseVisualStyleBackColor = false;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            this.cmdRegistrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmdRegistrar_MouseDown);
            this.cmdRegistrar.MouseLeave += new System.EventHandler(this.cmdRegistrar_MouseLeave);
            this.cmdRegistrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmdRegistrar_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(70, 541);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1285, 112);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 107;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.BotonAgregarEntrada;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(1250, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 80);
            this.button1.TabIndex = 105;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // cmdBuscarCliente
            // 
            this.cmdBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("cmdBuscarCliente.Image")));
            this.cmdBuscarCliente.Location = new System.Drawing.Point(135, 150);
            this.cmdBuscarCliente.Name = "cmdBuscarCliente";
            this.cmdBuscarCliente.Size = new System.Drawing.Size(36, 23);
            this.cmdBuscarCliente.TabIndex = 85;
            this.cmdBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // pbEncabezadoCotizacion
            // 
            this.pbEncabezadoCotizacion.Image = global::Sistema_de_Gestión.RecursosBA.TituloCotizacion;
            this.pbEncabezadoCotizacion.Location = new System.Drawing.Point(-3, 0);
            this.pbEncabezadoCotizacion.Name = "pbEncabezadoCotizacion";
            this.pbEncabezadoCotizacion.Size = new System.Drawing.Size(1369, 132);
            this.pbEncabezadoCotizacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbEncabezadoCotizacion.TabIndex = 2;
            this.pbEncabezadoCotizacion.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(41, 114);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(580, 449);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 56;
            this.pictureBox3.TabStop = false;
            // 
            // frmCotización
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 660);
            this.Controls.Add(this.CKITBIS);
            this.Controls.Add(this.TxtTotalGeneral);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtITBIS);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.cmdSalirCotizacion);
            this.Controls.Add(this.cmdBuscarCotizacion);
            this.Controls.Add(this.cmdNuevaCotización);
            this.Controls.Add(this.cmdRegistrar);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.UdCantidad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNuevoSubTotal);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.cboProductos);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.cboMedida);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.dgvCotizacion);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtCodigoCliente);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cmdBuscarCliente);
            this.Controls.Add(this.txtDirección);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelefonos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtContactos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtRNC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumCotizacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pbEncabezadoCotizacion);
            this.Controls.Add(this.pictureBox3);
            this.Name = "frmCotización";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cotización";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.UdCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEncabezadoCotizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbEncabezadoCotizacion;
        private System.Windows.Forms.TextBox txtNumCotizacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button cmdBuscarCliente;
        private System.Windows.Forms.TextBox txtDirección;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefonos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContactos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtRNC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown UdCantidad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNuevoSubTotal;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cboProductos;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cboMedida;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dgvCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn Accion;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button cmdSalirCotizacion;
        private System.Windows.Forms.Button cmdBuscarCotizacion;
        private System.Windows.Forms.Button cmdNuevaCotización;
        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.CheckBox CKITBIS;
        private System.Windows.Forms.TextBox TxtTotalGeneral;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtITBIS;
        private System.Windows.Forms.TextBox txtSubTotal;
    }
}