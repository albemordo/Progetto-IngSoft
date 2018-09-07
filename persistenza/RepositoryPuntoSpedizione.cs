using System;
using System.Collections.Generic;
using AutotrasportiFantini.modello.interfacce;
using System.Data.SqlClient;

namespace AutotrasportiFantini.persistenza
{
    class RepositoryPuntoSpedizione : RepositoryBase<IPuntoSpedizione, int>
    {
        public RepositoryPuntoSpedizione(SqlConnection connection) : base(connection)
        {

        }
        public override bool aggiorna(IPuntoSpedizione oggetto)
        {
            throw new NotImplementedException();
        }

        public override int crea(IPuntoSpedizione oggetto)
        {
            throw new NotImplementedException();
        }

        public override List<IPuntoSpedizione> elencaTutti()
        {
            throw new NotImplementedException();
        }

        public override void elimina(int id)
        {
            throw new NotImplementedException();
        }

        public override IPuntoSpedizione getById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
