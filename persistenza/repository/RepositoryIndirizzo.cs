using System;
using System.Collections.Generic;
using AutotrasportiFantini.modello.interfacce;
using System.Data;

namespace AutotrasportiFantini.persistenza.repository
{
    class RepositoryIndirizzo : RepositoryBase, IPersistenzaIndirizzo
    {
        public RepositoryIndirizzo(IDbConnection connection) : base(connection)
        {

        }
        public bool aggiorna(IIndirizzo oggetto)
        {
            throw new NotImplementedException();
        }

        public int crea(IIndirizzo oggetto)
        {
            throw new NotImplementedException();
        }

        public List<IIndirizzo> elencaTutti()
        {
            throw new NotImplementedException();
        }

        public void elimina(int id)
        {
            throw new NotImplementedException();
        }

        public IIndirizzo getById(int id)
        {
            throw new NotImplementedException();
        }

        public IIndirizzo cercaIndirizzo(String qualificatore, String nome, String civico, String cap, String localita, String provincia)
        {
            throw new NotImplementedException();
        }
    }
}
