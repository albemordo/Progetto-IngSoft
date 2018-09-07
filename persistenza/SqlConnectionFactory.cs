﻿using System;
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