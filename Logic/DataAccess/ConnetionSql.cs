using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Logic.DataAccess
{
    public abstract class ConnectionSql
    {
        private readonly string connectionString;

        public ConnectionSql() 
        {
            connectionString = "Server =.;Database = AdministracionDB ; Trusted_Connection = True;";
        }

        /// <summary>
        /// Da la conexion a la base de datos
        /// </summary>
        /// <returns></returns>
        protected SqlConnection GetConnection() 
        {
            return new SqlConnection(connectionString);
        }
    }
}
