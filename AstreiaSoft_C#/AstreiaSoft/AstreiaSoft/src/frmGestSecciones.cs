using AstreiaSoft.InfraWS;
using AstreiaSoft.UserWS;
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
    public partial class frmGestSecciones : Form
    {
        private string _rutaImagen = "";
        private Estado _estado;

        private InfraWSClient _daoInfraWs;
        private UserWSClient _daoUserWS;

        private InfraWS.grado _grado;
        private InfraWS.seccion _seccion;
        private InfraWS.seccion _seccionEst;

        private InfraWS.seccion _seccionSeleccionado;
        private UserWS.estudiante _estudianteGradoSeleccionado;
        private UserWS.estudiante _estudianteSeccionSeleccionado;

        public InfraWS.seccion SeccionSeleccionado { get => _seccionSeleccionado; set => _seccionSeleccionado = value; }
        public UserWS.estudiante EstudianteGradoSeleccionado { get => _estudianteGradoSeleccionado; set => _estudianteGradoSeleccionado = value; }
        public UserWS.estudiante EstudianteSeccionSeleccionado { get => _estudianteSeccionSeleccionado; set => _estudianteSeccionSeleccionado = value; }

        public frmGestSecciones()
        {
            _daoInfraWs = new InfraWSClient();
            _daoUserWS = new UserWSClient();

            InitializeComponent();
            _estado = Estado.Inicial;
            limpiarComponentes();
            dgvSecciones.AutoGenerateColumns = false;
            dgvSecciones.RowHeadersVisible = false;

            dgvEstudiantesGrado.AutoGenerateColumns = false;
            dgvEstudiantesGrado.RowHeadersVisible = false;

            dgvEstudiantesSeccion.AutoGenerateColumns = false;
            dgvEstudiantesSeccion.RowHeadersVisible = false;


            cboGrado.DataSource = _daoInfraWs.listarGradosTodos();
            cboGrado.DisplayMember = "nombreCompleto";
            cboGrado.ValueMember = "idGrado";


            cboGradoAsig.DataSource = _daoInfraWs.listarGradosTodos();
            cboGradoAsig.DisplayMember = "nombreCompleto";
            cboGradoAsig.ValueMember = "idGrado";



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

                    txtIdSeccion.ForeColor = Color.DarkGray;
                    txtIdSeccion.Enabled = false;
                    rbSecA.Enabled = false;
                    rbSecB.Enabled = false;
                    rbSecC.Enabled = false;
                    rbSecD.Enabled = false;
                    cboGrado.Enabled = false;
                    
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnSeleccionar.Enabled = false;

                    txtIdSeccion.ForeColor = Color.DarkGray;
                    txtIdSeccion.Enabled = false;
                    rbSecA.Enabled = true;
                    rbSecB.Enabled = true;
                    rbSecC.Enabled = true;
                    rbSecD.Enabled = true;
                    cboGrado.Enabled = true;
                    

                    break;
                case Estado.Buscar:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnSeleccionar.Enabled = true;

                    txtIdSeccion.ForeColor = Color.DarkGray;
                    txtIdSeccion.Enabled = false;
                    rbSecA.Enabled = false;
                    rbSecB.Enabled = false;
                    rbSecC.Enabled = false;
                    rbSecD.Enabled = false;
                    cboGrado.Enabled = false;
                    

                    break;
                case Estado.Seleccionar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnSeleccionar.Enabled = true;

                    txtIdSeccion.ForeColor = Color.DarkGray;
                    txtIdSeccion.Enabled = false;
                    rbSecA.Enabled = false;
                    rbSecB.Enabled = false;
                    rbSecC.Enabled = false;
                    rbSecD.Enabled = false;
                    cboGrado.Enabled = false;
                    

                    break;
                case Estado.Editar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnSeleccionar.Enabled = false;

                    txtIdSeccion.ForeColor = Color.DarkGray;
                    txtIdSeccion.Enabled = false;
                    rbSecA.Enabled = true;
                    rbSecB.Enabled = true;
                    rbSecC.Enabled = true;
                    rbSecD.Enabled = true;
                    cboGrado.Enabled = true;
                    

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

        public void limpiarComponentes()
        {
            txtIdSeccion.Text = "";
            //txtNombre.Text = "";
            cboGrado.SelectedIndex = -1;
            //cboProductora.SelectedIndex = -1;
            //dtpFechaEstreno.Value = DateTime.Now;
            rbSecA.Checked = false;
            rbSecB.Checked = false; 
            rbSecC.Checked = false;
            rbSecD.Checked = false;
            
            //txtSinopsis.Text = "";
            //panelSuperior.BackColor = SystemColors.Control;
            //pbLogoProductora.Image = null;
            //pbPortada.Image = null;

        }

        

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private BindingList<UserWS.estudiante> listaEstudiantesSeccion = new BindingList<UserWS.estudiante>();
        private BindingList<UserWS.estudiante> listaEstudiantesSeccionAgregar = new BindingList<UserWS.estudiante>();
        private BindingList<UserWS.estudiante> listaEstudiantesSeccionQuitar = new BindingList<UserWS.estudiante>();

        private void cboSeccionAsig_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSeccionAsig.SelectedIndex != -1)
            {
                _seccionEst = (InfraWS.seccion)cboSeccionAsig.SelectedItem;

                // Obtiene el arreglo de estudiantes
                UserWS.estudiante[] arrayEstudiantes = _daoUserWS.listarEstudiantesPorSeccion(_seccionEst.idSeccion);

                // Convierte el arreglo a BindingList
                listaEstudiantesSeccion.Clear();
                if (arrayEstudiantes != null)  // Comprueba que el arreglo no sea null
                {
                    foreach (UserWS.estudiante estudiante in arrayEstudiantes)
                    {
                        listaEstudiantesSeccion.Add(estudiante);
                    }
                }
                // Asigna la lista al DataGridView
                dgvEstudiantesSeccion.DataSource = listaEstudiantesSeccion;

            }



        }

        private BindingList<UserWS.estudiante> listaEstudiantesGrado = new BindingList<UserWS.estudiante>();

        private void cboGradoAsig_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGradoAsig.SelectedIndex != -1)
            {
                _grado = (InfraWS.grado)cboGradoAsig.SelectedItem;

                // Obtiene el arreglo de estudiantes
                UserWS.estudiante[] arrayEstudiantes = _daoUserWS.listarEstudiantesPorGrado(_grado.idGrado);

                // Convierte el arreglo a BindingList
                listaEstudiantesGrado.Clear();
                if (arrayEstudiantes != null)  // Comprueba que el arreglo no sea null
                {
                    foreach (UserWS.estudiante estudiante in arrayEstudiantes)
                    {
                        listaEstudiantesGrado.Add(estudiante);
                    }
                }

                // Asigna la lista al DataGridView
                dgvEstudiantesGrado.DataSource = listaEstudiantesGrado;

                cboSeccionAsig.DataSource = _daoInfraWs.listarSeccionPorIdGrado(_grado.idGrado);
                cboSeccionAsig.DisplayMember = "nombre";
                cboSeccionAsig.ValueMember = "idSeccion";
            }
        }

        private void dgvEstudiantesGrado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {


            UserWS.estudiante estudiante = (UserWS.estudiante)dgvEstudiantesGrado.Rows[e.RowIndex].DataBoundItem;
            dgvEstudiantesGrado.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString(); 
            dgvEstudiantesGrado.Rows[e.RowIndex].Cells[1].Value = estudiante.nombre + " " + 
                estudiante.apellidoPaterno + " " + estudiante.apellidoMaterno;
            if(estudiante.seccion == null)
            {
                dgvEstudiantesGrado.Rows[e.RowIndex].Cells[2].Value = "";
            }
            else 
            {
                dgvEstudiantesGrado.Rows[e.RowIndex].Cells[2].Value = estudiante.seccion.nombre;
            }
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            establecerEstadoComponentes();
            _seccion = new InfraWS.seccion();
        }

        private void btnNuevoAsig_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarAsig_Click(object sender, EventArgs e)
        {
            int resultadoAsig = 0;
            int resultadoQuit = 0;
            if (listaEstudiantesSeccionAgregar != null)
            {
                foreach (UserWS.estudiante estudiante in listaEstudiantesSeccionAgregar)
                {
                    resultadoAsig = _daoUserWS.asignarSeccionAEstudiante(estudiante.idEstudiante, _seccionEst.idSeccion);
                }
                listaEstudiantesSeccionAgregar.Clear(); 
            }
            if (listaEstudiantesSeccionQuitar != null)
            {
                foreach (UserWS.estudiante estudiante in listaEstudiantesSeccionQuitar)
                {
                    resultadoQuit = _daoUserWS.quitarSeccionDeEstudiante(estudiante.idEstudiante);
                }
                listaEstudiantesSeccionQuitar.Clear();
            }

            listaEstudiantesSeccion.Clear();

            if (resultadoAsig != 0 || resultadoQuit != 0)
            {
                MessageBox.Show("Se ha registrado con éxito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //_estado = Estado.Inicial;
                establecerEstadoComponentes();
            }
            else
                MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int resultado = 0;

            if (_grado.idGrado == 1) _grado.nivel = InfraWS.nivelEducativo.Primaria;
            else if (_grado.idGrado == 2) _grado.nivel = InfraWS.nivelEducativo.Primaria;
            else if (_grado.idGrado == 3) _grado.nivel = InfraWS.nivelEducativo.Primaria;
            else if (_grado.idGrado == 4) _grado.nivel = InfraWS.nivelEducativo.Primaria;
            else if (_grado.idGrado == 5) _grado.nivel = InfraWS.nivelEducativo.Primaria;
            else if (_grado.idGrado == 6) _grado.nivel = InfraWS.nivelEducativo.Primaria;
            else if (_grado.idGrado == 7) _grado.nivel = InfraWS.nivelEducativo.Secundaria;
            else if (_grado.idGrado == 8) _grado.nivel = InfraWS.nivelEducativo.Secundaria;
            else if (_grado.idGrado == 9) _grado.nivel = InfraWS.nivelEducativo.Secundaria;
            else if (_grado.idGrado == 10) _grado.nivel = InfraWS.nivelEducativo.Secundaria;
            else if (_grado.idGrado == 11) _grado.nivel = InfraWS.nivelEducativo.Secundaria;


            _seccion.grado = _grado;



            if (rbSecA.Checked) _seccion.nombre = "Sec A";
            else if (rbSecB.Checked) _seccion.nombre = "Sec B";
            else if (rbSecC.Checked) _seccion.nombre = "Sec C";
            else if (rbSecD.Checked) _seccion.nombre = "Sec D";

            _seccion.grado.nivelSpecified = true;


            if (_estado == Estado.Nuevo)
            {
                resultado = _daoInfraWs.insertarSeccion(_seccion);
            }

            if (_estado == Estado.Editar)
            {
                resultado = _daoInfraWs.modificarSeccion(_seccion);
            }

            if (resultado != 0)
            {
                MessageBox.Show("Se ha registrado con éxito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdSeccion.Text = this._seccion.idSeccion.ToString();

                _estado = Estado.Inicial;
                establecerEstadoComponentes();
            }
            else
                MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {

            _estado = Estado.Editar;
            establecerEstadoComponentes();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            dgvSecciones.DataSource = _daoInfraWs.listarSeccionesTodos().ToList();
            _estado = Estado.Buscar;
            establecerEstadoComponentes();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            _daoInfraWs.eliminarSeccion(_seccion.idSeccion);


            MessageBox.Show("Se ha eliminado con éxito", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _estado = Estado.Inicial;
            establecerEstadoComponentes();
        }

        private void btnSeleccionar_Click_1(object sender, EventArgs e)
        {
            _seccion = (InfraWS.seccion)dgvSecciones.CurrentRow.DataBoundItem;

            txtIdSeccion.Text = _seccion.idSeccion.ToString();
            if (_seccion.nombre == "Sec A") rbSecA.Checked = true;
            else if (_seccion.nombre == "Sec B") rbSecB.Checked = true;
            else if (_seccion.nombre == "Sec C") rbSecC.Checked = true;
            else if (_seccion.nombre == "Sec D") rbSecD.Checked = true;

            cboGrado.SelectedValue = _seccion.grado.idGrado;



            MemoryStream ms = new MemoryStream(_seccion.imagen);
            pbSeccion.Image = new Bitmap(ms);

            _estado = Estado.Seleccionar;
            establecerEstadoComponentes();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {

            _estado = Estado.Inicial;
            establecerEstadoComponentes();
        }

        private void btnSubir_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ofdSeccion.ShowDialog() == DialogResult.OK)
                {
                    _rutaImagen = ofdSeccion.FileName;
                    pbSeccion.Image = Image.FromFile(_rutaImagen);

                    FileStream fs = new FileStream(_rutaImagen, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    _seccion.imagen = br.ReadBytes((int)fs.Length);
                    fs.Close();

                    MemoryStream ms = new MemoryStream(_seccion.imagen);
                    pbSeccion.Image = new Bitmap(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }

        }

        private void dgvSecciones_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            InfraWS.seccion seccion = (InfraWS.seccion)dgvSecciones.Rows[e.RowIndex].DataBoundItem;
            dgvSecciones.Rows[e.RowIndex].Cells[0].Value = seccion.idSeccion;
            dgvSecciones.Rows[e.RowIndex].Cells[1].Value = seccion.grado.nombre;
            dgvSecciones.Rows[e.RowIndex].Cells[2].Value = seccion.nombre;
            dgvSecciones.Rows[e.RowIndex].Cells[3].Value = seccion.grado.nivel;
        }

        private void cboGrado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboGrado.SelectedIndex != -1)
            {
                _grado = (InfraWS.grado)cboGrado.SelectedItem;
            }
        }

        private void dgvEstudiantesSeccion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            UserWS.estudiante estudiante = (UserWS.estudiante)dgvEstudiantesSeccion.Rows[e.RowIndex].DataBoundItem;
            dgvEstudiantesSeccion.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
            
            if (dgvEstudiantesSeccion.Columns.Count > 1) // Asegúrate de que haya al menos 2 columnas
            {
                dgvEstudiantesSeccion.Rows[e.RowIndex].Cells[1].Value = estudiante.nombre + " " +
                                estudiante.apellidoPaterno + " " + estudiante.apellidoMaterno;
            }

        }

        private void dgvEstudiantesGrado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _estudianteGradoSeleccionado = (UserWS.estudiante)dgvEstudiantesGrado.Rows[e.RowIndex].DataBoundItem;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (_estudianteGradoSeleccionado != null)
            {
                listaEstudiantesSeccion.Add(_estudianteGradoSeleccionado);
                if (_estudianteGradoSeleccionado.seccion == null)
                    listaEstudiantesSeccionAgregar.Add(_estudianteGradoSeleccionado);
                else
                    listaEstudiantesSeccionQuitar.Add(_estudianteGradoSeleccionado);

                dgvEstudiantesSeccion.DataSource = null; // Puede que necesites resetear el DataSource
                dgvEstudiantesSeccion.DataSource = listaEstudiantesSeccion; // Vuelve a asignar listaProgramas a DataSource
                _estudianteGradoSeleccionado = null;
                

            }
            else
            {
                // Mostrar mensaje de error o hacer algo más si _proAcad es null
                MessageBox.Show("No se seleccionó ningún programa académico válido");
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (_estudianteSeccionSeleccionado != null)
            {
                listaEstudiantesSeccion.Remove(_estudianteSeccionSeleccionado);
                listaEstudiantesSeccionQuitar.Add(_estudianteSeccionSeleccionado);
                
                dgvEstudiantesSeccion.DataSource = null; // Puede que necesites resetear el DataSource
                dgvEstudiantesSeccion.DataSource = listaEstudiantesSeccion; // Vuelve a asignar listaProgramas a DataSource
                
                _estudianteSeccionSeleccionado = null;


            }
            else
            {
                // Mostrar mensaje de error o hacer algo más si _proAcad es null
                MessageBox.Show("No se seleccionó ningún programa académico válido");
            }

        }

        private void dgvEstudiantesSeccion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _estudianteSeccionSeleccionado = (UserWS.estudiante)dgvEstudiantesSeccion.Rows[e.RowIndex].DataBoundItem;
            }
        }
    }
}
