using System;
using System.Collections.Generic;
using AutotrasportiFantini.modello.interfacce;
using System.Data;

namespace AutotrasportiFantini.persistenza.repository
{
    class RepositoryPuntoSpedizione : RepositoryBase, IPersistenzaPuntoSpedizione
    {
        public RepositoryPuntoSpedizione(IDbConnection connection) : base(connection)
        {

        }

        public bool aggiorna(IPuntoSpedizione oggetto)
        {
            throw new NotImplementedException();
        }

        public int crea(IPuntoSpedizione oggetto)
        {
            throw new NotImplementedException();
        }

        public List<IPuntoSpedizione> elencaTutti()
        {
            throw new NotImplementedException();
        }

        public void elimina(int id)
        {
            throw new NotImplementedException();
        }

        public IPuntoSpedizione getById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
