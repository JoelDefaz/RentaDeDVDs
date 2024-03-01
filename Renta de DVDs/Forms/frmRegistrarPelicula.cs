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
    public partial class frmRegistrarPelicula : Form
    {
        public frmRegistrarPelicula()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string[] datosRenta = getDatosRenta();
            if (!Validar.estanLosCamposLlenos(datosRenta))
            {
                Mensajes.mostrarMensaje("Por favor llenar todos los campos");
                return;
            }
            else if (Peliculas.registrarPelicula(datosRenta))
            {
                Mensajes.mostrarMensaje("Pelicula registrada con éxito");
                return;
            }
            else
            {
                Mensajes.mostrarMensaje("Error al eliminar");
            }
        }

        private string[] getDatosRenta()
        {
            throw new NotImplementedException();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
