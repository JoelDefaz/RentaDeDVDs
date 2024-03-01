using System;

public class Class1
{
	public Class1()
	{
        // Conexión para la base de datos, de ser necesario cambiar el nombre de la base
        const string CONEXION_BASE_DE_DATOS = "Data Source=(Local); database=Facturacion; Integrated Security=SSPI";

        internal static string getConexion()
        {
            return CONEXION_BASE_DE_DATOS;
        }
    }
}
