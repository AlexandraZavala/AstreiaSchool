using AstreiaSoft.InfraWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstreiaSoft
{
    public partial class frmGestAulas : Form
    {

        private InfraWSClient _daoInfraWS;
        private grado _grado;
        private seccion _seccion;
        private aula _aula;
        private estadoAula _estadoAula;
        private Estado _estado;


        public seccion SeccionSeleccionada { get; set; }
        public frmGestAulas()
        {
            _daoInfraWS = new InfraWSClient();
            InitializeComponent();
            dgvAulas.AutoGenerateColumns = false;
            _estado = Estado.Inicial;
            panelSecciones.AutoScroll = true;

            cboGrado.DataSource = _daoInfraWS.listarGradosTodos();
            cboGrado.DisplayMember = "nombreCompleto";
            cboGrado.ValueMember = "idGrado";

           
            establecerEstadoComponentes();
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
                    panelSecciones.Controls.Clear();

                    txtIdAula.ForeColor = Color.DarkGray;
                    txtIdAula.Enabled = false;
                    cboGrado.Enabled = false;
                    

                    txtNombreAula.Enabled = false;
                    txtCodigoAula.Enabled = false;
                    txtNombreAula.Enabled = false;
                    txtCapacidadAula.Enabled = false;
                    



                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnSeleccionar.Enabled = false;
                    panelSecciones.Controls.Clear();

                    txtIdAula.ForeColor = Color.DarkGray;
                    txtIdAula.Enabled = false;
                    cboGrado.Enabled = true;


                    txtNombreAula.Enabled = true;
                    txtCodigoAula.Enabled = true;
                    txtNombreAula.Enabled = true;
                    txtCapacidadAula.Enabled = true;

                    break;
                case Estado.Buscar:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnSeleccionar.Enabled = true;

                


                    break;
                case Estado.Seleccionar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnSeleccionar.Enabled = true;
                    panelSecciones.Controls.Clear();


                    break;
                case Estado.Editar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnSeleccionar.Enabled = false;

                    txtIdAula.ForeColor = Color.DarkGray;
                    txtIdAula.Enabled = false;
                    cboGrado.Enabled = true;


                    txtNombreAula.Enabled = true;
                    txtCodigoAula.Enabled = true;
                    txtNombreAula.Enabled = true;
                    txtCapacidadAula.Enabled = true;

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

        private void frmGestAulas_Load(object sender, EventArgs e)
        {
           
        }

        private void cboGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGrado.SelectedIndex != -1)
            {
                _grado = (grado)cboGrado.SelectedItem;
            }

            panelSecciones.Controls.Clear();
            int id = (int)_grado.idGrado;

            AstreiaSoft.InfraWS.seccion[] arregloSecciones = _daoInfraWS.listarSeccionPorIdGrado(id);

            if (arregloSecciones != null) 
            {
                BindingList<AstreiaSoft.InfraWS.seccion> secciones = new BindingList<AstreiaSoft.InfraWS.seccion>(arregloSecciones);
                foreach (seccion sec in secciones)
                {
                    frmImgSeccion formSec = new frmImgSeccion(sec, this);
                    formSec.TopLevel = false;
                    formSec.Dock = DockStyle.Top;
                    panelSecciones.Controls.Add(formSec);
                    formSec.Visible = true;
                }
            }
            else 
            { 

            }
   
        }

        public void EstablecerSeccionSeleccionada(seccion sec)
        {
            _seccion = sec;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            establecerEstadoComponentes();
            _seccion = new seccion();
            _aula = new aula();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _seccion.aula = _aula;
            int idAula = _seccion.aula.idAula;
            int idSeccion = _daoInfraWS.vericarAulaEnSecciones(_seccion.aula.idAula);
            
            int resultado = 0;
            _seccion.aula.idAula = 0;
            resultado = _daoInfraWS.modificarSeccion(_seccion);
            resultado = _daoInfraWS.eliminarAula(idAula);

            if (resultado != 0)
            {
                
                MessageBox.Show("Se ha eliminado con éxito", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            _estado = Estado.Inicial;
            establecerEstadoComponentes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int resultado = 0;

            // Crear aula
            _aula.nombre = txtNombreAula.Text;
            _aula.codigo = txtCodigoAula.Text;
            _aula.capacidad = Int32.Parse(txtCapacidadAula.Text);

            
            _aula.estadoSpecified = true;

            if (_estado == Estado.Nuevo)
            {
                resultado = _daoInfraWS.insertarAula(_aula);
                _aula.idAula = resultado;
            }
            if (_estado == Estado.Editar)
            {
                resultado = _daoInfraWS.modificarAula(_aula);
            }

            

            foreach (Control control in panelSecciones.Controls)
            {
                if (control is frmImgSeccion formSec && formSec.IsSelected)
                {
                    _seccion = formSec.GetSeccion(); // Obtener la sección asociada del formulario seleccionado
                    break;
                }
            }

            //_seccion.aula = _aula;

            // Si hay una sección seleccionada, asociar la aula creada a esa sección
            if (_seccion != null)
            {
                _daoInfraWS.asignarAulaXSeccion(_seccion.idSeccion, _aula.idAula);
            }

            if (resultado != 0)
            {
                MessageBox.Show("Se ha registrado con éxito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdAula.Text = this._aula.idAula.ToString();

                _estado = Estado.Inicial;
                establecerEstadoComponentes();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvAulas.DataSource = _daoInfraWS.listarAulasDetalle().ToList();
            _estado = Estado.Buscar;
            establecerEstadoComponentes();
        }

        private void dgvAulas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            seccion seccion = (seccion)dgvAulas.Rows[e.RowIndex].DataBoundItem;
            dgvAulas.Rows[e.RowIndex].Cells[0].Value = seccion.aula.codigo;
            dgvAulas.Rows[e.RowIndex].Cells[1].Value = seccion.aula.capacidad;
            dgvAulas.Rows[e.RowIndex].Cells[2].Value = seccion.grado.nombreCompleto;
            dgvAulas.Rows[e.RowIndex].Cells[3].Value = seccion.nombre;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            _seccion = (seccion)dgvAulas.CurrentRow.DataBoundItem;
            _aula = _seccion.aula;

            txtIdAula.Text = _seccion.aula.idAula.ToString();
            txtNombreAula.Text = _seccion.aula.nombre;
            txtCodigoAula.Text = _seccion.aula.codigo.ToString();
            txtCapacidadAula.Text = _seccion.aula.capacidad.ToString();




            if (_seccion.grado != null)
            {

            }

            _estado = Estado.Seleccionar;
            establecerEstadoComponentes();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Editar;
            establecerEstadoComponentes();
        }

        
    }
}
