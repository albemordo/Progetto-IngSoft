using System;
using System.Collections.Generic;
using AutotrasportiFantini.modello.interfacce;
using System.Data;

namespace AutotrasportiFantini.persistenza
{
    class RepositoryTipologiaMerce : RepositoryBase<ITipologiaMerce, int>
    {
        public RepositoryTipologiaMerce(IDbConnection connection) : base(connection)
        {
        }

        public override bool aggiorna(ITipologiaMerce oggetto)
        {
            throw new NotImplementedException();
        }

        public override int crea(ITipologiaMerce oggetto)
        {
            throw new NotImplementedException();
        }

        public override List<ITipologiaMerce> elencaTutti()
        {
            throw new NotImplementedException();
        }

        public override void elimina(int id)
        {
            throw new NotImplementedException();
        }

        public override ITipologiaMerce getById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
