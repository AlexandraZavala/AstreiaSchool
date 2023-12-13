
using AstreiaSoft.UserWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstreiaSoft
{
    public partial class frmGestEstudiantes : Form 
    {

        private Estado _estado;
        private string _rutaFoto;
        private Panel panelUsuario;
        private UserWSClient _daoUserWS;
        private estudiante _estudiante;
        public frmGestEstudiantes(Panel panelUsuario)
        {
            InitializeComponent();
            this.panelUsuario = panelUsuario;
            _estado = Estado.Inicial;
            _daoUserWS = new UserWSClient();
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    btnNuevoEstudiante.Enabled = true;
                    btnGuardarEstudiante.Enabled = false;
                    btnBuscarEstudiante.Enabled = true;
                    btnEditarEstudiante.Enabled = false;
                    btnEliminarEstudiante.Enabled = false;
                    btnCancelarEstudiante.Enabled = true;
                    gbDatosGeneralesEstudiante.Enabled = false;
                    gbDatosAcademicosEstudiante.Enabled = false;
                    txtIDEstudiante.Enabled = false;
                    txtDNIEstudiante.Enabled = false;
                    txtDNIEstudiante.ReadOnly = false;
                    txtNombreEstudiante.Enabled = false;
                    txtNombreEstudiante.ReadOnly = false;
                    txtApellidoPaternoEstudiante.Enabled = false;
                    txtApellidoPaternoEstudiante.ReadOnly = false;
                    txtApellidoMaternoEstudiante.Enabled = false;
                    txtApellidoMaternoEstudiante.ReadOnly = false;
                    rbMasculinoEstudiante.Enabled = false;
                    rbFemeninoEstudiante.Enabled = false;
                    dtpFechaNacimientoEstudiante.Enabled = false;
                    txtTelefonoEstudiante.Enabled=false;
                    txtTelefonoEstudiante.ReadOnly = false;
                    txtDireccionEstudiante.Enabled = false; 
                    txtDireccionEstudiante.ReadOnly=false;
                    txtCorreoEstudiante.Enabled = false;
                    txtCorreoEstudiante.ReadOnly = false;
                    btnSubirFotoEstudiante.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevoEstudiante.Enabled = false;
                    btnGuardarEstudiante.Enabled = true;
                    btnBuscarEstudiante.Enabled = false;
                    btnEditarEstudiante.Enabled = false;
                    btnEliminarEstudiante.Enabled = false;
                    btnCancelarEstudiante.Enabled = true;
                    gbDatosGeneralesEstudiante.Enabled = true;
                    gbDatosAcademicosEstudiante.Enabled = true;
                    txtIDEstudiante.Enabled = false;
                    txtDNIEstudiante.Enabled = true;
                    txtDNIEstudiante.ReadOnly = false;
                    txtNombreEstudiante.Enabled = true;
                    txtNombreEstudiante.ReadOnly = false;
                    txtApellidoPaternoEstudiante.Enabled = true;
                    txtApellidoPaternoEstudiante.ReadOnly = false;
                    txtApellidoMaternoEstudiante.Enabled = true;
                    txtApellidoMaternoEstudiante.ReadOnly = false;
                    rbMasculinoEstudiante.Enabled = true;
                    rbFemeninoEstudiante.Enabled = true;
                    dtpFechaNacimientoEstudiante.Enabled = true;
                    txtTelefonoEstudiante.Enabled = true;
                    txtTelefonoEstudiante.ReadOnly = false;
                    txtDireccionEstudiante.Enabled = true;
                    txtDireccionEstudiante.ReadOnly = false;
                    txtCorreoEstudiante.Enabled = true;
                    txtCorreoEstudiante.ReadOnly = false;
                    btnSubirFotoEstudiante.Enabled = true;
                    break;
                case Estado.Editar:
                    btnNuevoEstudiante.Enabled = false;
                    btnGuardarEstudiante.Enabled = true;
                    btnCancelarEstudiante.Enabled = true;
                    btnBuscarEstudiante.Enabled = false;
                    btnEditarEstudiante.Enabled = false;
                    btnEliminarEstudiante.Enabled = false;
                    gbDatosGeneralesEstudiante.Enabled = true;
                    gbDatosAcademicosEstudiante.Enabled = true;
                    txtIDEstudiante.Enabled = true;
                    txtDNIEstudiante.Enabled = true;
                    txtDNIEstudiante.ReadOnly = false;
                    txtNombreEstudiante.Enabled = true;
                    txtNombreEstudiante.ReadOnly = false;
                    txtApellidoPaternoEstudiante.Enabled = true;
                    txtApellidoPaternoEstudiante.ReadOnly = false;
                    txtApellidoMaternoEstudiante.Enabled = true;
                    txtApellidoMaternoEstudiante.ReadOnly = false;
                    rbMasculinoEstudiante.Enabled = true;
                    rbFemeninoEstudiante.Enabled = true;
                    dtpFechaNacimientoEstudiante.Enabled = true;
                    txtTelefonoEstudiante.Enabled = true;
                    txtTelefonoEstudiante.ReadOnly = false;
                    txtDireccionEstudiante.Enabled = true;
                    txtDireccionEstudiante.ReadOnly = false;
                    txtCorreoEstudiante.Enabled = true;
                    txtCorreoEstudiante.ReadOnly = false;
                    btnSubirFotoEstudiante.Enabled = true;
                    break;
                case Estado.Buscar:
                    btnNuevoEstudiante.Enabled = false;
                    btnGuardarEstudiante.Enabled = false;
                    btnCancelarEstudiante.Enabled = true;
                    btnBuscarEstudiante.Enabled = false;
                    btnEditarEstudiante.Enabled = true;
                    btnEliminarEstudiante.Enabled = true;
                    gbDatosGeneralesEstudiante.Enabled = true;
                    gbDatosAcademicosEstudiante.Enabled = true;
                    txtIDEstudiante.Enabled = true;
                    txtDNIEstudiante.Enabled = true;
                    txtDNIEstudiante.ReadOnly = true;
                    txtNombreEstudiante.Enabled = true;
                    txtNombreEstudiante.ReadOnly = true;
                    txtApellidoPaternoEstudiante.Enabled = true;
                    txtApellidoPaternoEstudiante.ReadOnly = true;
                    txtApellidoMaternoEstudiante.Enabled = true;
                    txtApellidoMaternoEstudiante.ReadOnly = true;
                    rbMasculinoEstudiante.Enabled = false;
                    rbFemeninoEstudiante.Enabled = false;
                    dtpFechaNacimientoEstudiante.Enabled = false;
                    txtTelefonoEstudiante.Enabled = true;
                    txtTelefonoEstudiante.ReadOnly = true;
                    txtDireccionEstudiante.Enabled = true;
                    txtDireccionEstudiante.ReadOnly = true;
                    txtCorreoEstudiante.Enabled = true;
                    txtCorreoEstudiante.ReadOnly = true;
                    btnSubirFotoEstudiante.Enabled = false;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtIDEstudiante.Text = "";
            txtDNIEstudiante.Text = "";
            txtNombreEstudiante.Text = "";
            txtApellidoPaternoEstudiante.Text = "";
            txtApellidoMaternoEstudiante.Text = "";
            rbMasculinoEstudiante.Checked = false;
            rbFemeninoEstudiante.Checked = false;
            dtpFechaNacimientoEstudiante.Value = DateTime.Now;
            txtTelefonoEstudiante.Text = "";
            txtDireccionEstudiante.Text = "";
            txtCorreoEstudiante.Text = "";
            pbFotoEstudiante.Image = null;
        }

        private void btnNuevoEstudiante_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            _estado = Estado.Nuevo;
            _estudiante = new estudiante();
            establecerEstadoComponentes();
        }

        public static string GenerateRandomPassword(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            using (var rng = new RNGCryptoServiceProvider())
            {
                StringBuilder sb = new StringBuilder();
                byte[] uintBuffer = new byte[sizeof(uint)];

                while (length-- > 0)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    sb.Append(validChars[(int)(num % (uint)validChars.Length)]);
                }

                return sb.ToString();
            }
        }


        private void btnGuardarEstudiante_Click(object sender, EventArgs e)
        {
            if (!validarCamposVacios())
            {
                return;
            }
            _estudiante.DNI = txtDNIEstudiante.Text;
            _estudiante.nombre = txtNombreEstudiante.Text;
            _estudiante.apellidoPaterno = txtApellidoPaternoEstudiante.Text;
            _estudiante.apellidoMaterno = txtApellidoMaternoEstudiante.Text;
            if (rbMasculinoEstudiante.Checked) _estudiante.genero = "Masculino";
            else _estudiante.genero = "Femenino";
            _estudiante.fechaNacimiento = dtpFechaNacimientoEstudiante.Value;
            _estudiante.fechaNacimientoSpecified = true;
            _estudiante.telefono = txtTelefonoEstudiante.Text;
            _estudiante.direccion = txtDireccionEstudiante.Text;
            _estudiante.correo = txtCorreoEstudiante.Text;
            estudiante E1 = _estudiante;

            if (_estado == Estado.Nuevo)
            {
                _estudiante.contrasenha = GenerateRandomPassword(8);
                int resultado = _daoUserWS.insertarEstudiante(_estudiante);
                if (resultado != 0)
                {
                    txtIDEstudiante.Text = _estudiante.idUsuario.ToString();
                    MessageBox.Show("El estudiante se ha registrado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    establecerEstadoComponentes();
                }
                else
                    MessageBox.Show("Hubo un error en el registro", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //_estudiante.idUsuario = int.Parse(txtIDEstudiante.Text);
                int resultado = _daoUserWS.modificarEstudiante(_estudiante);
                if (resultado != 0)
                {
                    MessageBox.Show("El estudiante se ha modificado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    establecerEstadoComponentes();
                }
                else
                    MessageBox.Show("Hubo un error en al modificar", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarEstudiante_Click(object sender, EventArgs e)
        {
            _estado = Estado.Editar;
            establecerEstadoComponentes();
        }

        private void btnBuscarEstudiante_Click(object sender, EventArgs e)
        {
            _estado = Estado.Buscar;
            establecerEstadoComponentes();
            frmBusquedaEstudiantes formBusqEst = new frmBusquedaEstudiantes(panelUsuario);
            formBusqEst.OnEstudianteSeleccionado += formBusqEst_OnEstudianteSeleccionado;
            mostrarFormulario(formBusqEst);
        }

        private void formBusqEst_OnEstudianteSeleccionado(estudiante estudianteElegido)
        {
            _estudiante = estudianteElegido;
            txtIDEstudiante.Text = _estudiante.idUsuario.ToString();
            txtDNIEstudiante.Text = _estudiante.DNI;
            txtNombreEstudiante.Text = _estudiante.nombre;
            txtApellidoPaternoEstudiante.Text = _estudiante.apellidoPaterno;
            txtApellidoMaternoEstudiante.Text = _estudiante.apellidoMaterno;
            if (_estudiante.genero == "Masculino") rbMasculinoEstudiante.Checked = true;
            else rbFemeninoEstudiante.Checked = true;
            dtpFechaNacimientoEstudiante.Value = _estudiante.fechaNacimiento;
            txtTelefonoEstudiante.Text = _estudiante.telefono;
            txtDireccionEstudiante.Text = _estudiante.direccion;
            txtCorreoEstudiante.Text = _estudiante.correo;
            if(_estudiante.foto!= null)
            {
                MemoryStream ms = new MemoryStream(_estudiante.foto);
                pbFotoEstudiante.Image = new Bitmap(ms);
            }
            
        }
        private void btnEliminarEstudiante_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este estudiante?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Se llama al web service para eliminar el evento
                int resultadoEliminacion = _daoUserWS.eliminarEstudiante(_estudiante.idUsuario);

                if (resultadoEliminacion > 0)
                {
                    MessageBox.Show("Se ha eliminado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    limpiarComponentes();
                    establecerEstadoComponentes();
                }
                else
                {
                    MessageBox.Show("Hubo un error al eliminar el estudiante.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelarEstudiante_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        public void mostrarFormulario(Form form)
        {
            panelUsuario.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            panelUsuario.Controls.Add(form);
            form.Visible = true;
        }

        private void btnSubirFotoEstudiante_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdFoto.ShowDialog() == DialogResult.OK)
                {
                    _rutaFoto = ofdFoto.FileName;
                    pbFotoEstudiante.Image = Image.FromFile(_rutaFoto);

                    FileStream fs = new FileStream(_rutaFoto, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    _estudiante.foto = br.ReadBytes((int)fs.Length);
                    fs.Close();
                    
                    MemoryStream ms = new MemoryStream(_estudiante.foto);
                    pbFotoEstudiante.Image = new Bitmap(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }


        private bool validarCamposVacios()
        {
            if (txtDNIEstudiante.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el DNI del docente", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            try
            {
                Int32.Parse(txtDNIEstudiante.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar un número como DNI", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            //DNI solo puede ser de 8 digitos
            if (txtDNIEstudiante.Text.Trim().Length != 8)
            {
                MessageBox.Show("Debe ingresar un DNI que tenga 8 dígitos", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtNombreEstudiante.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el nombre del docente", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtApellidoPaternoEstudiante.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el apellido paterno del docente", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtApellidoMaternoEstudiante.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el apellido materno del docente", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (rbMasculinoEstudiante.Checked == false && rbFemeninoEstudiante.Checked == false)
            {
                MessageBox.Show("Debe indicar el género del docente", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtTelefonoEstudiante.Text.Trim().Length == 0)
            {

                MessageBox.Show("Debe ingresar el telefono del docente", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            try
            {
                Int32.Parse(txtTelefonoEstudiante.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar un número como telefono", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            //Telefono contenga 7 digitos
            if (txtTelefonoEstudiante.Text.Trim().Length != 7)
            {
                MessageBox.Show("Debe ingresar 7 digitos para el telefono", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            //Telefono solo se ingresen numeros --> en otra funcion de keypress
            if (txtDireccionEstudiante.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar la dirección del docente", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            //Para validar que se cargo una imagen de perfil.
            if (pbFotoEstudiante == null)
            {
                MessageBox.Show("Debe cargar una foto de perfil", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }


        //Solamente ingreso de datos numericos
        private void txtDNIEstudiante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefonoEstudiante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        /*
        private void txtDNIEstudiante_Leave(object sender, EventArgs e)
        {
            usuario usuario = new usuario();
            usuario = _daoUSERWS.encontrarUsuario(txtDNIEstudiante.Text);
            if (usuario.idUsuario != 0)
            {
                txtIDEstudiante.Text = usuario.idUsuario.ToString();
                txtDNIEstudiante.Text = usuario.DNI;
                txtNombreEstudiante.Text = usuario.nombre;
                txtApellidoPaternoEstudiante.Text = usuario.apellidoPaterno;
                txtApellidoMaternoEstudiante.Text = usuario.apellidoMaterno;
                if (usuario.genero == "Masculino") rbMasculinoEstudiante.Checked = true;
                else rbFemeninoEstudiante.Checked = true;
                dtpFechaNacimientoEstudiante.Value = usuario.fechaNacimiento;
                txtTelefonoEstudiante.Text = usuario.telefono;
                txtDireccionEstudiante.Text = usuario.direccion;
                txtCorreoEstudiante.Text = usuario.correo;
                txtContrasenhaEstudiante.Text = usuario.contrasenha;
                MemoryStream ms = new MemoryStream(usuario.foto);
                pbFotoEstudiante.Image = new Bitmap(ms);
            }
        }*/


    }
}
