using Dapper;
using System;
using System.Collections.Generic;
using AutotrasportiFantini.modello.interfacce;
using System.Data;
using AutotrasportiFantini.modello;
using System.Linq;
using AutotrasportiFantini.persistenza.repository.factory;

namespace AutotrasportiFantini.persistenza.repository
{
    class RepositoryAutomezzo : RepositoryBase, IPersistenzaAutomezzo
    {
        public RepositoryAutomezzo(DbConnectionFactory factory, DbConnectionFactory.SupportedDBMS dbms, String connectionName) : base(factory, dbms, connectionName)
        {
        }
        public bool aggiorna(IAutomezzo oggetto)
        {
            String sql = "UPDATE Automezzo SET targa = @Targa, modello = @Modello, produttore = @Produttore," +
                "targarimorchio = @TargaRimorchio, codicedelegato = @CodiceDelegato WHERE targa = @Targa";

            using (var connection = this.getConnection())
            {
                int righeAggiornate = connection.Execute(sql, oggetto);

                return righeAggiornate == 1;
            }
        }

        public IAutomezzo crea(IAutomezzo oggetto)
        {
            String sql = "INSERT INTO Automezzo (targa, modello, produttore, targarimorchio, codicedelegato)" +
                "VALUES (@Targa, @Modello, @Produttore, @TargaRimorchio, @CodiceDelegato) RETURNING targa";

            using (var connection = this.getConnection())
            {
                String targa = connection.QuerySingle<String>(sql, oggetto);

                return oggetto;
            }
        }

        public List<IAutomezzo> elencaTutti()
        {
            String sql = "SELECT * FROM Automezzo";

            using (var connection = this.getConnection())
            {
                IEnumerable<IAutomezzo> automezzi = connection.Query<Automezzo>(sql);

                return automezzi.ToList();
            }
        }

        public List<IAutomezzo> elencaPerDelegato(String codiceDelegato)
        {
            String sql = "SELECT * FROM Automezzo WHERE codicedelegato = @CodiceDelegato";

            using (var connection = this.getConnection())
            {
                IEnumerable<IAutomezzo> automezzi = connection.Query<Automezzo>(sql, new { CodiceDelegato = codiceDelegato });

                return automezzi.ToList();
            }
        }

        public void elimina(String id)
        {
            String sql = "DELETE FROM Automezzo WHERE targa = @Targa";

            using (var connection = this.getConnection())
            {
                connection.Execute(sql, new { Targa = id });
            }
        }

        public IAutomezzo getById(String id)
        {
            String sql = "SELECT * FROM Automezzo WHERE targa LIKE @TargaAutomezzo";

            using (var connection = this.getConnection())
            {
                IAutomezzo automezzo = connection.QuerySingle<Automezzo>(sql, new { TargaAutomezzo = id });

                return automezzo;
            }
        }
    }
}
