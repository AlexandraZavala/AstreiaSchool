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
    public partial class frmGestMatricula : Form
    {
        private Estado _estado;
        private Panel panelContenido;
        private matricula matriculaSeleccionada;
        private AdminWSClient client;
        public frmGestMatricula(Panel panelContenido)
        {
            client = new AdminWSClient();
            InitializeComponent();
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
            this.panelContenido = panelContenido;
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = false;
                    dtpFechaInicio.Enabled = false;
                    dtpFechaFin.Enabled = false;
                    txtMonto.Enabled = false;
                    break;

                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    dtpFechaInicio.Enabled = true;
                    dtpFechaFin.Enabled = true;
                    txtMonto.Enabled = true;
                    break;

                case Estado.Buscar:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnCancelar.Enabled = true;
                    dtpFechaInicio.Enabled = false;
                    dtpFechaFin.Enabled = false;
                    txtMonto.Enabled = false;
                    break;

                case Estado.Editar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    dtpFechaInicio.Enabled = true;
                    dtpFechaFin.Enabled = true;
                    txtMonto.Enabled = true;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtIDMatricula.Text = "";
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;
            txtMonto.Text = "";
            btnGuardar.Text = "Guardar";
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
            btnGuardar.Text = "Modificar";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Definir el estado como Buscar
            _estado = Estado.Buscar;
            establecerEstadoComponentes();

            // Crear y mostrar el formulario de búsqueda de matrículas
            frmBuscarMatriculas formBuscarMatricula = new frmBuscarMatriculas(panelContenido);
            formBuscarMatricula.OnMatriculaSeleccionada += FormBuscarMatricula_OnMatriculaSeleccionada;
            mostrarFormulario(formBuscarMatricula);
        }

        private void FormBuscarMatricula_OnMatriculaSeleccionada(matricula matriculaElegida)
        {
            // Guardar la matrícula seleccionada para uso posterior (si es necesario)
            matriculaSeleccionada = matriculaElegida;

            // Llenar los campos del formulario principal con la información de la matrícula seleccionada
            txtIDMatricula.Text = matriculaElegida.idMatricula.ToString();
            txtMonto.Text = matriculaElegida.monto.ToString();

            // Asignar la fecha de inicio y de fin al DateTimePicker correspondiente
            dtpFechaInicio.Value = matriculaElegida.fechaInicio.Date;
            dtpFechaFin.Value = matriculaElegida.fechaFin.Date;
        }



        public void mostrarFormulario(Form form)
        {
            panelContenido.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            panelContenido.Controls.Add(form);
            form.Visible = true;
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {

        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                matricula nuevaMatricula = CrearMatriculaDesdeFormulario();

                if (!ValidarMatricula(nuevaMatricula))
                    return;

                if (_estado == Estado.Editar)
                {
                    nuevaMatricula.idMatricula = matriculaSeleccionada.idMatricula;
                    ModificarMatricula(nuevaMatricula);
                }
                else
                {
                    GuardarNuevaMatricula(nuevaMatricula);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private matricula CrearMatriculaDesdeFormulario()
        {
            return new matricula
            {
                fechaInicio = dtpFechaInicio.Value.Date,
                fechaFin = dtpFechaFin.Value.Date,
                monto = double.Parse(txtMonto.Text),
                fechaInicioSpecified = true,
                fechaFinSpecified = true
            };
        }

        private bool ValidarMatricula(matricula matriculaAValidar)
        {
            if (txtMonto.Text.Any(c => !char.IsDigit(c)))
            {
                MessageBox.Show("El monto debe contener solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Establecer el monto máximo según la política de la institución o regulaciones
            double montoMaximo = 100000;

            if (matriculaAValidar.monto <= 0 || matriculaAValidar.monto > montoMaximo)
            {
                MessageBox.Show("El monto debe ser mayor que cero y no exceder el máximo permitido (S/. 100 000).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (matriculaAValidar.fechaInicio >= matriculaAValidar.fechaFin)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor o igual a la fecha de fin.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ModificarMatricula(matricula matriculaAModificar)
        {
            // Asumo que tienes un método similar al de insertarMatricula para modificar la matricula
            int resultadoModificacion = client.modificarMatricula(matriculaAModificar);
            if (resultadoModificacion > 0)
            {
                MessageBox.Show("Matrícula modificada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _estado = Estado.Inicial;
                limpiarComponentes();
                establecerEstadoComponentes();
            }
            else
            {
                MessageBox.Show("Hubo un error al modificar la matrícula.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarNuevaMatricula(matricula nuevaMatricula)
        {
            int resultado = client.insertarMatricula(nuevaMatricula);
            if (resultado > 0)
            {
                MessageBox.Show("Matrícula registrada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _estado = Estado.Inicial;
                limpiarComponentes();
                establecerEstadoComponentes();
            }
            else
            {
                MessageBox.Show("Hubo un error al registrar la matrícula.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string prevMonto = ""; // para almacenar el valor anterior del textBox
        private void textBoxMonto_TextChanged(object sender, EventArgs e)
        {
            // Si el contenido actual del textBox no es un número...
            if (!decimal.TryParse(txtMonto.Text, out _) && !string.IsNullOrEmpty(txtMonto.Text))
            {
                // ...revertir al valor anterior.
                txtMonto.Text = prevMonto;

                // Se coloca el cursor al final del texto.
                txtMonto.SelectionStart = txtMonto.Text.Length;
            }
            else
            {
                // Si es un número o está vacío, actualizamos el valor anterior.
                prevMonto = txtMonto.Text;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar esta matricula?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Se llama al web service para eliminar la matricula
                int resultadoEliminacion = client.eliminarMatricula(matriculaSeleccionada.idMatricula);

                if (resultadoEliminacion > 0)
                {
                    MessageBox.Show("Matricula eliminada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    limpiarComponentes();
                    establecerEstadoComponentes();
                }
                else
                {
                    MessageBox.Show("Hubo un error al eliminar la matricula.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
