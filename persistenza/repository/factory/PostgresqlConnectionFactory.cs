using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;

namespace AutotrasportiFantini.persistenza.repository.factory
{
    class PostgresqlConnectionFactory : IConfigurationConnectionFactory
    {
        protected String providerName = "Npgsql";

        public IDbConnection GetConnection(string connectionName)
        {
            try
            {
                DbProviderFactory providerFactory = DbProviderFactories.GetFactory(this.providerName);
                IDbConnection connection = providerFactory.CreateConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;

                return connection;
            }
            catch (ConfigurationErrorsException exception)
            {
                throw new ArgumentException("Connection string is invalid or nonexistent", "connectionName", exception);
            }
        }
    }
}
