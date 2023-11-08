namespace AstreiaSoft
{
    partial class ucEstudianteRegistrado
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblSeleccionarEstudiante;
        private System.Windows.Forms.ComboBox cbxEstudiantes;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblSeleccionarEstudiante = new System.Windows.Forms.Label();
            this.cbxEstudiantes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblSeleccionarEstudiante
            // 
            this.lblSeleccionarEstudiante.AutoSize = true;
            this.lblSeleccionarEstudiante.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarEstudiante.Location = new System.Drawing.Point(15, 16);
            this.lblSeleccionarEstudiante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeleccionarEstudiante.Name = "lblSeleccionarEstudiante";
            this.lblSeleccionarEstudiante.Size = new System.Drawing.Size(131, 16);
            this.lblSeleccionarEstudiante.TabIndex = 0;
            this.lblSeleccionarEstudiante.Text = "Seleccione a su hijo(a):";
            // 
            // cbxEstudiantes
            // 
            this.cbxEstudiantes.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstudiantes.FormattingEnabled = true;
            this.cbxEstudiantes.Items.AddRange(new object[] {
            "Alberto",
            "Frank",
            "Alexis",
            "Alexandra",
            "Alessandra"});
            this.cbxEstudiantes.Location = new System.Drawing.Point(165, 16);
            this.cbxEstudiantes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxEstudiantes.Name = "cbxEstudiantes";
            this.cbxEstudiantes.Size = new System.Drawing.Size(188, 23);
            this.cbxEstudiantes.TabIndex = 1;
            // 
            // ucEstudianteRegistrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSeleccionarEstudiante);
            this.Controls.Add(this.cbxEstudiantes);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucEstudianteRegistrado";
            this.Size = new System.Drawing.Size(381, 65);
            this.Load += new System.EventHandler(this.ucEstudianteRegistrado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
