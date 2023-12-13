using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AstreiaSoft.EvalWS;
using evaluacion = AstreiaSoft.EvalWS.evaluacion;
using AstreiaSoft.AdminWS;
using AstreiaSoft.src.Curso.DocenteTareas;

namespace AstreiaSoft
{
    public partial class frmGestTareasDocente : Form
    {
        private Estado _estado;
        private EvalWSClient _daoEvalWS;
        private EvalWS.evaluacion evaluacionSeleccionada;
        private Panel panelContenido;
        private int idCurso;
        Form formPadre;

        public frmGestTareasDocente(Panel panelContenido, int idCursoProg, Form formPadre)
        {
            idCurso = idCursoProg;
            _daoEvalWS = new EvalWSClient();
            InitializeComponent();
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
            this.panelContenido = panelContenido;
            LlenarTiposEvaluacion();
            this.formPadre = formPadre;
        }

        private void LlenarTiposEvaluacion()
        {
            try
            {
                // Llama al método del web service y obtén la lista de tipos de evaluación
                var tiposEvaluacion = _daoEvalWS.listarTiposEvaluacion();

                // Limpia los ítems existentes en el ComboBox
                cbxTipoEvaluacion.Items.Clear();

                // Agrega los tipos de evaluación al ComboBox
                foreach (var tipo in tiposEvaluacion)
                {
                    cbxTipoEvaluacion.Items.Add(tipo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los tipos de evaluación: " + ex.Message);
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

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = false;
                    nudBimestre.Enabled = false;
                    txtDescripcion.Enabled = false;
                    txtNotaMaxima.Enabled = false;
                    cbxTipoEvaluacion.Enabled = false;
                    dtpFechaInicio.Enabled = false;
                    dtpHoraInicio.Enabled = false;
                    dtpFechaFin.Enabled = false;
                    dtpHoraFin.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    nudBimestre.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtNotaMaxima.Enabled = true;
                    cbxTipoEvaluacion.Enabled = true;
                    dtpFechaInicio.Enabled = true;
                    dtpHoraInicio.Enabled = true;
                    dtpFechaFin.Enabled = true;
                    dtpHoraFin.Enabled = true;
                    break;
                case Estado.Buscar:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnCancelar.Enabled = true;
                    nudBimestre.Enabled = false;
                    txtDescripcion.Enabled = false;
                    txtNotaMaxima.Enabled = false;
                    cbxTipoEvaluacion.Enabled = false;
                    dtpFechaInicio.Enabled = false;
                    dtpHoraInicio.Enabled = false;
                    dtpFechaFin.Enabled = false;
                    dtpHoraFin.Enabled = false;
                    break;
                case Estado.Editar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    nudBimestre.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtNotaMaxima.Enabled = true;
                    cbxTipoEvaluacion.Enabled = true;
                    dtpFechaInicio.Enabled = true;
                    dtpHoraInicio.Enabled = true;
                    dtpFechaFin.Enabled = true;
                    dtpHoraFin.Enabled = true;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            // Limpiar campos de texto
            nudBimestre.Text = "";
            txtDescripcion.Text = "";
            cbxTipoEvaluacion.SelectedIndex = -1;
            txtNotaMaxima.Text = "";
            // Resetear DateTimePickers a la fecha y hora actual
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;
            dtpHoraInicio.Value = DateTime.Now;
            dtpHoraFin.Value = DateTime.Now;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private evaluacion CrearEvaluacionDesdeFormulario()
        {
            // Crear una instancia de cursoProgramado
            EvalWS.cursoProgramado nuevoCursoProgramado = new EvalWS.cursoProgramado();
            nuevoCursoProgramado.idCursoProgramado = idCurso;

            // Crear docente
            EvalWS.docente docente = new EvalWS.docente();
            docente.idUsuario = GlobalVariables.IdUsuario;
            EvalWS.bimestre bimestre = new EvalWS.bimestre();
            bimestre.idBimestre = (int)nudBimestre.Value;
            return new evaluacion
            {
                bimestre = bimestre,
                descripcion = txtDescripcion.Text,
                nota = double.TryParse(txtNotaMaxima.Text, out double notaConvertida) ? notaConvertida : 0.0,
                fechaSubido = dtpFechaInicio.Value.Date.Add(dtpHoraInicio.Value.TimeOfDay),
                fechaLimite = dtpFechaFin.Value.Date.Add(dtpHoraFin.Value.TimeOfDay),
                tipo = (AstreiaSoft.EvalWS.tipoEvaluacion)Enum.Parse(typeof(AstreiaSoft.EvalWS.tipoEvaluacion), cbxTipoEvaluacion.SelectedItem?.ToString() ?? "DefaultTipoEvaluacion"),
                cursoProgramado = nuevoCursoProgramado,
                docente = docente,
                activo = true,
                fechaSubidoSpecified = true,
                fechaLimiteSpecified = true,
                tipoSpecified = true, // Solo si tienes control sobre el servicio y este campo es opcional
                activoSpecified = true // Asume que tienes un campo de entrada para 'activo'
            };
        }

        private bool ValidarEvaluacion(evaluacion evaluacionAValidar)
        {
            // Verificar que los campos de texto no estén vacíos
            if (
                string.IsNullOrEmpty(evaluacionAValidar.descripcion))
            {
                MessageBox.Show("Nombre y descripción son campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Verificar que la nota máxima sea un número válido
            if (!Double.TryParse(txtNotaMaxima.Text, out double notaMaxima) || notaMaxima <= 0)
            {
                MessageBox.Show("La nota máxima debe ser un número positivo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Intentar convertir el texto de txtNotaMaxima a un double
            if (Double.TryParse(txtNotaMaxima.Text, out double nota))
            {
                // Verificar que la nota máxima sea como mucho 20
                if (nota > 20)
                {
                    MessageBox.Show("La nota máxima no puede ser mayor a 20.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                // Manejar el caso en que txtNotaMaxima no contiene un número válido
                MessageBox.Show("La nota máxima debe ser un número válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Verificar que se haya seleccionado un tipo de evaluación
            if (cbxTipoEvaluacion.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un tipo de evaluación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ModificarEvaluacion(evaluacion evaluacionAModificar)
        {
            int resultadoModificacion = _daoEvalWS.modificarEvaluacion(evaluacionAModificar);
            if (resultadoModificacion > 0)
            {
                MessageBox.Show("Evaluacion modificada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _estado = Estado.Inicial;
                limpiarComponentes();
                establecerEstadoComponentes();
            }
            else
            {
                MessageBox.Show("Hubo un error al modificar la evaluacion.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarNuevaEvaluacion(evaluacion nuevaEvaluacion)
        {
            int resultado = _daoEvalWS.insertarEvaluacion(nuevaEvaluacion);
            if (resultado > 0)
            {
                MessageBox.Show("Evaluacion registrada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _estado = Estado.Inicial;
                limpiarComponentes();
                establecerEstadoComponentes();
            }
            else
            {
                MessageBox.Show("Hubo un error al registrar la evaluacion.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                evaluacion nuevaEvaluacion = CrearEvaluacionDesdeFormulario();

                if (!ValidarEvaluacion(nuevaEvaluacion))
                    return;

                if (_estado == Estado.Editar)
                {
                    nuevaEvaluacion.idEvaluacion = evaluacionSeleccionada.idEvaluacion;
                    ModificarEvaluacion(nuevaEvaluacion);
                }
                else
                {
                    GuardarNuevaEvaluacion(nuevaEvaluacion);
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
            btnGuardar.Text = "Modificar";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar esta evaluacion?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Se llama al web service para eliminar la evaluacion
                int resultadoEliminacion = _daoEvalWS.eliminarEvaluacion(evaluacionSeleccionada.idEvaluacion);

                if (resultadoEliminacion > 0)
                {
                    MessageBox.Show("Evaluacion eliminada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    limpiarComponentes();
                    establecerEstadoComponentes();
                }
                else
                {
                    MessageBox.Show("Hubo un error al eliminar la evaluacion.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
            frmBuscarTareasAsignadas formBusqTareas = new frmBuscarTareasAsignadas(panelContenido, idCurso, this); // this es frmGestTareasDocente
            formBusqTareas.OnEvaluacionSeleccionado += FormBusqEvaluacion_OnEvaluacionSeleccionado;
            mostrarFormulario(formBusqTareas);
        }

        private void FormBusqEvaluacion_OnEvaluacionSeleccionado(evaluacion evaluacionElegida)
        {
            evaluacionSeleccionada = evaluacionElegida;

            // Llenar los campos del formulario principal con la información de la evaluación seleccionada
            nudBimestre.Value = evaluacionElegida.bimestre.idBimestre;
            txtDescripcion.Text = evaluacionElegida.descripcion;
            txtNotaMaxima.Text = evaluacionElegida.nota.ToString();

            // Asignar la fecha y la hora al DateTimePicker de fecha de inicio
            dtpFechaInicio.Value = evaluacionElegida.fechaSubido;

            // Asignar la fecha y la hora al DateTimePicker de fecha de fin
            dtpFechaFin.Value = evaluacionElegida.fechaLimite;

            // Asignar solamente la hora al DateTimePicker de hora de inicio
            dtpHoraInicio.Value = evaluacionElegida.fechaSubido;

            // Asignar solamente la hora al DateTimePicker de hora de fin
            dtpHoraFin.Value = evaluacionElegida.fechaLimite;

            // Seleccionar el tipo de evaluación en el ComboBox
            cbxTipoEvaluacion.SelectedItem = evaluacionElegida.tipo.ToString();
        }

        
    }
}
