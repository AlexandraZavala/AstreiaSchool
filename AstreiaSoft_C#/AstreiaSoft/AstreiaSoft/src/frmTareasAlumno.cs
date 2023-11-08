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
    public partial class frmTareasAlumno : Form
    {
        private Estado _estado;
        public frmTareasAlumno()
        {
            InitializeComponent();
            establecerEstadoComponentes();
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Buscar:
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnSeleccionar.Enabled = true;

                    dtpFechaEntrega.ForeColor = Color.DarkGray;
                    cboEstadoEntrega.Enabled = false;
                    txtObservaciones.Enabled = false;
                    pbArchivo.Enabled = false;

                    break;
                case Estado.Seleccionar:
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnSeleccionar.Enabled = false;

                    dtpFechaEntrega.ForeColor = Color.DarkGray;
                    cboEstadoEntrega.Enabled = false;
                    txtObservaciones.Enabled = true;
                    pbArchivo.Enabled = true;

                    break;
                
                case Estado.Guardar:
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnSeleccionar.Enabled = false;
                    break;
                
            }
        }

        private void btnEntregarTarea_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La entrega ha sido registrada exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha registrado con éxito", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _estado = Estado.Inicial;
            establecerEstadoComponentes();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Buscar;
            establecerEstadoComponentes();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Seleccionar;
            establecerEstadoComponentes();
        }
    }
}
