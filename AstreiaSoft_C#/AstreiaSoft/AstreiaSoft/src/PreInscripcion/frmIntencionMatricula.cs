using AstreiaSoft.AdminWS;
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
    public partial class frmIntencionMatricula : Form
    {
        private Estado _estado;
        private Panel panelContenido;
        private inscripcion inscripcionSeleccionada;
        AdminWSClient client;

        public frmIntencionMatricula(Panel panelContenido)
        {
            InitializeComponent();
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
            this.panelContenido = panelContenido;
            client = new AdminWSClient();
        }

        private void limpiarComponentes()
        {
            pbImagen.Image = null;
            rbSi.Checked = true;
            ucEstudianteRegistrado1.LimpiarComponentes(); // Limpia el UserControl de Estudiante Registrado
            ucNuevoEstudiante1.LimpiarComponentes();     // Limpia el UserControl de Nuevo Estudiante
            btnGuardar.Text = "Guardar";
        }

        private void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = false;
                    ucEstudianteRegistrado1.Enabled = false;
                    ucNuevoEstudiante1.Enabled = false;
                    pbImagen.Enabled = false;
                    btnCargar.Enabled = false;
                    rbSi.Enabled = false;
                    rbNo.Enabled = false;
                    break;

                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    rbSi.Enabled = true;
                    rbNo.Enabled = true;
                    ucEstudianteRegistrado1.Enabled = true;
                    ucNuevoEstudiante1.Enabled = true;
                    pbImagen.Enabled = true;
                    btnCargar.Enabled = true;
                    break;

                case Estado.Buscar:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnCancelar.Enabled = true;
                    rbSi.Enabled = false;
                    rbNo.Enabled = false;
                    ucEstudianteRegistrado1.Enabled = false;
                    ucNuevoEstudiante1.Enabled = false;
                    pbImagen.Enabled = false;
                    break;

                case Estado.Editar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    rbSi.Enabled = true;
                    rbNo.Enabled = true;
                    ucEstudianteRegistrado1.Enabled = true;
                    ucNuevoEstudiante1.Enabled = true;
                    pbImagen.Enabled = true;
                    btnCargar.Enabled = true;
                    break;
            }
        }

        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSi.Checked) // Si el estudiante ya está registrado.
            {
                ucEstudianteRegistrado1.Visible = true;
                ucNuevoEstudiante1.Visible = false;
            }
            else if (rbNo.Checked) // Si el estudiante NO está registrado.
            {
                ucEstudianteRegistrado1.Visible = false;
                ucNuevoEstudiante1.Visible = true;
            }
        }

        private void frmIntencionMatricula_Load(object sender, EventArgs e)
        {

        }

        private void ucEstudianteRegistrado1_Load(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            // Crear un OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Definir filtros para el tipo de archivos que deseas permitir
            openFileDialog.Filter = "Imágenes (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|Todos los archivos (*.*)|*.*";
            openFileDialog.FilterIndex = 1;

            // Mostrar el OpenFileDialog y verificar si el usuario seleccionó un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Establecer la imagen seleccionada en el PictureBox
                pbImagen.ImageLocation = openFileDialog.FileName;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha enviado su solicitud con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea cancelar esta pre-inscripción?", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Se ha cancelado la pre-inscripción.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _estado = Estado.Inicial;
                limpiarComponentes();
                establecerEstadoComponentes();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        public byte[] ConvertImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void ObtenerPreInscripcion()
        {
            if (rbNo.Checked)
            {
                inscripcionSeleccionada.estudiante.nombre = ucNuevoEstudiante1.Nombre;
                inscripcionSeleccionada.estudiante.DNI = ucNuevoEstudiante1.DNI;
                inscripcionSeleccionada.estudiante.apellidoPaterno = ucNuevoEstudiante1.ApellidoPaterno;
                inscripcionSeleccionada.estudiante.apellidoMaterno = ucNuevoEstudiante1.ApellidoMaterno;
                inscripcionSeleccionada.estudiante.genero = ucNuevoEstudiante1.GeneroMasculino ? "Masculino" : "Femenino";
                inscripcionSeleccionada.estudiante.fechaNacimiento = ucNuevoEstudiante1.FechaNacimiento;
                inscripcionSeleccionada.estudiante.telefono = ucNuevoEstudiante1.Telefono;
                inscripcionSeleccionada.estudiante.direccion = ucNuevoEstudiante1.Direccion;
            } else
            {
                //inscripcionSeleccionada.estudiante = (AdminService.estudiante)ucEstudianteRegistrado1.EstudianteSeleccionado;
            }
        }

        private inscripcion CrearInscripcionDesdeFormulario()
        {
            inscripcion nuevaInscripcion = new inscripcion();

            if (rbNo.Checked)
            {
                nuevaInscripcion.estudiante = ucNuevoEstudiante1.RegistrarNuevoEstudiante();
                if (nuevaInscripcion.estudiante == null) return null;
                nuevaInscripcion.esNuevo = true;
            }
            else
            {
                int? selectedId = ucEstudianteRegistrado1.EstudianteSeleccionado;
                if (selectedId.HasValue && ucEstudianteRegistrado1.ListaEstudiantes != null)
                {
                    AdminWS.usuario selectedUsuario = ucEstudianteRegistrado1.ListaEstudiantes.FirstOrDefault(u => u.idUsuario == selectedId.Value);
                    if (selectedUsuario != null)
                    {
                        nuevaInscripcion.estudiante = (AdminWS.estudiante)selectedUsuario;
                        nuevaInscripcion.esNuevo = false;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el estudiante seleccionado.");
                        return null;
                    }
                }
                else
                {
                    MessageBox.Show("No se seleccionó un estudiante o la lista de estudiantes no está disponible.");
                    return null;
                }
            }

            if (pbImagen.Image != null)
            {
                nuevaInscripcion.imagen = ConvertImageToByteArray(pbImagen.Image);
            }

            nuevaInscripcion.padre = new AdminWS.padreFamilia();
            nuevaInscripcion.padre.idUsuario = GlobalVariables.IdUsuario; 

            return nuevaInscripcion;
        }

        private bool ValidarInscripcion(inscripcion inscripcionAValidar)
        {
            if (inscripcionAValidar == null) return false;

            if (inscripcionAValidar.estudiante == null)
            {
                MessageBox.Show("Debe seleccionar o registrar un estudiante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (inscripcionAValidar.imagen == null)
            {
                MessageBox.Show("Debe cargar la imagen del comprobante de pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar el tamaño de la imagen
            if (inscripcionAValidar.imagen.Length > 65535)
            {
                MessageBox.Show("El tamaño de la imagen excede el máximo permitido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Aquí puedes agregar más validaciones si lo necesitas.

            return true;
        }

        private void ModificarInscripcion(inscripcion inscripcionAModificar)
        {
            AdminWSClient serviceClient = new AdminWSClient();
            int resultadoModificacion = serviceClient.modificarInscripcion(inscripcionAModificar);

            if (resultadoModificacion > 0)
            {
                MessageBox.Show("Inscripción modificada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _estado = Estado.Inicial;
                limpiarComponentes();
                establecerEstadoComponentes();
            }
            else
            {
                MessageBox.Show("Hubo un error al modificar la inscripción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarNuevaInscripcion(inscripcion nuevaInscripcion)
        {
            AdminWSClient serviceClient = new AdminWSClient();
            int resultado = serviceClient.insertarInscripcion(nuevaInscripcion);

            if (resultado > 0)
            {
                MessageBox.Show("Inscripción registrada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _estado = Estado.Inicial;
                limpiarComponentes();
                establecerEstadoComponentes();
            }
            else
            {
                MessageBox.Show("Hubo un error al registrar la inscripción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                inscripcion nuevaInscripcion = CrearInscripcionDesdeFormulario();

                if (!ValidarInscripcion(nuevaInscripcion))
                    return;

                if (_estado == Estado.Editar)
                {
                    // Asumiendo que inscripcionSeleccionada es una variable global que guarda la inscripción seleccionada.
                    nuevaInscripcion.idInscripcion = inscripcionSeleccionada.idInscripcion;
                    nuevaInscripcion.estudiante.idUsuario = inscripcionSeleccionada.estudiante.idUsuario;
                    nuevaInscripcion.estado = "Pre-Inscrito";
                    ModificarInscripcion(nuevaInscripcion);
                }
                else
                {
                    GuardarNuevaInscripcion(nuevaInscripcion);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Editar;
            establecerEstadoComponentes();
            btnGuardar.Text = "Editar";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Buscar;
            establecerEstadoComponentes();
            frmBuscarPreinscripcion formBuscarPreInscripcion = new frmBuscarPreinscripcion(panelContenido);
            formBuscarPreInscripcion.OnPreinscripcionSeleccionado += FormBusqPreinscripcion_OnPreinscripcionSeleccionado;
            mostrarFormulario(formBuscarPreInscripcion);
        }

        private void FormBusqPreinscripcion_OnPreinscripcionSeleccionado(inscripcion preinscripcion)
        {
            inscripcionSeleccionada = preinscripcion;

            if (preinscripcion.esNuevo)
            {
                rbSi.Checked = false;
                rbNo.Checked = true;
                //ucNuevoEstudiante1.BringToFront();
                ucEstudianteRegistrado1.Visible = false;
                ucNuevoEstudiante1.Visible = true;
                ucNuevoEstudiante1.DNI = preinscripcion.estudiante.DNI;
                ucNuevoEstudiante1.Nombre = preinscripcion.estudiante.nombre;
                ucNuevoEstudiante1.ApellidoMaterno = preinscripcion.estudiante.apellidoMaterno;
                ucNuevoEstudiante1.ApellidoPaterno = preinscripcion.estudiante.apellidoPaterno;
                ucNuevoEstudiante1.Telefono = preinscripcion.estudiante.telefono;
                ucNuevoEstudiante1.Direccion = preinscripcion.estudiante.direccion;
                ucNuevoEstudiante1.GeneroFemenino = preinscripcion.estudiante.genero == "Femenino";
                ucNuevoEstudiante1.GeneroMasculino = preinscripcion.estudiante.genero == "Masculino";
                ucNuevoEstudiante1.FechaNacimiento = preinscripcion.estudiante.fechaNacimiento;
            }
            else
            {
                rbNo.Checked = false;
                rbSi.Checked = true;
                //ucEstudianteRegistrado1.BringToFront();
                ucNuevoEstudiante1.Visible = false;
                ucEstudianteRegistrado1.Visible = true;
                ucEstudianteRegistrado1.EstudianteSeleccionado = preinscripcion.estudiante.idUsuario;
            }
            CargarImagen(preinscripcion.imagen);
        }

        private void CargarImagen(byte[] imagenBytes)
        {
            if (imagenBytes != null && imagenBytes.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imagenBytes))
                {
                    pbImagen.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pbImagen.Image = null; // o alguna imagen por defecto
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar esta pre-inscripcion?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) // Si el usuario confirma...
            {
                // Se llama al web service para eliminar el evento
                int resultadoEliminacion = client.eliminarInscripcion(inscripcionSeleccionada.idInscripcion);

                if (resultadoEliminacion > 0)
                {
                    MessageBox.Show("Inscripcion eliminado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    limpiarComponentes();
                    establecerEstadoComponentes();
                }
                else
                {
                    MessageBox.Show("Hubo un error al eliminar la preinscripcion.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
