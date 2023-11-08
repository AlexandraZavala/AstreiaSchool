using AstreiaSoft;
using AstreiaSoft.MallaWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;/**/
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmGestAreaCurricular : Form
    {
        private Estado _estado;
        private MallaWSClient _daoServicioWeb;
        private areaCurricular _areaCurricular;
        private areaCurricular _areaSeleccionada;


        public frmGestAreaCurricular()
        {
            InitializeComponent();
            establecerEstadoComponentes();
            _estado = Estado.Inicial;
            limpiarComponentes();
            dgvBusqueda.AutoGenerateColumns = false;
            _daoServicioWeb = new MallaWSClient();
            
        }
        public void limpiarComponentes()
        {
            
            txtNombreAreaCurr.Text = "";
            txtDescripcionAreaCurri.Text = "";
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

                    txtNombreAreaCurr.Enabled = false;
                    txtDescripcionAreaCurri.Enabled = false;
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

                    txtNombreAreaCurr.Enabled = true;
                    txtDescripcionAreaCurri.Enabled = true;
                    txtBuscar.Enabled = false;
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
                    txtNombreAreaCurr.Enabled = false;
                    txtDescripcionAreaCurri.Enabled = false;
                    

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
                    txtNombreAreaCurr.Enabled = false;
                    txtDescripcionAreaCurri.Enabled = false;

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
                    txtNombreAreaCurr.Enabled = true;
                    txtDescripcionAreaCurri.Enabled = true;

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
            _areaCurricular = new areaCurricular();

            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDescripcionAreaCurri.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar la descripción del Área Curricular", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtNombreAreaCurr.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el Nombre del Área Curricular", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _areaCurricular.nombre = txtNombreAreaCurr.Text;
            _areaCurricular.descripcion = txtDescripcionAreaCurri.Text;


            int verificar = _daoServicioWeb.verificarArea(txtNombreAreaCurr.Text);

            if (_estado == Estado.Nuevo)
            {
                if (verificar != 0 )
                {
                    MessageBox.Show("Ya existe un Área Curricular con ese nombre.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else {

                    int resultado = _daoServicioWeb.insertarAreaCurricular(_areaCurricular);

                    if (resultado != 0)
                    {
                        MessageBox.Show("El Área Curricular se ha registrado con éxito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                _areaCurricular.idAreaCurricular = _areaSeleccionada.idAreaCurricular;
                
                if(_areaCurricular.nombre != _areaSeleccionada.nombre)
                {
                    if (verificar != 0)
                    {
                        MessageBox.Show("Ya existe un Área Curricular con ese nombre.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                int resultado = _daoServicioWeb.modificarAreaCurricular(_areaCurricular);

                if (resultado != 0)
                {
                    MessageBox.Show("El Área Curricular se ha actualizado con éxito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            _areaCurricular = new areaCurricular();
            establecerEstadoComponentes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            dgvBusqueda.DataSource = _daoServicioWeb.listarAreasNombre(txtBuscar.Text);

            _estado = Estado.Buscar;
            establecerEstadoComponentes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_areaSeleccionada != null)
            {
                
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este Área Curricular?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    int resultadoEliminacion = _daoServicioWeb.eliminarAreaCurricular(_areaSeleccionada.idAreaCurricular);

                    if (resultadoEliminacion != 0)
                    {
                        MessageBox.Show("El Área Curricular se ha eliminado con éxito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _estado = Estado.Inicial;
                        establecerEstadoComponentes();

                        limpiarComponentes();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al eliminar el Área Curricular", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un Área Curricular para eliminar.", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

            _areaSeleccionada = (areaCurricular)dgvBusqueda.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;

            txtNombreAreaCurr.Text = _areaSeleccionada.nombre;
            txtDescripcionAreaCurri.Text = _areaSeleccionada.descripcion;

            _estado = Estado.Seleccionar;
            establecerEstadoComponentes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
        }

        private void dgvBusqueda_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            areaCurricular areaCurricular = (areaCurricular)dgvBusqueda.Rows[e.RowIndex].DataBoundItem;
            if (areaCurricular != null)
            {
                dgvBusqueda.Rows[e.RowIndex].Cells[0].Value = areaCurricular.nombre;
                dgvBusqueda.Rows[e.RowIndex].Cells[1].Value = areaCurricular.descripcion;
            }
        }
    }

   

}
