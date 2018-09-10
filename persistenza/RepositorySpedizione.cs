using System;
using System.Collections.Generic;
using AutotrasportiFantini.modello.interfacce;
using System.Data;

namespace AutotrasportiFantini.persistenza
{
    class RepositorySpedizione : RepositoryBase<ISpedizione, int>
    {
        public RepositorySpedizione(IDbConnection connection) : base(connection)
        {

        }
        public override bool aggiorna(ISpedizione oggetto)
        {
            throw new NotImplementedException();
        }

        public override int crea(ISpedizione oggetto)
        {
            throw new NotImplementedException();
        }

        public override List<ISpedizione> elencaTutti()
        {
            throw new NotImplementedException();
        }

        public override void elimina(int id)
        {
            throw new NotImplementedException();
        }

        public override ISpedizione getById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
