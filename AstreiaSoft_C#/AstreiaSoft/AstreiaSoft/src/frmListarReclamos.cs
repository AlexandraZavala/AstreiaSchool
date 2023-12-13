using AstreiaSoft.EvalWS;
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
        private EvalWSClient _daoEvalWS;
        private reclamoCalificacion _reclamoSeleccionado;

        public delegate void ReclamoSeleccionadooHandler(reclamoCalificacion reclamoSeleccionado);
        public event ReclamoSeleccionadooHandler OnReclamoSeleccionado;


        public reclamoCalificacion ReclamoSeleccionado { get => _reclamoSeleccionado; set => _reclamoSeleccionado = value; }


        public frmListarReclamos(Panel panelContenido)
        {
            InitializeComponent();
            //this.panelContenido = panelContenido;
            dgvListReclamos.AutoGenerateColumns = false;
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
            if (dgvListReclamos.SelectedRows.Count > 0)
            {
                ReclamoSeleccionado = (reclamoCalificacion)dgvListReclamos.CurrentRow.DataBoundItem;
                this.Close();
                OnReclamoSeleccionado?.Invoke(ReclamoSeleccionado);
                frmReclamoAlumno formReclamo = new frmReclamoAlumno(1);
                mostrarFormulario(formReclamo);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un reclamo.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvListReclamos.DataSource = _daoEvalWS.listarReclamoCalificaciones();
            //var reclamosCalificaciones = _daoEvalWS.listarReclamoCalificaciones();

            // Verificar si la lista no es nula antes de asignarla al DataSource
            //if (reclamosCalificaciones != null)
            //{
            //    dgvListReclamos.DataSource = reclamosCalificaciones;
            //}
        }

        private void dgvListReclamos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            reclamoCalificacion reclamo = (reclamoCalificacion)dgvListReclamos.Rows[e.RowIndex].DataBoundItem;
            dgvListReclamos.Rows[e.RowIndex].Cells[0].Value = reclamo.idReclamoCalificacion;
            dgvListReclamos.Rows[e.RowIndex].Cells[1].Value = reclamo.estado;
            dgvListReclamos.Rows[e.RowIndex].Cells[2].Value = reclamo.fechaReclamo;
            dgvListReclamos.Rows[e.RowIndex].Cells[3].Value = reclamo.fechaRespuesta;
        }
    }
}
