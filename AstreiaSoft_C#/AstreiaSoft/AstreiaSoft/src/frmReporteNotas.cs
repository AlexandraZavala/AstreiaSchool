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
using System.IO;

namespace AstreiaSoft.src
{
    public partial class frmReporteNotas : Form
    {
        private EvalWSClient _daoServicioWeb;
        private byte[] reporte = null;
        private int _idHorario;
        private string _nombreCurso;
        private string _nombreDocente;
        public frmReporteNotas(int idHorario, string nombreCurso, string nombreDocente)
        {
            InitializeComponent();
            _daoServicioWeb = new EvalWSClient();
            int[] arregloDeEnteros = { 1, 2, 3, 4 };
            cboBimestre.DataSource = arregloDeEnteros;
            _idHorario = idHorario;
            _nombreCurso = nombreCurso;
            _nombreDocente = nombreDocente;
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {

            int bimestreSeleccionado = (int)cboBimestre.SelectedItem;
            reporte = _daoServicioWeb.generarReporteDeNotas(_idHorario, bimestreSeleccionado, _nombreCurso, _nombreDocente);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Guardar archivo Excel";
            saveFileDialog.FileName = "nombre_del_archivo.xlsx"; // Puedes establecer la extensión predeterminada

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string archivoGuardar = saveFileDialog.FileName;
                    File.WriteAllBytes(archivoGuardar, reporte);
                    MessageBox.Show("Se ha guardado el archivo", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha generado un error al guardar el archivo", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
