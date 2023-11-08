
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
    public partial class frmBusquedaEstudiantes : Form
    {
        private Panel panelUsuario;
        private UserWSClient _daoUserWS;
        private estudiante _estudianteSeleccionado;
        private estudiante EstudianteSeleccionado;

        public delegate void EstudianteSeleccionadoHandler(estudiante estudianteSeleccionado);
        public event EstudianteSeleccionadoHandler OnEstudianteSeleccionado;


        //public administradorAcademico AdministradorSeleccionado { get => _administradorSeleccionado; set => _administradorSeleccionado = value; }
        public frmBusquedaEstudiantes(Panel panelUsuario)
        {
            _daoUserWS = new UserWSClient();
            InitializeComponent();
            dgvEstudiantes.AutoGenerateColumns = false;
            this.panelUsuario = panelUsuario;
        }

        private void btnBuscarEstudiante_Click(object sender, EventArgs e)
        {
            dgvEstudiantes.DataSource = _daoUserWS.listarTodosEstudiantesPorNombreDNI(txtBusquedaEstudiante.Text).ToList();
        }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvEstudiantes.SelectedRows.Count > 0)
            {
                EstudianteSeleccionado = (estudiante)dgvEstudiantes.CurrentRow.DataBoundItem;
                this.Close();
                OnEstudianteSeleccionado?.Invoke(EstudianteSeleccionado);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un estudiante.");
            }
            panelUsuario.Controls.Clear();
            panelUsuario.Controls.Add(frmGestUsuarios.formularios[frmGestUsuarios.formularios.Count - 1]);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            panelUsuario.Controls.Clear();
            panelUsuario.Controls.Add(frmGestUsuarios.formularios[frmGestUsuarios.formularios.Count - 1]);

        }

        private void dgvEstudiantes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            estudiante estudiante = (estudiante)dgvEstudiantes.Rows[e.RowIndex].DataBoundItem;
            dgvEstudiantes.Rows[e.RowIndex].Cells[0].Value = estudiante.idUsuario;
            dgvEstudiantes.Rows[e.RowIndex].Cells[1].Value = estudiante.DNI;
            dgvEstudiantes.Rows[e.RowIndex].Cells[2].Value = estudiante.nombre;
            dgvEstudiantes.Rows[e.RowIndex].Cells[3].Value = estudiante.fechaNacimiento;
        }
    }
}
