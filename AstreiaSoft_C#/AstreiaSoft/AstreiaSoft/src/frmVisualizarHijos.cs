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
using WindowsFormsApp1;

namespace AstreiaSoft
{

    public partial class frmVisualizarHijos : Form
    {
        private UserWSClient _daoUserWS;
        private UserWS.padreFamilia _padFam;
        private UserWS.estudiante _estudiante;
        private UserWS.usuario _usuario;
        private InfraWSClient _daoInfraWS;

        public frmVisualizarHijos(int idUsuario)
        {
            InitializeComponent();

            cmbHijos.SelectedIndex = -1;
            txtNombre.Enabled = false;
            txtGradoSeccion.Enabled = false;

            _daoUserWS = new UserWSClient();
            _daoInfraWS = new InfraWSClient();
            _padFam = new UserWS.padreFamilia();
            _padFam.idUsuario = idUsuario;
            _estudiante = new UserWS.estudiante();

            //var hijos = _daoUserWS.listarEstudiantesPorPadreFamilia(_padFam);

            cmbHijos.DataSource = _daoUserWS.listarEstudiantesPorPadreFamilia(_padFam);
            cmbHijos.DisplayMember = "nombreCompleto";
            cmbHijos.ValueMember = "IdUsuario";
            // Modificar el DataSource para incluir la concatenación temporal de nombres.
            //cmbHijos.DataSource = hijos.Select(estudiante => new
            //{
            //    IdUsuario = estudiante.idUsuario,
            //    GradoEstudiante = estudiante.grado.nombre,
            //    NombreCompletoTemporal = $"{estudiante.nombre} {estudiante.apellidoPaterno} {estudiante.apellidoMaterno}"
            //}).ToList();

        }


        public void mostrarFormulario(Form form)
        {
            panelContenido.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            panelContenido.Controls.Add(form);
            form.Visible = true;
        }

        

        private void btnCalificaciones_Click(object sender, EventArgs e)
        {
            //Se envia el id del estudiante
            //frmGestEntregasAlumno formTareas = new frmGestEntregasAlumno(_estudiante.idUsuario);
            //mostrarFormulario(formTareas);
        }

        private void cmbHijos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHijos.SelectedItem != null)
            {
                UserWS.estudiante estudianteSeleccionado = (dynamic)cmbHijos.SelectedItem;
                                
                txtNombre.Text = estudianteSeleccionado.nombreCompleto;
                if(estudianteSeleccionado.grado.idGrado != 0)
                {
                    txtGradoSeccion.Text = _daoUserWS.obtenerNombreGradoSeccion(estudianteSeleccionado.grado.idGrado, estudianteSeleccionado.seccion.idSeccion);
                    //txtGradoSeccion.Text = estudianteSeleccionado.grado.nombreCompleto;
                }
                else
                {
                    txtGradoSeccion.Text = "";
                    MessageBox.Show("Estudiante no cuenta con grado asignado", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


                //selccion del estudiante
                _estudiante = estudianteSeleccionado;
            }
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            //mostrar la asistencia del hijo
        }

        private void panelContenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            try
            {
                UserWS.usuario usuario = _daoUserWS.encontrarUsuario(_estudiante.idEstudiante.ToString());
                // Llamada al servicio web
                byte[] arregloPDF = _daoInfraWS.generarReporteAnualPorAlumno(_estudiante.idEstudiante, usuario.nombre + " "
                                                                   + usuario.apellidoPaterno + " " + usuario.apellidoMaterno);


                // Obtener la ruta de la carpeta de descargas del usuario
                string downloadFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads\";

                // Nombre del archivo
                string fileName = "ReporteAnual_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf";

                // Ruta completa del archivo
                string fullPath = Path.Combine(downloadFolder, fileName);

                // Guardar el PDF
                if (arregloPDF != null)
                {
                    File.WriteAllBytes(fullPath, arregloPDF);
                    MessageBox.Show("Reporte generado con éxito en: " + fullPath);
                }
                else
                {
                    MessageBox.Show("No se pudo generar el reporte.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
