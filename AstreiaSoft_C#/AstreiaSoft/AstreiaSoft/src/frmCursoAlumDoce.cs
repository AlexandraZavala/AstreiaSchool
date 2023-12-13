using AstreiaSoft.InfraWS;
using AstreiaSoft.MallaWS;
using AstreiaSoft.UserWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstreiaSoft
{
    public partial class frmCursoAlumDoce : Form
    {
        private Panel panelContenido;
        private MallaWSClient _daoServicioWeb;
        private curso[] cursos;
        private BindingList<cursoProgramado> cursosProgramados;
        private int _idUsuario;
        private Byte[] arregloPDF;
        private InfraWSClient _daoInfraWS;
        private UserWSClient _daoUserWS;

        public frmCursoAlumDoce(Panel panelContenido, int idUsuario)
        {
            InitializeComponent();
            _idUsuario = idUsuario;
            this.panelContenido = panelContenido;
            pnlContenido.AutoScroll = true;
            _daoInfraWS = new InfraWSClient();
            _daoUserWS = new UserWSClient();
            _daoServicioWeb = new MallaWSClient();
            var cursosProgramadosRaw = _daoServicioWeb.listarCursosProgramadosPorUsuario(idUsuario);

            if (cursosProgramadosRaw != null)
            {
                cursosProgramados = new BindingList<cursoProgramado>(cursosProgramadosRaw.ToList());
                var anhosUnicos = cursosProgramados.Select(curso => curso.anho).Distinct().ToList();
                cboPeriodo.DataSource = anhosUnicos;
                cursos = _daoServicioWeb.listarCursosPorUsuarioYAnio(idUsuario, DateTime.Now.Year);
            }

        }
        

        private int buscarProgramaAcademico(int idCurso) 
        {
            foreach (var cursoPro in cursosProgramados) 
            {
                if(cursoPro.curso.idCurso == idCurso) 
                    return cursoPro.idCursoProgramado;
            }
            return -1;
        }

        private void frmCursoAlumDoce_Load(object sender, EventArgs e)
        {
            int cursosPorFila = 3;
            int fila = 0;
            int columna = 0;
            int idCursoProg;

            if (cursos != null)
            {
                foreach (var curso in cursos)
                {
                    idCursoProg = buscarProgramaAcademico(curso.idCurso);
                    if (idCursoProg != -1) 
                    {
                        frmUnCurso frmCurso = new frmUnCurso(pnlContenido, curso, idCursoProg, _idUsuario, panelContenido);

                        int x = columna * (frmCurso.Width + 10);
                        int y = fila * (frmCurso.Height + 10);

                        frmCurso.Location = new Point(x, y);
                        frmCurso.FormBorderStyle = FormBorderStyle.None;
                        frmCurso.TopLevel = false;
                        pnlContenido.Controls.Add(frmCurso); //se lista
                        frmCurso.Visible = true;

                        columna++;
                        if (columna >= cursosPorFila)
                        {
                            columna = 0;
                            fila++;
                        }

                    }
                }
            }
            // Inicialmente asumimos que el usuario no es un estudiante
            bool esEstudiante = false;

            // Iterar a través de los roles del usuario
            foreach (UserWS.rol rol in GlobalVariables.Roles)
            {
                if (rol.nombre.ToString() == "Estudiante")
                {
                    esEstudiante = true;
                    break; // No necesitas buscar más si ya encontraste que es estudiante
                }
            }

            // Establecer la visibilidad del botón basado en si el usuario es un estudiante
            btnReporteAnual.Visible = esEstudiante;

        }

        private void btnReporteAnual_Click(object sender, EventArgs e)
        {
            try
            {
                UserWS.usuario usuario = _daoUserWS.encontrarUsuario(GlobalVariables.IdUsuario.ToString());
                // Llamada al servicio web
                byte[] arregloPDF = _daoInfraWS.generarReporteAnualPorAlumno(GlobalVariables.IdUsuario, usuario.nombre + " "
                                                                   + usuario.apellidoPaterno + " " + usuario.apellidoMaterno);


                // Obtener la ruta de la carpeta de descargas del usuario
                string downloadFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads\";

                // Nombre del archivo
                string fileName = "ReporteAnual_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf";

                // Ruta completa del archivo
                string fullPath = Path.Combine(downloadFolder, fileName);

                // Guardar el PDF
                if (arregloPDF != null)
                {
                    File.WriteAllBytes(fullPath, arregloPDF);
                    MessageBox.Show("Reporte generado con éxito en: " + fullPath);
                }
                else
                {
                    MessageBox.Show("No se pudo generar el reporte.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
