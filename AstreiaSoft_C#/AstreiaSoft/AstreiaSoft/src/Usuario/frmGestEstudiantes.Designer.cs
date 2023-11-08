namespace AstreiaSoft
{
    partial class frmGestEstudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestEstudiantes));
            this.dtpFechaNacimientoEstudiante = new System.Windows.Forms.DateTimePicker();
            this.rbFemeninoEstudiante = new System.Windows.Forms.RadioButton();
            this.rbMasculinoEstudiante = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDEstudiante = new System.Windows.Forms.TextBox();
            this.lblIDEmpleado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbDatosGeneralesEstudiante = new System.Windows.Forms.GroupBox();
            this.txtDNIEstudiante = new System.Windows.Forms.TextBox();
            this.txtNombreEstudiante = new System.Windows.Forms.TextBox();
            this.txtApellidoPaternoEstudiante = new System.Windows.Forms.TextBox();
            this.txtApellidoMaternoEstudiante = new System.Windows.Forms.TextBox();
            this.txtTelefonoEstudiante = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccionEstudiante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbDatosAcademicosEstudiante = new System.Windows.Forms.GroupBox();
            this.txtContrasenhaEstudiante = new System.Windows.Forms.TextBox();
            this.txtCorreoEstudiante = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFoto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarEstudiante = new System.Windows.Forms.Button();
            this.btnNuevoEstudiante = new System.Windows.Forms.Button();
            this.btnEliminarEstudiante = new System.Windows.Forms.Button();
            this.btnBuscarEstudiante = new System.Windows.Forms.Button();
            this.btnEditarEstudiante = new System.Windows.Forms.Button();
            this.btnGuardarEstudiante = new System.Windows.Forms.Button();
            this.pbFotoEstudiante = new System.Windows.Forms.PictureBox();
            this.btnSubirFotoEstudiante = new System.Windows.Forms.Button();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.gbDatosGeneralesEstudiante.SuspendLayout();
            this.gbDatosAcademicosEstudiante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoEstudiante)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaNacimientoEstudiante
            // 
            this.dtpFechaNacimientoEstudiante.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimientoEstudiante.Location = new System.Drawing.Point(185, 230);
            this.dtpFechaNacimientoEstudiante.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaNacimientoEstudiante.Name = "dtpFechaNacimientoEstudiante";
            this.dtpFechaNacimientoEstudiante.Size = new System.Drawing.Size(294, 23);
            this.dtpFechaNacimientoEstudiante.TabIndex = 37;
            // 
            // rbFemeninoEstudiante
            // 
            this.rbFemeninoEstudiante.AutoSize = true;
            this.rbFemeninoEstudiante.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemeninoEstudiante.Location = new System.Drawing.Point(300, 201);
            this.rbFemeninoEstudiante.Margin = new System.Windows.Forms.Padding(4);
            this.rbFemeninoEstudiante.Name = "rbFemeninoEstudiante";
            this.rbFemeninoEstudiante.Size = new System.Drawing.Size(92, 21);
            this.rbFemeninoEstudiante.TabIndex = 36;
            this.rbFemeninoEstudiante.TabStop = true;
            this.rbFemeninoEstudiante.Text = "Femenino";
            this.rbFemeninoEstudiante.UseVisualStyleBackColor = true;
            // 
            // rbMasculinoEstudiante
            // 
            this.rbMasculinoEstudiante.AutoSize = true;
            this.rbMasculinoEstudiante.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasculinoEstudiante.Location = new System.Drawing.Point(186, 201);
            this.rbMasculinoEstudiante.Margin = new System.Windows.Forms.Padding(4);
            this.rbMasculinoEstudiante.Name = "rbMasculinoEstudiante";
            this.rbMasculinoEstudiante.Size = new System.Drawing.Size(93, 21);
            this.rbMasculinoEstudiante.TabIndex = 35;
            this.rbMasculinoEstudiante.TabStop = true;
            this.rbMasculinoEstudiante.Text = "Masculino";
            this.rbMasculinoEstudiante.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(419, 66);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(231, 23);
            this.label9.TabIndex = 31;
            this.label9.Text = "Gestión de Estudiantes";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(25, 235);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(152, 17);
            this.lblFechaNacimiento.TabIndex = 28;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(117, 203);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(60, 17);
            this.lblGenero.TabIndex = 27;
            this.lblGenero.Text = "Género:";
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoPaterno.Location = new System.Drawing.Point(57, 142);
            this.lblApellidoPaterno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(120, 17);
            this.lblApellidoPaterno.TabIndex = 26;
            this.lblApellidoPaterno.Text = "Apellido Paterno:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(112, 111);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 17);
            this.lblNombre.TabIndex = 25;
            this.lblNombre.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "DNI:";
            // 
            // txtIDEstudiante
            // 
            this.txtIDEstudiante.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDEstudiante.Location = new System.Drawing.Point(185, 43);
            this.txtIDEstudiante.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDEstudiante.Name = "txtIDEstudiante";
            this.txtIDEstudiante.ReadOnly = true;
            this.txtIDEstudiante.Size = new System.Drawing.Size(73, 26);
            this.txtIDEstudiante.TabIndex = 23;
            // 
            // lblIDEmpleado
            // 
            this.lblIDEmpleado.AutoSize = true;
            this.lblIDEmpleado.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDEmpleado.Location = new System.Drawing.Point(152, 49);
            this.lblIDEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDEmpleado.Name = "lblIDEmpleado";
            this.lblIDEmpleado.Size = new System.Drawing.Size(25, 17);
            this.lblIDEmpleado.TabIndex = 22;
            this.lblIDEmpleado.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Apellido Materno:";
            // 
            // gbDatosGeneralesEstudiante
            // 
            this.gbDatosGeneralesEstudiante.Controls.Add(this.txtDNIEstudiante);
            this.gbDatosGeneralesEstudiante.Controls.Add(this.txtNombreEstudiante);
            this.gbDatosGeneralesEstudiante.Controls.Add(this.txtApellidoPaternoEstudiante);
            this.gbDatosGeneralesEstudiante.Controls.Add(this.txtApellidoMaternoEstudiante);
            this.gbDatosGeneralesEstudiante.Controls.Add(this.txtTelefonoEstudiante);
            this.gbDatosGeneralesEstudiante.Controls.Add(this.label5);
            this.gbDatosGeneralesEstudiante.Controls.Add(this.txtDireccionEstudiante);
            this.gbDatosGeneralesEstudiante.Controls.Add(this.label4);
            this.gbDatosGeneralesEstudiante.Controls.Add(this.lblIDEmpleado);
            this.gbDatosGeneralesEstudiante.Controls.Add(this.txtIDEstudiante);
            this.gbDatosGeneralesEstudiante.Controls.Add(this.label3);
            this.gbDatosGeneralesEstudiante.Controls.Add(this.label2);
            this.gbDatosGeneralesEstudiante.Controls.Add(this.lblNombre);
            this.gbDatosGeneralesEstudiante.Controls.Add(this.lblApellidoPaterno);
            this.gbDatosGeneralesEstudiante.Controls.Add(this.dtpFechaNacimientoEstudiante);
            this.gbDatosGeneralesEstudiante.Controls.Add(this.lblGenero);
            this.gbDatosGeneralesEstudiante.Controls.Add(this.rbFemeninoEstudiante);
            this.gbDatosGeneralesEstudiante.Controls.Add(this.lblFechaNacimiento);
            this.gbDatosGeneralesEstudiante.Controls.Add(this.rbMasculinoEstudiante);
            this.gbDatosGeneralesEstudiante.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosGeneralesEstudiante.Location = new System.Drawing.Point(17, 93);
            this.gbDatosGeneralesEstudiante.Margin = new System.Windows.Forms.Padding(4);
            this.gbDatosGeneralesEstudiante.Name = "gbDatosGeneralesEstudiante";
            this.gbDatosGeneralesEstudiante.Padding = new System.Windows.Forms.Padding(4);
            this.gbDatosGeneralesEstudiante.Size = new System.Drawing.Size(520, 345);
            this.gbDatosGeneralesEstudiante.TabIndex = 44;
            this.gbDatosGeneralesEstudiante.TabStop = false;
            this.gbDatosGeneralesEstudiante.Text = "Datos Generales";
            // 
            // txtDNIEstudiante
            // 
            this.txtDNIEstudiante.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNIEstudiante.Location = new System.Drawing.Point(185, 77);
            this.txtDNIEstudiante.Margin = new System.Windows.Forms.Padding(4);
            this.txtDNIEstudiante.Name = "txtDNIEstudiante";
            this.txtDNIEstudiante.Size = new System.Drawing.Size(176, 23);
            this.txtDNIEstudiante.TabIndex = 52;
            // 
            // txtNombreEstudiante
            // 
            this.txtNombreEstudiante.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEstudiante.Location = new System.Drawing.Point(185, 108);
            this.txtNombreEstudiante.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreEstudiante.Name = "txtNombreEstudiante";
            this.txtNombreEstudiante.Size = new System.Drawing.Size(294, 23);
            this.txtNombreEstudiante.TabIndex = 51;
            // 
            // txtApellidoPaternoEstudiante
            // 
            this.txtApellidoPaternoEstudiante.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoPaternoEstudiante.Location = new System.Drawing.Point(185, 139);
            this.txtApellidoPaternoEstudiante.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoPaternoEstudiante.Name = "txtApellidoPaternoEstudiante";
            this.txtApellidoPaternoEstudiante.Size = new System.Drawing.Size(294, 23);
            this.txtApellidoPaternoEstudiante.TabIndex = 50;
            // 
            // txtApellidoMaternoEstudiante
            // 
            this.txtApellidoMaternoEstudiante.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoMaternoEstudiante.Location = new System.Drawing.Point(185, 170);
            this.txtApellidoMaternoEstudiante.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoMaternoEstudiante.Name = "txtApellidoMaternoEstudiante";
            this.txtApellidoMaternoEstudiante.Size = new System.Drawing.Size(294, 23);
            this.txtApellidoMaternoEstudiante.TabIndex = 49;
            // 
            // txtTelefonoEstudiante
            // 
            this.txtTelefonoEstudiante.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoEstudiante.Location = new System.Drawing.Point(186, 261);
            this.txtTelefonoEstudiante.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoEstudiante.Name = "txtTelefonoEstudiante";
            this.txtTelefonoEstudiante.Size = new System.Drawing.Size(293, 23);
            this.txtTelefonoEstudiante.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 295);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 46;
            this.label5.Text = "Dirección:";
            // 
            // txtDireccionEstudiante
            // 
            this.txtDireccionEstudiante.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionEstudiante.Location = new System.Drawing.Point(186, 292);
            this.txtDireccionEstudiante.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccionEstudiante.Name = "txtDireccionEstudiante";
            this.txtDireccionEstudiante.Size = new System.Drawing.Size(293, 23);
            this.txtDireccionEstudiante.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 264);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Telefono:";
            // 
            // gbDatosAcademicosEstudiante
            // 
            this.gbDatosAcademicosEstudiante.Controls.Add(this.txtContrasenhaEstudiante);
            this.gbDatosAcademicosEstudiante.Controls.Add(this.txtCorreoEstudiante);
            this.gbDatosAcademicosEstudiante.Controls.Add(this.label7);
            this.gbDatosAcademicosEstudiante.Controls.Add(this.label6);
            this.gbDatosAcademicosEstudiante.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosAcademicosEstudiante.Location = new System.Drawing.Point(550, 294);
            this.gbDatosAcademicosEstudiante.Name = "gbDatosAcademicosEstudiante";
            this.gbDatosAcademicosEstudiante.Size = new System.Drawing.Size(475, 144);
            this.gbDatosAcademicosEstudiante.TabIndex = 45;
            this.gbDatosAcademicosEstudiante.TabStop = false;
            this.gbDatosAcademicosEstudiante.Text = "Datos Académicos";
            // 
            // txtContrasenhaEstudiante
            // 
            this.txtContrasenhaEstudiante.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenhaEstudiante.Location = new System.Drawing.Point(147, 81);
            this.txtContrasenhaEstudiante.Margin = new System.Windows.Forms.Padding(4);
            this.txtContrasenhaEstudiante.Name = "txtContrasenhaEstudiante";
            this.txtContrasenhaEstudiante.Size = new System.Drawing.Size(279, 23);
            this.txtContrasenhaEstudiante.TabIndex = 55;
            // 
            // txtCorreoEstudiante
            // 
            this.txtCorreoEstudiante.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoEstudiante.Location = new System.Drawing.Point(147, 50);
            this.txtCorreoEstudiante.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreoEstudiante.Name = "txtCorreoEstudiante";
            this.txtCorreoEstudiante.Size = new System.Drawing.Size(279, 23);
            this.txtCorreoEstudiante.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 50;
            this.label7.Text = "Contraseña:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(82, 51);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 48;
            this.label6.Text = "Correo:";
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.Location = new System.Drawing.Point(669, 107);
            this.lblFoto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(44, 26);
            this.lblFoto.TabIndex = 59;
            this.lblFoto.Text = "Foto";
            this.lblFoto.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(669, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 53);
            this.label1.TabIndex = 69;
            this.label1.Text = "El sistema solo\r\nacepta\r\nformato .jpg\r\n";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // btnCancelarEstudiante
            // 
            this.btnCancelarEstudiante.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarEstudiante.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarEstudiante.Image = global::AstreiaSoft.Properties.Resources.img_cancelar_17;
            this.btnCancelarEstudiante.Location = new System.Drawing.Point(596, 12);
            this.btnCancelarEstudiante.Name = "btnCancelarEstudiante";
            this.btnCancelarEstudiante.Size = new System.Drawing.Size(140, 39);
            this.btnCancelarEstudiante.TabIndex = 68;
            this.btnCancelarEstudiante.Text = "Cancelar";
            this.btnCancelarEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarEstudiante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarEstudiante.UseVisualStyleBackColor = false;
            this.btnCancelarEstudiante.Click += new System.EventHandler(this.btnCancelarEstudiante_Click);
            // 
            // btnNuevoEstudiante
            // 
            this.btnNuevoEstudiante.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevoEstudiante.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoEstudiante.Image = global::AstreiaSoft.Properties.Resources.img_nuevo_17;
            this.btnNuevoEstudiante.Location = new System.Drawing.Point(12, 12);
            this.btnNuevoEstudiante.Name = "btnNuevoEstudiante";
            this.btnNuevoEstudiante.Size = new System.Drawing.Size(140, 39);
            this.btnNuevoEstudiante.TabIndex = 66;
            this.btnNuevoEstudiante.Text = "Nuevo";
            this.btnNuevoEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoEstudiante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoEstudiante.UseVisualStyleBackColor = false;
            this.btnNuevoEstudiante.Click += new System.EventHandler(this.btnNuevoEstudiante_Click);
            // 
            // btnEliminarEstudiante
            // 
            this.btnEliminarEstudiante.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarEstudiante.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEstudiante.Image = global::AstreiaSoft.Properties.Resources.img_eliminar_17;
            this.btnEliminarEstudiante.Location = new System.Drawing.Point(908, 12);
            this.btnEliminarEstudiante.Name = "btnEliminarEstudiante";
            this.btnEliminarEstudiante.Size = new System.Drawing.Size(140, 39);
            this.btnEliminarEstudiante.TabIndex = 65;
            this.btnEliminarEstudiante.Text = "Eliminar";
            this.btnEliminarEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarEstudiante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarEstudiante.UseVisualStyleBackColor = false;
            this.btnEliminarEstudiante.Click += new System.EventHandler(this.btnEliminarEstudiante_Click);
            // 
            // btnBuscarEstudiante
            // 
            this.btnBuscarEstudiante.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarEstudiante.FlatAppearance.BorderSize = 0;
            this.btnBuscarEstudiante.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEstudiante.Image = global::AstreiaSoft.Properties.Resources.img_buscar_17;
            this.btnBuscarEstudiante.Location = new System.Drawing.Point(450, 12);
            this.btnBuscarEstudiante.Name = "btnBuscarEstudiante";
            this.btnBuscarEstudiante.Size = new System.Drawing.Size(140, 39);
            this.btnBuscarEstudiante.TabIndex = 64;
            this.btnBuscarEstudiante.Text = "Buscar";
            this.btnBuscarEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarEstudiante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarEstudiante.UseVisualStyleBackColor = false;
            this.btnBuscarEstudiante.Click += new System.EventHandler(this.btnBuscarEstudiante_Click);
            // 
            // btnEditarEstudiante
            // 
            this.btnEditarEstudiante.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarEstudiante.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarEstudiante.Image = global::AstreiaSoft.Properties.Resources.img_editar_17;
            this.btnEditarEstudiante.Location = new System.Drawing.Point(304, 12);
            this.btnEditarEstudiante.Name = "btnEditarEstudiante";
            this.btnEditarEstudiante.Size = new System.Drawing.Size(140, 39);
            this.btnEditarEstudiante.TabIndex = 63;
            this.btnEditarEstudiante.Text = "Editar";
            this.btnEditarEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarEstudiante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarEstudiante.UseVisualStyleBackColor = false;
            this.btnEditarEstudiante.Click += new System.EventHandler(this.btnEditarEstudiante_Click);
            // 
            // btnGuardarEstudiante
            // 
            this.btnGuardarEstudiante.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarEstudiante.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEstudiante.Image = global::AstreiaSoft.Properties.Resources.img_guardar_17;
            this.btnGuardarEstudiante.Location = new System.Drawing.Point(158, 12);
            this.btnGuardarEstudiante.Name = "btnGuardarEstudiante";
            this.btnGuardarEstudiante.Size = new System.Drawing.Size(140, 39);
            this.btnGuardarEstudiante.TabIndex = 62;
            this.btnGuardarEstudiante.Text = "Guardar";
            this.btnGuardarEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarEstudiante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarEstudiante.UseVisualStyleBackColor = false;
            this.btnGuardarEstudiante.Click += new System.EventHandler(this.btnGuardarEstudiante_Click);
            // 
            // pbFotoEstudiante
            // 
            this.pbFotoEstudiante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFotoEstudiante.Location = new System.Drawing.Point(800, 104);
            this.pbFotoEstudiante.Margin = new System.Windows.Forms.Padding(4);
            this.pbFotoEstudiante.Name = "pbFotoEstudiante";
            this.pbFotoEstudiante.Size = new System.Drawing.Size(142, 166);
            this.pbFotoEstudiante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoEstudiante.TabIndex = 60;
            this.pbFotoEstudiante.TabStop = false;
            // 
            // btnSubirFotoEstudiante
            // 
            this.btnSubirFotoEstudiante.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubirFotoEstudiante.BackgroundImage")));
            this.btnSubirFotoEstudiante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubirFotoEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirFotoEstudiante.Location = new System.Drawing.Point(906, 235);
            this.btnSubirFotoEstudiante.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubirFotoEstudiante.Name = "btnSubirFotoEstudiante";
            this.btnSubirFotoEstudiante.Size = new System.Drawing.Size(36, 35);
            this.btnSubirFotoEstudiante.TabIndex = 79;
            this.btnSubirFotoEstudiante.UseVisualStyleBackColor = true;
            this.btnSubirFotoEstudiante.Click += new System.EventHandler(this.btnSubirFotoEstudiante_Click);
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            // 
            // frmGestEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 450);
            this.Controls.Add(this.btnSubirFotoEstudiante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelarEstudiante);
            this.Controls.Add(this.btnNuevoEstudiante);
            this.Controls.Add(this.btnEliminarEstudiante);
            this.Controls.Add(this.btnBuscarEstudiante);
            this.Controls.Add(this.btnEditarEstudiante);
            this.Controls.Add(this.btnGuardarEstudiante);
            this.Controls.Add(this.pbFotoEstudiante);
            this.Controls.Add(this.lblFoto);
            this.Controls.Add(this.gbDatosAcademicosEstudiante);
            this.Controls.Add(this.gbDatosGeneralesEstudiante);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestEstudiantes";
            this.gbDatosGeneralesEstudiante.ResumeLayout(false);
            this.gbDatosGeneralesEstudiante.PerformLayout();
            this.gbDatosAcademicosEstudiante.ResumeLayout(false);
            this.gbDatosAcademicosEstudiante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoEstudiante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpFechaNacimientoEstudiante;
        private System.Windows.Forms.RadioButton rbFemeninoEstudiante;
        private System.Windows.Forms.RadioButton rbMasculinoEstudiante;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDEstudiante;
        private System.Windows.Forms.Label lblIDEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbDatosGeneralesEstudiante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDireccionEstudiante;
        private System.Windows.Forms.GroupBox gbDatosAcademicosEstudiante;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDNIEstudiante;
        private System.Windows.Forms.TextBox txtNombreEstudiante;
        private System.Windows.Forms.TextBox txtApellidoPaternoEstudiante;
        private System.Windows.Forms.TextBox txtApellidoMaternoEstudiante;
        private System.Windows.Forms.TextBox txtTelefonoEstudiante;
        private System.Windows.Forms.TextBox txtContrasenhaEstudiante;
        private System.Windows.Forms.TextBox txtCorreoEstudiante;
        private System.Windows.Forms.PictureBox pbFotoEstudiante;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Button btnCancelarEstudiante;
        private System.Windows.Forms.Button btnNuevoEstudiante;
        private System.Windows.Forms.Button btnEliminarEstudiante;
        private System.Windows.Forms.Button btnBuscarEstudiante;
        private System.Windows.Forms.Button btnEditarEstudiante;
        private System.Windows.Forms.Button btnGuardarEstudiante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubirFotoEstudiante;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
    }
}