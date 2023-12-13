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
using AstreiaSoft.src;
using AstreiaSoft.AdminWS;
using AstreiaSoft.UserWS;
using AstreiaSoft.src.Docente;

namespace AstreiaSoft
{
    public partial class frmVentanaMostrarCurso : Form
    {
        private Panel pnlContenido;
        private Panel _panelContenido;
        private Form formularioActual = null;
        private int _idCurso;
        private int _idCursoProg;
        private MallaWS.curso curso;
        private int idCursoProg;
        private int _idUsuario;
        private string _nombreCurso;
        private MallaWSClient daoServicioWeb;
        private UserWSClient daoUserWS;
        BindingList<MallaWS.horario> horarios;


        public frmVentanaMostrarCurso(Panel pnlContenido, MallaWS.curso curso, int idCursoProg, int idUsuario, Panel panelContenido)
        {

            
            this.curso = curso;
            this.idCursoProg = idCursoProg;
            InitializeComponent();
            this.pnlContenido = pnlContenido;
            this.PerformLayout(); // Refrescar el diseño
            _panelContenido = panelContenido;
            frmPantallaPrincipal.formularios.Add(this);
            _nombreCurso = curso.nombre;
            label1.Text = _nombreCurso;
            _idCurso = curso.idCurso;
            _idCursoProg = idCursoProg;
            _idUsuario = idUsuario;
            daoServicioWeb = new MallaWSClient();
            daoUserWS = new UserWSClient();
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
        public void mostrarFormulario2(Form form)
        {
            pnlContenido.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            pnlContenido.Controls.Add(form);
            form.Visible = true;
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


            // Instanciamos el formulario de la lista de cursos del docente
            frmCursoAlumDoce formListaCursos = new frmCursoAlumDoce(_panelContenido, _idUsuario);
            _panelContenido.Controls.Clear();
            formListaCursos.TopLevel = false;
            formListaCursos.FormBorderStyle = FormBorderStyle.None;
            _panelContenido.Controls.Add(formListaCursos);
            formListaCursos.Visible = true;
            this.Close();

        }

        private void btnTareas_Click(object sender, EventArgs e)
        {
            frmGestEntregasAlumno formTareasAlumno = new frmGestEntregasAlumno(pnlControl, idCursoProg);
            MostrarFormulario(formTareasAlumno);
        }

        private void btnTareasDocente_Click(object sender, EventArgs e)
        {
            frmGestTareasDocente formTareasDocente = new frmGestTareasDocente(pnlControl, idCursoProg, this); // this es frmVentanaMostrarCurso
            MostrarFormulario(formTareasDocente);
        }

        private void btnGestionarNotas_Click(object sender, EventArgs e)
        {
            frmBuscarEntregas formNotasEstudiante = new frmBuscarEntregas(pnlControl, idCursoProg);
            MostrarFormulario(formNotasEstudiante);
        }

        private void btnTomarAsis_Click(object sender, EventArgs e)
        {
            frmGestAsistencia frmGestAsistencia = new frmGestAsistencia(idCursoProg);
            MostrarFormulario(frmGestAsistencia);
        }


        //NUEVO

        private int buscarHorario(int idCursoProg) 
        {
            foreach (var horario in horarios) 
            {
                if (horario.cursoProgramado.idCursoProgramado == idCursoProg) return horario.idHorario;
            }
            return -1;
        }


        private void btnReporte_Click(object sender, EventArgs e)
        {
            var listaHorarios = daoServicioWeb.listarHorarioPorIdDocente(_idUsuario);

            if (listaHorarios != null)
            {
                horarios = new BindingList<MallaWS.horario>(listaHorarios.ToList());
                int idHorario = buscarHorario(_idCursoProg);
                string _nombreDocente = daoUserWS.obtenerNombreDocente(_idUsuario);
                frmReporteNotas frmRepNotas = new frmReporteNotas(idHorario, _nombreCurso, _nombreDocente);
                MostrarFormulario(frmRepNotas);
            }
            
        }


        public Button BtnMaterial
        {
            get => btnMaterial;
            set => btnMaterial = value;
        }
        public Button BtnGestionarMateriales
        {
            get => btnGestionarMateriales;
            set => btnGestionarMateriales = value;
        }
        
        public Button BtnGestionarNotas
        {
            get => btnGestionarNotas;
            set => btnGestionarNotas = value;
        }
        public Button BtnTareasAlumno
        {
            get => btnTareasAlumno;
            set => btnTareasAlumno = value;
        }
        public Button BtnTareasDocente
        {
            get => btnTareasDocente;
            set => btnTareasDocente = value;
        }
        public Button BtnTomarAsis
        {
            get => btnTomarAsis;
            set => btnTomarAsis = value;
        }
        public Button BtnReporte
        {
            get => btnReporte;
            set => btnReporte = value;
        }

        private void btnVerNotas_Click(object sender, EventArgs e)
        {
            frmNotasUnEstudiante formNotas = new frmNotasUnEstudiante();
            MostrarFormulario(formNotas);

        }

        public Button BtnVerNotas
        {
            get => btnVerNotas;
            set => btnVerNotas = value;
        }
    }
}
