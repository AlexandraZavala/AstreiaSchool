using AstreiaSoft.InfraWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstreiaSoft
{
    public partial class frmImgSeccion : Form
    {
        private frmGestAulas _parentForm;
        private seccion _currentSeccion;
        public seccion AssociatedSeccion { get; set; }
        private static List<frmImgSeccion> allForms = new List<frmImgSeccion>();
        public frmImgSeccion(seccion sec, frmGestAulas parentForm)
        {
            InitializeComponent();

            _currentSeccion = sec;
            _parentForm = parentForm;

            this.Paint += frmImgSeccion_Paint;

            // Asociar el evento Click del PictureBox al manejador de eventos
            pbImgSeccion.Click += frmImgSeccion_Click;

            // Asociar el evento Click del Form al manejador de eventos
            this.Click += frmImgSeccion_Click;


            if (_currentSeccion.imagen != null && _currentSeccion.imagen.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(_currentSeccion.imagen))
                {
                    pbImgSeccion.Image = Image.FromStream(ms);
                    pbImgSeccion.SizeMode = PictureBoxSizeMode.StretchImage;

                }
            }

            this.BackColor = Color.White;
            // Añadir esta instancia a la lista estática
            allForms.Add(this);

            this.FormClosed += (sender, args) =>
            {
                // Eliminar la instancia de la lista cuando se cierre
                allForms.Remove(this);
            };

        }

        public seccion GetSeccion()
        {
            return AssociatedSeccion;
        }
        public seccion SeccionSeleccionada { get; set; }

        public bool IsSelected { get; set; }

        private void frmImgSeccion_Paint(object sender, PaintEventArgs e)
        {
            // Define el color y el grosor del borde
            Color borderColor = Color.Black;
            int borderThickness = 1;

            // Dibuja un rectángulo alrededor del formulario
            e.Graphics.DrawRectangle(new Pen(borderColor, borderThickness), 0, 0, this.Width - borderThickness, this.Height - borderThickness);
        }

        private void frmImgSeccion_Click(object sender, EventArgs e)
        {
            _parentForm.EstablecerSeccionSeleccionada(_currentSeccion);

            foreach (var form in allForms)
            {
                form.BackColor = Color.White;
            }

            // Establecer el color de fondo del formulario clickeado a LightGray
            this.BackColor = Color.LightGray;
        }
    }
}
