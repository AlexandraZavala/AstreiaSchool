namespace AstreiaSoft.src.Docente
{
    partial class frmGestNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestNotas));
            this.gbEntrega = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxAnularEntrega = new System.Windows.Forms.CheckBox();
            this.txtObservacionesEntrega = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIDEntrega = new System.Windows.Forms.TextBox();
            this.lblIDInscripcion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObservacionesNota = new System.Windows.Forms.TextBox();
            this.txtNotaEntrega = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaRevision = new System.Windows.Forms.DateTimePicker();
            this.txtEstadoEntrega = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTipoEvaluacion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.nombreEval = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gbEntrega.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEntrega
            // 
            this.gbEntrega.Controls.Add(this.label9);
            this.gbEntrega.Controls.Add(this.cbxAnularEntrega);
            this.gbEntrega.Controls.Add(this.txtObservacionesEntrega);
            this.gbEntrega.Controls.Add(this.groupBox2);
            this.gbEntrega.Controls.Add(this.groupBox1);
            this.gbEntrega.Controls.Add(this.pbFoto);
            this.gbEntrega.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.gbEntrega.Location = new System.Drawing.Point(31, 62);
            this.gbEntrega.Name = "gbEntrega";
            this.gbEntrega.Size = new System.Drawing.Size(583, 376);
            this.gbEntrega.TabIndex = 51;
            this.gbEntrega.TabStop = false;
            this.gbEntrega.Text = "Entrega";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 23);
            this.label9.TabIndex = 57;
            this.label9.Text = "Observaciones de Entrega:";
            // 
            // cbxAnularEntrega
            // 
            this.cbxAnularEntrega.AutoSize = true;
            this.cbxAnularEntrega.Enabled = false;
            this.cbxAnularEntrega.Location = new System.Drawing.Point(24, 233);
            this.cbxAnularEntrega.Name = "cbxAnularEntrega";
            this.cbxAnularEntrega.Size = new System.Drawing.Size(106, 20);
            this.cbxAnularEntrega.TabIndex = 65;
            this.cbxAnularEntrega.Text = "Anular entrega";
            this.cbxAnularEntrega.UseVisualStyleBackColor = true;
            this.cbxAnularEntrega.CheckedChanged += new System.EventHandler(this.cbxAnularEntrega_CheckedChanged);
            // 
            // txtObservacionesEntrega
            // 
            this.txtObservacionesEntrega.Enabled = false;
            this.txtObservacionesEntrega.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacionesEntrega.Location = new System.Drawing.Point(24, 292);
            this.txtObservacionesEntrega.Multiline = true;
            this.txtObservacionesEntrega.Name = "txtObservacionesEntrega";
            this.txtObservacionesEntrega.Size = new System.Drawing.Size(167, 55);
            this.txtObservacionesEntrega.TabIndex = 58;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIDEntrega);
            this.groupBox2.Controls.Add(this.lblIDInscripcion);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtObservacionesNota);
            this.groupBox2.Controls.Add(this.txtNotaEntrega);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtpFechaRevision);
            this.groupBox2.Controls.Add(this.txtEstadoEntrega);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(215, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 213);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion";
            // 
            // txtIDEntrega
            // 
            this.txtIDEntrega.Location = new System.Drawing.Point(119, 31);
            this.txtIDEntrega.Name = "txtIDEntrega";
            this.txtIDEntrega.ReadOnly = true;
            this.txtIDEntrega.Size = new System.Drawing.Size(70, 20);
            this.txtIDEntrega.TabIndex = 37;
            this.txtIDEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIDInscripcion
            // 
            this.lblIDInscripcion.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDInscripcion.Location = new System.Drawing.Point(31, 31);
            this.lblIDInscripcion.Name = "lblIDInscripcion";
            this.lblIDInscripcion.Size = new System.Drawing.Size(70, 23);
            this.lblIDInscripcion.TabIndex = 36;
            this.lblIDInscripcion.Text = "ID Entrega:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 39);
            this.label3.TabIndex = 50;
            this.label3.Text = "Observaciones de Calificacion:";
            // 
            // txtObservacionesNota
            // 
            this.txtObservacionesNota.Enabled = false;
            this.txtObservacionesNota.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacionesNota.Location = new System.Drawing.Point(119, 141);
            this.txtObservacionesNota.Multiline = true;
            this.txtObservacionesNota.Name = "txtObservacionesNota";
            this.txtObservacionesNota.Size = new System.Drawing.Size(144, 55);
            this.txtObservacionesNota.TabIndex = 51;
            // 
            // txtNotaEntrega
            // 
            this.txtNotaEntrega.Enabled = false;
            this.txtNotaEntrega.Location = new System.Drawing.Point(119, 112);
            this.txtNotaEntrega.Name = "txtNotaEntrega";
            this.txtNotaEntrega.Size = new System.Drawing.Size(70, 20);
            this.txtNotaEntrega.TabIndex = 55;
            this.txtNotaEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNotaEntrega.TextChanged += new System.EventHandler(this.txtNotaEntrega_TextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 23);
            this.label5.TabIndex = 54;
            this.label5.Text = "Nota:";
            // 
            // dtpFechaRevision
            // 
            this.dtpFechaRevision.Enabled = false;
            this.dtpFechaRevision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRevision.Location = new System.Drawing.Point(119, 84);
            this.dtpFechaRevision.Name = "dtpFechaRevision";
            this.dtpFechaRevision.Size = new System.Drawing.Size(114, 20);
            this.dtpFechaRevision.TabIndex = 56;
            // 
            // txtEstadoEntrega
            // 
            this.txtEstadoEntrega.Location = new System.Drawing.Point(119, 54);
            this.txtEstadoEntrega.Name = "txtEstadoEntrega";
            this.txtEstadoEntrega.ReadOnly = true;
            this.txtEstadoEntrega.Size = new System.Drawing.Size(144, 20);
            this.txtEstadoEntrega.TabIndex = 47;
            this.txtEstadoEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEstadoEntrega.TextChanged += new System.EventHandler(this.txtEstadoEntrega_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 48;
            this.label2.Text = "Fecha Revision:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 46;
            this.label1.Text = "Estado:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTipoEvaluacion);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtpFechaFin);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtpFechaInicio);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nombreEval);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(215, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 120);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Evaluacion";
            // 
            // txtTipoEvaluacion
            // 
            this.txtTipoEvaluacion.Location = new System.Drawing.Point(119, 83);
            this.txtTipoEvaluacion.Name = "txtTipoEvaluacion";
            this.txtTipoEvaluacion.ReadOnly = true;
            this.txtTipoEvaluacion.Size = new System.Drawing.Size(144, 20);
            this.txtTipoEvaluacion.TabIndex = 70;
            this.txtTipoEvaluacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 23);
            this.label8.TabIndex = 69;
            this.label8.Text = "Tipo Evaluacion:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(203, 56);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(114, 20);
            this.dtpFechaFin.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(178, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 23);
            this.label7.TabIndex = 67;
            this.label7.Text = "Al:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(56, 57);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(114, 20);
            this.dtpFechaInicio.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 23);
            this.label6.TabIndex = 65;
            this.label6.Text = "Del:";
            // 
            // nombreEval
            // 
            this.nombreEval.Location = new System.Drawing.Point(96, 25);
            this.nombreEval.Name = "nombreEval";
            this.nombreEval.ReadOnly = true;
            this.nombreEval.Size = new System.Drawing.Size(144, 20);
            this.nombreEval.TabIndex = 64;
            this.nombreEval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 23);
            this.label4.TabIndex = 63;
            this.label4.Text = "Evaluacion:";
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(24, 37);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(168, 185);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 38;
            this.pbFoto.TabStop = false;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.Image")));
            this.btnAtras.Location = new System.Drawing.Point(31, 11);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(105, 32);
            this.btnAtras.TabIndex = 52;
            this.btnAtras.Text = "Atras";
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::AstreiaSoft.Properties.Resources.img_guardar_17;
            this.btnGuardar.Location = new System.Drawing.Point(291, 11);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 32);
            this.btnGuardar.TabIndex = 53;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::AstreiaSoft.Properties.Resources.img_cancelar_17;
            this.btnCancelar.Location = new System.Drawing.Point(509, 11);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 32);
            this.btnCancelar.TabIndex = 72;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::AstreiaSoft.Properties.Resources.img_editar_17;
            this.btnEditar.Location = new System.Drawing.Point(400, 11);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(105, 32);
            this.btnEditar.TabIndex = 71;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmGestNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 460);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gbEntrega);
            this.Name = "frmGestNotas";
            this.Text = "frmGestNotas";
            this.gbEntrega.ResumeLayout(false);
            this.gbEntrega.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEntrega;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIDEntrega;
        private System.Windows.Forms.Label lblIDInscripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtObservacionesNota;
        private System.Windows.Forms.DateTimePicker dtpFechaRevision;
        private System.Windows.Forms.TextBox txtEstadoEntrega;
        private System.Windows.Forms.TextBox txtNotaEntrega;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTipoEvaluacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nombreEval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckBox cbxAnularEntrega;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtObservacionesEntrega;
    }
}