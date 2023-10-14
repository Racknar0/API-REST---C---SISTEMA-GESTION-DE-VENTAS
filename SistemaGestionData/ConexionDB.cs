using System.Data.SqlClient;

namespace SistemaGestionData
{
    public class ConexionDB
    {
        private static string CadenaConexion = @"Server=RACKNARO-PC;Database=proyectocoder;Trusted_Connection=True;";

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(CadenaConexion);
        }
    }
}
