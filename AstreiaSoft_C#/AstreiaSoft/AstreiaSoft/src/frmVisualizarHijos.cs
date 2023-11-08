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

namespace AstreiaSoft
{

    
    public partial class frmVisualizarHijos : Form
    {
        public frmVisualizarHijos()
        {
            InitializeComponent();
        }


        public void mostrarFormulario(Form form)
        {
            panelContenido.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            panelContenido.Controls.Add(form);
            form.Visible = true;
        }

        private void btnHorario_Click(object sender, EventArgs e)
        {
            FrmHorario formHor = new FrmHorario();
            mostrarFormulario(formHor);
        }

        private void btnCalificaciones_Click(object sender, EventArgs e)
        {
            frmTareasAlumno formTareas = new frmTareasAlumno();
            mostrarFormulario(formTareas);
        }
    }
}
