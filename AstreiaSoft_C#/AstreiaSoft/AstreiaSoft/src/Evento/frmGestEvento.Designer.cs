using System.Windows.Forms;

namespace AstreiaSoft
{
    partial class frmGestEvento
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
            this.lblNombreEvento = new System.Windows.Forms.Label();
            this.textBoxNombreEvento = new System.Windows.Forms.TextBox();
            this.lblDescripcionEvento = new System.Windows.Forms.Label();
            this.textBoxDescripcionEvento = new System.Windows.Forms.TextBox();
            this.lblFechaEvento = new System.Windows.Forms.Label();
            this.dateTimePickerFechaInicioEvento = new System.Windows.Forms.DateTimePicker();
            this.lbLugarEvento = new System.Windows.Forms.Label();
            this.textBoxLugarEvento = new System.Windows.Forms.TextBox();
            this.dateTimePickerHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHoraFin = new System.Windows.Forms.DateTimePicker();
            this.gbEvento = new System.Windows.Forms.GroupBox();
            this.dateTimePickerFechaFinEvento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHoraInicio = new System.Windows.Forms.Label();
            this.labelHoraFin = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbEvento.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreEvento
            // 
            this.lblNombreEvento.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEvento.Location = new System.Drawing.Point(42, 45);
            this.lblNombreEvento.Name = "lblNombreEvento";
            this.lblNombreEvento.Size = new System.Drawing.Size(100, 23);
            this.lblNombreEvento.TabIndex = 1;
            this.lblNombreEvento.Text = "Nombre:";
            // 
            // textBoxNombreEvento
            // 
            this.textBoxNombreEvento.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreEvento.Location = new System.Drawing.Point(162, 45);
            this.textBoxNombreEvento.Name = "textBoxNombreEvento";
            this.textBoxNombreEvento.Size = new System.Drawing.Size(300, 20);
            this.textBoxNombreEvento.TabIndex = 2;
            this.textBoxNombreEvento.TextChanged += new System.EventHandler(this.textBoxNombreEvento_TextChanged);
            // 
            // lblDescripcionEvento
            // 
            this.lblDescripcionEvento.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionEvento.Location = new System.Drawing.Point(42, 84);
            this.lblDescripcionEvento.Name = "lblDescripcionEvento";
            this.lblDescripcionEvento.Size = new System.Drawing.Size(100, 23);
            this.lblDescripcionEvento.TabIndex = 3;
            this.lblDescripcionEvento.Text = "Descripción:";
            // 
            // textBoxDescripcionEvento
            // 
            this.textBoxDescripcionEvento.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescripcionEvento.Location = new System.Drawing.Point(162, 84);
            this.textBoxDescripcionEvento.Multiline = true;
            this.textBoxDescripcionEvento.Name = "textBoxDescripcionEvento";
            this.textBoxDescripcionEvento.Size = new System.Drawing.Size(300, 60);
            this.textBoxDescripcionEvento.TabIndex = 4;
            this.textBoxDescripcionEvento.TextChanged += new System.EventHandler(this.textBoxDescripcionEvento_TextChanged);
            // 
            // lblFechaEvento
            // 
            this.lblFechaEvento.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEvento.Location = new System.Drawing.Point(42, 201);
            this.lblFechaEvento.Name = "lblFechaEvento";
            this.lblFechaEvento.Size = new System.Drawing.Size(100, 23);
            this.lblFechaEvento.TabIndex = 5;
            this.lblFechaEvento.Text = "Fecha Inicio:";
            // 
            // dateTimePickerFechaInicioEvento
            // 
            this.dateTimePickerFechaInicioEvento.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaInicioEvento.Location = new System.Drawing.Point(162, 201);
            this.dateTimePickerFechaInicioEvento.Name = "dateTimePickerFechaInicioEvento";
            this.dateTimePickerFechaInicioEvento.Size = new System.Drawing.Size(242, 20);
            this.dateTimePickerFechaInicioEvento.TabIndex = 6;
            this.dateTimePickerFechaInicioEvento.Value = new System.DateTime(2023, 10, 21, 22, 26, 0, 0);
            this.dateTimePickerFechaInicioEvento.ValueChanged += new System.EventHandler(this.dateTimePickerFechaInicioEvento_ValueChanged);
            // 
            // lbLugarEvento
            // 
            this.lbLugarEvento.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLugarEvento.Location = new System.Drawing.Point(42, 161);
            this.lbLugarEvento.Name = "lbLugarEvento";
            this.lbLugarEvento.Size = new System.Drawing.Size(100, 23);
            this.lbLugarEvento.TabIndex = 7;
            this.lbLugarEvento.Text = "Lugar:";
            // 
            // textBoxLugarEvento
            // 
            this.textBoxLugarEvento.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLugarEvento.Location = new System.Drawing.Point(162, 161);
            this.textBoxLugarEvento.Name = "textBoxLugarEvento";
            this.textBoxLugarEvento.Size = new System.Drawing.Size(300, 20);
            this.textBoxLugarEvento.TabIndex = 8;
            this.textBoxLugarEvento.TextChanged += new System.EventHandler(this.textBoxLugarEvento_TextChanged);
            // 
            // dateTimePickerHoraInicio
            // 
            this.dateTimePickerHoraInicio.CustomFormat = "HH:mm";
            this.dateTimePickerHoraInicio.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHoraInicio.Location = new System.Drawing.Point(506, 202);
            this.dateTimePickerHoraInicio.Name = "dateTimePickerHoraInicio";
            this.dateTimePickerHoraInicio.ShowUpDown = true;
            this.dateTimePickerHoraInicio.Size = new System.Drawing.Size(84, 20);
            this.dateTimePickerHoraInicio.TabIndex = 10;
            this.dateTimePickerHoraInicio.Value = new System.DateTime(2023, 10, 21, 22, 43, 0, 0);
            this.dateTimePickerHoraInicio.ValueChanged += new System.EventHandler(this.dateTimePickerHoraInicio_ValueChanged);
            // 
            // dateTimePickerHoraFin
            // 
            this.dateTimePickerHoraFin.CustomFormat = "HH:mm";
            this.dateTimePickerHoraFin.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHoraFin.Location = new System.Drawing.Point(506, 237);
            this.dateTimePickerHoraFin.Name = "dateTimePickerHoraFin";
            this.dateTimePickerHoraFin.ShowUpDown = true;
            this.dateTimePickerHoraFin.Size = new System.Drawing.Size(84, 20);
            this.dateTimePickerHoraFin.TabIndex = 12;
            this.dateTimePickerHoraFin.ValueChanged += new System.EventHandler(this.dateTimePickerHoraFin_ValueChanged);
            // 
            // gbEvento
            // 
            this.gbEvento.Controls.Add(this.dateTimePickerFechaFinEvento);
            this.gbEvento.Controls.Add(this.label1);
            this.gbEvento.Controls.Add(this.textBoxDescripcionEvento);
            this.gbEvento.Controls.Add(this.labelHoraInicio);
            this.gbEvento.Controls.Add(this.dateTimePickerHoraFin);
            this.gbEvento.Controls.Add(this.labelHoraFin);
            this.gbEvento.Controls.Add(this.dateTimePickerHoraInicio);
            this.gbEvento.Controls.Add(this.textBoxLugarEvento);
            this.gbEvento.Controls.Add(this.lbLugarEvento);
            this.gbEvento.Controls.Add(this.dateTimePickerFechaInicioEvento);
            this.gbEvento.Controls.Add(this.lblFechaEvento);
            this.gbEvento.Controls.Add(this.lblNombreEvento);
            this.gbEvento.Controls.Add(this.lblDescripcionEvento);
            this.gbEvento.Controls.Add(this.textBoxNombreEvento);
            this.gbEvento.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEvento.Location = new System.Drawing.Point(78, 91);
            this.gbEvento.Margin = new System.Windows.Forms.Padding(2);
            this.gbEvento.Name = "gbEvento";
            this.gbEvento.Padding = new System.Windows.Forms.Padding(2);
            this.gbEvento.Size = new System.Drawing.Size(654, 296);
            this.gbEvento.TabIndex = 53;
            this.gbEvento.TabStop = false;
            this.gbEvento.Text = "Evento";
            this.gbEvento.Enter += new System.EventHandler(this.gbEvento_Enter);
            // 
            // dateTimePickerFechaFinEvento
            // 
            this.dateTimePickerFechaFinEvento.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaFinEvento.Location = new System.Drawing.Point(162, 237);
            this.dateTimePickerFechaFinEvento.Name = "dateTimePickerFechaFinEvento";
            this.dateTimePickerFechaFinEvento.Size = new System.Drawing.Size(242, 20);
            this.dateTimePickerFechaFinEvento.TabIndex = 14;
            this.dateTimePickerFechaFinEvento.Value = new System.DateTime(2023, 10, 21, 22, 26, 26, 0);
            this.dateTimePickerFechaFinEvento.ValueChanged += new System.EventHandler(this.dateTimePickerFechaFinEvento_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fecha Fin:";
            // 
            // labelHoraInicio
            // 
            this.labelHoraInicio.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoraInicio.Location = new System.Drawing.Point(418, 201);
            this.labelHoraInicio.Name = "labelHoraInicio";
            this.labelHoraInicio.Size = new System.Drawing.Size(82, 23);
            this.labelHoraInicio.TabIndex = 9;
            this.labelHoraInicio.Text = "Hora Inicio:";
            // 
            // labelHoraFin
            // 
            this.labelHoraFin.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoraFin.Location = new System.Drawing.Point(418, 236);
            this.labelHoraFin.Name = "labelHoraFin";
            this.labelHoraFin.Size = new System.Drawing.Size(82, 23);
            this.labelHoraFin.TabIndex = 11;
            this.labelHoraFin.Text = "Hora Fin:";
            this.labelHoraFin.Click += new System.EventHandler(this.labelHoraFin_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::AstreiaSoft.Properties.Resources.img_cancelar_17;
            this.btnCancelar.Location = new System.Drawing.Point(627, 33);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 32);
            this.btnCancelar.TabIndex = 51;
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
            this.btnNuevo.Location = new System.Drawing.Point(78, 33);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(105, 32);
            this.btnNuevo.TabIndex = 50;
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
            this.btnBuscar.Location = new System.Drawing.Point(406, 33);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 32);
            this.btnBuscar.TabIndex = 52;
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
            this.btnEditar.Location = new System.Drawing.Point(297, 33);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(105, 32);
            this.btnEditar.TabIndex = 48;
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
            this.btnEliminar.Location = new System.Drawing.Point(517, 33);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 32);
            this.btnEliminar.TabIndex = 49;
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
            this.btnGuardar.Location = new System.Drawing.Point(188, 33);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 32);
            this.btnGuardar.TabIndex = 47;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmGestEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 514);
            this.Controls.Add(this.gbEvento);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "frmGestEvento";
            this.Text = "Gestionar Eventos";
            this.gbEvento.ResumeLayout(false);
            this.gbEvento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNombreEvento;
        private System.Windows.Forms.TextBox textBoxNombreEvento;
        private System.Windows.Forms.Label lblDescripcionEvento;
        private System.Windows.Forms.TextBox textBoxDescripcionEvento;
        private System.Windows.Forms.Label lblFechaEvento;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaInicioEvento;
        private System.Windows.Forms.Label lbLugarEvento;
        private System.Windows.Forms.TextBox textBoxLugarEvento;
        private System.Windows.Forms.DateTimePicker dateTimePickerHoraInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerHoraFin;
        private Button btnCancelar;
        private Button btnNuevo;
        private Button btnBuscar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnGuardar;
        private GroupBox gbEvento;
        private DateTimePicker dateTimePickerFechaFinEvento;
        private Label label1;
        private Label labelHoraInicio;
        private Label labelHoraFin;
    }
}