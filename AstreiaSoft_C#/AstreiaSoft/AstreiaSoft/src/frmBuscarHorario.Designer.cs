namespace AstreiaSoft
{
    partial class frmBuscarHorario
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
            this.button6 = new System.Windows.Forms.Button();
            this.cboNivelEducativo = new System.Windows.Forms.ComboBox();
            this.lblNivelEducativo = new System.Windows.Forms.Label();
            this.txtDocenteHorario = new System.Windows.Forms.TextBox();
            this.cboCursoProgHora = new System.Windows.Forms.ComboBox();
            this.lblGrado = new System.Windows.Forms.Label();
            this.lblDocente = new System.Windows.Forms.Label();
            this.cboGrado = new System.Windows.Forms.ComboBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.cboSeccion = new System.Windows.Forms.ComboBox();
            this.lblSeccion = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvBuscarHorario = new System.Windows.Forms.DataGridView();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Docente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaSemana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarHorario)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(656, 209);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(41, 30);
            this.button6.TabIndex = 31;
            this.button6.Text = "...";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // cboNivelEducativo
            // 
            this.cboNivelEducativo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNivelEducativo.FormattingEnabled = true;
            this.cboNivelEducativo.Location = new System.Drawing.Point(207, 75);
            this.cboNivelEducativo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboNivelEducativo.Name = "cboNivelEducativo";
            this.cboNivelEducativo.Size = new System.Drawing.Size(220, 27);
            this.cboNivelEducativo.TabIndex = 30;
            // 
            // lblNivelEducativo
            // 
            this.lblNivelEducativo.AutoSize = true;
            this.lblNivelEducativo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelEducativo.Location = new System.Drawing.Point(56, 80);
            this.lblNivelEducativo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNivelEducativo.Name = "lblNivelEducativo";
            this.lblNivelEducativo.Size = new System.Drawing.Size(121, 19);
            this.lblNivelEducativo.TabIndex = 29;
            this.lblNivelEducativo.Text = "Nivel Educativo:";
            // 
            // txtDocenteHorario
            // 
            this.txtDocenteHorario.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocenteHorario.Location = new System.Drawing.Point(207, 212);
            this.txtDocenteHorario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDocenteHorario.Name = "txtDocenteHorario";
            this.txtDocenteHorario.Size = new System.Drawing.Size(440, 24);
            this.txtDocenteHorario.TabIndex = 24;
            // 
            // cboCursoProgHora
            // 
            this.cboCursoProgHora.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCursoProgHora.FormattingEnabled = true;
            this.cboCursoProgHora.Location = new System.Drawing.Point(207, 166);
            this.cboCursoProgHora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCursoProgHora.Name = "cboCursoProgHora";
            this.cboCursoProgHora.Size = new System.Drawing.Size(489, 27);
            this.cboCursoProgHora.TabIndex = 23;
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrado.Location = new System.Drawing.Point(56, 124);
            this.lblGrado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(58, 19);
            this.lblGrado.TabIndex = 27;
            this.lblGrado.Text = "Grado:";
            // 
            // lblDocente
            // 
            this.lblDocente.AutoSize = true;
            this.lblDocente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocente.Location = new System.Drawing.Point(56, 215);
            this.lblDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(73, 19);
            this.lblDocente.TabIndex = 22;
            this.lblDocente.Text = "Docente:";
            // 
            // cboGrado
            // 
            this.cboGrado.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGrado.FormattingEnabled = true;
            this.cboGrado.Location = new System.Drawing.Point(207, 121);
            this.cboGrado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboGrado.Name = "cboGrado";
            this.cboGrado.Size = new System.Drawing.Size(220, 27);
            this.cboGrado.TabIndex = 28;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(59, 166);
            this.lblCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(51, 19);
            this.lblCurso.TabIndex = 21;
            this.lblCurso.Text = "Curso:";
            // 
            // cboSeccion
            // 
            this.cboSeccion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSeccion.FormattingEnabled = true;
            this.cboSeccion.Location = new System.Drawing.Point(535, 121);
            this.cboSeccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboSeccion.Name = "cboSeccion";
            this.cboSeccion.Size = new System.Drawing.Size(161, 27);
            this.cboSeccion.TabIndex = 26;
            // 
            // lblSeccion
            // 
            this.lblSeccion.AutoSize = true;
            this.lblSeccion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeccion.Location = new System.Drawing.Point(455, 124);
            this.lblSeccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(68, 19);
            this.lblSeccion.TabIndex = 25;
            this.lblSeccion.Text = "Sección:";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Image = global::AstreiaSoft.Properties.Resources.img_seleccionar_17;
            this.btnSeleccionar.Location = new System.Drawing.Point(853, 21);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(140, 39);
            this.btnSeleccionar.TabIndex = 33;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::AstreiaSoft.Properties.Resources.img_buscar_17;
            this.btnBuscar.Location = new System.Drawing.Point(707, 21);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(140, 39);
            this.btnBuscar.TabIndex = 34;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dgvBuscarHorario
            // 
            this.dgvBuscarHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarHorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Curso,
            this.Docente,
            this.Seccion,
            this.DiaSemana,
            this.HoraInicio,
            this.HoraFin});
            this.dgvBuscarHorario.Location = new System.Drawing.Point(60, 287);
            this.dgvBuscarHorario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBuscarHorario.Name = "dgvBuscarHorario";
            this.dgvBuscarHorario.RowHeadersWidth = 51;
            this.dgvBuscarHorario.Size = new System.Drawing.Size(948, 185);
            this.dgvBuscarHorario.TabIndex = 35;
            // 
            // Curso
            // 
            this.Curso.HeaderText = "Curso";
            this.Curso.MinimumWidth = 6;
            this.Curso.Name = "Curso";
            this.Curso.Width = 125;
            // 
            // Docente
            // 
            this.Docente.HeaderText = "Docente";
            this.Docente.MinimumWidth = 6;
            this.Docente.Name = "Docente";
            this.Docente.Width = 125;
            // 
            // Seccion
            // 
            this.Seccion.HeaderText = "Seccion";
            this.Seccion.MinimumWidth = 6;
            this.Seccion.Name = "Seccion";
            this.Seccion.Width = 125;
            // 
            // DiaSemana
            // 
            this.DiaSemana.HeaderText = "Día Semana";
            this.DiaSemana.MinimumWidth = 6;
            this.DiaSemana.Name = "DiaSemana";
            this.DiaSemana.Width = 125;
            // 
            // HoraInicio
            // 
            this.HoraInicio.HeaderText = "Hora Inicio";
            this.HoraInicio.MinimumWidth = 6;
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.Width = 125;
            // 
            // HoraFin
            // 
            this.HoraFin.HeaderText = "Hora Fin";
            this.HoraFin.MinimumWidth = 6;
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.Width = 125;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.LightBlue;
            this.btnRegresar.Location = new System.Drawing.Point(60, 5);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(85, 71);
            this.btnRegresar.TabIndex = 36;
            this.btnRegresar.Text = "<-";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // frmBuscarHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dgvBuscarHorario);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.cboNivelEducativo);
            this.Controls.Add(this.lblNivelEducativo);
            this.Controls.Add(this.txtDocenteHorario);
            this.Controls.Add(this.cboCursoProgHora);
            this.Controls.Add(this.lblGrado);
            this.Controls.Add(this.lblDocente);
            this.Controls.Add(this.cboGrado);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.cboSeccion);
            this.Controls.Add(this.lblSeccion);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBuscarHorario";
            this.Text = "frmBuscarHorario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarHorario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox cboNivelEducativo;
        private System.Windows.Forms.Label lblNivelEducativo;
        private System.Windows.Forms.TextBox txtDocenteHorario;
        private System.Windows.Forms.ComboBox cboCursoProgHora;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.ComboBox cboGrado;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.ComboBox cboSeccion;
        private System.Windows.Forms.Label lblSeccion;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvBuscarHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Docente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaSemana;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.Button btnRegresar;
    }
}