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
    public partial class frmListarReclamos : Form
    {
        private Panel panelContenido;
        public frmListarReclamos(Panel panelContenido)
        {
            InitializeComponent();
            this.panelContenido = panelContenido;
        }

        private void frmListarReclamos_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        public void mostrarFormulario(Form form)
        {
             panelContenido.Controls.Clear();
             form.TopLevel = false;
             form.FormBorderStyle = FormBorderStyle.None;
             panelContenido.Controls.Add(form);
             form.Visible = true;
        }
        
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            frmReclamoAlumno formReclamo = new frmReclamoAlumno(panelContenido);
            mostrarFormulario(formReclamo);
        }
    }
}
