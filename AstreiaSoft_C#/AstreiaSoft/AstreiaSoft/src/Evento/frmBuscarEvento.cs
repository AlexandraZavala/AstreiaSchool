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

namespace AstreiaSoft
{
    public partial class frmBuscarEvento : Form
    {
        private evento[] EventosDisponibles;
        public evento EventoSeleccionado;
        private Panel panelContenido;

        public delegate void EventoSeleccionadoHandler(evento eventoSeleccionado);
        public event EventoSeleccionadoHandler OnEventoSeleccionado;

        public frmBuscarEvento(Panel panelContenido)
        {
            InitializeComponent();
            this.panelContenido = panelContenido;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                AdminWSClient client = new AdminWSClient();
                string nombreFiltro = cbxFiltroNombre.Checked ? txtNombreEvento.Text : null;

                if (cbxFiltroFechaInicio.Checked)
                {
                    EventosDisponibles = client.listarEventosPorNombreYFecha(nombreFiltro, dtpFechaEvento.Value);
                }
                else
                {
                    EventosDisponibles = client.listarEventosPorNombre(nombreFiltro);
                }

                dgvEventos.Rows.Clear();

                if (EventosDisponibles != null)
                {
                    foreach (evento evento in EventosDisponibles)
                    {
                        dgvEventos.Rows.Add(evento.idEvento, evento.nombre, evento.descripcion, evento.lugar, evento.fechaInicio, evento.fechaFin);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron eventos disponibles con los criterios especificados.");
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al buscar los eventos: " + ex.Message);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvEventos.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvEventos.SelectedRows[0].Index;
                EventoSeleccionado = EventosDisponibles[selectedIndex];
                this.Close();
                OnEventoSeleccionado?.Invoke(EventoSeleccionado);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un evento.");
            }
            panelContenido.Controls.Clear();
            panelContenido.Controls.Add(frmPantallaPrincipal.formularios[frmPantallaPrincipal.formularios.Count - 1]);
        }


        private void cbxFiltroNombre_CheckedChanged(object sender, EventArgs e)
        {
            txtNombreEvento.Enabled = cbxFiltroNombre.Checked;
        }

        private void cbxFiltroFechaInicio_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaEvento.Enabled = cbxFiltroFechaInicio.Checked;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            panelContenido.Controls.Clear();
            panelContenido.Controls.Add(frmPantallaPrincipal.formularios[frmPantallaPrincipal.formularios.Count - 1]);
        }
    }
}
