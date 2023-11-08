using AstreiaSoft;

using AstreiaSoft.MallaWS;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmGestCursoProgra : Form
    {
        private Estado _estado;
        private MallaWSClient _daoServicioWeb;
        private cursoProgramado _cursoProgramado;
        private cursoProgramado _cursoProSeleccionado;
        public frmGestCursoProgra()
        {
            InitializeComponent();
            establecerEstadoComponentes();
            _estado = Estado.Inicial;
            limpiarComponentes();
            _daoServicioWeb = new MallaWSClient();


            cboCurso.DataSource = _daoServicioWeb.listarCursos();
            cboCurso.DisplayMember = "nombre";
            cboCurso.ValueMember = "idCurso";

            txtAnio.Text = DateTime.Now.Year.ToString();

            dgvCursoPro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCursoPro.AutoGenerateColumns = false;
        }

        public void limpiarComponentes()
        {

            cboCurso.Text = "";
            txtDescripcion.Text = "";
            

        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnSeleccionar.Enabled = false;

                    cboCurso.Enabled = false;
                    txtDescripcion.Enabled = false;
                    txtAnio.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnSeleccionar.Enabled = false;

                    cboCurso.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtAnio.Enabled = false;
                    break;
                case Estado.Buscar:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnSeleccionar.Enabled = true;


                    
                    cboCurso.Enabled = false;
                    txtDescripcion.Enabled = false;
                    txtAnio.Enabled = false;

                    break;
                case Estado.Seleccionar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnSeleccionar.Enabled = false;

                    
                    cboCurso.Enabled = false;
                    txtDescripcion.Enabled = false;
                    txtAnio.Enabled = false;
                    break;
                case Estado.Editar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnSeleccionar.Enabled = false;

                    
                    cboCurso.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtAnio.Enabled = false;
                    break;
                case Estado.Eliminar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = false;
                    btnSeleccionar.Enabled = false;
                    break;
                case Estado.Guardar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = false;
                    btnSeleccionar.Enabled = false;
                    break;
                case Estado.Cancelar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = false;
                    btnSeleccionar.Enabled = false;
                    break;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            _cursoProgramado = new cursoProgramado();
            establecerEstadoComponentes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cboCurso.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el Curso a dictar el presente año", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDescripcion.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar la descripcion del curso", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _cursoProgramado.curso = new curso();

            _cursoProgramado.curso.idCurso = (int)cboCurso.SelectedValue;
            _cursoProgramado.descripcion = txtDescripcion.Text;
            _cursoProgramado.anho = DateTime.Now.Year;
             

            int verificar = _daoServicioWeb.verificarCursoProgramado(_cursoProgramado);

            if (_estado == Estado.Nuevo)
            {
                if (verificar != 0)
                {
                    MessageBox.Show("Ya existe ese Curso Programado.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int resultado = _daoServicioWeb.insertarCursoProgramado(_cursoProgramado);

                if (resultado != 0)
                {
                    
                    MessageBox.Show("El Curso Programado se ha registrado con éxito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    establecerEstadoComponentes();
                }
                else
                {
                    MessageBox.Show("Hubo un error en el registro", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (_estado == Estado.Editar)
            {
                _cursoProgramado.idCursoProgramado = _cursoProSeleccionado.idCursoProgramado;

                if(_cursoProgramado.curso.idCurso==_cursoProSeleccionado.curso.idCurso && _cursoProgramado.anho == _cursoProSeleccionado.anho)
                {
                    verificar = 0;//es el mismo
                }


                if (verificar != 0)
                {
                    MessageBox.Show("Ya existe ese Curso en el grado señalado.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int resultado = _daoServicioWeb.modificarCursoProgramado(_cursoProgramado);

                if (resultado != 0)
                {
                    MessageBox.Show("El Curso Programado se ha actualizado con éxito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    establecerEstadoComponentes();
                }
                else
                {
                    MessageBox.Show("Hubo un error en la actualización", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Editar;
            _cursoProgramado = new cursoProgramado();
            establecerEstadoComponentes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_cursoProSeleccionado != null)
            {

                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este Curso?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    int resultadoEliminacion = _daoServicioWeb.eliminarCursoProgramado(_cursoProSeleccionado.idCursoProgramado);

                    if (resultadoEliminacion != 0)
                    {
                        MessageBox.Show("El Curso se ha eliminado con éxito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _estado = Estado.Inicial;
                        establecerEstadoComponentes();

                        limpiarComponentes();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al eliminar el Curso", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un Curso para eliminar.", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvCursoPro.DataSource = _daoServicioWeb.listarCursosPrograTodos();
            _estado = Estado.Buscar;
            establecerEstadoComponentes();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            _cursoProSeleccionado = (cursoProgramado)dgvCursoPro.CurrentRow.DataBoundItem;

            this.DialogResult = DialogResult.OK;

            cboCurso.SelectedValue = _cursoProSeleccionado.curso.idCurso;
            txtAnio.Text = _cursoProSeleccionado.anho.ToString();
            txtDescripcion.Text = _cursoProSeleccionado.descripcion;


            _estado = Estado.Seleccionar;
            establecerEstadoComponentes();
        }

        private void dgvCursoPro_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            cursoProgramado cursoProgramado = (cursoProgramado)dgvCursoPro.Rows[e.RowIndex].DataBoundItem;
            if (cursoProgramado != null)
            {

                dgvCursoPro.Rows[e.RowIndex].Cells[0].Value = cursoProgramado.curso.nombre;
                dgvCursoPro.Rows[e.RowIndex].Cells[1].Value = cursoProgramado.anho;
                dgvCursoPro.Rows[e.RowIndex].Cells[2].Value = cursoProgramado.descripcion;

            }
        }
    }
}
