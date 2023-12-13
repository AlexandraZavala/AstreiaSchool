namespace WindowsFormsApp1
{
    partial class frmGestionMalla
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
            this.pnlMalla = new System.Windows.Forms.Panel();
            this.btnCursoProgra = new System.Windows.Forms.Button();
            this.btnAreaCurri = new System.Windows.Forms.Button();
            this.btnCursoGe = new System.Windows.Forms.Button();
            this.lblCurso = new System.Windows.Forms.Label();
            this.panelGestionCursos = new System.Windows.Forms.Panel();
            this.pnlMalla.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMalla
            // 
            this.pnlMalla.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlMalla.Controls.Add(this.btnCursoProgra);
            this.pnlMalla.Controls.Add(this.btnAreaCurri);
            this.pnlMalla.Controls.Add(this.btnCursoGe);
            this.pnlMalla.Controls.Add(this.lblCurso);
            this.pnlMalla.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMalla.Location = new System.Drawing.Point(0, 0);
            this.pnlMalla.Name = "pnlMalla";
            this.pnlMalla.Size = new System.Drawing.Size(800, 58);
            this.pnlMalla.TabIndex = 0;
            // 
            // btnCursoProgra
            // 
            this.btnCursoProgra.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursoProgra.ImageKey = "(ninguno)";
            this.btnCursoProgra.Location = new System.Drawing.Point(541, 6);
            this.btnCursoProgra.Name = "btnCursoProgra";
            this.btnCursoProgra.Size = new System.Drawing.Size(109, 46);
            this.btnCursoProgra.TabIndex = 3;
            this.btnCursoProgra.Text = "Curso Programado";
            this.btnCursoProgra.UseVisualStyleBackColor = true;
            this.btnCursoProgra.Click += new System.EventHandler(this.btnCursoProgra_Click);
            // 
            // btnAreaCurri
            // 
            this.btnAreaCurri.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAreaCurri.ImageKey = "(ninguno)";
            this.btnAreaCurri.Location = new System.Drawing.Point(175, 6);
            this.btnAreaCurri.Name = "btnAreaCurri";
            this.btnAreaCurri.Size = new System.Drawing.Size(109, 46);
            this.btnAreaCurri.TabIndex = 2;
            this.btnAreaCurri.Text = "Area Curricular";
            this.btnAreaCurri.UseVisualStyleBackColor = true;
            this.btnAreaCurri.Click += new System.EventHandler(this.btnAreaCurri_Click);
            // 
            // btnCursoGe
            // 
            this.btnCursoGe.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursoGe.ImageKey = "(ninguno)";
            this.btnCursoGe.Location = new System.Drawing.Point(355, 6);
            this.btnCursoGe.Name = "btnCursoGe";
            this.btnCursoGe.Size = new System.Drawing.Size(109, 46);
            this.btnCursoGe.TabIndex = 1;
            this.btnCursoGe.Text = "Curso General";
            this.btnCursoGe.UseVisualStyleBackColor = true;
            this.btnCursoGe.Click += new System.EventHandler(this.btnCursoGe_Click);
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblCurso.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(386, 23);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(0, 13);
            this.lblCurso.TabIndex = 0;
            // 
            // panelGestionCursos
            // 
            this.panelGestionCursos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelGestionCursos.Location = new System.Drawing.Point(0, 58);
            this.panelGestionCursos.Name = "panelGestionCursos";
            this.panelGestionCursos.Size = new System.Drawing.Size(800, 629);
            this.panelGestionCursos.TabIndex = 1;
            // 
            // frmGestionMalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 687);
            this.Controls.Add(this.panelGestionCursos);
            this.Controls.Add(this.pnlMalla);
            this.Name = "frmGestionMalla";
            this.TopMost = true;
            this.pnlMalla.ResumeLayout(false);
            this.pnlMalla.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMalla;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Button btnCursoGe;
        private System.Windows.Forms.Button btnAreaCurri;
        private System.Windows.Forms.Button btnCursoProgra;
        private System.Windows.Forms.Panel panelGestionCursos;
    }
}