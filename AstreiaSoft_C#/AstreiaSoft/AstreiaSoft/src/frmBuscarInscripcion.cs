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
    public partial class frmBuscarInscripcion : Form
    {
        public Inscripcion InscripcionSeleccionada;
        private BindingList<Inscripcion> inscripciones; // Lista para almacenar las inscripciones ficticias

        public frmBuscarInscripcion()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Instanciamos algunas inscripciones ficticias
            inscripciones = new BindingList<Inscripcion>
            {
                new Inscripcion { Fecha = DateTime.Now, Activo = 1, MatriculaReferencia = "M001", EstudianteReferencia = "E001" },
                new Inscripcion { Fecha = DateTime.Now.AddDays(-15), Activo = 0, MatriculaReferencia = "M002", EstudianteReferencia = "E002" },
                // Puedes agregar más inscripciones ficticias aquí
            };

            dgvInscripciones.Rows.Clear();
            foreach (Inscripcion inscripcion in inscripciones)
            {
                dgvInscripciones.Rows.Add(inscripcion.Fecha, inscripcion.Activo, inscripcion.MatriculaReferencia, inscripcion.EstudianteReferencia);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvInscripciones.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvInscripciones.SelectedRows[0].Index;
                InscripcionSeleccionada = inscripciones[selectedIndex];
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una inscripción.");
            }
        }

        private void frmBuscarInscripcion_Load(object sender, EventArgs e)
        {
            // Puedes poner aquí cualquier inicialización necesaria cuando el formulario se carga
        }

        private void btnBuscarEstudiantes_Click(object sender, EventArgs e)
        {
            frmBuscarEstudiante formBuscarEstudiante = new frmBuscarEstudiante();
            if (formBuscarEstudiante.ShowDialog() == DialogResult.OK)
            {
                // Aquí puedes agregar acciones adicionales que quieras realizar después de seleccionar un estudiante
            }
        }
    }

    public class Inscripcion // Clase ficticia para Inscripcion
    {
        public DateTime Fecha { get; set; }
        public int Activo { get; set; }
        public string MatriculaReferencia { get; set; }
        public string EstudianteReferencia { get; set; }
    }
}
