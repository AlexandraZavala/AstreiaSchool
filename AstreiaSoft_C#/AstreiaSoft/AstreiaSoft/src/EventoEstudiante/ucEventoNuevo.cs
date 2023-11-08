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
    public partial class ucEventoNuevo : UserControl
    {
        public event EventHandler EstudianteInscrito;
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
        }


        public ucEventoNuevo()
        {
            InitializeComponent();
            UpdateUI();
        }

        private void btnInscribirme_Click(object sender, EventArgs e)
        {
            //evento ev = EventoInscrito;

            AdminWSClient client = new AdminWSClient();

            // Confirmar inscripción
            DialogResult result = MessageBox.Show("¿Deseas inscribirte a este evento?", "Confirmar inscripción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Llamar al web method para inscribir al estudiante en el evento
                int inscripcionExitosa = client.inscribirEstudianteEnEvento(IdEstudiante, IdEvento);

                if (inscripcionExitosa > 0) // Suponiendo que un valor positivo indica éxito
                {
                    // Mostrar mensaje de confirmación
                    MessageBox.Show("Te has inscrito exitosamente al evento.", "Inscripción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cambiar estado del botón
                    btnInscribirme.Enabled = false;    // Deshabilitar botón
                    btnInscribirme.Text = "Inscrito";  // Cambiar texto

                    // Luego de inscribirse, disparamos el evento
                    EstudianteInscrito?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Hubo un error al intentar inscribirte. Por favor, intenta de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                client.Close();
            }
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
    }
}
