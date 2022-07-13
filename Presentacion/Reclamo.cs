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
using Comun;
using Diseño;


namespace Presentacion
{
    public partial class Reclamo : Form
    {
        public Reclamo()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("¿Está seguro que desea volver?", "PobreTITO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Opcion == DialogResult.Yes)
            {
                this.Hide();
                PresentacionVecino presentacionVecino = new PresentacionVecino();
                presentacionVecino.Show();
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

        

        private void fecha_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblHora.Text=DateTime.Now.ToLongTimeString();
        }

        private void Reclamo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pOBRETITODataSet.Calles' Puede moverla o quitarla según sea necesario.
            this.callesTableAdapter.Fill(this.pOBRETITODataSet.Calles);
            // TODO: esta línea de código carga datos en la tabla 'pOBRETITODataSet.Incidente' Puede moverla o quitarla según sea necesario.
            this.incidenteTableAdapter.Fill(this.pOBRETITODataSet.Incidente);
            // TODO: esta línea de código carga datos en la tabla 'pOBRETITODataSet.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.pOBRETITODataSet.Categoria);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ReclamoDominio dominioReclamo = new ReclamoDominio();
            string rta = dominioReclamo.InsertarReclamo("Pendiente", lblFecha.Text.Trim(), lblHora.Text.Trim(), UsuarioLoginCache.IdUsuario , cmbIncidente.TabIndex, cmbCalle.TabIndex);
            if (rta.Equals("OK"))
            {
                MessageBox.Show($"El reclamo se registro exitosamente!-----\n{lblFecha.Text}  {lblHora.Text}   {UsuarioLoginCache.IdUsuario}      {cmbIncidente.TabIndex}      {cmbCalle.TabIndex}", "PobreTITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(rta);
            }

        }

        private void txtAltura_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAltura.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor ingrese solo numeros.");
                txtAltura.Text = txtAltura.Text.Remove(txtAltura.Text.Length - 1);
            }
        }
    }
}
