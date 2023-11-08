namespace AstreiaSoft
{
    partial class frmPantallaLogIn
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPantallaLogIn));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlIzquierdo = new System.Windows.Forms.Panel();
            this.lnUsuario = new System.Windows.Forms.FlowLayoutPanel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lnContrasena = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.lnlOlvidarContrasena = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnMostrarContrasena = new System.Windows.Forms.Button();
            this.btnMinizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pnlIzquierdo
            // 
            this.pnlIzquierdo.BackColor = System.Drawing.Color.CadetBlue;
            this.pnlIzquierdo.Controls.Add(this.pictureBox1);
            this.pnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.pnlIzquierdo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlIzquierdo.Name = "pnlIzquierdo";
            this.pnlIzquierdo.Size = new System.Drawing.Size(251, 330);
            this.pnlIzquierdo.TabIndex = 1;
            // 
            // lnUsuario
            // 
            this.lnUsuario.BackColor = System.Drawing.Color.LightGray;
            this.lnUsuario.Enabled = false;
            this.lnUsuario.Location = new System.Drawing.Point(319, 127);
            this.lnUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lnUsuario.Name = "lnUsuario";
            this.lnUsuario.Size = new System.Drawing.Size(349, 1);
            this.lnUsuario.TabIndex = 2;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsuario.Location = new System.Drawing.Point(319, 102);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(349, 21);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Text = "USUARIO";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasena.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.ForeColor = System.Drawing.Color.DimGray;
            this.txtContrasena.Location = new System.Drawing.Point(319, 177);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(349, 21);
            this.txtContrasena.TabIndex = 4;
            this.txtContrasena.Text = "CONTRASEÑA";
            this.txtContrasena.Enter += new System.EventHandler(this.txtContrasena_Enter);
            this.txtContrasena.Leave += new System.EventHandler(this.txtContrasena_Leave);
            // 
            // lnContrasena
            // 
            this.lnContrasena.BackColor = System.Drawing.Color.LightGray;
            this.lnContrasena.Enabled = false;
            this.lnContrasena.Location = new System.Drawing.Point(319, 202);
            this.lnContrasena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lnContrasena.Name = "lnContrasena";
            this.lnContrasena.Size = new System.Drawing.Size(349, 1);
            this.lnContrasena.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(427, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "LOGIN";
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.ForeColor = System.Drawing.Color.LightGray;
            this.btnAcceder.Location = new System.Drawing.Point(319, 249);
            this.btnAcceder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(349, 39);
            this.btnAcceder.TabIndex = 5;
            this.btnAcceder.Text = "ACCEDER";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // lnlOlvidarContrasena
            // 
            this.lnlOlvidarContrasena.ActiveLinkColor = System.Drawing.Color.CadetBlue;
            this.lnlOlvidarContrasena.AutoSize = true;
            this.lnlOlvidarContrasena.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlOlvidarContrasena.LinkColor = System.Drawing.Color.CadetBlue;
            this.lnlOlvidarContrasena.Location = new System.Drawing.Point(365, 290);
            this.lnlOlvidarContrasena.Name = "lnlOlvidarContrasena";
            this.lnlOlvidarContrasena.Size = new System.Drawing.Size(255, 21);
            this.lnlOlvidarContrasena.TabIndex = 6;
            this.lnlOlvidarContrasena.TabStop = true;
            this.lnlOlvidarContrasena.Text = "¿Ha olvidado la contraseña?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.ForeColor = System.Drawing.Color.LightGray;
            this.lblContrasena.Location = new System.Drawing.Point(317, 151);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(125, 23);
            this.lblContrasena.TabIndex = 11;
            this.lblContrasena.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.LightGray;
            this.lblUsuario.Location = new System.Drawing.Point(315, 76);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 23);
            this.lblUsuario.TabIndex = 12;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(317, 210);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(116, 21);
            this.lblError.TabIndex = 13;
            this.lblError.Text = "Mostrar error";
            // 
            // btnMostrarContrasena
            // 
            this.btnMostrarContrasena.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrarContrasena.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMostrarContrasena.FlatAppearance.BorderSize = 0;
            this.btnMostrarContrasena.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMostrarContrasena.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMostrarContrasena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarContrasena.Image = global::AstreiaSoft.Properties.Resources.img_ojo_blanco_20;
            this.btnMostrarContrasena.Location = new System.Drawing.Point(674, 174);
            this.btnMostrarContrasena.Name = "btnMostrarContrasena";
            this.btnMostrarContrasena.Size = new System.Drawing.Size(26, 30);
            this.btnMostrarContrasena.TabIndex = 14;
            this.btnMostrarContrasena.UseVisualStyleBackColor = false;
            this.btnMostrarContrasena.Click += new System.EventHandler(this.btnMostrarContrasena_Click);
            // 
            // btnMinizar
            // 
            this.btnMinizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinizar.Image")));
            this.btnMinizar.Location = new System.Drawing.Point(701, 9);
            this.btnMinizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinizar.Name = "btnMinizar";
            this.btnMinizar.Size = new System.Drawing.Size(29, 30);
            this.btnMinizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinizar.TabIndex = 9;
            this.btnMinizar.TabStop = false;
            this.btnMinizar.Click += new System.EventHandler(this.btnMinizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(739, 9);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(29, 30);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AstreiaSoft.Properties.Resources.ASTREIA_LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(3, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmPantallaLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 330);
            this.Controls.Add(this.btnMostrarContrasena);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMinizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lnlOlvidarContrasena);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.lnContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lnUsuario);
            this.Controls.Add(this.pnlIzquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPantallaLogIn";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPantallaLogIn";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlPrincipal_MouseDown);
            this.pnlIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel pnlIzquierdo;
        private System.Windows.Forms.FlowLayoutPanel lnUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.FlowLayoutPanel lnContrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.LinkLabel lnlOlvidarContrasena;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnMostrarContrasena;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

