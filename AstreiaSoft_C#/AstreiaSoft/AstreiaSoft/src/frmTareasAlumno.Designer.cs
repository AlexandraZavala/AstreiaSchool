namespace AstreiaSoft
{
    partial class frmTareasAlumno
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dtgTareasAsignadas = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.pbArchivo = new System.Windows.Forms.PictureBox();
            this.cboEstadoEntrega = new System.Windows.Forms.ComboBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblArchivo = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblEstadoEntrega = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.FechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Archivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTareasAsignadas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArchivo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSeleccionar);
            this.groupBox1.Controls.Add(this.dtgTareasAsignadas);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(373, 450);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tareas asignadas";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Image = global::AstreiaSoft.Properties.Resources.img_seleccionar_17;
            this.btnSeleccionar.Location = new System.Drawing.Point(189, 391);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(140, 39);
            this.btnSeleccionar.TabIndex = 67;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // dtgTareasAsignadas
            // 
            this.dtgTareasAsignadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTareasAsignadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaEntrega,
            this.EstadoEntrega,
            this.Archivo});
            this.dtgTareasAsignadas.Location = new System.Drawing.Point(23, 43);
            this.dtgTareasAsignadas.Name = "dtgTareasAsignadas";
            this.dtgTareasAsignadas.RowHeadersWidth = 51;
            this.dtgTareasAsignadas.RowTemplate.Height = 24;
            this.dtgTareasAsignadas.Size = new System.Drawing.Size(323, 306);
            this.dtgTareasAsignadas.TabIndex = 54;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::AstreiaSoft.Properties.Resources.img_buscar_17;
            this.btnBuscar.Location = new System.Drawing.Point(32, 391);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(140, 39);
            this.btnBuscar.TabIndex = 66;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.dtpFechaEntrega);
            this.groupBox2.Controls.Add(this.pbArchivo);
            this.groupBox2.Controls.Add(this.cboEstadoEntrega);
            this.groupBox2.Controls.Add(this.txtObservaciones);
            this.groupBox2.Controls.Add(this.lblArchivo);
            this.groupBox2.Controls.Add(this.lblObservaciones);
            this.groupBox2.Controls.Add(this.lblEstadoEntrega);
            this.groupBox2.Controls.Add(this.lblDNI);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(394, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(456, 450);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entrega de evaluación";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::AstreiaSoft.Properties.Resources.img_guardar_17;
            this.btnGuardar.Location = new System.Drawing.Point(146, 391);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 39);
            this.btnGuardar.TabIndex = 65;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Location = new System.Drawing.Point(192, 50);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(226, 28);
            this.dtpFechaEntrega.TabIndex = 64;
            // 
            // pbArchivo
            // 
            this.pbArchivo.Location = new System.Drawing.Point(192, 314);
            this.pbArchivo.Name = "pbArchivo";
            this.pbArchivo.Size = new System.Drawing.Size(226, 35);
            this.pbArchivo.TabIndex = 63;
            this.pbArchivo.TabStop = false;
            // 
            // cboEstadoEntrega
            // 
            this.cboEstadoEntrega.FormattingEnabled = true;
            this.cboEstadoEntrega.Location = new System.Drawing.Point(192, 111);
            this.cboEstadoEntrega.Name = "cboEstadoEntrega";
            this.cboEstadoEntrega.Size = new System.Drawing.Size(226, 29);
            this.cboEstadoEntrega.TabIndex = 62;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(192, 161);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(226, 124);
            this.txtObservaciones.TabIndex = 61;
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblArchivo.Location = new System.Drawing.Point(17, 314);
            this.lblArchivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(88, 22);
            this.lblArchivo.TabIndex = 60;
            this.lblArchivo.Text = "Archivo:";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblObservaciones.Location = new System.Drawing.Point(17, 161);
            this.lblObservaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(154, 22);
            this.lblObservaciones.TabIndex = 59;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // lblEstadoEntrega
            // 
            this.lblEstadoEntrega.AutoSize = true;
            this.lblEstadoEntrega.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblEstadoEntrega.Location = new System.Drawing.Point(17, 111);
            this.lblEstadoEntrega.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoEntrega.Name = "lblEstadoEntrega";
            this.lblEstadoEntrega.Size = new System.Drawing.Size(157, 22);
            this.lblEstadoEntrega.TabIndex = 58;
            this.lblEstadoEntrega.Text = "Estado entrega:";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblDNI.Location = new System.Drawing.Point(17, 56);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(153, 22);
            this.lblDNI.TabIndex = 57;
            this.lblDNI.Text = "Fecha entrega:";
            // 
            // FechaEntrega
            // 
            this.FechaEntrega.HeaderText = "F. Entrega";
            this.FechaEntrega.MinimumWidth = 6;
            this.FechaEntrega.Name = "FechaEntrega";
            this.FechaEntrega.Width = 80;
            // 
            // EstadoEntrega
            // 
            this.EstadoEntrega.HeaderText = "Est Entrega";
            this.EstadoEntrega.MinimumWidth = 6;
            this.EstadoEntrega.Name = "EstadoEntrega";
            this.EstadoEntrega.Width = 80;
            // 
            // Archivo
            // 
            this.Archivo.HeaderText = "Archivo";
            this.Archivo.MinimumWidth = 6;
            this.Archivo.Name = "Archivo";
            this.Archivo.Width = 125;
            // 
            // frmTareasAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 486);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTareasAlumno";
            this.Text = "FormularioTareasAlumno";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTareasAsignadas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArchivo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgTareasAsignadas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblEstadoEntrega;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.PictureBox pbArchivo;
        private System.Windows.Forms.ComboBox cboEstadoEntrega;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Archivo;
    }
}