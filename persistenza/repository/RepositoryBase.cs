using System;
using System.Collections.Generic;
using System.Data;
using AutotrasportiFantini.persistenza.repository.factory;

namespace AutotrasportiFantini.persistenza.repository
{
    abstract class RepositoryBase
    {
        protected DbConnectionFactory connectionFactory;
        protected String connectionName;
        protected DbConnectionFactory.SupportedDBMS dbms;

        public RepositoryBase(DbConnectionFactory factory, DbConnectionFactory.SupportedDBMS dbms, String connectionName)
        {
            this.connectionFactory = factory;
            this.dbms = dbms;
            this.connectionName = connectionName;
        }

        protected IDbConnection getConnection()
        {
            return this.connectionFactory.GetConnection(this.dbms, this.connectionName);
        }
    }
}
