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

namespace AstreiaSoft.src.Alumno
{
    public partial class frmBusqTareasAsignadas : Form
    {
        public evaluacionConEntrega[] EvaluacionesConEntregaDisponibles;
        public evaluacionConEntrega EvaluacionConEntregaSeleccionada;

        public delegate void EvaluacionConEntregaSeleccionadoHandler(evaluacionConEntrega evaluacionConEntregaSeleccionada);
        public event EvaluacionConEntregaSeleccionadoHandler OnEvaluacionConEntregaSeleccionado;

        private Panel panelContenido;
        private int idCurso;
        private Form _formPadre;

        public frmBusqTareasAsignadas(Panel panelContenido, int idCurso, Form formPadre)
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

                // Obtener el ID del usuario actual, reemplaza esto con el código correspondiente.
                int idUsuario = GlobalVariables.IdUsuario;

                // Llamar al método del web service y obtener las evaluaciones con entregas y última nota.
                EvaluacionesConEntregaDisponibles = client.listarEvaluacionesConEntregasYUltimaNota(idCurso, idUsuario);

                // Asume que tienes un DataGridView dgvEvaluaciones para mostrar los resultados.
                dgvEvaluaciones.Rows.Clear();

                if (EvaluacionesConEntregaDisponibles != null)
                {
                    foreach (var item in EvaluacionesConEntregaDisponibles)
                    {
                        string puntaje = item.notaEvaluacion != null ? item.notaEvaluacion.puntajeObtenido.ToString() : "-";
                        string estado = item.entrega != null ? item.entrega.estado.ToString() : "Sin Entregar";

                        dgvEvaluaciones.Rows.Add(
                            item.evaluacion.idEvaluacion,
                            item.evaluacion.nombre,
                            item.evaluacion.tipo,
                            item.evaluacion.fechaSubido,
                            item.evaluacion.fechaLimite,
                            estado,
                            puntaje
                        );
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
                EvaluacionConEntregaSeleccionada = EvaluacionesConEntregaDisponibles[selectedIndex];
                this.Close();
                OnEvaluacionConEntregaSeleccionado?.Invoke(EvaluacionConEntregaSeleccionada);
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
