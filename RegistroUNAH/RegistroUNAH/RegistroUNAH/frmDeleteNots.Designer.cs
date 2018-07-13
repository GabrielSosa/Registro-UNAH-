namespace RegistroUNAH
{
    partial class frmDeleteNots
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleteNots));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblExpuProces = new System.Windows.Forms.Label();
            this.ckedListExpuls = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.Yellow;
            this.btnCerrar.Location = new System.Drawing.Point(312, 132);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(88, 26);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblExpuProces
            // 
            this.lblExpuProces.AutoSize = true;
            this.lblExpuProces.BackColor = System.Drawing.Color.Transparent;
            this.lblExpuProces.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpuProces.ForeColor = System.Drawing.Color.Yellow;
            this.lblExpuProces.Location = new System.Drawing.Point(12, 9);
            this.lblExpuProces.Name = "lblExpuProces";
            this.lblExpuProces.Size = new System.Drawing.Size(163, 24);
            this.lblExpuProces.TabIndex = 12;
            this.lblExpuProces.Text = "ELIMINAR CLASE";
            // 
            // ckedListExpuls
            // 
            this.ckedListExpuls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckedListExpuls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ckedListExpuls.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ckedListExpuls.CheckOnClick = true;
            this.ckedListExpuls.ForeColor = System.Drawing.Color.White;
            this.ckedListExpuls.FormattingEnabled = true;
            this.ckedListExpuls.Location = new System.Drawing.Point(12, 36);
            this.ckedListExpuls.Name = "ckedListExpuls";
            this.ckedListExpuls.Size = new System.Drawing.Size(388, 90);
            this.ckedListExpuls.TabIndex = 11;
            this.ckedListExpuls.SelectedIndexChanged += new System.EventHandler(this.ckedListExpuls_SelectedIndexChanged);
            // 
            // frmDeleteNots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::RegistroUNAH.Properties.Resources.fondo01;
            this.ClientSize = new System.Drawing.Size(419, 167);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblExpuProces);
            this.Controls.Add(this.ckedListExpuls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDeleteNots";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDeleteNots_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblExpuProces;
        private System.Windows.Forms.CheckedListBox ckedListExpuls;
    }
}