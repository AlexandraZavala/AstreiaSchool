
using AstreiaSoft.UserWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstreiaSoft
{
    public partial class frmGestAdminAcad : Form
    {

        private Estado _estado;
        private string _rutaFoto;
        private Panel panelUsuario;
        private UserWSClient _daoUserWS;
        private administradorAcademico _administrador;

        public frmGestAdminAcad(Panel panelUsuario)
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
                    btnNuevoAdmin.Enabled = true;
                    btnGuardarAdmin.Enabled = false;
                    btnBuscarAdmin.Enabled = true;
                    btnEditarAdmin.Enabled = false;
                    btnEliminarAdmin.Enabled = false;
                    btnCancelarAdmin.Enabled = true;
                    gbDatosGeneralesAdmin.Enabled = false;
                    gbDatosAcademicosAdmin.Enabled = false;
                    txtIDAdmin.Enabled = false;
                    txtDNIAdmin.Enabled = false;
                    txtDNIAdmin.ReadOnly = false;
                    txtNombreAdmin.Enabled = false;
                    txtNombreAdmin.ReadOnly = false;
                    txtApellidoPaternoAdmin.Enabled = false;
                    txtApellidoPaternoAdmin.ReadOnly = false;
                    txtApellidoMaternoAdmin.Enabled = false;
                    txtApellidoMaternoAdmin.ReadOnly = false;
                    rbMasculinoAdmin.Enabled = false;
                    rbFemeninoAdmin.Enabled = false;
                    dtpFechaNacimientoAdmin.Enabled = false;
                    txtTelefonoAdmin.Enabled = false;
                    txtTelefonoAdmin.ReadOnly = false;
                    txtDireccionAdmin.Enabled = false;
                    txtDireccionAdmin.ReadOnly = false;
                    txtCorreoAdmin.Enabled = false;
                    txtCorreoAdmin.ReadOnly = false;
                    txtContrasenhaAdmin.Enabled = false;
                    txtContrasenhaAdmin.ReadOnly = false;
                    dtpFechaContratacionAdmin.Enabled = false;
                    txtSalarioAdmin.Enabled = false;
                    txtSalarioAdmin.ReadOnly = false;
                    txtExperienciaAdmin.Enabled = false;
                    txtExperienciaAdmin.ReadOnly = false;
                    btnSubirFotoAdmin.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevoAdmin.Enabled = false;
                    btnGuardarAdmin.Enabled = true;
                    btnBuscarAdmin.Enabled = false;
                    btnEditarAdmin.Enabled = false;
                    btnEliminarAdmin.Enabled = false;
                    btnCancelarAdmin.Enabled = true;
                    gbDatosGeneralesAdmin.Enabled = true;
                    gbDatosAcademicosAdmin.Enabled = true;
                    txtIDAdmin.Enabled = false;
                    txtDNIAdmin.Enabled = true;
                    txtDNIAdmin.ReadOnly = false;
                    txtNombreAdmin.Enabled = true;
                    txtNombreAdmin.ReadOnly = false;
                    txtApellidoPaternoAdmin.Enabled = true;
                    txtApellidoPaternoAdmin.ReadOnly = false;
                    txtApellidoMaternoAdmin.Enabled = true;
                    txtApellidoMaternoAdmin.ReadOnly = false;
                    rbMasculinoAdmin.Enabled = true;
                    rbFemeninoAdmin.Enabled = true;
                    dtpFechaNacimientoAdmin.Enabled = true;
                    txtTelefonoAdmin.Enabled = true;
                    txtTelefonoAdmin.ReadOnly = false;
                    txtDireccionAdmin.Enabled = true;
                    txtDireccionAdmin.ReadOnly = false;
                    txtCorreoAdmin.Enabled = true;
                    txtCorreoAdmin.ReadOnly = false;
                    txtContrasenhaAdmin.Enabled = true;
                    txtContrasenhaAdmin.ReadOnly = false;
                    dtpFechaContratacionAdmin.Enabled = true;
                    txtSalarioAdmin.Enabled = true;
                    txtSalarioAdmin.ReadOnly = false;
                    txtExperienciaAdmin.Enabled = true;
                    txtExperienciaAdmin.ReadOnly = false;
                    btnSubirFotoAdmin.Enabled = true;
                    break;

                case Estado.Existe:
                    txtIDAdmin.Enabled = false;
                    txtDNIAdmin.Enabled = false;
                    txtDNIAdmin.ReadOnly = true;
                    txtNombreAdmin.Enabled = true;
                    txtNombreAdmin.ReadOnly = false;
                    txtApellidoPaternoAdmin.Enabled = true;
                    txtApellidoPaternoAdmin.ReadOnly = false;
                    txtApellidoMaternoAdmin.Enabled = true;
                    txtApellidoMaternoAdmin.ReadOnly = false;
                    rbMasculinoAdmin.Enabled = false;
                    rbFemeninoAdmin.Enabled = false;
                    dtpFechaNacimientoAdmin.Enabled = false;
                    txtTelefonoAdmin.Enabled = true;
                    txtTelefonoAdmin.ReadOnly = false;
                    txtDireccionAdmin.Enabled = true;
                    txtDireccionAdmin.ReadOnly = false;
                    txtCorreoAdmin.Enabled = false;
                    txtCorreoAdmin.ReadOnly = true;
                    txtContrasenhaAdmin.Enabled = false;
                    txtContrasenhaAdmin.ReadOnly = true;
                    dtpFechaContratacionAdmin.Enabled = true;
                    txtSalarioAdmin.Enabled = true;
                    txtSalarioAdmin.ReadOnly = false;
                    txtExperienciaAdmin.Enabled = true;
                    txtExperienciaAdmin.ReadOnly = false;
                    btnSubirFotoAdmin.Enabled = true;
                    break;

                case Estado.Editar:
                    btnNuevoAdmin.Enabled = false;
                    btnGuardarAdmin.Enabled = true;
                    btnCancelarAdmin.Enabled = true;
                    btnBuscarAdmin.Enabled = false;
                    btnEditarAdmin.Enabled = false;
                    btnEliminarAdmin.Enabled = false;
                    gbDatosGeneralesAdmin.Enabled = true;
                    gbDatosAcademicosAdmin.Enabled = true;
                    txtIDAdmin.Enabled = true;
                    txtDNIAdmin.Enabled = true;
                    txtDNIAdmin.ReadOnly = false;
                    txtNombreAdmin.Enabled = true;
                    txtNombreAdmin.ReadOnly = false;
                    txtApellidoPaternoAdmin.Enabled = true;
                    txtApellidoPaternoAdmin.ReadOnly = false;
                    txtApellidoMaternoAdmin.Enabled = true;
                    txtApellidoMaternoAdmin.ReadOnly = false;
                    rbMasculinoAdmin.Enabled = true;
                    rbFemeninoAdmin.Enabled = true;
                    dtpFechaNacimientoAdmin.Enabled = true;
                    txtTelefonoAdmin.Enabled = true;
                    txtTelefonoAdmin.ReadOnly = false;
                    txtDireccionAdmin.Enabled = true;
                    txtDireccionAdmin.ReadOnly = false;
                    txtCorreoAdmin.Enabled = true;
                    txtCorreoAdmin.ReadOnly = false;
                    txtContrasenhaAdmin.Enabled = true;
                    txtContrasenhaAdmin.ReadOnly = false;
                    dtpFechaContratacionAdmin.Enabled = true;
                    txtSalarioAdmin.Enabled = true;
                    txtSalarioAdmin.ReadOnly = false;
                    txtExperienciaAdmin.Enabled = true;
                    txtExperienciaAdmin.ReadOnly = false;
                    btnSubirFotoAdmin.Enabled = true;
                    break;
                case Estado.Buscar:
                    btnNuevoAdmin.Enabled = false;
                    btnGuardarAdmin.Enabled = false;
                    btnCancelarAdmin.Enabled = true;
                    btnBuscarAdmin.Enabled = false;
                    btnEditarAdmin.Enabled = true;
                    btnEliminarAdmin.Enabled = true;
                    gbDatosGeneralesAdmin.Enabled = true;
                    gbDatosAcademicosAdmin.Enabled = true;
                    txtIDAdmin.Enabled = true;
                    txtDNIAdmin.Enabled = true;
                    txtDNIAdmin.ReadOnly = true;
                    txtNombreAdmin.Enabled = true;
                    txtNombreAdmin.ReadOnly = true;
                    txtApellidoPaternoAdmin.Enabled = true;
                    txtApellidoPaternoAdmin.ReadOnly = true;
                    txtApellidoMaternoAdmin.Enabled = true;
                    txtApellidoMaternoAdmin.ReadOnly = true;
                    rbMasculinoAdmin.Enabled = false;
                    rbFemeninoAdmin.Enabled = false;
                    dtpFechaNacimientoAdmin.Enabled = false;
                    txtTelefonoAdmin.Enabled = true;
                    txtTelefonoAdmin.ReadOnly = true;
                    txtDireccionAdmin.Enabled = true;
                    txtDireccionAdmin.ReadOnly = true;
                    txtCorreoAdmin.Enabled = true;
                    txtCorreoAdmin.ReadOnly = true; 
                    txtContrasenhaAdmin.Enabled = true;
                    txtContrasenhaAdmin.ReadOnly = true;
                    dtpFechaContratacionAdmin.Enabled = false;
                    txtSalarioAdmin.Enabled = true;
                    txtSalarioAdmin.ReadOnly = true;
                    txtExperienciaAdmin.Enabled = false;
                    txtExperienciaAdmin.ReadOnly = true;
                    btnSubirFotoAdmin.Enabled = false;
                    break;
            }
        }
        public void limpiarComponentes()
        {
            txtIDAdmin.Text = "";
            txtDNIAdmin.Text = "";
            txtNombreAdmin.Text = "";
            txtApellidoPaternoAdmin.Text = "";
            txtApellidoMaternoAdmin.Text = "";
            rbMasculinoAdmin.Checked = false;
            rbFemeninoAdmin.Checked = false;
            dtpFechaNacimientoAdmin.Value = DateTime.Now;
            txtTelefonoAdmin.Text = "";
            txtDireccionAdmin.Text = "";
            txtCorreoAdmin.Text = "";
            txtContrasenhaAdmin.Text = "";
            dtpFechaContratacionAdmin.Value = DateTime.Now;
            txtSalarioAdmin.Text = "";
            txtExperienciaAdmin.Text = "";
            pbFotoAdmin.Image = null;
        }

        private void btnNuevoAdmin_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            _estado = Estado.Nuevo;
            _administrador = new administradorAcademico(); 
            establecerEstadoComponentes();
        }

        private void btnGuardarAdmin_Click(object sender, EventArgs e)
        {
            _administrador.DNI = txtDNIAdmin.Text;
            _administrador.nombre = txtNombreAdmin.Text;
            _administrador.apellidoPaterno = txtApellidoPaternoAdmin.Text;
            _administrador.apellidoMaterno = txtApellidoMaternoAdmin.Text;
            if (rbMasculinoAdmin.Checked) _administrador.genero = "Masculino";
            else _administrador.genero = "Femenino";
            _administrador.fechaNacimiento = dtpFechaNacimientoAdmin.Value;
            _administrador.fechaNacimientoSpecified = true;
            _administrador.telefono = txtTelefonoAdmin.Text;
            _administrador.direccion = txtDireccionAdmin.Text;
            _administrador.correo = txtCorreoAdmin.Text;
            _administrador.contrasenha = txtContrasenhaAdmin.Text;
            _administrador.fechaContratacion = dtpFechaContratacionAdmin.Value;
            _administrador.fechaContratacionSpecified = true;
            _administrador.salario = Double.Parse(txtSalarioAdmin.Text);
            _administrador.experiencia = txtExperienciaAdmin.Text;

            if (_estado == Estado.Nuevo)
            {
                int resultado = _daoUserWS.insertarAdministrador(_administrador);
                if (resultado != 0)
                {
                    txtIDAdmin.Text = _administrador.idUsuario.ToString();
                    MessageBox.Show("El administrador se ha registrado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    establecerEstadoComponentes();
                }
                else
                    MessageBox.Show("Hubo un error en el registro", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (_estado == Estado.Existe)
            {
                
                int resultado = _daoUserWS.insertarAdministradorUsuarioExiste(_administrador);
                if (resultado != 0)
                {
                    MessageBox.Show("El administrador se ha registrado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    establecerEstadoComponentes();
                }
                else
                    MessageBox.Show("Hubo un error en el registro", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int resultado = _daoUserWS.modificarAdministrador(_administrador);
                if (resultado != 0)
                {
                    MessageBox.Show("El administrador se ha modificado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    establecerEstadoComponentes();
                }
                else
                    MessageBox.Show("Hubo un error en al modificar", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnEditarAdmin_Click(object sender, EventArgs e)
        {
            _estado = Estado.Editar;
            establecerEstadoComponentes();
        }

        private void btnBuscarAdmin_Click(object sender, EventArgs e)
        {
            _estado = Estado.Buscar;
            establecerEstadoComponentes();
            frmBusquedaAdminsAcads formBusqAcad = new frmBusquedaAdminsAcads(panelUsuario);
            formBusqAcad.OnAdministradorSeleccionado += formBusqAcad_OnAdministradorSeleccionado;
            mostrarFormulario(formBusqAcad);
        }


        private void formBusqAcad_OnAdministradorSeleccionado(administradorAcademico administradorElegido)
        {
            _administrador = administradorElegido;

            txtIDAdmin.Text = _administrador.idUsuario.ToString();
            txtDNIAdmin.Text = _administrador.DNI;
            txtNombreAdmin.Text = _administrador.nombre;
            txtApellidoPaternoAdmin.Text = _administrador.apellidoPaterno;
            txtApellidoMaternoAdmin.Text = _administrador.apellidoMaterno;
            if (_administrador.genero == "Masculino") rbMasculinoAdmin.Checked = true;
            else rbFemeninoAdmin.Checked = true;
            dtpFechaNacimientoAdmin.Value = _administrador.fechaNacimiento;
            txtTelefonoAdmin.Text = _administrador.telefono;
            txtDireccionAdmin.Text = _administrador.direccion;
            txtCorreoAdmin.Text = _administrador.correo;
            txtContrasenhaAdmin.Text = _administrador.contrasenha;
            dtpFechaContratacionAdmin.Value = _administrador.fechaContratacion;
            txtSalarioAdmin.Text = _administrador.salario.ToString();
            txtExperienciaAdmin.Text = _administrador.experiencia;
            MemoryStream ms = new MemoryStream(_administrador.foto);
            pbFotoAdmin.Image = new Bitmap(ms);
        }

        private void btnEliminarAdmin_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este administrador?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Se llama al web service para eliminar el evento
                int resultadoEliminacion = _daoUserWS.eliminarAdministrador(_administrador.idUsuario);

                if (resultadoEliminacion > 0)
                {
                    MessageBox.Show("Se ha eliminado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    limpiarComponentes();
                    establecerEstadoComponentes();
                }
                else
                {
                    MessageBox.Show("Hubo un error al eliminar el administrador.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnCancelarAdmin_Click(object sender, EventArgs e)
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

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdFoto.ShowDialog() == DialogResult.OK)
                {
                    _rutaFoto = ofdFoto.FileName;
                    pbFotoAdmin.Image = Image.FromFile(_rutaFoto);

                    FileStream fs = new FileStream(_rutaFoto, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    _administrador.foto = br.ReadBytes((int)fs.Length);
                    fs.Close();

                    MemoryStream ms = new MemoryStream(_administrador.foto);
                    pbFotoAdmin.Image = new Bitmap(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void txtDNIAdmin_Leave(object sender, EventArgs e)
        {
            usuario usuario = new usuario();
            usuario = _daoUserWS.encontrarUsuario(txtDNIAdmin.Text);
            if(usuario.idUsuario!= 0)
            {
                _estado = Estado.Existe;
                establecerEstadoComponentes();
                txtIDAdmin.Text = usuario.idUsuario.ToString();
                txtDNIAdmin.Text = usuario.DNI;
                txtNombreAdmin.Text = usuario.nombre;
                txtApellidoPaternoAdmin.Text = usuario.apellidoPaterno;
                txtApellidoMaternoAdmin.Text = usuario.apellidoMaterno;
                if (usuario.genero == "Masculino") rbMasculinoAdmin.Checked = true;
                else rbFemeninoAdmin.Checked = true;
                dtpFechaNacimientoAdmin.Value = usuario.fechaNacimiento;
                txtTelefonoAdmin.Text = usuario.telefono;
                txtDireccionAdmin.Text = usuario.direccion;
                txtCorreoAdmin.Text = usuario.correo;
                txtContrasenhaAdmin.Text = usuario.contrasenha;
                //Se cargan datos
                _administrador.idUsuario = usuario.idUsuario;  
                _administrador.foto = usuario.foto;
                //Se muestra la foto
                if(usuario.foto != null)
                {
                    MemoryStream ms = new MemoryStream(usuario.foto);
                    pbFotoAdmin.Image = new Bitmap(ms);
                }
                
            }
        }
    }
}
