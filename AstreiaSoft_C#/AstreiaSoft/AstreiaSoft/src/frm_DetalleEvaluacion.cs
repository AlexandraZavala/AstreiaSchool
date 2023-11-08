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
    public partial class frm_DetalleEvaluacion : Form
    {
        private Panel pnlControl;
        public frm_DetalleEvaluacion(Panel pnlControl)
        {
            InitializeComponent();
            this.pnlControl = pnlControl;
        }

        private void btnCalificarEvaluacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La evaluación ha sido calificadas exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
