using AstreiaSoft.MallaWS;
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
    public partial class frmCursoAlumDoce : Form
    {
        private Panel panelContenido;
        private MallaWSClient _daoServicioWeb;
        private curso[] cursos;
        private BindingList<cursoProgramado> cursosProgramados;
        public frmCursoAlumDoce(Panel panelContenido, int idUsuario)
        {
            InitializeComponent();
            this.panelContenido = panelContenido;
            pnlContenido.AutoScroll = true;
            _daoServicioWeb = new MallaWSClient();
            cursosProgramados = new BindingList<cursoProgramado>(_daoServicioWeb.listarCursosProgramadosPorUsuario(idUsuario).ToList());
            var anhosUnicos = cursosProgramados.Select(curso => curso.anho).Distinct().ToList();
            cboPeriodo.DataSource = anhosUnicos;

            /*cboPeriodo.DataSource = _daoServicioWeb.listarCursosProgramadosPorUsuario(idUsuario);
            cboPeriodo.DisplayMember = "anho";
            cboPeriodo.ValueMember = "idCursoProgramado";*/
            cursos = _daoServicioWeb.listarCursosPorUsuarioYAnio(idUsuario, DateTime.Now.Year);
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
                        frmUnCurso frmCurso = new frmUnCurso(pnlContenido, curso, idCursoProg);

                        int x = columna * (frmCurso.Width + 10);
                        int y = fila * (frmCurso.Height + 10);

                        frmCurso.Location = new Point(x, y);

                        frmCurso.FormBorderStyle = FormBorderStyle.None;
                        frmCurso.TopLevel = false;
                        pnlContenido.Controls.Add(frmCurso);
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

        }
    }
}
