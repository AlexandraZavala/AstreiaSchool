using AstreiaSoft.AdminWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstreiaSoft
{
    public partial class frmGestInscripcion : Form
    {
        private Estado _estado;
        private Panel panelContenido;
        private AdminWSClient client = new AdminWSClient();

        public frmGestInscripcion(Panel panelContenido)
        {
            InitializeComponent();
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
            this.panelContenido = panelContenido;
            LlenarGrados();
            listaGrados.SelectedIndex = -1;
        }

        private void LlenarGrados()
        {
            try
            {
                AdminWSClient client = new AdminWSClient();
                AdminWS.grado[] set = client.listarGradosActivos();
                if (set != null)
                {
                    List<AdminWS.grado> grados = set.ToList();

                    listaGrados.DataSource = grados;
                    listaGrados.DisplayMember = "nombreCompleto";
                    listaGrados.ValueMember = "idGrado"; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los grados: " + ex.Message);
            }
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    //btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    //btnSeleccionar.Enabled = false;
                    //btnBuscarEstudiante.Enabled = true;
                    btnCancelar.Enabled = false;
                    //comboBoxMatricula.Enabled = false;
                    txtCodigoEst.Enabled = false;
                    // Agrega más componentes si es necesario
                    listaGrados.Enabled = false;
                    cbxEsValido.Enabled = false;
                    break;

                case Estado.Nuevo:
                    //btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    //btnSeleccionar.Enabled = false;
                    //btnBuscarEstudiante.Enabled = false;
                    btnCancelar.Enabled = true;
                    //comboBoxMatricula.Enabled = true;
                    txtCodigoEst.Enabled = true;
                    break;

                case Estado.Buscar:
                    //btnNuevo.Enabled = true;
                    btnGuardar.Enabled = true;
                    //btnSeleccionar.Enabled = false;
                    //btnBuscarEstudiante.Enabled = true;
                    btnCancelar.Enabled = true;
                    //comboBoxMatricula.Enabled = false;

                    txtCodigoEst.Enabled = false;

                    listaGrados.Enabled = true;
                    cbxEsValido.Enabled = true;
                    break;

                case Estado.Editar:
                    //btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    //btnSeleccionar.Enabled = true;
                    //btnBuscarEstudiante.Enabled = true;
                    btnCancelar.Enabled = true;
                    //comboBoxMatricula.Enabled = true;
                    //textBox1.Enabled = true;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtIDMatricula.Text = "";
            txtPeriodoMatricula.Text = "";
            //comboBoxMatricula.SelectedIndex = -1;
            txtCodigoEst.Text = "";
            txtNombreEst.Text = "";
            cbxEsValido.Checked = false;
            pictureBoxImagen.Image = null;
            listaGrados.SelectedIndex = -1;
            // Limpia más componentes si es necesario
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Editar;
            establecerEstadoComponentes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Buscar;
            establecerEstadoComponentes();
            frmRevisionPreInscripciones formRevisionPreInscripcion = new frmRevisionPreInscripciones(panelContenido);
            formRevisionPreInscripcion.OnInscripcionSeleccionado += FormRevisionPreInscripcion_OnInscripcionSeleccionado;
            mostrarFormulario(formRevisionPreInscripcion);
        }

        private inscripcion inscripcionSeleccionada;

        private void FormRevisionPreInscripcion_OnInscripcionSeleccionado(inscripcion inscripcion)
        {
            inscripcionSeleccionada = inscripcion;
            txtIDMatricula.Text = inscripcion.idInscripcion.ToString();
            txtPeriodoMatricula.Text = inscripcion.periodoAcademico;
            txtCodigoEst.Text = inscripcion.estudiante.idUsuario.ToString();
            string nombreCompleto = $"{inscripcion.estudiante.nombre} {inscripcion.estudiante.apellidoPaterno} {inscripcion.estudiante.apellidoMaterno}";
            txtNombreEst.Text = nombreCompleto;
            listaGrados.Enabled = cbxEsValido.Checked;

            if (inscripcion.estudiante.grado != null)
            {
                listaGrados.ValueMember = "IdGrado";
                listaGrados.SelectedValue = inscripcion.estudiante.grado.idGrado;
            }
            else
            {
                listaGrados.SelectedIndex = -1;
            }
            CargarImagen(inscripcion.imagen);
        }

        private void CargarImagen(byte[] imagenBytes)
        {
            if (imagenBytes != null && imagenBytes.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imagenBytes))
                {
                    pictureBoxImagen.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pictureBoxImagen.Image = null; // o alguna imagen por defecto
            }
        }


        public void mostrarFormulario(Form form)
        {
            panelContenido.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            panelContenido.Controls.Add(form);
            form.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Añade el código necesario para guardar la inscripción
            try
            {
                inscripcionSeleccionada.estado = cbxEsValido.Checked ? "Inscrito" : "Rechazado";
                inscripcionSeleccionada.estudiante.activo = cbxEsValido.Checked;

                if (listaGrados.SelectedIndex == -1)
                {
                    inscripcionSeleccionada.estudiante.grado = null;
                } else
                {
                    AdminWS.grado gradoSeleccionado = (AdminWS.grado)listaGrados.SelectedItem;
                    inscripcionSeleccionada.estudiante.grado = gradoSeleccionado;
                }

                int resultado = client.decidirInscripcion(inscripcionSeleccionada);
                if (resultado > 0)
                {
                    MessageBox.Show("Inscripción modificada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    limpiarComponentes();
                    establecerEstadoComponentes();
                }
                else
                {
                    MessageBox.Show("Hubo un error al modificar la inscripción.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Añade el código necesario para eliminar la inscripción
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar esta inscripción?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Aquí el código para eliminar la inscripción de la base de datos
                MessageBox.Show("Se ha eliminado la inscripción con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _estado = Estado.Inicial;
                limpiarComponentes();
                establecerEstadoComponentes();
            }
        }

        private void btnBuscarEstudiante_Click(object sender, EventArgs e)
        {
            frmBuscarEstudiante formBuscarInscripcion = new frmBuscarEstudiante();
            if (formBuscarInscripcion.ShowDialog() == DialogResult.OK)
            { }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbxEsValido_CheckedChanged(object sender, EventArgs e)
        {
            listaGrados.Enabled = cbxEsValido.Checked; 

            if (cbxEsValido.Checked == false)
            {
                listaGrados.SelectedIndex = -1;
            }
        }
    }
}
