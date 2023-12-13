
using AstreiaSoft.UserWS;
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
    public partial class frmBusquedaDocentes : Form
    {
        private Panel panelUsuario;
        private UserWSClient _daoUserWS;
        private docente _docenteSeleccionado;

        public delegate void DocenteSeleccionadoHandler(docente docenteSeleccionado);
        public event DocenteSeleccionadoHandler OnDocenteSeleccionado;


        public docente DocenteSeleccionado { get => _docenteSeleccionado; set => _docenteSeleccionado = value; }


        public frmBusquedaDocentes(Panel panelUsuario)
        {
            _daoUserWS = new UserWSClient();
            InitializeComponent();
            dgvDocentes.AutoGenerateColumns = false;
            this.panelUsuario = panelUsuario;
        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            panelUsuario.Controls.Clear();
            panelUsuario.Controls.Add(frmGestUsuarios.formularios[frmGestUsuarios.formularios.Count - 1]);

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvDocentes.SelectedRows.Count > 0)
            {
                DocenteSeleccionado = (docente)dgvDocentes.CurrentRow.DataBoundItem;
                this.Close();
                OnDocenteSeleccionado?.Invoke(DocenteSeleccionado);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un docente.");
            }
            panelUsuario.Controls.Clear();
            panelUsuario.Controls.Add(frmGestUsuarios.formularios[frmGestUsuarios.formularios.Count - 1]);

        }

        private void btnBuscarEstudiante_Click(object sender, EventArgs e)
        {
            dgvDocentes.DataSource = _daoUserWS.listarTodosDocentesPorNombreDNI(txtBusqueda.Text).ToList();
        }

        private void dgvDocentes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            docente docente = (docente)dgvDocentes.Rows[e.RowIndex].DataBoundItem;
            dgvDocentes.Rows[e.RowIndex].Cells[0].Value = docente.idUsuario;
            dgvDocentes.Rows[e.RowIndex].Cells[1].Value = docente.DNI;
            dgvDocentes.Rows[e.RowIndex].Cells[2].Value = docente.nombre;
            dgvDocentes.Rows[e.RowIndex].Cells[3].Value = docente.fechaNacimiento;
        }
    }
}
