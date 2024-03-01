using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


namespace Renta_de_DVDs.Sistema
{
    internal class Login
    {
        static string str_conn = BaseDeDatos.getConexion();
        static string str_comm = null;
        static NpgsqlConnection conn = null;
        static NpgsqlCommand comm = null;

        internal static bool sonCorrectasLasCredenciales(string usuario, string contraseña)
        {
            using (conn = new NpgsqlConnection(str_conn))
            {
                conn.Open();
                str_comm = "SELECT * FROM staff WHERE username = '" + usuario+ "' AND password = '" + contraseña + "'";
                using (comm = new NpgsqlCommand(str_comm, conn))
                {
                    using (NpgsqlDataReader reader = comm.ExecuteReader())
                    {
                        reader.Read();
                        if (reader.HasRows)
                        {
                            return true;
                        }
                    }
                }
                conn.Close();
            }
            return false;
        }
    }
}
