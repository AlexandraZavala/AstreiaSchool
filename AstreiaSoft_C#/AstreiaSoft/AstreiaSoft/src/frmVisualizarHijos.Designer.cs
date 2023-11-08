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
            this.btnEstadoCuenta = new System.Windows.Forms.Button();
            this.btnHorario = new System.Windows.Forms.Button();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnCalificaciones = new System.Windows.Forms.Button();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.txtGradoSeccion = new System.Windows.Forms.TextBox();
            this.lblGradoSeccion = new System.Windows.Forms.Label();
            this.txtAp = new System.Windows.Forms.TextBox();
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
            this.panelMisHijos.Margin = new System.Windows.Forms.Padding(4);
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
            this.cmbHijos.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHijos.Name = "cmbHijos";
            this.cmbHijos.Size = new System.Drawing.Size(305, 27);
            this.cmbHijos.TabIndex = 3;
            // 
            // dgvHijo
            // 
            this.dgvHijo.Controls.Add(this.btnEstadoCuenta);
            this.dgvHijo.Controls.Add(this.btnHorario);
            this.dgvHijo.Controls.Add(this.btnAsistencia);
            this.dgvHijo.Controls.Add(this.btnCalificaciones);
            this.dgvHijo.Controls.Add(this.panelContenido);
            this.dgvHijo.Controls.Add(this.txtGradoSeccion);
            this.dgvHijo.Controls.Add(this.lblGradoSeccion);
            this.dgvHijo.Controls.Add(this.txtAp);
            this.dgvHijo.Controls.Add(this.lblNombreHijo);
            this.dgvHijo.Location = new System.Drawing.Point(16, 103);
            this.dgvHijo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHijo.Name = "dgvHijo";
            this.dgvHijo.Size = new System.Drawing.Size(996, 441);
            this.dgvHijo.TabIndex = 2;
            // 
            // btnEstadoCuenta
            // 
            this.btnEstadoCuenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadoCuenta.Location = new System.Drawing.Point(725, 103);
            this.btnEstadoCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnEstadoCuenta.Name = "btnEstadoCuenta";
            this.btnEstadoCuenta.Size = new System.Drawing.Size(204, 37);
            this.btnEstadoCuenta.TabIndex = 59;
            this.btnEstadoCuenta.Text = "Estado de Cuenta";
            this.btnEstadoCuenta.UseVisualStyleBackColor = true;
            // 
            // btnHorario
            // 
            this.btnHorario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorario.Location = new System.Drawing.Point(89, 103);
            this.btnHorario.Margin = new System.Windows.Forms.Padding(4);
            this.btnHorario.Name = "btnHorario";
            this.btnHorario.Size = new System.Drawing.Size(204, 37);
            this.btnHorario.TabIndex = 58;
            this.btnHorario.Text = "Horario";
            this.btnHorario.UseVisualStyleBackColor = true;
            this.btnHorario.Click += new System.EventHandler(this.btnHorario_Click);
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistencia.Location = new System.Drawing.Point(513, 103);
            this.btnAsistencia.Margin = new System.Windows.Forms.Padding(4);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(204, 37);
            this.btnAsistencia.TabIndex = 57;
            this.btnAsistencia.Text = "Asistencia";
            this.btnAsistencia.UseVisualStyleBackColor = true;
            // 
            // btnCalificaciones
            // 
            this.btnCalificaciones.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalificaciones.Location = new System.Drawing.Point(301, 103);
            this.btnCalificaciones.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalificaciones.Name = "btnCalificaciones";
            this.btnCalificaciones.Size = new System.Drawing.Size(204, 37);
            this.btnCalificaciones.TabIndex = 56;
            this.btnCalificaciones.Text = "Calificaciones";
            this.btnCalificaciones.UseVisualStyleBackColor = true;
            this.btnCalificaciones.Click += new System.EventHandler(this.btnCalificaciones_Click);
            // 
            // panelContenido
            // 
            this.panelContenido.AutoScroll = true;
            this.panelContenido.Location = new System.Drawing.Point(33, 148);
            this.panelContenido.Margin = new System.Windows.Forms.Padding(4);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(937, 289);
            this.panelContenido.TabIndex = 55;
            // 
            // txtGradoSeccion
            // 
            this.txtGradoSeccion.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGradoSeccion.Location = new System.Drawing.Point(177, 57);
            this.txtGradoSeccion.Margin = new System.Windows.Forms.Padding(4);
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
            // txtAp
            // 
            this.txtAp.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAp.Location = new System.Drawing.Point(177, 20);
            this.txtAp.Margin = new System.Windows.Forms.Padding(4);
            this.txtAp.Name = "txtAp";
            this.txtAp.ReadOnly = true;
            this.txtAp.Size = new System.Drawing.Size(295, 23);
            this.txtAp.TabIndex = 52;
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox txtAp;
        private System.Windows.Forms.Label lblNombreHijo;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Button btnCalificaciones;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Button btnEstadoCuenta;
        private System.Windows.Forms.Button btnHorario;
    }
}