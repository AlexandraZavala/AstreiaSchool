
using AstreiaSoft.UserWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstreiaSoft
{
    public partial class frmBusquedaAdminsAcads : Form
    {

        private Panel panelUsuario;
        private UserWSClient _daoUserWS;
        private administradorAcademico _administradorSeleccionado;

        public delegate void AdministradorSeleccionadoHandler(administradorAcademico administradorSeleccionado);
        public event AdministradorSeleccionadoHandler OnAdministradorSeleccionado;


        public administradorAcademico AdministradorSeleccionado { get => _administradorSeleccionado; set => _administradorSeleccionado = value; }

        public frmBusquedaAdminsAcads(Panel panelUsuario)
        {
            _daoUserWS = new UserWSClient();
            InitializeComponent();
            dgvAdmins.AutoGenerateColumns = false;
            this.panelUsuario = panelUsuario;
        }

        private void btnBuscarAdmin_Click(object sender, EventArgs e)
        {
            dgvAdmins.DataSource = _daoUserWS.listarTodosAdministradoresAcademicosPorNombreDNI(txtBusqueda.Text).ToList();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvAdmins.SelectedRows.Count > 0)
            {
                AdministradorSeleccionado = (administradorAcademico)dgvAdmins.CurrentRow.DataBoundItem;
                this.Close();
                OnAdministradorSeleccionado?.Invoke(AdministradorSeleccionado);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un administrador.");
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

        private void dgvAdmins_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            administradorAcademico administrador = (administradorAcademico)dgvAdmins.Rows[e.RowIndex].DataBoundItem;
            dgvAdmins.Rows[e.RowIndex].Cells[0].Value = administrador.idUsuario;
            dgvAdmins.Rows[e.RowIndex].Cells[1].Value = administrador.DNI;
            dgvAdmins.Rows[e.RowIndex].Cells[2].Value = administrador.nombre;
            dgvAdmins.Rows[e.RowIndex].Cells[3].Value = administrador.fechaNacimiento;
        }
    }
}
