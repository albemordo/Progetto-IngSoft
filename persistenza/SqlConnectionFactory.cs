using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace AutotrasportiFantini.persistenza
{
    class SqlConnectionFactory
    {
        public static SqlConnection getSqlConnection(String connectionName) 
        {
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
                return new SqlConnection(connectionString);
            } catch(ConfigurationErrorsException exception)
            {
                throw new ArgumentException("Connection string is invalid or nonexistent", "connectionName", exception);
            }
        }
    }
}
