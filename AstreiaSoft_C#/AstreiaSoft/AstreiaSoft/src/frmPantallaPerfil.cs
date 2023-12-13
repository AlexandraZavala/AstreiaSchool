
using AstreiaSoft.UserWS;
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
    public partial class frmPantallaPerfil : Form
    {
        private Panel panelContenido;
        private usuario _usuario;
        private UserWSClient _daoUserWS;
        private int idUsuario;
        public frmPantallaPerfil(Panel panelContenido, int idUsuario)
        {
            InitializeComponent();
            this.panelContenido = panelContenido;
            _daoUserWS = new UserWSClient();
            _usuario = _daoUserWS.encontrarUsuario(idUsuario.ToString());
            txtNombrePerfil.Text = _usuario.nombre;
            txtCorreoPerfil.Text = _usuario.correo;
            txtDNIPerfil.Text = _usuario.DNI;
            txtNombreCompletoPerfil.Text = _usuario.nombre + " " + _usuario.apellidoPaterno + " " + _usuario.apellidoMaterno;
            txtGeneroPerfil.Text = _usuario.genero;
            txtFechaNacimientoPerfil.Text = _usuario.fechaNacimiento.ToString("dd/MM/yyyy");
            txtTelefonoPerfil.Text = _usuario.telefono;
            txtDireccionPerfil.Text = _usuario.direccion;

            if(_usuario.foto != null)
            {
                MemoryStream ms = new MemoryStream(_usuario.foto);
                pbFotoPerfil.Image = new Bitmap(ms);
            }
            
        }

        private void panelLinea_Paint(object sender, PaintEventArgs e)
        {
            // Obtiene el objeto Graphics del Panel.
            Graphics g = e.Graphics;

            // Define los puntos de inicio y final de la línea.
            Point startPoint = new Point(10, 10); // Cambia estas coordenadas según tus necesidades.
            Point endPoint = new Point(500, 10); // Cambia estas coordenadas según tus necesidades.

            // Crea un objeto Pen con el color y el grosor de línea deseados.
            Pen pen = new Pen(Color.Black, 2); // Cambia el color y el grosor según tus necesidades.

            // Dibuja la línea.
            g.DrawLine(pen, startPoint, endPoint);

            // Limpia el objeto Pen y el objeto Graphics (opcional).
            pen.Dispose();
            g.Dispose();
        }

        private void pbFoto_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pbFotoPerfil.Width - 1, pbFotoPerfil.Height - 1);
            Region rg = new Region(gp);
            pbFotoPerfil.Region = rg;
        }

        private void btnEditarAdmin_Click(object sender, EventArgs e)
        {
            frmEditarPerfil formEditarPerf = new frmEditarPerfil(panelContenido, _usuario);
            formEditarPerf.OnUsuarioSeleccionado += formEditarPerf_OnUsuarioSeleccionado;
            mostrarFormulario(formEditarPerf);
        }

        private void formEditarPerf_OnUsuarioSeleccionado(usuario usuarioElegido)
        {
            _usuario = new usuario();
            _usuario = usuarioElegido;
            txtNombrePerfil.Text = _usuario.nombre;
            txtCorreoPerfil.Text = _usuario.correo;
            txtDNIPerfil.Text = _usuario.DNI;
            txtNombreCompletoPerfil.Text = _usuario.nombre + " " + _usuario.apellidoPaterno + " " + _usuario.apellidoMaterno;
            txtGeneroPerfil.Text = _usuario.genero;
            txtFechaNacimientoPerfil.Text = _usuario.fechaNacimiento.ToString("dd/MM/yyyy");
            txtTelefonoPerfil.Text = _usuario.telefono;
            txtDireccionPerfil.Text = _usuario.direccion;

            // Verificar si hay una foto antes de intentar mostrarla
            if (_usuario.foto != null && _usuario.foto.Length > 0)
            {
                // Si hay una foto, mostrarla
                try
                {
                    MemoryStream ms = new MemoryStream(_usuario.foto);
                    pbFotoPerfil.Image = new Bitmap(ms);
                }
                catch (ArgumentException ex)
                {
                    // Manejar la excepción si ocurre un problema al cargar la imagen
                    Console.WriteLine("Error al cargar la imagen: " + ex.Message);
                }
            }
            else
            {
                // Si no hay foto, podrías asignar una imagen predeterminada o dejar el cuadro de imagen en blanco
                pbFotoPerfil.Image = null; // O asignar una imagen predeterminada si tienes una
            }
        }

        public void mostrarFormulario(Form form)
        {
            panelContenido.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            panelContenido.Controls.Add(form);
            form.Visible = true;
        }

    }
}
