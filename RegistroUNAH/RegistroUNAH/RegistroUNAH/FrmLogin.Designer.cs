namespace RegistroUNAH
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.GrpBotones = new System.Windows.Forms.GroupBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtNumeroCuenta = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.GrpBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRegistrar.Location = new System.Drawing.Point(422, 156);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(238, 28);
            this.btnRegistrar.TabIndex = 38;
            this.btnRegistrar.Text = "REGISTRAR NUEVO ESTUDIANTE";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // GrpBotones
            // 
            this.GrpBotones.BackColor = System.Drawing.Color.Transparent;
            this.GrpBotones.Controls.Add(this.lblUser);
            this.GrpBotones.Controls.Add(this.Label1);
            this.GrpBotones.Controls.Add(this.txtContraseña);
            this.GrpBotones.Controls.Add(this.txtNumeroCuenta);
            this.GrpBotones.Location = new System.Drawing.Point(309, 47);
            this.GrpBotones.Name = "GrpBotones";
            this.GrpBotones.Size = new System.Drawing.Size(351, 102);
            this.GrpBotones.TabIndex = 37;
            this.GrpBotones.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Baskerville Old Face", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(2, 20);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(111, 24);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = " No. cuenta:\r\n";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Baskerville Old Face", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(2, 56);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(61, 24);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Clave:";
            this.Label1.Visible = false;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(69, 56);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(261, 26);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.Text = "20121001000";
            this.txtContraseña.Visible = false;
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCuenta.Location = new System.Drawing.Point(119, 20);
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.Size = new System.Drawing.Size(211, 26);
            this.txtNumeroCuenta.TabIndex = 1;
            this.txtNumeroCuenta.Text = "20126969710";
            this.txtNumeroCuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroCuenta_KeyPress);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Transparent;
            this.btnsalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.Yellow;
            this.btnsalir.Location = new System.Drawing.Point(422, 187);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(116, 46);
            this.btnsalir.TabIndex = 35;
            this.btnsalir.Text = "&SALIR";
            this.btnsalir.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.Yellow;
            this.btnAceptar.Location = new System.Drawing.Point(544, 187);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(116, 46);
            this.btnAceptar.TabIndex = 34;
            this.btnAceptar.Text = "&ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.Image = global::RegistroUNAH.Properties.Resources.IS_UNAH_OFICIAL;
            this.PictureBox1.Location = new System.Drawing.Point(15, 12);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(243, 221);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 36;
            this.PictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::RegistroUNAH.Properties.Resources.fondo01;
            this.ClientSize = new System.Drawing.Size(697, 245);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.GrpBotones);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hh";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.GrpBotones.ResumeLayout(false);
            this.GrpBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        internal System.Windows.Forms.GroupBox GrpBotones;
        internal System.Windows.Forms.Label lblUser;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtNumeroCuenta;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnAceptar;
    }
}

