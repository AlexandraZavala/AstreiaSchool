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
    public partial class frmReclamoAlumno : Form
    {
        private Panel panelContenido;
        public frmReclamoAlumno(Panel panelContenido)
        {
            InitializeComponent();
            this.panelContenido = panelContenido;
        }

        private void btnEnviarReclamo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El reclamo fue enviado exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardarRespuesta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La respuesta al reclamo ha sido registrada exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
