namespace RegistroUNAH
{
    partial class frmPronosticoAprobacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPronosticoAprobacion));
            this.grbNiveles = new System.Windows.Forms.GroupBox();
            this.lblAños = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.chkbNivel4 = new System.Windows.Forms.CheckBox();
            this.chkbNivel3 = new System.Windows.Forms.CheckBox();
            this.chkbNivel2 = new System.Windows.Forms.CheckBox();
            this.chkbNivel1 = new System.Windows.Forms.CheckBox();
            this.DtGrdVwCalificaciones = new System.Windows.Forms.DataGridView();
            this.IdClasePlanEst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcAPR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcRPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComboBoxAsigDispon = new System.Windows.Forms.ComboBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblProbAprob = new System.Windows.Forms.Label();
            this.grbNiveles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrdVwCalificaciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbNiveles
            // 
            this.grbNiveles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbNiveles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grbNiveles.Controls.Add(this.lblAños);
            this.grbNiveles.Controls.Add(this.numericUpDown1);
            this.grbNiveles.Controls.Add(this.chkbNivel4);
            this.grbNiveles.Controls.Add(this.chkbNivel3);
            this.grbNiveles.Controls.Add(this.chkbNivel2);
            this.grbNiveles.Controls.Add(this.chkbNivel1);
            this.grbNiveles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNiveles.ForeColor = System.Drawing.Color.White;
            this.grbNiveles.Location = new System.Drawing.Point(13, 13);
            this.grbNiveles.Name = "grbNiveles";
            this.grbNiveles.Size = new System.Drawing.Size(961, 84);
            this.grbNiveles.TabIndex = 0;
            this.grbNiveles.TabStop = false;
            this.grbNiveles.Text = "NIVELES";
            // 
            // lblAños
            // 
            this.lblAños.AutoSize = true;
            this.lblAños.Location = new System.Drawing.Point(306, 58);
            this.lblAños.Name = "lblAños";
            this.lblAños.Size = new System.Drawing.Size(62, 16);
            this.lblAños.TabIndex = 3;
            this.lblAños.Text = "N° Años: ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(382, 52);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(58, 22);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkbNivel4
            // 
            this.chkbNivel4.AutoSize = true;
            this.chkbNivel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbNivel4.Location = new System.Drawing.Point(462, 31);
            this.chkbNivel4.Name = "chkbNivel4";
            this.chkbNivel4.Size = new System.Drawing.Size(71, 20);
            this.chkbNivel4.TabIndex = 0;
            this.chkbNivel4.Text = "INDICE";
            this.chkbNivel4.UseVisualStyleBackColor = true;
            // 
            // chkbNivel3
            // 
            this.chkbNivel3.AutoSize = true;
            this.chkbNivel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbNivel3.Location = new System.Drawing.Point(309, 31);
            this.chkbNivel3.Name = "chkbNivel3";
            this.chkbNivel3.Size = new System.Drawing.Size(132, 20);
            this.chkbNivel3.TabIndex = 0;
            this.chkbNivel3.Text = "GENERACIONAL";
            this.chkbNivel3.UseVisualStyleBackColor = true;
            // 
            // chkbNivel2
            // 
            this.chkbNivel2.AutoSize = true;
            this.chkbNivel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbNivel2.Location = new System.Drawing.Point(118, 31);
            this.chkbNivel2.Name = "chkbNivel2";
            this.chkbNivel2.Size = new System.Drawing.Size(186, 20);
            this.chkbNivel2.TabIndex = 0;
            this.chkbNivel2.Text = "POR CANTIDAD CLASES ";
            this.chkbNivel2.UseVisualStyleBackColor = true;
            // 
            // chkbNivel1
            // 
            this.chkbNivel1.AutoSize = true;
            this.chkbNivel1.Checked = true;
            this.chkbNivel1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbNivel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbNivel1.Location = new System.Drawing.Point(6, 31);
            this.chkbNivel1.Name = "chkbNivel1";
            this.chkbNivel1.Size = new System.Drawing.Size(99, 20);
            this.chkbNivel1.TabIndex = 0;
            this.chkbNivel1.Text = "POR  PESO";
            this.chkbNivel1.UseVisualStyleBackColor = true;
            // 
            // DtGrdVwCalificaciones
            // 
            this.DtGrdVwCalificaciones.AllowUserToAddRows = false;
            this.DtGrdVwCalificaciones.AllowUserToDeleteRows = false;
            this.DtGrdVwCalificaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtGrdVwCalificaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtGrdVwCalificaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtGrdVwCalificaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtGrdVwCalificaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtGrdVwCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGrdVwCalificaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdClasePlanEst,
            this.Clase,
            this.UV,
            this.PorcAPR,
            this.PorcRPB});
            this.DtGrdVwCalificaciones.Location = new System.Drawing.Point(12, 277);
            this.DtGrdVwCalificaciones.MultiSelect = false;
            this.DtGrdVwCalificaciones.Name = "DtGrdVwCalificaciones";
            this.DtGrdVwCalificaciones.ReadOnly = true;
            this.DtGrdVwCalificaciones.Size = new System.Drawing.Size(962, 189);
            this.DtGrdVwCalificaciones.TabIndex = 19;
            // 
            // IdClasePlanEst
            // 
            this.IdClasePlanEst.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IdClasePlanEst.FillWeight = 369.5432F;
            this.IdClasePlanEst.HeaderText = "ID_CLASE_PLAN_ESTUDIOS";
            this.IdClasePlanEst.MinimumWidth = 200;
            this.IdClasePlanEst.Name = "IdClasePlanEst";
            this.IdClasePlanEst.ReadOnly = true;
            this.IdClasePlanEst.Width = 200;
            // 
            // Clase
            // 
            this.Clase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Clase.FillWeight = 10.15228F;
            this.Clase.HeaderText = "CLASE";
            this.Clase.MinimumWidth = 200;
            this.Clase.Name = "Clase";
            this.Clase.ReadOnly = true;
            this.Clase.Width = 200;
            // 
            // UV
            // 
            this.UV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UV.FillWeight = 10.15228F;
            this.UV.HeaderText = "UV";
            this.UV.MinimumWidth = 200;
            this.UV.Name = "UV";
            this.UV.ReadOnly = true;
            this.UV.Width = 200;
            // 
            // PorcAPR
            // 
            this.PorcAPR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PorcAPR.FillWeight = 10.15228F;
            this.PorcAPR.HeaderText = "PORCENTAJE APR";
            this.PorcAPR.MinimumWidth = 200;
            this.PorcAPR.Name = "PorcAPR";
            this.PorcAPR.ReadOnly = true;
            this.PorcAPR.Width = 200;
            // 
            // PorcRPB
            // 
            this.PorcRPB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PorcRPB.HeaderText = "PORCENTAJE RPB";
            this.PorcRPB.Name = "PorcRPB";
            this.PorcRPB.ReadOnly = true;
            this.PorcRPB.Width = 117;
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.BackColor = System.Drawing.Color.Transparent;
            this.lblEstudiante.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblEstudiante.Location = new System.Drawing.Point(12, 100);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(161, 42);
            this.lblEstudiante.TabIndex = 17;
            this.lblEstudiante.Text = "Estudiante:\r\nNúmero de Cuenta\r\n";
            this.lblEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.ComboBoxAsigDispon);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Location = new System.Drawing.Point(12, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(962, 126);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // ComboBoxAsigDispon
            // 
            this.ComboBoxAsigDispon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxAsigDispon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxAsigDispon.FormattingEnabled = true;
            this.ComboBoxAsigDispon.Location = new System.Drawing.Point(6, 19);
            this.ComboBoxAsigDispon.Name = "ComboBoxAsigDispon";
            this.ComboBoxAsigDispon.Size = new System.Drawing.Size(944, 28);
            this.ComboBoxAsigDispon.TabIndex = 0;
            this.ComboBoxAsigDispon.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAsigDispon_SelectedIndexChanged);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDescripcion.Location = new System.Drawing.Point(7, 60);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(186, 42);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Asignatura: \r\nUnidades Valorativas:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnAgregar.Location = new System.Drawing.Point(782, 66);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(169, 32);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.Yellow;
            this.btnCerrar.Location = new System.Drawing.Point(805, 501);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(169, 32);
            this.btnCerrar.TabIndex = 20;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEvaluar.BackColor = System.Drawing.Color.Transparent;
            this.btnEvaluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvaluar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEvaluar.Location = new System.Drawing.Point(455, 501);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(169, 32);
            this.btnEvaluar.TabIndex = 21;
            this.btnEvaluar.Text = "EVALUAR";
            this.btnEvaluar.UseVisualStyleBackColor = false;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.Yellow;
            this.btnReset.Location = new System.Drawing.Point(630, 501);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(169, 32);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "REINICIAR";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblProbAprob
            // 
            this.lblProbAprob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProbAprob.AutoSize = true;
            this.lblProbAprob.BackColor = System.Drawing.Color.Transparent;
            this.lblProbAprob.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProbAprob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProbAprob.ForeColor = System.Drawing.Color.White;
            this.lblProbAprob.Location = new System.Drawing.Point(12, 491);
            this.lblProbAprob.Name = "lblProbAprob";
            this.lblProbAprob.Size = new System.Drawing.Size(270, 42);
            this.lblProbAprob.TabIndex = 23;
            this.lblProbAprob.Text = "PROBABILIDAD DE APROBAR \r\nTODAS LAS CLASES:";
            // 
            // frmPronosticoAprobacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RegistroUNAH.Properties.Resources.fondo01;
            this.ClientSize = new System.Drawing.Size(986, 545);
            this.Controls.Add(this.lblProbAprob);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.DtGrdVwCalificaciones);
            this.Controls.Add(this.lblEstudiante);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbNiveles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPronosticoAprobacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPronosticoAprobacion_Load);
            this.grbNiveles.ResumeLayout(false);
            this.grbNiveles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrdVwCalificaciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbNiveles;
        private System.Windows.Forms.CheckBox chkbNivel4;
        private System.Windows.Forms.CheckBox chkbNivel3;
        private System.Windows.Forms.CheckBox chkbNivel2;
        private System.Windows.Forms.CheckBox chkbNivel1;
        private System.Windows.Forms.DataGridView DtGrdVwCalificaciones;
        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ComboBoxAsigDispon;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblAños;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdClasePlanEst;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clase;
        private System.Windows.Forms.DataGridViewTextBoxColumn UV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcAPR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcRPB;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblProbAprob;
    }
}