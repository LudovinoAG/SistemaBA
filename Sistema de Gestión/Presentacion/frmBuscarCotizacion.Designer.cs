
namespace Sistema_de_Gestión.Presentacion
{
    partial class frmBuscarCotizacion
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
            this.txtCodigoCotizacion = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdMostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoCotizacion)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigoCotizacion
            // 
            this.txtCodigoCotizacion.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCotizacion.Location = new System.Drawing.Point(257, 41);
            this.txtCodigoCotizacion.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtCodigoCotizacion.Name = "txtCodigoCotizacion";
            this.txtCodigoCotizacion.Size = new System.Drawing.Size(85, 28);
            this.txtCodigoCotizacion.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(135, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Num. de cotización:";
            // 
            // cmdMostrar
            // 
            this.cmdMostrar.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.BotonMostrarFactura;
            this.cmdMostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdMostrar.Location = new System.Drawing.Point(160, 80);
            this.cmdMostrar.Name = "cmdMostrar";
            this.cmdMostrar.Size = new System.Drawing.Size(153, 43);
            this.cmdMostrar.TabIndex = 6;
            this.cmdMostrar.UseVisualStyleBackColor = true;
            this.cmdMostrar.Click += new System.EventHandler(this.cmdMostrar_Click);
            // 
            // frmBuscarCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.FondoBuscarCotizacion;
            this.ClientSize = new System.Drawing.Size(369, 156);
            this.Controls.Add(this.txtCodigoCotizacion);
            this.Controls.Add(this.cmdMostrar);
            this.Controls.Add(this.label2);
            this.Name = "frmBuscarCotizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Cotización";
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoCotizacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtCodigoCotizacion;
        private System.Windows.Forms.Button cmdMostrar;
        private System.Windows.Forms.Label label2;
    }
}