using AstreiaSoft;
using AstreiaSoft.MallaWS;

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

namespace WindowsFormsApp1
{
    public partial class FrmGestionarCurso : Form
    {
        private Estado _estado;
        private MallaWSClient _daoServicioWeb;

        private curso _curso;
        private curso _cursoSeleccionado;
        private string _rutaFotoLocal;
        private Image _imagenSeleccionada;
        public FrmGestionarCurso()
        {
            InitializeComponent();
            establecerEstadoComponentes();
            _estado = Estado.Inicial;

            _daoServicioWeb = new MallaWSClient();


            cboAreaCurricular.DataSource = _daoServicioWeb.listarAreaCurricular();
            cboAreaCurricular.DisplayMember = "nombre";
            cboAreaCurricular.ValueMember = "idAreaCurricular";

            cboGrado.DataSource = _daoServicioWeb.listarGradosTodos();
            cboGrado.DisplayMember = "nombreCompleto";
            cboGrado.ValueMember = "idGrado";

            dgvCursos.AutoGenerateColumns = false;
            limpiarComponentes();
        }

        public void limpiarComponentes()
        {
            txtNombreCurso.Text = "";
            txtDescripcionCurso.Text = "";
            cboAreaCurricular.SelectedIndex = -1;
            cboGrado.SelectedIndex = -1;
            pbImagen.Image = null;
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

                    txtNombreCurso.Enabled = false;
                    txtDescripcionCurso.Enabled = false;
                    cboAreaCurricular.Enabled = false;
                    cboGrado.Enabled = false;
                    nudHorasSemanales.Enabled = false;
                    txtBuscar.Enabled = true;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnSeleccionar.Enabled = false;

                    txtNombreCurso.Enabled = true;
                    txtDescripcionCurso.Enabled = true;
                    cboAreaCurricular.Enabled = true;
                    cboGrado.Enabled = true;
                    nudHorasSemanales.Enabled=true;
                    txtBuscar.Enabled = true;
                    break;
                case Estado.Buscar:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnSeleccionar.Enabled = true;


                    txtBuscar.Enabled = true;
                    txtNombreCurso.Enabled = false;
                    txtDescripcionCurso.Enabled = false;
                    cboAreaCurricular.Enabled = false;
                    cboGrado.Enabled = false;
                    nudHorasSemanales.Enabled = false;

                    break;
                case Estado.Seleccionar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnSeleccionar.Enabled = false;

                    txtBuscar.Enabled = true;
                    txtNombreCurso.Enabled = false;
                    txtDescripcionCurso.Enabled = false;
                    cboAreaCurricular.Enabled = false;
                    cboGrado.Enabled = false;
                    nudHorasSemanales.Enabled=false;
                    break;
                case Estado.Editar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnSeleccionar.Enabled = false;

                    txtBuscar.Enabled = false;
                    txtNombreCurso.Enabled = true;
                    txtDescripcionCurso.Enabled = true;
                    cboAreaCurricular.Enabled = true;
                    cboGrado.Enabled = true;
                    nudHorasSemanales.Enabled = true;

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
            _curso = new curso();
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtNombreCurso.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el nombre del curso", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtDescripcionCurso.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar la descripcion del curso", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboAreaCurricular.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el Área Curricular del curso", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboGrado.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el grado del curso", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nudHorasSemanales.Value == -1)
            {
                MessageBox.Show("Debe ingresar la cantidad de horas semanales del curso", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (pbImagen.Image == null)
            {

                MessageBox.Show("Debe subir una portada para el curso", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            _curso.areaCurricular = new areaCurricular();
            _curso.grado = new grado();

            _curso.nombre = txtNombreCurso.Text;
            _curso.descripcion = txtDescripcionCurso.Text;
            _curso.areaCurricular.idAreaCurricular = (int)cboAreaCurricular.SelectedValue;
            _curso.grado.idGrado = (int)cboGrado.SelectedValue;
            _curso.horasSemanales = (int)nudHorasSemanales.Value;

            if (pbImagen.Image != _imagenSeleccionada)
            {
                // Obtener el arreglo de bytes de la nueva imagen
                FileStream fs = new FileStream(_rutaFotoLocal, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                _curso.imagen = br.ReadBytes((int)fs.Length);
                fs.Close();
            }
            else
            {

                MemoryStream ms = new MemoryStream();
                
                _imagenSeleccionada.Save(ms, _imagenSeleccionada.RawFormat);
                _curso.imagen = ms.ToArray();
                
                
            }

            

            int verificar = _daoServicioWeb.verificarCurso(_curso);

            if (_estado == Estado.Nuevo)
            {
                if (verificar != 0)
                {
                    MessageBox.Show("Ya existe ese Curso en el grado señalado.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    int resultado = _daoServicioWeb.insertarCurso(_curso);

                    if (resultado != 0)
                    {
                        MessageBox.Show("El Curso se ha registrado con éxito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _estado = Estado.Inicial;
                        establecerEstadoComponentes();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error en el registro", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                
            }
            else if (_estado == Estado.Editar)
            {
                _curso.idCurso = _cursoSeleccionado.idCurso;
                
                if(_cursoSeleccionado.nombre==_curso.nombre && _cursoSeleccionado.areaCurricular.idAreaCurricular ==
                    _curso.areaCurricular.idAreaCurricular && _cursoSeleccionado.grado.idGrado == _curso.grado.idGrado)
                {
                    //es el mismo
                    verificar =  0;
                }
                
                if (verificar != 0)
                {
                    MessageBox.Show("Ya existe ese Curso en el grado señalado.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                

                int resultado = _daoServicioWeb.modificarCurso(_curso);

                if (resultado != 0)
                {
                    MessageBox.Show("El Curso se ha actualizado con éxito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            _curso = new curso();

            

            establecerEstadoComponentes();

            //if (ofdFoto.ShowDialog() == DialogResult.OK)
            //{
                
            //    _imagenSeleccionada = Image.FromFile(ofdFoto.FileName);
            //    pbImagen.Image = _imagenSeleccionada;
            //}

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_cursoSeleccionado != null)
            {

                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este Curso?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    int resultadoEliminacion = _daoServicioWeb.eliminarCurso(_cursoSeleccionado.idCurso);

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
            dgvCursos.DataSource = _daoServicioWeb.listarCursosNombre(txtBuscar.Text);

            _estado = Estado.Buscar;
            establecerEstadoComponentes();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            _cursoSeleccionado = (curso)dgvCursos.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;

            txtDescripcionCurso.Text = _cursoSeleccionado.descripcion;
            txtNombreCurso.Text = _cursoSeleccionado.nombre;
            cboAreaCurricular.SelectedValue = _cursoSeleccionado.areaCurricular.idAreaCurricular;
            cboGrado.SelectedValue = _cursoSeleccionado.grado.idGrado;
            nudHorasSemanales.Value = _cursoSeleccionado.horasSemanales;
            MemoryStream ms = new MemoryStream(_cursoSeleccionado.imagen);
            pbImagen.Image = new Bitmap(ms);
            _imagenSeleccionada = pbImagen.Image;

            _estado = Estado.Seleccionar;
            establecerEstadoComponentes();
        }

        private void dgvCursos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            curso cursos = (curso)dgvCursos.Rows[e.RowIndex].DataBoundItem;
            if (cursos != null)
            {

                dgvCursos.Rows[e.RowIndex].Cells[0].Value = cursos.nombre;
                dgvCursos.Rows[e.RowIndex].Cells[1].Value = cursos.areaCurricular.nombre;
                dgvCursos.Rows[e.RowIndex].Cells[2].Value = cursos.grado.nombre;
                
            }
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdFoto.ShowDialog() == DialogResult.OK)
                {
                    _rutaFotoLocal = ofdFoto.FileName;
                    pbImagen.Image = Image.FromFile(_rutaFotoLocal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }
    }
}
