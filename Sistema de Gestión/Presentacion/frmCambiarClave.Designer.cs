
namespace Sistema_de_Gestión.Presentacion
{
    partial class frmCambiarClave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambiarClave));
            this.label1 = new System.Windows.Forms.Label();
            this.txtClaveActual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNuevaClave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.cmdGuardarClave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(36, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actual:";
            // 
            // txtClaveActual
            // 
            this.txtClaveActual.Location = new System.Drawing.Point(85, 44);
            this.txtClaveActual.MaxLength = 60;
            this.txtClaveActual.Name = "txtClaveActual";
            this.txtClaveActual.PasswordChar = '*';
            this.txtClaveActual.Size = new System.Drawing.Size(130, 20);
            this.txtClaveActual.TabIndex = 1;
            this.txtClaveActual.Tag = "Contraseña Actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(35, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nueva:";
            // 
            // txtNuevaClave
            // 
            this.txtNuevaClave.Location = new System.Drawing.Point(85, 70);
            this.txtNuevaClave.MaxLength = 60;
            this.txtNuevaClave.Name = "txtNuevaClave";
            this.txtNuevaClave.PasswordChar = '*';
            this.txtNuevaClave.Size = new System.Drawing.Size(130, 20);
            this.txtNuevaClave.TabIndex = 2;
            this.txtNuevaClave.Tag = "Nueva Clave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Confirmar:";
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Location = new System.Drawing.Point(85, 96);
            this.txtConfirmarClave.MaxLength = 60;
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.PasswordChar = '*';
            this.txtConfirmarClave.Size = new System.Drawing.Size(130, 20);
            this.txtConfirmarClave.TabIndex = 3;
            this.txtConfirmarClave.Tag = "Confirmar";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(12, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(228, 16);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Usuario Actual: USUARIO DEFINIDO";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmdGuardarClave
            // 
            this.cmdGuardarClave.BackColor = System.Drawing.SystemColors.Control;
            this.cmdGuardarClave.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.BotonGuardarClave;
            this.cmdGuardarClave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdGuardarClave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdGuardarClave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdGuardarClave.FlatAppearance.BorderSize = 0;
            this.cmdGuardarClave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdGuardarClave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.cmdGuardarClave.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardarClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdGuardarClave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdGuardarClave.Location = new System.Drawing.Point(392, 29);
            this.cmdGuardarClave.Name = "cmdGuardarClave";
            this.cmdGuardarClave.Size = new System.Drawing.Size(159, 105);
            this.cmdGuardarClave.TabIndex = 88;
            this.cmdGuardarClave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdGuardarClave.UseVisualStyleBackColor = false;
            this.cmdGuardarClave.Click += new System.EventHandler(this.cmdGuardar_Click);
            this.cmdGuardarClave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmdGuardar_MouseDown);
            this.cmdGuardarClave.MouseLeave += new System.EventHandler(this.cmdGuardar_MouseLeave);
            this.cmdGuardarClave.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmdGuardar_MouseMove);
            // 
            // frmCambiarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_de_Gestión.RecursosBA.FondoCambiarClave2;
            this.ClientSize = new System.Drawing.Size(563, 143);
            this.Controls.Add(this.cmdGuardarClave);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtConfirmarClave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNuevaClave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClaveActual);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCambiarClave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cambiar contraseña";
            this.Load += new System.EventHandler(this.frmCambiarClave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClaveActual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNuevaClave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmarClave;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button cmdGuardarClave;
    }
}