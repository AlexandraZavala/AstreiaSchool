namespace AstreiaSoft
{
    partial class frmReclamoAlumno
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gboReclamo = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtArgumentacion = new System.Windows.Forms.TextBox();
            this.dtpFechaReclamo = new System.Windows.Forms.DateTimePicker();
            this.lblFechaReclamo = new System.Windows.Forms.Label();
            this.lblArgumentacion = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDNI = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gboRespuesta = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtRespuestaReclamo = new System.Windows.Forms.TextBox();
            this.dtpFechaRespuesta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaRespuesta = new System.Windows.Forms.Label();
            this.lblRespuestaReclamo = new System.Windows.Forms.Label();
            this.lblEstadoReclamo = new System.Windows.Forms.Label();
            this.cboEstadoReclamo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.gboReclamo.SuspendLayout();
            this.gboRespuesta.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gboReclamo);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.lblDNI);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 314);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reclamo de Evaluación";
            // 
            // gboReclamo
            // 
            this.gboReclamo.Controls.Add(this.btnGuardar);
            this.gboReclamo.Controls.Add(this.txtArgumentacion);
            this.gboReclamo.Controls.Add(this.dtpFechaReclamo);
            this.gboReclamo.Controls.Add(this.lblFechaReclamo);
            this.gboReclamo.Controls.Add(this.lblArgumentacion);
            this.gboReclamo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboReclamo.Location = new System.Drawing.Point(0, 0);
            this.gboReclamo.Name = "gboReclamo";
            this.gboReclamo.Size = new System.Drawing.Size(302, 314);
            this.gboReclamo.TabIndex = 63;
            this.gboReclamo.TabStop = false;
            this.gboReclamo.Text = "Reclamo de Evaluación";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::AstreiaSoft.Properties.Resources.img_guardar_17;
            this.btnGuardar.Location = new System.Drawing.Point(100, 253);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 32);
            this.btnGuardar.TabIndex = 71;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnEnviarReclamo_Click);
            // 
            // txtArgumentacion
            // 
            this.txtArgumentacion.Location = new System.Drawing.Point(16, 144);
            this.txtArgumentacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtArgumentacion.Multiline = true;
            this.txtArgumentacion.Name = "txtArgumentacion";
            this.txtArgumentacion.Size = new System.Drawing.Size(265, 76);
            this.txtArgumentacion.TabIndex = 68;
            // 
            // dtpFechaReclamo
            // 
            this.dtpFechaReclamo.Location = new System.Drawing.Point(16, 70);
            this.dtpFechaReclamo.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaReclamo.Name = "dtpFechaReclamo";
            this.dtpFechaReclamo.Size = new System.Drawing.Size(264, 24);
            this.dtpFechaReclamo.TabIndex = 63;
            // 
            // lblFechaReclamo
            // 
            this.lblFechaReclamo.AutoSize = true;
            this.lblFechaReclamo.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblFechaReclamo.Location = new System.Drawing.Point(13, 38);
            this.lblFechaReclamo.Name = "lblFechaReclamo";
            this.lblFechaReclamo.Size = new System.Drawing.Size(128, 20);
            this.lblFechaReclamo.TabIndex = 59;
            this.lblFechaReclamo.Text = "Fecha Reclamo:";
            // 
            // lblArgumentacion
            // 
            this.lblArgumentacion.AutoSize = true;
            this.lblArgumentacion.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblArgumentacion.Location = new System.Drawing.Point(14, 114);
            this.lblArgumentacion.Name = "lblArgumentacion";
            this.lblArgumentacion.Size = new System.Drawing.Size(127, 20);
            this.lblArgumentacion.TabIndex = 60;
            this.lblArgumentacion.Text = "Argumentación:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(69, 248);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 38);
            this.button2.TabIndex = 67;
            this.button2.Text = "Enviar Reclamo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 144);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 76);
            this.textBox1.TabIndex = 68;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 70);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(264, 24);
            this.dateTimePicker1.TabIndex = 63;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblDNI.Location = new System.Drawing.Point(13, 38);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(128, 20);
            this.lblDNI.TabIndex = 59;
            this.lblDNI.Text = "Fecha Reclamo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label2.Location = new System.Drawing.Point(14, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Argumentación:";
            // 
            // gboRespuesta
            // 
            this.gboRespuesta.Controls.Add(this.button1);
            this.gboRespuesta.Controls.Add(this.txtRespuestaReclamo);
            this.gboRespuesta.Controls.Add(this.dtpFechaRespuesta);
            this.gboRespuesta.Controls.Add(this.lblFechaRespuesta);
            this.gboRespuesta.Controls.Add(this.lblRespuestaReclamo);
            this.gboRespuesta.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboRespuesta.Location = new System.Drawing.Point(343, 44);
            this.gboRespuesta.Name = "gboRespuesta";
            this.gboRespuesta.Size = new System.Drawing.Size(302, 314);
            this.gboRespuesta.TabIndex = 69;
            this.gboRespuesta.TabStop = false;
            this.gboRespuesta.Text = "Respuesta de reclamo";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::AstreiaSoft.Properties.Resources.img_guardar_17;
            this.button1.Location = new System.Drawing.Point(95, 253);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 32);
            this.button1.TabIndex = 69;
            this.button1.Text = "Guardar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnGuardarRespuesta_Click);
            // 
            // txtRespuestaReclamo
            // 
            this.txtRespuestaReclamo.Location = new System.Drawing.Point(16, 144);
            this.txtRespuestaReclamo.Margin = new System.Windows.Forms.Padding(2);
            this.txtRespuestaReclamo.Multiline = true;
            this.txtRespuestaReclamo.Name = "txtRespuestaReclamo";
            this.txtRespuestaReclamo.Size = new System.Drawing.Size(265, 76);
            this.txtRespuestaReclamo.TabIndex = 68;
            // 
            // dtpFechaRespuesta
            // 
            this.dtpFechaRespuesta.Location = new System.Drawing.Point(16, 70);
            this.dtpFechaRespuesta.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaRespuesta.Name = "dtpFechaRespuesta";
            this.dtpFechaRespuesta.Size = new System.Drawing.Size(264, 24);
            this.dtpFechaRespuesta.TabIndex = 63;
            // 
            // lblFechaRespuesta
            // 
            this.lblFechaRespuesta.AutoSize = true;
            this.lblFechaRespuesta.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblFechaRespuesta.Location = new System.Drawing.Point(13, 38);
            this.lblFechaRespuesta.Name = "lblFechaRespuesta";
            this.lblFechaRespuesta.Size = new System.Drawing.Size(158, 20);
            this.lblFechaRespuesta.TabIndex = 59;
            this.lblFechaRespuesta.Text = "Fecha de respuesta:";
            // 
            // lblRespuestaReclamo
            // 
            this.lblRespuestaReclamo.AutoSize = true;
            this.lblRespuestaReclamo.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblRespuestaReclamo.Location = new System.Drawing.Point(14, 114);
            this.lblRespuestaReclamo.Name = "lblRespuestaReclamo";
            this.lblRespuestaReclamo.Size = new System.Drawing.Size(177, 20);
            this.lblRespuestaReclamo.TabIndex = 60;
            this.lblRespuestaReclamo.Text = "Respuesta de reclamo:";
            // 
            // lblEstadoReclamo
            // 
            this.lblEstadoReclamo.AutoSize = true;
            this.lblEstadoReclamo.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblEstadoReclamo.Location = new System.Drawing.Point(182, 376);
            this.lblEstadoReclamo.Name = "lblEstadoReclamo";
            this.lblEstadoReclamo.Size = new System.Drawing.Size(127, 20);
            this.lblEstadoReclamo.TabIndex = 69;
            this.lblEstadoReclamo.Text = "Estado reclamo:";
            // 
            // cboEstadoReclamo
            // 
            this.cboEstadoReclamo.FormattingEnabled = true;
            this.cboEstadoReclamo.Location = new System.Drawing.Point(343, 377);
            this.cboEstadoReclamo.Margin = new System.Windows.Forms.Padding(2);
            this.cboEstadoReclamo.Name = "cboEstadoReclamo";
            this.cboEstadoReclamo.Size = new System.Drawing.Size(134, 21);
            this.cboEstadoReclamo.TabIndex = 70;
            this.cboEstadoReclamo.SelectedIndexChanged += new System.EventHandler(this.cboEstadoReclamo_SelectedIndexChanged);
            // 
            // frmReclamoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 435);
            this.Controls.Add(this.cboEstadoReclamo);
            this.Controls.Add(this.lblEstadoReclamo);
            this.Controls.Add(this.gboRespuesta);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmReclamoAlumno";
            this.Text = "frmReclamoAlumno";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gboReclamo.ResumeLayout(false);
            this.gboReclamo.PerformLayout();
            this.gboRespuesta.ResumeLayout(false);
            this.gboRespuesta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gboReclamo;
        private System.Windows.Forms.TextBox txtArgumentacion;
        private System.Windows.Forms.DateTimePicker dtpFechaReclamo;
        private System.Windows.Forms.Label lblFechaReclamo;
        private System.Windows.Forms.Label lblArgumentacion;
        private System.Windows.Forms.GroupBox gboRespuesta;
        private System.Windows.Forms.TextBox txtRespuestaReclamo;
        private System.Windows.Forms.DateTimePicker dtpFechaRespuesta;
        private System.Windows.Forms.Label lblFechaRespuesta;
        private System.Windows.Forms.Label lblRespuestaReclamo;
        private System.Windows.Forms.Label lblEstadoReclamo;
        private System.Windows.Forms.ComboBox cboEstadoReclamo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button1;
    }
}