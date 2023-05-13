
namespace Sistema_de_Gestión.Presentacion
{
    partial class frmConfiguraciones
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
            this.tcConfiguraciones = new System.Windows.Forms.TabControl();
            this.tbpComprobanteFiscal = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.lstComprobantes = new System.Windows.Forms.ListBox();
            this.gbRangoComprobantes = new System.Windows.Forms.GroupBox();
            this.cmdActualizar = new System.Windows.Forms.Button();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbDesactivado = new System.Windows.Forms.RadioButton();
            this.rbActivado = new System.Windows.Forms.RadioButton();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProximo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHastaComprobante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComprobanteDesde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpUsuarios = new System.Windows.Forms.TabPage();
            this.cmdInsertUser = new System.Windows.Forms.Button();
            this.cmdEliminarUser = new System.Windows.Forms.Button();
            this.cmdGuardarUser = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.cboEstatusUsuario = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboPerfiles = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMensajeConfiguracion = new System.Windows.Forms.Label();
            this.tcConfiguraciones.SuspendLayout();
            this.tbpComprobanteFiscal.SuspendLayout();
            this.gbRangoComprobantes.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tbpUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcConfiguraciones
            // 
            this.tcConfiguraciones.Controls.Add(this.tbpComprobanteFiscal);
            this.tcConfiguraciones.Controls.Add(this.tbpUsuarios);
            this.tcConfiguraciones.Location = new System.Drawing.Point(13, 23);
            this.tcConfiguraciones.Name = "tcConfiguraciones";
            this.tcConfiguraciones.SelectedIndex = 0;
            this.tcConfiguraciones.Size = new System.Drawing.Size(630, 225);
            this.tcConfiguraciones.TabIndex = 0;
            this.tcConfiguraciones.SelectedIndexChanged += new System.EventHandler(this.tcConfiguraciones_SelectedIndexChanged);
            // 
            // tbpComprobanteFiscal
            // 
            this.tbpComprobanteFiscal.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.LogoFondoFactura2;
            this.tbpComprobanteFiscal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tbpComprobanteFiscal.Controls.Add(this.label6);
            this.tbpComprobanteFiscal.Controls.Add(this.lstComprobantes);
            this.tbpComprobanteFiscal.Controls.Add(this.gbRangoComprobantes);
            this.tbpComprobanteFiscal.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpComprobanteFiscal.Location = new System.Drawing.Point(4, 22);
            this.tbpComprobanteFiscal.Name = "tbpComprobanteFiscal";
            this.tbpComprobanteFiscal.Padding = new System.Windows.Forms.Padding(3);
            this.tbpComprobanteFiscal.Size = new System.Drawing.Size(622, 199);
            this.tbpComprobanteFiscal.TabIndex = 0;
            this.tbpComprobanteFiscal.Text = "Comprobante Fiscal";
            this.tbpComprobanteFiscal.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(500, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 14);
            this.label6.TabIndex = 2;
            this.label6.Text = "Disponibles:";
            // 
            // lstComprobantes
            // 
            this.lstComprobantes.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstComprobantes.FormattingEnabled = true;
            this.lstComprobantes.ItemHeight = 14;
            this.lstComprobantes.Location = new System.Drawing.Point(504, 38);
            this.lstComprobantes.Name = "lstComprobantes";
            this.lstComprobantes.Size = new System.Drawing.Size(109, 158);
            this.lstComprobantes.TabIndex = 1;
            // 
            // gbRangoComprobantes
            // 
            this.gbRangoComprobantes.Controls.Add(this.cmdActualizar);
            this.gbRangoComprobantes.Controls.Add(this.lblEstatus);
            this.gbRangoComprobantes.Controls.Add(this.groupBox2);
            this.gbRangoComprobantes.Controls.Add(this.dtpFechaVencimiento);
            this.gbRangoComprobantes.Controls.Add(this.label3);
            this.gbRangoComprobantes.Controls.Add(this.txtProximo);
            this.gbRangoComprobantes.Controls.Add(this.label4);
            this.gbRangoComprobantes.Controls.Add(this.txtTipo);
            this.gbRangoComprobantes.Controls.Add(this.label8);
            this.gbRangoComprobantes.Controls.Add(this.txtSerie);
            this.gbRangoComprobantes.Controls.Add(this.label7);
            this.gbRangoComprobantes.Controls.Add(this.txtCantidad);
            this.gbRangoComprobantes.Controls.Add(this.label5);
            this.gbRangoComprobantes.Controls.Add(this.txtHastaComprobante);
            this.gbRangoComprobantes.Controls.Add(this.label2);
            this.gbRangoComprobantes.Controls.Add(this.txtComprobanteDesde);
            this.gbRangoComprobantes.Controls.Add(this.label1);
            this.gbRangoComprobantes.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRangoComprobantes.Location = new System.Drawing.Point(21, 21);
            this.gbRangoComprobantes.Name = "gbRangoComprobantes";
            this.gbRangoComprobantes.Size = new System.Drawing.Size(477, 176);
            this.gbRangoComprobantes.TabIndex = 0;
            this.gbRangoComprobantes.TabStop = false;
            this.gbRangoComprobantes.Text = "Rango de Comprobantes:";
            // 
            // cmdActualizar
            // 
            this.cmdActualizar.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.BotonActualizar;
            this.cmdActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdActualizar.Location = new System.Drawing.Point(313, 128);
            this.cmdActualizar.Name = "cmdActualizar";
            this.cmdActualizar.Size = new System.Drawing.Size(158, 42);
            this.cmdActualizar.TabIndex = 51;
            this.cmdActualizar.UseVisualStyleBackColor = true;
            this.cmdActualizar.Click += new System.EventHandler(this.cmdActualizar_Click);
            this.cmdActualizar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmdActualizar_MouseDown);
            this.cmdActualizar.MouseLeave += new System.EventHandler(this.cmdActualizar_MouseLeave);
            this.cmdActualizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmdActualizar_MouseMove);
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Location = new System.Drawing.Point(26, 175);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(55, 16);
            this.lblEstatus.TabIndex = 8;
            this.lblEstatus.Text = "Activado";
            this.lblEstatus.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbDesactivado);
            this.groupBox2.Controls.Add(this.rbActivado);
            this.groupBox2.Location = new System.Drawing.Point(67, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 55);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estatus:";
            // 
            // rbDesactivado
            // 
            this.rbDesactivado.AutoSize = true;
            this.rbDesactivado.Location = new System.Drawing.Point(99, 23);
            this.rbDesactivado.Name = "rbDesactivado";
            this.rbDesactivado.Size = new System.Drawing.Size(90, 20);
            this.rbDesactivado.TabIndex = 0;
            this.rbDesactivado.Text = "Desactivado";
            this.rbDesactivado.UseVisualStyleBackColor = true;
            this.rbDesactivado.Click += new System.EventHandler(this.rbDesactivado_Click);
            // 
            // rbActivado
            // 
            this.rbActivado.AutoSize = true;
            this.rbActivado.Checked = true;
            this.rbActivado.Location = new System.Drawing.Point(22, 23);
            this.rbActivado.Name = "rbActivado";
            this.rbActivado.Size = new System.Drawing.Size(73, 20);
            this.rbActivado.TabIndex = 0;
            this.rbActivado.TabStop = true;
            this.rbActivado.Text = "Activado";
            this.rbActivado.UseVisualStyleBackColor = true;
            this.rbActivado.Click += new System.EventHandler(this.rbActivado_Click);
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.CustomFormat = "dd/mm/yyyy";
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(357, 25);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(111, 23);
            this.dtpFechaVencimiento.TabIndex = 4;
            this.dtpFechaVencimiento.Value = new System.DateTime(2022, 9, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Venc.:";
            // 
            // txtProximo
            // 
            this.txtProximo.Location = new System.Drawing.Point(202, 78);
            this.txtProximo.MaxLength = 20;
            this.txtProximo.Name = "txtProximo";
            this.txtProximo.ReadOnly = true;
            this.txtProximo.Size = new System.Drawing.Size(70, 23);
            this.txtProximo.TabIndex = 3;
            this.txtProximo.Tag = "Proximo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(142, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Próximo:";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(67, 50);
            this.txtTipo.MaxLength = 2;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(70, 23);
            this.txtTipo.TabIndex = 5;
            this.txtTipo.Tag = "Tipo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 16);
            this.label8.TabIndex = 2;
            this.label8.Tag = "";
            this.label8.Text = "Tipo:";
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(67, 23);
            this.txtSerie.MaxLength = 1;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(70, 23);
            this.txtSerie.TabIndex = 5;
            this.txtSerie.Tag = "Serie";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Serie:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(67, 78);
            this.txtCantidad.MaxLength = 20;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(70, 23);
            this.txtCantidad.TabIndex = 5;
            this.txtCantidad.Tag = "Cantidad";
            this.txtCantidad.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cantidad:";
            // 
            // txtHastaComprobante
            // 
            this.txtHastaComprobante.Location = new System.Drawing.Point(202, 51);
            this.txtHastaComprobante.MaxLength = 20;
            this.txtHastaComprobante.Name = "txtHastaComprobante";
            this.txtHastaComprobante.Size = new System.Drawing.Size(70, 23);
            this.txtHastaComprobante.TabIndex = 2;
            this.txtHastaComprobante.Tag = "Hasta";
            this.txtHastaComprobante.Leave += new System.EventHandler(this.txtHastaComprobante_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta:";
            // 
            // txtComprobanteDesde
            // 
            this.txtComprobanteDesde.Location = new System.Drawing.Point(202, 24);
            this.txtComprobanteDesde.MaxLength = 20;
            this.txtComprobanteDesde.Name = "txtComprobanteDesde";
            this.txtComprobanteDesde.Size = new System.Drawing.Size(70, 23);
            this.txtComprobanteDesde.TabIndex = 1;
            this.txtComprobanteDesde.Tag = "Desde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde:";
            // 
            // tbpUsuarios
            // 
            this.tbpUsuarios.Controls.Add(this.cmdInsertUser);
            this.tbpUsuarios.Controls.Add(this.cmdEliminarUser);
            this.tbpUsuarios.Controls.Add(this.cmdGuardarUser);
            this.tbpUsuarios.Controls.Add(this.dgvUsuarios);
            this.tbpUsuarios.Controls.Add(this.label14);
            this.tbpUsuarios.Controls.Add(this.cboEstatusUsuario);
            this.tbpUsuarios.Controls.Add(this.label9);
            this.tbpUsuarios.Controls.Add(this.cboPerfiles);
            this.tbpUsuarios.Controls.Add(this.label13);
            this.tbpUsuarios.Controls.Add(this.txtEmail);
            this.tbpUsuarios.Controls.Add(this.txtClave);
            this.tbpUsuarios.Controls.Add(this.label12);
            this.tbpUsuarios.Controls.Add(this.label11);
            this.tbpUsuarios.Controls.Add(this.label10);
            this.tbpUsuarios.Controls.Add(this.txtUsuario);
            this.tbpUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tbpUsuarios.Name = "tbpUsuarios";
            this.tbpUsuarios.Size = new System.Drawing.Size(622, 199);
            this.tbpUsuarios.TabIndex = 1;
            this.tbpUsuarios.Text = "Usuarios";
            this.tbpUsuarios.UseVisualStyleBackColor = true;
            // 
            // cmdInsertUser
            // 
            this.cmdInsertUser.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.BotonInsertar;
            this.cmdInsertUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdInsertUser.Location = new System.Drawing.Point(122, 150);
            this.cmdInsertUser.Name = "cmdInsertUser";
            this.cmdInsertUser.Size = new System.Drawing.Size(158, 42);
            this.cmdInsertUser.TabIndex = 52;
            this.cmdInsertUser.UseVisualStyleBackColor = true;
            this.cmdInsertUser.Click += new System.EventHandler(this.cmdInsertUser_Click);
            this.cmdInsertUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmdInsertUser_MouseDown);
            this.cmdInsertUser.MouseLeave += new System.EventHandler(this.cmdInsertUser_MouseLeave);
            this.cmdInsertUser.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmdInsertUser_MouseMove);
            // 
            // cmdEliminarUser
            // 
            this.cmdEliminarUser.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.BotonEliminar;
            this.cmdEliminarUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdEliminarUser.Location = new System.Drawing.Point(450, 150);
            this.cmdEliminarUser.Name = "cmdEliminarUser";
            this.cmdEliminarUser.Size = new System.Drawing.Size(158, 42);
            this.cmdEliminarUser.TabIndex = 51;
            this.cmdEliminarUser.UseVisualStyleBackColor = true;
            this.cmdEliminarUser.Click += new System.EventHandler(this.cmdEliminarUser_Click);
            this.cmdEliminarUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmdEliminarUser_MouseDown);
            this.cmdEliminarUser.MouseLeave += new System.EventHandler(this.cmdEliminarUser_MouseLeave);
            this.cmdEliminarUser.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmdEliminarUser_MouseMove);
            // 
            // cmdGuardarUser
            // 
            this.cmdGuardarUser.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.BotonActualizar;
            this.cmdGuardarUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdGuardarUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdGuardarUser.Location = new System.Drawing.Point(286, 150);
            this.cmdGuardarUser.Name = "cmdGuardarUser";
            this.cmdGuardarUser.Size = new System.Drawing.Size(158, 42);
            this.cmdGuardarUser.TabIndex = 50;
            this.cmdGuardarUser.UseVisualStyleBackColor = true;
            this.cmdGuardarUser.Click += new System.EventHandler(this.cmdGuardarUser_Click);
            this.cmdGuardarUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmdGuardarUser_MouseDown);
            this.cmdGuardarUser.MouseLeave += new System.EventHandler(this.cmdGuardarUser_MouseLeave);
            this.cmdGuardarUser.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmdGuardarUser_MouseMove);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(209, 28);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(399, 115);
            this.dgvUsuarios.TabIndex = 9;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkGray;
            this.label14.Location = new System.Drawing.Point(206, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(179, 16);
            this.label14.TabIndex = 8;
            this.label14.Text = "Mantenimiento de Usuarios";
            // 
            // cboEstatusUsuario
            // 
            this.cboEstatusUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstatusUsuario.FormattingEnabled = true;
            this.cboEstatusUsuario.Location = new System.Drawing.Point(60, 119);
            this.cboEstatusUsuario.Name = "cboEstatusUsuario";
            this.cboEstatusUsuario.Size = new System.Drawing.Size(143, 24);
            this.cboEstatusUsuario.TabIndex = 4;
            this.cboEstatusUsuario.Tag = "Estatus";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Estatus:";
            // 
            // cboPerfiles
            // 
            this.cboPerfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPerfiles.FormattingEnabled = true;
            this.cboPerfiles.Location = new System.Drawing.Point(60, 91);
            this.cboPerfiles.Name = "cboPerfiles";
            this.cboPerfiles.Size = new System.Drawing.Size(143, 24);
            this.cboPerfiles.TabIndex = 4;
            this.cboPerfiles.Tag = "Perfil";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 16);
            this.label13.TabIndex = 6;
            this.label13.Text = "Perfil:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(60, 65);
            this.txtEmail.MaxLength = 65;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(143, 22);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Tag = "Email";
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(60, 39);
            this.txtClave.MaxLength = 20;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(143, 22);
            this.txtClave.TabIndex = 2;
            this.txtClave.Tag = "Clave";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Email:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Clave:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(60, 13);
            this.txtUsuario.MaxLength = 65;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(143, 22);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Tag = "Usuario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.lblMensajeConfiguracion);
            this.panel1.Location = new System.Drawing.Point(105, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 44);
            this.panel1.TabIndex = 1;
            // 
            // lblMensajeConfiguracion
            // 
            this.lblMensajeConfiguracion.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeConfiguracion.Location = new System.Drawing.Point(21, 15);
            this.lblMensajeConfiguracion.Name = "lblMensajeConfiguracion";
            this.lblMensajeConfiguracion.Size = new System.Drawing.Size(499, 16);
            this.lblMensajeConfiguracion.TabIndex = 0;
            this.lblMensajeConfiguracion.Text = "Para configurar el comprobante fiscal debe introducir la información suministrada" +
    " por la DGII";
            this.lblMensajeConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmConfiguraciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.FondoConfiguracion;
            this.ClientSize = new System.Drawing.Size(655, 315);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tcConfiguraciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmConfiguraciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuraciones";
            this.Load += new System.EventHandler(this.frmConfiguraciones_Load);
            this.tcConfiguraciones.ResumeLayout(false);
            this.tbpComprobanteFiscal.ResumeLayout(false);
            this.tbpComprobanteFiscal.PerformLayout();
            this.gbRangoComprobantes.ResumeLayout(false);
            this.gbRangoComprobantes.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tbpUsuarios.ResumeLayout(false);
            this.tbpUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcConfiguraciones;
        private System.Windows.Forms.TabPage tbpComprobanteFiscal;
        private System.Windows.Forms.GroupBox gbRangoComprobantes;
        private System.Windows.Forms.TextBox txtHastaComprobante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtComprobanteDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProximo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbDesactivado;
        private System.Windows.Forms.RadioButton rbActivado;
        private System.Windows.Forms.ListBox lstComprobantes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMensajeConfiguracion;
        private System.Windows.Forms.TabPage tbpUsuarios;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ComboBox cboPerfiles;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button cmdInsertUser;
        private System.Windows.Forms.Button cmdEliminarUser;
        private System.Windows.Forms.Button cmdGuardarUser;
        private System.Windows.Forms.ComboBox cboEstatusUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cmdActualizar;
    }
}