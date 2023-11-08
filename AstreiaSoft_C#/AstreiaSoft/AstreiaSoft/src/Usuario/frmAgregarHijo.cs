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
    public partial class frmAgregarHijo : Form
    {
        private Panel panelUsuario;

        public frmAgregarHijo(Panel panelUsuario)
        {
            InitializeComponent();
            dgvEstudiantes.AutoGenerateColumns = false;
            this.panelUsuario = panelUsuario;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            panelUsuario.Controls.Clear();
            panelUsuario.Controls.Add(frmGestUsuarios.formularios[frmGestUsuarios.formularios.Count - 1]);

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            panelUsuario.Controls.Clear();
            panelUsuario.Controls.Add(frmGestUsuarios.formularios[frmGestUsuarios.formularios.Count - 1]);

        }
    }
}
