namespace AstreiaSoft
{
    partial class frmBuscarEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarEvento));
            this.txtNombreEvento = new System.Windows.Forms.TextBox();
            this.lbllNombreEvento = new System.Windows.Forms.Label();
            this.lblFechaEvento = new System.Windows.Forms.Label();
            this.dtpFechaEvento = new System.Windows.Forms.DateTimePicker();
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxFiltroFechaInicio = new System.Windows.Forms.CheckBox();
            this.cbxFiltroNombre = new System.Windows.Forms.CheckBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreEvento
            // 
            this.txtNombreEvento.Enabled = false;
            this.txtNombreEvento.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEvento.Location = new System.Drawing.Point(249, 58);
            this.txtNombreEvento.Name = "txtNombreEvento";
            this.txtNombreEvento.Size = new System.Drawing.Size(213, 20);
            this.txtNombreEvento.TabIndex = 29;
            // 
            // lbllNombreEvento
            // 
            this.lbllNombreEvento.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllNombreEvento.Location = new System.Drawing.Point(38, 61);
            this.lbllNombreEvento.Name = "lbllNombreEvento";
            this.lbllNombreEvento.Size = new System.Drawing.Size(178, 23);
            this.lbllNombreEvento.TabIndex = 28;
            this.lbllNombreEvento.Text = "Seleccione nombre del evento:";
            // 
            // lblFechaEvento
            // 
            this.lblFechaEvento.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEvento.Location = new System.Drawing.Point(38, 101);
            this.lblFechaEvento.Name = "lblFechaEvento";
            this.lblFechaEvento.Size = new System.Drawing.Size(147, 23);
            this.lblFechaEvento.TabIndex = 30;
            this.lblFechaEvento.Text = "Seleccione fecha inicio:";
            // 
            // dtpFechaEvento
            // 
            this.dtpFechaEvento.CalendarFont = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEvento.Enabled = false;
            this.dtpFechaEvento.Location = new System.Drawing.Point(249, 98);
            this.dtpFechaEvento.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaEvento.Name = "dtpFechaEvento";
            this.dtpFechaEvento.Size = new System.Drawing.Size(213, 20);
            this.dtpFechaEvento.TabIndex = 31;
            // 
            // dgvEventos
            // 
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Descripcion,
            this.Lugar,
            this.FechaInicio,
            this.FechaFin});
            this.dgvEventos.Location = new System.Drawing.Point(40, 151);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.RowHeadersWidth = 51;
            this.dgvEventos.Size = new System.Drawing.Size(711, 232);
            this.dgvEventos.TabIndex = 41;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID Evento";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 125;
            // 
            // Lugar
            // 
            this.Lugar.HeaderText = "Lugar";
            this.Lugar.MinimumWidth = 6;
            this.Lugar.Name = "Lugar";
            this.Lugar.ReadOnly = true;
            this.Lugar.Width = 125;
            // 
            // FechaInicio
            // 
            this.FechaInicio.HeaderText = "Fecha de Inicio";
            this.FechaInicio.MinimumWidth = 6;
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            this.FechaInicio.Width = 125;
            // 
            // FechaFin
            // 
            this.FechaFin.HeaderText = "Fecha de Fin";
            this.FechaFin.MinimumWidth = 6;
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            this.FechaFin.Width = 125;
            // 
            // cbxFiltroFechaInicio
            // 
            this.cbxFiltroFechaInicio.AutoSize = true;
            this.cbxFiltroFechaInicio.Location = new System.Drawing.Point(229, 101);
            this.cbxFiltroFechaInicio.Name = "cbxFiltroFechaInicio";
            this.cbxFiltroFechaInicio.Size = new System.Drawing.Size(15, 14);
            this.cbxFiltroFechaInicio.TabIndex = 42;
            this.cbxFiltroFechaInicio.UseVisualStyleBackColor = true;
            this.cbxFiltroFechaInicio.CheckedChanged += new System.EventHandler(this.cbxFiltroFechaInicio_CheckedChanged);
            // 
            // cbxFiltroNombre
            // 
            this.cbxFiltroNombre.AutoSize = true;
            this.cbxFiltroNombre.Location = new System.Drawing.Point(228, 61);
            this.cbxFiltroNombre.Name = "cbxFiltroNombre";
            this.cbxFiltroNombre.Size = new System.Drawing.Size(15, 14);
            this.cbxFiltroNombre.TabIndex = 43;
            this.cbxFiltroNombre.UseVisualStyleBackColor = true;
            this.cbxFiltroNombre.CheckedChanged += new System.EventHandler(this.cbxFiltroNombre_CheckedChanged);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.Image")));
            this.btnAtras.Location = new System.Drawing.Point(40, 11);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(105, 32);
            this.btnAtras.TabIndex = 44;
            this.btnAtras.Text = "Atras";
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::AstreiaSoft.Properties.Resources.img_buscar_17;
            this.btnBuscar.Location = new System.Drawing.Point(532, 58);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 32);
            this.btnBuscar.TabIndex = 38;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Image = global::AstreiaSoft.Properties.Resources.img_seleccionar_17;
            this.btnSeleccionar.Location = new System.Drawing.Point(646, 58);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(105, 32);
            this.btnSeleccionar.TabIndex = 37;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // frmBuscarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.cbxFiltroNombre);
            this.Controls.Add(this.cbxFiltroFechaInicio);
            this.Controls.Add(this.dgvEventos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dtpFechaEvento);
            this.Controls.Add(this.lblFechaEvento);
            this.Controls.Add(this.txtNombreEvento);
            this.Controls.Add(this.lbllNombreEvento);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBuscarEvento";
            this.Text = "frmBuscarEvento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreEvento;
        private System.Windows.Forms.Label lbllNombreEvento;
        private System.Windows.Forms.Label lblFechaEvento;
        private System.Windows.Forms.DateTimePicker dtpFechaEvento;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView dgvEventos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.CheckBox cbxFiltroFechaInicio;
        private System.Windows.Forms.CheckBox cbxFiltroNombre;
        private System.Windows.Forms.Button btnAtras;
    }
}