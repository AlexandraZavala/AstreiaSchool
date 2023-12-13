
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
    public partial class frmEditarPerfil : Form
    {
        private Panel panelContenido;
        private usuario _usuario;
        private string _rutaFoto;
        private UserWSClient _daoUserWS;

        private usuario _usuarioSeleccionado;

        public delegate void UsuarioSeleccionadoHandler(usuario usuario);
        public event UsuarioSeleccionadoHandler OnUsuarioSeleccionado;

        public usuario UsuarioSeleccionado { get => _usuarioSeleccionado; set => _usuarioSeleccionado = value; }
        public frmEditarPerfil(Panel panelContenido, usuario usuarioLogin)
        {
            InitializeComponent();
            this.panelContenido = panelContenido;
            _daoUserWS = new UserWSClient();
            _usuario = usuarioLogin;
            txtNombrePerfil.Text = _usuario.nombre;
            txtDNI.Text = _usuario.DNI;
            txtApellidoPaterno.Text = _usuario.apellidoPaterno;
            txtApellidoMaterno.Text = _usuario.apellidoMaterno;
            if (_usuario.genero == "Masculino") rbMasculinoPerfil.Checked = true;
            else rbFemeninoPerfil.Checked = true;
            dtpFechaNacimientoPerfil.Value = _usuario.fechaNacimiento;
            txtTelefono.Text = _usuario.telefono;
            txtDireccion.Text = _usuario.direccion;
            if(_usuario.foto != null)
            {
                MemoryStream ms = new MemoryStream(_usuario.foto);
                pbFoto.Image = new Bitmap(ms);
            }

            

        }

        private void btnGuardarPerfil_Click(object sender, EventArgs e)
        {

            
            _usuario.DNI = txtDNI.Text;
            _usuario.nombre = txtNombrePerfil.Text;
            _usuario.apellidoPaterno = txtApellidoPaterno.Text;
            _usuario.apellidoMaterno = txtApellidoMaterno.Text;
            if (rbMasculinoPerfil.Checked) _usuario.genero = "Masculino";
            else _usuario.genero = "Femenino";
            _usuario.fechaNacimiento = dtpFechaNacimientoPerfil.Value;
            _usuario.fechaNacimientoSpecified = true;
            _usuario.telefono = txtTelefono.Text;
            _usuario.direccion = txtDireccion.Text;

            int resultado = _daoUserWS.editarPerfil(_usuario);
            if (resultado != 0)
            {
                MessageBox.Show("El perfil se ha editado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UsuarioSeleccionado = _daoUserWS.encontrarUsuario(_usuario.idUsuario.ToString());
                this.Close();
                OnUsuarioSeleccionado?.Invoke(UsuarioSeleccionado);
                panelContenido.Controls.Clear();
                panelContenido.Controls.Add(frmPantallaPrincipal.formularios[frmPantallaPrincipal.formularios.Count - 1]);
            }
            else
                MessageBox.Show("Hubo un error en al editar", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRegresarPerfil_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();
            panelContenido.Controls.Add(frmPantallaPrincipal.formularios[frmPantallaPrincipal.formularios.Count - 1]);
        }

        private void btnSubirPerfil_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdFoto.ShowDialog() == DialogResult.OK)
                {
                    _rutaFoto = ofdFoto.FileName;
                    pbFoto.Image = Image.FromFile(_rutaFoto);

                    FileStream fs = new FileStream(_rutaFoto, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    _usuario.foto = br.ReadBytes((int)fs.Length);
                    fs.Close();

                    MemoryStream ms = new MemoryStream(_usuario.foto);
                    pbFoto.Image = new Bitmap(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

    }
}
