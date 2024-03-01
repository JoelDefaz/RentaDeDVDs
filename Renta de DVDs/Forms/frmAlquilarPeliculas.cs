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
    public partial class frmAlquilarPeliculas : Form
    {
        public frmAlquilarPeliculas(string text)
        {
            InitializeComponent();
            txtTitulo.Text = text;
            dtpFechaRetorno.Format = DateTimePickerFormat.Short;
            dtpFechaRetorno.CustomFormat = "yyyy-MM-dd";
            dtpFechaPago.Format = DateTimePickerFormat.Short;
            dtpFechaPago.CustomFormat = "yyyy-MM-dd";
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEstadoAlquilada_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAlquilar_Click(object sender, EventArgs e)
        {
            string[] datosRenta = getDatosRenta();
            if (Peliculas.alquilarPeliculas(datosRenta))
            {
                Mensajes.mostrarMensaje("Pelicula alquilada con éxito");
            }
            else
            {
                Mensajes.mostrarMensaje("Error al eliminar");
            }
        }

        private string[] getDatosRenta()
        {
            string[] datosRenta = new string[7];
            datosRenta[0] = txtTitulo.Text;
            datosRenta[1] = txtNombre.Text;
            datosRenta[2] = txtApellido.Text;
            datosRenta[3] = dtpFechaRetorno.Text;
            datosRenta[4] = dtpFechaPago.Text;
            datosRenta[5] = cmbPago.Text;
            datosRenta[6] = txtCoste.Text;
            return datosRenta;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
