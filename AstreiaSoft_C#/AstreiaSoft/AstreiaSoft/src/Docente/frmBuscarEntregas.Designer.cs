namespace AstreiaSoft.src.Docente
{
    partial class frmBuscarEntregas
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
            this.dgvEvaluaciones = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEvaluacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.gbEvalSeleccionada = new System.Windows.Forms.GroupBox();
            this.txtTipoEvaluacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreEvaluacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDEvaluacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEntregas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscarEntregas = new System.Windows.Forms.Button();
            this.btnSeleccionarEntrega = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluaciones)).BeginInit();
            this.gbEvalSeleccionada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEvaluaciones
            // 
            this.dgvEvaluaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvaluaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.TipoEvaluacion,
            this.FechaInicio,
            this.FechaFin});
            this.dgvEvaluaciones.Location = new System.Drawing.Point(26, 89);
            this.dgvEvaluaciones.Name = "dgvEvaluaciones";
            this.dgvEvaluaciones.RowHeadersWidth = 51;
            this.dgvEvaluaciones.Size = new System.Drawing.Size(620, 114);
            this.dgvEvaluaciones.TabIndex = 53;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID Evaluacion";
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
            // TipoEvaluacion
            // 
            this.TipoEvaluacion.HeaderText = "Tipo Evaluacion";
            this.TipoEvaluacion.MinimumWidth = 6;
            this.TipoEvaluacion.Name = "TipoEvaluacion";
            this.TipoEvaluacion.ReadOnly = true;
            this.TipoEvaluacion.Width = 125;
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
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::AstreiaSoft.Properties.Resources.img_buscar_17;
            this.btnBuscar.Location = new System.Drawing.Point(432, 40);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 32);
            this.btnBuscar.TabIndex = 55;
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
            this.btnSeleccionar.Location = new System.Drawing.Point(541, 40);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(105, 32);
            this.btnSeleccionar.TabIndex = 54;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // gbEvalSeleccionada
            // 
            this.gbEvalSeleccionada.Controls.Add(this.txtTipoEvaluacion);
            this.gbEvalSeleccionada.Controls.Add(this.label3);
            this.gbEvalSeleccionada.Controls.Add(this.txtNombreEvaluacion);
            this.gbEvalSeleccionada.Controls.Add(this.label2);
            this.gbEvalSeleccionada.Controls.Add(this.txtIDEvaluacion);
            this.gbEvalSeleccionada.Controls.Add(this.label1);
            this.gbEvalSeleccionada.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEvalSeleccionada.Location = new System.Drawing.Point(25, 210);
            this.gbEvalSeleccionada.Name = "gbEvalSeleccionada";
            this.gbEvalSeleccionada.Size = new System.Drawing.Size(620, 125);
            this.gbEvalSeleccionada.TabIndex = 57;
            this.gbEvalSeleccionada.TabStop = false;
            this.gbEvalSeleccionada.Text = "Evaluacion Seleccionada";
            // 
            // txtTipoEvaluacion
            // 
            this.txtTipoEvaluacion.Enabled = false;
            this.txtTipoEvaluacion.Location = new System.Drawing.Point(75, 84);
            this.txtTipoEvaluacion.Name = "txtTipoEvaluacion";
            this.txtTipoEvaluacion.Size = new System.Drawing.Size(140, 21);
            this.txtTipoEvaluacion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo";
            // 
            // txtNombreEvaluacion
            // 
            this.txtNombreEvaluacion.Enabled = false;
            this.txtNombreEvaluacion.Location = new System.Drawing.Point(75, 57);
            this.txtNombreEvaluacion.Name = "txtNombreEvaluacion";
            this.txtNombreEvaluacion.Size = new System.Drawing.Size(199, 21);
            this.txtNombreEvaluacion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtIDEvaluacion
            // 
            this.txtIDEvaluacion.Enabled = false;
            this.txtIDEvaluacion.Location = new System.Drawing.Point(75, 30);
            this.txtIDEvaluacion.Name = "txtIDEvaluacion";
            this.txtIDEvaluacion.Size = new System.Drawing.Size(67, 21);
            this.txtIDEvaluacion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // dgvEntregas
            // 
            this.dgvEntregas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntregas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7});
            this.dgvEntregas.Location = new System.Drawing.Point(29, 385);
            this.dgvEntregas.Name = "dgvEntregas";
            this.dgvEntregas.RowHeadersWidth = 51;
            this.dgvEntregas.Size = new System.Drawing.Size(620, 119);
            this.dgvEntregas.TabIndex = 58;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Entrega";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Estudiante";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha Entrega";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Nota Obtenida";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Seleccion de Evaluacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Seleccion de Entrega";
            // 
            // btnBuscarEntregas
            // 
            this.btnBuscarEntregas.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarEntregas.FlatAppearance.BorderSize = 0;
            this.btnBuscarEntregas.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEntregas.Image = global::AstreiaSoft.Properties.Resources.img_buscar_17;
            this.btnBuscarEntregas.Location = new System.Drawing.Point(432, 340);
            this.btnBuscarEntregas.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarEntregas.Name = "btnBuscarEntregas";
            this.btnBuscarEntregas.Size = new System.Drawing.Size(105, 32);
            this.btnBuscarEntregas.TabIndex = 60;
            this.btnBuscarEntregas.Text = "Buscar";
            this.btnBuscarEntregas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarEntregas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarEntregas.UseVisualStyleBackColor = false;
            this.btnBuscarEntregas.Click += new System.EventHandler(this.btnBuscarEntregas_Click);
            // 
            // btnSeleccionarEntrega
            // 
            this.btnSeleccionarEntrega.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionarEntrega.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarEntrega.Image = global::AstreiaSoft.Properties.Resources.img_seleccionar_17;
            this.btnSeleccionarEntrega.Location = new System.Drawing.Point(541, 340);
            this.btnSeleccionarEntrega.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeleccionarEntrega.Name = "btnSeleccionarEntrega";
            this.btnSeleccionarEntrega.Size = new System.Drawing.Size(105, 32);
            this.btnSeleccionarEntrega.TabIndex = 59;
            this.btnSeleccionarEntrega.Text = "Seleccionar";
            this.btnSeleccionarEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionarEntrega.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeleccionarEntrega.UseVisualStyleBackColor = false;
            this.btnSeleccionarEntrega.Click += new System.EventHandler(this.btnSeleccionarEntrega_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(179, 52);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(213, 20);
            this.txtNombre.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 23);
            this.label6.TabIndex = 61;
            this.label6.Text = "Nombre de la evaluacion:";
            // 
            // frmBuscarEntregas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 529);
            this.Controls.Add(this.dgvEntregas);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBuscarEntregas);
            this.Controls.Add(this.btnSeleccionarEntrega);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbEvalSeleccionada);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dgvEvaluaciones);
            this.Name = "frmBuscarEntregas";
            this.Text = "frmGestNotas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluaciones)).EndInit();
            this.gbEvalSeleccionada.ResumeLayout(false);
            this.gbEvalSeleccionada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEvaluaciones;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.GroupBox gbEvalSeleccionada;
        private System.Windows.Forms.TextBox txtTipoEvaluacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreEvaluacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDEvaluacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEntregas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btnBuscarEntregas;
        private System.Windows.Forms.Button btnSeleccionarEntrega;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEvaluacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
    }
}