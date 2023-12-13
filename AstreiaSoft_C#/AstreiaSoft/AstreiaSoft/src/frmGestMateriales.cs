using AstreiaSoft.MallaWS;
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
    public partial class frmGestMateriales : Form
    {
        private MallaWSClient _daoServicioWeb;
        private BindingList<material> materiales;
        public frmGestMateriales(int idCursoProg)
        {
            InitializeComponent();
            _daoServicioWeb = new MallaWSClient();
            pnlControl.AutoScroll = true;
            var listaMateriales = _daoServicioWeb.listarMaterialesPorCursoProgramado(idCursoProg);

            if (listaMateriales != null)
            {
                materiales = new BindingList<material>(listaMateriales.ToList());
            }
        }

        private void frmGestMateriales_Load(object sender, EventArgs e)
        {

            int cursosPorFila = 2;
            int fila = 0;
            int columna = 0;

            if (materiales != null) 
            {
                foreach (var material in materiales) 
                {
                    frmUnMaterial frmMat = new frmUnMaterial(material);

                    /*
                    frmMat.AutoSize = false;
                    frmMat.TopLevel = false;
                    frmMat.Dock = DockStyle.Top;
                    frmMat.FormBorderStyle = FormBorderStyle.None;
                    frmMat.ControlBox = false;

                    pnlControl.Controls.Add(frmMat);

                    frmMat.Visible = true;
                    */
                    int x = columna * (frmMat.Width + 5);
                    int y = fila * (frmMat.Height + 5);

                    frmMat.Location = new Point(x, y);
                    frmMat.FormBorderStyle = FormBorderStyle.None;
                    frmMat.TopLevel = false;
                    pnlControl.Controls.Add(frmMat); //se lista
                    frmMat.Visible = true;

                    columna++;
                    if (columna >= cursosPorFila)
                    {
                        columna = 0;
                        fila++;
                    }
                }
            
            }
        }
    }
}
