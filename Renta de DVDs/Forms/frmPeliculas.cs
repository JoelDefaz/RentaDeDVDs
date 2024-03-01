using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Renta_de_DVDs.Sistema;

namespace Renta_de_DVDs.Forms
{
    public partial class frmPeliculas : Form
    {
        public frmPeliculas()
        {
            InitializeComponent();
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            dtgvPeliculas.Rows.Clear();
            Peliculas.getPeliculas(txtTituloPelicula.Text, dtgvPeliculas);
        }

        private void btnAgregarPelicula_Click(object sender, EventArgs e)
        {
            frmRegistrarPelicula registrar = new frmRegistrarPelicula();
            registrar.ShowDialog();
        }
        object contenidoCelda;
        DataGridViewColumn columnaSeleccionada;
        private void dtgvPeliculas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                columnaSeleccionada = dtgvPeliculas.Columns[e.ColumnIndex];
                contenidoCelda = dtgvPeliculas.Rows[e.RowIndex].Cells[columnaSeleccionada.Index].Value;
                frmInformacionPelicula detallePeliculaMostrar = new frmInformacionPelicula(contenidoCelda.ToString(), this.btnBuscar);
                detallePeliculaMostrar.ShowDialog();
                columnaSeleccionada = null;
                contenidoCelda = "";
            }
        }
    }
}
