using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        

        private void fechaHora_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString();
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
            MessageBox.Show("Intento de guardado", "PobreTITO");
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
