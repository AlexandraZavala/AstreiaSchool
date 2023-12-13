using AstreiaSoft.AdminWS;
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
    public partial class ucEvento : UserControl
    {
        public event EventHandler EstudianteDesuscrito;

        public evento EventoData
        {
            get { return _eventoData; }
            set
            {
                _eventoData = value;
                UpdateUI();
            }
        }

        private evento _eventoData;

        private void UpdateUI()
        {
            if (_eventoData == null) return;
            IdEvento = _eventoData.idEvento;
            IdEstudiante = GlobalVariables.IdUsuario; // This seems to be static. Adjust if necessary.
            NombreEvento = _eventoData.nombre;
            DescripcionEvento = _eventoData.descripcion;
            LugarEvento = _eventoData.lugar;
            FechaInicioEvento = _eventoData.fechaInicio.ToString();
            FechaFinEvento = _eventoData.fechaFin.ToString();

            // Ocultar el botón "Cancelar Inscripción" si la fecha de inicio del evento es pasada
            
            if (_eventoData.fechaInicio < DateTime.Now)
            {
                btnCancelarInscripcion.Visible = false;
                this.Height = this.Height - 30;
            }
        }

        public ucEvento()
        {
            InitializeComponent();
            UpdateUI();
        }

        public int IdEstudiante { get; set; }
        public int IdEvento { get; set; }

        public string NombreEvento
        {
            get { return tbxNombre.Text; }
            set { tbxNombre.Text = value; }
        }

        public string DescripcionEvento
        {
            get { return rtxDescripcion.Text; }
            set { rtxDescripcion.Text = value; }
        }

        public string LugarEvento
        {
            get { return tbxLugar.Text; }
            set { tbxLugar.Text = value; }
        }

        public string FechaInicioEvento
        {
            get { return tbxFechaInicio.Text; }
            set { tbxFechaInicio.Text = value; }
        }

        public string FechaFinEvento
        {
            get { return tbxFechaFin.Text; }
            set { tbxFechaFin.Text = value; }
        }

        private void btnCancelarInscripcion_Click(object sender, EventArgs e)
        {
            try
            {
                AdminWSClient service = new AdminWSClient();
                int result = service.cancelarInscripcionEvento(IdEstudiante, IdEvento);

                if (result > 0)
                {
                    MessageBox.Show("Inscripción cancelada con éxito.");
                    EstudianteDesuscrito?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Hubo un problema al cancelar la inscripción.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cancelar la inscripción: {ex.Message}");
            }
        }
    }
}
