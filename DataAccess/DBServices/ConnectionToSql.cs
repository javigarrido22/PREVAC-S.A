using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DBServices
{
    public abstract class ConnectionToSql
    {
        /// <summary>
        /// Esta clase abstracta es responsable de establecer la cadena de conexion
        /// y obtener la conexion a SQL.
        /// </summary>
        /// 

        private readonly string connectionString;//Obtiene o establece la cadena de conexión.

        public ConnectionToSql()
        {
            //Establecer la cadena de conexión.
            connectionString = "Server=tcp:prevac.database.windows.net,1433;Initial Catalog=prevac;Persist Security Info=False;User ID=admin1;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Server=tcp:prevac.database.windows.net,1433;Initial Catalog=prevac;Persist Security Info=False;User ID=admin1;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        }
        protected SqlConnection GetConnection()
        {
            //Este métedo se encarga de establecer y devolver el objeto de conexión a SQL Server.
            return new SqlConnection(connectionString);
        }
    }
}
