using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace AstreiaSoft
{

    public static class GlobalVariables
    {
        public static int IdUsuario { get; set; }
    }

    public partial class frmPantallaPrincipal : Form
    {
        public static BindingList<Form> formularios = new BindingList<Form>();
        private Button lastButtonClicked;
        public static int _idUsuario;

        

        public frmPantallaPrincipal(int idUsuario, BindingList<UserWS.rol> roles)
        {
            InitializeComponent();
            frmBienvenida formBienvenida = new frmBienvenida();
            _idUsuario = idUsuario;
            GlobalVariables.IdUsuario = idUsuario;
            // Mostrar el formulario de bienvenida en el panel principal
            mostrarFormulario(formBienvenida);
        }


        private void ChangeButtonColor(Button clickedButton)
        {
            // Cambia el color del último botón clicado de vuelta a su color original
            if (lastButtonClicked != null)
            {
                lastButtonClicked.BackColor = Color.LightBlue; // Reemplaza 'Color.Original' con el color original de tus botones
            }
            
            // Cambia el color del botón clicado
            clickedButton.BackColor = Color.SkyBlue; // Reemplaza 'Color.MasClaro' con el color más claro que quieras usar

            // Actualiza la variable del último botón clicado
            lastButtonClicked = clickedButton;
        }

        public void mostrarFormulario(Form form)
        {
            panelContenido.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            panelContenido.Controls.Add(form);
            form.Visible = true;
        }


        private void btnGestSeccion_Click(object sender, EventArgs e)
        {
            ChangeButtonColor((Button)sender);
            frmGestSecciones formGestSec = new frmGestSecciones();
            mostrarFormulario(formGestSec);
        }

        

        private void btnGestAulas_Click(object sender, EventArgs e)
        {
            ChangeButtonColor((Button)sender);
            frmGestAulas formGestAu = new frmGestAulas();
            mostrarFormulario(formGestAu);
        }


        private void btnMatricula_Click(object sender, EventArgs e)
        {
            ChangeButtonColor((Button)sender);
            frmIntencionMatricula formPreInscripcion = new frmIntencionMatricula(panelContenido);
            formularios.Add(formPreInscripcion);
            mostrarFormulario(formPreInscripcion);
        }

        private void btnHorario_Click(object sender, EventArgs e)
        {
            ChangeButtonColor((Button)sender);
            FrmHorario formHor = new FrmHorario();
            mostrarFormulario(formHor);
        }

        private void btnGestEventos_Click(object sender, EventArgs e)
        {
            ChangeButtonColor((Button)sender);
            frmGestEvento formGestEve = new frmGestEvento(panelContenido);
            formularios.Add(formGestEve);
            mostrarFormulario(formGestEve);
        }

        private void btnGestCursos_Click(object sender, EventArgs e)
        {
            ChangeButtonColor((Button)sender);
            frmGestionMalla formGestCursoProgra = new frmGestionMalla();
            mostrarFormulario(formGestCursoProgra);
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            ChangeButtonColor((Button)sender);
            frmPantallaPerfil formPantallaPerfil = new frmPantallaPerfil(panelContenido, _idUsuario);
            formularios.Add(formPantallaPerfil);
            mostrarFormulario(formPantallaPerfil);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ChangeButtonColor((Button)sender);
            frmGestUsuarios formGestUsu = new frmGestUsuarios();
            mostrarFormulario(formGestUsu);
        }

        private void btnGestHorarios_Click(object sender, EventArgs e)
        {
            ChangeButtonColor((Button)sender);
            frmGestHorario formGestHor = new frmGestHorario(panelContenido);
            formularios.Add(formGestHor);
            mostrarFormulario(formGestHor);
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            ChangeButtonColor((Button)sender);
            frmCursoAlumDoce formCursoAD = new frmCursoAlumDoce(panelContenido, _idUsuario);
            formularios.Add(formCursoAD);
            mostrarFormulario(formCursoAD);
        }

        private void btnHijos_Click(object sender, EventArgs e)
        {
            ChangeButtonColor((Button)sender);
            frmVisualizarHijos formVisHijos = new frmVisualizarHijos();
            mostrarFormulario(formVisHijos);
        }

        private void btnReclamos_Click(object sender, EventArgs e)
        {
            ChangeButtonColor((Button)sender);
            frmListarReclamos formReclamos = new frmListarReclamos(panelContenido);
            mostrarFormulario(formReclamos);
        }

        private void btnBimestre_Click(object sender, EventArgs e)
        {
            ChangeButtonColor((Button)sender);
            frmBimestre frmBimestre = new frmBimestre();
            mostrarFormulario(frmBimestre);
        }

        private void btnGestMatricula_Click(object sender, EventArgs e)
        {
            ChangeButtonColor((Button)sender);
            frmGestMatricula frmGestMatri = new frmGestMatricula(panelContenido);
            formularios.Add(frmGestMatri);
            mostrarFormulario(frmGestMatri);
        }

        private void btnGestPreInscripciones_Click(object sender, EventArgs e)
        {
            ChangeButtonColor((Button)sender);
            frmGestInscripcion frmGestInscripcion = new frmGestInscripcion(panelContenido);
            formularios.Add(frmGestInscripcion);
            mostrarFormulario(frmGestInscripcion);
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            ChangeButtonColor((Button)sender);
            frmEventosEstudiante frmEventos = new frmEventosEstudiante();
            mostrarFormulario(frmEventos);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            ChangeButtonColor((Button)sender);
            frmBienvenida frmBienve = new frmBienvenida();
            mostrarFormulario(frmBienve);
        }
        public Button BtnCursos
        {
            get => btnCursos;
            set => btnCursos = value;
        }
        public Button BtnEventos
        {
            get => btnEventos;
            set => btnEventos = value;
        }
        public Button BtnGestAulas
        {
            get => btnGestAulas;
            set => btnGestAulas = value;
        }
        public Button BtnGestCursos
        {
            get => btnGestCursos;
            set => btnGestCursos = value;
        }
        public Button BtnGestEventos
        {
            get => btnGestEventos;
            set => btnGestEventos = value;
        }
        public Button BtnGestHorarios
        {
            get => btnGestHorarios;
            set => btnGestHorarios = value;
        }
        public Button BtnGestSeccion
        {
            get => btnGestSeccion;
            set => btnGestSeccion = value;
        }
        public Button BtnHijos
        {
            get => btnHijos;
            set => btnHijos = value;
        }
        public Button BtnUsuarios
        {
            get => btnUsuarios;
            set => btnUsuarios = value;
        }
        public Button BtnHorario
        {
            get => btnHorario;
            set => btnHorario = value;
        }
        public Button BtnInicio
        {
            get => btnInicio;
            set => btnInicio = value;
        }
        public Button BtnMatricula
        {
            get => btnMatricula;
            set => btnMatricula = value;
        }
        public Button BtnPerfil
        {
            get => btnPerfil;
            set => btnPerfil = value;
        }
        public Button BtnReclamos
        {
            get => btnReclamos;
            set => btnReclamos = value;
        }

        public Button BtnGestBimestre
        {
            get => btnBimestre;
            set => btnBimestre = value;
        }

        public Button BtnGestMatricula
        {
            get => btnGestMatricula;
            set => btnGestMatricula = value;
        }


        public Button BtnGestInscripciones
        {
            get => btnGestInscripciones;
            set => btnGestInscripciones = value;
        }



    }
}
