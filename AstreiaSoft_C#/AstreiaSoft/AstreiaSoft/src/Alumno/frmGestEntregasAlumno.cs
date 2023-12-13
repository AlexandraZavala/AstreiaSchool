using AstreiaSoft.EvalWS;
using AstreiaSoft.src.Alumno;
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
    public partial class frmGestEntregasAlumno : Form
    {
        private Panel panelContenido;
        private int idCurso;
        private Estado _estado;
        private EvalWSClient _daoEvalWS;
        private evaluacionConEntrega evaluacionConEntregaSeleccionada;
        public frmGestEntregasAlumno(Panel panelContenido, int idCursoProg)
        {
            idCurso = idCursoProg;
            _daoEvalWS = new EvalWSClient();
            InitializeComponent();
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
            limpiarComponentes();
            this.panelContenido = panelContenido;
        }

        private void limpiarComponentes()
        {
            pbFoto.Image = null;

            dtpFechaRevision.Enabled = false; // Esto deshabilitará el control
            dtpFechaRevision.CustomFormat = " "; // Establece el formato personalizado en espacio en blanco
            dtpFechaRevision.Format = DateTimePickerFormat.Custom; // Cambia el formato a personalizado

            dtpFechaInicio.Enabled = false; // Esto deshabilitará el control
            dtpFechaInicio.CustomFormat = " "; // Establece el formato personalizado en espacio en blanco
            dtpFechaInicio.Format = DateTimePickerFormat.Custom; // Cambia el formato a personalizado

            dtpFechaFin.Enabled = false; // Esto deshabilitará el control
            dtpFechaFin.CustomFormat = " "; // Establece el formato personalizado en espacio en blanco
            dtpFechaFin.Format = DateTimePickerFormat.Custom; // Cambia el formato a personalizado

            nombreEval.Text = null;
            txtTipoEvaluacion.Text = null;
            txtIDEntrega.Text = null;
            txtEstadoEntrega.Text = null;
            txtNotaEntrega.Text = null;
            txtObservacionesEntrega.Text = null;

            btnGuardar.Text = "Guardar";
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    break;
                case Estado.Buscar:
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    break;
            }
        }

        private void btnEntregarTarea_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La entrega ha sido registrada exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public byte[] ConvertImageToByteArray(Image image)
        {
            if (image == null)
            {
                MessageBox.Show("No se ha seleccionado ninguna imagen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private entrega CrearEntregaDesdeFormulario()
        {
            // Asume que tienes un mecanismo para convertir el archivo a un byte array
            byte[] archivo = ConvertImageToByteArray(pbFoto.Image);
            string observaciones = txtObservacionesEntrega.Text;
            //estudiante est = new estudiante();
            //est.idUsuario = GlobalVariables.IdUsuario;
            //evaluacion ev = new evaluacion();
            //ev.idEvaluacion = evaluacionConEntregaSeleccionada.evaluacion.idEvaluacion;

            return new entrega
            {
                archivo = archivo,
                observaciones = observaciones,
                //estudiante = est,
                //evaluacion = ev
            };
        }

        private bool ValidarEntrega(entrega entrega)
        {
            if (entrega == null)
            {
                MessageBox.Show("La entrega no fue creada exitosamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //if (entrega.estudiante == null)
            //{
            //    MessageBox.Show("La entrega debe estar asociada a un estudiante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}

            if (entrega.archivo == null)
            {
                MessageBox.Show("Debe cargar la imagen de su trabajo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar el tamaño de la imagen
            if (entrega.archivo.Length > 65535)
            {
                MessageBox.Show("El tamaño de la imagen excede el máximo permitido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void GuardarNuevaEntrega(entrega nuevaEntrega)
        {
            // Asume que tienes un método en tu web service para insertar una nueva entrega
            int idEvaluacion = evaluacionConEntregaSeleccionada.evaluacion.idEvaluacion;
            int idEstudiante = GlobalVariables.IdUsuario; // Obtener el ID del estudiante de alguna manera
            int resultado = _daoEvalWS.insertarEntrega(nuevaEntrega, idEvaluacion, idEstudiante);
            if (resultado > 0)
            {
                MessageBox.Show("Entrega guardada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _estado = Estado.Inicial;
                limpiarComponentes();
                establecerEstadoComponentes();
            }
            else
            {
                MessageBox.Show("Hubo un error al guardar la entrega.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModificarEntrega(entrega entregaModificada)
        {
            // Asume que tienes un método en tu web service para modificar una entrega existente
            int resultadoModificacion = _daoEvalWS.modificarEntrega(entregaModificada);
            if (resultadoModificacion > 0)
            {
                MessageBox.Show("Entrega modificada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _estado = Estado.Inicial;
                limpiarComponentes();
                establecerEstadoComponentes();
            }
            else
            {
                MessageBox.Show("Hubo un error al modificar la entrega.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var entrega = CrearEntregaDesdeFormulario();

                if (!ValidarEntrega(entrega))
                    return;

                // Verificar si es una nueva entrega o una actualización
                if (evaluacionConEntregaSeleccionada.entrega == null)
                {
                    // Es una nueva entrega
                    GuardarNuevaEntrega(entrega);
                }
                else
                {
                    // Actualizar una entrega existente
                    entrega.idEntrega = evaluacionConEntregaSeleccionada.entrega.idEntrega;
                    ModificarEntrega(entrega);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Buscar;
            establecerEstadoComponentes();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Seleccionar;
            establecerEstadoComponentes();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void mostrarFormulario(Form form)
        {
            panelContenido.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            panelContenido.Controls.Add(form);
            form.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _estado = Estado.Buscar;
            establecerEstadoComponentes();
            frmBusqTareasAsignadas formBusqTareas = new frmBusqTareasAsignadas(panelContenido, idCurso, this);
            formBusqTareas.OnEvaluacionConEntregaSeleccionado += FormBusqEvaluacion_OnEvaluacionSeleccionado;
            mostrarFormulario(formBusqTareas);
        }

        private void FormBusqEvaluacion_OnEvaluacionSeleccionado(evaluacionConEntrega evaluacionElegida)
        {
            _estado = Estado.Buscar;
            establecerEstadoComponentes();

            evaluacionConEntregaSeleccionada = evaluacionElegida;

            // Actualizar la interfaz de usuario con los datos de evaluacionConEntrega
            nombreEval.Text = evaluacionElegida.evaluacion.nombre;

            //dtpFechaInicio.Enabled = true;
            dtpFechaInicio.Format = DateTimePickerFormat.Short; 
            dtpFechaInicio.Value = evaluacionElegida.evaluacion.fechaSubido;

            //dtpFechaFin.Enabled = true;
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Value = evaluacionElegida.evaluacion.fechaLimite; 

            txtTipoEvaluacion.Text = evaluacionElegida.evaluacion.tipo.ToString();

            // Deshabilitar controles si la fecha actual es mayor a la fecha de finalización de la tarea
            if (DateTime.Now > evaluacionElegida.evaluacion.fechaLimite)
            {
                txtObservacionesEntrega.Enabled = false;
                btnCargar.Enabled = false;
                btnGuardar.Enabled = false;
            }

            // Si hay entrega, actualizar los campos de entrega
            if (evaluacionElegida.entrega != null)
            {
                txtIDEntrega.Text = evaluacionElegida.entrega.idEntrega.ToString();
                txtEstadoEntrega.Text = evaluacionElegida.entrega.estado.ToString();
                txtObservacionesEntrega.Text = evaluacionElegida.entrega.observaciones;

                // Si hay un archivo de imagen, mostrarlo en el PictureBox
                if (evaluacionElegida.entrega.archivo != null && evaluacionElegida.entrega.archivo.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(evaluacionElegida.entrega.archivo))
                    {
                        pbFoto.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pbFoto.Image = null;
                }


                // Primero, verificamos si la fecha de revisión no es null y es una fecha válida.
                if (evaluacionElegida.entrega.fechaRevision != null &&
                    evaluacionElegida.entrega.fechaRevision > dtpFechaRevision.MinDate &&
                    evaluacionElegida.entrega.fechaRevision < dtpFechaRevision.MaxDate)
                {
                    dtpFechaRevision.Format = DateTimePickerFormat.Short;
                    dtpFechaRevision.Value = evaluacionElegida.entrega.fechaRevision;
                }
                else
                {
                    // Si la fecha es null o está fuera de rango, se muestra el control vacío.
                    dtpFechaRevision.CustomFormat = " "; // Esto hará que el control se muestre vacío.
                    dtpFechaRevision.Format = DateTimePickerFormat.Custom;
                }

                // Habilitar o deshabilitar el botón Cargar basado en el estado de la entrega
                EvalWS.estadoEntrega estado = evaluacionElegida.entrega.estado;
                btnCargar.Enabled = estado == estadoEntrega.Pendiente;
                txtObservacionesEntrega.Enabled = estado == estadoEntrega.Pendiente;

                if (estado == estadoEntrega.Pendiente)
                {
                    btnGuardar.Text = "Modificar";
                }
                else btnGuardar.Text = "Guardar";
            }
            else
            {
                // Limpiar o deshabilitar los campos relacionados con la entrega si no hay ninguna
                txtIDEntrega.Text = "-";
                txtEstadoEntrega.Text = "Sin Entregar";
                txtObservacionesEntrega.Clear();
                txtObservacionesEntrega.Enabled = true;

                dtpFechaRevision.Enabled = false; // Esto deshabilitará el control
                dtpFechaRevision.CustomFormat = " "; // Establece el formato personalizado en espacio en blanco
                dtpFechaRevision.Format = DateTimePickerFormat.Custom; // Cambia el formato a personalizado
                
                pbFoto.Image = null;
                // Si no hay entrega, el botón Cargar se debe habilitar
                btnCargar.Enabled = true;
            }

            // Si hay una nota de evaluación, actualizar los campos de nota
            if (evaluacionElegida.notaEvaluacion != null)
            {
                txtNotaEntrega.Text = evaluacionElegida.notaEvaluacion.puntajeObtenido.ToString();
            }
            else
            {
                // Limpiar o deshabilitar los campos relacionados con la nota si no hay ninguna
                txtNotaEntrega.Text = "-";
            }
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
                pbFoto.ImageLocation = openFileDialog.FileName;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtNotaEntrega_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
