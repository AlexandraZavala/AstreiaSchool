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
    public partial class frmDetallesTareaDocente : Form
    {
        public frmDetallesTareaDocente()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private Estado _estado;
        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;

                    dtpFechaInicio.ForeColor = Color.DarkGray;
                    dtpFechaInicio.Enabled = false;
                    dtpFechaFin.Enabled = false;
                    cboTipoEvaluacion.Enabled = false;
                    txtNotaMaxima.Enabled = false;
                    lblDescripcion.Enabled = false;

                    break;

                case Estado.Buscar:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;

                    dtpFechaInicio.ForeColor = Color.DarkGray;
                    dtpFechaInicio.Enabled = false;
                    dtpFechaFin.Enabled = false;
                    cboTipoEvaluacion.Enabled = false;
                    txtNotaMaxima.Enabled = false;
                    txtDescripcion.Enabled = false;

                    break;
                case Estado.Seleccionar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;

                    dtpFechaInicio.ForeColor = Color.DarkGray;
                    dtpFechaInicio.Enabled = true;
                    dtpFechaFin.Enabled = true;
                    cboTipoEvaluacion.Enabled = true;
                    txtNotaMaxima.Enabled = true;
                    txtDescripcion.Enabled = true;
                    break;

                case Estado.Editar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;

                    dtpFechaInicio.ForeColor = Color.DarkGray;
                    dtpFechaInicio.Enabled = true;
                    dtpFechaFin.Enabled = true;
                    cboTipoEvaluacion.Enabled = true;
                    txtNotaMaxima.Enabled = true;
                    txtDescripcion.Enabled = true;
                    break;

                case Estado.Eliminar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = false;
                    break;

                case Estado.Guardar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = false;
                    break;

                case Estado.Cancelar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = false;
                    break;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            establecerEstadoComponentes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha registrado con éxito", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _estado = Estado.Inicial;
            establecerEstadoComponentes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Editar;
            establecerEstadoComponentes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha eliminado con éxito", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _estado = Estado.Inicial;
            establecerEstadoComponentes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Buscar;
            establecerEstadoComponentes();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Seleccionar;
            establecerEstadoComponentes();
        }

        private void btnIngresarTarea_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La tarea ha sido registrada exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
