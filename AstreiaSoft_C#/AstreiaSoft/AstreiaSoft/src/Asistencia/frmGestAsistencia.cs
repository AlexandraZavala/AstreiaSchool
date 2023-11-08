using AstreiaSoft;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft
{
    public partial class frmGestAsistencia : Form
    {
        private Estado _estado;

        public frmGestAsistencia()
        {
            InitializeComponent();
            _estado = AstreiaSoft.Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case AstreiaSoft.Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = false;
                    dtpFecha.Enabled = false;
                    // otros componentes a deshabilitar
                    break;

                case AstreiaSoft.Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    dtpFecha.Enabled = true;
                    // otros componentes a habilitar
                    break;

                case AstreiaSoft.Estado.Buscar:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnCancelar.Enabled = true;
                    dtpFecha.Enabled = false;
                    // otros componentes a deshabilitar
                    break;

                case AstreiaSoft.Estado.Editar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    dtpFecha.Enabled = true;
                    // otros componentes a habilitar
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtEstudiante.Text = "";
            cbMarcarTodos.Checked = false;
            dgvAsistencias.Rows.Clear();  // Limpia el DataGridView
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = AstreiaSoft.Estado.Nuevo;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = AstreiaSoft.Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _estado = AstreiaSoft.Estado.Editar;
            establecerEstadoComponentes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Asistencia registrada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _estado = AstreiaSoft.Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar esta asistencia?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Asistencia eliminada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _estado = AstreiaSoft.Estado.Inicial;
                limpiarComponentes();
                establecerEstadoComponentes();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _estado = AstreiaSoft.Estado.Buscar;
            establecerEstadoComponentes();

            // Aquí invocarías el formulario de búsqueda de asistencias, si lo tienes.
            frmBuscarAsistencia formBuscarAsistencia = new frmBuscarAsistencia();
            if (formBuscarAsistencia.ShowDialog() == DialogResult.OK)
            { }
        }

        private void btnBuscarEstudiantes_Click(object sender, EventArgs e)
        {
            frmBuscarEstudiante formBuscarEstudiante = new frmBuscarEstudiante();
            if (formBuscarEstudiante.ShowDialog() == DialogResult.OK)
            {
                // Aquí puedes agregar acciones adicionales que quieras realizar después de seleccionar un estudiante
            }
        }

        private void tbCodCurso_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
