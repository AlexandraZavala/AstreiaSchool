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
    public partial class frmBuscarAsistencia : Form
    {
        //public Asistencia AsistenciaSeleccionada;
        //private BindingList<Asistencia> asistencias; // Lista para almacenar las asistencias ficticias

        public frmBuscarAsistencia()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //// Instanciamos algunas asistencias ficticias
            //asistencias = new BindingList<Asistencia>
            //{
            //    new Asistencia { Fecha = DateTime.Now, Estado = "Presente", EventoReferencia = "E001", EstudianteReferencia = "Est001" },
            //    new Asistencia { Fecha = DateTime.Now.AddDays(-1), Estado = "Ausente", EventoReferencia = "E002", EstudianteReferencia = "Est002" },
            //    // Puedes agregar más asistencias ficticias aquí
            //};

            //dgvAsistencias.Rows.Clear();
            //foreach (Asistencia asistencia in asistencias)
            //{
            //    dgvAsistencias.Rows.Add(asistencia.Fecha, asistencia.Estado, asistencia.EventoReferencia, asistencia.EstudianteReferencia);
            //}
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            //if (dgvAsistencias.SelectedRows.Count > 0)
            //{
            //    int selectedIndex = dgvAsistencias.SelectedRows[0].Index;
            //    AsistenciaSeleccionada = asistencias[selectedIndex];
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Por favor, selecciona una asistencia.");
            //}
        }

        private void frmBuscarAsistencia_Load(object sender, EventArgs e)
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
}
