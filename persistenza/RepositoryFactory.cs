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
        protected DbConnectionFactory.SupportedDBMS dbms;
        protected String connectionName;
        protected DbConnectionFactory connectionFactory;

        public RepositoryFactory(DbConnectionFactory.SupportedDBMS dbms, String connectionName)
        {
            this.connectionFactory = new DbConnectionFactory();
            this.dbms = dbms;
            this.connectionName = connectionName;
        }

        public IPersistenzaAutomezzo GetPersistenzaAutomezzo()
        {
            return new RepositoryAutomezzo(this.connectionFactory, this.dbms, this.connectionName);
        }

        public IPersistenzaIndirizzo GetPersistenzaIndirizzo()
        {
            return new RepositoryIndirizzo(this.connectionFactory, this.dbms, this.connectionName);
        }

        public IPersistenzaSpedizione GetPersistenzaSpedizione()
        {
            return new RepositorySpedizione(this.connectionFactory, this.dbms, this.connectionName);
        }

        public IPersistenzaTipologiaMerce GetPersistenzaTipologiaMerce()
        {
            return new RepositoryTipologiaMerce(this.connectionFactory, this.dbms, this.connectionName);
        }
    }
}
