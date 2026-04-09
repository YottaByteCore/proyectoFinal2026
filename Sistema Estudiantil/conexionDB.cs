using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sistema_Estudiantil
{
    public static class ConexionDB
    {
        // Cadena de conexión a tu base de datos
        public static string connectionString = "Server=DESKTOP-OLP7FUV;Database=SistemaEstudiantil;Trusted_Connection=True;";

        // Método que devuelve la conexión lista para usar
        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(connectionString);
        }
    }
}
