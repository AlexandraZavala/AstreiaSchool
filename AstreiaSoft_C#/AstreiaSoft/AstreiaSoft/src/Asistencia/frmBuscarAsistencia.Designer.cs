namespace AstreiaSoft
{
    partial class frmBuscarAsistencia
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
            this.lblCurso = new System.Windows.Forms.Label();
            this.txtCursoID = new System.Windows.Forms.TextBox();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.btnBuscarEstudiantes = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscarEstudiante = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dgvAsistencias = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(44, 53);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(49, 17);
            this.lblCurso.TabIndex = 16;
            this.lblCurso.Text = "Curso:";
            // 
            // txtCursoID
            // 
            this.txtCursoID.Location = new System.Drawing.Point(212, 53);
            this.txtCursoID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCursoID.Name = "txtCursoID";
            this.txtCursoID.ReadOnly = true;
            this.txtCursoID.Size = new System.Drawing.Size(68, 22);
            this.txtCursoID.TabIndex = 17;
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(289, 53);
            this.txtNombreCurso.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.ReadOnly = true;
            this.txtNombreCurso.Size = new System.Drawing.Size(160, 22);
            this.txtNombreCurso.TabIndex = 18;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(44, 101);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(59, 17);
            this.lblHorario.TabIndex = 19;
            this.lblHorario.Text = "Horario:";
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(213, 101);
            this.txtHorario.Margin = new System.Windows.Forms.Padding(4);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.ReadOnly = true;
            this.txtHorario.Size = new System.Drawing.Size(157, 22);
            this.txtHorario.TabIndex = 20;
            // 
            // btnBuscarEstudiantes
            // 
            this.btnBuscarEstudiantes.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarEstudiantes.FlatAppearance.BorderSize = 0;
            this.btnBuscarEstudiantes.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEstudiantes.Image = global::AstreiaSoft.Properties.Resources.img_buscar_17;
            this.btnBuscarEstudiantes.Location = new System.Drawing.Point(390, 142);
            this.btnBuscarEstudiantes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarEstudiantes.Name = "btnBuscarEstudiantes";
            this.btnBuscarEstudiantes.Size = new System.Drawing.Size(213, 30);
            this.btnBuscarEstudiantes.TabIndex = 49;
            this.btnBuscarEstudiantes.Text = "Buscar estudiante";
            this.btnBuscarEstudiantes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarEstudiantes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarEstudiantes.UseVisualStyleBackColor = false;
            this.btnBuscarEstudiantes.Click += new System.EventHandler(this.btnBuscarEstudiantes_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(210, 148);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(160, 22);
            this.txtBuscar.TabIndex = 47;
            // 
            // lblBuscarEstudiante
            // 
            this.lblBuscarEstudiante.AutoSize = true;
            this.lblBuscarEstudiante.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarEstudiante.Location = new System.Drawing.Point(47, 151);
            this.lblBuscarEstudiante.Name = "lblBuscarEstudiante";
            this.lblBuscarEstudiante.Size = new System.Drawing.Size(121, 17);
            this.lblBuscarEstudiante.TabIndex = 48;
            this.lblBuscarEstudiante.Text = "Buscar estudiante";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::AstreiaSoft.Properties.Resources.img_buscar_17;
            this.btnBuscar.Location = new System.Drawing.Point(635, 53);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(205, 39);
            this.btnBuscar.TabIndex = 51;
            this.btnBuscar.Text = "Buscar asistencias";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Image = global::AstreiaSoft.Properties.Resources.img_seleccionar_17;
            this.btnSeleccionar.Location = new System.Drawing.Point(855, 53);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(140, 39);
            this.btnSeleccionar.TabIndex = 50;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // dgvAsistencias
            // 
            this.dgvAsistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Estudiante,
            this.Fecha,
            this.Estado});
            this.dgvAsistencias.Location = new System.Drawing.Point(47, 201);
            this.dgvAsistencias.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAsistencias.Name = "dgvAsistencias";
            this.dgvAsistencias.RowHeadersWidth = 51;
            this.dgvAsistencias.Size = new System.Drawing.Size(948, 326);
            this.dgvAsistencias.TabIndex = 52;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID Asistencia";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Estudiante
            // 
            this.Estudiante.HeaderText = "Estudiante";
            this.Estudiante.MinimumWidth = 6;
            this.Estudiante.Name = "Estudiante";
            this.Estudiante.Width = 125;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Width = 125;
            // 
            // frmBuscarAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgvAsistencias);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnBuscarEstudiantes);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscarEstudiante);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.txtCursoID);
            this.Controls.Add(this.txtNombreCurso);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.txtHorario);
            this.Name = "frmBuscarAsistencia";
            this.Text = "frmBuscarAsistencia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.TextBox txtCursoID;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.Button btnBuscarEstudiantes;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscarEstudiante;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView dgvAsistencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}