
namespace Sistema_de_Gestión.Presentacion
{
    partial class frmMantenimientoProductos
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFiltrar = new System.Windows.Forms.ComboBox();
            this.StbMantProducts = new System.Windows.Forms.StatusStrip();
            this.tsslTotalProducto = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDisponible = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslAgotado = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUso = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslMantenimiento = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDesactivado = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTotalProductos = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDisponibles = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslAgotados = new System.Windows.Forms.ToolStripStatusLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboEstatus = new System.Windows.Forms.ComboBox();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdInsertar = new System.Windows.Forms.Button();
            this.LblID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtITBISProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.StbMantProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(12, 116);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(799, 327);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboFiltrar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 62);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Enabled = false;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(291, 24);
            this.txtBuscar.MaxLength = 255;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(204, 24);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
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
            // StbMantProducts
            // 
            this.StbMantProducts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.StbMantProducts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTotalProducto,
            this.tsslDisponible,
            this.tsslAgotado,
            this.tsslUso,
            this.tsslMantenimiento,
            this.tsslDesactivado});
            this.StbMantProducts.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.StbMantProducts.Location = new System.Drawing.Point(0, 450);
            this.StbMantProducts.Name = "StbMantProducts";
            this.StbMantProducts.Size = new System.Drawing.Size(1138, 24);
            this.StbMantProducts.TabIndex = 5;
            this.StbMantProducts.Text = "statusStrip1";
            // 
            // tsslTotalProducto
            // 
            this.tsslTotalProducto.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslTotalProducto.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.tsslTotalProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsslTotalProducto.Name = "tsslTotalProducto";
            this.tsslTotalProducto.Size = new System.Drawing.Size(127, 19);
            this.tsslTotalProducto.Text = "Total de productos: 0";
            // 
            // tsslDisponible
            // 
            this.tsslDisponible.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslDisponible.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.tsslDisponible.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsslDisponible.ForeColor = System.Drawing.Color.DarkGreen;
            this.tsslDisponible.Name = "tsslDisponible";
            this.tsslDisponible.Size = new System.Drawing.Size(86, 19);
            this.tsslDisponible.Text = "Disponibles: 0";
            // 
            // tsslAgotado
            // 
            this.tsslAgotado.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslAgotado.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.tsslAgotado.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsslAgotado.ForeColor = System.Drawing.Color.DarkRed;
            this.tsslAgotado.Name = "tsslAgotado";
            this.tsslAgotado.Size = new System.Drawing.Size(75, 19);
            this.tsslAgotado.Text = "Agotados: 0";
            // 
            // tsslUso
            // 
            this.tsslUso.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslUso.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.tsslUso.Name = "tsslUso";
            this.tsslUso.Size = new System.Drawing.Size(58, 19);
            this.tsslUso.Text = "En uso: 0";
            // 
            // tsslMantenimiento
            // 
            this.tsslMantenimiento.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslMantenimiento.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.tsslMantenimiento.Name = "tsslMantenimiento";
            this.tsslMantenimiento.Size = new System.Drawing.Size(105, 19);
            this.tsslMantenimiento.Text = "Mantenimiento: 0";
            // 
            // tsslDesactivado
            // 
            this.tsslDesactivado.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslDesactivado.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.tsslDesactivado.Name = "tsslDesactivado";
            this.tsslDesactivado.Size = new System.Drawing.Size(87, 19);
            this.tsslDesactivado.Text = "Desactivado: 0";
            // 
            // tsslTotalProductos
            // 
            this.tsslTotalProductos.Name = "tsslTotalProductos";
            this.tsslTotalProductos.Size = new System.Drawing.Size(140, 17);
            this.tsslTotalProductos.Text = "Cantidad de Productos: 0";
            // 
            // tsslDisponibles
            // 
            this.tsslDisponibles.Name = "tsslDisponibles";
            this.tsslDisponibles.Size = new System.Drawing.Size(80, 17);
            this.tsslDisponibles.Text = "Disponibles: 0";
            // 
            // tsslAgotados
            // 
            this.tsslAgotados.Name = "tsslAgotados";
            this.tsslAgotados.Size = new System.Drawing.Size(70, 17);
            this.tsslAgotados.Text = "Agotados: 0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(853, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 14);
            this.label7.TabIndex = 27;
            this.label7.Text = "Estatus:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.Khaki;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(904, 262);
            this.txtPrecio.MaxLength = 15;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(129, 24);
            this.txtPrecio.TabIndex = 6;
            this.txtPrecio.Tag = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(858, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 14);
            this.label5.TabIndex = 23;
            this.label5.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(836, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 14);
            this.label4.TabIndex = 22;
            this.label4.Text = "Proveedor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(840, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 14);
            this.label8.TabIndex = 21;
            this.label8.Text = "Categoría:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.Khaki;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(904, 159);
            this.txtDescripcion.MaxLength = 350;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(218, 38);
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.Tag = "Descripcion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(830, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 14);
            this.label9.TabIndex = 19;
            this.label9.Text = "Descripción:";
            // 
            // cboEstatus
            // 
            this.cboEstatus.BackColor = System.Drawing.Color.Khaki;
            this.cboEstatus.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstatus.FormattingEnabled = true;
            this.cboEstatus.Location = new System.Drawing.Point(904, 318);
            this.cboEstatus.Name = "cboEstatus";
            this.cboEstatus.Size = new System.Drawing.Size(129, 24);
            this.cboEstatus.TabIndex = 7;
            this.cboEstatus.Tag = "Estatus";
            // 
            // cboProveedor
            // 
            this.cboProveedor.BackColor = System.Drawing.Color.Khaki;
            this.cboProveedor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(904, 232);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(218, 24);
            this.cboProveedor.TabIndex = 5;
            this.cboProveedor.Tag = "Proveedor";
            // 
            // cboCategoria
            // 
            this.cboCategoria.BackColor = System.Drawing.Color.Khaki;
            this.cboCategoria.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(904, 202);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(218, 24);
            this.cboCategoria.TabIndex = 4;
            this.cboCategoria.Tag = "Categoria";
            // 
            // txtProducto
            // 
            this.txtProducto.BackColor = System.Drawing.Color.Khaki;
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(904, 130);
            this.txtProducto.MaxLength = 100;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(218, 24);
            this.txtProducto.TabIndex = 2;
            this.txtProducto.Tag = "Producto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(842, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 14);
            this.label10.TabIndex = 14;
            this.label10.Text = "Producto:";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.BotonActualizar;
            this.cmdGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdGuardar.Location = new System.Drawing.Point(815, 401);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(158, 42);
            this.cmdGuardar.TabIndex = 28;
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            this.cmdGuardar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmdGuadar_MouseDown);
            this.cmdGuardar.MouseLeave += new System.EventHandler(this.cmdGuadar_MouseLeave);
            this.cmdGuardar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmdGuadar_MouseMove);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.BotonEliminar;
            this.cmdEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdEliminar.Location = new System.Drawing.Point(973, 401);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(158, 42);
            this.cmdEliminar.TabIndex = 29;
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            this.cmdEliminar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmdEliminar_MouseDown);
            this.cmdEliminar.MouseLeave += new System.EventHandler(this.cmdEliminar_MouseLeave);
            this.cmdEliminar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmdEliminar_MouseMove);
            // 
            // cmdInsertar
            // 
            this.cmdInsertar.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.BotonInsertar;
            this.cmdInsertar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdInsertar.Location = new System.Drawing.Point(894, 359);
            this.cmdInsertar.Name = "cmdInsertar";
            this.cmdInsertar.Size = new System.Drawing.Size(158, 42);
            this.cmdInsertar.TabIndex = 30;
            this.cmdInsertar.UseVisualStyleBackColor = true;
            this.cmdInsertar.Click += new System.EventHandler(this.cmdInsertar_Click);
            this.cmdInsertar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmdInsertar_MouseDown);
            this.cmdInsertar.MouseLeave += new System.EventHandler(this.cmdInsertar_MouseLeave);
            this.cmdInsertar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmdInsertar_MouseMove);
            // 
            // LblID
            // 
            this.LblID.BackColor = System.Drawing.Color.White;
            this.LblID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblID.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.ForeColor = System.Drawing.Color.DarkRed;
            this.LblID.Location = new System.Drawing.Point(1039, 272);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(83, 55);
            this.LblID.TabIndex = 31;
            this.LblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1042, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 14);
            this.label3.TabIndex = 32;
            this.label3.Text = "ID";
            // 
            // txtITBISProducto
            // 
            this.txtITBISProducto.BackColor = System.Drawing.Color.Khaki;
            this.txtITBISProducto.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtITBISProducto.Location = new System.Drawing.Point(904, 290);
            this.txtITBISProducto.MaxLength = 15;
            this.txtITBISProducto.Name = "txtITBISProducto";
            this.txtITBISProducto.Size = new System.Drawing.Size(129, 24);
            this.txtITBISProducto.TabIndex = 34;
            this.txtITBISProducto.Tag = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(863, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 14);
            this.label6.TabIndex = 35;
            this.label6.Text = "ITBIS:";
            // 
            // frmMantenimientoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.FondoMantProducto3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1138, 474);
            this.Controls.Add(this.txtITBISProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.cmdInsertar);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboEstatus);
            this.Controls.Add(this.cboProveedor);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.StbMantProducts);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMantenimientoProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmMantenimientoProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.StbMantProducts.ResumeLayout(false);
            this.StbMantProducts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.StatusStrip StbMantProducts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboEstatus;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdInsertar;
        private System.Windows.Forms.ToolStripStatusLabel tsslTotalProductos;
        private System.Windows.Forms.ToolStripStatusLabel tsslDisponibles;
        private System.Windows.Forms.ToolStripStatusLabel tsslAgotados;
        private System.Windows.Forms.ToolStripStatusLabel tsslTotalProducto;
        private System.Windows.Forms.ToolStripStatusLabel tsslDisponible;
        private System.Windows.Forms.ToolStripStatusLabel tsslAgotado;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.ToolStripStatusLabel tsslUso;
        private System.Windows.Forms.ToolStripStatusLabel tsslMantenimiento;
        private System.Windows.Forms.ToolStripStatusLabel tsslDesactivado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtITBISProducto;
        private System.Windows.Forms.Label label6;
    }
}