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

namespace AstreiaSoft
{
    public partial class frmNotasUnEstudiante : Form
    {
        public evaluacionConEntrega[] EvaluacionesConEntregaDisponibles;
        public evaluacionConEntrega EvaluacionConEntregaSeleccionada;

        public delegate void EvaluacionConEntregaSeleccionadoHandler(evaluacionConEntrega evaluacionConEntregaSeleccionada);
        public event EvaluacionConEntregaSeleccionadoHandler OnEvaluacionConEntregaSeleccionado;


        public notaEvaluacion[] NotasDisponibles;
        public notaEvaluacion NotaDisponibleSeleccionada;

        public delegate void NotaDisponibleSeleccionadaHandler(notaEvaluacion notaEvaluacionSeleccionada);
        public event NotaDisponibleSeleccionadaHandler OnNotaDisponibleSeleccionada;


        private Panel panelContenido;
        private int idCurso;
        private Form _formPadre;
        private EvalWSClient _daoEvalWS;

        private BindingList<notaEvaluacion> notas;

        public frmNotasUnEstudiante(int idCurso)
        {
            InitializeComponent();
            this.idCurso = idCurso;
            _daoEvalWS = new EvalWSClient();
            dgvNotasEstudiante.AutoGenerateColumns = false;
            notas = new BindingList<notaEvaluacion>();
        }
        public frmNotasUnEstudiante()
        {
            InitializeComponent();
            _daoEvalWS = new EvalWSClient();
            dgvNotasEstudiante.AutoGenerateColumns = false;
            notas = new BindingList<notaEvaluacion>();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //notas = _daoEvalWS.listarNotaEvaluacion();
            //dgvNotasEstudiante.DataSource = _daoEvalWS.listarNotaEvaluacion(); ;


            try
            {
                EvalWSClient client = new EvalWSClient();
                //int idUsuario = GlobalVariables.IdUsuario;


                NotasDisponibles = client.listarNotaEvaluacion();

                
                dgvNotasEstudiante.Rows.Clear();

                if (NotasDisponibles != null)
                {
                    foreach (var item in NotasDisponibles)
                    {
                        dgvNotasEstudiante.Rows.Add(
                            item.idNotaEvaluacion,
                            item.fecha,
                            item.puntajeObtenido,
                            item.detalle
                        );
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron notas  disponibles con los criterios especificados.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al buscar las notas: " + ex.Message);
            }





        }

        //private void dgvNotasEstudiante_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    notaEvaluacion nota = (notaEvaluacion)dgvNotasEstudiante.Rows[e.RowIndex].DataBoundItem;
        //    dgvNotasEstudiante.Rows[e.RowIndex].Cells[0].Value = nota.idNotaEvaluacion;
        //    dgvNotasEstudiante.Rows[e.RowIndex].Cells[1].Value = nota.fecha;
        //    dgvNotasEstudiante.Rows[e.RowIndex].Cells[3].Value = nota.puntajeObtenido;
        //}


        private void button1_Click(object sender, EventArgs e)
        {

            if (dgvNotasEstudiante.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvNotasEstudiante.SelectedRows[0].Index;
                NotaDisponibleSeleccionada = NotasDisponibles[selectedIndex];
                this.Close();
                OnNotaDisponibleSeleccionada?.Invoke(NotaDisponibleSeleccionada);

                frmReclamoAlumno formReclaAlum = new frmReclamoAlumno(0, NotaDisponibleSeleccionada.idNotaEvaluacion);
                formReclaAlum.ShowDialog();
                //mostrarFormulario(formReclaAlum);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una evaluacion.");
            }



        }

        //    try
        //    {
        //        // Crear instancia del cliente web service.
        //        EvalWSClient client = new EvalWSClient();

        //        // Obtener el ID del usuario actual, reemplaza esto con el código correspondiente.
        //        int idUsuario = GlobalVariables.IdUsuario;

        //        // Llamar al método del web service y obtener las evaluaciones con entregas y última nota.
        // //       EvaluacionesConEntregaDisponibles = client.listarEvaluacionesConEntregasYUltimaNota(idCurso, idUsuario);



        //        dgvNotasEstudiante.DataSource = _daoEval.listarNotaEvaluacion();


        //        // Asume que tienes un DataGridView dgvEvaluaciones para mostrar los resultados.
        //        dgvNotasEstudiante.Rows.Clear();

        //        if (EvaluacionesConEntregaDisponibles != null)
        //        {
        //            foreach (var item in EvaluacionesConEntregaDisponibles)
        //            {
        //                string puntaje = item.notaEvaluacion != null ? item.notaEvaluacion.puntajeObtenido.ToString() : "-";
        //                string estado = item.entrega != null ? item.entrega.estado.ToString() : "Sin Entregar";

        //                dgvNotasEstudiante.Rows.Add(
        //                    item.evaluacion.idEvaluacion,
        //                    item.evaluacion.nombre,
        //                    item.evaluacion.tipo,
        //                    item.evaluacion.fechaSubido,
        //                    item.evaluacion.fechaLimite,
        //                    estado,
        //                    puntaje
        //                );
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("No se encontraron evaluaciones disponibles con los criterios especificados.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Ocurrio un error al buscar las evaluaciones: " + ex.Message);
        //    }
    }
        
}
