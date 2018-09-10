using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutotrasportiFantini.persistenza.factory;
using AutotrasportiFantini.persistenza;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace AutotrasportiFantini.test
{
    class TestRepository
    {

        static void Main()
        {
            DbConnectionFactory connectionFactory = new DbConnectionFactory();
            RepositoryAutomezzo repoAutomezzo = new RepositoryAutomezzo(connectionFactory.GetConnection(DbConnectionFactory.SupportedDBMS.postgresql, "TestDb"));

            Console.WriteLine(JsonConvert.SerializeObject(repoAutomezzo.getById("FD306BC")));
        }
    }
}
