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
    public partial class ucEstudianteRegistrado : UserControl
    {
        public ucEstudianteRegistrado()
        {
            InitializeComponent();
        }

        public int? EstudianteSeleccionado
        {
            get
            {
                return cbxEstudiantes.SelectedValue as int?;
            }
            set
            {
                if (value.HasValue)
                    cbxEstudiantes.SelectedValue = value.Value;
                else
                    cbxEstudiantes.SelectedIndex = -1;  // Si no hay valor, deseleccionamos cualquier elemento.
            }
        }

        public List<AdminWS.usuario> ListaEstudiantes
        {
            get
            {
                return cbxEstudiantes.DataSource as List<AdminWS.usuario>;
            }
        }



        public void LimpiarComponentes()
        {
            // Establece los valores iniciales de tus controles aquí.
            cbxEstudiantes.SelectedIndex = -1;
        }

        private void ucEstudianteRegistrado_Load(object sender, EventArgs e)
        {
            // Suponemos que tienes una clase cliente de tu web service llamada InscripcionServiceClient
            AdminWSClient serviceClient = new AdminWSClient();

            try
            {
                // Llamamos al método del web service con el idPadre hardcodeado
                AdminWS.usuario[] hijosSourceSet = serviceClient.listarHijosDePadre(GlobalVariables.IdUsuario);

                // Comprobamos que no sea null y que tenga datos
                if (hijosSourceSet != null)
                {
                    List<AdminWS.usuario> hijos = hijosSourceSet.ToList();

                    // Llenamos el ComboBox con los datos
                    cbxEstudiantes.DataSource = hijos;

                    // Si deseas mostrar una propiedad específica de Usuario en el ComboBox:
                    cbxEstudiantes.DisplayMember = "nombre"; // Suponiendo que 'nombre' es una propiedad de Usuario
                    cbxEstudiantes.ValueMember = "idUsuario"; // Suponiendo que 'id_usuario' es una propiedad de Usuario
                }
                else
                {
                    // Si no hay hijos o el resultado es null, podemos mostrar un mensaje o manejarlo como prefieras.
                    MessageBox.Show("No se encontraron hijos para el padre seleccionado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al obtener los hijos: " + ex.Message);
            }
        }

    }
}
