using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renta_de_DVDs.Sistema;

namespace Renta_de_DVDs.Forms
{
    public partial class frmClientes : Form
    {
        List<string> ciudadesDisponibles;

        public frmClientes()
        {
            InitializeComponent();
            ciudadesDisponibles = Informacion.getCiudades();
            añadirCiudades();
        }

        private void añadirCiudades()
        {
            foreach (string resultado in ciudadesDisponibles)
            {
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string[] datosCliente = obtenerDatos();
            if (!Validar.estanLosCamposLlenos(datosCliente))
            {
                Mensajes.mostrarMensaje("Por favor llenar los campos");
                return;
            }
            if (Cliente.registrarCliente(datosCliente))
            {
                limpiarConsola();
            }
            else
            {
                Mensajes.mostrarMensaje("Ocurrio un error al ingresar el nuevo cliente");
            }
        }

        private string[] obtenerDatos()
        {
            string[] datos = new string[9];
            return datos;
        }

        private void limpiarConsola()
        {
            throw new NotImplementedException();
        }

        object contenidoCelda;
        DataGridViewColumn columnaSeleccionada;
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dtgvClientes.Rows.Clear();
            Cliente.getClientes(txtNombre.Text.ToUpper(), txtApellido.Text.ToUpper(), dtgvClientes);
        }

        private void dtgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                columnaSeleccionada = dtgvClientes.Columns[e.ColumnIndex];
                contenidoCelda = dtgvClientes.Rows[e.RowIndex].Cells[columnaSeleccionada.Index].Value;
                frnInformacionCliente detalleClienteMostrar = new frnInformacionCliente(contenidoCelda.ToString(), this.btnBuscar);
                detalleClienteMostrar.ShowDialog();
                columnaSeleccionada = null;
                contenidoCelda = "";
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            frmRegistrarCliente registrarCliente = new frmRegistrarCliente();
            registrarCliente.ShowDialog();
        }
    }
}
