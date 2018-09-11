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
    class RepositoryIndirizzo : RepositoryBase, IPersistenzaIndirizzo
    {
        public RepositoryIndirizzo(IDbConnection connection) : base(connection)
        {
        }
        public bool aggiorna(IIndirizzo oggetto)
        {
            String sql = "UPDATE Indirizzo SET id = @Id, qualificatore = @Qualificatore, nome = @Nome, " +
                "civico = @Civico, cap = @Cap, localita = @Localita, provincia = @Provincia";

            using (var connection = this.connection)
            {
                int righeAggiornate = connection.Execute(sql, oggetto);

                return righeAggiornate == 1;
            }
        }

        public IIndirizzo crea(IIndirizzo oggetto)
        {
            String sql = "INSERT INTO Indirizzo (qualificatore, nome, civico, cap, localita, provincia)" +
                "VALUES (@Qualificatore, @Nome, @Civico, @Cap, @Localita, @Provincia) RETURNING id";

            using (var connection = this.connection)
            {
                int id = connection.QuerySingle<int>(sql, oggetto);
                oggetto.id = id;

                return oggetto;
            }
        }

        public List<IIndirizzo> elencaTutti()
        {
            String sql = "SELECT * FROM Indirizzo";

            using (var connection = this.connection)
            {
                IEnumerable<IIndirizzo> indirizzi = connection.Query<Indirizzo>(sql);

                return indirizzi.ToList();
            }
        }

        public void elimina(int id)
        {
            String sql = "DELETE FROM Automezzo WHERE id = @Id";

            using (var connection = this.connection)
            {
                connection.Execute(sql, new { Id = id });
            }
        }

        public IIndirizzo getById(int id)
        {
            String sql = "SELECT * FROM Indirizzo WHERE id = @Id";

            using (var connection = this.connection)
            {
                IIndirizzo indirizzo = connection.QuerySingle<Indirizzo>(sql, new { Id = id });

                return indirizzo;
            }
        }

        public IIndirizzo cercaIndirizzo(String qualificatore, String nome, String civico, String cap, String localita, String provincia)
        {
            String sql = "SELECT * FROM Indirizzo WHERE qualificatore LIKE @Qualificatore AND nome = @Nome AND civico = @Civico AND cap = @Cap" +
                "AND localita = @Localita AND provincia = @Provincia";

            using (var connection = this.connection)
            {
                IIndirizzo indirizzo = connection.QuerySingle<Indirizzo>(sql, new
                {
                    Qualificatore = qualificatore,
                    Nome = nome,
                    Civico = civico,
                    Cap = cap,
                    Localita = localita,
                    Provincia = provincia
                });

                return indirizzo;
            }
        }
    }
}
