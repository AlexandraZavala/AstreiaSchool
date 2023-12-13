using AstreiaSoft.AdminWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstreiaSoft
{
    public partial class frmRevisionPreInscripciones : Form
    {
        public inscripcion PreinscripcionSeleccionada { get; private set; }
        private Panel panelContenido;
        private inscripcion[] PreinscripcionesDisponibles;
        AdminWSClient client = new AdminWSClient();
        public delegate void InscripcionSeleccionadoHandler(inscripcion inscripcionSeleccionada);
        public event InscripcionSeleccionadoHandler OnInscripcionSeleccionado;

        public frmRevisionPreInscripciones(Panel panelContenido)
        {
            InitializeComponent();
            this.panelContenido = panelContenido;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvRevisionPreinscripciones.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvRevisionPreinscripciones.SelectedRows[0].Index;
                PreinscripcionSeleccionada = PreinscripcionesDisponibles[selectedIndex];
                this.Close();
                OnInscripcionSeleccionado?.Invoke(PreinscripcionSeleccionada);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un evento.");
            }
            panelContenido.Controls.Clear();
            panelContenido.Controls.Add(frmPantallaPrincipal.formularios[frmPantallaPrincipal.formularios.Count - 1]);
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboEstado.SelectedIndex == -1) // Lista todos
                {
                    PreinscripcionesDisponibles = client.listarPreinscripciones();
                }
                else if (cboEstado.SelectedIndex == 0) // Lista solo los pre-inscritos
                {
                    PreinscripcionesDisponibles = client.listarPreinscripcionesPorEstado("Pre-Inscrito");
                }
                else if (cboEstado.SelectedIndex == 1) // Lista solo los rechazados
                {
                    PreinscripcionesDisponibles = client.listarPreinscripcionesPorEstado("Rechazado");
                }

                dgvRevisionPreinscripciones.Rows.Clear();

                if (PreinscripcionesDisponibles != null)
                {
                    foreach (inscripcion inscripcion in PreinscripcionesDisponibles)
                    {
                        // Formateo del nombre completo del estudiante
                        string nombreCompleto = $"{inscripcion.estudiante.nombre} {inscripcion.estudiante.apellidoPaterno} {inscripcion.estudiante.apellidoMaterno}";
                        // Adapt the following line to the real columns of your DataGridView and the properties of your Inscripcion object.
                        dgvRevisionPreinscripciones.Rows.Add(inscripcion.idInscripcion, nombreCompleto, inscripcion.periodoAcademico, inscripcion.fecha, inscripcion.estado, inscripcion.esNuevo ? "Nuevo" : "Recurrente");
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron pre-inscripciones.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al buscar las pre-inscripciones: " + ex.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            panelContenido.Controls.Clear();
            panelContenido.Controls.Add(frmPantallaPrincipal.formularios[frmPantallaPrincipal.formularios.Count - 1]);
        }
    }
}
