
namespace Sistema_de_Gestión.Presentacion
{
    partial class frmBuscarFactura
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmdMostrar = new System.Windows.Forms.Button();
            this.txtCodigoFactura = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(136, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de factura:";
            // 
            // cmdMostrar
            // 
            this.cmdMostrar.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.BotonMostrarFactura;
            this.cmdMostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdMostrar.Location = new System.Drawing.Point(161, 80);
            this.cmdMostrar.Name = "cmdMostrar";
            this.cmdMostrar.Size = new System.Drawing.Size(153, 43);
            this.cmdMostrar.TabIndex = 3;
            this.cmdMostrar.UseVisualStyleBackColor = true;
            this.cmdMostrar.Click += new System.EventHandler(this.cmdMostrar_Click);
            this.cmdMostrar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmdMostrar_MouseClick);
            this.cmdMostrar.MouseLeave += new System.EventHandler(this.cmdMostrar_MouseLeave);
            this.cmdMostrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmdMostrar_MouseMove);
            // 
            // txtCodigoFactura
            // 
            this.txtCodigoFactura.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoFactura.Location = new System.Drawing.Point(258, 41);
            this.txtCodigoFactura.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtCodigoFactura.Name = "txtCodigoFactura";
            this.txtCodigoFactura.Size = new System.Drawing.Size(85, 28);
            this.txtCodigoFactura.TabIndex = 4;
            // 
            // frmBuscarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.FondoBuscarFactura;
            this.ClientSize = new System.Drawing.Size(369, 156);
            this.Controls.Add(this.txtCodigoFactura);
            this.Controls.Add(this.cmdMostrar);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmBuscarFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar Factura";
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdMostrar;
        private System.Windows.Forms.NumericUpDown txtCodigoFactura;
    }
}