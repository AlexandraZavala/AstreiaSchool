namespace AstreiaSoft
{
    partial class frm_DetalleEvaluacion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNotaAsignada = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.dtpFechaCalificacion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaCalificacion = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblNotaAsignada = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 66);
            this.panel1.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Curso - Año";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtNotaAsignada);
            this.groupBox1.Controls.Add(this.txtObservaciones);
            this.groupBox1.Controls.Add(this.dtpFechaCalificacion);
            this.groupBox1.Controls.Add(this.lblFechaCalificacion);
            this.groupBox1.Controls.Add(this.lblObservaciones);
            this.groupBox1.Controls.Add(this.lblNotaAsignada);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 129);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(633, 374);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tareas asignadas";
            // 
            // txtNotaAsignada
            // 
            this.txtNotaAsignada.Location = new System.Drawing.Point(254, 61);
            this.txtNotaAsignada.Name = "txtNotaAsignada";
            this.txtNotaAsignada.Size = new System.Drawing.Size(144, 28);
            this.txtNotaAsignada.TabIndex = 69;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(254, 110);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(325, 92);
            this.txtObservaciones.TabIndex = 68;
            // 
            // dtpFechaCalificacion
            // 
            this.dtpFechaCalificacion.Location = new System.Drawing.Point(254, 223);
            this.dtpFechaCalificacion.Name = "dtpFechaCalificacion";
            this.dtpFechaCalificacion.Size = new System.Drawing.Size(325, 28);
            this.dtpFechaCalificacion.TabIndex = 63;
            // 
            // lblFechaCalificacion
            // 
            this.lblFechaCalificacion.AutoSize = true;
            this.lblFechaCalificacion.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblFechaCalificacion.Location = new System.Drawing.Point(39, 223);
            this.lblFechaCalificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaCalificacion.Name = "lblFechaCalificacion";
            this.lblFechaCalificacion.Size = new System.Drawing.Size(182, 22);
            this.lblFechaCalificacion.TabIndex = 61;
            this.lblFechaCalificacion.Text = "Fecha calificación:";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblObservaciones.Location = new System.Drawing.Point(39, 110);
            this.lblObservaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(154, 22);
            this.lblObservaciones.TabIndex = 60;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // lblNotaAsignada
            // 
            this.lblNotaAsignada.AutoSize = true;
            this.lblNotaAsignada.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblNotaAsignada.Location = new System.Drawing.Point(39, 61);
            this.lblNotaAsignada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotaAsignada.Name = "lblNotaAsignada";
            this.lblNotaAsignada.Size = new System.Drawing.Size(153, 22);
            this.lblNotaAsignada.TabIndex = 59;
            this.lblNotaAsignada.Text = "Nota asignada:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::AstreiaSoft.Properties.Resources.img_guardar_17;
            this.btnGuardar.Location = new System.Drawing.Point(218, 293);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 39);
            this.btnGuardar.TabIndex = 70;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnCalificarEvaluacion_Click);
            // 
            // frm_DetalleEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 534);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_DetalleEvaluacion";
            this.Text = "frm_DetalleEvaluacion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFechaCalificacion;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblNotaAsignada;
        private System.Windows.Forms.DateTimePicker dtpFechaCalificacion;
        private System.Windows.Forms.TextBox txtNotaAsignada;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnGuardar;
    }
}