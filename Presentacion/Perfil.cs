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
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
        }

        

        private void Perfil_Load(object sender, EventArgs e)
        {
            PerfilData();
        }
        
        private void PerfilData()
        {
            lblNombre.Text = UsuarioLoginCache.Nombre;
            lblCuil.Text = UsuarioLoginCache.Cuil;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            PresentacionVecino presentacionVecino = new PresentacionVecino();
            presentacionVecino.Show();
        }
    }
}
