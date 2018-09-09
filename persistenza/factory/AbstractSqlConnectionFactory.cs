using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotrasportiFantini.persistenza.factory
{
    abstract class AbstractSqlConnectionFactory
    {
        public abstract SqlConnection GetSqlConnection(String connectionName);
    }
}
