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

namespace AstreiaSoft
{
    public partial class frmGestionMaterial : Form
    {
        private Estado _estado;
        private MallaWSClient _daoMallaWS;
        private material _material;
        private int _idCursoProg;
        private string _rutaArchivoPDF;
        public frmGestionMaterial(int idCursoProg)
        {
            InitializeComponent();
            _estado = Estado.Inicial;
            _daoMallaWS = new MallaWSClient();
            _idCursoProg = idCursoProg;
            dgvBuscarMaterial.AutoGenerateColumns = false;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        public void limpiarComponentes()
        {

            txtTitulo.Text = "";
            txtDescripcion.Text = "";
            txtBuscar.Text = "";

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
                    gbBuscarMaterial.Enabled = false;
                    gbMaterial.Enabled = false;
                    txtTitulo.Enabled = false;
                    txtDescripcion.Enabled = false;
                    txtBuscar.Enabled = true;
                    btnSubirArchivo.Enabled = false;
                    dgvBuscarMaterial.DataSource = null;
                    dgvBuscarMaterial.Rows.Clear();
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnSeleccionar.Enabled = false;
                    gbBuscarMaterial.Enabled = true;
                    gbMaterial.Enabled = true;
                    txtTitulo.Enabled = true;
                    txtTitulo.ReadOnly = false;
                    txtDescripcion.Enabled = true;
                    txtDescripcion.ReadOnly = false;
                    btnSubirArchivo.Enabled = true;
                    txtBuscar.Enabled = false;
                    dgvBuscarMaterial.DataSource = null;
                    dgvBuscarMaterial.Rows.Clear();
                    break;
                case Estado.Buscar:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnSeleccionar.Enabled = true;

                    gbBuscarMaterial.Enabled = true;
                    gbMaterial.Enabled = true;
                    txtBuscar.Enabled = true;
                    txtTitulo.Enabled = false;
                    btnSubirArchivo.Enabled = false;
                    txtDescripcion.Enabled = false;


                    break;
                case Estado.Seleccionar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnSeleccionar.Enabled = true;

                    gbBuscarMaterial.Enabled = true;
                    gbMaterial.Enabled = true;
                    txtBuscar.Enabled = true;
                    txtTitulo.Enabled = false;
                    txtDescripcion.Enabled = false;
                    btnSubirArchivo.Enabled = false;
                    break;
                case Estado.Editar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnSeleccionar.Enabled = false;
                    gbMaterial.Enabled = true;
                    gbBuscarMaterial.Enabled = true;
                    txtBuscar.Enabled = false;
                    txtTitulo.Enabled = true;
                    txtDescripcion.Enabled = true;
                    btnSubirArchivo.Enabled = true;

                    break;
                
                case Estado.Guardar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = false;
                    btnSeleccionar.Enabled = false;
                    dgvBuscarMaterial.DataSource = null;
                    dgvBuscarMaterial.Rows.Clear();
                    break;
                case Estado.Cancelar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = false;
                    btnSeleccionar.Enabled = false;
                    dgvBuscarMaterial.DataSource = null;
                    dgvBuscarMaterial.Rows.Clear();
                    break;
            }
        }
        private void btnSubirArchivo_Click(object sender, EventArgs e)
        {
            

            try
            {
                if (ofdArchivo.ShowDialog() == DialogResult.OK)
                {
                    
                    _rutaArchivoPDF = ofdArchivo.FileName;
                    FileStream fs = new FileStream(_rutaArchivoPDF, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    //Asignamos el archivo al objeto
                    this._material.archivo = br.ReadBytes((int)fs.Length);
                    br.Close();
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al seleccionar el archivo", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            _estado = Estado.Nuevo;
            _material = new material();
            establecerEstadoComponentes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (!validarCamposVacios()) return;

            _material.nombre = txtTitulo.Text;
            _material.descripcion = txtDescripcion.Text;
            _material.cursoProgramado = new cursoProgramado();
            _material.cursoProgramado.idCursoProgramado = _idCursoProg;
            //_material.cursoProgramado.idCursoProgramado = _daoMallaWS.encontrarCursoProgramadoPorCurso(_idCurso);

            if (_estado == Estado.Nuevo)
            {
                int resultado = _daoMallaWS.insertarMaterial(_material);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha registrado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //dgvBuscarMaterial.Rows.Clear();
                    _estado = Estado.Inicial;
                    establecerEstadoComponentes();
                }
                else
                    MessageBox.Show("Hubo un error en el registro", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                int resultado = _daoMallaWS.modificarMaterial(_material);
                if (resultado != 0)
                {
                    MessageBox.Show("El material se ha modificado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    establecerEstadoComponentes();
                }
                else
                    MessageBox.Show("Hubo un error en al modificar", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Editar;
            establecerEstadoComponentes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            

            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este material?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Se llama al web service para eliminar el evento
                int resultadoEliminacion = _daoMallaWS.eliminarMaterial(_material.idMaterial);

                if (resultadoEliminacion > 0)
                {
                    MessageBox.Show("Se ha eliminado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    //dgvBuscarMaterial.Rows.Clear();
                    limpiarComponentes();
                    establecerEstadoComponentes();
                }
                else
                {
                    MessageBox.Show("Hubo un error al eliminar el material.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            //dgvBuscarMaterial.Rows.Clear();
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var materiales = _daoMallaWS.listarMaterialesPorCursoProgramado(_idCursoProg)?.ToList();

            if (materiales != null)
            {
                dgvBuscarMaterial.DataSource = materiales;
                _estado = Estado.Buscar;
                establecerEstadoComponentes();
            }
            else
            {
                // Si no se encontraron materiales, puedes mostrar un mensaje o realizar otra acción
                MessageBox.Show("No se encontraron materiales para este curso programado.");

                // También puedes dejar el DataGridView en blanco
                dgvBuscarMaterial.DataSource = null;

                // Ajusta el estado según sea necesario
                _estado = Estado.Buscar; // Ajusta el estado según tus necesidades
                establecerEstadoComponentes();
            }

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            _material = (material)dgvBuscarMaterial.CurrentRow.DataBoundItem;
            txtTitulo.Text = _material.nombre;
            txtDescripcion.Text = _material.descripcion;
            _estado = Estado.Seleccionar;
            establecerEstadoComponentes();
        }

        private void dgvBuscarMaterial_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            material material = (material)dgvBuscarMaterial.Rows[e.RowIndex].DataBoundItem;
            dgvBuscarMaterial.Rows[e.RowIndex].Cells[0].Value = material.nombre;
            dgvBuscarMaterial.Rows[e.RowIndex].Cells[1].Value = material.descripcion;
        }

        private bool validarCamposVacios()
        {
            if (txtTitulo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el titulo del material", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtDescripcion.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar la descripcion del material", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (this._material.archivo == null)
            {
                MessageBox.Show("Tiene que subir un archivo", "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
