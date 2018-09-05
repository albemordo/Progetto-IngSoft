using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutotrasportiFantini.modello.interfacce;
using System.Data.SqlClient;

namespace AutotrasportiFantini.persistenza
{
    class RepositoryAutomezzo : RepositoryBase<IAutomezzo, int>
    {
        public RepositoryAutomezzo(SqlConnection connection) : base(connection)
        {
        }
        public override bool aggiorna(IAutomezzo oggetto)
        {
            throw new NotImplementedException();
        }

        public override int crea(IAutomezzo oggetto)
        {
            throw new NotImplementedException();
        }

        public override List<IAutomezzo> elencaTutti()
        {
            throw new NotImplementedException();
        }

        public override void elimina(int id)
        {
            throw new NotImplementedException();
        }

        public override IAutomezzo getById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
