namespace AstreiaSoft
{
    partial class frmAgregarHijo
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.gbBusquedaHijo = new System.Windows.Forms.GroupBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtBusquedaEstudiante = new System.Windows.Forms.TextBox();
            this.ckbDNI = new System.Windows.Forms.CheckBox();
            this.ckbNombre = new System.Windows.Forms.CheckBox();
            this.btnBuscarEstudiante = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.IDEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNIEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeNacimientoEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbBusquedaHijo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.LightBlue;
            this.btnRegresar.Location = new System.Drawing.Point(21, 12);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(47, 39);
            this.btnRegresar.TabIndex = 74;
            this.btnRegresar.Text = "<-";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // gbBusquedaHijo
            // 
            this.gbBusquedaHijo.Controls.Add(this.lblBusqueda);
            this.gbBusquedaHijo.Controls.Add(this.txtBusquedaEstudiante);
            this.gbBusquedaHijo.Controls.Add(this.ckbDNI);
            this.gbBusquedaHijo.Controls.Add(this.ckbNombre);
            this.gbBusquedaHijo.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBusquedaHijo.Location = new System.Drawing.Point(77, 12);
            this.gbBusquedaHijo.Margin = new System.Windows.Forms.Padding(2);
            this.gbBusquedaHijo.Name = "gbBusquedaHijo";
            this.gbBusquedaHijo.Padding = new System.Windows.Forms.Padding(2);
            this.gbBusquedaHijo.Size = new System.Drawing.Size(420, 82);
            this.gbBusquedaHijo.TabIndex = 75;
            this.gbBusquedaHijo.TabStop = false;
            this.gbBusquedaHijo.Text = "Opción de búsqueda";
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Location = new System.Drawing.Point(7, 53);
            this.lblBusqueda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(135, 17);
            this.lblBusqueda.TabIndex = 72;
            this.lblBusqueda.Text = "Ingrese el estudiante:";
            // 
            // txtBusquedaEstudiante
            // 
            this.txtBusquedaEstudiante.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaEstudiante.Location = new System.Drawing.Point(150, 53);
            this.txtBusquedaEstudiante.Name = "txtBusquedaEstudiante";
            this.txtBusquedaEstudiante.Size = new System.Drawing.Size(257, 20);
            this.txtBusquedaEstudiante.TabIndex = 73;
            // 
            // ckbDNI
            // 
            this.ckbDNI.AutoSize = true;
            this.ckbDNI.Location = new System.Drawing.Point(229, 18);
            this.ckbDNI.Name = "ckbDNI";
            this.ckbDNI.Size = new System.Drawing.Size(45, 20);
            this.ckbDNI.TabIndex = 75;
            this.ckbDNI.Text = "DNI";
            this.ckbDNI.UseVisualStyleBackColor = true;
            // 
            // ckbNombre
            // 
            this.ckbNombre.AutoSize = true;
            this.ckbNombre.Location = new System.Drawing.Point(69, 20);
            this.ckbNombre.Name = "ckbNombre";
            this.ckbNombre.Size = new System.Drawing.Size(137, 20);
            this.ckbNombre.TabIndex = 74;
            this.ckbNombre.Text = "Nombre y/o apellido";
            this.ckbNombre.UseVisualStyleBackColor = true;
            // 
            // btnBuscarEstudiante
            // 
            this.btnBuscarEstudiante.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarEstudiante.FlatAppearance.BorderSize = 0;
            this.btnBuscarEstudiante.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEstudiante.Image = global::AstreiaSoft.Properties.Resources.img_buscar_17;
            this.btnBuscarEstudiante.Location = new System.Drawing.Point(514, 61);
            this.btnBuscarEstudiante.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarEstudiante.Name = "btnBuscarEstudiante";
            this.btnBuscarEstudiante.Size = new System.Drawing.Size(99, 28);
            this.btnBuscarEstudiante.TabIndex = 76;
            this.btnBuscarEstudiante.Text = "Buscar";
            this.btnBuscarEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarEstudiante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarEstudiante.UseVisualStyleBackColor = false;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Image = global::AstreiaSoft.Properties.Resources.img_seleccionar_17;
            this.btnSeleccionar.Location = new System.Drawing.Point(626, 61);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(99, 28);
            this.btnSeleccionar.TabIndex = 77;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.AllowUserToAddRows = false;
            this.dgvEstudiantes.AllowUserToDeleteRows = false;
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDEstudiante,
            this.DNIEstudiante,
            this.NombreEstudiante,
            this.FechaDeNacimientoEstudiante});
            this.dgvEstudiantes.Location = new System.Drawing.Point(21, 101);
            this.dgvEstudiantes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.ReadOnly = true;
            this.dgvEstudiantes.RowHeadersWidth = 51;
            this.dgvEstudiantes.RowTemplate.Height = 24;
            this.dgvEstudiantes.Size = new System.Drawing.Size(766, 204);
            this.dgvEstudiantes.TabIndex = 78;
            // 
            // IDEstudiante
            // 
            this.IDEstudiante.HeaderText = "ID";
            this.IDEstudiante.MinimumWidth = 6;
            this.IDEstudiante.Name = "IDEstudiante";
            this.IDEstudiante.ReadOnly = true;
            this.IDEstudiante.Width = 125;
            // 
            // DNIEstudiante
            // 
            this.DNIEstudiante.HeaderText = "DNI";
            this.DNIEstudiante.MinimumWidth = 6;
            this.DNIEstudiante.Name = "DNIEstudiante";
            this.DNIEstudiante.ReadOnly = true;
            this.DNIEstudiante.Width = 125;
            // 
            // NombreEstudiante
            // 
            this.NombreEstudiante.HeaderText = "Nombre";
            this.NombreEstudiante.MinimumWidth = 6;
            this.NombreEstudiante.Name = "NombreEstudiante";
            this.NombreEstudiante.ReadOnly = true;
            this.NombreEstudiante.Width = 175;
            // 
            // FechaDeNacimientoEstudiante
            // 
            this.FechaDeNacimientoEstudiante.HeaderText = "Fecha De Nacimiento";
            this.FechaDeNacimientoEstudiante.MinimumWidth = 6;
            this.FechaDeNacimientoEstudiante.Name = "FechaDeNacimientoEstudiante";
            this.FechaDeNacimientoEstudiante.ReadOnly = true;
            this.FechaDeNacimientoEstudiante.Width = 200;
            // 
            // frmAgregarHijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 316);
            this.Controls.Add(this.dgvEstudiantes);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnBuscarEstudiante);
            this.Controls.Add(this.gbBusquedaHijo);
            this.Controls.Add(this.btnRegresar);
            this.Name = "frmAgregarHijo";
            this.Text = "frmAgregarHijo";
            this.gbBusquedaHijo.ResumeLayout(false);
            this.gbBusquedaHijo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.GroupBox gbBusquedaHijo;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtBusquedaEstudiante;
        private System.Windows.Forms.CheckBox ckbDNI;
        private System.Windows.Forms.CheckBox ckbNombre;
        private System.Windows.Forms.Button btnBuscarEstudiante;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNIEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeNacimientoEstudiante;
    }
}