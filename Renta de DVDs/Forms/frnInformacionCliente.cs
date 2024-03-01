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
    public partial class frnInformacionCliente : Form
    {
        FontAwesome.Sharp.IconButton mostrar;
        public frnInformacionCliente(string id_cliente, FontAwesome.Sharp.IconButton btnBuscar)
        {
            InitializeComponent();
            mostrarDetalles(id_cliente);
            this.mostrar = btnBuscar;
        }

        private void mostrarDetalles(string id_cliente)
        {
            string[] informacionCliente = Cliente.getInformacionCliente(id_cliente);
            txtNombre.Text = informacionCliente[0];
            txtApellido.Text = informacionCliente[1];
            txtEmail.Text = informacionCliente[2];
            txtDireccion1.Text = informacionCliente[3];
            txtDireccion2.Text = informacionCliente[4];
            txtDistrito.Text = informacionCliente[5];
            txtCiudad.Text = informacionCliente[6];
            txtPais.Text = informacionCliente[7];
            txtcodigoPostal.Text = informacionCliente[8];
            txtTelefono.Text = informacionCliente[9];
        }

        private void frnInformacionCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminarPelicula_Click(object sender, EventArgs e)
        {
            if (Cliente.eliminarCliente(txtNombre.Text,txtApellido.Text))
            {
                Mensajes.mostrarMensaje("Cliente eliminado con éxito");
            }
            else
            {
                Mensajes.mostrarMensaje("Error al eliminar al cliente");
            }
            mostrar.PerformClick();
            this.Close();
        }
    }
}
