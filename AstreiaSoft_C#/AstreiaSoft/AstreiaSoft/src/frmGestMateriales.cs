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
            materiales = new BindingList<material>(_daoServicioWeb.listarMaterialesPorCursoProgramado(idCursoProg).ToList());
        }

        private void frmGestMateriales_Load(object sender, EventArgs e)
        {
            if (materiales != null) 
            {
                foreach (var material in materiales) 
                {
                    frmUnMaterial frmMat = new frmUnMaterial(material);
                    frmMat.AutoSize = false;
                    frmMat.TopLevel = false;
                    frmMat.Dock = DockStyle.Top;
                    frmMat.FormBorderStyle = FormBorderStyle.None;
                    frmMat.ControlBox = false;

                    pnlControl.Controls.Add(frmMat);

                    frmMat.Visible = true;
                }
            
            }
        }
    }
}
