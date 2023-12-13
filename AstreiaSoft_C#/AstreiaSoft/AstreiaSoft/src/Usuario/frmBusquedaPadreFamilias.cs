
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
    public partial class frmBusquedaPadreFamilias : Form
    {
        private Panel panelUsuario;
        private UserWSClient _daoUserWS;
        private padreFamilia _padreFamiliaSeleccionado;

        public delegate void PadreFamiliaSeleccionadoHandler(padreFamilia padreFamiliaSeleccionado);
        public event PadreFamiliaSeleccionadoHandler OnPadreFamiliaSeleccionado;


        public padreFamilia PadreFamiliaSeleccionado { get => _padreFamiliaSeleccionado; set => _padreFamiliaSeleccionado = value; }

        public frmBusquedaPadreFamilias(Panel panelUsario)
        {
            _daoUserWS = new UserWSClient();
            InitializeComponent();
            dgvPadreFamilia.AutoGenerateColumns = false;
            this.panelUsuario = panelUsario;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            panelUsuario.Controls.Clear();
            panelUsuario.Controls.Add(frmGestUsuarios.formularios[frmGestUsuarios.formularios.Count - 1]);
        }


        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvPadreFamilia.SelectedRows.Count > 0)
            {
                PadreFamiliaSeleccionado = (padreFamilia)dgvPadreFamilia.CurrentRow.DataBoundItem;
                this.Close();
                OnPadreFamiliaSeleccionado?.Invoke(PadreFamiliaSeleccionado);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un padre de familia.");
            }
            panelUsuario.Controls.Clear();
            panelUsuario.Controls.Add(frmGestUsuarios.formularios[frmGestUsuarios.formularios.Count - 1]);
        }

        private void dgvPadreFamilia_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            padreFamilia padreFamilia = (padreFamilia)dgvPadreFamilia.Rows[e.RowIndex].DataBoundItem;
            dgvPadreFamilia.Rows[e.RowIndex].Cells[0].Value = padreFamilia.idUsuario;
            dgvPadreFamilia.Rows[e.RowIndex].Cells[1].Value = padreFamilia.DNI;
            dgvPadreFamilia.Rows[e.RowIndex].Cells[2].Value = padreFamilia.nombre;
            dgvPadreFamilia.Rows[e.RowIndex].Cells[3].Value = padreFamilia.fechaNacimiento;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvPadreFamilia.DataSource = _daoUserWS.listarTodosPadresFamiliaPorNombreDNI(txtBusqueda.Text).ToList();
        }
    }
}
