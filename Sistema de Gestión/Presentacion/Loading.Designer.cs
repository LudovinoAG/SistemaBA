
namespace Sistema_de_Gestión.Presentacion
{
    partial class Loading
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
            this.lblMensajeLoading = new System.Windows.Forms.Label();
            this.MiLoading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MiLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensajeLoading
            // 
            this.lblMensajeLoading.BackColor = System.Drawing.Color.DarkOrange;
            this.lblMensajeLoading.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeLoading.ForeColor = System.Drawing.Color.White;
            this.lblMensajeLoading.Location = new System.Drawing.Point(98, 264);
            this.lblMensajeLoading.Name = "lblMensajeLoading";
            this.lblMensajeLoading.Size = new System.Drawing.Size(364, 63);
            this.lblMensajeLoading.TabIndex = 1;
            this.lblMensajeLoading.Text = "Preparando la visualización de la factura, por favor espere...";
            this.lblMensajeLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MiLoading
            // 
            this.MiLoading.Location = new System.Drawing.Point(132, 12);
            this.MiLoading.Name = "MiLoading";
            this.MiLoading.Size = new System.Drawing.Size(292, 239);
            this.MiLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MiLoading.TabIndex = 0;
            this.MiLoading.TabStop = false;
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(562, 338);
            this.Controls.Add(this.lblMensajeLoading);
            this.Controls.Add(this.MiLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.Load += new System.EventHandler(this.Loading_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.MiLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MiLoading;
        private System.Windows.Forms.Label lblMensajeLoading;
    }
}