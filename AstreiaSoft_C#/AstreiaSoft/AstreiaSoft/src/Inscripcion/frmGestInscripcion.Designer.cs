using System.Windows.Forms;

namespace AstreiaSoft
{
    partial class frmGestInscripcion
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
            this.txtCodigoEst = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelImagen = new System.Windows.Forms.Label();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.labelEstudiante = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPeriodoMatricula = new System.Windows.Forms.TextBox();
            this.cbxEsValido = new System.Windows.Forms.CheckBox();
            this.gbEstudiante = new System.Windows.Forms.GroupBox();
            this.listaGrados = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreEst = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDMatricula = new System.Windows.Forms.TextBox();
            this.lblIDInscripcion = new System.Windows.Forms.Label();
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbEstudiante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigoEst
            // 
            this.txtCodigoEst.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtCodigoEst.Location = new System.Drawing.Point(136, 41);
            this.txtCodigoEst.Name = "txtCodigoEst";
            this.txtCodigoEst.ReadOnly = true;
            this.txtCodigoEst.Size = new System.Drawing.Size(89, 21);
            this.txtCodigoEst.TabIndex = 29;
            this.txtCodigoEst.Text = "20170569";
            // 
            // labelTitulo
            // 
            this.labelTitulo.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(316, -32);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(125, 23);
            this.labelTitulo.TabIndex = 17;
            this.labelTitulo.Text = "Gestión de Inscripciones";
            // 
            // labelImagen
            // 
            this.labelImagen.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImagen.Location = new System.Drawing.Point(38, 46);
            this.labelImagen.Name = "labelImagen";
            this.labelImagen.Size = new System.Drawing.Size(131, 23);
            this.labelImagen.TabIndex = 20;
            this.labelImagen.Text = "Comprobante Pago:";
            // 
            // labelMatricula
            // 
            this.labelMatricula.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatricula.Location = new System.Drawing.Point(274, 86);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(76, 23);
            this.labelMatricula.TabIndex = 23;
            this.labelMatricula.Text = "Matrícula:";
            // 
            // labelEstudiante
            // 
            this.labelEstudiante.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstudiante.Location = new System.Drawing.Point(20, 41);
            this.labelEstudiante.Name = "labelEstudiante";
            this.labelEstudiante.Size = new System.Drawing.Size(76, 23);
            this.labelEstudiante.TabIndex = 25;
            this.labelEstudiante.Text = "Codigo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPeriodoMatricula);
            this.groupBox1.Controls.Add(this.cbxEsValido);
            this.groupBox1.Controls.Add(this.gbEstudiante);
            this.groupBox1.Controls.Add(this.txtIDMatricula);
            this.groupBox1.Controls.Add(this.lblIDInscripcion);
            this.groupBox1.Controls.Add(this.labelMatricula);
            this.groupBox1.Controls.Add(this.pictureBoxImagen);
            this.groupBox1.Controls.Add(this.labelImagen);
            this.groupBox1.Controls.Add(this.labelTitulo);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(78, 95);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(654, 377);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inscripcion";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtPeriodoMatricula
            // 
            this.txtPeriodoMatricula.Location = new System.Drawing.Point(364, 84);
            this.txtPeriodoMatricula.Name = "txtPeriodoMatricula";
            this.txtPeriodoMatricula.ReadOnly = true;
            this.txtPeriodoMatricula.Size = new System.Drawing.Size(109, 20);
            this.txtPeriodoMatricula.TabIndex = 38;
            this.txtPeriodoMatricula.Text = "2023-2024";
            // 
            // cbxEsValido
            // 
            this.cbxEsValido.AutoSize = true;
            this.cbxEsValido.Location = new System.Drawing.Point(40, 238);
            this.cbxEsValido.Margin = new System.Windows.Forms.Padding(2);
            this.cbxEsValido.Name = "cbxEsValido";
            this.cbxEsValido.Size = new System.Drawing.Size(152, 20);
            this.cbxEsValido.TabIndex = 37;
            this.cbxEsValido.Text = "Comprobante válido? ";
            this.cbxEsValido.UseVisualStyleBackColor = true;
            this.cbxEsValido.CheckedChanged += new System.EventHandler(this.cbxEsValido_CheckedChanged);
            // 
            // gbEstudiante
            // 
            this.gbEstudiante.Controls.Add(this.listaGrados);
            this.gbEstudiante.Controls.Add(this.label1);
            this.gbEstudiante.Controls.Add(this.txtNombreEst);
            this.gbEstudiante.Controls.Add(this.label2);
            this.gbEstudiante.Controls.Add(this.labelEstudiante);
            this.gbEstudiante.Controls.Add(this.txtCodigoEst);
            this.gbEstudiante.Location = new System.Drawing.Point(276, 130);
            this.gbEstudiante.Margin = new System.Windows.Forms.Padding(2);
            this.gbEstudiante.Name = "gbEstudiante";
            this.gbEstudiante.Padding = new System.Windows.Forms.Padding(2);
            this.gbEstudiante.Size = new System.Drawing.Size(337, 156);
            this.gbEstudiante.TabIndex = 36;
            this.gbEstudiante.TabStop = false;
            this.gbEstudiante.Text = "Estudiante";
            // 
            // listaGrados
            // 
            this.listaGrados.FormattingEnabled = true;
            this.listaGrados.Location = new System.Drawing.Point(136, 108);
            this.listaGrados.Name = "listaGrados";
            this.listaGrados.Size = new System.Drawing.Size(181, 23);
            this.listaGrados.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 37;
            this.label1.Text = "Asignar Grado:";
            // 
            // txtNombreEst
            // 
            this.txtNombreEst.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtNombreEst.Location = new System.Drawing.Point(136, 74);
            this.txtNombreEst.Name = "txtNombreEst";
            this.txtNombreEst.ReadOnly = true;
            this.txtNombreEst.Size = new System.Drawing.Size(181, 21);
            this.txtNombreEst.TabIndex = 35;
            this.txtNombreEst.Text = "LP2";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nombre y Apellido:";
            // 
            // txtIDMatricula
            // 
            this.txtIDMatricula.Location = new System.Drawing.Point(364, 44);
            this.txtIDMatricula.Name = "txtIDMatricula";
            this.txtIDMatricula.ReadOnly = true;
            this.txtIDMatricula.Size = new System.Drawing.Size(70, 20);
            this.txtIDMatricula.TabIndex = 35;
            this.txtIDMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIDInscripcion
            // 
            this.lblIDInscripcion.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDInscripcion.Location = new System.Drawing.Point(274, 46);
            this.lblIDInscripcion.Name = "lblIDInscripcion";
            this.lblIDInscripcion.Size = new System.Drawing.Size(106, 23);
            this.lblIDInscripcion.TabIndex = 34;
            this.lblIDInscripcion.Text = "ID Inscripcion:";
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxImagen.Image = global::AstreiaSoft.Properties.Resources.aHT6ZAVbBJ;
            this.pictureBoxImagen.Location = new System.Drawing.Point(40, 72);
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.Size = new System.Drawing.Size(200, 150);
            this.pictureBoxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImagen.TabIndex = 21;
            this.pictureBoxImagen.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::AstreiaSoft.Properties.Resources.img_cancelar_17;
            this.btnCancelar.Location = new System.Drawing.Point(627, 36);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 32);
            this.btnCancelar.TabIndex = 45;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::AstreiaSoft.Properties.Resources.img_buscar_17;
            this.button2.Location = new System.Drawing.Point(409, 36);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 32);
            this.button2.TabIndex = 46;
            this.button2.Text = "Buscar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::AstreiaSoft.Properties.Resources.img_guardar_17;
            this.btnGuardar.Location = new System.Drawing.Point(518, 36);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 32);
            this.btnGuardar.TabIndex = 41;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmGestInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGuardar);
            this.Name = "frmGestInscripcion";
            this.Text = "frmGestInscripcion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbEstudiante.ResumeLayout(false);
            this.gbEstudiante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox txtCodigoEst;
        private Label labelTitulo;
        private Label labelImagen;
        private PictureBox pictureBoxImagen;
        private Label labelMatricula;
        private Label labelEstudiante;
        private Button btnCancelar;
        private Button button2;
        private Button btnGuardar;
        private GroupBox groupBox1;
        private Label lblIDInscripcion;
        private TextBox txtIDMatricula;
        private GroupBox gbEstudiante;
        private TextBox txtNombreEst;
        private Label label2;
        private CheckBox cbxEsValido;
        private TextBox txtPeriodoMatricula;
        private Label label1;
        private ComboBox listaGrados;
    }
}