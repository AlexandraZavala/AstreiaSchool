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
    public partial class frmBuscarHorario : Form
    {
        private Panel panelContenido;
        public frmBuscarHorario(Panel panelContenido)
        {
            InitializeComponent();
            this.panelContenido = panelContenido;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            
               panelContenido.Controls.Clear();

               panelContenido.Controls.Add(frmPantallaPrincipal.formularios[frmPantallaPrincipal.formularios.Count - 1]);
            
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();

            panelContenido.Controls.Add(frmPantallaPrincipal.formularios[frmPantallaPrincipal.formularios.Count - 1]);

        }
    }
}
