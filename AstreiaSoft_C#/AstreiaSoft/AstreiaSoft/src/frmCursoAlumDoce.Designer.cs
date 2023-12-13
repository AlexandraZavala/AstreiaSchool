namespace AstreiaSoft
{
    partial class frmCursoAlumDoce
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
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.btnReporteAnual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlContenido
            // 
            this.pnlContenido.Location = new System.Drawing.Point(52, 126);
            this.pnlContenido.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(1078, 470);
            this.pnlContenido.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTitulo.Location = new System.Drawing.Point(46, 20);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(168, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Mis Cursos";
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Location = new System.Drawing.Point(240, 78);
            this.cboPeriodo.Margin = new System.Windows.Forms.Padding(4);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(305, 27);
            this.cboPeriodo.TabIndex = 1;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.Location = new System.Drawing.Point(48, 82);
            this.lblPeriodo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(163, 19);
            this.lblPeriodo.TabIndex = 2;
            this.lblPeriodo.Text = "Seleccione el periodo:";
            // 
            // btnReporteAnual
            // 
            this.btnReporteAnual.Location = new System.Drawing.Point(665, 68);
            this.btnReporteAnual.Name = "btnReporteAnual";
            this.btnReporteAnual.Size = new System.Drawing.Size(147, 46);
            this.btnReporteAnual.TabIndex = 4;
            this.btnReporteAnual.Text = "Reporte Anual";
            this.btnReporteAnual.UseVisualStyleBackColor = true;
            this.btnReporteAnual.Click += new System.EventHandler(this.btnReporteAnual_Click);
            // 
            // frmCursoAlumDoce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 625);
            this.Controls.Add(this.btnReporteAnual);
            this.Controls.Add(this.cboPeriodo);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCursoAlumDoce";
            this.Text = "frmCursoAlumDoce";
            this.Load += new System.EventHandler(this.frmCursoAlumDoce_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Button btnReporteAnual;
    }
}