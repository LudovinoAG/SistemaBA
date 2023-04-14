
namespace Sistema_de_Gestión.Presentacion
{
    partial class frmMantenimientoVehiculos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFiltrar = new System.Windows.Forms.ComboBox();
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.StbMantVehiculos = new System.Windows.Forms.StatusStrip();
            this.tsslTotalVehiculos = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTotalVehiculosActivos = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTotalVehiculosInactivos = new System.Windows.Forms.ToolStripStatusLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboEstatus = new System.Windows.Forms.ComboBox();
            this.cboSeguro = new System.Windows.Forms.ComboBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.dtpEmisionSeguro = new System.Windows.Forms.DateTimePicker();
            this.dtpVencimientoSeguro = new System.Windows.Forms.DateTimePicker();
            this.cmdInsertar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.StbMantVehiculos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboFiltrar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 62);
            this.groupBox1.TabIndex = 5;
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
            // dgvVehiculos
            // 
            this.dgvVehiculos.AllowUserToAddRows = false;
            this.dgvVehiculos.AllowUserToDeleteRows = false;
            this.dgvVehiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvVehiculos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVehiculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Location = new System.Drawing.Point(10, 103);
            this.dgvVehiculos.MultiSelect = false;
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVehiculos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehiculos.Size = new System.Drawing.Size(635, 322);
            this.dgvVehiculos.TabIndex = 4;
            this.dgvVehiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehiculos_CellClick);
            // 
            // StbMantVehiculos
            // 
            this.StbMantVehiculos.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.StbMantVehiculos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTotalVehiculos,
            this.tsslTotalVehiculosActivos,
            this.tsslTotalVehiculosInactivos});
            this.StbMantVehiculos.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.StbMantVehiculos.Location = new System.Drawing.Point(0, 434);
            this.StbMantVehiculos.Name = "StbMantVehiculos";
            this.StbMantVehiculos.Size = new System.Drawing.Size(979, 24);
            this.StbMantVehiculos.TabIndex = 6;
            this.StbMantVehiculos.Text = "statusStrip1";
            // 
            // tsslTotalVehiculos
            // 
            this.tsslTotalVehiculos.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslTotalVehiculos.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.tsslTotalVehiculos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsslTotalVehiculos.Name = "tsslTotalVehiculos";
            this.tsslTotalVehiculos.Size = new System.Drawing.Size(123, 19);
            this.tsslTotalVehiculos.Text = "Total de vehiculos: 0";
            // 
            // tsslTotalVehiculosActivos
            // 
            this.tsslTotalVehiculosActivos.ForeColor = System.Drawing.Color.Green;
            this.tsslTotalVehiculosActivos.Name = "tsslTotalVehiculosActivos";
            this.tsslTotalVehiculosActivos.Size = new System.Drawing.Size(58, 19);
            this.tsslTotalVehiculosActivos.Text = "Activos: 0";
            // 
            // tsslTotalVehiculosInactivos
            // 
            this.tsslTotalVehiculosInactivos.ForeColor = System.Drawing.Color.DarkRed;
            this.tsslTotalVehiculosInactivos.Name = "tsslTotalVehiculosInactivos";
            this.tsslTotalVehiculosInactivos.Size = new System.Drawing.Size(66, 19);
            this.tsslTotalVehiculosInactivos.Text = "Inactivos: 0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(681, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 14);
            this.label7.TabIndex = 39;
            this.label7.Text = "Emi. Seguro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(706, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 14);
            this.label5.TabIndex = 38;
            this.label5.Text = "Seguro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(694, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 14);
            this.label4.TabIndex = 37;
            this.label4.Text = "Matrícula:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(683, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 14);
            this.label8.TabIndex = 36;
            this.label8.Text = "Descripción:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(702, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 14);
            this.label9.TabIndex = 35;
            this.label9.Text = "Modelo:";
            // 
            // cboEstatus
            // 
            this.cboEstatus.BackColor = System.Drawing.Color.Khaki;
            this.cboEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstatus.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstatus.FormattingEnabled = true;
            this.cboEstatus.Location = new System.Drawing.Point(757, 304);
            this.cboEstatus.Name = "cboEstatus";
            this.cboEstatus.Size = new System.Drawing.Size(171, 24);
            this.cboEstatus.TabIndex = 8;
            this.cboEstatus.Tag = "Estatus";
            // 
            // cboSeguro
            // 
            this.cboSeguro.BackColor = System.Drawing.Color.Khaki;
            this.cboSeguro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSeguro.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSeguro.FormattingEnabled = true;
            this.cboSeguro.Location = new System.Drawing.Point(757, 178);
            this.cboSeguro.Name = "cboSeguro";
            this.cboSeguro.Size = new System.Drawing.Size(171, 24);
            this.cboSeguro.TabIndex = 4;
            this.cboSeguro.Tag = "Seguro";
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.Khaki;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(757, 94);
            this.txtMarca.MaxLength = 60;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(171, 24);
            this.txtMarca.TabIndex = 1;
            this.txtMarca.Tag = "Marca";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(711, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 14);
            this.label10.TabIndex = 34;
            this.label10.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(675, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 14);
            this.label3.TabIndex = 39;
            this.label3.Text = "Venc. Seguro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(706, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 14);
            this.label6.TabIndex = 40;
            this.label6.Text = "Estatus:";
            // 
            // txtModelo
            // 
            this.txtModelo.BackColor = System.Drawing.Color.Khaki;
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(757, 122);
            this.txtModelo.MaxLength = 60;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(171, 24);
            this.txtModelo.TabIndex = 2;
            this.txtModelo.Tag = "Modelo";
            this.txtModelo.Leave += new System.EventHandler(this.txtModelo_Leave);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.Khaki;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(757, 258);
            this.txtDescripcion.MaxLength = 80;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(171, 41);
            this.txtDescripcion.TabIndex = 7;
            this.txtDescripcion.Tag = "Descripcion";
            // 
            // txtMatricula
            // 
            this.txtMatricula.BackColor = System.Drawing.Color.Khaki;
            this.txtMatricula.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.Location = new System.Drawing.Point(757, 150);
            this.txtMatricula.MaxLength = 60;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(171, 24);
            this.txtMatricula.TabIndex = 3;
            this.txtMatricula.Tag = "Matricula";
            // 
            // dtpEmisionSeguro
            // 
            this.dtpEmisionSeguro.CustomFormat = "dd/mm/yyyy";
            this.dtpEmisionSeguro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmisionSeguro.Location = new System.Drawing.Point(757, 208);
            this.dtpEmisionSeguro.Name = "dtpEmisionSeguro";
            this.dtpEmisionSeguro.Size = new System.Drawing.Size(171, 20);
            this.dtpEmisionSeguro.TabIndex = 5;
            this.dtpEmisionSeguro.Value = new System.DateTime(2022, 10, 1, 0, 0, 0, 0);
            // 
            // dtpVencimientoSeguro
            // 
            this.dtpVencimientoSeguro.CustomFormat = "dd/mm/yyyy";
            this.dtpVencimientoSeguro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimientoSeguro.Location = new System.Drawing.Point(757, 234);
            this.dtpVencimientoSeguro.Name = "dtpVencimientoSeguro";
            this.dtpVencimientoSeguro.Size = new System.Drawing.Size(171, 20);
            this.dtpVencimientoSeguro.TabIndex = 6;
            this.dtpVencimientoSeguro.Value = new System.DateTime(2022, 10, 1, 0, 0, 0, 0);
            // 
            // cmdInsertar
            // 
            this.cmdInsertar.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.BotonInsertar;
            this.cmdInsertar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdInsertar.Location = new System.Drawing.Point(729, 341);
            this.cmdInsertar.Name = "cmdInsertar";
            this.cmdInsertar.Size = new System.Drawing.Size(158, 42);
            this.cmdInsertar.TabIndex = 45;
            this.cmdInsertar.UseVisualStyleBackColor = true;
            this.cmdInsertar.Click += new System.EventHandler(this.cmdInsertar_Click);
            this.cmdInsertar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmdInsertar_MouseDown);
            this.cmdInsertar.MouseLeave += new System.EventHandler(this.cmdInsertar_MouseLeave);
            this.cmdInsertar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmdInsertar_MouseMove);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.BotonEliminar;
            this.cmdEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdEliminar.Location = new System.Drawing.Point(808, 383);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(158, 42);
            this.cmdEliminar.TabIndex = 44;
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            this.cmdEliminar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmdEliminar_MouseDown);
            this.cmdEliminar.MouseLeave += new System.EventHandler(this.cmdEliminar_MouseLeave);
            this.cmdEliminar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmdEliminar_MouseMove);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.BotonActualizar;
            this.cmdGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdGuardar.Location = new System.Drawing.Point(650, 383);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(158, 42);
            this.cmdGuardar.TabIndex = 43;
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            this.cmdGuardar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmdGuardar_MouseDown);
            this.cmdGuardar.MouseLeave += new System.EventHandler(this.cmdGuardar_MouseLeave);
            this.cmdGuardar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmdGuardar_MouseMove);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(721, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 14);
            this.label11.TabIndex = 34;
            this.label11.Text = "Cap.:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.BackColor = System.Drawing.Color.Khaki;
            this.txtCapacidad.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacidad.Location = new System.Drawing.Point(757, 66);
            this.txtCapacidad.MaxLength = 6;
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(171, 24);
            this.txtCapacidad.TabIndex = 1;
            this.txtCapacidad.Tag = "Capacidad";
            this.txtCapacidad.Text = "0";
            // 
            // frmMantenimientoVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.FondoMantenimientoVehiculos3;
            this.ClientSize = new System.Drawing.Size(979, 458);
            this.Controls.Add(this.cmdInsertar);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.dtpVencimientoSeguro);
            this.Controls.Add(this.dtpEmisionSeguro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboEstatus);
            this.Controls.Add(this.cboSeguro);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.StbMantVehiculos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvVehiculos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMantenimientoVehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vehiculos";
            this.Load += new System.EventHandler(this.frmMantenimientoVehiculos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.StbMantVehiculos.ResumeLayout(false);
            this.StbMantVehiculos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFiltrar;
        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.StatusStrip StbMantVehiculos;
        private System.Windows.Forms.ToolStripStatusLabel tsslTotalVehiculos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboEstatus;
        private System.Windows.Forms.ComboBox cboSeguro;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.DateTimePicker dtpEmisionSeguro;
        private System.Windows.Forms.DateTimePicker dtpVencimientoSeguro;
        private System.Windows.Forms.Button cmdInsertar;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.ToolStripStatusLabel tsslTotalVehiculosActivos;
        private System.Windows.Forms.ToolStripStatusLabel tsslTotalVehiculosInactivos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCapacidad;
    }
}