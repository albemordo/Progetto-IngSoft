using Dapper;
using System;
using System.Collections.Generic;
using AutotrasportiFantini.modello.interfacce;
using System.Data;
using AutotrasportiFantini.modello.factory;
using System.Linq;
using AutotrasportiFantini.modello;

namespace AutotrasportiFantini.persistenza.repository
{
    class RepositoryTipologiaMerce : RepositoryBase, IPersistenzaTipologiaMerce
    {
        public RepositoryTipologiaMerce(IDbConnection connection) : base(connection)
        {
        }

        public bool aggiorna(ITipologiaMerce oggetto)
        {
            String sql = "UPDATE TipologiaMerce SET id = @Id, tipologia = @Tipologia";

            using (var connection = this.connection)
            {
                int righeAggiornate = connection.Execute(sql, oggetto);

                return righeAggiornate == 1;
            }
        }

        public ITipologiaMerce crea(ITipologiaMerce oggetto)
        {
            String sql = "INSERT INTO TipologiaMerce (tipologia)" +
                "VALUES (@Tipologia) RETURNING id";

            using (var connection = this.connection)
            {
                int id = connection.QuerySingle<int>(sql, oggetto);
                oggetto.id = id;

                return oggetto;
            }
        }

        public List<ITipologiaMerce> elencaTutti()
        {
            String sql = "SELECT * FROM TipologiaMerce";

            using (var connection = this.connection)
            {
                IEnumerable<ITipologiaMerce> risultato = connection.Query<TipologiaMerce>(sql);

                return risultato.ToList();
            }
        }

        public void elimina(int id)
        {
            String sql = "DELETE FROM TipologiaMerce WHERE id = @Id";

            using (var connection = this.connection)
            {
                connection.Execute(sql, new { Id = id });
            }
        }

        public ITipologiaMerce getById(int id)
        {
            String sql = "SELECT * FROM TipologiaMerce WHERE id = @Id";

            using (var connection = this.connection)
            {
                ITipologiaMerce risultato = connection.QuerySingle<TipologiaMerce>(sql, new { Id = id });

                return risultato;
            }
        }
    }
}
