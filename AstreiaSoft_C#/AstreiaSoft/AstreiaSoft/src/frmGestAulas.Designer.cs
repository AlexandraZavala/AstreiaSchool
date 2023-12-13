namespace AstreiaSoft
{
    partial class frmGestAulas
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
            this.components = new System.ComponentModel.Container();
            this.lblGrado = new System.Windows.Forms.Label();
            this.cboGrado = new System.Windows.Forms.ComboBox();
            this.gbAula = new System.Windows.Forms.GroupBox();
            this.txtCapacidadAula = new System.Windows.Forms.TextBox();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.txtCodigoAula = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNombreAula = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtIdAula = new System.Windows.Forms.TextBox();
            this.lblIdSeccion = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelSecciones = new System.Windows.Forms.Panel();
            this.dgvAulas = new System.Windows.Forms.DataGridView();
            this.Aula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sección = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbBuscarAula = new System.Windows.Forms.GroupBox();
            this.lblIngresaNombreAula = new System.Windows.Forms.Label();
            this.txtNombreBusqAula = new System.Windows.Forms.TextBox();
            this.gbAula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulas)).BeginInit();
            this.gbBuscarAula.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrado.Location = new System.Drawing.Point(403, 76);
            this.lblGrado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(56, 17);
            this.lblGrado.TabIndex = 21;
            this.lblGrado.Text = "Grado :";
            // 
            // cboGrado
            // 
            this.cboGrado.FormattingEnabled = true;
            this.cboGrado.Location = new System.Drawing.Point(463, 73);
            this.cboGrado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboGrado.Name = "cboGrado";
            this.cboGrado.Size = new System.Drawing.Size(200, 21);
            this.cboGrado.TabIndex = 22;
            this.cboGrado.SelectedIndexChanged += new System.EventHandler(this.cboGrado_SelectedIndexChanged);
            // 
            // gbAula
            // 
            this.gbAula.Controls.Add(this.txtCapacidadAula);
            this.gbAula.Controls.Add(this.lblCapacidad);
            this.gbAula.Controls.Add(this.txtCodigoAula);
            this.gbAula.Controls.Add(this.lblCodigo);
            this.gbAula.Controls.Add(this.txtNombreAula);
            this.gbAula.Controls.Add(this.lblNombre);
            this.gbAula.Controls.Add(this.txtIdAula);
            this.gbAula.Controls.Add(this.lblIdSeccion);
            this.gbAula.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAula.Location = new System.Drawing.Point(22, 76);
            this.gbAula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbAula.Name = "gbAula";
            this.gbAula.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbAula.Size = new System.Drawing.Size(369, 178);
            this.gbAula.TabIndex = 23;
            this.gbAula.TabStop = false;
            this.gbAula.Text = "Aula";
            // 
            // txtCapacidadAula
            // 
            this.txtCapacidadAula.Location = new System.Drawing.Point(141, 124);
            this.txtCapacidadAula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCapacidadAula.Name = "txtCapacidadAula";
            this.txtCapacidadAula.Size = new System.Drawing.Size(178, 24);
            this.txtCapacidadAula.TabIndex = 7;
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidad.Location = new System.Drawing.Point(47, 130);
            this.lblCapacidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(79, 16);
            this.lblCapacidad.TabIndex = 6;
            this.lblCapacidad.Text = "Capacidad :";
            // 
            // txtCodigoAula
            // 
            this.txtCodigoAula.Location = new System.Drawing.Point(141, 89);
            this.txtCodigoAula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigoAula.Name = "txtCodigoAula";
            this.txtCodigoAula.Size = new System.Drawing.Size(178, 24);
            this.txtCodigoAula.TabIndex = 5;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(67, 95);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(53, 16);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Código :";
            // 
            // txtNombreAula
            // 
            this.txtNombreAula.Location = new System.Drawing.Point(141, 56);
            this.txtNombreAula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreAula.Name = "txtNombreAula";
            this.txtNombreAula.Size = new System.Drawing.Size(178, 24);
            this.txtNombreAula.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(64, 62);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre :";
            // 
            // txtIdAula
            // 
            this.txtIdAula.Location = new System.Drawing.Point(141, 24);
            this.txtIdAula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdAula.Name = "txtIdAula";
            this.txtIdAula.Size = new System.Drawing.Size(178, 24);
            this.txtIdAula.TabIndex = 1;
            // 
            // lblIdSeccion
            // 
            this.lblIdSeccion.AutoSize = true;
            this.lblIdSeccion.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdSeccion.Location = new System.Drawing.Point(94, 30);
            this.lblIdSeccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdSeccion.Name = "lblIdSeccion";
            this.lblIdSeccion.Size = new System.Drawing.Size(24, 16);
            this.lblIdSeccion.TabIndex = 0;
            this.lblIdSeccion.Text = "ID :";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::AstreiaSoft.Properties.Resources.img_cancelar_17;
            this.btnCancelar.Location = new System.Drawing.Point(492, 17);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 32);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Image = global::AstreiaSoft.Properties.Resources.img_seleccionar_17;
            this.btnSeleccionar.Location = new System.Drawing.Point(514, 14);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(105, 32);
            this.btnSeleccionar.TabIndex = 19;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = global::AstreiaSoft.Properties.Resources.img_nuevo_17;
            this.btnNuevo.Location = new System.Drawing.Point(25, 17);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(105, 32);
            this.btnNuevo.TabIndex = 18;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::AstreiaSoft.Properties.Resources.img_eliminar_17;
            this.btnEliminar.Location = new System.Drawing.Point(374, 17);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 32);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::AstreiaSoft.Properties.Resources.img_buscar_17;
            this.btnBuscar.Location = new System.Drawing.Point(397, 14);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 32);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::AstreiaSoft.Properties.Resources.img_editar_17;
            this.btnEditar.Location = new System.Drawing.Point(254, 17);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(105, 32);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::AstreiaSoft.Properties.Resources.img_guardar_17;
            this.btnGuardar.Location = new System.Drawing.Point(140, 17);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 32);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panelSecciones
            // 
            this.panelSecciones.Location = new System.Drawing.Point(463, 98);
            this.panelSecciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSecciones.Name = "panelSecciones";
            this.panelSecciones.Size = new System.Drawing.Size(198, 157);
            this.panelSecciones.TabIndex = 25;
            // 
            // dgvAulas
            // 
            this.dgvAulas.AllowUserToAddRows = false;
            this.dgvAulas.AllowUserToDeleteRows = false;
            this.dgvAulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAulas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Aula,
            this.Capacidad,
            this.Grado,
            this.Sección});
            this.dgvAulas.Location = new System.Drawing.Point(28, 58);
            this.dgvAulas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAulas.Name = "dgvAulas";
            this.dgvAulas.RowHeadersWidth = 51;
            this.dgvAulas.RowTemplate.Height = 24;
            this.dgvAulas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAulas.Size = new System.Drawing.Size(590, 164);
            this.dgvAulas.TabIndex = 26;
            this.dgvAulas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAulas_CellFormatting);
            // 
            // Aula
            // 
            this.Aula.HeaderText = "Aula";
            this.Aula.MinimumWidth = 6;
            this.Aula.Name = "Aula";
            this.Aula.Width = 50;
            // 
            // Capacidad
            // 
            this.Capacidad.HeaderText = "Capacidad";
            this.Capacidad.MinimumWidth = 6;
            this.Capacidad.Name = "Capacidad";
            this.Capacidad.Width = 80;
            // 
            // Grado
            // 
            this.Grado.HeaderText = "Grado";
            this.Grado.MinimumWidth = 6;
            this.Grado.Name = "Grado";
            this.Grado.Width = 150;
            // 
            // Sección
            // 
            this.Sección.HeaderText = "Seccion";
            this.Sección.MinimumWidth = 6;
            this.Sección.Name = "Sección";
            this.Sección.Width = 80;
            // 
            // gbBuscarAula
            // 
            this.gbBuscarAula.Controls.Add(this.lblIngresaNombreAula);
            this.gbBuscarAula.Controls.Add(this.txtNombreBusqAula);
            this.gbBuscarAula.Controls.Add(this.dgvAulas);
            this.gbBuscarAula.Controls.Add(this.btnSeleccionar);
            this.gbBuscarAula.Controls.Add(this.btnBuscar);
            this.gbBuscarAula.Location = new System.Drawing.Point(22, 277);
            this.gbBuscarAula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbBuscarAula.Name = "gbBuscarAula";
            this.gbBuscarAula.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbBuscarAula.Size = new System.Drawing.Size(640, 235);
            this.gbBuscarAula.TabIndex = 27;
            this.gbBuscarAula.TabStop = false;
            this.gbBuscarAula.Text = "Buscar Aula";
            // 
            // lblIngresaNombreAula
            // 
            this.lblIngresaNombreAula.AutoSize = true;
            this.lblIngresaNombreAula.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresaNombreAula.Location = new System.Drawing.Point(26, 24);
            this.lblIngresaNombreAula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIngresaNombreAula.Name = "lblIngresaNombreAula";
            this.lblIngresaNombreAula.Size = new System.Drawing.Size(109, 16);
            this.lblIngresaNombreAula.TabIndex = 10;
            this.lblIngresaNombreAula.Text = "Ingrese el Nombre :";
            // 
            // txtNombreBusqAula
            // 
            this.txtNombreBusqAula.Location = new System.Drawing.Point(141, 21);
            this.txtNombreBusqAula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreBusqAula.Name = "txtNombreBusqAula";
            this.txtNombreBusqAula.Size = new System.Drawing.Size(216, 20);
            this.txtNombreBusqAula.TabIndex = 27;
            // 
            // frmGestAulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 514);
            this.Controls.Add(this.gbBuscarAula);
            this.Controls.Add(this.panelSecciones);
            this.Controls.Add(this.gbAula);
            this.Controls.Add(this.cboGrado);
            this.Controls.Add(this.lblGrado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmGestAulas";
            this.Text = "frmGestAulas";
            this.Load += new System.EventHandler(this.frmGestAulas_Load);
            this.gbAula.ResumeLayout(false);
            this.gbAula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulas)).EndInit();
            this.gbBuscarAula.ResumeLayout(false);
            this.gbBuscarAula.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.ComboBox cboGrado;
        private System.Windows.Forms.GroupBox gbAula;
        private System.Windows.Forms.Label lblIdSeccion;
        private System.Windows.Forms.TextBox txtCapacidadAula;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.TextBox txtCodigoAula;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombreAula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtIdAula;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panelSecciones;
        private System.Windows.Forms.DataGridView dgvAulas;
        private System.Windows.Forms.GroupBox gbBuscarAula;
        private System.Windows.Forms.TextBox txtNombreBusqAula;
        private System.Windows.Forms.Label lblIngresaNombreAula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sección;
    }
}