
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
    public partial class frmGestDocente : Form
    {

        private Estado _estado;
        private string _rutaFoto;
        private Panel panelUsuario;
        private UserWSClient _daoUserWS;
        private docente _docente;

        public frmGestDocente(Panel panelUsuario)
        {
            InitializeComponent();
            this.panelUsuario = panelUsuario;
            _estado = Estado.Inicial;
            _daoUserWS = new UserWSClient();

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
                    gpbDADocente.Enabled = false;
                    gpbDTDocente.Enabled = false;
                    txtIDDocente.Enabled = false;
                    txtDNIDocente.Enabled = false;
                    txtNombreDocente.Enabled = false;
                    txtApellidoPaternoDocente.Enabled = false;
                    txtApellidoMaternoDocente.Enabled = false;
                    rbMasculinoDocente.Enabled = false;
                    rbFemeninoDocente.Enabled = false;
                    dtpFechaNacimientoDocente.Enabled = false;
                    txtTelefonoDocente.Enabled = false;
                    txtDireccionDocente.Enabled = false;
                    txtCorreoDocente.Enabled = false;
                    txtContrasenhaDocente.Enabled = false;
                    dtpFechaContratacionDocente.Enabled = false;
                    txtSalarioDocente.Enabled = false;
                    txtEspecialidad.Enabled = false;
                    break;

                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gpbDADocente.Enabled = true;
                    gpbDTDocente.Enabled = true;

                    txtIDDocente.Enabled = false;
                    txtDNIDocente.Enabled = true;
                    txtDNIDocente.ReadOnly = false;
                    txtNombreDocente.Enabled = true;
                    txtNombreDocente.ReadOnly = false;
                    txtApellidoPaternoDocente.Enabled = true;
                    txtApellidoPaternoDocente.ReadOnly = false;
                    txtApellidoMaternoDocente.Enabled = true;
                    txtApellidoMaternoDocente.ReadOnly = false;
                    rbMasculinoDocente.Enabled = true;
                    rbFemeninoDocente.Enabled = true;
                    dtpFechaNacimientoDocente.Enabled = true;
                    txtTelefonoDocente.Enabled = true;
                    txtTelefonoDocente.ReadOnly = false;
                    txtDireccionDocente.Enabled = true;
                    txtDireccionDocente.ReadOnly = false;
                    txtCorreoDocente.Enabled = true;
                    txtCorreoDocente.ReadOnly = false;
                    txtContrasenhaDocente.Enabled = true;
                    txtContrasenhaDocente.ReadOnly = false;
                    dtpFechaContratacionDocente.Enabled = true;
                    txtEspecialidad.Enabled = true;
                    txtEspecialidad.ReadOnly = false;
                    txtSalarioDocente.Enabled = true;
                    txtSalarioDocente.ReadOnly = false;
                    break;

                case Estado.Existe:
                    gpbDADocente.Enabled = true;
                    gpbDTDocente.Enabled = true;
                    txtIDDocente.Enabled = false;
                    txtDNIDocente.Enabled = false;
                    txtDNIDocente.ReadOnly = true;
                    txtNombreDocente.Enabled = true;
                    txtNombreDocente.ReadOnly = false;
                    txtApellidoPaternoDocente.Enabled = true;
                    txtApellidoPaternoDocente.ReadOnly = false;
                    txtApellidoMaternoDocente.Enabled = true;
                    txtApellidoMaternoDocente.ReadOnly = false;
                    rbMasculinoDocente.Enabled = false;
                    rbFemeninoDocente.Enabled = false;
                    dtpFechaNacimientoDocente.Enabled = false;
                    txtTelefonoDocente.Enabled = true;
                    txtTelefonoDocente.ReadOnly = false;
                    txtDireccionDocente.Enabled = true;
                    txtDireccionDocente.ReadOnly = false;
                    txtCorreoDocente.Enabled = false;
                    txtCorreoDocente.ReadOnly = true;
                    txtContrasenhaDocente.Enabled = false;
                    txtContrasenhaDocente.ReadOnly = true;
                    dtpFechaContratacionDocente.Enabled = true;
                    txtSalarioDocente.Enabled = true;
                    txtSalarioDocente.ReadOnly = false;
                    txtEspecialidad.Enabled = true;
                    txtEspecialidad.ReadOnly = false;
                    btnSubirFotoDocente.Enabled = true;
                    break;

                case Estado.Editar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    gpbDADocente.Enabled = true;
                    gpbDTDocente.Enabled = true;

                    txtIDDocente.Enabled = false;
                    txtDNIDocente.Enabled = true;
                    txtDNIDocente.ReadOnly = false;
                    txtNombreDocente.Enabled = true;
                    txtNombreDocente.ReadOnly = false;
                    txtApellidoPaternoDocente.Enabled = true;
                    txtApellidoPaternoDocente.ReadOnly = false;
                    txtApellidoMaternoDocente.Enabled = true;
                    txtApellidoMaternoDocente.ReadOnly = false;
                    rbMasculinoDocente.Enabled = true;
                    rbFemeninoDocente.Enabled = true;
                    dtpFechaNacimientoDocente.Enabled = true;
                    txtTelefonoDocente.Enabled = true;
                    txtTelefonoDocente.ReadOnly = false;
                    txtDireccionDocente.Enabled = true;
                    txtDireccionDocente.ReadOnly = false;
                    txtCorreoDocente.Enabled = true;
                    txtCorreoDocente.ReadOnly = false;
                    txtContrasenhaDocente.Enabled = true;
                    txtContrasenhaDocente.ReadOnly = false;
                    dtpFechaContratacionDocente.Enabled = true;
                    txtEspecialidad.Enabled = true;
                    txtEspecialidad.ReadOnly = false;
                    txtSalarioDocente.Enabled = true;
                    txtSalarioDocente.ReadOnly = false;
                    break;
                
                case Estado.Buscar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    gpbDTDocente.Enabled = true;
                    gpbDADocente.Enabled = true;

                    txtIDDocente.Enabled = true;
                    txtDNIDocente.Enabled = true;
                    txtDNIDocente.ReadOnly = true;
                    txtNombreDocente.Enabled = true;
                    txtNombreDocente.ReadOnly = true;
                    txtApellidoPaternoDocente.Enabled = true;
                    txtApellidoPaternoDocente.ReadOnly = true;
                    txtApellidoMaternoDocente.Enabled = true;
                    txtApellidoMaternoDocente.ReadOnly = true;
                    rbMasculinoDocente.Enabled = false;
                    rbFemeninoDocente.Enabled = false;
                    dtpFechaNacimientoDocente.Enabled = false;
                    txtTelefonoDocente.Enabled = true;
                    txtTelefonoDocente.ReadOnly = true;
                    txtDireccionDocente.Enabled = true;
                    txtDireccionDocente.ReadOnly = true;
                    txtCorreoDocente.Enabled = true;
                    txtCorreoDocente.ReadOnly = true;
                    txtContrasenhaDocente.Enabled = true;
                    txtContrasenhaDocente.ReadOnly = true;
                    dtpFechaContratacionDocente.Enabled = false;
                    txtEspecialidad.Enabled = true;
                    txtEspecialidad.ReadOnly = true;
                    txtSalarioDocente.Enabled = true;
                    txtSalarioDocente.ReadOnly = true;
                    btnSubirFotoDocente.Enabled = false;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtIDDocente.Text = "";
            txtDNIDocente.Text = "";
            txtNombreDocente.Text = "";
            txtApellidoPaternoDocente.Text = "";
            txtApellidoMaternoDocente.Text = "";
            rbMasculinoDocente.Checked = false;
            rbFemeninoDocente.Checked = false;
            dtpFechaNacimientoDocente.Value = DateTime.Now;
            txtTelefonoDocente.Text = "";
            txtDireccionDocente.Text = "";
            txtCorreoDocente.Text = "";
            txtContrasenhaDocente.Text = "";
            dtpFechaContratacionDocente.Value = DateTime.Now;
            txtEspecialidad.Text = "";
            txtSalarioDocente.Text = "";
            pbFotoDocente.Image = null;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            _estado = Estado.Nuevo;
            _docente = new docente();
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
            /*
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea cancelar el registro de Docente?",
                "Confirmar eliminación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                //limpiar componentes
                MessageBox.Show("Se ha cancelado el registro del Docente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //deberia regresar a el punto inicial donde estaba
            }*/
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Buscar;
            establecerEstadoComponentes();
            frmBusquedaDocentes formBusqDoc = new frmBusquedaDocentes(panelUsuario);
            formBusqDoc.OnDocenteSeleccionado += formBusqDoc_OnDocenteSeleccionado;
            mostrarFormulario(formBusqDoc);
        }
        private void formBusqDoc_OnDocenteSeleccionado(docente docenteElegido)
        {
            _docente = docenteElegido;

            txtIDDocente.Text = _docente.idUsuario.ToString();
            txtDNIDocente.Text = _docente.DNI;
            txtNombreDocente.Text = _docente.nombre;
            txtApellidoPaternoDocente.Text = _docente.apellidoPaterno;
            txtApellidoMaternoDocente.Text = _docente.apellidoMaterno;
            if (_docente.genero == "Masculino") rbMasculinoDocente.Checked = true;
            else rbFemeninoDocente.Checked = true;
            dtpFechaNacimientoDocente.Value = _docente.fechaNacimiento;
            txtTelefonoDocente.Text = _docente.telefono;
            txtDireccionDocente.Text = _docente.direccion;
            txtCorreoDocente.Text = _docente.correo;
            txtContrasenhaDocente.Text = _docente.contrasenha;
            dtpFechaContratacionDocente.Value = _docente.fechaContratacion;
            txtEspecialidad.Text = _docente.especialidad;
            txtSalarioDocente.Text = _docente.salario.ToString();
            MemoryStream ms = new MemoryStream(_docente.foto);
            pbFotoDocente.Image = new Bitmap(ms);
        }

        public void mostrarFormulario(Form form)
        {
            panelUsuario.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            panelUsuario.Controls.Add(form);
            form.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _docente.DNI = txtDNIDocente.Text;
            _docente.nombre = txtNombreDocente.Text;
            _docente.apellidoPaterno = txtApellidoPaternoDocente.Text;
            _docente.apellidoMaterno = txtApellidoMaternoDocente.Text;
            if (rbMasculinoDocente.Checked) _docente.genero = "Masculino";
            else _docente.genero = "Femenino";
            _docente.fechaNacimiento = dtpFechaNacimientoDocente.Value;
            _docente.fechaNacimientoSpecified = true;
            _docente.telefono = txtTelefonoDocente.Text;
            _docente.direccion = txtDireccionDocente.Text;
            _docente.correo = txtCorreoDocente.Text;
            _docente.contrasenha = txtContrasenhaDocente.Text;
            _docente.fechaContratacion = dtpFechaContratacionDocente.Value;
            _docente.fechaContratacionSpecified = true;
            _docente.salario = Double.Parse(txtSalarioDocente.Text);
            _docente.especialidad = txtEspecialidad.Text;

            if (_estado == Estado.Nuevo)
            {
                int resultado = _daoUserWS.insertarDocente(_docente);
                if (resultado != 0)
                {
                    txtIDDocente.Text = _docente.idUsuario.ToString();
                    MessageBox.Show("El docente se ha registrado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    establecerEstadoComponentes();
                }
                else
                    MessageBox.Show("Hubo un error en el registro", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (_estado == Estado.Existe) 
            {
                int resultado = _daoUserWS.insertarDocenteUsuarioExiste(_docente);
                if (resultado != 0)
                {
                    MessageBox.Show("El docente se ha registrado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    establecerEstadoComponentes();
                }
                else
                    MessageBox.Show("Hubo un error en el registro", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                int resultado = _daoUserWS.modificarDocente(_docente);
                if (resultado != 0)
                {
                    MessageBox.Show("El docente se ha modificado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    establecerEstadoComponentes();
                }
                else
                    MessageBox.Show("Hubo un error en al modificar", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este docente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Se llama al web service para eliminar el evento
                int resultadoEliminacion = _daoUserWS.eliminarDocente(_docente.idUsuario);

                if (resultadoEliminacion > 0)
                {
                    MessageBox.Show("Se ha eliminado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    limpiarComponentes();
                    establecerEstadoComponentes();
                }
                else
                {
                    MessageBox.Show("Hubo un error al eliminar el docente.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSubirFotoDocente_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdFoto.ShowDialog() == DialogResult.OK)
                {
                    _rutaFoto = ofdFoto.FileName;
                    pbFotoDocente.Image = Image.FromFile(_rutaFoto);

                    FileStream fs = new FileStream(_rutaFoto, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    _docente.foto = br.ReadBytes((int)fs.Length);
                    fs.Close();

                    MemoryStream ms = new MemoryStream(_docente.foto);
                    pbFotoDocente.Image = new Bitmap(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void txtDNIDocente_Leave(object sender, EventArgs e)
        {
            usuario usuario = new usuario();
            usuario = _daoUserWS.encontrarUsuario(txtDNIDocente.Text);
            if (usuario.idUsuario != 0)
            {
                _estado = Estado.Existe;
                establecerEstadoComponentes();
                txtIDDocente.Text = usuario.idUsuario.ToString();
                txtDNIDocente.Text = usuario.DNI;
                txtNombreDocente.Text = usuario.nombre;
                txtApellidoPaternoDocente.Text = usuario.apellidoPaterno;
                txtApellidoMaternoDocente.Text = usuario.apellidoMaterno;
                if (usuario.genero == "Masculino") rbMasculinoDocente.Checked = true;
                else rbFemeninoDocente.Checked = true;
                dtpFechaNacimientoDocente.Value = usuario.fechaNacimiento;
                txtTelefonoDocente.Text = usuario.telefono;
                txtDireccionDocente.Text = usuario.direccion;
                txtCorreoDocente.Text = usuario.correo;
                txtContrasenhaDocente.Text = usuario.contrasenha;
                //Se cargan datos
                _docente.idUsuario = usuario.idUsuario;
                _docente.foto = usuario.foto;
                //Se muestra la foto
                if(usuario.foto != null)
                {
                    MemoryStream ms = new MemoryStream(usuario.foto);
                    pbFotoDocente.Image = new Bitmap(ms);
                }
                
            }
        }
    }
}
