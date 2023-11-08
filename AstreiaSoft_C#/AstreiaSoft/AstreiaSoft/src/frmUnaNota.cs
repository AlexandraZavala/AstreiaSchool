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
    public partial class frmUnaNota : Form
    {
        private Panel pnlControl;
        public frmUnaNota(Panel pnlControl)
        {
            InitializeComponent();
            this.pnlControl = pnlControl;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void mostrarFormulario(Form form)
        {
            pnlControl.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            pnlControl.Controls.Add(form);
            form.Visible = true;
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            frm_DetalleEvaluacion formDetalleEvaluacion = new frm_DetalleEvaluacion(pnlControl);
            mostrarFormulario(formDetalleEvaluacion);
        }
    }
}
