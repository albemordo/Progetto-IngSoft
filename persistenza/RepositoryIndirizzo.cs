using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutotrasportiFantini.modello.interfacce;
using System.Data.SqlClient;

namespace AutotrasportiFantini.persistenza
{
    class RepositoryIndirizzo : RepositoryBase<IIndirizzo, int>
    {
        public RepositoryIndirizzo(SqlConnection connection) : base(connection)
        {

        }
        public override bool aggiorna(IIndirizzo oggetto)
        {
            throw new NotImplementedException();
        }

        public override int crea(IIndirizzo oggetto)
        {
            throw new NotImplementedException();
        }

        public override List<IIndirizzo> elencaTutti()
        {
            throw new NotImplementedException();
        }

        public override void elimina(int id)
        {
            throw new NotImplementedException();
        }

        public override IIndirizzo getById(int id)
        {
            throw new NotImplementedException();
        }

        public IIndirizzo cercaIndirizzo(String qualificatore, String nome, String civico, String cap, String localita, String provincia)
        {
            throw new NotImplementedException();
        }
    }
}
