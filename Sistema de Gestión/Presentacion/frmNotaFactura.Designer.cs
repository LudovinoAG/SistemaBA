
namespace Sistema_de_Gestión.Presentacion
{
    partial class frmNotaFactura
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
            this.txtNota = new System.Windows.Forms.TextBox();
            this.lblComentario = new System.Windows.Forms.Label();
            this.lblLimite = new System.Windows.Forms.Label();
            this.cmdAgregarComentario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNota
            // 
            this.txtNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota.Location = new System.Drawing.Point(12, 82);
            this.txtNota.MaxLength = 255;
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(331, 99);
            this.txtNota.TabIndex = 1;
            this.txtNota.TextChanged += new System.EventHandler(this.txtNota_TextChanged);
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.BackColor = System.Drawing.Color.Transparent;
            this.lblComentario.Location = new System.Drawing.Point(9, 66);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(63, 13);
            this.lblComentario.TabIndex = 2;
            this.lblComentario.Text = "Comentario:";
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.BackColor = System.Drawing.Color.Transparent;
            this.lblLimite.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimite.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLimite.Location = new System.Drawing.Point(97, 65);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(249, 14);
            this.lblLimite.TabIndex = 2;
            this.lblLimite.Text = "Caracteres introducidos 255 de 255 permitidos.";
            this.lblLimite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmdAgregarComentario
            // 
            this.cmdAgregarComentario.BackColor = System.Drawing.SystemColors.Control;
            this.cmdAgregarComentario.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.BotonAgregarComentario;
            this.cmdAgregarComentario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdAgregarComentario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdAgregarComentario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdAgregarComentario.FlatAppearance.BorderSize = 0;
            this.cmdAgregarComentario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdAgregarComentario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.cmdAgregarComentario.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgregarComentario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdAgregarComentario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdAgregarComentario.Location = new System.Drawing.Point(352, 79);
            this.cmdAgregarComentario.Name = "cmdAgregarComentario";
            this.cmdAgregarComentario.Size = new System.Drawing.Size(159, 105);
            this.cmdAgregarComentario.TabIndex = 88;
            this.cmdAgregarComentario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdAgregarComentario.UseVisualStyleBackColor = false;
            this.cmdAgregarComentario.Click += new System.EventHandler(this.cmdAgregarComentario_Click);
            this.cmdAgregarComentario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmdAgregarComentario_MouseDown);
            this.cmdAgregarComentario.MouseLeave += new System.EventHandler(this.cmdAgregarComentario_MouseLeave);
            this.cmdAgregarComentario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmdAgregarComentario_MouseMove);
            // 
            // frmNotaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.FondoAgregarComentario2;
            this.ClientSize = new System.Drawing.Size(516, 193);
            this.Controls.Add(this.cmdAgregarComentario);
            this.Controls.Add(this.lblLimite);
            this.Controls.Add(this.lblComentario);
            this.Controls.Add(this.txtNota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNotaFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Comentario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Button cmdAgregarComentario;
    }
}