using System;
using System.Collections.Generic;
using AutotrasportiFantini.modello.interfacce;
using System.Data;

namespace AutotrasportiFantini.persistenza.repository
{
    class RepositorySpedizione : RepositoryBase, IPersistenzaSpedizione
    {
        public RepositorySpedizione(IDbConnection connection) : base(connection)
        {

        }

        public bool aggiorna(ISpedizione oggetto)
        {
            throw new NotImplementedException();
        }

        public List<ISpedizione> cercaPerAutista(string codiceAutista)
        {
            throw new NotImplementedException();
        }

        public List<ISpedizione> cercaPerDelegato(string codiceDelegato)
        {
            throw new NotImplementedException();
        }

        public int crea(ISpedizione oggetto)
        {
            throw new NotImplementedException();
        }

        public List<ISpedizione> elencaTutti()
        {
            throw new NotImplementedException();
        }

        public void elimina(int id)
        {
            throw new NotImplementedException();
        }

        public ISpedizione getById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
