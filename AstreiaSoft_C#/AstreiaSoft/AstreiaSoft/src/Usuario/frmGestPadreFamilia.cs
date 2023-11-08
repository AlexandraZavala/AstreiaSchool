
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
    public partial class frmGestPadreFamilia : Form
    {

        private Estado _estado;
        private string _rutaFoto;
        private Panel panelUsuario;
        private UserWSClient _daoUserWS;
        private padreFamilia _padreFamilia;

        public frmGestPadreFamilia(Panel panelUsuario)
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
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gpbDAPadFam.Enabled = false;
                    gpbDTPadFam.Enabled = false;  
                    gpHijos.Enabled = false;

                    txtIDPadFam.Enabled = false;
                    txtDNIPadFam.Enabled = false;
                    txtNombrePadFam.Enabled = false;
                    txtApellidoPaternoPadFam.Enabled = false;
                    txtApellidoMaternoPadFam.Enabled = false;
                    rbMasculinoPadFam.Enabled = false;
                    rbFemeninoPadFam.Enabled = false;
                    dtpFechaNacimientoPadFam.Enabled = false;
                    txtTelefonoPadFam.Enabled = false;
                    txtDireccionPadFam.Enabled = false;
                    txtCorreoPadFam.Enabled = false;
                    txtContrasenhaPadFam.Enabled = false;
                    nudCantidadHijos.Enabled = false;
                    btnAgregarHijos.Enabled = false;
                    btnSubirFotoPadreFamilia.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gpbDAPadFam.Enabled = true;
                    gpbDTPadFam.Enabled = true;
                    gpHijos.Enabled = true;

                    txtIDPadFam.Enabled = false;
                    txtDNIPadFam.Enabled = true;
                    txtDNIPadFam.ReadOnly = false;
                    txtNombrePadFam.Enabled = true;
                    txtNombrePadFam.ReadOnly = false;
                    txtApellidoPaternoPadFam.Enabled = true;
                    txtApellidoPaternoPadFam.ReadOnly = false;
                    txtApellidoMaternoPadFam.Enabled = true;
                    txtApellidoMaternoPadFam.ReadOnly = false;
                    rbMasculinoPadFam.Enabled = true;
                    rbFemeninoPadFam.Enabled = true;
                    dtpFechaNacimientoPadFam.Enabled = true;
                    txtTelefonoPadFam.Enabled = true;
                    txtTelefonoPadFam.ReadOnly = false;
                    txtDireccionPadFam.Enabled = true;
                    txtDireccionPadFam.ReadOnly = false;
                    txtCorreoPadFam.Enabled = true;
                    txtCorreoPadFam.ReadOnly = false;
                    txtContrasenhaPadFam.Enabled = true;
                    txtContrasenhaPadFam.ReadOnly = false;
                    nudCantidadHijos.Enabled = true;
                    btnAgregarHijos.Enabled = true;
                    break;

                case Estado.Existe:
                    gpbDAPadFam.Enabled = true;
                    gpbDTPadFam.Enabled = true;
                    gpHijos.Enabled = true;
                    txtIDPadFam.Enabled = false;
                    txtDNIPadFam.Enabled = false;
                    txtDNIPadFam.ReadOnly = true;
                    txtNombrePadFam.Enabled = true;
                    txtNombrePadFam.ReadOnly = false;
                    txtApellidoPaternoPadFam.Enabled = true;
                    txtApellidoPaternoPadFam.ReadOnly = false;
                    txtApellidoMaternoPadFam.Enabled = true;
                    txtApellidoMaternoPadFam.ReadOnly = false;
                    rbMasculinoPadFam.Enabled = false;
                    rbFemeninoPadFam.Enabled = false;
                    dtpFechaNacimientoPadFam.Enabled = false;
                    txtTelefonoPadFam.Enabled = true;
                    txtTelefonoPadFam.ReadOnly = false;
                    txtDireccionPadFam.Enabled = true;
                    txtDireccionPadFam.ReadOnly = false;
                    txtCorreoPadFam.Enabled = false;
                    txtCorreoPadFam.ReadOnly = true;
                    txtContrasenhaPadFam.Enabled = false;
                    txtContrasenhaPadFam.ReadOnly = true;
                    btnSubirFotoPadreFamilia.Enabled = true;
                    nudCantidadHijos.Enabled = true;
                    btnAgregarHijos.Enabled = true;
                    break;


                case Estado.Editar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;

                    gpHijos.Enabled = true;
                    gpbDAPadFam.Enabled = true;
                    gpbDTPadFam.Enabled = true;
                    txtIDPadFam.Enabled = false;
                    txtDNIPadFam.Enabled = true;
                    txtDNIPadFam.ReadOnly = false;
                    txtNombrePadFam.Enabled = true;
                    txtNombrePadFam.ReadOnly = false;
                    txtApellidoPaternoPadFam.Enabled = true;
                    txtApellidoPaternoPadFam.ReadOnly = false;
                    txtApellidoMaternoPadFam.Enabled = true;
                    txtApellidoMaternoPadFam.ReadOnly = false;
                    rbMasculinoPadFam.Enabled = true;
                    rbFemeninoPadFam.Enabled = true;
                    dtpFechaNacimientoPadFam.Enabled = true;
                    txtTelefonoPadFam.Enabled = true;
                    txtTelefonoPadFam.ReadOnly = false;
                    txtDireccionPadFam.Enabled = true;
                    txtDireccionPadFam.ReadOnly = false;
                    txtCorreoPadFam.Enabled = true;
                    txtCorreoPadFam.ReadOnly = false;
                    txtContrasenhaPadFam.Enabled = true;
                    txtContrasenhaPadFam.ReadOnly = false;
                    
                    nudCantidadHijos.Enabled = true;
                    btnAgregarHijos.Enabled = true;
                    break;
                case Estado.Buscar:

                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    gpbDAPadFam.Enabled = true;
                    gpbDTPadFam.Enabled = true;
                    gpHijos.Enabled = true;

                    txtIDPadFam.Enabled = true;
                    txtDNIPadFam.Enabled = true;
                    txtDNIPadFam.ReadOnly = true;
                    txtNombrePadFam.Enabled = true;
                    txtNombrePadFam.ReadOnly = true;
                    txtApellidoPaternoPadFam.Enabled = true;
                    txtApellidoPaternoPadFam.ReadOnly = true;
                    txtApellidoMaternoPadFam.Enabled = true;
                    txtApellidoMaternoPadFam.ReadOnly = true;
                    rbMasculinoPadFam.Enabled = false;
                    rbFemeninoPadFam.Enabled = false;
                    dtpFechaNacimientoPadFam.Enabled = false;
                    txtTelefonoPadFam.Enabled = true;
                    txtTelefonoPadFam.ReadOnly = true;
                    txtDireccionPadFam.Enabled = true;
                    txtDireccionPadFam.ReadOnly = true;
                    txtCorreoPadFam.Enabled = true;
                    txtCorreoPadFam.ReadOnly = true;
                    txtContrasenhaPadFam.Enabled = true;
                    txtContrasenhaPadFam.ReadOnly = true;
                    btnSubirFotoPadreFamilia.Enabled = false;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtIDPadFam.Text = "";
            txtDNIPadFam.Text = "";
            txtNombrePadFam.Text = "";
            txtApellidoPaternoPadFam.Text = "";
            txtApellidoMaternoPadFam.Text = "";
            rbMasculinoPadFam.Checked = false;
            rbFemeninoPadFam.Checked = false;
            dtpFechaNacimientoPadFam.Value = DateTime.Now;
            txtTelefonoPadFam.Text = "";
            txtDireccionPadFam.Text = "";
            txtCorreoPadFam.Text = "";
            txtContrasenhaPadFam.Text = "";
            nudCantidadHijos.Enabled = false;
            btnAgregarHijos.Enabled = false;
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            _estado = Estado.Nuevo;
            _padreFamilia = new padreFamilia();
            establecerEstadoComponentes();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Editar;
            establecerEstadoComponentes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Buscar;
            establecerEstadoComponentes();
            frmBusquedaPadreFamilias formBusqPadre = new frmBusquedaPadreFamilias(panelUsuario);
            formBusqPadre.OnPadreFamiliaSeleccionado += formBusqPadre_OnPadreFamiliaSeleccionado;
            mostrarFormulario(formBusqPadre);
        }
        private void formBusqPadre_OnPadreFamiliaSeleccionado(padreFamilia padreFamiliaElegido)
        {
            _padreFamilia = padreFamiliaElegido;

            txtIDPadFam.Text = _padreFamilia.idUsuario.ToString();
            txtDNIPadFam.Text = _padreFamilia.DNI;
            txtNombrePadFam.Text = _padreFamilia.nombre;
            txtApellidoPaternoPadFam.Text = _padreFamilia.apellidoPaterno;
            txtApellidoMaternoPadFam.Text = _padreFamilia.apellidoMaterno;
            if (_padreFamilia.genero == "Masculino") rbMasculinoPadFam.Checked = true;
            else rbFemeninoPadFam.Checked = true;
            dtpFechaNacimientoPadFam.Value = _padreFamilia.fechaNacimiento;
            txtTelefonoPadFam.Text = _padreFamilia.telefono;
            txtDireccionPadFam.Text = _padreFamilia.direccion;
            txtCorreoPadFam.Text = _padreFamilia.correo;
            txtContrasenhaPadFam.Text = _padreFamilia.contrasenha;
            MemoryStream ms = new MemoryStream(_padreFamilia.foto);
            pbFotoPadreFamilia.Image = new Bitmap(ms);
        }

        public void mostrarFormulario(Form form)
        {
            panelUsuario.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            panelUsuario.Controls.Add(form);
            form.Visible = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este padre de familia?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Se llama al web service para eliminar el evento
                int resultadoEliminacion = _daoUserWS.eliminarPadreFamilia(_padreFamilia.idUsuario);

                if (resultadoEliminacion > 0)
                {
                    MessageBox.Show("Se ha eliminado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    limpiarComponentes();
                    establecerEstadoComponentes();
                }
                else
                {
                    MessageBox.Show("Hubo un error al eliminar el padre de familia.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _padreFamilia.DNI = txtDNIPadFam.Text;
            _padreFamilia.nombre = txtNombrePadFam.Text;
            _padreFamilia.apellidoPaterno = txtApellidoPaternoPadFam.Text;
            _padreFamilia.apellidoMaterno = txtApellidoMaternoPadFam.Text;
            if (rbMasculinoPadFam.Checked) _padreFamilia.genero = "Masculino";
            else _padreFamilia.genero = "Femenino";
            _padreFamilia.fechaNacimiento = dtpFechaNacimientoPadFam.Value;
            _padreFamilia.fechaNacimientoSpecified = true;
            _padreFamilia.telefono = txtTelefonoPadFam.Text;
            _padreFamilia.direccion = txtDireccionPadFam.Text;
            _padreFamilia.correo = txtCorreoPadFam.Text;
            _padreFamilia.contrasenha = txtContrasenhaPadFam.Text;
            //prueba
            _padreFamilia.numeroHijos = 0;

            if (_estado == Estado.Nuevo)
            {
                int resultado = _daoUserWS.insertarPadreFamilia(_padreFamilia);
                if (resultado != 0)
                {
                    txtIDPadFam.Text = _padreFamilia.idUsuario.ToString();
                    MessageBox.Show("El padre de familia se ha registrado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    establecerEstadoComponentes();
                }
                else
                    MessageBox.Show("Hubo un error en el registro", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else if (_estado == Estado.Existe) 
            {
                int resultado = _daoUserWS.insertarPadreFamiliaUsuarioExiste(_padreFamilia);
                if (resultado != 0)
                {
                    MessageBox.Show("El padre de familia se ha registrado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    establecerEstadoComponentes();
                }
                else
                    MessageBox.Show("Hubo un error en el registro", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int resultado = _daoUserWS.modificarPadreFamilia(_padreFamilia);
                if (resultado != 0)
                {
                    MessageBox.Show("El padre de familia se ha modificado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    establecerEstadoComponentes();
                }
                else
                    MessageBox.Show("Hubo un error en al modificar", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnAgregarHijos_Click(object sender, EventArgs e)
        {
            frmAgregarHijo formAgHijo = new frmAgregarHijo(panelUsuario);
            mostrarFormulario(formAgHijo);
        }

        private void btnSubirFotoPadreFamilia_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdFoto.ShowDialog() == DialogResult.OK)
                {
                    _rutaFoto = ofdFoto.FileName;
                    pbFotoPadreFamilia.Image = Image.FromFile(_rutaFoto);

                    FileStream fs = new FileStream(_rutaFoto, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    _padreFamilia.foto = br.ReadBytes((int)fs.Length);
                    fs.Close();

                    MemoryStream ms = new MemoryStream(_padreFamilia.foto);
                    pbFotoPadreFamilia.Image = new Bitmap(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }


        private void txtDNIPadFam_Leave(object sender, EventArgs e)
        {
            usuario usuario = new usuario();
            usuario = _daoUserWS.encontrarUsuario(txtDNIPadFam.Text);
            if (usuario.idUsuario != 0)
            {
                _estado = Estado.Existe;
                establecerEstadoComponentes();
                txtIDPadFam.Text = usuario.idUsuario.ToString();
                txtDNIPadFam.Text = usuario.DNI;
                txtNombrePadFam.Text = usuario.nombre;
                txtApellidoPaternoPadFam.Text = usuario.apellidoPaterno;
                txtApellidoMaternoPadFam.Text = usuario.apellidoMaterno;
                if (usuario.genero == "Masculino") rbMasculinoPadFam.Checked = true;
                else rbFemeninoPadFam.Checked = true;
                dtpFechaNacimientoPadFam.Value = usuario.fechaNacimiento;
                txtTelefonoPadFam.Text = usuario.telefono;
                txtDireccionPadFam.Text = usuario.direccion;
                txtCorreoPadFam.Text = usuario.correo;
                txtContrasenhaPadFam.Text = usuario.contrasenha;
                //Se cargan datos
                _padreFamilia.idUsuario = usuario.idUsuario;
                _padreFamilia.foto = usuario.foto;
                //Se muestra la foto
                if(usuario.foto != null)
                {
                    MemoryStream ms = new MemoryStream(usuario.foto);
                    pbFotoPadreFamilia.Image = new Bitmap(ms);
                }
                
            }
        }
    }
}
