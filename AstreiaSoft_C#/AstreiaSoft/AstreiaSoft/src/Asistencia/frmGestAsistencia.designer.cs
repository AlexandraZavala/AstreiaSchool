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
            this.lblCurso = new System.Windows.Forms.Label();
            this.txtEstudiante = new System.Windows.Forms.TextBox();
            this.dgvAsistencias = new System.Windows.Forms.DataGridView();
            this.Estado = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lblBuscaEstudiante = new System.Windows.Forms.Label();
            this.cbMarcarTodos = new System.Windows.Forms.CheckBox();
            this.tbCodCurso = new System.Windows.Forms.TextBox();
            this.tbNombreCurso = new System.Windows.Forms.TextBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.tbHorarioCurso = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarEstudiantes = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnRelojColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencias)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(21, 71);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(55, 17);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha: ";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(162, 71);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(306, 23);
            this.dtpFecha.TabIndex = 2;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(21, 21);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(49, 17);
            this.lblCurso.TabIndex = 3;
            this.lblCurso.Text = "Curso:";
            // 
            // txtEstudiante
            // 
            this.txtEstudiante.Location = new System.Drawing.Point(162, 115);
            this.txtEstudiante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEstudiante.Name = "txtEstudiante";
            this.txtEstudiante.ReadOnly = true;
            this.txtEstudiante.Size = new System.Drawing.Size(160, 22);
            this.txtEstudiante.TabIndex = 5;
            // 
            // dgvAsistencias
            // 
            this.dgvAsistencias.AllowUserToOrderColumns = true;
            this.dgvAsistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Foto,
            this.Codigo,
            this.Estudiante,
            this.checkBoxColumn,
            this.btnRelojColumn,
            this.Observaciones});
            this.dgvAsistencias.Location = new System.Drawing.Point(24, 161);
            this.dgvAsistencias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAsistencias.Name = "dgvAsistencias";
            this.dgvAsistencias.RowHeadersWidth = 51;
            this.dgvAsistencias.RowTemplate.Height = 50;
            this.dgvAsistencias.Size = new System.Drawing.Size(780, 215);
            this.dgvAsistencias.TabIndex = 8;
            // 
            // Estado
            // 
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Width = 125;
            // 
            // lblBuscaEstudiante
            // 
            this.lblBuscaEstudiante.AutoSize = true;
            this.lblBuscaEstudiante.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaEstudiante.Location = new System.Drawing.Point(24, 118);
            this.lblBuscaEstudiante.Name = "lblBuscaEstudiante";
            this.lblBuscaEstudiante.Size = new System.Drawing.Size(121, 17);
            this.lblBuscaEstudiante.TabIndex = 10;
            this.lblBuscaEstudiante.Text = "Buscar estudiante";
            // 
            // cbMarcarTodos
            // 
            this.cbMarcarTodos.AutoSize = true;
            this.cbMarcarTodos.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarcarTodos.Location = new System.Drawing.Point(352, 118);
            this.cbMarcarTodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMarcarTodos.Name = "cbMarcarTodos";
            this.cbMarcarTodos.Size = new System.Drawing.Size(116, 21);
            this.cbMarcarTodos.TabIndex = 11;
            this.cbMarcarTodos.Text = "Marcar Todos";
            this.cbMarcarTodos.UseVisualStyleBackColor = true;
            // 
            // tbCodCurso
            // 
            this.tbCodCurso.Location = new System.Drawing.Point(162, 22);
            this.tbCodCurso.Margin = new System.Windows.Forms.Padding(4);
            this.tbCodCurso.Name = "tbCodCurso";
            this.tbCodCurso.ReadOnly = true;
            this.tbCodCurso.Size = new System.Drawing.Size(68, 22);
            this.tbCodCurso.TabIndex = 12;
            this.tbCodCurso.TextChanged += new System.EventHandler(this.tbCodCurso_TextChanged);
            // 
            // tbNombreCurso
            // 
            this.tbNombreCurso.Location = new System.Drawing.Point(249, 22);
            this.tbNombreCurso.Margin = new System.Windows.Forms.Padding(4);
            this.tbNombreCurso.Name = "tbNombreCurso";
            this.tbNombreCurso.ReadOnly = true;
            this.tbNombreCurso.Size = new System.Drawing.Size(160, 22);
            this.tbNombreCurso.TabIndex = 13;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(464, 25);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(59, 17);
            this.lblHorario.TabIndex = 14;
            this.lblHorario.Text = "Horario:";
            // 
            // tbHorarioCurso
            // 
            this.tbHorarioCurso.Location = new System.Drawing.Point(605, 22);
            this.tbHorarioCurso.Margin = new System.Windows.Forms.Padding(4);
            this.tbHorarioCurso.Name = "tbHorarioCurso";
            this.tbHorarioCurso.ReadOnly = true;
            this.tbHorarioCurso.Size = new System.Drawing.Size(157, 22);
            this.tbHorarioCurso.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarEstudiantes);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.lblCurso);
            this.groupBox1.Controls.Add(this.tbCodCurso);
            this.groupBox1.Controls.Add(this.tbNombreCurso);
            this.groupBox1.Controls.Add(this.lblHorario);
            this.groupBox1.Controls.Add(this.tbHorarioCurso);
            this.groupBox1.Controls.Add(this.dgvAsistencias);
            this.groupBox1.Controls.Add(this.txtEstudiante);
            this.groupBox1.Controls.Add(this.lblBuscaEstudiante);
            this.groupBox1.Controls.Add(this.cbMarcarTodos);
            this.groupBox1.Location = new System.Drawing.Point(23, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 389);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnBuscarEstudiantes
            // 
            this.btnBuscarEstudiantes.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarEstudiantes.FlatAppearance.BorderSize = 0;
            this.btnBuscarEstudiantes.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEstudiantes.Image = global::AstreiaSoft.Properties.Resources.img_buscar_17;
            this.btnBuscarEstudiantes.Location = new System.Drawing.Point(570, 111);
            this.btnBuscarEstudiantes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarEstudiantes.Name = "btnBuscarEstudiantes";
            this.btnBuscarEstudiantes.Size = new System.Drawing.Size(213, 30);
            this.btnBuscarEstudiantes.TabIndex = 46;
            this.btnBuscarEstudiantes.Text = "Buscar estudiante";
            this.btnBuscarEstudiantes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarEstudiantes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarEstudiantes.UseVisualStyleBackColor = false;
            this.btnBuscarEstudiantes.Click += new System.EventHandler(this.btnBuscarEstudiantes_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(694, 32);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 39);
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
            this.btnNuevo.Location = new System.Drawing.Point(20, 32);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(128, 39);
            this.btnNuevo.TabIndex = 56;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::AstreiaSoft.Properties.Resources.img_buscar_17;
            this.btnBuscar.Location = new System.Drawing.Point(429, 32);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(127, 39);
            this.btnBuscar.TabIndex = 58;
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
            this.btnEditar.Location = new System.Drawing.Point(289, 32);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(134, 39);
            this.btnEditar.TabIndex = 54;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::AstreiaSoft.Properties.Resources.img_eliminar_17;
            this.btnEliminar.Location = new System.Drawing.Point(562, 32);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(127, 39);
            this.btnEliminar.TabIndex = 55;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::AstreiaSoft.Properties.Resources.img_guardar_17;
            this.btnGuardar.Location = new System.Drawing.Point(154, 32);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(129, 39);
            this.btnGuardar.TabIndex = 53;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Foto
            // 
            this.Foto.HeaderText = "Foto";
            this.Foto.MinimumWidth = 6;
            this.Foto.Name = "Foto";
            this.Foto.ReadOnly = true;
            this.Foto.Width = 125;
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
            // checkBoxColumn
            // 
            this.checkBoxColumn.FillWeight = 5F;
            this.checkBoxColumn.HeaderText = "Asistió";
            this.checkBoxColumn.MinimumWidth = 6;
            this.checkBoxColumn.Name = "checkBoxColumn";
            this.checkBoxColumn.Width = 60;
            // 
            // btnRelojColumn
            // 
            this.btnRelojColumn.FillWeight = 5F;
            this.btnRelojColumn.HeaderText = "Tardanza";
            this.btnRelojColumn.Image = global::AstreiaSoft.Properties.Resources.reloj1;
            this.btnRelojColumn.MinimumWidth = 6;
            this.btnRelojColumn.Name = "btnRelojColumn";
            this.btnRelojColumn.Width = 60;
            // 
            // Observaciones
            // 
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.MinimumWidth = 6;
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.Width = 240;
            // 
            // frmGestAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 486);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmGestAsistencia";
            this.Text = "frmGestAsistencia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencias)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.TextBox txtEstudiante;
        private System.Windows.Forms.DataGridView dgvAsistencias;
        private System.Windows.Forms.DataGridViewComboBoxColumn Estado;
        private Label lblBuscaEstudiante;
        private CheckBox cbMarcarTodos;
        private TextBox tbCodCurso;
        private TextBox tbNombreCurso;
        private Label lblHorario;
        private TextBox tbHorarioCurso;

        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.CheckBox checkBoxTodos;
        private System.Windows.Forms.TextBox textBoxCurso;
        private System.Windows.Forms.TextBox textBoxHorario;
        private System.Windows.Forms.Label labelCurso;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private Button btnCancelar;
        private Button btnNuevo;
        private Button btnBuscar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnGuardar;
        private GroupBox groupBox1;
        private Button btnBuscarEstudiantes;
        private DataGridViewImageColumn Foto;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Estudiante;
        private DataGridViewCheckBoxColumn checkBoxColumn;
        private DataGridViewImageColumn btnRelojColumn;
        private DataGridViewTextBoxColumn Observaciones;
    }
}