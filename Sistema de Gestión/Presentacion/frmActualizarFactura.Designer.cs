
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdAplicar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumFactura = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificar fechas";
            // 
            // dtpFechaFactura
            // 
            this.dtpFechaFactura.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFactura.Location = new System.Drawing.Point(135, 58);
            this.dtpFechaFactura.Name = "dtpFechaFactura";
            this.dtpFechaFactura.Size = new System.Drawing.Size(107, 20);
            this.dtpFechaFactura.TabIndex = 1;
            this.dtpFechaFactura.Value = new System.DateTime(2023, 6, 20, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Factura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Vencimiento:";
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(135, 84);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(107, 20);
            this.dtpFechaVencimiento.TabIndex = 5;
            this.dtpFechaVencimiento.Value = new System.DateTime(2023, 6, 20, 0, 0, 0, 0);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(36, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 2);
            this.panel1.TabIndex = 6;
            // 
            // cmdAplicar
            // 
            this.cmdAplicar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAplicar.Location = new System.Drawing.Point(267, 57);
            this.cmdAplicar.Name = "cmdAplicar";
            this.cmdAplicar.Size = new System.Drawing.Size(108, 48);
            this.cmdAplicar.TabIndex = 7;
            this.cmdAplicar.Text = "GUARDAR";
            this.cmdAplicar.UseVisualStyleBackColor = true;
            this.cmdAplicar.Click += new System.EventHandler(this.cmdAplicar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Num. Factura:";
            // 
            // lblNumFactura
            // 
            this.lblNumFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFactura.Location = new System.Drawing.Point(358, 21);
            this.lblNumFactura.Name = "lblNumFactura";
            this.lblNumFactura.Size = new System.Drawing.Size(50, 16);
            this.lblNumFactura.TabIndex = 9;
            this.lblNumFactura.Text = "0";
            this.lblNumFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmActualizarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 131);
            this.Controls.Add(this.lblNumFactura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdAplicar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpFechaVencimiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaFactura);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmActualizarFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Factura";
            this.Load += new System.EventHandler(this.frmActualizarFactura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdAplicar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumFactura;
    }
}