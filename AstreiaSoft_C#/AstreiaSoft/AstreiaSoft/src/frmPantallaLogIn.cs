using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using AstreiaSoft.UserWS;
using AstreiaSoft.MallaWS;

namespace AstreiaSoft
{
    public partial class frmPantallaLogIn : Form
    {
        private MallaWSClient daoMalla;
        private UserWSClient daoUser;

        public frmPantallaLogIn()
        {
            InitializeComponent();
            txtContrasena.KeyDown += new KeyEventHandler(this.txtContrasena_KeyDown);
            txtContrasena.UseSystemPasswordChar = true;

            daoMalla = new MallaWSClient();
            daoUser = new UserWSClient();
            this.Icon = new Icon("logo.ico");
            this.AcceptButton = btnAcceder;
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
                lblError.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "CONTRASEÑA")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.LightGray;
                // Do not change PasswordChar here.
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "CONTRASEÑA";
                txtContrasena.ForeColor = Color.DimGray;
                // Do not change PasswordChar here.
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            String correo = txtUsuario.Text;
            String password = txtContrasena.Text;
            int idUsuario = 0;
            idUsuario = daoUser.verificarCuentaUsuario(correo, password);
            BindingList <UserWS.rol> roles = new BindingList<UserWS.rol>();
            /*frmPantallaPrincipal formPrincipal = new frmPantallaPrincipal(idUsuario, roles);
            this.Hide();
            formPrincipal.Show();*/

            if (idUsuario != 0)
            {
                roles = new BindingList<UserWS.rol>
                    (daoUser.listarRolesDeUsuario(idUsuario).ToList());
                frmPantallaPrincipal formPrincipal = new frmPantallaPrincipal(idUsuario, roles);
                formPrincipal.BtnCursos.Visible = false;
                formPrincipal.BtnEventos.Visible = false;
                formPrincipal.BtnGestAulas.Visible = false;
                formPrincipal.BtnGestCursos.Visible = false;
                formPrincipal.BtnGestEventos.Visible = false;
                formPrincipal.BtnGestHorarios.Visible = false;
                formPrincipal.BtnGestSeccion.Visible = false;
                formPrincipal.BtnHijos.Visible = false;
                formPrincipal.BtnHorario.Visible = false;
                formPrincipal.BtnInicio.Visible = false;
                formPrincipal.BtnMatricula.Visible = false;
                formPrincipal.BtnPerfil.Visible = false;
                formPrincipal.BtnReclamos.Visible = false;
                formPrincipal.BtnUsuarios.Visible = false;
                //formPrincipal.BtnGestBimestre.Visible = false;
                formPrincipal.BtnGestMatricula.Visible = false;
                formPrincipal.BtnGestInscripciones.Visible = false;

                foreach (var role in roles)
                {
                    switch (role.idRol)
                    {
                        case 1: //ESTUDIANTE
                            formPrincipal.BtnCursos.Visible = true;
                            formPrincipal.BtnHorario.Visible = true;
                            formPrincipal.BtnEventos.Visible = true;
                            formPrincipal.BtnPerfil.Visible = true;
                            break;
                        case 2: //PADRE DE FAMILIA
                            formPrincipal.BtnHijos.Visible = true;
                            formPrincipal.BtnMatricula.Visible = true;
                            formPrincipal.BtnPerfil.Visible = true;
                            break;
                        case 3: //DOCENTE
                            formPrincipal.BtnCursos.Visible = true;
                            formPrincipal.BtnReclamos.Visible = true;
                            formPrincipal.BtnPerfil.Visible = true;
                            break;
                        case 4: //ADMINISTRADOR ACADÉMICO
                            formPrincipal.BtnGestAulas.Visible = true;
                            formPrincipal.BtnGestCursos.Visible = true;
                            formPrincipal.BtnGestEventos.Visible = true;
                            formPrincipal.BtnGestSeccion.Visible = true;
                            formPrincipal.BtnGestHorarios.Visible = true;
                            formPrincipal.BtnPerfil.Visible = true;
                            //formPrincipal.BtnGestBimestre.Visible = true;
                            formPrincipal.BtnGestMatricula.Visible = true;
                            formPrincipal.BtnGestInscripciones.Visible = true;
                            formPrincipal.BtnUsuarios.Visible = true;
                            break;
                        case 5: //ADMINISTRADOR DE SISTEMAS
                            formPrincipal.BtnPerfil.Visible = true;
                            formPrincipal.BtnUsuarios.Visible = true;
                            break;
                    }

                }

                this.Hide();
                formPrincipal.Show();
            }
            else 
            {
                MessageBox.Show("Credenciales incorrectas. Por favor, verifique su correo y contraseña.","Error de inicio de sesión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }


        }

        private void btnMostrarContrasena_Click(object sender, EventArgs e)
        {
            // Toggle the UseSystemPasswordChar property.
            txtContrasena.UseSystemPasswordChar = !txtContrasena.UseSystemPasswordChar;
            // Optionally, change the button text or icon.
            btnMostrarContrasena.Text = txtContrasena.UseSystemPasswordChar ? "Mostrar" : "Ocultar";
        }

        private void txtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAcceder_Click(this, new EventArgs());
            }
        }

    }
}

