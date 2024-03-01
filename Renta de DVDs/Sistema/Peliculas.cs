using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Renta_de_DVDs.Sistema
{
    internal class Peliculas
    {
        static string str_conn = BaseDeDatos.getConexion();
        static string str_comm = null;
        static NpgsqlConnection conn = null;
        static NpgsqlCommand comm = null;

        internal static bool eliminarPelicula(string titulo)
        {
            if (!confirmarAccion("¿Está seguro de eliminar este registro?"))
            {
                return false;
            }
            try
            {
                using (conn = new NpgsqlConnection(str_conn))
                {
                    conn.Open();
                    using (var transaccion = conn.BeginTransaction())
                    {
                        string str_comm = getComandoEliminacion(titulo);
                        using (comm = new NpgsqlCommand(str_comm, conn, transaccion))
                        {
                            comm.ExecuteNonQuery();
                        }
                        transaccion.Commit();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Mensajes.mostrarMensaje("Error durante la eliminación de la película: " + ex.Message);
                Mensajes.mostrarMensaje("StackTrace: " + ex.StackTrace);
                return false;
            }
        }


        private static bool confirmarAccion(string mensaje)
        {
            DialogResult result = MessageBox.Show(mensaje, "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }

        private static string getComandoEliminacion(string titulo)
        {
            return "DELETE FROM payment WHERE rental_id IN (SELECT rental.rental_id FROM rental INNER JOIN inventory ON rental.inventory_id = inventory.inventory_id WHERE inventory.film_id IN (SELECT film_id FROM film WHERE title = '" + titulo + "'));" +
                "DELETE FROM rental WHERE inventory_id IN (SELECT inventory.inventory_id FROM inventory WHERE inventory.film_id IN (SELECT film_id FROM film WHERE title = '" + titulo + "'));" +
                "DELETE FROM inventory WHERE film_id IN (SELECT film_id FROM film WHERE title = '" + titulo + "');" +
                "DELETE FROM film_category WHERE film_id IN (SELECT film_id FROM film WHERE title = '" + titulo + "');" +
                "DELETE FROM film_actor WHERE film_id IN (SELECT film_id FROM film WHERE title = '" + titulo + "');" +
                "DELETE FROM film WHERE title = '" + titulo + "';";
        }

        internal static string[] getDetallePelicula(string titulo)
        {
            string[] datos = new string[8];
            using (conn = new NpgsqlConnection(str_conn))
            {
                conn.Open();
                str_comm = "SELECT title, description, release_year, L.name, rental_duration, rental_rate, replacement_cost, rating FROM film F, language L WHERE title = '"+titulo+"' AND L.language_id = F.language_id";
                using (comm = new NpgsqlCommand(str_comm, conn))
                {
                    using (NpgsqlDataReader reader = comm.ExecuteReader())
                    {
                        reader.Read();
                        datos[0] = reader.GetString(0);
                        datos[1] = reader.GetString(1);
                        datos[2] = reader.GetInt32(2).ToString();
                        datos[3] = reader.GetString(3);
                        datos[4] = reader.GetInt16(4).ToString();
                        datos[5] = reader.GetDecimal(5).ToString();
                        datos[6] = reader.GetDecimal(6).ToString();
                        datos[7] = reader.GetString(7);
                    }
                }
            }
            return datos;
        }

        internal static void getPeliculas(string titulo, System.Windows.Forms.DataGridView dtgvPeliculas)
        {
            string[] datos = new string[6];
            try
            {
                using (conn = new NpgsqlConnection(str_conn))
                {
                    conn.Open();
                    str_comm = "SELECT title, rating, L.name, rental_duration, rental_rate, replacement_cost FROM film F, language L WHERE L.language_id = F.language_id AND UPPER(F.title) LIKE '%" + titulo.ToUpper() + "%'";
                    using (comm = new NpgsqlCommand(str_comm, conn))
                    {
                        using (NpgsqlDataReader reader = comm.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int n = dtgvPeliculas.Rows.Add();
                                dtgvPeliculas.Rows[n].Cells[0].Value = reader.GetString(0);
                                dtgvPeliculas.Rows[n].Cells[1].Value = reader.GetString(1);
                                dtgvPeliculas.Rows[n].Cells[2].Value = reader.GetString(2);
                                dtgvPeliculas.Rows[n].Cells[3].Value = reader.GetDecimal(3).ToString();
                                dtgvPeliculas.Rows[n].Cells[4].Value = reader.GetDecimal(4).ToString();
                                dtgvPeliculas.Rows[n].Cells[5].Value = reader.GetDecimal(5).ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Mensajes.mostrarMensaje("No se encontraron películas que coincidan con el título proporcionado.");
            }
        }

        internal static bool alquilarPeliculas(string[] text)
        {
            if (!confirmarAccion("¿Está seguro de alquilar está pelicula?"))
            {
                return false;
            }
            try
            {
                using (conn = new NpgsqlConnection(str_conn))
                {
                    conn.Open();
                    using (var transaccion = conn.BeginTransaction())
                    {
                        string str_comm = getComandoRentar(text);
                        using (comm = new NpgsqlCommand(str_comm, conn, transaccion))
                        {
                            comm.ExecuteNonQuery();
                        }
                        transaccion.Commit();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Mensajes.mostrarMensaje("Error: " + ex.Message);
                return false;
            }
        }

        private static string getComandoRentar(string[] text)
        {
            return "INSERT INTO inventory VALUES(" + getIdInventory() + "," + getPeliculaID(text[0])+",1,(CURRENT_TIMESTAMP));" +
                "INSERT INTO rental VALUES("+getIdRental()+",(CURRENT_TIMESTAMP),(SELECT MAX(inventory_id) FROM inventory)," + getIdCustomer(text[1], text[2]) + ",'" + text[3] +"',1,(CURRENT_TIMESTAMP));" +
                "INSERT INTO payment VALUES("+getIdPayment()+","+ getIdCustomer(text[1], text[2]) + ",2,"+ "(SELECT MAX(rental_id) FROM rental)," + text[6] + ",'" + text[4] +"');";
        }

        private static string getIdPayment()
        {
            return "(SELECT MAX(payment_id)+1 FROM payment)";
        }

        private static string getIdCustomer(string nombres, string apellidos)
        {
            return "(SELECT customer_id FROM customer WHERE first_name = '"+nombres+"' AND last_name = '"+apellidos+"')";
        }

        private static string getIdRental()
        {
            return "(SELECT MAX(rental_id)+1 FROM rental)";
        }

        private static string getPeliculaID(string title)
        {
            return "(SELECT film_id FROM film WHERE title = '"+title+"')";   
        }

        private static string getIdInventory()
        {
            return "(SELECT MAX(inventory_id)+1 FROM inventory)";
        }

        internal static bool registrarPelicula(string[] datosRenta)
        {
            throw new NotImplementedException();
        }
    }
}
