using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotrasportiFantini.persistenza.factory
{
    class DbConnectionFactory
    {
        public enum SupportedDBMS { postgresql };

        public IDbConnection GetConnection(SupportedDBMS dbms, String connectionName)
        {
            IConfigurationConnectionFactory factory = null;

            if(dbms == SupportedDBMS.postgresql)
            {
                factory = new PostgresqlConnectionFactory();
            }
            
            if(factory != null)
            {
                return factory.GetConnection(connectionName);
            } else
            {
                return null;
            }
        }
    }
}
