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
    public partial class frmGestUsuarios : Form
    {
        public static BindingList<Form> formularios = new BindingList<Form>();
        public frmGestUsuarios()
        {
            InitializeComponent();
        }
        
        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            frmGestEstudiantes formGestEst = new frmGestEstudiantes(panelUsuario);
            formularios.Add(formGestEst);
            mostrarFormulario(formGestEst);
        }

      

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmGestAdminAcad formGestAdmin = new frmGestAdminAcad(panelUsuario);
            formularios.Add(formGestAdmin);
            mostrarFormulario(formGestAdmin);
        }

        private void btnDocente_Click(object sender, EventArgs e)
        {
            frmGestDocente formGestDoc = new frmGestDocente(panelUsuario);
            formularios.Add(formGestDoc);
            mostrarFormulario(formGestDoc);
        }

        private void btnPadreFamilia_Click(object sender, EventArgs e)
        {
            frmGestPadreFamilia formGestPadre = new frmGestPadreFamilia(panelUsuario);
            formularios.Add(formGestPadre);
            mostrarFormulario(formGestPadre);
        }
        public void mostrarFormulario(Form form)
        {
            panelUsuario.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            panelUsuario.Controls.Add(form);
            form.Visible = true;
        }
    }
}
