namespace AstreiaSoft
{
    partial class frmImgSeccion
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
            this.lblSeccion = new System.Windows.Forms.Label();
            this.pbImgSeccion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgSeccion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeccion
            // 
            this.lblSeccion.AutoSize = true;
            this.lblSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeccion.Location = new System.Drawing.Point(29, 38);
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(69, 20);
            this.lblSeccion.TabIndex = 1;
            this.lblSeccion.Text = "Sección";
            // 
            // pbImgSeccion
            // 
            this.pbImgSeccion.Location = new System.Drawing.Point(104, 18);
            this.pbImgSeccion.Name = "pbImgSeccion";
            this.pbImgSeccion.Size = new System.Drawing.Size(40, 40);
            this.pbImgSeccion.TabIndex = 0;
            this.pbImgSeccion.TabStop = false;
            // 
            // frmImgSeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 78);
            this.Controls.Add(this.lblSeccion);
            this.Controls.Add(this.pbImgSeccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmImgSeccion";
            this.Text = "frmImgSeccion";
            this.Click += new System.EventHandler(this.frmImgSeccion_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmImgSeccion_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbImgSeccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImgSeccion;
        private System.Windows.Forms.Label lblSeccion;
    }
}