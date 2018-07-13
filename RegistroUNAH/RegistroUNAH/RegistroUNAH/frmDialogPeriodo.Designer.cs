namespace RegistroUNAH
{
    partial class frmDialogPeriodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDialogPeriodo));
            this.groupBoxPeriodo = new System.Windows.Forms.GroupBox();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.groupBoxPeriodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPeriodo
            // 
            this.groupBoxPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPeriodo.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxPeriodo.Controls.Add(this.txtPeriodo);
            this.groupBoxPeriodo.Controls.Add(this.btnOk);
            this.groupBoxPeriodo.Controls.Add(this.lblPeriodo);
            this.groupBoxPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPeriodo.ForeColor = System.Drawing.Color.White;
            this.groupBoxPeriodo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPeriodo.Name = "groupBoxPeriodo";
            this.groupBoxPeriodo.Size = new System.Drawing.Size(262, 89);
            this.groupBoxPeriodo.TabIndex = 3;
            this.groupBoxPeriodo.TabStop = false;
            this.groupBoxPeriodo.Text = "Periodo";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPeriodo.Location = new System.Drawing.Point(131, 26);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(125, 22);
            this.txtPeriodo.TabIndex = 1;
            this.txtPeriodo.Text = "1";
            this.txtPeriodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPeriodo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeriodo_KeyPress);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.Yellow;
            this.btnOk.Location = new System.Drawing.Point(10, 54);
            this.btnOk.Name = "btnOk";
            this.btnOk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnOk.Size = new System.Drawing.Size(246, 24);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.Location = new System.Drawing.Point(7, 29);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(118, 16);
            this.lblPeriodo.TabIndex = 0;
            this.lblPeriodo.Text = "Ingrese el Periodo";
            // 
            // frmDialogPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::RegistroUNAH.Properties.Resources.fondo01;
            this.ClientSize = new System.Drawing.Size(286, 113);
            this.Controls.Add(this.groupBoxPeriodo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDialogPeriodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBoxPeriodo.ResumeLayout(false);
            this.groupBoxPeriodo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPeriodo;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblPeriodo;
    }
}