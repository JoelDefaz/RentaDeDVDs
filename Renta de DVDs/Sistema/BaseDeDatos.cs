using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Renta_de_DVDs.Sistema
{
    internal class BaseDeDatos
    {
        const string CONEXION_BASE_DE_DATOS = "Host=127.0.0.1; Username=postgres; Password=*J@3l*; Database=DVDRENT";

        internal static string getConexion()
        {
            return CONEXION_BASE_DE_DATOS; 
        }
    }

}
