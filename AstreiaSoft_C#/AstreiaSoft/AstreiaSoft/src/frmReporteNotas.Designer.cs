namespace AstreiaSoft.src
{
    partial class frmReporteNotas
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
            this.btnDescargar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cboBimestre = new System.Windows.Forms.ComboBox();
            this.lblBimestre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDescargar
            // 
            this.btnDescargar.BackColor = System.Drawing.Color.LightBlue;
            this.btnDescargar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargar.Location = new System.Drawing.Point(323, 333);
            this.btnDescargar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(186, 56);
            this.btnDescargar.TabIndex = 5;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.UseVisualStyleBackColor = false;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(267, 162);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(314, 39);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "REPORTE DE NOTAS";
            // 
            // cboBimestre
            // 
            this.cboBimestre.FormattingEnabled = true;
            this.cboBimestre.Location = new System.Drawing.Point(488, 242);
            this.cboBimestre.Name = "cboBimestre";
            this.cboBimestre.Size = new System.Drawing.Size(121, 24);
            this.cboBimestre.TabIndex = 7;
            // 
            // lblBimestre
            // 
            this.lblBimestre.AutoSize = true;
            this.lblBimestre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBimestre.Location = new System.Drawing.Point(237, 242);
            this.lblBimestre.Name = "lblBimestre";
            this.lblBimestre.Size = new System.Drawing.Size(206, 21);
            this.lblBimestre.TabIndex = 8;
            this.lblBimestre.Text = "Seleccione un bimestre:";
            // 
            // frmReporteNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 571);
            this.Controls.Add(this.lblBimestre);
            this.Controls.Add(this.cboBimestre);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReporteNotas";
            this.Text = "frmReporteNotas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cboBimestre;
        private System.Windows.Forms.Label lblBimestre;
    }
}