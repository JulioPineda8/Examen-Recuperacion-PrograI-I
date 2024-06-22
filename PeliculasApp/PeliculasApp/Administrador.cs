using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeliculasApp
{
    public partial class frmAdministrador : Form
    {
        private int n = 0;
        public frmAdministrador()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int n = dtgvPeliculas.Rows.Add();

            dtgvPeliculas.Rows[n].Cells[0].Value = txtNombre.Text;
            dtgvPeliculas.Rows[n].Cells[1].Value = txtDirector.Text;
            dtgvPeliculas.Rows[n].Cells[2].Value = txtGenero.Text;

            txtNombre.Text = "";
            txtDirector.Text = "";
            txtGenero.Text = "";
        }

        private void dtgvPeliculas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
            if (n != -1)
            {
                lblInformacion.Text = (string)dtgvPeliculas.Rows[n].Cells[0].Value;

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
                dtgvPeliculas.Rows.RemoveAt(n);
            }
        }
    }
}
