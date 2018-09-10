using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.persistenza.repository;
using AutotrasportiFantini.persistenza.repository.factory;

namespace AutotrasportiFantini.persistenza
{
    class RepositoryFactory : IPersistenzaFactory
    {
        protected IDbConnection connection;

        public RepositoryFactory(DbConnectionFactory.SupportedDBMS dbms, String connectionName)
        {
            DbConnectionFactory connectionFactory = new DbConnectionFactory();
            this.connection = connectionFactory.GetConnection(dbms, connectionName);
        }

        public IPersistenzaAutomezzo GetPersistenzaAutomezzo()
        {
            return new RepositoryAutomezzo(this.connection);
        }

        public IPersistenzaIndirizzo GetPersistenzaIndirizzo()
        {
            return new RepositoryIndirizzo(this.connection);
        }

        public IPersistenzaPuntoSpedizione GetPersistenzaPuntoSpedizione()
        {
            return new RepositoryPuntoSpedizione(this.connection);
        }

        public IPersistenzaSpedizione GetPersistenzaSpedizione()
        {
            return new RepositorySpedizione(this.connection);
        }

        public IPersistenzaTipologiaMerce GetPersistenzaTipologiaMerce()
        {
            return new RepositoryTipologiaMerce(this.connection);
        }
    }
}
