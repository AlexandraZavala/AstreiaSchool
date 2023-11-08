namespace AstreiaSoft
{
    partial class frmBienvenida
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
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblAstreia = new System.Windows.Forms.Label();
            this.pbColegio = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbColegio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(207, 465);
            this.lblBienvenido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(661, 40);
            this.lblBienvenido.TabIndex = 1;
            this.lblBienvenido.Text = "Bienvenido a la plataforma del colegio";
            // 
            // lblAstreia
            // 
            this.lblAstreia.AutoSize = true;
            this.lblAstreia.Font = new System.Drawing.Font("Century Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAstreia.Location = new System.Drawing.Point(377, 9);
            this.lblAstreia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAstreia.Name = "lblAstreia";
            this.lblAstreia.Size = new System.Drawing.Size(327, 55);
            this.lblAstreia.TabIndex = 2;
            this.lblAstreia.Text = "Astreia School";
            // 
            // pbColegio
            // 
            this.pbColegio.ErrorImage = global::AstreiaSoft.Properties.Resources.Cole;
            this.pbColegio.Image = global::AstreiaSoft.Properties.Resources.Cole;
            this.pbColegio.Location = new System.Drawing.Point(231, 82);
            this.pbColegio.Margin = new System.Windows.Forms.Padding(4);
            this.pbColegio.Name = "pbColegio";
            this.pbColegio.Size = new System.Drawing.Size(637, 366);
            this.pbColegio.TabIndex = 0;
            this.pbColegio.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 530);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAstreia);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.pbColegio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBienvenida";
            this.Text = "frmBienvenida";
            ((System.ComponentModel.ISupportInitialize)(this.pbColegio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbColegio;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Label lblAstreia;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}