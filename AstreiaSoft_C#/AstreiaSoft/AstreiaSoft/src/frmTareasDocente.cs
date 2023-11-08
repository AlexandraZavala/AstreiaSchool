using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstreiaSoft
{
    public partial class frmTareasDocente : Form
    {
        private Estado _estado;
        public frmTareasDocente()
        {        
            InitializeComponent();
        }
        
        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Buscar:
                    btnBuscar.Enabled = false;
                    btnSeleccionar.Enabled = true;
                    break;

                case Estado.Seleccionar:
                    btnBuscar.Enabled = false;
                    btnSeleccionar.Enabled = false;
                    break;
            }
        }


        private void frmGestAulas_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            establecerEstadoComponentes();
            frmDetallesTareaDocente formDetallesTarea = new frmDetallesTareaDocente();
            formDetallesTarea.Show();
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
        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La tarea ha sido elimada exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            frmDetallesTareaDocente formDetallesTarea = new frmDetallesTareaDocente();
        }

        private void btnEditarTarea_Click(object sender, EventArgs e)
        {
            frmDetallesTareaDocente formDetallesTarea = new frmDetallesTareaDocente();
        }

        private void frmTareasDocente_Load(object sender, EventArgs e)
        {

        }

        private void btnSeleccionar_Click_1(object sender, EventArgs e)
        {
            frmDetallesTareaDocente formDetallesTarea = new frmDetallesTareaDocente();
            formDetallesTarea.Show();
        }
    }
}
