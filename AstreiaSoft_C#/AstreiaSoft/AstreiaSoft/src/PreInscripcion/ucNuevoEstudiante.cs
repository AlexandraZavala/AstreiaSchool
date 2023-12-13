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
    public partial class ucNuevoEstudiante : UserControl
    {
        public string DNI
        {
            get { return txtDNI.Text; }
            set { txtDNI.Text = value; }
        }

        public string Nombre
        {
            get { return txtNombre.Text; }
            set { txtNombre.Text = value; }
        }

        public string ApellidoPaterno
        {
            get { return txtApellidoPat.Text; }
            set { txtApellidoPat.Text = value; }
        }

        public string ApellidoMaterno
        {
            get { return txtApelidoMat.Text; }
            set { txtApelidoMat.Text = value; }
        }

        public string Telefono
        {
            get { return txtTelefono.Text; }
            set { txtTelefono.Text = value; }
        }

        public string Direccion
        {
            get { return txtDireccion.Text; }
            set { txtDireccion.Text = value; }
        }

        public bool GeneroMasculino
        {
            get { return rbMasculino.Checked; }
            set { rbMasculino.Checked = value; }
        }

        public bool GeneroFemenino
        {
            get { return rbFemenino.Checked; }
            set { rbFemenino.Checked = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return dtpFechaNacimiento.Value; }
            set { dtpFechaNacimiento.Value = value; }
        }

        private bool ValidarRegistro()
        {
            // Validación DNI
            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("El campo DNI es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtDNI.Text.Length != 8)
            {
                MessageBox.Show("El DNI debe tener exactamente 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validación Nombre
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validación Apellido Paterno
            if (string.IsNullOrWhiteSpace(txtApellidoPat.Text))
            {
                MessageBox.Show("El campo Apellido Paterno es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validación Apellido Materno
            if (string.IsNullOrWhiteSpace(txtApelidoMat.Text))
            {
                MessageBox.Show("El campo Apellido Materno es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validación Teléfono
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("El campo Teléfono es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtTelefono.Text.Length != 9)
            {
                MessageBox.Show("El Teléfono debe tener exactamente 9 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validación Dirección
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("El campo Dirección es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validación Género
            if (!rbFemenino.Checked && !rbMasculino.Checked)
            {
                MessageBox.Show("Debe seleccionar un género.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int edad = DateTime.Today.Year - dtpFechaNacimiento.Value.Year;
            if (dtpFechaNacimiento.Value > DateTime.Today.AddYears(-edad)) edad--;
            if (edad > 17)
            {
                MessageBox.Show("El estudiante debe ser menor de 18 años.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtDNI.Text.Any(c => !char.IsDigit(c)))
            {
                MessageBox.Show("El DNI debe contener solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtTelefono.Text.Any(c => !char.IsDigit(c)))
            {
                MessageBox.Show("El Teléfono debe contener solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public estudiante RegistrarNuevoEstudiante()
        {
            AdminWSClient serviceClient = new AdminWSClient();

            if (!ValidarRegistro()) return null;

            estudiante nuevoEstudiante = new estudiante()
            {
                DNI = txtDNI.Text,
                nombre = txtNombre.Text,
                apellidoPaterno = txtApellidoPat.Text,
                apellidoMaterno = txtApelidoMat.Text,
                telefono = txtTelefono.Text,
                direccion = txtDireccion.Text,
                fechaNacimiento = dtpFechaNacimiento.Value,
                genero = rbFemenino.Checked ? "Femenino" : "Masculino",
                activo = false
            };

            nuevoEstudiante.fechaNacimientoSpecified = true;

            int idNuevoEstudiante = serviceClient.insertarEstudiante(nuevoEstudiante);
            if (idNuevoEstudiante <= 0)
            {
                MessageBox.Show("Hubo un error al registrar el nuevo estudiante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            nuevoEstudiante.idUsuario = idNuevoEstudiante;

            return nuevoEstudiante;
        }

        public ucNuevoEstudiante()
        {
            InitializeComponent();
        }


        public void LimpiarComponentes()
        {
            // Establece los valores iniciales de tus controles aquí.
            txtApelidoMat.Text = "";
            txtApellidoPat.Text = "";
            txtDireccion.Text = "";
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
        }

    }
}
