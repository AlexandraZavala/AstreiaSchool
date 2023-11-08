namespace AstreiaSoft
{
    partial class frmEventosEstudiante
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
            this.pnlMisEventos = new System.Windows.Forms.Panel();
            this.btnExplorarEventos = new System.Windows.Forms.Button();
            this.btnMisEventos = new System.Windows.Forms.Button();
            this.pnlDescubrir = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlMisEventos
            // 
            this.pnlMisEventos.AutoScroll = true;
            this.pnlMisEventos.Location = new System.Drawing.Point(25, 60);
            this.pnlMisEventos.Name = "pnlMisEventos";
            this.pnlMisEventos.Size = new System.Drawing.Size(753, 391);
            this.pnlMisEventos.TabIndex = 5;
            // 
            // btnExplorarEventos
            // 
            this.btnExplorarEventos.BackColor = System.Drawing.Color.Transparent;
            this.btnExplorarEventos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExplorarEventos.Location = new System.Drawing.Point(170, 11);
            this.btnExplorarEventos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExplorarEventos.Name = "btnExplorarEventos";
            this.btnExplorarEventos.Size = new System.Drawing.Size(141, 32);
            this.btnExplorarEventos.TabIndex = 33;
            this.btnExplorarEventos.Text = "Explorar Eventos";
            this.btnExplorarEventos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExplorarEventos.UseVisualStyleBackColor = false;
            this.btnExplorarEventos.Click += new System.EventHandler(this.btnExplrarEventos_Click);
            // 
            // btnMisEventos
            // 
            this.btnMisEventos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMisEventos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMisEventos.Location = new System.Drawing.Point(25, 11);
            this.btnMisEventos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMisEventos.Name = "btnMisEventos";
            this.btnMisEventos.Size = new System.Drawing.Size(141, 32);
            this.btnMisEventos.TabIndex = 32;
            this.btnMisEventos.Text = "Mis Eventos";
            this.btnMisEventos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMisEventos.UseVisualStyleBackColor = false;
            this.btnMisEventos.Click += new System.EventHandler(this.btnMisEventos_Click);
            // 
            // pnlDescubrir
            // 
            this.pnlDescubrir.AutoScroll = true;
            this.pnlDescubrir.Location = new System.Drawing.Point(25, 60);
            this.pnlDescubrir.Name = "pnlDescubrir";
            this.pnlDescubrir.Size = new System.Drawing.Size(753, 391);
            this.pnlDescubrir.TabIndex = 6;
            // 
            // frmEventosEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.btnExplorarEventos);
            this.Controls.Add(this.pnlMisEventos);
            this.Controls.Add(this.btnMisEventos);
            this.Controls.Add(this.pnlDescubrir);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmEventosEstudiante";
            this.Text = "frmEventosEstudiante";
            this.Load += new System.EventHandler(this.frmEventosEstudiante_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMisEventos;
        private System.Windows.Forms.Button btnExplorarEventos;
        private System.Windows.Forms.Button btnMisEventos;
        private System.Windows.Forms.Panel pnlDescubrir;
    }
}