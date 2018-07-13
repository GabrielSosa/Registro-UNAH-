namespace RegistroUNAH
{
    partial class frmMostrarClases
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMostrarClases));
            this.groupBoxIndiceGlobal = new System.Windows.Forms.GroupBox();
            this.lblIndiceGlobal = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.groupBoxVisualizarNotas = new System.Windows.Forms.GroupBox();
            this.rbtnAllClassNSP = new System.Windows.Forms.RadioButton();
            this.rbtnAllClassRPB = new System.Windows.Forms.RadioButton();
            this.rbtnAllClassAPR = new System.Windows.Forms.RadioButton();
            this.rbtnAllClass = new System.Windows.Forms.RadioButton();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dataGridViewClases = new System.Windows.Forms.DataGridView();
            this.groupBoxIndiceGlobal.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxVisualizarNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClases)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxIndiceGlobal
            // 
            this.groupBoxIndiceGlobal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxIndiceGlobal.Controls.Add(this.lblIndiceGlobal);
            this.groupBoxIndiceGlobal.Location = new System.Drawing.Point(663, 20);
            this.groupBoxIndiceGlobal.Name = "groupBoxIndiceGlobal";
            this.groupBoxIndiceGlobal.Size = new System.Drawing.Size(329, 64);
            this.groupBoxIndiceGlobal.TabIndex = 8;
            this.groupBoxIndiceGlobal.TabStop = false;
            // 
            // lblIndiceGlobal
            // 
            this.lblIndiceGlobal.AutoSize = true;
            this.lblIndiceGlobal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIndiceGlobal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndiceGlobal.ForeColor = System.Drawing.Color.Yellow;
            this.lblIndiceGlobal.Location = new System.Drawing.Point(6, 25);
            this.lblIndiceGlobal.Name = "lblIndiceGlobal";
            this.lblIndiceGlobal.Size = new System.Drawing.Size(139, 24);
            this.lblIndiceGlobal.TabIndex = 4;
            this.lblIndiceGlobal.Text = "Indice Global:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblEstudiante);
            this.groupBox2.Controls.Add(this.groupBoxVisualizarNotas);
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Location = new System.Drawing.Point(663, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 198);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiante.ForeColor = System.Drawing.Color.White;
            this.lblEstudiante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEstudiante.Location = new System.Drawing.Point(6, 16);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(161, 42);
            this.lblEstudiante.TabIndex = 5;
            this.lblEstudiante.Text = "Estudiante:\r\nNumero de Cuenta\r\n";
            this.lblEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxVisualizarNotas
            // 
            this.groupBoxVisualizarNotas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxVisualizarNotas.Controls.Add(this.rbtnAllClassNSP);
            this.groupBoxVisualizarNotas.Controls.Add(this.rbtnAllClassRPB);
            this.groupBoxVisualizarNotas.Controls.Add(this.rbtnAllClassAPR);
            this.groupBoxVisualizarNotas.Controls.Add(this.rbtnAllClass);
            this.groupBoxVisualizarNotas.ForeColor = System.Drawing.Color.White;
            this.groupBoxVisualizarNotas.Location = new System.Drawing.Point(6, 74);
            this.groupBoxVisualizarNotas.Name = "groupBoxVisualizarNotas";
            this.groupBoxVisualizarNotas.Size = new System.Drawing.Size(218, 118);
            this.groupBoxVisualizarNotas.TabIndex = 6;
            this.groupBoxVisualizarNotas.TabStop = false;
            this.groupBoxVisualizarNotas.Text = "Selecciones un modo";
            // 
            // rbtnAllClassNSP
            // 
            this.rbtnAllClassNSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnAllClassNSP.AutoSize = true;
            this.rbtnAllClassNSP.Location = new System.Drawing.Point(7, 89);
            this.rbtnAllClassNSP.Name = "rbtnAllClassNSP";
            this.rbtnAllClassNSP.Size = new System.Drawing.Size(103, 17);
            this.rbtnAllClassNSP.TabIndex = 3;
            this.rbtnAllClassNSP.Text = "Clases Ausentes";
            this.rbtnAllClassNSP.UseVisualStyleBackColor = true;
            this.rbtnAllClassNSP.CheckedChanged += new System.EventHandler(this.rbtnAllClassNSP_CheckedChanged);
            // 
            // rbtnAllClassRPB
            // 
            this.rbtnAllClassRPB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnAllClassRPB.AutoSize = true;
            this.rbtnAllClassRPB.Location = new System.Drawing.Point(7, 66);
            this.rbtnAllClassRPB.Name = "rbtnAllClassRPB";
            this.rbtnAllClassRPB.Size = new System.Drawing.Size(117, 17);
            this.rbtnAllClassRPB.TabIndex = 2;
            this.rbtnAllClassRPB.Text = "Clases Reprobadas";
            this.rbtnAllClassRPB.UseVisualStyleBackColor = true;
            this.rbtnAllClassRPB.CheckedChanged += new System.EventHandler(this.rbtnAllClassRPB_CheckedChanged);
            // 
            // rbtnAllClassAPR
            // 
            this.rbtnAllClassAPR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnAllClassAPR.AutoSize = true;
            this.rbtnAllClassAPR.Location = new System.Drawing.Point(7, 43);
            this.rbtnAllClassAPR.Name = "rbtnAllClassAPR";
            this.rbtnAllClassAPR.Size = new System.Drawing.Size(110, 17);
            this.rbtnAllClassAPR.TabIndex = 1;
            this.rbtnAllClassAPR.Text = "Clases Aprobadas";
            this.rbtnAllClassAPR.UseVisualStyleBackColor = true;
            this.rbtnAllClassAPR.CheckedChanged += new System.EventHandler(this.rbtnAllClassAPR_CheckedChanged);
            // 
            // rbtnAllClass
            // 
            this.rbtnAllClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnAllClass.AutoSize = true;
            this.rbtnAllClass.Checked = true;
            this.rbtnAllClass.Location = new System.Drawing.Point(7, 20);
            this.rbtnAllClass.Name = "rbtnAllClass";
            this.rbtnAllClass.Size = new System.Drawing.Size(105, 17);
            this.rbtnAllClass.TabIndex = 0;
            this.rbtnAllClass.TabStop = true;
            this.rbtnAllClass.Text = "Todas las Clases";
            this.rbtnAllClass.UseVisualStyleBackColor = true;
            this.rbtnAllClass.CheckedChanged += new System.EventHandler(this.rbtnAllClass_CheckedChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Yellow;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.Location = new System.Drawing.Point(236, 161);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSalir.Size = new System.Drawing.Size(87, 31);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "CLOSE";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dataGridViewClases
            // 
            this.dataGridViewClases.AllowUserToAddRows = false;
            this.dataGridViewClases.AllowUserToDeleteRows = false;
            this.dataGridViewClases.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClases.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewClases.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewClases.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClases.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewClases.Location = new System.Drawing.Point(12, 20);
            this.dataGridViewClases.MultiSelect = false;
            this.dataGridViewClases.Name = "dataGridViewClases";
            this.dataGridViewClases.Size = new System.Drawing.Size(645, 267);
            this.dataGridViewClases.TabIndex = 5;
            // 
            // frmMostrarClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1004, 301);
            this.Controls.Add(this.groupBoxIndiceGlobal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridViewClases);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMostrarClases";
            this.Load += new System.EventHandler(this.frmMostrarClases_Load);
            this.groupBoxIndiceGlobal.ResumeLayout(false);
            this.groupBoxIndiceGlobal.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxVisualizarNotas.ResumeLayout(false);
            this.groupBoxVisualizarNotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClases)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIndiceGlobal;
        private System.Windows.Forms.Label lblIndiceGlobal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.GroupBox groupBoxVisualizarNotas;
        private System.Windows.Forms.RadioButton rbtnAllClassNSP;
        private System.Windows.Forms.RadioButton rbtnAllClassRPB;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.RadioButton rbtnAllClassAPR;
        private System.Windows.Forms.RadioButton rbtnAllClass;
        private System.Windows.Forms.DataGridView dataGridViewClases;
    }
}