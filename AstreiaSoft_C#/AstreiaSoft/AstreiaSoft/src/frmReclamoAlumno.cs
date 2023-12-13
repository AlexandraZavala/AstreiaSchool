using AstreiaSoft.EvalWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AstreiaSoft
{
    public partial class frmReclamoAlumno : Form
    {
        private Panel panelContenido;
        private EvalWSClient _daoEvalWS;
        private reclamoCalificacion _reclamo;
        private estadoEntrega estadito;
        private int idNota;
        public frmReclamoAlumno(Panel panelContenido)
        {
            InitializeComponent();
            //this.panelContenido = panelContenido;
            dtpFechaReclamo.ShowUpDown = true;
            dtpFechaReclamo.Enabled = false;
            _daoEvalWS = new EvalWSClient();
            _reclamo = new reclamoCalificacion();
        }

        //falta id de nota
        public frmReclamoAlumno(int tipo, int _idNota)
        {
            InitializeComponent();
            
            //this.panelContenido = panelContenido;
            dtpFechaReclamo.ShowUpDown = true;
            dtpFechaReclamo.Enabled = false;
            _daoEvalWS = new EvalWSClient();
            _reclamo = new reclamoCalificacion();
            idNota = _idNota;
            if (tipo == 0) //Alumno
            {
                dtpFechaReclamo.Value = DateTime.Now;
                dtpFechaReclamo.Enabled = false;
                gboRespuesta.Enabled = false;
                cboEstadoReclamo.Enabled = false;
            }
            else if (tipo == 1) //Profesor
                                {
                dtpFechaRespuesta.Value = DateTime.Now;
                dtpFechaReclamo.Enabled = false;
                gboReclamo.Enabled = false;
                cboEstadoReclamo.Enabled = true;
                foreach (var item in Enum.GetValues(typeof(estadoEntrega)))
                {
                    cboEstadoReclamo.Items.Add(item);
                }
                cboEstadoReclamo.DisplayMember = "nombreCompleto";
                cboEstadoReclamo.ValueMember = "IdUsuario";
            }
        }

        //Solo para el docente
        public frmReclamoAlumno(int tipo)
        {
            InitializeComponent();

            //this.panelContenido = panelContenido;
            dtpFechaReclamo.ShowUpDown = true;
            dtpFechaReclamo.Enabled = false;
            _daoEvalWS = new EvalWSClient();
            _reclamo = new reclamoCalificacion();
            if (tipo == 0) //Alumno
            {
                dtpFechaReclamo.Value = DateTime.Now;
                dtpFechaReclamo.Enabled = false;
                gboRespuesta.Enabled = false;
                cboEstadoReclamo.Enabled = false;
            }
            else if (tipo == 1) //Profesor
            {
                dtpFechaRespuesta.Value = DateTime.Now;
                dtpFechaReclamo.Enabled = false;
                gboReclamo.Enabled = false;
                cboEstadoReclamo.Enabled = true;
                foreach (var item in Enum.GetValues(typeof(estadoEntrega)))
                {
                    cboEstadoReclamo.Items.Add(item);
                }
                cboEstadoReclamo.DisplayMember = "nombreCompleto";
                cboEstadoReclamo.ValueMember = "IdUsuario";
            }
        }

        private void btnEnviarReclamo_Click(object sender, EventArgs e)
        {
            if (txtArgumentacion.Text.Length == 0)
            {
                // El texto está vacío
                MessageBox.Show("Debe ingresar el argumento", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _reclamo.fechaReclamo = DateTime.Now;
            _reclamo.fechaReclamoSpecified = true;
            _reclamo.descripcion = txtArgumentacion.Text;
            //_reclamo.estado = new estadoEntrega();
            //_reclamo.estado = estadoEntrega.POR_CALIFICAR;

            _reclamo.nota = new notaEvaluacion();
            _reclamo.nota.idNotaEvaluacion = idNota;
            _reclamo.fechaRespuesta = DateTime.Now;
            _reclamo.fechaRespuestaSpecified = true;
            _reclamo.respuesta = "";
            //falta poner el id de la nota
            int resultado = _daoEvalWS.insertarReclamoCalificacion(_reclamo);
            if(resultado != 0)
            {
                MessageBox.Show("El reclamo fue enviado exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo un error en el registro del reclamo", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //profesor
        private void btnGuardarRespuesta_Click(object sender, EventArgs e)
        {
            if (txtArgumentacion.Text.Length == 0)
            {
                // El texto está vacío
                MessageBox.Show("Debe ingresar el argumento", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboEstadoReclamo.SelectedItem == null)
            {
                // No se ha seleccionado ningún elemento
                MessageBox.Show("Debe seleccionar un elemento de estado", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _reclamo.fechaRespuesta = DateTime.Now;
            _reclamo.fechaRespuestaSpecified = true;
            _reclamo.respuesta = txtArgumentacion.Text;

            estadoEntrega estadoSeleccionando = (dynamic)cboEstadoReclamo.SelectedItem;
            _reclamo.estado = estadoSeleccionando;


            //en este caso se modifica el id que ya existe
            //el id de la nota se queda
            int resultado = _daoEvalWS.modificarReclamoCalificacion(_reclamo);
            if(resultado != 0)
            {
                MessageBox.Show("La respuesta al reclamo ha sido registrada exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo un error en el registro del reclamo", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cboEstadoReclamo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
