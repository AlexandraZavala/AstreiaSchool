using AstreiaSoft.AdminWS;
using AstreiaSoft.Evento;
using AstreiaSoft.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AstreiaSoft
{
    public partial class frmEventosEstudiante : Form
    {

        public frmEventosEstudiante()
        {
            InitializeComponent();
        }

        private void AgregarEventoAPanel(evento eventoActual, Panel panelDestino, int indice, bool esNuevoEvento)
        {
            int margen = 40;
            int eventosPorFila = 2; // Cambiado a 2 columnas
            int xOffset = (panelDestino.Width - 3 * margen) / eventosPorFila; // Ajustado para 2 columnas
            int yOffset = 160;

            UserControl controlEvento;

            if (esNuevoEvento)
            {
                ucEventoNuevo nuevoEvento = new ucEventoNuevo();
                nuevoEvento.EstudianteInscrito += NuevoEvento_EstudianteInscrito;
                nuevoEvento.EventoData = eventoActual;
                controlEvento = nuevoEvento;
            }
            else
            {
                ucEvento eventoInscrito = new ucEvento();
                eventoInscrito.EstudianteDesuscrito += MisEventos_EstudianteDesuscrito;
                eventoInscrito.EventoData = eventoActual;
                controlEvento = eventoInscrito;
            }

            int fila = indice / eventosPorFila;
            int columna = indice % eventosPorFila;

            int xPosition = margen + columna * (xOffset + margen);
            int yPosition = 60 + fila * (controlEvento.Height + margen);

            controlEvento.Location = new Point(xPosition, yPosition);
            panelDestino.Controls.Add(controlEvento);
        }


        private bool IsMensajePresente(Panel panel)
        {
            return panel.Controls.OfType<ucMensajeEventos>().Any();
        }


        private void MisEventos_EstudianteDesuscrito(object sender, EventArgs e)
        {
            // Convertir el sender en un ucEvento
            ucEvento eventoDesuscrito = sender as ucEvento;

            // Remover el evento del panel Descubrir
            pnlMisEventos.Controls.Remove(eventoDesuscrito);

            evento eventoActual = eventoDesuscrito.EventoData;

            // Asumiendo que ya tienes el número total de eventos en Mis Eventos
            int indice = pnlDescubrir.Controls.Count;

            if (IsMensajePresente(pnlDescubrir))
            {
                var mensaje = pnlDescubrir.Controls.OfType<ucMensajeEventos>().First();
                pnlDescubrir.Controls.Remove(mensaje);
                indice = 0;
            }

            // Agregar el evento al panel Mis Eventos
            AgregarEventoAPanel(eventoActual, pnlDescubrir, indice, true);

            // Reordenar los eventos en el panel MisEventos
            ReordenarEventosEnPanel(pnlMisEventos);
        }

        private void NuevoEvento_EstudianteInscrito(object sender, EventArgs e)
        {
            // Convertir el sender en un ucEventoNuevo
            ucEventoNuevo eventoInscrito = sender as ucEventoNuevo;

            // Remover el evento del panel Descubrir
            pnlDescubrir.Controls.Remove(eventoInscrito);

            evento eventoActual = eventoInscrito.EventoData;

            // Asumiendo que ya tienes el número total de eventos en Mis Eventos
            int indice = pnlMisEventos.Controls.Count;

            if (IsMensajePresente(pnlMisEventos))
            {
                var mensaje = pnlMisEventos.Controls.OfType<ucMensajeEventos>().First();
                pnlMisEventos.Controls.Remove(mensaje);
                indice = 0;
            }

            // Agregar el evento al panel Mis Eventos
            AgregarEventoAPanel(eventoActual, pnlMisEventos, indice, false);

            // Reordenar los eventos en el panel Descubrir
            ReordenarEventosEnPanel(pnlDescubrir);
        }

        private void ReordenarEventosEnPanel(Panel panel)
        {
            // Recolecta todos los eventos en el panel
            var eventos = panel.Controls.OfType<ucEvento>().ToList();

            // Limpia el panel
            panel.Controls.Clear();

            // Agrega los eventos al panel de nuevo
            for (int i = 0; i < eventos.Count; i++)
            {
                var eventoActual = eventos[i].EventoData;
                bool esNuevoEvento = eventos[i] is ucEventoNuevo;
                AgregarEventoAPanel(eventoActual, panel, i, esNuevoEvento);
            }
        }



        private void AgregarEventosAlPanelMisEventos(evento[] eventos)
        {
            if (eventos == null || eventos.Length == 0)
            {
                MostrarMensajeEnPanel(pnlMisEventos, "Sin Eventos Inscritos", "No tienes eventos inscritos.");
                return;
            }

            for (int i = 0; i < eventos.Length; i++)
            {
                AgregarEventoAPanel(eventos[i], pnlMisEventos, i, false); // false para indicar que no es un nuevo evento
            }
        }

        private void AgregarEventosAlPanelDescubrir(evento[] eventos)
        {
            if (eventos == null || eventos.Length == 0)
            {
                MostrarMensajeEnPanel(pnlDescubrir, "Sin Eventos Nuevos", "No hay eventos nuevos.");
                return;
            }

            for (int i = 0; i < eventos.Length; i++)
            {
                AgregarEventoAPanel(eventos[i], pnlDescubrir, i, true); // true para indicar que es un nuevo evento
            }
        }

        private void btnMisEventos_Click(object sender, EventArgs e)
        {
            btnMisEventos.BackColor = Color.DodgerBlue;
            btnExplorarEventos.BackColor = Color.Transparent;
            pnlMisEventos.Visible = true;
            pnlMisEventos.BringToFront();
            pnlDescubrir.Visible = false;
            pnlDescubrir.SendToBack();
        }

        private void btnExplrarEventos_Click(object sender, EventArgs e)
        {
            btnExplorarEventos.BackColor = Color.DodgerBlue;
            btnMisEventos.BackColor = Color.Transparent;
            pnlMisEventos.Visible = false;
            pnlMisEventos.SendToBack();
            pnlDescubrir.Visible = true;
            pnlDescubrir.BringToFront();
        }

        private void MostrarMensajeEnPanel(Panel panel, string titulo, string texto)
        {
            ucMensajeEventos mensaje = new ucMensajeEventos();

            // Establece los valores
            mensaje.TituloMensaje = titulo;
            mensaje.TextoMensaje = texto;
            mensaje.ImagenMensaje = Resources.icons8_empty_64; 

            // Centra el UserControl en el panel
            mensaje.Location = new Point((panel.Width - mensaje.Width) / 2, (panel.Height - mensaje.Height) / 2);
            mensaje.Anchor = AnchorStyles.None;

            // Limpia el panel y agrega el mensaje
            panel.Controls.Clear();
            panel.Controls.Add(mensaje);
        }

        evento[] eventosInscritos;
        evento[] todosLosEventos;

        private void frmEventosEstudiante_Load(object sender, EventArgs e)
        {
            // Crea una instancia del cliente del servicio web
            AdminWSClient client = new AdminWSClient();

            try
            {
                // Llama al método del servicio web y obtén la lista de eventos
                eventosInscritos = client.listarEventosInscritosPorEstudiante(GlobalVariables.IdUsuario) ?? new evento[0];  // Si es null, se asigna un arreglo vacío

                if (eventosInscritos.Length == 0)
                {
                    MostrarMensajeEnPanel(pnlMisEventos, "Sin Eventos Inscritos", "No tienes eventos inscritos.");
                }
                else
                {
                    AgregarEventosAlPanelMisEventos(eventosInscritos);
                }

                // Obtener todos los eventos
                todosLosEventos = client.listarTodosEventos() ?? new evento[0];  // Si es null, se asigna un arreglo vacío

                // Filtrar todos los eventos para excluir aquellos en los que el estudiante ya está inscrito y eventos pasados
                evento[] eventosParaDescubrir = todosLosEventos
                .Where(evento =>
                    !eventosInscritos.Any(eventoInscrito => eventoInscrito.idEvento == evento.idEvento) &&
                    evento.fechaInicio > DateTime.Now)
                .ToArray();

                if (todosLosEventos.Length == 0)
                {
                    MostrarMensajeEnPanel(pnlDescubrir, "Sin Eventos Disponibles", "No hay eventos disponibles.");
                }
                else
                {
                    // Llama al método para agregar los eventos no inscritos al panel "descubrir eventos"
                    AgregarEventosAlPanelDescubrir(eventosParaDescubrir);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los eventos: " + ex.Message);
            }
            finally
            {
                // Asegúrate de cerrar el cliente cuando hayas terminado
                client.Close();
            }
        }

    }
}
