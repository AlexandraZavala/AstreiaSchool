using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AstreiaSoft.MallaWS;

namespace AstreiaSoft
{
    public partial class frmUnCurso : Form
    {
        private Panel panelContenido;
        private curso curso_;
        private int _idCursoProg;
        public frmUnCurso(Panel panelContenido, curso _curso, int idCursoProg)
        {
            InitializeComponent();
            this.panelContenido = panelContenido;
            lblNombre.Text = _curso.nombre;
            lblArea.Text = _curso.areaCurricular.nombre;
            curso_ = _curso;
            _idCursoProg = idCursoProg;
        }

        private void btnSeleCurso_Click(object sender, EventArgs e)
        {
            frmVentanaMostrarCurso formCursoAD = new frmVentanaMostrarCurso(panelContenido, curso_, _idCursoProg);

            foreach (frmUnCurso curso in panelContenido.Controls.OfType<frmUnCurso>())
            {
                curso.Hide();
            }
            panelContenido.Controls.Clear();
            formCursoAD.TopLevel = false;
            formCursoAD.FormBorderStyle = FormBorderStyle.None;
            panelContenido.Controls.Add(formCursoAD);
            formCursoAD.Visible = true;


            frmPantallaPrincipal.formularios.Add(this);

        }
    }
}
