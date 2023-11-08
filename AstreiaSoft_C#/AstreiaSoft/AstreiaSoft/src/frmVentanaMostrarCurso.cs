using LP2Soft;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using AstreiaSoft.MallaWS;

namespace AstreiaSoft
{
    public partial class frmVentanaMostrarCurso : Form
    {
        private Panel panelContenido;
        private Form formularioActual = null;
        private int _idCurso;
        private int _idCursoProg;
        public frmVentanaMostrarCurso(Panel panelContenido,  curso curso, int idCursoProg)
        {
            InitializeComponent();
            this.panelContenido = panelContenido;
            label1.Text = curso.nombre;
            _idCurso = curso.idCurso;
            _idCursoProg = idCursoProg;
        }

        private void MostrarFormulario(Form nuevoFormulario)
        {
            if (formularioActual != null)
            {
                // Ocultar el formulario actual
                formularioActual.Visible = false;
            }

            // Configurar el nuevo formulario y mostrarlo en el panel
            nuevoFormulario.FormBorderStyle = FormBorderStyle.None;
            nuevoFormulario.TopLevel = false;
            nuevoFormulario.ControlBox = false;
            pnlControl.Controls.Clear();
            pnlControl.Controls.Add(nuevoFormulario);
            nuevoFormulario.Visible = true;

            // Actualizar la variable formularioActual
            formularioActual = nuevoFormulario;
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            frmGestMateriales frmGes = new frmGestMateriales(_idCursoProg);
            MostrarFormulario(frmGes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGestionMaterial frmGes = new frmGestionMaterial(_idCursoProg);
            MostrarFormulario(frmGes);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            
            panelContenido.Controls.Add(frmPantallaPrincipal.formularios[frmPantallaPrincipal.formularios.Count - 1]);

            
            this.Close();

            
            foreach (frmUnCurso curso in panelContenido.Controls.OfType<frmUnCurso>())
            {
                curso.Show();
            }


        }

        private void btnTareas_Click(object sender, EventArgs e)
        {
            frmTareasAlumno formTareasAlumno = new frmTareasAlumno();
            MostrarFormulario(formTareasAlumno);
        }

        private void btnTareasDocente_Click(object sender, EventArgs e)
        {
            frmTareasDocente formTareasDocente = new frmTareasDocente();
            MostrarFormulario(formTareasDocente);
        }

        private void btnGestionarNotas_Click(object sender, EventArgs e)
        {
            frmUnaNota formNotasEstudiante = new frmUnaNota(pnlControl);
            MostrarFormulario(formNotasEstudiante);
        }

        private void btnTomarAsis_Click(object sender, EventArgs e)
        {
            frmGestAsistencia frmGestAsistencia = new frmGestAsistencia();
            MostrarFormulario(frmGestAsistencia);
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            frmNotasUnEstudiante formNotas = new frmNotasUnEstudiante();
            MostrarFormulario(formNotas);
        }

        private void pnlControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmVentanaMostrarCurso_Load(object sender, EventArgs e)
        {

        }
    }
}
