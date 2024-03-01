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
    public partial class frmHistorialRentas : Form
    {
        object contenidoCelda;
        DataGridViewColumn columnaSeleccionada;
        public frmHistorialRentas()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            dtgvHistorial.Rows.Clear();
            Historial.getHistorial(txtNombre.Text.ToUpper(), txtApellido.Text.ToUpper(), dtgvHistorial);
        }

        private void btnBuscarPelicula_Click(object sender, EventArgs e)
        {
            dtgvHistorial.Rows.Clear();
            Historial.getHistorial(txtTitulo.Text.ToUpper(), dtgvHistorial);
        }

        private void dtgvHistorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                columnaSeleccionada = dtgvHistorial.Columns[e.ColumnIndex];
                contenidoCelda = dtgvHistorial.Rows[e.RowIndex].Cells[columnaSeleccionada.Index].Value;
                frmInformacionPelicula detallePelicula = new frmInformacionPelicula(contenidoCelda.ToString(), this.btnBuscarPelicula);
                detallePelicula.ShowDialog();
                columnaSeleccionada = null;
                contenidoCelda = "";
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                columnaSeleccionada = dtgvHistorial.Columns[e.ColumnIndex];
                contenidoCelda = dtgvHistorial.Rows[e.RowIndex].Cells[columnaSeleccionada.Index].Value;
                frnInformacionCliente detalleCliente = new frnInformacionCliente(contenidoCelda.ToString(), this.btnBuscarCliente);
                detalleCliente.ShowDialog();
                columnaSeleccionada = null;
                contenidoCelda = "";
            }
        }
    }
}
