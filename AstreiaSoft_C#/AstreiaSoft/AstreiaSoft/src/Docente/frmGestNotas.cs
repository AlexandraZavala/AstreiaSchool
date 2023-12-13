using AstreiaSoft.EvalWS;
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

namespace AstreiaSoft.src.Docente
{
    public partial class frmGestNotas : Form
    {
        Panel panel;
        Form formPadre;
        evaluacion evaluacion;
        notaEvaluacion notaEvaluacion;
        private Estado _estado;
        private CheckBox cbxOrig;
        private string notaOrig;

        public frmGestNotas(Panel pnlContenido, Form formPadre, evaluacion evaluacion, notaEvaluacion notaEv)
        {
            this.panel= pnlContenido;
            this.formPadre= formPadre;
            this.evaluacion= evaluacion;
            this.notaEvaluacion= notaEv;
            InitializeComponent();
            LlenarFormulario();
            cbxOrig = cbxAnularEntrega;
            notaOrig = txtNotaEntrega.Text;
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    btnGuardar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    txtNotaEntrega.Enabled = false;
                    cbxAnularEntrega.Enabled = false;
                    txtObservacionesNota.Enabled = false;
                    break;
                case Estado.Editar:
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    txtNotaEntrega.Enabled = true;
                    cbxAnularEntrega.Enabled = true;
                    txtObservacionesNota.Enabled = true;
                    break;
            }
        }

        private void LlenarFormulario()
        {
            // Evaluación
            nombreEval.Text = evaluacion.nombre;
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Value = evaluacion.fechaSubido;
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Value = evaluacion.fechaLimite;
            txtTipoEvaluacion.Text = evaluacion.tipo.ToString();

            cbxAnularEntrega.Checked = notaEvaluacion.entrega.estado == estadoEntrega.Anulado;

            // Entrega
            txtIDEntrega.Text = notaEvaluacion.entrega.idEntrega.ToString();
            txtEstadoEntrega.Text = notaEvaluacion.entrega.estado.ToString();
            txtObservacionesEntrega.Text = notaEvaluacion.entrega.observaciones;

            // Mostrar imagen de la entrega si está disponible
            if (notaEvaluacion.entrega.archivo != null && notaEvaluacion.entrega.archivo.Length > 0)
            {
                using (var ms = new MemoryStream(notaEvaluacion.entrega.archivo))
                {
                    pbFoto.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pbFoto.Image = null; // Si no hay imagen, limpia el PictureBox
            }

            // Nota Evaluación - Verifica si notaEvaluacion es null antes de acceder a sus miembros
            if (notaEvaluacion.idNotaEvaluacion > 0)
            {
                txtNotaEntrega.Text = notaEvaluacion.puntajeObtenido.ToString();
                txtObservacionesNota.Text = notaEvaluacion.detalle;
            }
            else
            {
                txtNotaEntrega.Text = ""; // O podrías poner un texto predeterminado o dejarlo en blanco
                txtObservacionesNota.Text = "";
            }

            // Fecha de Revisión - Verifica si fechaRevision es una fecha válida
            if (notaEvaluacion.entrega.fechaRevision != default(DateTime) && notaEvaluacion.entrega.fechaRevision > dtpFechaRevision.MinDate && notaEvaluacion.entrega.fechaRevision < dtpFechaRevision.MaxDate)
            {
                dtpFechaRevision.Format = DateTimePickerFormat.Short;
                dtpFechaRevision.Value = notaEvaluacion.entrega.fechaRevision;
            }
            else
            {
                // Si la fecha es null o está fuera de rango, se muestra el control vacío
                dtpFechaRevision.CustomFormat = " "; // Esto hará que el control se muestre vacío
                dtpFechaRevision.Format = DateTimePickerFormat.Custom;
            }
        }


        private void txtNotaEntrega_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEstadoEntrega_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            panel.Controls.Clear();
            panel.Controls.Add(formPadre);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear un objeto de tipo NotaEvaluacion para enviar al método de actualización
                //notaEvaluacion notaEvaluacion = new notaEvaluacion();
                //notaEvaluacion.entrega = this.notaEvaluacion;
                notaEvaluacion.detalle = txtObservacionesNota.Text;

                // Si el checkbox está marcado, establecer el estado de la entrega como ANULADO
                if (cbxAnularEntrega.Checked)
                {
                    this.notaEvaluacion.entrega.estado = estadoEntrega.Anulado;
                    // En caso de anulación, podrías decidir si se debe eliminar la nota existente o dejarla como está
                    // Por ejemplo, aquí simplemente se establece la nota en 0
                    notaEvaluacion.puntajeObtenido = 0;
                }
                else
                {
                    this.notaEvaluacion.entrega.estado = estadoEntrega.Completado;
                    // Asumiendo que txtNotaEntrega es un TextBox donde el usuario ingresa la nota
                    if (!int.TryParse(txtNotaEntrega.Text, out int nota))
                    {
                        MessageBox.Show("La nota ingresada no es un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (nota < 0 || nota > 20) // Asumiendo que las notas están en el rango de 0 a 20
                    {
                        MessageBox.Show("La nota ingresada está fuera del rango permitido (0-20).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    notaEvaluacion.puntajeObtenido = nota;
                }

                // Llamar al método web service para actualizar la entrega y la nota
                EvalWSClient client = new EvalWSClient();
                int resultado = client.modificarEntregaYNota(notaEvaluacion);

                if (resultado > 0)
                {
                    MessageBox.Show("La entrega ha sido actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    establecerEstadoComponentes();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la entrega.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Editar;
            establecerEstadoComponentes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
            cbxAnularEntrega = cbxOrig;
            txtNotaEntrega.Text = notaOrig;
        }

        private void cbxAnularEntrega_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAnularEntrega.Checked == true)
            {
                txtNotaEntrega.Text = "0";
                txtObservacionesNota.Text = "PLAGIO";
            }
            else
            {
                txtNotaEntrega.Text = "";
                txtObservacionesEntrega.Text = "";
            }
        }
    }
}
