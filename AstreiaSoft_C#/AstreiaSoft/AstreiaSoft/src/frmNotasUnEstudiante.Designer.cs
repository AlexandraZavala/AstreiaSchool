namespace AstreiaSoft
{
    partial class frmNotasUnEstudiante
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
            this.dgvNotasEstudiante = new System.Windows.Forms.DataGridView();
            this.lblNombreCurso = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.btnReclamo = new System.Windows.Forms.Button();
            this.IDEvaluacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEvaluacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotasEstudiante)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNotasEstudiante
            // 
            this.dgvNotasEstudiante.AllowUserToAddRows = false;
            this.dgvNotasEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotasEstudiante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDEvaluacion,
            this.FechaInicio,
            this.FechaFin,
            this.TipoEvaluacion});
            this.dgvNotasEstudiante.Location = new System.Drawing.Point(20, 69);
            this.dgvNotasEstudiante.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNotasEstudiante.Name = "dgvNotasEstudiante";
            this.dgvNotasEstudiante.RowHeadersWidth = 51;
            this.dgvNotasEstudiante.RowTemplate.Height = 24;
            this.dgvNotasEstudiante.Size = new System.Drawing.Size(524, 219);
            this.dgvNotasEstudiante.TabIndex = 70;
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.AutoSize = true;
            this.lblNombreCurso.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblNombreCurso.Location = new System.Drawing.Point(26, 23);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(55, 20);
            this.lblNombreCurso.TabIndex = 73;
            this.lblNombreCurso.Text = "Curso:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::AstreiaSoft.Properties.Resources.img_buscar_17;
            this.btnBuscar.Location = new System.Drawing.Point(324, 17);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 32);
            this.btnBuscar.TabIndex = 74;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(91, 24);
            this.txtNombreCurso.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.ReadOnly = true;
            this.txtNombreCurso.Size = new System.Drawing.Size(141, 20);
            this.txtNombreCurso.TabIndex = 75;
            // 
            // btnReclamo
            // 
            this.btnReclamo.Location = new System.Drawing.Point(439, 17);
            this.btnReclamo.Name = "btnReclamo";
            this.btnReclamo.Size = new System.Drawing.Size(105, 32);
            this.btnReclamo.TabIndex = 76;
            this.btnReclamo.Text = "Presentar reclamo";
            this.btnReclamo.UseVisualStyleBackColor = true;
            this.btnReclamo.Click += new System.EventHandler(this.button1_Click);
            // 
            // IDEvaluacion
            // 
            this.IDEvaluacion.HeaderText = "ID";
            this.IDEvaluacion.MinimumWidth = 6;
            this.IDEvaluacion.Name = "IDEvaluacion";
            this.IDEvaluacion.Width = 56;
            // 
            // FechaInicio
            // 
            this.FechaInicio.HeaderText = "Fecha";
            this.FechaInicio.MinimumWidth = 6;
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.Width = 78;
            // 
            // FechaFin
            // 
            this.FechaFin.HeaderText = "Nota Obtenida";
            this.FechaFin.MinimumWidth = 6;
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.Width = 115;
            // 
            // TipoEvaluacion
            // 
            this.TipoEvaluacion.HeaderText = "Detalle";
            this.TipoEvaluacion.MinimumWidth = 6;
            this.TipoEvaluacion.Name = "TipoEvaluacion";
            this.TipoEvaluacion.Width = 220;
            // 
            // frmNotasUnEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 301);
            this.Controls.Add(this.btnReclamo);
            this.Controls.Add(this.txtNombreCurso);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblNombreCurso);
            this.Controls.Add(this.dgvNotasEstudiante);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmNotasUnEstudiante";
            this.Text = "frmNotasUnEstudiante";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotasEstudiante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvNotasEstudiante;
        private System.Windows.Forms.Label lblNombreCurso;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.Button btnReclamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEvaluacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEvaluacion;
    }
}