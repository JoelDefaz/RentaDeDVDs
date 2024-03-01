using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Renta_de_DVDs.Sistema
{
    internal class Historial
    {
        static string str_conn = BaseDeDatos.getConexion();
        static string str_comm = null;
        static NpgsqlConnection conn = null;
        static NpgsqlCommand comm = null;
        internal static void getHistorial(string nombre, string apellido, DataGridView dtgvHistorial)
        {
            try
            {
                using (conn = new NpgsqlConnection(str_conn))
                {
                    conn.Open();
                    str_comm = getComando(nombre,apellido);
                    using (comm = new NpgsqlCommand(str_comm, conn))
                    {
                        using (NpgsqlDataReader reader = comm.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int n = dtgvHistorial.Rows.Add();
                                DateTime? fechaNullable = reader.IsDBNull(0) ? (DateTime?)null : reader.GetDateTime(0);
                                string fechaString = fechaNullable.HasValue ? fechaNullable.Value.ToString("dd/MM/yyyy") : "";
                                dtgvHistorial.Rows[n].Cells[0].Value = fechaString;
                                dtgvHistorial.Rows[n].Cells[1].Value = reader.GetInt32(1).ToString();
                                dtgvHistorial.Rows[n].Cells[2].Value = reader.GetString(2);
                                dtgvHistorial.Rows[n].Cells[3].Value = reader.GetString(3);
                                fechaNullable = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4);
                                fechaString = fechaNullable.HasValue ? fechaNullable.Value.ToString("dd/MM/yyyy") : "";
                                dtgvHistorial.Rows[n].Cells[4].Value = fechaString;
                                dtgvHistorial.Rows[n].Cells[5].Value = reader.GetString(5);
                                dtgvHistorial.Rows[n].Cells[6].Value = reader.GetDecimal(6).ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Mensajes.mostrarMensaje("No se encontraron historiales.");
            }
        }

        private static string getComando(string nombre, string apellido)
        {
            return "SELECT rental_date, C.customer_id, C.first_name, C.last_name, return_date, F.title, P.amount " +
                "FROM rental R, customer C, inventory I, payment P, film F " +
                "WHERE UPPER(C.first_name) LIKE '%"+nombre+"%' AND UPPER(last_name) LIKE '%"+apellido+"%' AND C.customer_id = P.customer_id " +
                "AND R.inventory_id = I.inventory_id AND F.film_id = I.film_id AND R.rental_id = P.rental_id ORDER BY F.title ";
        }

        internal static void getHistorial(string titulo, DataGridView dtgvHistorial)
        {
            try
            {
                using (conn = new NpgsqlConnection(str_conn))
                {
                    conn.Open();
                    str_comm = getComando(titulo);
                    using (comm = new NpgsqlCommand(str_comm, conn))
                    {
                        using (NpgsqlDataReader reader = comm.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int n = dtgvHistorial.Rows.Add();
                                DateTime? fechaNullable = reader.IsDBNull(0) ? (DateTime?)null : reader.GetDateTime(0);
                                string fechaString = fechaNullable.HasValue ? fechaNullable.Value.ToString("dd/MM/yyyy") : "";
                                dtgvHistorial.Rows[n].Cells[0].Value = fechaString;
                                dtgvHistorial.Rows[n].Cells[1].Value = reader.GetInt32(1).ToString();
                                dtgvHistorial.Rows[n].Cells[2].Value = reader.GetString(2);
                                dtgvHistorial.Rows[n].Cells[3].Value = reader.GetString(3);
                                fechaNullable = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4);
                                fechaString = fechaNullable.HasValue ? fechaNullable.Value.ToString("dd/MM/yyyy") : "";
                                dtgvHistorial.Rows[n].Cells[4].Value = fechaString;
                                dtgvHistorial.Rows[n].Cells[5].Value = reader.GetString(5);
                                dtgvHistorial.Rows[n].Cells[6].Value = reader.GetDecimal(6).ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Mensajes.mostrarMensaje("No se encontraron historiales.");
            }
        }

        private static string getComando(string titulo)
        {
            return "SELECT rental_date, C.customer_id, C.first_name, C.last_name, return_date, F.title, P.amount " +
                "FROM rental R, customer C, inventory I, payment P, film F " +
                "WHERE UPPER(F.title) LIKE '%"+titulo+"%' AND C.customer_id = P.customer_id " +
                "AND R.inventory_id = I.inventory_id AND F.film_id = I.film_id AND R.rental_id = P.rental_id " +
                "ORDER BY F.title ";
        }
    }
}
