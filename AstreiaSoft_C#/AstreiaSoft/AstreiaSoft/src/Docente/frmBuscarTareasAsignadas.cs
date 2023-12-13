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

namespace AstreiaSoft.src.Curso.DocenteTareas
{
    public partial class frmBuscarTareasAsignadas : Form
    {
        public evaluacion[] EvaluacionesDisponibles;
        public evaluacion EvaluacionSeleccionada;
        private Panel panelContenido;

        public delegate void EvaluacionSeleccionadoHandler(evaluacion evaluacionSeleccionado);
        public event EvaluacionSeleccionadoHandler OnEvaluacionSeleccionado;
        private int idCurso;
        private Form _formPadre;

        public frmBuscarTareasAsignadas(Panel panelContenido, int idCurso, Form formPadre)
        {
            this.idCurso = idCurso;
            InitializeComponent();
            this.panelContenido = panelContenido;
            _formPadre = formPadre;
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
                        dgvEvaluaciones.Rows.Add(ev.idEvaluacion, ev.nombre, ev.descripcion, ev.fechaSubido, ev.fechaLimite, ev.nota);
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
                this.Close();
                OnEvaluacionSeleccionado?.Invoke(EvaluacionSeleccionada);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una evaluacion.");
            }
            panelContenido.Controls.Clear();
            panelContenido.Controls.Add(_formPadre);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            panelContenido.Controls.Clear();
            panelContenido.Controls.Add(_formPadre);
        }

    }
}
