namespace AstreiaSoft
{
    partial class frmVentanaMostrarCurso
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnGestionarNotas = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.btnTareasAlumno = new System.Windows.Forms.Button();
            this.btnGestionarMateriales = new System.Windows.Forms.Button();
            this.btnTareasDocente = new System.Windows.Forms.Button();
            this.btnTomarAsis = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnVerNotas = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Curso - Año";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(99, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 71);
            this.panel1.TabIndex = 1;
            // 
            // pnlControl
            // 
            this.pnlControl.AutoScroll = true;
            this.pnlControl.Location = new System.Drawing.Point(155, 94);
            this.pnlControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(880, 571);
            this.pnlControl.TabIndex = 0;
            // 
            // btnGestionarNotas
            // 
            this.btnGestionarNotas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarNotas.Location = new System.Drawing.Point(4, 274);
            this.btnGestionarNotas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGestionarNotas.Name = "btnGestionarNotas";
            this.btnGestionarNotas.Size = new System.Drawing.Size(143, 52);
            this.btnGestionarNotas.TabIndex = 5;
            this.btnGestionarNotas.Text = "Gestionar Notas";
            this.btnGestionarNotas.UseVisualStyleBackColor = true;
            this.btnGestionarNotas.Visible = false;
            this.btnGestionarNotas.Click += new System.EventHandler(this.btnGestionarNotas_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.LightBlue;
            this.btnRegresar.Location = new System.Drawing.Point(4, 4);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(85, 71);
            this.btnRegresar.TabIndex = 6;
            this.btnRegresar.Text = "<-";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnMaterial
            // 
            this.btnMaterial.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterial.Location = new System.Drawing.Point(4, 94);
            this.btnMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(143, 52);
            this.btnMaterial.TabIndex = 7;
            this.btnMaterial.Text = "Materiales";
            this.btnMaterial.UseVisualStyleBackColor = true;
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            // 
            // btnTareasAlumno
            // 
            this.btnTareasAlumno.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnTareasAlumno.Location = new System.Drawing.Point(4, 335);
            this.btnTareasAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTareasAlumno.Name = "btnTareasAlumno";
            this.btnTareasAlumno.Size = new System.Drawing.Size(143, 81);
            this.btnTareasAlumno.TabIndex = 8;
            this.btnTareasAlumno.Text = "Ver Tareas como Alumno";
            this.btnTareasAlumno.UseVisualStyleBackColor = true;
            this.btnTareasAlumno.Visible = false;
            this.btnTareasAlumno.Click += new System.EventHandler(this.btnTareas_Click);
            // 
            // btnGestionarMateriales
            // 
            this.btnGestionarMateriales.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarMateriales.Location = new System.Drawing.Point(4, 158);
            this.btnGestionarMateriales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGestionarMateriales.Name = "btnGestionarMateriales";
            this.btnGestionarMateriales.Size = new System.Drawing.Size(143, 52);
            this.btnGestionarMateriales.TabIndex = 9;
            this.btnGestionarMateriales.Text = "Gestionar Materiales";
            this.btnGestionarMateriales.UseVisualStyleBackColor = true;
            this.btnGestionarMateriales.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTareasDocente
            // 
            this.btnTareasDocente.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnTareasDocente.Location = new System.Drawing.Point(4, 423);
            this.btnTareasDocente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTareasDocente.Name = "btnTareasDocente";
            this.btnTareasDocente.Size = new System.Drawing.Size(143, 82);
            this.btnTareasDocente.TabIndex = 10;
            this.btnTareasDocente.Text = "Ver Tareas como Docente";
            this.btnTareasDocente.UseVisualStyleBackColor = true;
            this.btnTareasDocente.Visible = false;
            this.btnTareasDocente.Click += new System.EventHandler(this.btnTareasDocente_Click);
            // 
            // btnTomarAsis
            // 
            this.btnTomarAsis.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnTomarAsis.Location = new System.Drawing.Point(4, 514);
            this.btnTomarAsis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTomarAsis.Name = "btnTomarAsis";
            this.btnTomarAsis.Size = new System.Drawing.Size(143, 71);
            this.btnTomarAsis.TabIndex = 12;
            this.btnTomarAsis.Text = "Tomar Asistencia";
            this.btnTomarAsis.UseVisualStyleBackColor = true;
            this.btnTomarAsis.Click += new System.EventHandler(this.btnTomarAsis_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnReporte.Location = new System.Drawing.Point(4, 594);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(143, 71);
            this.btnReporte.TabIndex = 13;
            this.btnReporte.Text = "Reporte de Notas";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // pnlBotones
            // 
            this.pnlBotones.AutoScroll = true;
            this.pnlBotones.Controls.Add(this.btnVerNotas);
            this.pnlBotones.Location = new System.Drawing.Point(4, 94);
            this.pnlBotones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(144, 571);
            this.pnlBotones.TabIndex = 14;
            // 
            // btnVerNotas
            // 
            this.btnVerNotas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerNotas.Location = new System.Drawing.Point(0, 123);
            this.btnVerNotas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerNotas.Name = "btnVerNotas";
            this.btnVerNotas.Size = new System.Drawing.Size(143, 52);
            this.btnVerNotas.TabIndex = 15;
            this.btnVerNotas.Text = "Ver Notas";
            this.btnVerNotas.UseVisualStyleBackColor = true;
            this.btnVerNotas.Click += new System.EventHandler(this.btnVerNotas_Click);
            // 
            // frmVentanaMostrarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 716);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnTomarAsis);
            this.Controls.Add(this.btnTareasDocente);
            this.Controls.Add(this.btnGestionarMateriales);
            this.Controls.Add(this.btnTareasAlumno);
            this.Controls.Add(this.btnMaterial);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGestionarNotas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBotones);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmVentanaMostrarCurso";
            this.Text = "frmVentanaMostrarCurso";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGestionarNotas;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.Button btnTareasAlumno;
        private System.Windows.Forms.Button btnGestionarMateriales;
        private System.Windows.Forms.Button btnTareasDocente;
        private System.Windows.Forms.Button btnTomarAsis;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnVerNotas;
    }
}