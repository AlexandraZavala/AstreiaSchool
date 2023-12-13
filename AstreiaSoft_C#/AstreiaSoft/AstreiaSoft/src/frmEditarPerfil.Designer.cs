namespace AstreiaSoft
{
    partial class frmEditarPerfil
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
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.btnGuardarPerfil = new System.Windows.Forms.Button();
            this.rbFemeninoPerfil = new System.Windows.Forms.RadioButton();
            this.rbMasculinoPerfil = new System.Windows.Forms.RadioButton();
            this.lblSubirFoto = new System.Windows.Forms.Label();
            this.btnRegresarPerfil = new System.Windows.Forms.Button();
            this.lblTituloEditarPerfil = new System.Windows.Forms.Label();
            this.dtpFechaNacimientoPerfil = new System.Windows.Forms.DateTimePicker();
            this.btnSubirPerfil = new System.Windows.Forms.Button();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombrePerfil = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Image = global::AstreiaSoft.Properties.Resources.foto_sin_perfil;
            this.pbFoto.Location = new System.Drawing.Point(159, 177);
            this.pbFoto.Margin = new System.Windows.Forms.Padding(4);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(160, 180);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 79;
            this.pbFoto.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(415, 390);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 21);
            this.label7.TabIndex = 78;
            this.label7.Text = "Direccion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(415, 358);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 21);
            this.label6.TabIndex = 77;
            this.label6.Text = "Telefono:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 326);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 21);
            this.label1.TabIndex = 76;
            this.label1.Text = "Fecha de Nacimiento:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(415, 222);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(154, 21);
            this.lblNombre.TabIndex = 73;
            this.lblNombre.Text = "Apellido Paterno:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(415, 292);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(78, 21);
            this.lblArea.TabIndex = 75;
            this.lblArea.Text = "Género:";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(415, 162);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(46, 21);
            this.lblDNI.TabIndex = 74;
            this.lblDNI.Text = "DNI:";
            // 
            // btnGuardarPerfil
            // 
            this.btnGuardarPerfil.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarPerfil.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPerfil.Image = global::AstreiaSoft.Properties.Resources.img_guardar_17;
            this.btnGuardarPerfil.Location = new System.Drawing.Point(466, 461);
            this.btnGuardarPerfil.Name = "btnGuardarPerfil";
            this.btnGuardarPerfil.Size = new System.Drawing.Size(145, 65);
            this.btnGuardarPerfil.TabIndex = 120;
            this.btnGuardarPerfil.Text = "Guardar";
            this.btnGuardarPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarPerfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarPerfil.UseVisualStyleBackColor = false;
            this.btnGuardarPerfil.Click += new System.EventHandler(this.btnGuardarPerfil_Click);
            // 
            // rbFemeninoPerfil
            // 
            this.rbFemeninoPerfil.AutoSize = true;
            this.rbFemeninoPerfil.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemeninoPerfil.Location = new System.Drawing.Point(748, 292);
            this.rbFemeninoPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.rbFemeninoPerfil.Name = "rbFemeninoPerfil";
            this.rbFemeninoPerfil.Size = new System.Drawing.Size(92, 21);
            this.rbFemeninoPerfil.TabIndex = 115;
            this.rbFemeninoPerfil.TabStop = true;
            this.rbFemeninoPerfil.Text = "Femenino";
            this.rbFemeninoPerfil.UseVisualStyleBackColor = true;
            // 
            // rbMasculinoPerfil
            // 
            this.rbMasculinoPerfil.AutoSize = true;
            this.rbMasculinoPerfil.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasculinoPerfil.Location = new System.Drawing.Point(634, 292);
            this.rbMasculinoPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.rbMasculinoPerfil.Name = "rbMasculinoPerfil";
            this.rbMasculinoPerfil.Size = new System.Drawing.Size(93, 21);
            this.rbMasculinoPerfil.TabIndex = 114;
            this.rbMasculinoPerfil.TabStop = true;
            this.rbMasculinoPerfil.Text = "Masculino";
            this.rbMasculinoPerfil.UseVisualStyleBackColor = true;
            // 
            // lblSubirFoto
            // 
            this.lblSubirFoto.AutoSize = true;
            this.lblSubirFoto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubirFoto.Location = new System.Drawing.Point(189, 373);
            this.lblSubirFoto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubirFoto.Name = "lblSubirFoto";
            this.lblSubirFoto.Size = new System.Drawing.Size(90, 21);
            this.lblSubirFoto.TabIndex = 101;
            this.lblSubirFoto.Text = "Subir Foto";
            // 
            // btnRegresarPerfil
            // 
            this.btnRegresarPerfil.BackColor = System.Drawing.Color.LightBlue;
            this.btnRegresarPerfil.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarPerfil.Location = new System.Drawing.Point(32, 54);
            this.btnRegresarPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresarPerfil.Name = "btnRegresarPerfil";
            this.btnRegresarPerfil.Size = new System.Drawing.Size(77, 65);
            this.btnRegresarPerfil.TabIndex = 103;
            this.btnRegresarPerfil.Text = "<-";
            this.btnRegresarPerfil.UseVisualStyleBackColor = false;
            this.btnRegresarPerfil.Click += new System.EventHandler(this.btnRegresarPerfil_Click);
            // 
            // lblTituloEditarPerfil
            // 
            this.lblTituloEditarPerfil.AutoSize = true;
            this.lblTituloEditarPerfil.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEditarPerfil.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTituloEditarPerfil.Location = new System.Drawing.Point(454, 54);
            this.lblTituloEditarPerfil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloEditarPerfil.Name = "lblTituloEditarPerfil";
            this.lblTituloEditarPerfil.Size = new System.Drawing.Size(175, 37);
            this.lblTituloEditarPerfil.TabIndex = 104;
            this.lblTituloEditarPerfil.Text = "Editar Perfil";
            // 
            // dtpFechaNacimientoPerfil
            // 
            this.dtpFechaNacimientoPerfil.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimientoPerfil.Location = new System.Drawing.Point(634, 325);
            this.dtpFechaNacimientoPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaNacimientoPerfil.Name = "dtpFechaNacimientoPerfil";
            this.dtpFechaNacimientoPerfil.Size = new System.Drawing.Size(327, 23);
            this.dtpFechaNacimientoPerfil.TabIndex = 116;
            // 
            // btnSubirPerfil
            // 
            this.btnSubirPerfil.BackColor = System.Drawing.Color.Transparent;
            this.btnSubirPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirPerfil.ForeColor = System.Drawing.Color.Transparent;
            this.btnSubirPerfil.Image = global::AstreiaSoft.Properties.Resources.img_subir_151;
            this.btnSubirPerfil.Location = new System.Drawing.Point(278, 317);
            this.btnSubirPerfil.Margin = new System.Windows.Forms.Padding(1);
            this.btnSubirPerfil.Name = "btnSubirPerfil";
            this.btnSubirPerfil.Size = new System.Drawing.Size(41, 40);
            this.btnSubirPerfil.TabIndex = 119;
            this.btnSubirPerfil.UseVisualStyleBackColor = false;
            this.btnSubirPerfil.Click += new System.EventHandler(this.btnSubirPerfil_Click);
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(415, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 107;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(415, 257);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 21);
            this.label3.TabIndex = 108;
            this.label3.Text = "Apellido Materno:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(634, 161);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(153, 22);
            this.txtDNI.TabIndex = 110;
            // 
            // txtNombrePerfil
            // 
            this.txtNombrePerfil.Location = new System.Drawing.Point(634, 191);
            this.txtNombrePerfil.Name = "txtNombrePerfil";
            this.txtNombrePerfil.Size = new System.Drawing.Size(182, 22);
            this.txtNombrePerfil.TabIndex = 111;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(634, 223);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(252, 22);
            this.txtApellidoPaterno.TabIndex = 112;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Location = new System.Drawing.Point(634, 258);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(252, 22);
            this.txtApellidoMaterno.TabIndex = 113;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(634, 359);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(206, 22);
            this.txtTelefono.TabIndex = 117;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(634, 391);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(295, 22);
            this.txtDireccion.TabIndex = 118;
            // 
            // frmEditarPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 632);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApellidoMaterno);
            this.Controls.Add(this.txtApellidoPaterno);
            this.Controls.Add(this.txtNombrePerfil);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubirPerfil);
            this.Controls.Add(this.dtpFechaNacimientoPerfil);
            this.Controls.Add(this.lblTituloEditarPerfil);
            this.Controls.Add(this.btnRegresarPerfil);
            this.Controls.Add(this.lblSubirFoto);
            this.Controls.Add(this.rbFemeninoPerfil);
            this.Controls.Add(this.rbMasculinoPerfil);
            this.Controls.Add(this.btnGuardarPerfil);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblDNI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditarPerfil";
            this.Text = "frmEditarPerfil";
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Button btnGuardarPerfil;
        private System.Windows.Forms.RadioButton rbFemeninoPerfil;
        private System.Windows.Forms.RadioButton rbMasculinoPerfil;
        private System.Windows.Forms.Label lblSubirFoto;
        private System.Windows.Forms.Button btnRegresarPerfil;
        private System.Windows.Forms.Label lblTituloEditarPerfil;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimientoPerfil;
        private System.Windows.Forms.Button btnSubirPerfil;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombrePerfil;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
    }
}