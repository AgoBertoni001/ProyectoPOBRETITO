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
using Dominio;

namespace Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        
        

        private void txtCUIL_Enter(object sender, EventArgs e)
        {
            if (txtCUIL.Text == "CUIL")
            {
                txtCUIL.Text = "";
                txtCUIL.ForeColor = Color.LightGray;
            }
        }
        private void txtCUIL_Leave(object sender, EventArgs e)
        {
            if (txtCUIL.Text == "")
            {
                txtCUIL.Text = "CUIL";
                txtCUIL.ForeColor = Color.DimGray;
            }
        }

        private void txtPassword_Enter_1(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Contraseña";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("¿Está seguro que desea salir?", "PobreTITO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Opcion == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtCUIL.Text != "CUIL") {
                if (txtPassword.Text != "Contraseña")
                {
                    UsuarioDominio usuario = new UsuarioDominio();
                    var validLogin = usuario.Login(txtCUIL.Text, txtPassword.Text);
                    if(validLogin == true)
                    {
                        PresentacionVecino principalVecino = new PresentacionVecino();
                        principalVecino.Show();
                        this.Hide();
                    }
                    else
                    {
                        mensajeDeError("Incorrecto cuil o contraseña\n Intente nuevamente.");
                        txtCUIL.Clear();
                        txtCUIL.Focus();
                        txtPassword.Clear();
                    }

                }
                else mensajeDeError("Por favor ingrese la contraseña");
            }
            else mensajeDeError("Por favor ingrese el cuil");
        }

        private void mensajeDeError(string msg) //es un metodo vacío, no tiene que venir del doble click del mensaje
        {
            lblMensajeDeError.Text = "    "+ msg;
            lblMensajeDeError.Visible = true;
            
        }

        private void iniciarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrarUsuario registrarUsuario = new RegistrarUsuario();
            registrarUsuario.Show();
            this.Hide();
        }
    }
}
