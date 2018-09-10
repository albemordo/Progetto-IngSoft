using Dapper;
using System;
using System.Collections.Generic;
using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.modello.factory;
using System.Data;

namespace AutotrasportiFantini.persistenza.repository
{
    class RepositoryAutomezzo : RepositoryBase, IPersistenzaAutomezzo
    {
        public RepositoryAutomezzo(IDbConnection connection) : base(connection)
        {
        }
        public bool aggiorna(IAutomezzo oggetto)
        {
            String sql = "UPDATE Automezzo SET targa = @Targa, modello = @Modello, produttore = @Produttore," +
                "targa_rimorchio = @TargaRimorchio, cod_delegato = @CodiceDelegato WHERE targa = @Targa";

            using (var connection = this.connection)
            {
                int righeAggiornate = connection.Execute(sql, oggetto);

                return righeAggiornate == 1;
            }
        }

        public String crea(IAutomezzo oggetto)
        {
            String sql = "INSERT INTO Automezzo (targa, modello, produttore, targa_rimorchio, cod_delegato)" +
                "VALUES (@Targa, @Modello, @Produttore, @TargaRimorchio, @CodiceDelegato) RETURNING targa";

            using (var connection = this.connection)
            {
                String targa = connection.QuerySingle<String>(sql, oggetto);

                return targa;
            }
        }

        public List<IAutomezzo> elencaTutti()
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

        public List<IAutomezzo> elencaPerDelegato(String codiceDelegato)
        {
            String sql = "SELECT * FROM Automezzo WHERE cod_delegato = @CodiceDelegato";

            using (var connection = this.connection)
            {
                var rawAutomezzi = connection.Query(sql, new { CodiceDelegato = codiceDelegato }).AsList();

                List<IAutomezzo> automezzi = new List<IAutomezzo>();
                foreach (var rawAutomezzo in rawAutomezzi)
                {
                    automezzi.Add(this.FillFromDb(rawAutomezzo));
                }

                return automezzi;
            }
        }

        public void elimina(String id)
        {
            String sql = "DELETE FROM Automezzo WHERE targa = @Targa";

            using (var connection = this.connection)
            {
                connection.Execute(sql, new { Targa = id });
            }
        }

        public IAutomezzo getById(String id)
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
            IRisorseFactory factoryRisorse = new RisorseFactory();
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
