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
using Comun.Cache;

namespace Presentacion
{
    public partial class RegistrarUsuario : Form
    {
        public RegistrarUsuario()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        


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

        private void RegistrarUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        

        private void mensajeDeError(string msg) //es un metodo vacío, no tiene que venir del doble click del mensaje
        {
            lblMensajeDeError.Text = "    " + msg;
            lblMensajeDeError.Visible = true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("¿Está seguro que desea salir?", "PobreTITO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Opcion == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }

        private void btnGuardar_Enter(object sender, EventArgs e)
        {
            
            if (txtNombre.Text != "")
            {
                if (txtCuil.Text != "")
                {
                    if (txtContraseña.Text != "")
                    {
                        //entonces guardo - instancio un nuevo Usuario
                        

                    }
                    else
                    {
                        mensajeDeError("No se asignó contraseña");
                        txtContraseña.Clear();
                        txtCuil.Clear();
                        txtNombre.Clear();
                    }
                }
                else {
                    mensajeDeError("No se asignó Cuil");
                    txtContraseña.Clear();
                    txtCuil.Clear();
                    txtNombre.Clear();
                }
            }
            else
            {
                mensajeDeError("No se asignó Nombre");
                txtContraseña.Clear();
                txtCuil.Clear();
                txtNombre.Clear();
            }
        }
    }
}
