using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstreiaSoft.Evento
{
    public partial class ucMensajeEventos : UserControl
    {
        public ucMensajeEventos()
        {
            InitializeComponent();
        }

        public Image ImagenMensaje
        {
            set { pictureBoxImagen.Image = value; }
        }

        public string TituloMensaje
        {
            set { labelTitulo.Text = value; }
        }

        public string TextoMensaje
        {
            set { labelTexto.Text = value; }
        }

    }
}
