namespace AstreiaSoft
{
    partial class frmUnCurso
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
            this.btnSeleCurso = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeleCurso
            // 
            this.btnSeleCurso.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleCurso.Location = new System.Drawing.Point(109, 157);
            this.btnSeleCurso.Name = "btnSeleCurso";
            this.btnSeleCurso.Size = new System.Drawing.Size(82, 24);
            this.btnSeleCurso.TabIndex = 4;
            this.btnSeleCurso.Text = "Seleccionar";
            this.btnSeleCurso.UseVisualStyleBackColor = true;
            this.btnSeleCurso.Click += new System.EventHandler(this.btnSeleCurso_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AstreiaSoft.Properties.Resources.mate;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 108);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 119);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(94, 16);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre Curso";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(7, 141);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(44, 16);
            this.lblArea.TabIndex = 6;
            this.lblArea.Text = "label1";
            // 
            // frmUnCurso
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(197, 188);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnSeleCurso);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUnCurso";
            this.Text = "frmUnCurso";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSeleCurso;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblArea;
    }
}