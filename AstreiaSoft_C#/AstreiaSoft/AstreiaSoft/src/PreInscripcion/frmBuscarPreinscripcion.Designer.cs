using System.Windows.Forms;

namespace AstreiaSoft
{
    partial class frmBuscarPreinscripcion
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
            this.dgvPreInscripciones = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodoAcademico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPreinscripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboHijos = new System.Windows.Forms.ComboBox();
            this.lblHijo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreInscripciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPreInscripciones
            // 
            this.dgvPreInscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreInscripciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Estudiante,
            this.PeriodoAcademico,
            this.FechaPreinscripcion,
            this.Estado,
            this.Tipo});
            this.dgvPreInscripciones.Location = new System.Drawing.Point(41, 99);
            this.dgvPreInscripciones.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPreInscripciones.Name = "dgvPreInscripciones";
            this.dgvPreInscripciones.RowHeadersWidth = 51;
            this.dgvPreInscripciones.Size = new System.Drawing.Size(948, 406);
            this.dgvPreInscripciones.TabIndex = 44;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // Estudiante
            // 
            this.Estudiante.HeaderText = "Estudiante";
            this.Estudiante.MinimumWidth = 6;
            this.Estudiante.Name = "Estudiante";
            this.Estudiante.Width = 150;
            // 
            // PeriodoAcademico
            // 
            this.PeriodoAcademico.HeaderText = "Periodo Académico";
            this.PeriodoAcademico.MinimumWidth = 6;
            this.PeriodoAcademico.Name = "PeriodoAcademico";
            this.PeriodoAcademico.Width = 120;
            // 
            // FechaPreinscripcion
            // 
            this.FechaPreinscripcion.HeaderText = "Fecha de Pre-inscripción";
            this.FechaPreinscripcion.MinimumWidth = 6;
            this.FechaPreinscripcion.Name = "FechaPreinscripcion";
            this.FechaPreinscripcion.Width = 150;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Width = 125;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 150;
            // 
            // Año
            // 
            this.Año.HeaderText = "Año";
            this.Año.MinimumWidth = 6;
            this.Año.Name = "Año";
            this.Año.Width = 125;
            // 
            // FechaInicio
            // 
            this.FechaInicio.HeaderText = "Fecha Inicio";
            this.FechaInicio.MinimumWidth = 6;
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.Width = 125;
            // 
            // FechaFin
            // 
            this.FechaFin.HeaderText = "Fecha Fin";
            this.FechaFin.MinimumWidth = 6;
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.Width = 125;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.MinimumWidth = 6;
            this.Monto.Name = "Monto";
            this.Monto.Width = 125;
            // 
            // cboHijos
            // 
            this.cboHijos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHijos.FormattingEnabled = true;
            this.cboHijos.Items.AddRange(new object[] {
            "2023",
            "2022",
            "2021",
            "2020",
            "2019",
            "2018"});
            this.cboHijos.Location = new System.Drawing.Point(226, 47);
            this.cboHijos.Margin = new System.Windows.Forms.Padding(4);
            this.cboHijos.Name = "cboHijos";
            this.cboHijos.Size = new System.Drawing.Size(120, 27);
            this.cboHijos.TabIndex = 43;
            // 
            // lblHijo
            // 
            this.lblHijo.AutoSize = true;
            this.lblHijo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHijo.Location = new System.Drawing.Point(43, 50);
            this.lblHijo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHijo.Name = "lblHijo";
            this.lblHijo.Size = new System.Drawing.Size(169, 19);
            this.lblHijo.TabIndex = 42;
            this.lblHijo.Text = "Seleccione a su hijo(a):";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::AstreiaSoft.Properties.Resources.img_buscar_17;
            this.btnBuscar.Location = new System.Drawing.Point(378, 41);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(140, 39);
            this.btnBuscar.TabIndex = 41;
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
            this.btnSeleccionar.Location = new System.Drawing.Point(849, 41);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(140, 39);
            this.btnSeleccionar.TabIndex = 40;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // frmBuscarPreinscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgvPreInscripciones);
            this.Controls.Add(this.cboHijos);
            this.Controls.Add(this.lblHijo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSeleccionar);
            this.Name = "frmBuscarPreinscripcion";
            this.Text = "frmBuscarPreinscripcion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBuscarPreinscripcion_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreInscripciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPreInscripciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.ComboBox cboHijos;
        private System.Windows.Forms.Label lblHijo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSeleccionar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Estudiante;
        private DataGridViewTextBoxColumn PeriodoAcademico;
        private DataGridViewTextBoxColumn FechaPreinscripcion;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Tipo;
    }
}