using Dapper;
using System;
using System.Collections.Generic;
using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.modello.factory;
using System.Data;

namespace AutotrasportiFantini.persistenza
{
    class RepositoryAutomezzo : RepositoryBase<IAutomezzo, String>
    {
        public RepositoryAutomezzo(IDbConnection connection) : base(connection)
        {
        }
        public override bool aggiorna(IAutomezzo oggetto)
        {
            throw new NotImplementedException();
        }

        public override String crea(IAutomezzo oggetto)
        {
            throw new NotImplementedException();
        }

        public override List<IAutomezzo> elencaTutti()
        {
            String sql = "SELECT * FROM Automezzo";

            using (var connection = this.connection)
            {
                var rawAutomezzi = connection.Query(sql).AsList();
                
                List<IAutomezzo> automezzi = new List<IAutomezzo>();
                foreach(var rawAutomezzo in rawAutomezzi)
                {
                    automezzi.Add(this.FillFromDb(rawAutomezzo));
                }

                return automezzi;
            }
        }

        public override void elimina(String id)
        {
            throw new NotImplementedException();
        }

        public override IAutomezzo getById(String id)
        {
            String sql = "SELECT * FROM Automezzo WHERE targa LIKE @TargaAutomezzo";

            using (var connection = this.connection)
            {
                var rawAutomezzo = connection.QuerySingle(sql, new { TargaAutomezzo = id });

                return this.FillFromDb(rawAutomezzo);
            }
        }

        protected IAutomezzo FillFromDb(dynamic raw)
        {
            IFactoryRisorse factoryRisorse = new FactoryRisorse();
            IAutomezzo automezzo = factoryRisorse.GetAutomezzo();

            automezzo.targa = raw.targa;
            automezzo.modello = raw.modello;
            automezzo.produttore = raw.produttore;
            automezzo.targaRimorchio = raw.targa_rimorchio;
            automezzo.codiceDelegato = raw.cod_delegato;

            return automezzo;
        }
    }
}
