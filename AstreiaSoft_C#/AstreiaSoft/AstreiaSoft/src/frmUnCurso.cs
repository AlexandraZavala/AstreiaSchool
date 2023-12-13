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
        private Panel pnlContenido;
        private Panel _panelContenido;
        private curso curso_;
        private int _idCursoProg;
        private int _idUsuario;
        public frmUnCurso(Panel pnlContenido, curso _curso, int idCursoProg, int idUsuario, Panel panelContenido)
        {
            InitializeComponent();
            this.pnlContenido = pnlContenido;
            _panelContenido = panelContenido;
            lblNombre.Text = _curso.nombre;
            lblArea.Text = _curso.areaCurricular.nombre;
            curso_ = _curso;
            _idCursoProg = idCursoProg;
            _idUsuario = idUsuario;
        }

        private void btnSeleCurso_Click(object sender, EventArgs e)
        {

            


            frmVentanaMostrarCurso formCursoAD = new frmVentanaMostrarCurso(pnlContenido, curso_, _idCursoProg, _idUsuario, _panelContenido);
            
            foreach (frmUnCurso curso in pnlContenido.Controls.OfType<frmUnCurso>())
            {
                curso.Hide();
            }
            pnlContenido.Controls.Clear();
            formCursoAD.TopLevel = false;
            formCursoAD.FormBorderStyle = FormBorderStyle.None;
            pnlContenido.Controls.Add(formCursoAD);
            formCursoAD.Visible = true;


            formCursoAD.BtnGestionarMateriales.Visible = false;
            formCursoAD.BtnGestionarNotas.Visible = false;
            formCursoAD.BtnTareasDocente.Visible = false;
            formCursoAD.BtnTomarAsis.Visible = false;
            formCursoAD.BtnReporte.Visible = false;
            formCursoAD.BtnMaterial.Visible = false;
            formCursoAD.BtnTareasAlumno.Visible = false;
            formCursoAD.BtnVerNotas.Visible = false;

            foreach (UserWS.rol rol in GlobalVariables.Roles)
            {
                if (rol.nombre.ToString() == "Docente")
                {
                    formCursoAD.BtnGestionarMateriales.Visible = true;
                    formCursoAD.BtnGestionarNotas.Visible = true;
                    formCursoAD.BtnTareasDocente.Visible = true;
                    formCursoAD.BtnTomarAsis.Visible = true;
                    formCursoAD.BtnReporte.Visible = true;
                    break; // No necesitas buscar más si ya encontraste que es estudiante
                }
                else
                {
                    formCursoAD.BtnMaterial.Visible = true;
                    formCursoAD.BtnTareasAlumno.Visible = true;
                    formCursoAD.BtnVerNotas.Visible = true;
                }
            }
            
            frmPantallaPrincipal.formularios.Add(this);

        }
    }
}
