using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Renta_de_DVDs.Sistema
{
    internal class Informacion
    {
        static string str_conn = BaseDeDatos.getConexion();
        static string str_comm = null;
        static NpgsqlConnection conn = null;
        static NpgsqlCommand comm = null;
        internal static List<string> getCiudades()
        {
            List<string> ciudades = new List<string>();
            using (conn = new NpgsqlConnection(str_conn))
            {
                conn.Open();
                str_comm = "SELECT city FROM city";
                using (comm = new NpgsqlCommand(str_comm, conn))
                {
                    using (NpgsqlDataReader reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ciudades.Add(reader.GetString(0));
                        }
                    }
                }
                conn.Close();
            }
            return ciudades;
        }
    }
}
