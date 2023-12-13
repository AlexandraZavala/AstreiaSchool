using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmGestionMalla : Form
    {
        private Form formularioActual = null;
        public frmGestionMalla()
        {
            InitializeComponent();
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
            panelGestionCursos.Controls.Clear();
            panelGestionCursos.Controls.Add(nuevoFormulario);
            nuevoFormulario.Visible = true;

            // Actualizar la variable formularioActual
            formularioActual = nuevoFormulario;
        }


        private void btnCursoGe_Click(object sender, EventArgs e)
        {
            FrmGestionarCurso frmGesCur = new FrmGestionarCurso();
            MostrarFormulario(frmGesCur);
        }

        private void btnAreaCurri_Click(object sender, EventArgs e)
        {
            frmGestAreaCurricular frmGesArea = new frmGestAreaCurricular();
            MostrarFormulario(frmGesArea);
        }

        private void btnCursoProgra_Click(object sender, EventArgs e)
        {
            frmGestCursoProgra frmCursoPro = new frmGestCursoProgra();
            MostrarFormulario(frmCursoPro);
        }
    }
}
