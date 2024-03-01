using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renta_de_DVDs.Sistema;

namespace Renta_de_DVDs.Forms
{
    public partial class frmInformacionPelicula : Form
    {
        FontAwesome.Sharp.IconButton frmfilm;
        public frmInformacionPelicula(string titulo, FontAwesome.Sharp.IconButton btnBuscar)
        {
            InitializeComponent();
            mostrarDetalles(titulo);
            this.frmfilm = btnBuscar;
        }

        private void mostrarDetalles(string titulo)
        {
            string[] detallesPelicula = Peliculas.getDetallePelicula(titulo);
            txtTitulo.Text = titulo;
            txtDescripcion.Text = detallesPelicula[1];
            txtAñoLanzamiento.Text = detallesPelicula[2];
            txtIdioma.Text = detallesPelicula[3];
            txtTiempoRenta.Text = detallesPelicula[4];
            txtCosteRenta.Text = detallesPelicula[5];
            txtCosteRemplazo.Text = detallesPelicula[6];
            txtPuntaje.Text = detallesPelicula[7];
        }

        private void frmDetallePelicula_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminarPelicula_Click(object sender, EventArgs e)
        {
            if (Peliculas.eliminarPelicula(txtTitulo.Text))
            {
                Mensajes.mostrarMensaje("Pelicula eliminada con éxito");
            }
            else
            {
                Mensajes.mostrarMensaje("Error al eliminar");
            }
            frmfilm.PerformClick();
            this.Close();
        }

        private void btnAlquilar_Click(object sender, EventArgs e)
        {
            frmAlquilarPeliculas alquilar = new frmAlquilarPeliculas(txtTitulo.Text);
            alquilar.ShowDialog();
        }
    }
}
