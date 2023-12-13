using AstreiaSoft.EvalWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstreiaSoft.src.Docente
{
    public partial class frmBuscarEntregas : Form
    {
        private Panel panelContenido;
        public evaluacion[] EvaluacionesDisponibles;
        public evaluacion EvaluacionSeleccionada;
        private int idCurso;

        public notaEvaluacion[] EntregasDisponibles;
        public notaEvaluacion EntregaSeleccionada;

        public frmBuscarEntregas(Panel panel, int idCurso)
        {
            this.idCurso = idCurso;
            panelContenido = panel;
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear instancia del cliente web service.
                EvalWSClient client = new EvalWSClient();
                string nombreFiltro = txtNombre.Text; // Asume que tienes un TextBox txtNombre para filtrar por nombre.

                // Llamar al método del web service y obtener las evaluaciones.
                // Asume que tienes un método para obtener el ID del curso programado, y una forma de introducir el nombre de la evaluación.
                EvaluacionesDisponibles = client.listarEvaluacionesPorNombre(idCurso, nombreFiltro);

                // Asume que tienes un DataGridView dgvEvaluaciones para mostrar los resultados.
                dgvEvaluaciones.Rows.Clear();

                if (EvaluacionesDisponibles != null)
                {
                    foreach (evaluacion ev in EvaluacionesDisponibles)
                    {
                        dgvEvaluaciones.Rows.Add(ev.idEvaluacion, ev.nombre, ev.tipo, ev.fechaSubido, ev.fechaLimite);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron evaluaciones disponibles con los criterios especificados.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al buscar las evaluaciones: " + ex.Message);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvEvaluaciones.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvEvaluaciones.SelectedRows[0].Index;
                EvaluacionSeleccionada = EvaluacionesDisponibles[selectedIndex];
                llenarCardEvaluacion();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una evaluacion.");
            }
        }

        private void llenarCardEvaluacion()
        {
            txtIDEvaluacion.Text = EvaluacionSeleccionada.idEvaluacion.ToString();
            txtNombreEvaluacion.Text = EvaluacionSeleccionada.nombre.ToString();
            txtTipoEvaluacion.Text = EvaluacionSeleccionada.tipo.ToString();
        }

        private void btnBuscarEntregas_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear instancia del cliente web service.
                EvalWSClient client = new EvalWSClient();
                string nombreFiltro = txtNombre.Text; // Asume que tienes un TextBox txtNombre para filtrar por nombre.

                // Llamar al método del web service y obtener las evaluaciones.
                if (EvaluacionSeleccionada == null)
                {
                    MessageBox.Show("Seleccione una evaluacion primero.");
                    return;
                }

                EntregasDisponibles = client.listarEntregasPorEvaluacion(EvaluacionSeleccionada.idEvaluacion);

                // Asume que tienes un DataGridView dgvEvaluaciones para mostrar los resultados.
                dgvEntregas.Rows.Clear();

                if (EntregasDisponibles != null)
                {
                    foreach (notaEvaluacion ev in EntregasDisponibles)
                    {
                        // Formateo del nombre completo del estudiante
                        string nombreCompleto = $"{ev.entrega.estudiante.nombre} {ev.entrega.estudiante.apellidoPaterno} {ev.entrega.estudiante.apellidoMaterno}";
                        
                        // Suponiendo que 'ev' es de tipo 'AstreiaSoft.EvalWS.entrega' y representa una entrega con posiblemente una nota de evaluación asociada
                        if (ev.idNotaEvaluacion > 0)
                        {
                            // Ahora es seguro acceder a 'puntajeObtenido' porque 'notaEvaluacion' no es nula
                            dgvEntregas.Rows.Add(ev.entrega.idEntrega, nombreCompleto, ev.entrega.fechaEntrega, ev.entrega.estado, ev.puntajeObtenido);
                        }
                        else
                        {
                            // Si 'notaEvaluacion' es nula, puedes decidir qué hacer en este caso.
                            // Por ejemplo, podrías agregar una fila con un valor predeterminado o un marcador de posición para 'puntajeObtenido'.
                            dgvEntregas.Rows.Add(ev.entrega.idEntrega, nombreCompleto, ev.entrega.fechaEntrega, ev.entrega.estado, "N/A");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron entregas disponibles con los criterios especificados.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al buscar las entregas: " + ex.Message);
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

        private void btnSeleccionarEntrega_Click(object sender, EventArgs e)
        {
            if (dgvEntregas.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvEntregas.SelectedRows[0].Index;
                if (selectedIndex >= 0 && selectedIndex < EntregasDisponibles.Length)
                {
                    EntregaSeleccionada = EntregasDisponibles[selectedIndex];
                    frmGestNotas formBusqTareas = new frmGestNotas(panelContenido, this, EvaluacionSeleccionada, EntregaSeleccionada);
                    mostrarFormulario(formBusqTareas);
                }
                else
                {
                    MessageBox.Show("La selección es inválida.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una entrega.");
            }
        }
    }
}
