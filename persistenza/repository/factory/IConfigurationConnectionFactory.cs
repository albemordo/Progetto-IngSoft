using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotrasportiFantini.persistenza.repository.factory
{
    interface IConfigurationConnectionFactory
    {
        IDbConnection GetConnection(String connectionName);
    }
}
