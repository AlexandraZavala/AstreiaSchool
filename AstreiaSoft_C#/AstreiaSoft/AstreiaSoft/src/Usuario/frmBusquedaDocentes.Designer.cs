namespace AstreiaSoft
{
    partial class frmBusquedaDocentes
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
            this.gpBusquedaDocente = new System.Windows.Forms.GroupBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.ckbDNI = new System.Windows.Forms.CheckBox();
            this.ckbNombre = new System.Windows.Forms.CheckBox();
            this.btnBuscarEstudiante = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dgvDocentes = new System.Windows.Forms.DataGridView();
            this.IDEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNIEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeNacimientoEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpBusquedaDocente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.LightBlue;
            this.btnRegresar.Location = new System.Drawing.Point(28, 27);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(63, 48);
            this.btnRegresar.TabIndex = 80;
            this.btnRegresar.Text = "<-";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // gpBusquedaDocente
            // 
            this.gpBusquedaDocente.Controls.Add(this.lblBusqueda);
            this.gpBusquedaDocente.Controls.Add(this.txtBusqueda);
            this.gpBusquedaDocente.Controls.Add(this.ckbDNI);
            this.gpBusquedaDocente.Controls.Add(this.ckbNombre);
            this.gpBusquedaDocente.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBusquedaDocente.Location = new System.Drawing.Point(116, 27);
            this.gpBusquedaDocente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpBusquedaDocente.Name = "gpBusquedaDocente";
            this.gpBusquedaDocente.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpBusquedaDocente.Size = new System.Drawing.Size(592, 101);
            this.gpBusquedaDocente.TabIndex = 81;
            this.gpBusquedaDocente.TabStop = false;
            this.gpBusquedaDocente.Text = "Opción de búsqueda";
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Location = new System.Drawing.Point(9, 65);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(153, 20);
            this.lblBusqueda.TabIndex = 72;
            this.lblBusqueda.Text = "Ingrese el docente:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(224, 65);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(341, 23);
            this.txtBusqueda.TabIndex = 73;
            // 
            // ckbDNI
            // 
            this.ckbDNI.AutoSize = true;
            this.ckbDNI.Location = new System.Drawing.Point(305, 22);
            this.ckbDNI.Margin = new System.Windows.Forms.Padding(4);
            this.ckbDNI.Name = "ckbDNI";
            this.ckbDNI.Size = new System.Drawing.Size(53, 21);
            this.ckbDNI.TabIndex = 75;
            this.ckbDNI.Text = "DNI";
            this.ckbDNI.UseVisualStyleBackColor = true;
            // 
            // ckbNombre
            // 
            this.ckbNombre.AutoSize = true;
            this.ckbNombre.Location = new System.Drawing.Point(92, 25);
            this.ckbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.ckbNombre.Name = "ckbNombre";
            this.ckbNombre.Size = new System.Drawing.Size(165, 21);
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
            this.btnBuscarEstudiante.Location = new System.Drawing.Point(731, 87);
            this.btnBuscarEstudiante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarEstudiante.Name = "btnBuscarEstudiante";
            this.btnBuscarEstudiante.Size = new System.Drawing.Size(132, 34);
            this.btnBuscarEstudiante.TabIndex = 82;
            this.btnBuscarEstudiante.Text = "Buscar";
            this.btnBuscarEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarEstudiante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarEstudiante.UseVisualStyleBackColor = false;
            this.btnBuscarEstudiante.Click += new System.EventHandler(this.btnBuscarEstudiante_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Image = global::AstreiaSoft.Properties.Resources.img_seleccionar_17;
            this.btnSeleccionar.Location = new System.Drawing.Point(881, 87);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(132, 34);
            this.btnSeleccionar.TabIndex = 83;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // dgvDocentes
            // 
            this.dgvDocentes.AllowUserToAddRows = false;
            this.dgvDocentes.AllowUserToDeleteRows = false;
            this.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDEstudiante,
            this.DNIEstudiante,
            this.NombreEstudiante,
            this.FechaDeNacimientoEstudiante});
            this.dgvDocentes.Location = new System.Drawing.Point(23, 151);
            this.dgvDocentes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDocentes.Name = "dgvDocentes";
            this.dgvDocentes.ReadOnly = true;
            this.dgvDocentes.RowHeadersWidth = 51;
            this.dgvDocentes.RowTemplate.Height = 24;
            this.dgvDocentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocentes.Size = new System.Drawing.Size(1021, 251);
            this.dgvDocentes.TabIndex = 84;
            this.dgvDocentes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDocentes_CellFormatting);
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
            // frmBusquedaDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 450);
            this.Controls.Add(this.dgvDocentes);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnBuscarEstudiante);
            this.Controls.Add(this.gpBusquedaDocente);
            this.Controls.Add(this.btnRegresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBusquedaDocentes";
            this.Text = "frmBusquedaDocentes";
            this.gpBusquedaDocente.ResumeLayout(false);
            this.gpBusquedaDocente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.GroupBox gpBusquedaDocente;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.CheckBox ckbDNI;
        private System.Windows.Forms.CheckBox ckbNombre;
        private System.Windows.Forms.Button btnBuscarEstudiante;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView dgvDocentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNIEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeNacimientoEstudiante;
    }
}