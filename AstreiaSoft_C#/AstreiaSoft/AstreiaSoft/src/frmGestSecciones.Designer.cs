namespace AstreiaSoft
{
    partial class frmGestSecciones
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
            this.ofdSeccion = new System.Windows.Forms.OpenFileDialog();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tcSeccion = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbSeccion = new System.Windows.Forms.GroupBox();
            this.lbImagen = new System.Windows.Forms.Label();
            this.rbSecD = new System.Windows.Forms.RadioButton();
            this.rbSecC = new System.Windows.Forms.RadioButton();
            this.rbSecB = new System.Windows.Forms.RadioButton();
            this.rbSecA = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdSeccion = new System.Windows.Forms.TextBox();
            this.lblGrado = new System.Windows.Forms.Label();
            this.cboGrado = new System.Windows.Forms.ComboBox();
            this.lblIdSeccion = new System.Windows.Forms.Label();
            this.dgvSecciones = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbSeccionAsig = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvEstudiantesSeccion = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEstudiantesGrado = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeccionEst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboSeccionAsig = new System.Windows.Forms.ComboBox();
            this.cboGradoAsig = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSubir = new System.Windows.Forms.Button();
            this.pbSeccion = new System.Windows.Forms.PictureBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGuardarAsig = new System.Windows.Forms.Button();
            this.tcSeccion.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbSeccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecciones)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantesSeccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantesGrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeccion)).BeginInit();
            this.SuspendLayout();
            // 
            // ofdSeccion
            // 
            this.ofdSeccion.FileName = "ofdSeccion";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 653);
            this.splitter1.TabIndex = 14;
            this.splitter1.TabStop = false;
            // 
            // tcSeccion
            // 
            this.tcSeccion.Controls.Add(this.tabPage1);
            this.tcSeccion.Controls.Add(this.tabPage2);
            this.tcSeccion.Location = new System.Drawing.Point(12, 20);
            this.tcSeccion.Name = "tcSeccion";
            this.tcSeccion.SelectedIndex = 0;
            this.tcSeccion.Size = new System.Drawing.Size(1058, 600);
            this.tcSeccion.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Controls.Add(this.btnSeleccionar);
            this.tabPage1.Controls.Add(this.btnNuevo);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.btnEditar);
            this.tabPage1.Controls.Add(this.btnGuardar);
            this.tabPage1.Controls.Add(this.gbSeccion);
            this.tabPage1.Controls.Add(this.dgvSecciones);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1050, 571);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gestionar Sección";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // gbSeccion
            // 
            this.gbSeccion.Controls.Add(this.lbImagen);
            this.gbSeccion.Controls.Add(this.btnSubir);
            this.gbSeccion.Controls.Add(this.pbSeccion);
            this.gbSeccion.Controls.Add(this.rbSecD);
            this.gbSeccion.Controls.Add(this.rbSecC);
            this.gbSeccion.Controls.Add(this.rbSecB);
            this.gbSeccion.Controls.Add(this.rbSecA);
            this.gbSeccion.Controls.Add(this.label1);
            this.gbSeccion.Controls.Add(this.txtIdSeccion);
            this.gbSeccion.Controls.Add(this.lblGrado);
            this.gbSeccion.Controls.Add(this.cboGrado);
            this.gbSeccion.Controls.Add(this.lblIdSeccion);
            this.gbSeccion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSeccion.Location = new System.Drawing.Point(18, 96);
            this.gbSeccion.Name = "gbSeccion";
            this.gbSeccion.Size = new System.Drawing.Size(502, 293);
            this.gbSeccion.TabIndex = 12;
            this.gbSeccion.TabStop = false;
            this.gbSeccion.Text = "Sección";
            // 
            // lbImagen
            // 
            this.lbImagen.AutoSize = true;
            this.lbImagen.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImagen.Location = new System.Drawing.Point(20, 205);
            this.lbImagen.Name = "lbImagen";
            this.lbImagen.Size = new System.Drawing.Size(84, 21);
            this.lbImagen.TabIndex = 22;
            this.lbImagen.Text = "Imagen :";
            // 
            // rbSecD
            // 
            this.rbSecD.AutoSize = true;
            this.rbSecD.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSecD.Location = new System.Drawing.Point(266, 161);
            this.rbSecD.Name = "rbSecD";
            this.rbSecD.Size = new System.Drawing.Size(114, 25);
            this.rbSecD.TabIndex = 18;
            this.rbSecD.TabStop = true;
            this.rbSecD.Text = "Sección D";
            this.rbSecD.UseVisualStyleBackColor = true;
            // 
            // rbSecC
            // 
            this.rbSecC.AutoSize = true;
            this.rbSecC.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSecC.Location = new System.Drawing.Point(120, 161);
            this.rbSecC.Name = "rbSecC";
            this.rbSecC.Size = new System.Drawing.Size(115, 25);
            this.rbSecC.TabIndex = 17;
            this.rbSecC.TabStop = true;
            this.rbSecC.Text = "Sección C";
            this.rbSecC.UseVisualStyleBackColor = true;
            // 
            // rbSecB
            // 
            this.rbSecB.AutoSize = true;
            this.rbSecB.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSecB.Location = new System.Drawing.Point(266, 133);
            this.rbSecB.Name = "rbSecB";
            this.rbSecB.Size = new System.Drawing.Size(111, 25);
            this.rbSecB.TabIndex = 16;
            this.rbSecB.TabStop = true;
            this.rbSecB.Text = "Sección B";
            this.rbSecB.UseVisualStyleBackColor = true;
            // 
            // rbSecA
            // 
            this.rbSecA.AutoSize = true;
            this.rbSecA.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSecA.Location = new System.Drawing.Point(120, 130);
            this.rbSecA.Name = "rbSecA";
            this.rbSecA.Size = new System.Drawing.Size(114, 25);
            this.rbSecA.TabIndex = 15;
            this.rbSecA.TabStop = true;
            this.rbSecA.Text = "Sección A";
            this.rbSecA.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre :";
            // 
            // txtIdSeccion
            // 
            this.txtIdSeccion.Location = new System.Drawing.Point(123, 37);
            this.txtIdSeccion.Name = "txtIdSeccion";
            this.txtIdSeccion.Size = new System.Drawing.Size(148, 28);
            this.txtIdSeccion.TabIndex = 8;
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrado.Location = new System.Drawing.Point(32, 85);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(75, 21);
            this.lblGrado.TabIndex = 5;
            this.lblGrado.Text = "Grado :";
            // 
            // cboGrado
            // 
            this.cboGrado.FormattingEnabled = true;
            this.cboGrado.Location = new System.Drawing.Point(123, 82);
            this.cboGrado.Name = "cboGrado";
            this.cboGrado.Size = new System.Drawing.Size(358, 29);
            this.cboGrado.TabIndex = 6;
            this.cboGrado.SelectedIndexChanged += new System.EventHandler(this.cboGrado_SelectedIndexChanged_1);
            // 
            // lblIdSeccion
            // 
            this.lblIdSeccion.AutoSize = true;
            this.lblIdSeccion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdSeccion.Location = new System.Drawing.Point(69, 45);
            this.lblIdSeccion.Name = "lblIdSeccion";
            this.lblIdSeccion.Size = new System.Drawing.Size(38, 21);
            this.lblIdSeccion.TabIndex = 7;
            this.lblIdSeccion.Text = "ID :";
            // 
            // dgvSecciones
            // 
            this.dgvSecciones.AllowUserToAddRows = false;
            this.dgvSecciones.AllowUserToDeleteRows = false;
            this.dgvSecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSecciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Grado,
            this.Seccion,
            this.Nivel});
            this.dgvSecciones.Location = new System.Drawing.Point(543, 106);
            this.dgvSecciones.Name = "dgvSecciones";
            this.dgvSecciones.RowHeadersWidth = 51;
            this.dgvSecciones.RowTemplate.Height = 24;
            this.dgvSecciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSecciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSecciones.Size = new System.Drawing.Size(490, 283);
            this.dgvSecciones.TabIndex = 11;
            this.dgvSecciones.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSecciones_CellFormatting_1);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 20;
            this.ID.Name = "ID";
            this.ID.Width = 40;
            // 
            // Grado
            // 
            this.Grado.HeaderText = "Grado";
            this.Grado.MinimumWidth = 6;
            this.Grado.Name = "Grado";
            this.Grado.Width = 125;
            // 
            // Seccion
            // 
            this.Seccion.HeaderText = "Seccion";
            this.Seccion.MinimumWidth = 6;
            this.Seccion.Name = "Seccion";
            this.Seccion.Width = 125;
            // 
            // Nivel
            // 
            this.Nivel.HeaderText = "Nivel";
            this.Nivel.MinimumWidth = 6;
            this.Nivel.Name = "Nivel";
            this.Nivel.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.btnQuitar);
            this.tabPage2.Controls.Add(this.btnAgregar);
            this.tabPage2.Controls.Add(this.lbSeccionAsig);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dgvEstudiantesSeccion);
            this.tabPage2.Controls.Add(this.dgvEstudiantesGrado);
            this.tabPage2.Controls.Add(this.cboSeccionAsig);
            this.tabPage2.Controls.Add(this.cboGradoAsig);
            this.tabPage2.Controls.Add(this.btnGuardarAsig);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1050, 571);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Asignar Estudiantes";
            // 
            // lbSeccionAsig
            // 
            this.lbSeccionAsig.AutoSize = true;
            this.lbSeccionAsig.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeccionAsig.Location = new System.Drawing.Point(630, 77);
            this.lbSeccionAsig.Name = "lbSeccionAsig";
            this.lbSeccionAsig.Size = new System.Drawing.Size(85, 21);
            this.lbSeccionAsig.TabIndex = 35;
            this.lbSeccionAsig.Text = "Sección :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Grado :";
            // 
            // dgvEstudiantesSeccion
            // 
            this.dgvEstudiantesSeccion.AllowUserToAddRows = false;
            this.dgvEstudiantesSeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantesSeccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.NombreCompleto2});
            this.dgvEstudiantesSeccion.Location = new System.Drawing.Point(602, 127);
            this.dgvEstudiantesSeccion.Name = "dgvEstudiantesSeccion";
            this.dgvEstudiantesSeccion.RowHeadersWidth = 51;
            this.dgvEstudiantesSeccion.RowTemplate.Height = 24;
            this.dgvEstudiantesSeccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstudiantesSeccion.Size = new System.Drawing.Size(431, 410);
            this.dgvEstudiantesSeccion.TabIndex = 33;
            this.dgvEstudiantesSeccion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstudiantesSeccion_CellClick);
            this.dgvEstudiantesSeccion.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEstudiantesSeccion_CellFormatting);
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Número";
            this.Numero.MinimumWidth = 6;
            this.Numero.Name = "Numero";
            this.Numero.Width = 125;
            // 
            // NombreCompleto2
            // 
            this.NombreCompleto2.HeaderText = "Nombre completo";
            this.NombreCompleto2.MinimumWidth = 6;
            this.NombreCompleto2.Name = "NombreCompleto2";
            this.NombreCompleto2.Width = 180;
            // 
            // dgvEstudiantesGrado
            // 
            this.dgvEstudiantesGrado.AllowUserToAddRows = false;
            this.dgvEstudiantesGrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantesGrado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.NombreCompleto,
            this.SeccionEst});
            this.dgvEstudiantesGrado.Location = new System.Drawing.Point(19, 127);
            this.dgvEstudiantesGrado.Name = "dgvEstudiantesGrado";
            this.dgvEstudiantesGrado.RowHeadersWidth = 51;
            this.dgvEstudiantesGrado.RowTemplate.Height = 24;
            this.dgvEstudiantesGrado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstudiantesGrado.Size = new System.Drawing.Size(431, 410);
            this.dgvEstudiantesGrado.TabIndex = 32;
            this.dgvEstudiantesGrado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstudiantesGrado_CellClick);
            this.dgvEstudiantesGrado.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEstudiantesGrado_CellFormatting);
            // 
            // Num
            // 
            this.Num.FillWeight = 30F;
            this.Num.HeaderText = "Num";
            this.Num.MinimumWidth = 6;
            this.Num.Name = "Num";
            this.Num.Width = 50;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.FillWeight = 125F;
            this.NombreCompleto.HeaderText = "Nombre completo";
            this.NombreCompleto.MinimumWidth = 6;
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.Width = 150;
            // 
            // SeccionEst
            // 
            this.SeccionEst.FillWeight = 80F;
            this.SeccionEst.HeaderText = "Sección";
            this.SeccionEst.MinimumWidth = 6;
            this.SeccionEst.Name = "SeccionEst";
            this.SeccionEst.Width = 125;
            // 
            // cboSeccionAsig
            // 
            this.cboSeccionAsig.FormattingEnabled = true;
            this.cboSeccionAsig.Location = new System.Drawing.Point(727, 74);
            this.cboSeccionAsig.Name = "cboSeccionAsig";
            this.cboSeccionAsig.Size = new System.Drawing.Size(303, 24);
            this.cboSeccionAsig.TabIndex = 31;
            this.cboSeccionAsig.SelectedIndexChanged += new System.EventHandler(this.cboSeccionAsig_SelectedIndexChanged);
            // 
            // cboGradoAsig
            // 
            this.cboGradoAsig.FormattingEnabled = true;
            this.cboGradoAsig.Location = new System.Drawing.Point(147, 80);
            this.cboGradoAsig.Name = "cboGradoAsig";
            this.cboGradoAsig.Size = new System.Drawing.Size(303, 24);
            this.cboGradoAsig.TabIndex = 30;
            this.cboGradoAsig.SelectedIndexChanged += new System.EventHandler(this.cboGradoAsig_SelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::AstreiaSoft.Properties.Resources.img_cancelar_17;
            this.btnCancelar.Location = new System.Drawing.Point(893, 27);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 40);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Image = global::AstreiaSoft.Properties.Resources.img_seleccionar_17;
            this.btnSeleccionar.Location = new System.Drawing.Point(747, 27);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(140, 40);
            this.btnSeleccionar.TabIndex = 19;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click_1);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = global::AstreiaSoft.Properties.Resources.img_nuevo_17;
            this.btnNuevo.Location = new System.Drawing.Point(18, 27);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(140, 40);
            this.btnNuevo.TabIndex = 18;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::AstreiaSoft.Properties.Resources.img_eliminar_17;
            this.btnEliminar.Location = new System.Drawing.Point(601, 27);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(140, 40);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::AstreiaSoft.Properties.Resources.img_buscar_17;
            this.btnBuscar.Location = new System.Drawing.Point(455, 27);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(140, 40);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::AstreiaSoft.Properties.Resources.img_editar_17;
            this.btnEditar.Location = new System.Drawing.Point(309, 27);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(140, 40);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::AstreiaSoft.Properties.Resources.img_guardar_17;
            this.btnGuardar.Location = new System.Drawing.Point(164, 27);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 40);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSubir
            // 
            this.btnSubir.BackColor = System.Drawing.Color.Transparent;
            this.btnSubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubir.ForeColor = System.Drawing.Color.Transparent;
            this.btnSubir.Image = global::AstreiaSoft.Properties.Resources.img_subir_151;
            this.btnSubir.Location = new System.Drawing.Point(176, 255);
            this.btnSubir.Margin = new System.Windows.Forms.Padding(1);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(25, 25);
            this.btnSubir.TabIndex = 21;
            this.btnSubir.UseVisualStyleBackColor = false;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click_1);
            // 
            // pbSeccion
            // 
            this.pbSeccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSeccion.Location = new System.Drawing.Point(123, 205);
            this.pbSeccion.Name = "pbSeccion";
            this.pbSeccion.Size = new System.Drawing.Size(80, 80);
            this.pbSeccion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSeccion.TabIndex = 20;
            this.pbSeccion.TabStop = false;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Image = global::AstreiaSoft.Properties.Resources.img_quitar_17;
            this.btnQuitar.Location = new System.Drawing.Point(456, 255);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(140, 40);
            this.btnQuitar.TabIndex = 37;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::AstreiaSoft.Properties.Resources.img_agregar_17;
            this.btnAgregar.Location = new System.Drawing.Point(456, 209);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(140, 40);
            this.btnAgregar.TabIndex = 36;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGuardarAsig
            // 
            this.btnGuardarAsig.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarAsig.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAsig.Image = global::AstreiaSoft.Properties.Resources.img_guardar_17;
            this.btnGuardarAsig.Location = new System.Drawing.Point(19, 20);
            this.btnGuardarAsig.Name = "btnGuardarAsig";
            this.btnGuardarAsig.Size = new System.Drawing.Size(140, 40);
            this.btnGuardarAsig.TabIndex = 23;
            this.btnGuardarAsig.Text = "Guardar";
            this.btnGuardarAsig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarAsig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarAsig.UseVisualStyleBackColor = false;
            this.btnGuardarAsig.Click += new System.EventHandler(this.btnGuardarAsig_Click);
            // 
            // frmGestSecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1086, 653);
            this.Controls.Add(this.tcSeccion);
            this.Controls.Add(this.splitter1);
            this.Name = "frmGestSecciones";
            this.Text = "frmGestSecciones";
            this.tcSeccion.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbSeccion.ResumeLayout(false);
            this.gbSeccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecciones)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantesSeccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantesGrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeccion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofdSeccion;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabControl tcSeccion;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gbSeccion;
        private System.Windows.Forms.Label lbImagen;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.PictureBox pbSeccion;
        private System.Windows.Forms.RadioButton rbSecD;
        private System.Windows.Forms.RadioButton rbSecC;
        private System.Windows.Forms.RadioButton rbSecB;
        private System.Windows.Forms.RadioButton rbSecA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdSeccion;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.ComboBox cboGrado;
        private System.Windows.Forms.Label lblIdSeccion;
        private System.Windows.Forms.DataGridView dgvSecciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nivel;
        private System.Windows.Forms.Button btnGuardarAsig;
        private System.Windows.Forms.ComboBox cboSeccionAsig;
        private System.Windows.Forms.ComboBox cboGradoAsig;
        private System.Windows.Forms.DataGridView dgvEstudiantesSeccion;
        private System.Windows.Forms.DataGridView dgvEstudiantesGrado;
        private System.Windows.Forms.Label lbSeccionAsig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeccionEst;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
    }
}