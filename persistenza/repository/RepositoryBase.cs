using System;
using System.Collections.Generic;
using System.Data;

namespace AutotrasportiFantini.persistenza.repository
{
    abstract class RepositoryBase
    {
        protected IDbConnection connection;

        public RepositoryBase(IDbConnection connection)
        {
            this.connection = connection;
        }
    }
}
