using AstreiaSoft;

using AstreiaSoft.InfraWS;
using AstreiaSoft.MallaWS;
using AstreiaSoft.UserWS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmGestHorario : Form
    {
        private Panel panelContenido;
        private MallaWSClient _daoServicioWeb;
        private InfraWSClient _daoServicioWebInfra;
        private UserWSClient _daoServicioWebUser;
        private horario _horario;
        private AstreiaSoft.InfraWS.seccion seccionSeleccionado;
        private cursoProgramado cursoProSeleccionado;
        private Estado _estado;
        private int idGrado;
        private int idDocente;
        private List<horario> horarios = null;
        private CursoComboItem cursoP;
        private Button lastSelectedButton = null;
        int cantidadAeliminar = 0;
        private int EsEstudiante =0;

        public frmGestHorario(Panel panelContenido)
        {
            InitializeComponent();

            InicializarComponentes();

            InicializarEventos();

        }

        private void InicializarComponentes()
        {
            establecerEstadoComponentes();
            limpiarComponentes();
            _estado = Estado.Inicial;

            _daoServicioWeb = new MallaWSClient();
            _daoServicioWebInfra = new InfraWSClient();
            _daoServicioWebUser = new UserWSClient();

            ConfigurarComboBoxGrado();
            ConfigurarComboBoxDocente();
            ConfigurarVisibilidadSegunRoles();
        }
        private bool UsuarioTieneRol(string rol)
        {
            return GlobalVariables.Roles.Any(r => r.nombre.ToString() == rol);
        }
        private void ConfigurarVisibilidadSegunRoles()
        {
            
            if (UsuarioTieneRol("Estudiante"))
            {
                btnNuevo.Visible = false;
                btnGuardar.Visible = false;
                btnEditar.Visible = false;
                btnEliminar.Visible = false;
                btnCancelar.Visible = false;

                gbHorario.Visible = false;
                EsEstudiante = 1;
                MostrarHorariosEnFormulario();
                
            }
            
        }

        private void InicializarEventos()
        {
            cboGrado.SelectedIndexChanged += (sender, e) =>
            {
                RestaurarBotonesHorario();
                CambiarGradoSeleccionado();
                ChequearSeleccionParaDocente();

            };    

            cboSeccion.SelectedIndexChanged += (sender, e) =>
            {
                if (cboSeccion.SelectedItem != null)
                {
                    seccionSeleccionado = (AstreiaSoft.InfraWS.seccion)cboSeccion.SelectedItem;
                    RestaurarBotonesHorario();
                    
                    MostrarHorariosEnFormulario();//estado =1 (nuevo), estado=0(editar)
                    
                    
                }
                else
                {
                    seccionSeleccionado = null;
                }
                ChequearSeleccionParaDocente();
            };

            cboCurso.SelectedIndexChanged += (sender, e) =>
            {
                if (cboCurso.SelectedItem != null)
                {
                    
                    cursoP = (CursoComboItem)cboCurso.SelectedItem;
                    cursoProSeleccionado.idCursoProgramado = cursoP.Id;



                }
            };


            cboDocente.SelectedIndexChanged += (sender, e) =>
            {
                if (cboDocente.SelectedItem != null)
                {

                    idDocente = (int)cboDocente.SelectedValue;
                    if (_estado == Estado.Nuevo)
                    {
                        RestaurarBotonesOcupados();
                        List<horario> horariosExistentes = _daoServicioWeb.listarHorarioPorIdDocente(idDocente)?.ToList();
                        if (horariosExistentes != null)
                        {
                            ActualizarBotonesHorario(horariosExistentes);
                        }
                    }
                    
                    
                }
            };


            foreach (Control control in Controls)
            {
                if (control is Button && EsBotonDeHorario((Button)control))
                {
                    ((Button)control).Click += BotonHorario_Click;
                }
            }
        }

        void ChequearSeleccionParaDocente()
        {
            cboDocente.Enabled = cboGrado.SelectedItem != null && cboSeccion.SelectedItem != null;
        }

        private void ConfigurarComboBoxGrado()
        {
            cboGrado.DataSource = _daoServicioWeb.listarGradosTodos();
            cboGrado.DisplayMember = "nombreCompleto";
            cboGrado.ValueMember = "idGrado";
            idGrado = cboGrado.SelectedIndex;
            
            //cboGrado.SelectedIndexChanged += (sender, e) => CambiarGradoSeleccionado();
        }

        private void CambiarGradoSeleccionado()
        {
            AstreiaSoft.MallaWS.grado gradoSeleccionado = (AstreiaSoft.MallaWS.grado)cboGrado.SelectedItem;

            if (gradoSeleccionado != null)
            {
                cboSeccion.DataSource = _daoServicioWebInfra.listarSeccionPorIdGrado(gradoSeleccionado.idGrado);
                cboSeccion.DisplayMember = "nombre";
                cboSeccion.ValueMember = "idSeccion";
                //cboSeccion.SelectedIndex = -1;

                List<CursoComboItem> cursosCombo = new List<CursoComboItem>();

                var cursosProgramados = _daoServicioWeb.listarCursosPrograGrado(gradoSeleccionado.idGrado);

                if (cursosProgramados != null && cursosProgramados.Length > 0)
                {
                    foreach (var cursoProgramado in cursosProgramados)
                    {
                        string nombreCurso = _daoServicioWeb.obtenerNombreCurso(cursoProgramado.curso.idCurso);

                        if (!string.IsNullOrEmpty(nombreCurso))
                        {
                            cursosCombo.Add(new CursoComboItem { Id = cursoProgramado.idCursoProgramado, Nombre = nombreCurso });
                        }
                    }
                    cboCurso.Enabled = true;
                    cboCurso.DataSource = cursosCombo;
                    cboCurso.DisplayMember = "Nombre";
                    cboCurso.ValueMember = "Id";
                }
                else
                {
                    cboCurso.DataSource = null;
                    cboCurso.Enabled = false;
                    MessageBox.Show("No hay cursos programados para este grado.");
                }

                //cboSeccion.SelectedIndex = -1;
            }
        }

        private void ConfigurarComboBoxDocente()
        {
            cboDocente.DataSource = _daoServicioWebUser.listarTodosDocentesCursos();
            cboDocente.Format += (s, e) => { e.Value = $"{((AstreiaSoft.UserWS.docente)e.ListItem).nombre} {((AstreiaSoft.UserWS.docente)e.ListItem).apellidoPaterno}"; };
            cboDocente.ValueMember = "idusuario";
            idDocente = (int)cboDocente.SelectedValue;
           
        }

        class CursoComboItem
        {
            private int _idCursoP;
            public int Id { get => _idCursoP; set => _idCursoP = value; }
            public string Nombre { get; set; }

            public override string ToString()
            {
                return Nombre; // Esto se usa para mostrar el nombre en el ComboBox.
            }
        }



        public void limpiarComponentes()
        {

            //txtDocenteHorario.Text = "";
            cboCurso.SelectedIndex = -1;
            cboGrado.SelectedIndex = -1;
            cboDocente.SelectedIndex = -1;
            cboSeccion.SelectedIndex = -1;

        }
        
        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnEditar.Enabled = true;

                    cboCurso.Enabled = false;
                    cboGrado.Enabled = false;
                    cboSeccion.Enabled = false;
                    cboDocente.Enabled = false;
                    BloquearBotonesHorarioYDia();
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnEliminar.Enabled = false;
                    btnEditar.Enabled = false;

                    cboCurso.Enabled = true;
                    cboGrado.Enabled = true;
                    cboSeccion.Enabled = true;
                    cboDocente.Enabled = true;
                    DesbloquearBotonesHorarioYDia();
                    break;
                case Estado.Editar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnEliminar.Enabled = false;
                    btnEditar.Enabled = false;

                    cboCurso.Enabled = false;
                    cboGrado.Enabled = true;
                    cboDocente.Enabled = true;
                    cboSeccion.Enabled = true;
                    DesbloquearBotonesHorarioYDia();
                    break;
                case Estado.Eliminar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnEditar.Enabled = false;
                    break;
                case Estado.Guardar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnEditar.Enabled = false;
                    break;
                case Estado.Cancelar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnEditar.Enabled = false;
                    break;
            }
        }


        private void BloquearBotonesHorarioYDia()
        {
            foreach (Control control in Controls)
            {
                if (control is Button && EsBotonDeHorario((Button)control))
                {
                    ((Button)control).Enabled = false;
                }
            }
        }

        private void DesbloquearBotonesHorarioYDia()
        {
            foreach (Control control in Controls)
            {
                if (control is Button && EsBotonDeHorario((Button)control))
                {
                    ((Button)control).Enabled = true;
                }
            }
        }
        private void RestaurarBotonesOcupados()
        {
            foreach (Control control in Controls)
            {
                if (control is Button && EsBotonDeHorario((Button)control))
                {
                    Button boton = (Button)control;
                    if (boton.BackColor != Color.CadetBlue)
                    {
                        boton.BackColor = Color.WhiteSmoke;
                        boton.Text = "";
                        if (_estado == Estado.Nuevo)
                        {
                            boton.Enabled = true;
                        }
                    }
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            establecerEstadoComponentes();
            limpiarComponentes();
            cursoProSeleccionado = new cursoProgramado();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int resultado=0;
            int estudiantesAsociados=0;
            int cursoProDocente = 0;
            if (cboSeccion.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una seccion a dictar en dicho horario. Si no aparecen secciones debe de agregar nuevas en 'Gestionar Seccion' ", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboDocente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Docente a dictar en dicho horario", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            //Si es nuevo:
            if (_estado == Estado.Nuevo)
            {
                if (seccionSeleccionado != null)
                {
                    estudiantesAsociados = _daoServicioWeb.verificarCursoProgramadoEstudiantes(cursoProSeleccionado.idCursoProgramado, seccionSeleccionado.idSeccion);

                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una sección.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (estudiantesAsociados == 0)
                {
                    // 1.Asigno los estudiantes de la seccion a un cursoProgramado
                    int[] arregloIdsEstudiantes = _daoServicioWebInfra.listarEstPorSeccion(seccionSeleccionado.idSeccion);
                    if (arregloIdsEstudiantes == null)
                    {
                        MessageBox.Show("No hay estudiantes en la seccion", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    resultado = _daoServicioWeb.asignarEstudiantesCursoProgramado(cursoProSeleccionado.idCursoProgramado, arregloIdsEstudiantes);
                }
            }

            //2. inserto en la tabla 


            cursoProDocente = _daoServicioWeb.verificarCursoProgramadoDocente(cursoProSeleccionado.idCursoProgramado, idDocente);
            if (cursoProDocente == 0)
            {
                resultado = _daoServicioWeb.asignarDocenteCursoProgramado(cursoProSeleccionado.idCursoProgramado, idDocente);
            }


            int horaInicio, horaFin,idHorarioModificar=0;

            //3. Inserto en la tabla los horarios
            foreach (Control control in Controls)
            {
                if (control is Button && EsBotonDeHorario((Button)control))
                {
                    Button boton = (Button)control;

                    string nombreBoton = boton.Name;
                    string dia = ObtenerDiaDesdeNombre(nombreBoton);
                    ObtenerHoraDesdeNombre(nombreBoton, out horaInicio, out horaFin);
                    
                    _horario = new horario();
                    _horario.seccion = new AstreiaSoft.MallaWS.seccion();
                    _horario.seccion.idSeccion = seccionSeleccionado.idSeccion;
                    _horario.cursoProgramado = new cursoProgramado();
                    _horario.docente = new AstreiaSoft.MallaWS.docente();

                    _horario.cursoProgramado.idCursoProgramado = cursoProSeleccionado.idCursoProgramado;
                    _horario.diaSemana = dia;


                    DateTime horaInicial = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, horaInicio, 0, 0);
                    string horaComoString = horaInicial.ToString("HH:mm");

                    DateTime horaFinal = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, horaFin, 0, 0);
                    string horaFinalComoString = horaFinal.ToString("HH:mm");

                   

                    _horario.horaIni = horaComoString;
                    _horario.horaFin = horaFinalComoString;
                    _horario.docente.idUsuario = idDocente;
                    if (boton.BackColor == Color.Green)
                    {
                         resultado = _daoServicioWeb.insertarHorario(_horario);
                        
                    }
                    else if(boton.BackColor == Color.Red)
                    {
                        idHorarioModificar = ObtenerIdHorario(horarios, dia, horaComoString, horaFinalComoString);
                        //Console.WriteLine("idHorarioModificar: " + idHorarioModificar);
                        _horario.idHorario = idHorarioModificar;
                        resultado = _daoServicioWeb.modificarHorario(_horario);
                    }
                }
            }

            if (resultado > 0)
            {
                if (_estado == Estado.Nuevo)
                {
                    MessageBox.Show("Se ha registrado con éxito", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (_estado == Estado.Editar)
                {
                    MessageBox.Show("Se ha modificado con éxito", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                if (_estado == Estado.Nuevo)
                {
                    MessageBox.Show("No se ha registrado con éxito", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (_estado == Estado.Editar)
                {
                    MessageBox.Show("No se ha modificado con éxito", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
            RestaurarBotonesHorario();
        }

        private void RestaurarBotonesHorario()
        {
            foreach (Control control in Controls)
            {
                if (control is Button && EsBotonDeHorario((Button)control))
                {
                    Button boton = (Button)control;
                    boton.BackColor = Color.WhiteSmoke;
                    boton.Text = "";
                }
            }
        }
        
        private void MostrarHorariosEnFormulario()
        {
            int horaInicio, horaFin;
            // Obtener los horarios de la base de datos para la sección seleccionada

            int idSeccionUsu=-1;
            if (EsEstudiante == 1)
            {
                //obtener seccion
                
                idSeccionUsu = _daoServicioWebUser.obtenerSeccion(GlobalVariables.IdUsuario);
                Console.WriteLine(idSeccionUsu);
                Console.WriteLine(GlobalVariables.IdUsuario);
                horarios = _daoServicioWeb.listarHorarioPorSeccion(idSeccionUsu)?.ToList();

            }
            else
            {
                horarios = _daoServicioWeb.listarHorarioPorSeccion(seccionSeleccionado.idSeccion)?.ToList();

            }


            if (horarios != null)
            {
                foreach (Control control in Controls)
                {
                    if (control is Button && EsBotonDeHorario((Button)control))
                    {
                        Button boton = (Button)control;
                        string nombreBoton = boton.Name;
                        string dia = ObtenerDiaDesdeNombre(nombreBoton);
                        ObtenerHoraDesdeNombre(nombreBoton, out horaInicio, out horaFin);

                        DateTime horaInicial = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, horaInicio, 0, 0);
                        string horaComoString = horaInicial.ToString("HH:mm");

                        DateTime horaFinal = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, horaFin, 0, 0);
                        string horaFinalComoString = horaFinal.ToString("HH:mm");

                        int idHor = ObtenerIdHorario(horarios, dia, horaComoString, horaFinalComoString);
                        
                        // Si se encuentra un horario en la base de datos, colorear el botón en rojo
                        if (idHor > -1)
                        {
                            string nombreCurso = _daoServicioWeb.obtenerNombreCursoHorario(idHor);
                            string nombreDocente = _daoServicioWeb.obtenerNombreDocenteHorario(idHor);

                            boton.BackColor = Color.CadetBlue;
                            boton.Text = $"{nombreCurso} - {nombreDocente}";
                            if (_estado==Estado.Nuevo)
                            {
                                boton.Enabled= false; 
                            }else if (_estado == Estado.Editar)
                            {
                                boton.Enabled = true;
                            }
                        }
                        else
                        {
                            boton.BackColor = Color.WhiteSmoke; 
                            if (_estado == Estado.Editar)
                            {
                                boton.Enabled = false;
                            }
                        }
                    }
                    
                }
            }
            else
            {
                if (_estado == Estado.Nuevo)//ver
                {
                    DesbloquearBotonesHorarioYDia();
                }
                else //editar
                {
                    BloquearBotonesHorarioYDia();
                }
            }


        }

        private int ObtenerIdHorario(List<horario> horarios, string dia, string horaIni, string horaFin)
        {
            foreach (var horario in horarios)
            {
                if (horario.diaSemana == dia && horario.horaIni == horaIni && horario.horaFin == horaFin)
                {
                    return horario.idHorario;
                }
            }

            return -1; 
        }

        

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cantidadAeliminar = 0;
            int horaInicio, horaFin,resultado=0;
            foreach (Control control in Controls)
            {
                if (control is Button && EsBotonDeHorario((Button)control))
                {
                    Button boton = (Button)control;
                    if (boton.BackColor == Color.Red)
                    {

                        string nombreBoton = boton.Name;
                        string dia = ObtenerDiaDesdeNombre(nombreBoton);
                        ObtenerHoraDesdeNombre(nombreBoton, out horaInicio, out horaFin);

                        DateTime horaInicial = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, horaInicio, 0, 0);
                        string horaComoString = horaInicial.ToString("HH:mm");

                        DateTime horaFinal = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, horaFin, 0, 0);
                        string horaFinalComoString = horaFinal.ToString("HH:mm");

                        int idHor = ObtenerIdHorario(horarios, dia, horaComoString, horaFinalComoString);
                        resultado = _daoServicioWeb.eliminarHorarioCursDocente(idHor);
                        resultado = _daoServicioWeb.eliminarHorarioCursEstudiante(idHor);
                        resultado = _daoServicioWeb.eliminarHorario(idHor);
                        boton.BackColor =Color.WhiteSmoke;
                        boton.Text = "";
                    }
                }
            }
            if (resultado == 1)
            {
                MessageBox.Show("Se ha eliminado con éxito", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _estado = Estado.Inicial;
                establecerEstadoComponentes();
            }
            else
            {
                MessageBox.Show("No se ha/n eliminado con éxito", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
            limpiarComponentes();
        }

        private void BotonHorario_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (clickedButton.BackColor == Color.CadetBlue)
            {
                clickedButton.BackColor = Color.Red;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = true;
                cboGrado.Enabled = false;
                cboSeccion.Enabled = false;
                cboCurso.Enabled = false;
                cantidadAeliminar++;
                
            }else if(clickedButton.BackColor == Color.Red){
                cantidadAeliminar--;
                clickedButton.BackColor = Color.CadetBlue;
                if (cantidadAeliminar == 0)
                {
                    btnEliminar.Enabled = false;
                    btnGuardar.Enabled= false;
                    cboGrado.Enabled = true;
                    cboSeccion.Enabled = true;
                    cboCurso.Enabled = true;
                }
                
            }
            else if (clickedButton.BackColor == Color.Green)
            {
                clickedButton.BackColor = Color.WhiteSmoke;
            }
            else
            {
                clickedButton.BackColor = Color.Green;
            }
        }

        private bool EsBotonDeHorario(Button boton)
        {
            // determinar si el botón es parte del horario
            
            return boton.Name.StartsWith("btn_"); 
        }

        private string ObtenerDiaDesdeNombre(string nombreBoton)
        {
           
            Dictionary<string, string> mapeoDias = new Dictionary<string, string>
            {
                { "L", "Lunes" },
                { "M", "Martes" },
                { "X", "Miercoles" },
                { "J", "Jueves" },
                { "V", "Viernes" },
                
            };

            // "btn_[DIA]_[HORA1]_[HORA2]"
            
            string[] partes = nombreBoton.Split('_');

            if (partes.Length >= 2)
            {
                // El segundo elemento (índice 1) debería contener la abreviatura del día
                string abreviaturaDia = partes[1];

                //  obtener el nombre completo del día a partir de la abreviatura
                if (mapeoDias.ContainsKey(abreviaturaDia))
                {
                    string diaCompleto = mapeoDias[abreviaturaDia];
                    return diaCompleto;
                }
            }

            
            return "Día Desconocido";
        }

        private void ObtenerHoraDesdeNombre(string nombreBoton, out int horaInicio, out int horaFin)
        {
            // "btn_[DIA]_[HORA1]_[HORA2]"
            
            string[] partes = nombreBoton.Split('_');

            horaInicio = 0;
            horaFin = 0;

            if (partes.Length >= 4)
            {
                // Los elementos 2 y 3 (índices 2 y 3) deberían contener las horas
                horaInicio = int.Parse(partes[2]);
                horaFin = int.Parse(partes[3]);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Editar;
            limpiarComponentes();
            establecerEstadoComponentes();
            cursoProSeleccionado = new cursoProgramado();
        }

        private void ActualizarBotonesHorario(List<horario> horariosExistentes)
        {
            int horaInicio, horaFin;
            foreach (Control control in Controls)
            {
                if (control is Button botonHorario && EsBotonDeHorario(botonHorario))
                {

                    string nombreBoton = botonHorario.Name;
                    string dia = ObtenerDiaDesdeNombre(nombreBoton);
                    ObtenerHoraDesdeNombre(nombreBoton, out horaInicio, out horaFin);

                    horario horarioPropuesto = new horario();
                    horarioPropuesto.seccion = new AstreiaSoft.MallaWS.seccion();
                    horarioPropuesto.seccion.idSeccion = seccionSeleccionado.idSeccion;
                    horarioPropuesto.cursoProgramado = new cursoProgramado();
                    horarioPropuesto.docente = new AstreiaSoft.MallaWS.docente();

                    horarioPropuesto.cursoProgramado.idCursoProgramado = cursoProSeleccionado.idCursoProgramado;
                    horarioPropuesto.diaSemana = dia;


                    DateTime horaInicial = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, horaInicio, 0, 0);
                    string horaComoString = horaInicial.ToString("HH:mm");

                    DateTime horaFinal = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, horaFin, 0, 0);
                    string horaFinalComoString = horaFinal.ToString("HH:mm");

                    horarioPropuesto.horaIni = horaComoString;
                    horarioPropuesto.horaFin = horaFinalComoString;
                    horarioPropuesto.docente.idUsuario = idDocente;


                    if (botonHorario.BackColor==Color.WhiteSmoke && !EsHorarioDisponible(horarioPropuesto, horariosExistentes))
                    {
                        // Marcar el botón como no disponible
                        botonHorario.BackColor = Color.Pink;
                        botonHorario.Enabled = false;
                        botonHorario.Text = "Docente no disponible"; 
                        //toolTip.SetToolTip(botonHorario, "Docente no disponible en este horario.");
                    }
                }
            }
        }

        private bool EsHorarioDisponible(horario horarioPropuesto, List<horario> horariosExistentes)
        {
            

            foreach (var horarioExistente in horariosExistentes)
            {
                

                if (horarioPropuesto.diaSemana == horarioExistente.diaSemana &&
                    horarioPropuesto.horaIni == horarioExistente.horaIni &&
                    horarioPropuesto.horaFin == horarioExistente.horaFin)
                {
                    Console.WriteLine($"ID: {horarioExistente.idHorario}, Día: {horarioExistente.diaSemana}, Hora de inicio: {horarioExistente.horaIni}, Hora de fin: {horarioExistente.horaFin}");
                    Console.WriteLine($"ID: {horarioPropuesto.idHorario}, Día: {horarioPropuesto.diaSemana}, Hora de inicio: {horarioPropuesto.horaIni}, Hora de fin: {horarioPropuesto.horaFin}");

                    return false;
                }
            }
            // No hay conflictos, el horario está disponible
            return true;
        }
    }
}
