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
    public partial class frmBuscarPreinscripcion : Form
    {
        private inscripcion[] PreinscripcionesDisponibles; // Almacenará las preinscripciones obtenidas del servicio web.
        public inscripcion PreinscripcionSeleccionada { get; private set; }

        public delegate void PreinscripcionSeleccionadoHandler(inscripcion preinscripcionseleccionada);
        public event PreinscripcionSeleccionadoHandler OnPreinscripcionSeleccionado;

        private Panel panelContenido;
        AdminWSClient client = new AdminWSClient();

        public frmBuscarPreinscripcion(Panel panelContenido)
        {
            InitializeComponent();
            this.panelContenido = panelContenido;
            // Aquí puedes cargar los hijos del padre de familia en el ComboBox (cbxHijos)
            cargarHijos();
            cboHijos.SelectedIndex = -1;
        }

        private void cargarHijos()
        {
            try
            {
                // Llamamos al método del web service con el idPadre hardcodeado
                AdminWS.usuario[] hijosSourceSet = client.listarHijosDePadre(13);

                // Comprobamos que no sea null y que tenga datos
                if (hijosSourceSet != null)
                {
                    List<AdminWS.usuario> hijos = hijosSourceSet.ToList();

                    // Llenamos el ComboBox con los datos
                    cboHijos.DataSource = hijos;

                    // Si deseas mostrar una propiedad específica de Usuario en el ComboBox:
                    cboHijos.DisplayMember = "nombre"; // Suponiendo que 'nombre' es una propiedad de Usuario
                    cboHijos.ValueMember = "idUsuario"; // Suponiendo que 'id_usuario' es una propiedad de Usuario
                }
                else
                {
                    // Si no hay hijos o el resultado es null, podemos mostrar un mensaje o manejarlo como prefieras.
                    MessageBox.Show("No se encontraron hijos para el padre seleccionado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al obtener los hijos: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // Reemplaza con los campos de entrada correctos, como un comboBox que tenga los ID de los hijos.
                int idPadre = 13; // Aquí debes obtener el ID del padre de familia.
                // Obtener el estudiante seleccionado en el ComboBox.
                usuario estudianteSeleccionado = cboHijos.SelectedItem as usuario;

                // Si deseas filtrar por un hijo en particular:
                if (estudianteSeleccionado != null) // Suponiendo que 0 significa que no se ha seleccionado un hijo específico.
                {
                    int idEstudiante = estudianteSeleccionado.idUsuario;
                    PreinscripcionesDisponibles = client.listarPorPadreEstudiante(idPadre, idEstudiante);
                }
                else
                {
                    PreinscripcionesDisponibles = client.listarPorPadre(idPadre);
                }

                dgvPreInscripciones.Rows.Clear();

                if (PreinscripcionesDisponibles != null)
                {
                    foreach (inscripcion inscripcion in PreinscripcionesDisponibles)
                    {
                        // Asegúrate de adaptar la siguiente línea a las columnas reales de tu DataGridView y a las propiedades de tu objeto Inscripcion.
                        dgvPreInscripciones.Rows.Add(inscripcion.idInscripcion, inscripcion.estudiante.nombre, inscripcion.periodoAcademico, inscripcion.fecha, inscripcion.estado, inscripcion.esNuevo ? "Nuevo" : "Recurrente");
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron pre-inscripciones con los criterios especificados.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al buscar las pre-inscripciones: " + ex.Message);
            }
        }


        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvPreInscripciones.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvPreInscripciones.SelectedRows[0].Index;
                PreinscripcionSeleccionada = PreinscripcionesDisponibles[selectedIndex];
                this.Close();
                OnPreinscripcionSeleccionado?.Invoke(PreinscripcionSeleccionada);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un evento.");
            }
            panelContenido.Controls.Clear();
            panelContenido.Controls.Add(frmPantallaPrincipal.formularios[frmPantallaPrincipal.formularios.Count - 1]);
        }


        private void frmBuscarPreinscripcion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dgvPreInscripciones.SelectedRows.Count == 0)
            {
                this.DialogResult = DialogResult.Cancel;  // Si no se selecciona nada, se establece a Cancel.
            }
        }
    }
}
