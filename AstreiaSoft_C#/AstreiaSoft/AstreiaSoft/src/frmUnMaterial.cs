using AstreiaSoft.MallaWS;
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
    public partial class frmUnMaterial : Form
    {

        private material _material;
        public frmUnMaterial(material material)
        {
            InitializeComponent();
            _material = material;
            lblTitulo.Text = _material.nombre;
            lblDescripcion.Text = _material.descripcion;
            
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Filter = "Todos los archivos (*.*)|*.*"; // Filtro para todos los archivos
            saveFileDialog.Filter = "Archivos de texto (*.pdf)|*.pdf";
            saveFileDialog.Title = "Guardar archivo"; // Título del cuadro de diálogo
            saveFileDialog.FileName = "nombre_del_archivo"; // Nombre predeterminado del archivo con la extensión que desees

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string archivoGuardar = saveFileDialog.FileName;
                    File.WriteAllBytes(archivoGuardar, this._material.archivo);
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
