namespace RegistroUNAH
{
    partial class frmAgregarClases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarClases));
            this.lblIndice = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.DtGrdVwCalificaciones = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminarCalificaciones = new System.Windows.Forms.Button();
            this.btnPeriodo = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnSubirCalificaciones = new System.Windows.Forms.Button();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComboBoxAsigDispon = new System.Windows.Forms.ComboBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblCalificación = new System.Windows.Forms.Label();
            this.txtCalificación = new System.Windows.Forms.TextBox();
            this.ID_CALIFICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CLASE_PLAN_ESTUDIOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLASE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERIODO_CLASE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CALIFICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrdVwCalificaciones)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIndice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblIndice.Location = new System.Drawing.Point(12, 218);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(283, 24);
            this.lblIndice.TabIndex = 15;
            this.lblIndice.Text = "Promedio de Índice de Clases: 0";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.ForeColor = System.Drawing.Color.White;
            this.lblPeriodo.Location = new System.Drawing.Point(578, 36);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(90, 20);
            this.lblPeriodo.TabIndex = 18;
            this.lblPeriodo.Text = "Periodo: 0";
            // 
            // lblAño
            // 
            this.lblAño.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.ForeColor = System.Drawing.Color.White;
            this.lblAño.Location = new System.Drawing.Point(578, 12);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(91, 20);
            this.lblAño.TabIndex = 17;
            this.lblAño.Text = "Año: 1999";
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
            this.ID_CALIFICACION,
            this.ID_CLASE_PLAN_ESTUDIOS,
            this.CLASE,
            this.PERIODO_CLASE,
            this.CALIFICACION,
            this.OBS,
            this.DATE,
            this.ESTADO});
            this.DtGrdVwCalificaciones.Location = new System.Drawing.Point(12, 249);
            this.DtGrdVwCalificaciones.MultiSelect = false;
            this.DtGrdVwCalificaciones.Name = "DtGrdVwCalificaciones";
            this.DtGrdVwCalificaciones.ReadOnly = true;
            this.DtGrdVwCalificaciones.Size = new System.Drawing.Size(846, 216);
            this.DtGrdVwCalificaciones.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnEliminarCalificaciones);
            this.groupBox2.Controls.Add(this.btnPeriodo);
            this.groupBox2.Controls.Add(this.btnCerrar);
            this.groupBox2.Controls.Add(this.btnSubirCalificaciones);
            this.groupBox2.Location = new System.Drawing.Point(682, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 199);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // btnEliminarCalificaciones
            // 
            this.btnEliminarCalificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCalificaciones.ForeColor = System.Drawing.Color.Yellow;
            this.btnEliminarCalificaciones.Location = new System.Drawing.Point(6, 66);
            this.btnEliminarCalificaciones.Name = "btnEliminarCalificaciones";
            this.btnEliminarCalificaciones.Size = new System.Drawing.Size(164, 32);
            this.btnEliminarCalificaciones.TabIndex = 12;
            this.btnEliminarCalificaciones.Text = "SUPRIMIR CALIFICACIONES";
            this.btnEliminarCalificaciones.UseVisualStyleBackColor = true;
            this.btnEliminarCalificaciones.Click += new System.EventHandler(this.btnEliminarCalificaciones_Click);
            // 
            // btnPeriodo
            // 
            this.btnPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeriodo.ForeColor = System.Drawing.Color.Yellow;
            this.btnPeriodo.Location = new System.Drawing.Point(6, 113);
            this.btnPeriodo.Name = "btnPeriodo";
            this.btnPeriodo.Size = new System.Drawing.Size(164, 32);
            this.btnPeriodo.TabIndex = 11;
            this.btnPeriodo.Text = "CAMBIAR PERIODO";
            this.btnPeriodo.UseVisualStyleBackColor = true;
            this.btnPeriodo.Click += new System.EventHandler(this.btnPeriodo_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.Yellow;
            this.btnCerrar.Location = new System.Drawing.Point(6, 160);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(164, 32);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnSubirCalificaciones
            // 
            this.btnSubirCalificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirCalificaciones.ForeColor = System.Drawing.Color.Yellow;
            this.btnSubirCalificaciones.Location = new System.Drawing.Point(6, 19);
            this.btnSubirCalificaciones.Name = "btnSubirCalificaciones";
            this.btnSubirCalificaciones.Size = new System.Drawing.Size(164, 32);
            this.btnSubirCalificaciones.TabIndex = 9;
            this.btnSubirCalificaciones.Text = "SUBIR CALIFICACIONES";
            this.btnSubirCalificaciones.UseVisualStyleBackColor = true;
            this.btnSubirCalificaciones.Click += new System.EventHandler(this.btnSubirCalificaciones_Click);
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiante.ForeColor = System.Drawing.Color.White;
            this.lblEstudiante.Location = new System.Drawing.Point(13, 12);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(161, 42);
            this.lblEstudiante.TabIndex = 12;
            this.lblEstudiante.Text = "Estudiante:\r\nNúmero de Cuenta\r\n";
            this.lblEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ComboBoxAsigDispon);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.lblCalificación);
            this.groupBox1.Controls.Add(this.txtCalificación);
            this.groupBox1.Location = new System.Drawing.Point(13, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 154);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // ComboBoxAsigDispon
            // 
            this.ComboBoxAsigDispon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxAsigDispon.FormattingEnabled = true;
            this.ComboBoxAsigDispon.Location = new System.Drawing.Point(6, 19);
            this.ComboBoxAsigDispon.Name = "ComboBoxAsigDispon";
            this.ComboBoxAsigDispon.Size = new System.Drawing.Size(638, 21);
            this.ComboBoxAsigDispon.TabIndex = 0;
            this.ComboBoxAsigDispon.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAsigDispon_SelectedIndexChanged);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(6, 49);
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
            this.btnAgregar.Location = new System.Drawing.Point(477, 115);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(169, 32);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblCalificación
            // 
            this.lblCalificación.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCalificación.AutoSize = true;
            this.lblCalificación.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalificación.ForeColor = System.Drawing.Color.White;
            this.lblCalificación.Location = new System.Drawing.Point(6, 121);
            this.lblCalificación.Name = "lblCalificación";
            this.lblCalificación.Size = new System.Drawing.Size(106, 20);
            this.lblCalificación.TabIndex = 7;
            this.lblCalificación.Text = "Calificación:";
            // 
            // txtCalificación
            // 
            this.txtCalificación.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCalificación.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalificación.Location = new System.Drawing.Point(118, 115);
            this.txtCalificación.Multiline = true;
            this.txtCalificación.Name = "txtCalificación";
            this.txtCalificación.Size = new System.Drawing.Size(356, 32);
            this.txtCalificación.TabIndex = 6;
            this.txtCalificación.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalificación_KeyPress);
            // 
            // ID_CALIFICACION
            // 
            this.ID_CALIFICACION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_CALIFICACION.HeaderText = "ID_CALIFICACION";
            this.ID_CALIFICACION.Name = "ID_CALIFICACION";
            this.ID_CALIFICACION.ReadOnly = true;
            this.ID_CALIFICACION.Width = 121;
            // 
            // ID_CLASE_PLAN_ESTUDIOS
            // 
            this.ID_CLASE_PLAN_ESTUDIOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_CLASE_PLAN_ESTUDIOS.HeaderText = "ID_CLASE_PLAN_ESTUDIOS";
            this.ID_CLASE_PLAN_ESTUDIOS.Name = "ID_CLASE_PLAN_ESTUDIOS";
            this.ID_CLASE_PLAN_ESTUDIOS.ReadOnly = true;
            this.ID_CLASE_PLAN_ESTUDIOS.Width = 178;
            // 
            // CLASE
            // 
            this.CLASE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CLASE.HeaderText = "CLASE";
            this.CLASE.Name = "CLASE";
            this.CLASE.ReadOnly = true;
            this.CLASE.Width = 66;
            // 
            // PERIODO_CLASE
            // 
            this.PERIODO_CLASE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PERIODO_CLASE.HeaderText = "PERIODO";
            this.PERIODO_CLASE.Name = "PERIODO_CLASE";
            this.PERIODO_CLASE.ReadOnly = true;
            this.PERIODO_CLASE.Width = 81;
            // 
            // CALIFICACION
            // 
            this.CALIFICACION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CALIFICACION.HeaderText = "CALIFICACIÓN";
            this.CALIFICACION.Name = "CALIFICACION";
            this.CALIFICACION.ReadOnly = true;
            this.CALIFICACION.Width = 104;
            // 
            // OBS
            // 
            this.OBS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OBS.HeaderText = "OBSERVACION";
            this.OBS.Name = "OBS";
            this.OBS.ReadOnly = true;
            this.OBS.Width = 109;
            // 
            // DATE
            // 
            this.DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DATE.HeaderText = "FECHA";
            this.DATE.Name = "DATE";
            this.DATE.ReadOnly = true;
            this.DATE.Width = 67;
            // 
            // ESTADO
            // 
            this.ESTADO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            this.ESTADO.Width = 76;
            // 
            // frmAgregarClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(873, 488);
            this.Controls.Add(this.lblIndice);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.DtGrdVwCalificaciones);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblEstudiante);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgregarClases";
            this.Load += new System.EventHandler(this.frmAgregarClases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtGrdVwCalificaciones)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIndice;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.DataGridView DtGrdVwCalificaciones;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminarCalificaciones;
        private System.Windows.Forms.Button btnPeriodo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnSubirCalificaciones;
        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ComboBoxAsigDispon;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblCalificación;
        private System.Windows.Forms.TextBox txtCalificación;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CALIFICACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CLASE_PLAN_ESTUDIOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLASE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERIODO_CLASE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CALIFICACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
    }
}