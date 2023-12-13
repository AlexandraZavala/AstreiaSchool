using AstreiaSoft.AdminWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstreiaSoft
{
    public partial class frmGestEvento : Form
    {
        private Estado _estado;
        AdminWSClient client;
        private evento eventoSeleccionado;

        private Panel panelContenido;
        public frmGestEvento(Panel panelContenido)
        {
            client = new AdminWSClient();
            InitializeComponent();
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
            this.panelContenido = panelContenido;
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
                    textBoxNombreEvento.Enabled = false;
                    textBoxLugarEvento.Enabled = false;
                    textBoxDescripcionEvento.Enabled = false;
                    dateTimePickerFechaInicioEvento.Enabled = false;
                    dateTimePickerFechaFinEvento.Enabled = false;
                    textBoxLugarEvento.Enabled = false;
                    dateTimePickerHoraFin.Enabled = false;
                    dateTimePickerHoraInicio.Enabled = false;
                    break;

                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    // otros componentes a habilitar
                    textBoxNombreEvento.Enabled = true;
                    textBoxLugarEvento.Enabled = true;
                    textBoxDescripcionEvento.Enabled = true;
                    dateTimePickerFechaInicioEvento.Enabled = true;
                    dateTimePickerFechaFinEvento.Enabled = true;
                    textBoxLugarEvento.Enabled = true;
                    dateTimePickerHoraFin.Enabled = true;
                    dateTimePickerHoraInicio.Enabled = true;
                    break;

                case Estado.Buscar:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnCancelar.Enabled = true;
                    // otros componentes a deshabilitar
                    textBoxNombreEvento.Enabled = false;
                    textBoxLugarEvento.Enabled = false;
                    textBoxDescripcionEvento.Enabled = false;
                    dateTimePickerFechaInicioEvento.Enabled = false;
                    dateTimePickerFechaFinEvento.Enabled = false;
                    textBoxLugarEvento.Enabled = false;
                    dateTimePickerHoraFin.Enabled = false;
                    dateTimePickerHoraInicio.Enabled = false;
                    break;

                case Estado.Editar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    // otros componentes a habilitar
                    textBoxNombreEvento.Enabled = true;
                    textBoxLugarEvento.Enabled = true;
                    textBoxDescripcionEvento.Enabled = true;
                    dateTimePickerFechaInicioEvento.Enabled = true;
                    dateTimePickerFechaFinEvento.Enabled = true;
                    textBoxLugarEvento.Enabled = true;
                    dateTimePickerHoraFin.Enabled = true;
                    dateTimePickerHoraInicio.Enabled = true;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            // Limpiar campos de texto
            textBoxNombreEvento.Text = "";
            textBoxDescripcionEvento.Text = "";
            textBoxLugarEvento.Text = "";
            btnGuardar.Text = "Guardar";

            // Resetear DateTimePickers a la fecha y hora actual
            dateTimePickerFechaInicioEvento.Value = DateTime.Now;
            dateTimePickerFechaFinEvento.Value = DateTime.Now;
            dateTimePickerHoraInicio.Value = DateTime.Now;
            dateTimePickerHoraFin.Value = DateTime.Now;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Editar;
            establecerEstadoComponentes();
            btnGuardar.Text = "Modificar";
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                evento nuevoEvento = CrearEventoDesdeFormulario();

                if (!ValidarEvento(nuevoEvento))
                    return;

                if (_estado == Estado.Editar)
                {
                    nuevoEvento.idEvento = eventoSeleccionado.idEvento;
                    ModificarEvento(nuevoEvento);
                }
                else
                {
                    GuardarNuevoEvento(nuevoEvento);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private evento CrearEventoDesdeFormulario()
        {
            return new evento
            {
                nombre = textBoxNombreEvento.Text,
                descripcion = textBoxDescripcionEvento.Text,
                lugar = textBoxLugarEvento.Text,
                fechaInicio = dateTimePickerFechaInicioEvento.Value.Date.Add(dateTimePickerHoraInicio.Value.TimeOfDay),
                fechaFin = dateTimePickerFechaFinEvento.Value.Date.Add(dateTimePickerHoraFin.Value.TimeOfDay),
                fechaInicioSpecified = true,
                fechaFinSpecified = true
            };
        }

        private bool ValidarEvento(evento eventoAValidar)
        {
            if (string.IsNullOrEmpty(eventoAValidar.nombre) ||
                string.IsNullOrEmpty(eventoAValidar.descripcion) ||
                string.IsNullOrEmpty(eventoAValidar.lugar))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (eventoAValidar.fechaInicio >= eventoAValidar.fechaFin)
            {
                MessageBox.Show("La fecha y hora de inicio no pueden ser mayores o iguales a la fecha y hora de fin.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ModificarEvento(evento eventoAModificar)
        {
            int resultadoModificacion = client.modificarEvento(eventoAModificar);
            if (resultadoModificacion > 0)
            {
                MessageBox.Show("Evento modificado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _estado = Estado.Inicial;
                limpiarComponentes();
                establecerEstadoComponentes();
            }
            else
            {
                MessageBox.Show("Hubo un error al modificar el evento.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarNuevoEvento(evento nuevoEvento)
        {
            int resultado = client.insertarEvento(nuevoEvento);
            if (resultado > 0)
            {
                MessageBox.Show("Evento registrado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _estado = Estado.Inicial;
                limpiarComponentes();
                establecerEstadoComponentes();
            }
            else
            {
                MessageBox.Show("Hubo un error al registrar el evento.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este evento?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Se llama al web service para eliminar el evento
                int resultadoEliminacion = client.eliminarEvento(eventoSeleccionado.idEvento);

                if (resultadoEliminacion > 0)
                {
                    MessageBox.Show("Evento eliminado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    limpiarComponentes();
                    establecerEstadoComponentes();
                }
                else
                {
                    MessageBox.Show("Hubo un error al eliminar el evento.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Buscar;
            establecerEstadoComponentes();
            frmBuscarEvento formBusqEvent = new frmBuscarEvento(panelContenido);
            formBusqEvent.OnEventoSeleccionado += FormBusqEvent_OnEventoSeleccionado;
            mostrarFormulario(formBusqEvent);
        }

        private void FormBusqEvent_OnEventoSeleccionado(evento eventoElegido)
        {
            eventoSeleccionado = eventoElegido;

            // Llenar los campos del formulario principal con la información del evento seleccionado
            textBoxNombreEvento.Text = eventoElegido.nombre;
            textBoxDescripcionEvento.Text = eventoElegido.descripcion;
            textBoxLugarEvento.Text = eventoElegido.lugar;

            // Asignar la fecha de inicio y de fin al DateTimePicker correspondiente
            dateTimePickerFechaInicioEvento.Value = eventoElegido.fechaInicio.Date;
            dateTimePickerFechaFinEvento.Value = eventoElegido.fechaFin.Date;

            // Separar la hora de inicio y de fin y asignarla al DateTimePicker correspondiente
            dateTimePickerHoraInicio.Value = DateTime.Today.Add(eventoElegido.fechaInicio.TimeOfDay);
            dateTimePickerHoraFin.Value = DateTime.Today.Add(eventoElegido.fechaFin.TimeOfDay);
        }

        public void mostrarFormulario(Form form)
        {
            panelContenido.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            panelContenido.Controls.Add(form);
            form.Visible = true;
        }

        private void gbEvento_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePickerHoraInicio_ValueChanged(object sender, EventArgs e)
        {
        }

        private void labelHoraFin_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNombreEvento_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxDescripcionEvento_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxLugarEvento_TextChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePickerFechaInicioEvento_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePickerFechaFinEvento_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePickerHoraFin_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
