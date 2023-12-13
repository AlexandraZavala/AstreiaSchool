namespace AstreiaSoft
{
    partial class frmVisualizarHijos
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
            this.lblTituloHijos = new System.Windows.Forms.Label();
            this.panelMisHijos = new System.Windows.Forms.Panel();
            this.lblHijos = new System.Windows.Forms.Label();
            this.cmbHijos = new System.Windows.Forms.ComboBox();
            this.dgvHijo = new System.Windows.Forms.Panel();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnCalificaciones = new System.Windows.Forms.Button();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.txtGradoSeccion = new System.Windows.Forms.TextBox();
            this.lblGradoSeccion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombreHijo = new System.Windows.Forms.Label();
            this.panelMisHijos.SuspendLayout();
            this.dgvHijo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloHijos
            // 
            this.lblTituloHijos.AutoSize = true;
            this.lblTituloHijos.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloHijos.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTituloHijos.Location = new System.Drawing.Point(20, 16);
            this.lblTituloHijos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloHijos.Name = "lblTituloHijos";
            this.lblTituloHijos.Size = new System.Drawing.Size(147, 37);
            this.lblTituloHijos.TabIndex = 1;
            this.lblTituloHijos.Text = "Mis Hijos:";
            // 
            // panelMisHijos
            // 
            this.panelMisHijos.Controls.Add(this.lblHijos);
            this.panelMisHijos.Controls.Add(this.cmbHijos);
            this.panelMisHijos.Controls.Add(this.dgvHijo);
            this.panelMisHijos.Controls.Add(this.lblTituloHijos);
            this.panelMisHijos.Location = new System.Drawing.Point(16, 12);
            this.panelMisHijos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMisHijos.Name = "panelMisHijos";
            this.panelMisHijos.Size = new System.Drawing.Size(1031, 551);
            this.panelMisHijos.TabIndex = 2;
            // 
            // lblHijos
            // 
            this.lblHijos.AutoSize = true;
            this.lblHijos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHijos.Location = new System.Drawing.Point(25, 65);
            this.lblHijos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHijos.Name = "lblHijos";
            this.lblHijos.Size = new System.Drawing.Size(273, 19);
            this.lblHijos.TabIndex = 4;
            this.lblHijos.Text = "Seleccione el hijo que desea visualizar";
            // 
            // cmbHijos
            // 
            this.cmbHijos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHijos.FormattingEnabled = true;
            this.cmbHijos.Location = new System.Drawing.Point(329, 62);
            this.cmbHijos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbHijos.Name = "cmbHijos";
            this.cmbHijos.Size = new System.Drawing.Size(305, 27);
            this.cmbHijos.TabIndex = 3;
            this.cmbHijos.SelectedIndexChanged += new System.EventHandler(this.cmbHijos_SelectedIndexChanged);
            // 
            // dgvHijo
            // 
            this.dgvHijo.Controls.Add(this.btnReporte);
            this.dgvHijo.Controls.Add(this.btnAsistencia);
            this.dgvHijo.Controls.Add(this.btnCalificaciones);
            this.dgvHijo.Controls.Add(this.panelContenido);
            this.dgvHijo.Controls.Add(this.txtGradoSeccion);
            this.dgvHijo.Controls.Add(this.lblGradoSeccion);
            this.dgvHijo.Controls.Add(this.txtNombre);
            this.dgvHijo.Controls.Add(this.lblNombreHijo);
            this.dgvHijo.Location = new System.Drawing.Point(16, 103);
            this.dgvHijo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvHijo.Name = "dgvHijo";
            this.dgvHijo.Size = new System.Drawing.Size(996, 441);
            this.dgvHijo.TabIndex = 2;
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.LightBlue;
            this.btnReporte.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Location = new System.Drawing.Point(755, 96);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(204, 52);
            this.btnReporte.TabIndex = 58;
            this.btnReporte.Text = "Descargar Reporte de Notas";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistencia.Location = new System.Drawing.Point(529, 103);
            this.btnAsistencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(204, 37);
            this.btnAsistencia.TabIndex = 57;
            this.btnAsistencia.Text = "Asistencia";
            this.btnAsistencia.UseVisualStyleBackColor = true;
            this.btnAsistencia.Visible = false;
            this.btnAsistencia.Click += new System.EventHandler(this.btnAsistencia_Click);
            // 
            // btnCalificaciones
            // 
            this.btnCalificaciones.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalificaciones.Location = new System.Drawing.Point(301, 103);
            this.btnCalificaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalificaciones.Name = "btnCalificaciones";
            this.btnCalificaciones.Size = new System.Drawing.Size(204, 37);
            this.btnCalificaciones.TabIndex = 56;
            this.btnCalificaciones.Text = "Calificaciones";
            this.btnCalificaciones.UseVisualStyleBackColor = true;
            this.btnCalificaciones.Visible = false;
            this.btnCalificaciones.Click += new System.EventHandler(this.btnCalificaciones_Click);
            // 
            // panelContenido
            // 
            this.panelContenido.AutoScroll = true;
            this.panelContenido.Location = new System.Drawing.Point(33, 164);
            this.panelContenido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(937, 273);
            this.panelContenido.TabIndex = 55;
            this.panelContenido.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenido_Paint);
            // 
            // txtGradoSeccion
            // 
            this.txtGradoSeccion.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGradoSeccion.Location = new System.Drawing.Point(177, 57);
            this.txtGradoSeccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGradoSeccion.Name = "txtGradoSeccion";
            this.txtGradoSeccion.ReadOnly = true;
            this.txtGradoSeccion.Size = new System.Drawing.Size(295, 23);
            this.txtGradoSeccion.TabIndex = 54;
            // 
            // lblGradoSeccion
            // 
            this.lblGradoSeccion.AutoSize = true;
            this.lblGradoSeccion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradoSeccion.Location = new System.Drawing.Point(29, 62);
            this.lblGradoSeccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGradoSeccion.Name = "lblGradoSeccion";
            this.lblGradoSeccion.Size = new System.Drawing.Size(129, 19);
            this.lblGradoSeccion.TabIndex = 53;
            this.lblGradoSeccion.Text = "Grado y Sección:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(177, 20);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(295, 23);
            this.txtNombre.TabIndex = 52;
            // 
            // lblNombreHijo
            // 
            this.lblNombreHijo.AutoSize = true;
            this.lblNombreHijo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreHijo.Location = new System.Drawing.Point(29, 22);
            this.lblNombreHijo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreHijo.Name = "lblNombreHijo";
            this.lblNombreHijo.Size = new System.Drawing.Size(140, 19);
            this.lblNombreHijo.TabIndex = 51;
            this.lblNombreHijo.Text = "Nombre y Apellido:";
            // 
            // frmVisualizarHijos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 578);
            this.Controls.Add(this.panelMisHijos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmVisualizarHijos";
            this.Text = "frmVisualizarHijos";
            this.panelMisHijos.ResumeLayout(false);
            this.panelMisHijos.PerformLayout();
            this.dgvHijo.ResumeLayout(false);
            this.dgvHijo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTituloHijos;
        private System.Windows.Forms.Panel panelMisHijos;
        private System.Windows.Forms.Label lblHijos;
        private System.Windows.Forms.ComboBox cmbHijos;
        private System.Windows.Forms.Panel dgvHijo;
        private System.Windows.Forms.TextBox txtGradoSeccion;
        private System.Windows.Forms.Label lblGradoSeccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombreHijo;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Button btnCalificaciones;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Button btnReporte;
    }
}