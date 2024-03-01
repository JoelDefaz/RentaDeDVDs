using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using FontAwesome.Sharp;
using Renta_de_DVDs.Forms;
using Renta_de_DVDs.Sistema;

namespace Renta_de_DVDs
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();

            // Establecer TopLevel como false para poder insertar el formulario dentro del panel
            clientes.TopLevel = false;

            // Limpiar el contenido actual del panel si es necesario
            panel3.Controls.Clear();

            // Agregar el formulario al panel
            panel3.Controls.Add(clientes);

            // Mostrar el formulario dentro del panel
            clientes.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmInicio inicio = new frmInicio();
            inicio.ShowDialog();
        }

        private void btnDVD_Click(object sender, EventArgs e)
        {
            frmPeliculas peliculas = new frmPeliculas();
            peliculas.TopLevel = false;
            panel3.Controls.Clear();
            panel3.Controls.Add(peliculas);
            peliculas.Show();
        }

        private void btnAlquilar_Click(object sender, EventArgs e)
        {
            frmHistorialRentas historial = new frmHistorialRentas();
            historial.TopLevel = false;
            panel3.Controls.Clear();
            panel3.Controls.Add(historial);
            historial.Show();
        }
    }
}