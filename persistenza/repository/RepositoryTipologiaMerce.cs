using System;
using System.Collections.Generic;
using AutotrasportiFantini.modello.interfacce;
using System.Data;

namespace AutotrasportiFantini.persistenza.repository
{
    class RepositoryTipologiaMerce : RepositoryBase, IPersistenzaTipologiaMerce
    {
        public RepositoryTipologiaMerce(IDbConnection connection) : base(connection)
        {
        }

        public bool aggiorna(ITipologiaMerce oggetto)
        {
            throw new NotImplementedException();
        }

        public int crea(ITipologiaMerce oggetto)
        {
            throw new NotImplementedException();
        }

        public List<ITipologiaMerce> elencaTutti()
        {
            throw new NotImplementedException();
        }

        public void elimina(int id)
        {
            throw new NotImplementedException();
        }

        public ITipologiaMerce getById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
