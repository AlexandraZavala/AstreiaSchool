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
            this.groupBox1.Location = new System.Drawing.Point(27, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(403, 387);
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
            this.gboReclamo.Margin = new System.Windows.Forms.Padding(4);
            this.gboReclamo.Name = "gboReclamo";
            this.gboReclamo.Padding = new System.Windows.Forms.Padding(4);
            this.gboReclamo.Size = new System.Drawing.Size(403, 387);
            this.gboReclamo.TabIndex = 63;
            this.gboReclamo.TabStop = false;
            this.gboReclamo.Text = "Reclamo de Evaluación";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::AstreiaSoft.Properties.Resources.img_guardar_17;
            this.btnGuardar.Location = new System.Drawing.Point(134, 311);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 39);
            this.btnGuardar.TabIndex = 71;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnEnviarReclamo_Click);
            // 
            // txtArgumentacion
            // 
            this.txtArgumentacion.Location = new System.Drawing.Point(21, 177);
            this.txtArgumentacion.Multiline = true;
            this.txtArgumentacion.Name = "txtArgumentacion";
            this.txtArgumentacion.Size = new System.Drawing.Size(352, 92);
            this.txtArgumentacion.TabIndex = 68;
            // 
            // dtpFechaReclamo
            // 
            this.dtpFechaReclamo.Location = new System.Drawing.Point(22, 86);
            this.dtpFechaReclamo.Name = "dtpFechaReclamo";
            this.dtpFechaReclamo.Size = new System.Drawing.Size(351, 28);
            this.dtpFechaReclamo.TabIndex = 63;
            // 
            // lblFechaReclamo
            // 
            this.lblFechaReclamo.AutoSize = true;
            this.lblFechaReclamo.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblFechaReclamo.Location = new System.Drawing.Point(17, 47);
            this.lblFechaReclamo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaReclamo.Name = "lblFechaReclamo";
            this.lblFechaReclamo.Size = new System.Drawing.Size(159, 22);
            this.lblFechaReclamo.TabIndex = 59;
            this.lblFechaReclamo.Text = "Fecha Reclamo:";
            // 
            // lblArgumentacion
            // 
            this.lblArgumentacion.AutoSize = true;
            this.lblArgumentacion.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblArgumentacion.Location = new System.Drawing.Point(18, 140);
            this.lblArgumentacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArgumentacion.Name = "lblArgumentacion";
            this.lblArgumentacion.Size = new System.Drawing.Size(161, 22);
            this.lblArgumentacion.TabIndex = 60;
            this.lblArgumentacion.Text = "Argumentación:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(92, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 47);
            this.button2.TabIndex = 67;
            this.button2.Text = "Enviar Reclamo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 177);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 92);
            this.textBox1.TabIndex = 68;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(22, 86);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(351, 28);
            this.dateTimePicker1.TabIndex = 63;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblDNI.Location = new System.Drawing.Point(17, 47);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(159, 22);
            this.lblDNI.TabIndex = 59;
            this.lblDNI.Text = "Fecha Reclamo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label2.Location = new System.Drawing.Point(18, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 22);
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
            this.gboRespuesta.Location = new System.Drawing.Point(457, 54);
            this.gboRespuesta.Margin = new System.Windows.Forms.Padding(4);
            this.gboRespuesta.Name = "gboRespuesta";
            this.gboRespuesta.Padding = new System.Windows.Forms.Padding(4);
            this.gboRespuesta.Size = new System.Drawing.Size(403, 387);
            this.gboRespuesta.TabIndex = 69;
            this.gboRespuesta.TabStop = false;
            this.gboRespuesta.Text = "Respuesta de reclamo";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::AstreiaSoft.Properties.Resources.img_guardar_17;
            this.button1.Location = new System.Drawing.Point(127, 311);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 39);
            this.button1.TabIndex = 69;
            this.button1.Text = "Guardar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnGuardarRespuesta_Click);
            // 
            // txtRespuestaReclamo
            // 
            this.txtRespuestaReclamo.Location = new System.Drawing.Point(21, 177);
            this.txtRespuestaReclamo.Multiline = true;
            this.txtRespuestaReclamo.Name = "txtRespuestaReclamo";
            this.txtRespuestaReclamo.Size = new System.Drawing.Size(352, 92);
            this.txtRespuestaReclamo.TabIndex = 68;
            // 
            // dtpFechaRespuesta
            // 
            this.dtpFechaRespuesta.Location = new System.Drawing.Point(22, 86);
            this.dtpFechaRespuesta.Name = "dtpFechaRespuesta";
            this.dtpFechaRespuesta.Size = new System.Drawing.Size(351, 28);
            this.dtpFechaRespuesta.TabIndex = 63;
            // 
            // lblFechaRespuesta
            // 
            this.lblFechaRespuesta.AutoSize = true;
            this.lblFechaRespuesta.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblFechaRespuesta.Location = new System.Drawing.Point(17, 47);
            this.lblFechaRespuesta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaRespuesta.Name = "lblFechaRespuesta";
            this.lblFechaRespuesta.Size = new System.Drawing.Size(197, 22);
            this.lblFechaRespuesta.TabIndex = 59;
            this.lblFechaRespuesta.Text = "Fecha de respuesta:";
            // 
            // lblRespuestaReclamo
            // 
            this.lblRespuestaReclamo.AutoSize = true;
            this.lblRespuestaReclamo.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblRespuestaReclamo.Location = new System.Drawing.Point(18, 140);
            this.lblRespuestaReclamo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRespuestaReclamo.Name = "lblRespuestaReclamo";
            this.lblRespuestaReclamo.Size = new System.Drawing.Size(220, 22);
            this.lblRespuestaReclamo.TabIndex = 60;
            this.lblRespuestaReclamo.Text = "Respuesta de reclamo:";
            // 
            // lblEstadoReclamo
            // 
            this.lblEstadoReclamo.AutoSize = true;
            this.lblEstadoReclamo.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblEstadoReclamo.Location = new System.Drawing.Point(243, 463);
            this.lblEstadoReclamo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoReclamo.Name = "lblEstadoReclamo";
            this.lblEstadoReclamo.Size = new System.Drawing.Size(157, 22);
            this.lblEstadoReclamo.TabIndex = 69;
            this.lblEstadoReclamo.Text = "Estado reclamo:";
            // 
            // cboEstadoReclamo
            // 
            this.cboEstadoReclamo.FormattingEnabled = true;
            this.cboEstadoReclamo.Location = new System.Drawing.Point(457, 464);
            this.cboEstadoReclamo.Name = "cboEstadoReclamo";
            this.cboEstadoReclamo.Size = new System.Drawing.Size(177, 24);
            this.cboEstadoReclamo.TabIndex = 70;
            // 
            // frmReclamoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 535);
            this.Controls.Add(this.cboEstadoReclamo);
            this.Controls.Add(this.lblEstadoReclamo);
            this.Controls.Add(this.gboRespuesta);
            this.Controls.Add(this.groupBox1);
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