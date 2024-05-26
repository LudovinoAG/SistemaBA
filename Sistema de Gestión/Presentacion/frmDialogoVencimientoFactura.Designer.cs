
namespace Sistema_de_Gestión.Presentacion
{
    partial class frmDialogoVencimientoFactura
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
            this.label2 = new System.Windows.Forms.Label();
            this.UPdiasVencimiento = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdInsertar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UPdiasVencimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(125, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "FACTURA A CREDITO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(125, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Programación de dias para vencimiento";
            // 
            // UPdiasVencimiento
            // 
            this.UPdiasVencimiento.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPdiasVencimiento.Location = new System.Drawing.Point(128, 85);
            this.UPdiasVencimiento.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.UPdiasVencimiento.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UPdiasVencimiento.Name = "UPdiasVencimiento";
            this.UPdiasVencimiento.Size = new System.Drawing.Size(94, 24);
            this.UPdiasVencimiento.TabIndex = 2;
            this.UPdiasVencimiento.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UPdiasVencimiento.ValueChanged += new System.EventHandler(this.UPdiasVencimiento_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad de días:";
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaVencimiento.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVencimiento.ForeColor = System.Drawing.Color.DarkRed;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(239, 88);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(76, 16);
            this.lblFechaVencimiento.TabIndex = 4;
            this.lblFechaVencimiento.Text = "00/00/0000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(238, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha programada:";
            // 
            // cmdInsertar
            // 
            this.cmdInsertar.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.BotonInsertar;
            this.cmdInsertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdInsertar.Location = new System.Drawing.Point(103, 126);
            this.cmdInsertar.Name = "cmdInsertar";
            this.cmdInsertar.Size = new System.Drawing.Size(163, 43);
            this.cmdInsertar.TabIndex = 7;
            this.cmdInsertar.UseVisualStyleBackColor = true;
            this.cmdInsertar.Click += new System.EventHandler(this.cmdInsertar_Click);
            // 
            // frmDialogoVencimientoFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.FondoFacturaCredito;
            this.ClientSize = new System.Drawing.Size(361, 180);
            this.Controls.Add(this.cmdInsertar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFechaVencimiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UPdiasVencimiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDialogoVencimientoFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Credito";
            ((System.ComponentModel.ISupportInitialize)(this.UPdiasVencimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown UPdiasVencimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdInsertar;
        public System.Windows.Forms.Label lblFechaVencimiento;
    }
}