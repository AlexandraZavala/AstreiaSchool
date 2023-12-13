using System.IO;
using System.Reflection;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace LP2Soft
{
    partial class frmGestAsistencia
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

        private Image LoadImageFromResources(string resourceName)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream != null)
                {
                    return Image.FromStream(stream);
                }
                else
                {
                    throw new ArgumentException("No se encontró el recurso.", nameof(resourceName));
                }
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dgvAsistencias = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Tardanza = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbMarcarTodos = new System.Windows.Forms.CheckBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnListarEstudiantes = new System.Windows.Forms.Button();
            this.cbxListaHorarios = new System.Windows.Forms.ComboBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencias)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(16, 58);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 16);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha: ";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(122, 58);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(230, 20);
            this.dtpFecha.TabIndex = 2;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // dgvAsistencias
            // 
            this.dgvAsistencias.AllowUserToOrderColumns = true;
            this.dgvAsistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Estudiante,
            this.Presente,
            this.Tardanza,
            this.Observaciones});
            this.dgvAsistencias.Location = new System.Drawing.Point(18, 131);
            this.dgvAsistencias.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAsistencias.Name = "dgvAsistencias";
            this.dgvAsistencias.RowHeadersWidth = 51;
            this.dgvAsistencias.RowTemplate.Height = 50;
            this.dgvAsistencias.Size = new System.Drawing.Size(585, 175);
            this.dgvAsistencias.TabIndex = 8;
            this.dgvAsistencias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsistencias_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 125;
            // 
            // Estudiante
            // 
            this.Estudiante.HeaderText = "Estudiante";
            this.Estudiante.MinimumWidth = 6;
            this.Estudiante.Name = "Estudiante";
            this.Estudiante.ReadOnly = true;
            this.Estudiante.Width = 125;
            // 
            // Presente
            // 
            this.Presente.FillWeight = 5F;
            this.Presente.HeaderText = "Asistió";
            this.Presente.MinimumWidth = 6;
            this.Presente.Name = "Presente";
            this.Presente.Width = 60;
            // 
            // Tardanza
            // 
            this.Tardanza.HeaderText = "Tardanza";
            this.Tardanza.Name = "Tardanza";
            this.Tardanza.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tardanza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Observaciones
            // 
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.MinimumWidth = 6;
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.Width = 240;
            // 
            // Estado
            // 
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Width = 125;
            // 
            // cbMarcarTodos
            // 
            this.cbMarcarTodos.AutoSize = true;
            this.cbMarcarTodos.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarcarTodos.Location = new System.Drawing.Point(19, 94);
            this.cbMarcarTodos.Margin = new System.Windows.Forms.Padding(2);
            this.cbMarcarTodos.Name = "cbMarcarTodos";
            this.cbMarcarTodos.Size = new System.Drawing.Size(166, 20);
            this.cbMarcarTodos.TabIndex = 11;
            this.cbMarcarTodos.Text = "Marcar asistencia a todos";
            this.cbMarcarTodos.UseVisualStyleBackColor = true;
            this.cbMarcarTodos.CheckedChanged += new System.EventHandler(this.cbMarcarTodos_CheckedChanged);
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(18, 20);
            this.lblHorario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(48, 16);
            this.lblHorario.TabIndex = 14;
            this.lblHorario.Text = "Horario:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnListarEstudiantes);
            this.groupBox1.Controls.Add(this.cbxListaHorarios);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.lblHorario);
            this.groupBox1.Controls.Add(this.dgvAsistencias);
            this.groupBox1.Controls.Add(this.cbMarcarTodos);
            this.groupBox1.Location = new System.Drawing.Point(17, 69);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(620, 316);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnListarEstudiantes
            // 
            this.btnListarEstudiantes.Location = new System.Drawing.Point(249, 15);
            this.btnListarEstudiantes.Name = "btnListarEstudiantes";
            this.btnListarEstudiantes.Size = new System.Drawing.Size(139, 23);
            this.btnListarEstudiantes.TabIndex = 48;
            this.btnListarEstudiantes.Text = "Gestionar Asistencia";
            this.btnListarEstudiantes.UseVisualStyleBackColor = true;
            this.btnListarEstudiantes.Click += new System.EventHandler(this.btnListarEstudiantes_Click);
            // 
            // cbxListaHorarios
            // 
            this.cbxListaHorarios.FormattingEnabled = true;
            this.cbxListaHorarios.Location = new System.Drawing.Point(122, 17);
            this.cbxListaHorarios.Name = "cbxListaHorarios";
            this.cbxListaHorarios.Size = new System.Drawing.Size(121, 21);
            this.cbxListaHorarios.TabIndex = 47;
            this.cbxListaHorarios.SelectedIndexChanged += new System.EventHandler(this.cbxListaHorarios_SelectedIndexChanged);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 5F;
            this.dataGridViewImageColumn1.HeaderText = "Tardanza";
            this.dataGridViewImageColumn1.Image = global::AstreiaSoft.Properties.Resources.reloj1;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 60;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::AstreiaSoft.Properties.Resources.img_cancelar_17;
            this.btnCancelar.Location = new System.Drawing.Point(265, 26);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 32);
            this.btnCancelar.TabIndex = 57;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = global::AstreiaSoft.Properties.Resources.img_nuevo_17;
            this.btnNuevo.Location = new System.Drawing.Point(15, 26);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(96, 32);
            this.btnNuevo.TabIndex = 56;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::AstreiaSoft.Properties.Resources.img_guardar_17;
            this.btnGuardar.Location = new System.Drawing.Point(116, 26);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(144, 32);
            this.btnGuardar.TabIndex = 53;
            this.btnGuardar.Text = "Registrar asistencia";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmGestAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 406);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmGestAsistencia";
            this.Text = "frmGestAsistencia";
            this.Load += new System.EventHandler(this.frmGestAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencias)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView dgvAsistencias;
        private System.Windows.Forms.DataGridViewComboBoxColumn Estado;
        private CheckBox cbMarcarTodos;
        private Label lblHorario;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.CheckBox checkBoxTodos;
        private System.Windows.Forms.TextBox textBoxCurso;
        private System.Windows.Forms.TextBox textBoxHorario;
        private System.Windows.Forms.Label labelCurso;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private Button btnCancelar;
        private Button btnNuevo;
        private Button btnGuardar;
        private GroupBox groupBox1;
        private ComboBox cbxListaHorarios;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Estudiante;
        private DataGridViewCheckBoxColumn Presente;
        private DataGridViewCheckBoxColumn Tardanza;
        private DataGridViewTextBoxColumn Observaciones;
        private Button btnListarEstudiantes;
    }
}