namespace AstreiaSoft
{
    partial class frmBusquedaAdminsAcads
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
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.gpBusquedaAdmin = new System.Windows.Forms.GroupBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.ckbDNI = new System.Windows.Forms.CheckBox();
            this.ckbNombre = new System.Windows.Forms.CheckBox();
            this.btnBuscarAdmin = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.FechaDeNacimientoEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNIEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAdmins = new System.Windows.Forms.DataGridView();
            this.gpBusquedaAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmins)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Image = global::AstreiaSoft.Properties.Resources.img_seleccionar_17;
            this.btnSeleccionar.Location = new System.Drawing.Point(889, 101);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(132, 34);
            this.btnSeleccionar.TabIndex = 73;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // gpBusquedaAdmin
            // 
            this.gpBusquedaAdmin.Controls.Add(this.lblBusqueda);
            this.gpBusquedaAdmin.Controls.Add(this.txtBusqueda);
            this.gpBusquedaAdmin.Controls.Add(this.ckbDNI);
            this.gpBusquedaAdmin.Controls.Add(this.ckbNombre);
            this.gpBusquedaAdmin.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBusquedaAdmin.Location = new System.Drawing.Point(124, 34);
            this.gpBusquedaAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpBusquedaAdmin.Name = "gpBusquedaAdmin";
            this.gpBusquedaAdmin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpBusquedaAdmin.Size = new System.Drawing.Size(592, 101);
            this.gpBusquedaAdmin.TabIndex = 77;
            this.gpBusquedaAdmin.TabStop = false;
            this.gpBusquedaAdmin.Text = "Opción de búsqueda";
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Location = new System.Drawing.Point(9, 65);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(188, 20);
            this.lblBusqueda.TabIndex = 72;
            this.lblBusqueda.Text = "Ingrese el administrador:";
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
            // btnBuscarAdmin
            // 
            this.btnBuscarAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarAdmin.FlatAppearance.BorderSize = 0;
            this.btnBuscarAdmin.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAdmin.Image = global::AstreiaSoft.Properties.Resources.img_buscar_17;
            this.btnBuscarAdmin.Location = new System.Drawing.Point(743, 101);
            this.btnBuscarAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarAdmin.Name = "btnBuscarAdmin";
            this.btnBuscarAdmin.Size = new System.Drawing.Size(132, 34);
            this.btnBuscarAdmin.TabIndex = 78;
            this.btnBuscarAdmin.Text = "Buscar";
            this.btnBuscarAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarAdmin.UseVisualStyleBackColor = false;
            this.btnBuscarAdmin.Click += new System.EventHandler(this.btnBuscarAdmin_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.LightBlue;
            this.btnRegresar.Location = new System.Drawing.Point(28, 36);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(63, 48);
            this.btnRegresar.TabIndex = 79;
            this.btnRegresar.Text = "<-";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FechaDeNacimientoEstudiante
            // 
            this.FechaDeNacimientoEstudiante.HeaderText = "Fecha De Nacimiento";
            this.FechaDeNacimientoEstudiante.MinimumWidth = 6;
            this.FechaDeNacimientoEstudiante.Name = "FechaDeNacimientoEstudiante";
            this.FechaDeNacimientoEstudiante.ReadOnly = true;
            this.FechaDeNacimientoEstudiante.Width = 200;
            // 
            // NombreEstudiante
            // 
            this.NombreEstudiante.HeaderText = "Nombre";
            this.NombreEstudiante.MinimumWidth = 6;
            this.NombreEstudiante.Name = "NombreEstudiante";
            this.NombreEstudiante.ReadOnly = true;
            this.NombreEstudiante.Width = 175;
            // 
            // DNIEstudiante
            // 
            this.DNIEstudiante.HeaderText = "DNI";
            this.DNIEstudiante.MinimumWidth = 6;
            this.DNIEstudiante.Name = "DNIEstudiante";
            this.DNIEstudiante.ReadOnly = true;
            this.DNIEstudiante.Width = 125;
            // 
            // IDEstudiante
            // 
            this.IDEstudiante.HeaderText = "ID";
            this.IDEstudiante.MinimumWidth = 6;
            this.IDEstudiante.Name = "IDEstudiante";
            this.IDEstudiante.ReadOnly = true;
            this.IDEstudiante.Width = 125;
            // 
            // dgvAdmins
            // 
            this.dgvAdmins.AllowUserToAddRows = false;
            this.dgvAdmins.AllowUserToDeleteRows = false;
            this.dgvAdmins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDEstudiante,
            this.DNIEstudiante,
            this.NombreEstudiante,
            this.FechaDeNacimientoEstudiante});
            this.dgvAdmins.Location = new System.Drawing.Point(25, 149);
            this.dgvAdmins.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAdmins.Name = "dgvAdmins";
            this.dgvAdmins.ReadOnly = true;
            this.dgvAdmins.RowHeadersWidth = 51;
            this.dgvAdmins.RowTemplate.Height = 24;
            this.dgvAdmins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdmins.Size = new System.Drawing.Size(1021, 251);
            this.dgvAdmins.TabIndex = 76;
            this.dgvAdmins.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAdmins_CellFormatting);
            // 
            // frmBusquedaAdminsAcads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 450);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnBuscarAdmin);
            this.Controls.Add(this.gpBusquedaAdmin);
            this.Controls.Add(this.dgvAdmins);
            this.Controls.Add(this.btnSeleccionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBusquedaAdminsAcads";
            this.Text = "frmBusquedaAdminsAcads";
            this.gpBusquedaAdmin.ResumeLayout(false);
            this.gpBusquedaAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmins)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.GroupBox gpBusquedaAdmin;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.CheckBox ckbDNI;
        private System.Windows.Forms.CheckBox ckbNombre;
        private System.Windows.Forms.Button btnBuscarAdmin;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeNacimientoEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNIEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEstudiante;
        private System.Windows.Forms.DataGridView dgvAdmins;
    }
}