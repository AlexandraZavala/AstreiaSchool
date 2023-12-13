using AstreiaSoft;
using AstreiaSoft.AdminWS;
using AstreiaSoft.MallaWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft
{
    public partial class frmGestAsistencia : Form
    {
        private Estado _estado;
        private int idCurso;

        public frmGestAsistencia(int idCursoProg)
        {
            idCurso = idCursoProg;
            InitializeComponent();
            _estado = AstreiaSoft.Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();

            // Incrementa en un día la fecha del DateTimePicker
            //dtpFecha.Value = DateTime.Now.AddDays(-1);
            dtpFecha.Value = DateTime.Now;
        
            LlenarHorarios();
            cbxListaHorarios.SelectedIndex = -1;
            dgvAsistencias.AllowUserToAddRows = false;
            dgvAsistencias.CellValueChanged += new DataGridViewCellEventHandler(dgvAsistencias_CellContentClick);
        }

        private void LlenarAsistencias(int idHorario, int idCursoProgramado)
        {
            dgvAsistencias.Rows.Clear();
            try
            {
                AdminWSClient client = new AdminWSClient();
                // Asumiendo que la fecha del componente dtpFecha es del tipo DateTime en C#
                DateTime fecha = dtpFecha.Value.Date;
                AstreiaSoft.AdminWS.asistencia[] asistenciasSet = client.obtenerOListarAsistencias(idHorario, fecha);

                if (asistenciasSet != null)
                {
                    btnGuardar.Text = "Editar asistencia";
                    foreach (var asistencia in asistenciasSet)
                    {
                        // Formateo del nombre completo del estudiante
                        string nombreCompleto = $"{asistencia.estudiante.nombre} {asistencia.estudiante.apellidoPaterno} {asistencia.estudiante.apellidoMaterno}";

                        // Crear una nueva fila para el DataGridView
                        int index = dgvAsistencias.Rows.Add(); // Agrega una nueva fila y obtiene el índice de la fila

                        // Establecer los valores de las celdas
                        dgvAsistencias.Rows[index].Cells["Codigo"].Value = asistencia.estudiante.idUsuario;
                        dgvAsistencias.Rows[index].Cells["Estudiante"].Value = nombreCompleto;
                        // Determinar el estado de los checkbox basado en el estado de la asistencia
                        dgvAsistencias.Rows[index].Cells["Presente"].Value = asistencia.estado == AstreiaSoft.AdminWS.estadoAsistencia.Presente;
                        dgvAsistencias.Rows[index].Cells["Tardanza"].Value = asistencia.estado == AstreiaSoft.AdminWS.estadoAsistencia.Tardanza;
                        dgvAsistencias.Rows[index].Cells["Observaciones"].Value = asistencia.observaciones ?? ""; // Campo de observaciones
                    }
                }
                else
                {
                    btnGuardar.Text = "Registrar asistencia";
                    dgvAsistencias.Rows.Clear();
                    try
                    {
                        AstreiaSoft.AdminWS.estudiante[] estudiantesSet = client.listarEstudiantesDelCursoProgramado(idCurso, idHorario);
                        if (estudiantesSet != null)
                        {
                            // Limpiar las filas existentes para evitar duplicados
                            dgvAsistencias.Rows.Clear();

                            foreach (var est in estudiantesSet)
                            {
                                // Formateo del nombre completo del estudiante
                                string nombreCompleto = $"{est.nombre} {est.apellidoPaterno} {est.apellidoMaterno}";

                                // Crear una nueva fila para el DataGridView
                                int index = dgvAsistencias.Rows.Add(); // Agrega una nueva fila y obtiene el índice de la fila

                                // Establecer los valores de las celdas
                                dgvAsistencias.Rows[index].Cells["Codigo"].Value = est.idUsuario;
                                dgvAsistencias.Rows[index].Cells["Estudiante"].Value = nombreCompleto;
                                dgvAsistencias.Rows[index].Cells["Presente"].Value = false; // Checkbox desmarcado
                                dgvAsistencias.Rows[index].Cells["Tardanza"].Value = false; // Checkbox desmarcado
                                dgvAsistencias.Rows[index].Cells["Observaciones"].Value = null; // Campo de observaciones vacío
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al obtener la lista de estudiantes del curso: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la lista de asistencias: " + ex.Message);
            }
        }


        List<AstreiaSoft.AdminWS.horario> horarios;
        private void LlenarHorarios()
        {
            try
            {
                string dia = dtpFecha.Value.ToString("dddd", new System.Globalization.CultureInfo("es-ES"));
                dia = char.ToUpper(dia[0]) + dia.Substring(1); // Asegúrate de que la primera letra sea mayúscula
                AdminWSClient client = new AdminWSClient();
                AstreiaSoft.AdminWS.horario[] set = client.listarHorariosDelCurso(idCurso, GlobalVariables.IdUsuario, dia);
                if (set != null)
                {
                    horarios = set.ToList();

                    cbxListaHorarios.DataSource = horarios
                    .Select(h => new
                    {
                        NombreCompleto = $"{h.seccion.nombre} - {h.horaIni:HH:mm} - {h.horaFin:HH:mm}",
                        Id = h.idHorario
                    })
                    .ToList();
                    cbxListaHorarios.DisplayMember = "NombreCompleto";
                    cbxListaHorarios.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la lista de horarios del curso: " + ex.Message);
            }
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case AstreiaSoft.Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    dtpFecha.Enabled = false;
                    cbxListaHorarios.Enabled = false;
                    btnListarEstudiantes.Enabled = false;
                    cbMarcarTodos.Enabled = false;
                    // otros componentes a deshabilitar
                    break;

                case AstreiaSoft.Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    dtpFecha.Enabled = true;
                    cbxListaHorarios.Enabled = true;
                    btnListarEstudiantes.Enabled = true;
                    cbMarcarTodos.Enabled = true;
                    // otros componentes a habilitar
                    break;

                case AstreiaSoft.Estado.Buscar:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    dtpFecha.Enabled = true;
                    cbMarcarTodos.Enabled = true;
                    // otros componentes a deshabilitar
                    break;

                case AstreiaSoft.Estado.Editar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    dtpFecha.Enabled = true;
                    // otros componentes a habilitar
                    break;
            }
        }

        public void limpiarComponentes()
        {
            cbxListaHorarios.SelectedIndex = -1;
            cbMarcarTodos.Checked = false;
            dgvAsistencias.Rows.Clear();  // Limpia el DataGridView
            btnGuardar.Text = "Registrar Asistencia";
            dtpFecha.Value = DateTime.Now;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = AstreiaSoft.Estado.Nuevo;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = AstreiaSoft.Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _estado = AstreiaSoft.Estado.Editar;
            establecerEstadoComponentes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                List<AstreiaSoft.AdminWS.asistencia> asistencias = CrearAsistenciasDesdeFormulario();

                if (!ValidarAsistencias(asistencias))
                    return;

                bool todoCorrecto = true;

                foreach (var asistencia in asistencias)
                {
                    int resultado = InsertarOModificarAsistencia(asistencia);

                    if (resultado <= 0)
                    {
                        MessageBox.Show("Hubo un error al registrar la asistencia para el estudiante con código: " + asistencia.estudiante.idUsuario, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        todoCorrecto = false;
                        break; // Detener el procesamiento si hay un error
                    }
                }

                if (todoCorrecto)
                {
                    MessageBox.Show("Todas las asistencias se registraron con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = AstreiaSoft.Estado.Inicial;
                    limpiarComponentes();
                    establecerEstadoComponentes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int InsertarOModificarAsistencia(AstreiaSoft.AdminWS.asistencia asistencia)
        {
            using (AdminWSClient client = new AdminWSClient())
            {
                return client.insertarAsistencia(asistencia);
            }
        }

        private List<AstreiaSoft.AdminWS.asistencia> CrearAsistenciasDesdeFormulario()
        {
            List<AstreiaSoft.AdminWS.asistencia> asistencias = new List<AstreiaSoft.AdminWS.asistencia>();

            foreach (DataGridViewRow row in dgvAsistencias.Rows)
            {
                if (!row.IsNewRow)
                {
                    AstreiaSoft.AdminWS.estudiante estudiante = new AstreiaSoft.AdminWS.estudiante();
                    AstreiaSoft.AdminWS.horario horario = new AstreiaSoft.AdminWS.horario();
                    AstreiaSoft.AdminWS.asistencia asistencia = new AstreiaSoft.AdminWS.asistencia();
                    asistencia.fecha = dtpFecha.Value;
                    asistencia.fechaSpecified = true;
                    asistencia.estadoSpecified= true;
                    estudiante.idUsuario = Convert.ToInt32(row.Cells["Codigo"].Value);
                    asistencia.estudiante = estudiante;
                    // Obtener el ID del horario seleccionado
                    int selectedHorarioId = (int)cbxListaHorarios.SelectedValue;
                    asistencia.horario = horarios.FirstOrDefault(h => h.idHorario == selectedHorarioId);

                    // Asumiendo que 'Presente' y 'Tardanza' son checkbox que no pueden estar marcados a la vez.
                    if (Convert.ToBoolean(row.Cells["Presente"].Value))
                    {
                        asistencia.estado = AstreiaSoft.AdminWS.estadoAsistencia.Presente;
                    }
                    else if (Convert.ToBoolean(row.Cells["Tardanza"].Value))
                    {
                        asistencia.estado = AstreiaSoft.AdminWS.estadoAsistencia.Tardanza;
                    }
                    else
                    {
                        asistencia.estado = AstreiaSoft.AdminWS.estadoAsistencia.Ausente;
                    }

                    string observaciones = row.Cells["Observaciones"].Value?.ToString() ?? string.Empty;
                    asistencia.observaciones = observaciones;

                    asistencias.Add(asistencia);
                }
            }

            return asistencias;
        }

        private bool ValidarAsistencias(List<AstreiaSoft.AdminWS.asistencia> asistencias)
        {
            if (!asistencias.Any())
            {
                MessageBox.Show("No hay asistencias para procesar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtpFecha.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("La fecha de asistencia no puede ser futura.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (horarios == null || horarios.Count == 0)
            {
                MessageBox.Show("Seleccione un horario para registrar las asistencias por favor.");
                return false;
            }

            // Otras validaciones específicas podrían ir aquí

            return true;
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar esta asistencia?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Asistencia eliminada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _estado = AstreiaSoft.Estado.Inicial;
                limpiarComponentes();
                establecerEstadoComponentes();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _estado = AstreiaSoft.Estado.Buscar;
            establecerEstadoComponentes();

            // Aquí invocarías el formulario de búsqueda de asistencias, si lo tienes.
            frmBuscarAsistencia formBuscarAsistencia = new frmBuscarAsistencia();
            if (formBuscarAsistencia.ShowDialog() == DialogResult.OK)
            { }
        }

        private void btnBuscarEstudiantes_Click(object sender, EventArgs e)
        {
            frmBuscarEstudiante formBuscarEstudiante = new frmBuscarEstudiante();
            if (formBuscarEstudiante.ShowDialog() == DialogResult.OK)
            {
                // Aquí puedes agregar acciones adicionales que quieras realizar después de seleccionar un estudiante
            }
        }

        private void tbCodCurso_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmGestAsistencia_Load(object sender, EventArgs e)
        {

        }

        private void btnListarEstudiantes_Click(object sender, EventArgs e)
        {
            cbMarcarTodos.Checked = false;
            if (cbxListaHorarios.SelectedItem != null)
            {
                int idHorario = Convert.ToInt32(cbxListaHorarios.SelectedValue);
                LlenarAsistencias(idHorario, idCurso);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un horario antes de listar los estudiantes.");
            }
        }

        private void cbMarcarTodos_CheckedChanged(object sender, EventArgs e)
        {
            // Verificar si el DataGridView tiene alguna fila
            if (dgvAsistencias.Rows.Count == 0)
            {
                // Si el DataGridView está vacío, muestra un mensaje de error
                MessageBox.Show("Primero debe listar los estudiantes.");
                // Asegúrate de desmarcar el cbMarcarTodos ya que no hay filas para marcar
                cbMarcarTodos.CheckedChanged -= cbMarcarTodos_CheckedChanged;
                cbMarcarTodos.Checked = false;
                cbMarcarTodos.CheckedChanged += cbMarcarTodos_CheckedChanged;
            }
            else
            {
                // Obtener el estado del CheckBox 'cbMarcarTodos'
                bool checkState = cbMarcarTodos.Checked;

                // Recorrer todas las filas del DataGridView
                foreach (DataGridViewRow row in dgvAsistencias.Rows)
                {
                    // Cambiar el estado del CheckBox en la columna "Presente"
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells["Presente"] as DataGridViewCheckBoxCell;
                    checkBoxCell.Value = checkState;
                }
            }
        }

        private void dgvAsistencias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Confirma que el click es en una celda de checkbox
            if (e.RowIndex >= 0 && (e.ColumnIndex == dgvAsistencias.Columns["Presente"].Index || e.ColumnIndex == dgvAsistencias.Columns["Tardanza"].Index))
            {
                DataGridViewCheckBoxCell checkPresente = (DataGridViewCheckBoxCell)dgvAsistencias.Rows[e.RowIndex].Cells["Presente"];
                DataGridViewCheckBoxCell checkTardanza = (DataGridViewCheckBoxCell)dgvAsistencias.Rows[e.RowIndex].Cells["Tardanza"];

                // Si el checkbox de Presente fue clickeado y está marcado, desmarca Tardanza
                if (e.ColumnIndex == dgvAsistencias.Columns["Presente"].Index && (bool)checkPresente.Value)
                {
                    checkTardanza.Value = false;
                }
                // Si el checkbox de Tardanza fue clickeado y está marcado, desmarca Presente
                else if (e.ColumnIndex == dgvAsistencias.Columns["Tardanza"].Index && (bool)checkTardanza.Value)
                {
                    checkPresente.Value = false;
                }

                dgvAsistencias.EndEdit(); // Importante: finaliza la edición de la celda
            }
        }

        private void cbxListaHorarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvAsistencias.Rows.Clear();  // Limpia el DataGridView
            cbMarcarTodos.Checked = false;
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            dgvAsistencias.Rows.Clear();  // Limpia el DataGridView
            cbMarcarTodos.Checked = false;
            cbxListaHorarios.DataSource = null; // Set the DataSource to null
            cbxListaHorarios.Items.Clear(); // Now you can clear the items
                                            // ... modify your data source if needed
                                            //cbxListaHorarios.DataSource = yourDataSource; // Rebind the DataSource;
            LlenarHorarios();
        }
    }
}
