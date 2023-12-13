namespace AstreiaSoft
{
    partial class frmGestUsuarios
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
            this.btnDocente = new System.Windows.Forms.Button();
            this.btnEstudiante = new System.Windows.Forms.Button();
            this.btnPadreFamilia = new System.Windows.Forms.Button();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDocente
            // 
            this.btnDocente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDocente.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDocente.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocente.Location = new System.Drawing.Point(388, 68);
            this.btnDocente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDocente.Name = "btnDocente";
            this.btnDocente.Size = new System.Drawing.Size(149, 49);
            this.btnDocente.TabIndex = 3;
            this.btnDocente.Text = "Docentes";
            this.btnDocente.UseVisualStyleBackColor = false;
            this.btnDocente.Click += new System.EventHandler(this.btnDocente_Click);
            // 
            // btnEstudiante
            // 
            this.btnEstudiante.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEstudiante.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEstudiante.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstudiante.Location = new System.Drawing.Point(595, 68);
            this.btnEstudiante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEstudiante.Name = "btnEstudiante";
            this.btnEstudiante.Size = new System.Drawing.Size(155, 49);
            this.btnEstudiante.TabIndex = 4;
            this.btnEstudiante.Text = "Estudiantes";
            this.btnEstudiante.UseVisualStyleBackColor = false;
            this.btnEstudiante.Click += new System.EventHandler(this.btnEstudiante_Click);
            // 
            // btnPadreFamilia
            // 
            this.btnPadreFamilia.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPadreFamilia.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPadreFamilia.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPadreFamilia.Location = new System.Drawing.Point(803, 68);
            this.btnPadreFamilia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPadreFamilia.Name = "btnPadreFamilia";
            this.btnPadreFamilia.Size = new System.Drawing.Size(165, 49);
            this.btnPadreFamilia.TabIndex = 5;
            this.btnPadreFamilia.Text = "Padres de Familia";
            this.btnPadreFamilia.UseVisualStyleBackColor = false;
            this.btnPadreFamilia.Click += new System.EventHandler(this.btnPadreFamilia_Click);
            // 
            // panelUsuario
            // 
            this.panelUsuario.AutoScroll = true;
            this.panelUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelUsuario.Location = new System.Drawing.Point(25, 148);
            this.panelUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(1090, 458);
            this.panelUsuario.TabIndex = 1;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdmin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAdmin.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(123, 68);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(215, 49);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "Administradores Academicos";
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuarios";
            // 
            // frmGestUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnAdmin;
            this.ClientSize = new System.Drawing.Size(1138, 617);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnPadreFamilia);
            this.Controls.Add(this.btnEstudiante);
            this.Controls.Add(this.btnDocente);
            this.Controls.Add(this.panelUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmGestUsuarios";
            this.Text = "frmGestUsuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDocente;
        private System.Windows.Forms.Button btnEstudiante;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnPadreFamilia;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panelUsuario;
    }
}