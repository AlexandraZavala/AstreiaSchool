
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
    public partial class frmGestPadreFamilia : Form
    {

        private Estado _estado;
        private string _rutaFoto;
        private Panel panelUsuario;
        private UserWSClient _daoUserWS;
        private padreFamilia _padreFamilia;
        private estudiante _hijoPadre;
        private BindingList<estudiante> hijosPadre = new BindingList<estudiante>();

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
                    //nudCantidadHijos.Enabled = false;
                    btnBuscarHijo.Enabled = false;
                    btnSubirFotoPadreFamilia.Enabled = false;
                    btnAgregarH.Enabled = false;
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
                    //nudCantidadHijos.Enabled = true;
                    btnBuscarHijo.Enabled = true;
                    btnAgregarH.Enabled = true;
                    btnSubirFotoPadreFamilia.Enabled = true;
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
                    btnSubirFotoPadreFamilia.Enabled = true;
                    //nudCantidadHijos.Enabled = true;
                    btnBuscarHijo.Enabled = true;
                    btnAgregarH.Enabled = true;
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
                    
                    //nudCantidadHijos.Enabled = true;
                    btnBuscarHijo.Enabled = true;
                    btnAgregarH.Enabled = true;
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
            //nudCantidadHijos.Enabled = false;
            btnBuscarHijo.Enabled = false;
            btnAgregarH.Enabled = false;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            _estado = Estado.Nuevo;
            _padreFamilia = new padreFamilia();
            _hijoPadre = new estudiante();
            _padreFamilia.numeroHijos = 0;
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
            if (_padreFamilia.foto != null) {
                MemoryStream ms = new MemoryStream(_padreFamilia.foto);
                pbFotoPadreFamilia.Image = new Bitmap(ms);
            }
            
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
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Para validar cualquier incongruencia
            if (!validarCamposVacios())
            {
                return;
            }
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
            _padreFamilia.hijos = hijosPadre.ToArray();
            //_padreFamilia.hijos.Append(_hijoPadre);
            //prueba
            //_padreFamilia.numeroHijos = 0;

            if (_estado == Estado.Nuevo)
            {
                _padreFamilia.contrasenha = GenerateRandomPassword(8);
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
            frmAgregarHijo formAgHijo = new frmAgregarHijo();
            if (formAgHijo.ShowDialog() == DialogResult.OK)
            {
                _hijoPadre = formAgHijo.EstudianteSeleccionado;
                txtHijo.Text = _hijoPadre.nombre + " " + _hijoPadre.apellidoPaterno + " " + _hijoPadre.apellidoMaterno;
            }
            ;
        }

        private void btnAgregarH_Click(object sender, EventArgs e)
        {
            if (txtHijo.Text == "")
            {
                MessageBox.Show("Debe seleccionar un estudiante", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                //Se agrega el estudiante al arreglo de hijos del padre
                hijosPadre.Add(_hijoPadre);
                //Agregar al padre de familia su hijo
                //_padreFamilia.hijos.Append(_hijoPadre);
                //Aumentar contador de hijos
                _padreFamilia.numeroHijos++;

                //foreach (estudiante est in this._padreFamilia.hijos)
                //{
                //    est.nombre = linea.Cantidad + Int32.Parse(txtCantidad.Text);
                //    linea.Subtotal = linea.Cantidad * linea.Producto.Precio;
                //    dtaHijos.Refresh();

                //    //_padreFamilia = null;
                //    txtHijo.Text = "";
                //    return;
                //}

                dtaHijos.DataSource = hijosPadre.ToList();
                txtHijo.Text = "";
            }

        }

        private void dtaHijos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            estudiante est = (estudiante)dtaHijos.Rows[e.RowIndex].DataBoundItem;

            dtaHijos.Rows[e.RowIndex].Cells[0].Value = est.nombre;
            dtaHijos.Rows[e.RowIndex].Cells[1].Value = est.apellidoPaterno;
            dtaHijos.Rows[e.RowIndex].Cells[2].Value = est.apellidoMaterno;
        }

        private bool validarCamposVacios()
        {
            if (txtDNIPadFam.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el DNI del docente", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            try
            {
                Int32.Parse(txtDNIPadFam.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar un número como DNI", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            //DNI solo puede ser de 8 digitos
            if (txtDNIPadFam.Text.Trim().Length != 8)
            {
                MessageBox.Show("Debe ingresar un DNI que tenga 8 dígitos", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtNombrePadFam.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el nombre del docente", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtApellidoPaternoPadFam.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el apellido paterno del docente", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtApellidoMaternoPadFam.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el apellido materno del docente", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (rbMasculinoPadFam.Checked == false && rbFemeninoPadFam.Checked == false)
            {
                MessageBox.Show("Debe indicar el género del docente", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtTelefonoPadFam.Text.Trim().Length == 0)
            {

                MessageBox.Show("Debe ingresar el telefono del docente", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            try
            {
                Int32.Parse(txtTelefonoPadFam.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar un número como telefono", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            //Telefono contenga 7 digitos
            if (txtTelefonoPadFam.Text.Trim().Length != 7)
            {
                MessageBox.Show("Debe ingresar 7 digitos para el telefono", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            //Telefono solo se ingresen numeros --> en otra funcion de keypress
            if (txtDireccionPadFam.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar la dirección del docente", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            //Para validar que se cargo una imagen de perfil.
            if (pbFotoPadreFamilia == null)
            {
                MessageBox.Show("Debe cargar una foto de perfil", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if(hijosPadre.ToArray().Length == 0)
            {
                MessageBox.Show("Debe cargar por lo menos un estudiante como hijo", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
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

                    string fileExtension = Path.GetExtension(ofdFoto.FileName).ToLower();

                    if (fileExtension == ".jpg" || fileExtension == ".jpeg")
                    {
                        // El archivo seleccionado es una imagen JPG y puedes cargarlo.
                        Image imagen = Image.FromFile(ofdFoto.FileName);
                        // Aquí puedes trabajar con la imagen, por ejemplo, mostrarla en un control PictureBox.
                        MemoryStream ms = new MemoryStream(_padreFamilia.foto);
                        pbFotoPadreFamilia.Image = new Bitmap(ms);
                    }
                    else
                    {
                        // El archivo no es una imagen JPG. Muestra un mensaje de error.
                        MessageBox.Show("Por favor, selecciona un archivo JPG válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

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
                //Se cargan datos
                _padreFamilia.idUsuario = usuario.idUsuario;
                _padreFamilia.foto = usuario.foto;
                //Se muestra la foto
                if (usuario.foto != null) {
                    MemoryStream ms = new MemoryStream(usuario.foto);
                    pbFotoPadreFamilia.Image = new Bitmap(ms);
                }
                
            }
        }

        private void txtDNIPadFam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefonoPadFam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
