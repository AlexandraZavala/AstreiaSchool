namespace AstreiaSoft
{
    partial class frmDetallesTareaDocente
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
            this.gbTareas = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNotaMaxima = new System.Windows.Forms.TextBox();
            this.cboTipoEvaluacion = new System.Windows.Forms.ComboBox();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblNota = new System.Windows.Forms.Label();
            this.lblTipoEvaluacion = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbTareas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTareas
            // 
            this.gbTareas.Controls.Add(this.txtDescripcion);
            this.gbTareas.Controls.Add(this.lblDescripcion);
            this.gbTareas.Controls.Add(this.txtNotaMaxima);
            this.gbTareas.Controls.Add(this.cboTipoEvaluacion);
            this.gbTareas.Controls.Add(this.dtpFechaFin);
            this.gbTareas.Controls.Add(this.dtpFechaInicio);
            this.gbTareas.Controls.Add(this.lblNota);
            this.gbTareas.Controls.Add(this.lblTipoEvaluacion);
            this.gbTareas.Controls.Add(this.lblFechaFin);
            this.gbTareas.Controls.Add(this.lblDNI);
            this.gbTareas.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTareas.Location = new System.Drawing.Point(23, 102);
            this.gbTareas.Margin = new System.Windows.Forms.Padding(4);
            this.gbTareas.Name = "gbTareas";
            this.gbTareas.Padding = new System.Windows.Forms.Padding(4);
            this.gbTareas.Size = new System.Drawing.Size(941, 309);
            this.gbTareas.TabIndex = 65;
            this.gbTareas.TabStop = false;
            this.gbTareas.Text = "Tareas asignadas";
            this.gbTareas.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(184, 168);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(680, 92);
            this.txtDescripcion.TabIndex = 67;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblDescripcion.Location = new System.Drawing.Point(45, 171);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(116, 22);
            this.lblDescripcion.TabIndex = 66;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtNotaMaxima
            // 
            this.txtNotaMaxima.Location = new System.Drawing.Point(729, 108);
            this.txtNotaMaxima.Name = "txtNotaMaxima";
            this.txtNotaMaxima.Size = new System.Drawing.Size(135, 28);
            this.txtNotaMaxima.TabIndex = 65;
            // 
            // cboTipoEvaluacion
            // 
            this.cboTipoEvaluacion.FormattingEnabled = true;
            this.cboTipoEvaluacion.Location = new System.Drawing.Point(729, 51);
            this.cboTipoEvaluacion.Name = "cboTipoEvaluacion";
            this.cboTipoEvaluacion.Size = new System.Drawing.Size(135, 29);
            this.cboTipoEvaluacion.TabIndex = 64;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(184, 111);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(325, 28);
            this.dtpFechaFin.TabIndex = 63;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(184, 54);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(325, 28);
            this.dtpFechaInicio.TabIndex = 62;
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblNota.Location = new System.Drawing.Point(548, 111);
            this.lblNota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(138, 22);
            this.lblNota.TabIndex = 61;
            this.lblNota.Text = "Nota máxima:";
            // 
            // lblTipoEvaluacion
            // 
            this.lblTipoEvaluacion.AutoSize = true;
            this.lblTipoEvaluacion.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblTipoEvaluacion.Location = new System.Drawing.Point(548, 54);
            this.lblTipoEvaluacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoEvaluacion.Name = "lblTipoEvaluacion";
            this.lblTipoEvaluacion.Size = new System.Drawing.Size(159, 22);
            this.lblTipoEvaluacion.TabIndex = 60;
            this.lblTipoEvaluacion.Text = "Tipo Evaluación:";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblFechaFin.Location = new System.Drawing.Point(45, 111);
            this.lblFechaFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(99, 22);
            this.lblFechaFin.TabIndex = 59;
            this.lblFechaFin.Text = "Fecha fin:";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblDNI.Location = new System.Drawing.Point(45, 54);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(123, 22);
            this.lblDNI.TabIndex = 58;
            this.lblDNI.Text = "Fecha inicio:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::AstreiaSoft.Properties.Resources.img_cancelar_17;
            this.btnCancelar.Location = new System.Drawing.Point(696, 36);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 39);
            this.btnCancelar.TabIndex = 72;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::AstreiaSoft.Properties.Resources.img_eliminar_17;
            this.btnEliminar.Location = new System.Drawing.Point(550, 36);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(140, 39);
            this.btnEliminar.TabIndex = 71;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::AstreiaSoft.Properties.Resources.img_editar_17;
            this.btnEditar.Location = new System.Drawing.Point(404, 36);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(140, 39);
            this.btnEditar.TabIndex = 69;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::AstreiaSoft.Properties.Resources.img_guardar_17;
            this.btnGuardar.Location = new System.Drawing.Point(258, 36);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 39);
            this.btnGuardar.TabIndex = 68;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = global::AstreiaSoft.Properties.Resources.img_nuevo_17;
            this.btnNuevo.Location = new System.Drawing.Point(112, 36);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(140, 39);
            this.btnNuevo.TabIndex = 70;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmDetallesTareaDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 438);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.gbTareas);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEditar);
            this.Name = "frmDetallesTareaDocente";
            this.Text = "frmDetallesTareaDocente";
            this.gbTareas.ResumeLayout(false);
            this.gbTareas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbTareas;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Label lblTipoEvaluacion;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.TextBox txtNotaMaxima;
        private System.Windows.Forms.ComboBox cboTipoEvaluacion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
    }
}