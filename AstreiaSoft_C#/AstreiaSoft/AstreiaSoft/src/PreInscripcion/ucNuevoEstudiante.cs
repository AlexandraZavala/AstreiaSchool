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

        public estudiante RegistrarNuevoEstudiante()
        {
            AdminWSClient serviceClient = new AdminWSClient();

            if (string.IsNullOrWhiteSpace(txtDNI.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellidoPat.Text) ||
                string.IsNullOrWhiteSpace(txtApelidoMat.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                (!rbFemenino.Checked && !rbMasculino.Checked))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

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
