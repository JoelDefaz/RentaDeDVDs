using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Renta_de_DVDs.Sistema
{
    internal class Cliente
    {
        static string str_conn = BaseDeDatos.getConexion();
        static string str_comm = null;
        static NpgsqlConnection conn = null;
        static NpgsqlCommand comm = null;
        internal static bool registrarCliente(string[] datosCliente)
        {
            using (conn = new NpgsqlConnection(str_conn))
            {
                try
                {
                    conn.Open();
                    str_comm = nuevoCliente(datosCliente);
                    using (comm = new NpgsqlCommand(str_comm, conn))
                    {
                        using (NpgsqlDataReader reader = comm.ExecuteReader())
                        {
                            if (comm.ExecuteNonQuery() == 1)
                            {
                                Mensajes.mostrarMensaje("Cliente registrado con éxito");
                                return true;
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601)
                    {
                        Mensajes.mostrarMensaje("Cliente ya registrado en el sistema");
                        return false;
                    }
                    else
                    {
                        Mensajes.mostrarMensaje("Error de base de datos");
                        return false;
                    }
                }
            }
            return false;
        }

        private static string nuevoCliente(string[] datos)
        {
            string comando = "INSERT INTO customer VALUES(";
            comando += getClienteID() + ",";
            comando += "1,'";
            comando += datos[0] + "','";
            comando += datos[1] + "','";
            comando += datos[2] + "',";
            comando += getIdDireccionID(datos[3], datos[4], datos[5], datos[6], datos[7], datos[8]) +",";
            comando += "true,";
            comando += "SELECT CURRENT_DATE,";
            comando += "SELECT CURRENT_TIMESTAMP,";
            comando += "1)";
            return comando;
        }

        private static string getIdDireccionID(string direccion1, string direccion2, string distrito, string ciudad, string codigo_postal, string telefono)
        {
            using (conn = new NpgsqlConnection(str_conn))
            {
                try
                {
                    conn.Open();
                    str_comm = "INSERT INTO address VALUES (" + obtenerNuevoID() + ",'" + direccion1 + "','" + direccion2 + "','" + distrito + "'," + GetCiudadID(ciudad) + ",'" + codigo_postal + "','" + telefono + "',(SELECT CURRENT_TIMESTAMP))";
                    using (comm = new NpgsqlCommand(str_comm, conn))
                    {
                        using (NpgsqlDataReader reader = comm.ExecuteReader())
                        {
                            {
                                if (comm.ExecuteNonQuery() == 1)
                                {
                                    return (reader.GetInt32(0) + 1).ToString();
                                }
                            }
                        }
                        conn.Close();
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601)
                    {
                        Mensajes.mostrarMensaje("Direccion ya registrada en el sistema");
                        return "0";
                    }
                    else
                    {
                        Mensajes.mostrarMensaje("Error de base de datos");
                        return "0";
                    }
                }
            }
            return "0";
        }

        private static string GetCiudadID(string ciudad)
        {
            return "(SELECT city_id FROM city WHERE city = '"+ciudad+"')";
        }

        private static string obtenerNuevoID()
        {
            return "(SELECT MAX(address_id) FROM address)";
        }

        private static string getClienteID()
        {
            return "(SELECT MAX(customer_id) FROM customer)";
        }

        internal static void getClientes(string nombre, string apellido, DataGridView dtgvClientes)
        {
            try
            {
                using (conn = new NpgsqlConnection(str_conn))
                {
                    conn.Open();
                    str_comm = getComandoInsercion(nombre, apellido);
                    using (comm = new NpgsqlCommand(str_comm, conn))
                    {
                        using (NpgsqlDataReader reader = comm.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int n = dtgvClientes.Rows.Add();
                                dtgvClientes.Rows[n].Cells[0].Value = reader.GetInt32(0).ToString();
                                dtgvClientes.Rows[n].Cells[1].Value = reader.GetString(1);
                                dtgvClientes.Rows[n].Cells[2].Value = reader.GetString(2);
                                dtgvClientes.Rows[n].Cells[3].Value = reader.GetString(3);
                                dtgvClientes.Rows[n].Cells[4].Value = reader.GetString(4);
                                dtgvClientes.Rows[n].Cells[5].Value = reader.GetString(5);
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

        private static string getComandoInsercion(string nombre, string apellido)
        {
            return "SELECT customer_id, first_name, last_name, email, A.address, A.phone " +
                "FROM customer C, address A " +
                "WHERE UPPER(C.first_name) LIKE '%"+nombre+"%' AND UPPER(C.last_name) LIKE '%"+apellido+"%' AND C.address_id = A.address_id;";
        }

        internal static string[] getInformacionCliente(string id_cliente)
        {
            string[] datos = new string[10];
            using (conn = new NpgsqlConnection(str_conn))
            {
                conn.Open();
                str_comm = getComando(id_cliente);
                using (comm = new NpgsqlCommand(str_comm, conn))
                {
                    using (NpgsqlDataReader reader = comm.ExecuteReader())
                    {
                        reader.Read();
                        datos[0] = reader.GetString(0);
                        datos[1] = reader.GetString(1);
                        datos[2] = reader.GetString(2);
                        datos[3] = reader.GetString(3);
                        datos[4] = reader.GetString(4);
                        datos[5] = reader.GetString(5);
                        datos[6] = reader.GetString(6);
                        datos[7] = reader.GetString(7);
                        datos[8] = reader.GetString(8);
                        datos[9] = reader.GetString(9);
                    }
                }
            }
            return datos;
        }

        private static string getComando(string id_cliente)
        {
            return "SELECT first_name, last_name, email, A.address, A.address2, A.district, T.city, P.country, A.postal_code, A.phone " +
                "FROM customer C, address A, city T, country P " +
                "WHERE customer_id = "+id_cliente+" AND C.address_id = A.address_id AND A.city_id = T.city_id AND T.country_id = P.country_id";
        }

        internal static bool eliminarCliente(string nombre, string apellido)
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
                        string str_comm = getComandoEliminacion(nombre.ToUpper(),apellido.ToUpper());
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
                return true;
            }
        }

        private static string getComandoEliminacion(string nombre, string apellido)
        {
            return "BEGIN TRANSACTION; " +
            "DELETE FROM payment WHERE payment.customer_id IN(SELECT customer_id FROM customer WHERE UPPER(first_name) = '" + nombre + "' AND UPPER(last_name) = '" + apellido + "'); " +
            "DELETE FROM rental WHERE rental.customer_id IN(SELECT customer_id FROM customer WHERE UPPER(first_name) = '" + nombre + "' AND UPPER(last_name) = '" + apellido + "'); " +
            "DELETE FROM customer WHERE UPPER(first_name) = '" + nombre + "' AND UPPER(last_name) = '" + apellido + "'; "+
            "COMMIT; ";
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
    }
}
