using AstreiaSoft.AdminWS;
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
using System.Linq;

namespace AstreiaSoft
{
    public partial class frmBuscarMatriculas : Form
    {
        private matricula[] MatriculasDisponibles;
        public matricula MatriculaSeleccionada;
        private Panel panelContenido;

        public delegate void MatriculaSeleccionadaHandler(matricula matriculaSeleccionada);
        public event MatriculaSeleccionadaHandler OnMatriculaSeleccionada;

        public frmBuscarMatriculas(Panel panelContenido)
        {
            InitializeComponent();
            this.panelContenido = panelContenido;
            cboAnho.Enabled = false;
            LlenarCboAnho();
        }

        private void LlenarCboAnho()
        {
            try
            {
                AdminWSClient client = new AdminWSClient();
                int[] anhosResultSet = client.listarAnhosMatriculacion();
                if (anhosResultSet != null)
                {
                    List<int> anhos = anhosResultSet.ToList();
                    foreach (int anho in anhos)
                    {
                        cboAnho.Items.Add(anho);
                    }
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los años: " + ex.Message);
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                AdminWSClient client = new AdminWSClient();

                if (cbxFiltroAnho.Checked)
                {
                    MatriculasDisponibles = client.listarMatriculasPorAnho(int.Parse(cboAnho.Text));
                }
                else MatriculasDisponibles = client.listarTodasMatriculas();

                dgvMatriculas.Rows.Clear();

                if (MatriculasDisponibles != null)
                {
                    foreach (matricula matricula in MatriculasDisponibles)
                    {
                        dgvMatriculas.Rows.Add(matricula.idMatricula, matricula.estado, matricula.fechaInicio, matricula.fechaFin, matricula.monto);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron matrículas disponibles con los criterios especificados.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al buscar las matrículas: " + ex.Message);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvMatriculas.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvMatriculas.SelectedRows[0].Index;
                MatriculaSeleccionada = MatriculasDisponibles[selectedIndex];
                this.Close();
                OnMatriculaSeleccionada?.Invoke(MatriculaSeleccionada);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una matrícula.");
            }
            panelContenido.Controls.Clear();
            panelContenido.Controls.Add(frmPantallaPrincipal.formularios[frmPantallaPrincipal.formularios.Count - 1]);
        }

        private void cbxFiltroAnho_CheckedChanged(object sender, EventArgs e)
        {
            cboAnho.Enabled = cbxFiltroAnho.Checked;
        }

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            this.Close();
            panelContenido.Controls.Clear();
            panelContenido.Controls.Add(frmPantallaPrincipal.formularios[frmPantallaPrincipal.formularios.Count - 1]);
        }
    }
}
