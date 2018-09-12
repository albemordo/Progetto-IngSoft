using Dapper;
using System;
using System.Collections.Generic;
using AutotrasportiFantini.modello.interfacce;
using System.Data;
using System.Linq;
using AutotrasportiFantini.modello.factory;
using AutotrasportiFantini.modello;
using Newtonsoft.Json;
using AutotrasportiFantini.persistenza.repository.factory;

namespace AutotrasportiFantini.persistenza.repository
{
    class RepositorySpedizione : RepositoryBase, IPersistenzaSpedizione
    {
        public RepositorySpedizione(DbConnectionFactory factory, DbConnectionFactory.SupportedDBMS dbms, String connectionName) : base(factory, dbms, connectionName)
        {
        }

        public bool aggiorna(ISpedizione oggetto)
        {
            String sqlSpedizione = "UPDATE Spedizione SET orarioprevistopartenza = @OrarioPrevistoPartenza, orarioprevistoarrivo = @OrarioPrevistoArrivo, orarioeffettivopartenza = @OrarioEffettivoPartenza, " +
                "orarioeffettivoarrivo = @OrarioEffettivoArrivo, distanzastimata = @DistanzaStimata, distanzaeffettiva = @DistanzaEffettiva, durata = @Durata, codicedelegato = @CodiceDelegato, " +
                "codiceautista = @CodiceAutista, fk_tipologiamerce = @CodiceTipologiaMerce, fk_automezzo = @CodiceAutomezzo, quantitamerce = @QuantitaMerce, fk_indirizzo_partenza = @CodiceIndirizzoPartenza, " +
                "fk_indirizzo_arrivo = @CodiceIndirizzoArrivo WHERE id = @Id";

            using (var connection = this.getConnection())
            {
                String codiceDelegato = oggetto.delegato == null ? null : oggetto.delegato.idAziendale;
                String codiceAutista = oggetto.autista == null ? null : oggetto.autista.idAziendale;
                String codiceAutomezzo = oggetto.automezzo == null ? null : oggetto.automezzo.targa;

                int aggiornaSpedizione = connection.Execute(sqlSpedizione, new
                {
                    @OrarioPrevistoPartenza = oggetto.orarioPrevistoPartenza,
                    @OrarioPrevistoArrivo = oggetto.orarioPrevistoArrivo,
                    @OrarioEffettivoPartenza = oggetto.orarioEffettivoPartenza,
                    @OrarioEffettivoArrivo = oggetto.orarioEffettivoArrivo,
                    @DistanzaStimata = oggetto.distanzaStimata,
                    @DistanzaEffettiva = oggetto.distanzaEffettiva,
                    @Durata = oggetto.tempoPercorrenza,
                    @CodiceDelegato = codiceDelegato,
                    @CodiceAutista = codiceAutista,
                    @CodiceTipologiaMerce = oggetto.tipologiaMerce.id,
                    @CodiceAutomezzo = codiceAutomezzo,
                    @QuantitaMerce = oggetto.quantitaMerce,
                    @CodiceIndirizzoPartenza = oggetto.partenza.id,
                    @CodiceIndirizzoArrivo = oggetto.destinazione.id,
                    @Id = oggetto.id
                });

                bool aggiornaPuntoSpedizione = true;
                foreach (IPuntoSpedizione puntoSpedizione in oggetto.puntiSpedizione)
                {
                    if (!this.aggiornaPuntoSpedizione(puntoSpedizione))
                        aggiornaPuntoSpedizione = false;
                }

                return (aggiornaSpedizione == 1 && aggiornaPuntoSpedizione);
            }
        }

        public List<ISpedizione> cercaPerAutista(string codiceAutista)
        {
            String sql = "SELECT " +
                    "s.id, s.distanzaStimata, s.distanzaEffettiva, s.quantitaMerce, s.durata, s.orarioPrevistoPartenza, s.orarioPrevistoArrivo, s.orarioEffettivoPartenza, s.orarioEffettivoArrivo, s.codiceDelegato, s.codiceAutista, " +
                    "tm.id, tm.tipologia, " +
                    "a.*, " +
                    "ip.id, ip.qualificatore, ip.nome, ip.civico, ip.cap, ip.localita, ip.provincia, " +
                    "ia.id, ia.qualificatore, ia.nome, ia.civico, ip.cap, ia.localita, ia.provincia, " +
                    "ps.id, ps.fk_spedizione, ps.orario_arrivo, " +
                    "ips.id, ips.qualificatore, ips.nome, ips.civico, ips.cap, ips.localita, ips.provincia " +
                    "FROM spedizione as s " +
                    "INNER JOIN tipologiamerce as tm ON tm.id = s.fk_tipologiamerce " +
                    "LEFT OUTER JOIN automezzo as a ON a.targa = s.fk_automezzo " +
                    "INNER JOIN indirizzo as ip ON ip.id = s.fk_indirizzo_partenza " +
                    "INNER JOIN indirizzo as ia ON ia.id = s.fk_indirizzo_arrivo " +
                    "INNER JOIN puntospedizione as ps ON ps.fk_spedizione = s.id " +
                    "INNER JOIN indirizzo as ips ON ips.id = ps.fk_indirizzo" +
                    "WHERE s.codiceAutista = @CodiceAutista";

            using (var connection = this.getConnection())
            {
                var dizionarioSpedizioni = new Dictionary<int, Spedizione>();
                IEnumerable<ISpedizione> spedizioni = connection.Query<Spedizione, TipologiaMerce, Automezzo, Indirizzo, Indirizzo, PuntoSpedizione, Indirizzo, Spedizione>(
                    sql,
                    (spedizione, tipologiaMerce, automezzo, indirizzoPartenza, indirizzoArrivo, puntoSpedizione, indirizzoPuntoSpedizione) =>
                    {
                        Spedizione entrySpedizione;

                        if (!dizionarioSpedizioni.TryGetValue(spedizione.id, out entrySpedizione))
                        {
                            entrySpedizione = spedizione;

                            spedizione.tipologiaMerce = tipologiaMerce;
                            spedizione.automezzo = automezzo;
                            spedizione.partenza = indirizzoPartenza;
                            spedizione.destinazione = indirizzoArrivo;

                            dizionarioSpedizioni.Add(spedizione.id, entrySpedizione);
                        }

                        puntoSpedizione.indirizzo = indirizzoPuntoSpedizione;
                        entrySpedizione.puntiSpedizione.Add(puntoSpedizione);

                        return entrySpedizione;
                    }, new { CodiceAutista = codiceAutista }, splitOn: "id,targa,id,id,id,id"
                    ).Distinct();

                return spedizioni.ToList();
            }
        }

        public List<ISpedizione> cercaPerDelegato(string codiceDelegato)
        {
            String sql = "SELECT " +
                    "s.id, s.distanzaStimata, s.distanzaEffettiva, s.quantitaMerce, s.durata, s.orarioPrevistoPartenza, s.orarioPrevistoArrivo, s.orarioEffettivoPartenza, s.orarioEffettivoArrivo, s.codiceDelegato, s.codiceAutista, " +
                    "tm.id, tm.tipologia, " +
                    "a.*, " +
                    "ip.id, ip.qualificatore, ip.nome, ip.civico, ip.cap, ip.localita, ip.provincia, " +
                    "ia.id, ia.qualificatore, ia.nome, ia.civico, ip.cap, ia.localita, ia.provincia, " +
                    "ps.id, ps.fk_spedizione, ps.orario_arrivo, " +
                    "ips.id, ips.qualificatore, ips.nome, ips.civico, ips.cap, ips.localita, ips.provincia " +
                    "FROM spedizione as s " +
                    "INNER JOIN tipologiamerce as tm ON tm.id = s.fk_tipologiamerce " +
                    "LEFT OUTER JOIN automezzo as a ON a.targa = s.fk_automezzo " +
                    "INNER JOIN indirizzo as ip ON ip.id = s.fk_indirizzo_partenza " +
                    "INNER JOIN indirizzo as ia ON ia.id = s.fk_indirizzo_arrivo " +
                    "INNER JOIN puntospedizione as ps ON ps.fk_spedizione = s.id " +
                    "INNER JOIN indirizzo as ips ON ips.id = ps.fk_indirizzo" +
                    "WHERE s.codiceDelegato = @CodiceDelegato";

            using (var connection = this.getConnection())
            {
                var dizionarioSpedizioni = new Dictionary<int, Spedizione>();
                IEnumerable<ISpedizione> spedizioni = connection.Query<Spedizione, TipologiaMerce, Automezzo, Indirizzo, Indirizzo, PuntoSpedizione, Indirizzo, Spedizione>(
                    sql,
                    (spedizione, tipologiaMerce, automezzo, indirizzoPartenza, indirizzoArrivo, puntoSpedizione, indirizzoPuntoSpedizione) =>
                    {
                        Spedizione entrySpedizione;

                        if (!dizionarioSpedizioni.TryGetValue(spedizione.id, out entrySpedizione))
                        {
                            entrySpedizione = spedizione;

                            spedizione.tipologiaMerce = tipologiaMerce;
                            spedizione.automezzo = automezzo;
                            spedizione.partenza = indirizzoPartenza;
                            spedizione.destinazione = indirizzoArrivo;

                            dizionarioSpedizioni.Add(spedizione.id, entrySpedizione);
                        }

                        puntoSpedizione.indirizzo = indirizzoPuntoSpedizione;
                        entrySpedizione.puntiSpedizione.Add(puntoSpedizione);

                        return entrySpedizione;
                    }, new { CodiceDelegato = codiceDelegato }, splitOn: "id,targa,id,id,id,id"
                    ).Distinct();

                return spedizioni.ToList();
            }
        }

        public ISpedizione crea(ISpedizione oggetto)
        {
            String sqlSpedizione = "INSERT INTO Spedizione (orarioprevistopartenza, orarioprevistoarrivo, orarioeffettivopartenza, orarioeffettivoarrivo, distanzastimata, distanzaeffettiva, durata, codicedelegato, codiceautista," +
                "fk_tipologiamerce, fk_automezzo, quantitamerce, fk_indirizzo_partenza, fk_indirizzo_arrivo) VALUES (@OrarioPrevistoPartenza, @OrarioPrevistoArrivo, @OrarioEffettivoPartenza, @OrarioEffettivoArrivo, " +
                "@DistanzaStimata, @DistanzaEffettiva, @Durata, @CodiceDelegato, @CodiceAutista, @CodiceTipologiaMerce, @CodiceAutomezzo, @QuantitaMerce, @CodiceIndirizzoPartenza, @CodiceIndirizzoArrivo) RETURNING id";
            String sqlPuntoSpedizione = "INSERT INTO PuntoSpedizione (fk_spedizione, fk_indirizzo, orario_arrivo) VALUES (@CodiceSpedizione, @CodiceIndirizzo, @OrarioArrivo) RETURNING id";

            using (var connection = this.getConnection())
            {
                String codiceDelegato = oggetto.delegato == null ? null : oggetto.delegato.idAziendale;
                String codiceAutista = oggetto.autista == null ? null : oggetto.autista.idAziendale;
                String codiceAutomezzo = oggetto.automezzo == null ? null : oggetto.automezzo.targa;

                int idSpedizione = connection.QuerySingle<int>(sqlSpedizione, new
                {
                    @OrarioPrevistoPartenza = oggetto.orarioPrevistoPartenza,
                    @OrarioPrevistoArrivo = oggetto.orarioPrevistoArrivo,
                    @OrarioEffettivoPartenza = oggetto.orarioEffettivoPartenza,
                    @OrarioEffettivoArrivo = oggetto.orarioEffettivoArrivo,
                    @DistanzaStimata = oggetto.distanzaStimata,
                    @DistanzaEffettiva = oggetto.distanzaEffettiva,
                    @Durata = oggetto.tempoPercorrenza,
                    @CodiceDelegato = codiceDelegato,
                    @CodiceAutista = codiceAutista,
                    @CodiceTipologiaMerce = oggetto.tipologiaMerce.id,
                    @CodiceAutomezzo = codiceAutomezzo,
                    @QuantitaMerce = oggetto.quantitaMerce,
                    @CodiceIndirizzoPartenza = oggetto.partenza.id,
                    @CodiceIndirizzoArrivo = oggetto.destinazione.id
                });

                oggetto.id = idSpedizione;

                foreach(IPuntoSpedizione puntoSpedizione in oggetto.puntiSpedizione)
                {
                    puntoSpedizione.spedizione = oggetto.id;

                    int idPuntoSpedizione = connection.QuerySingle<int>(sqlPuntoSpedizione, new
                    {
                        @CodiceSpedizione = puntoSpedizione.spedizione,
                        @CodiceIndirizzo = puntoSpedizione.indirizzo.id,
                        @OrarioArrivo = puntoSpedizione.orarioArrivo
                    });

                    puntoSpedizione.id = idPuntoSpedizione;
                }

                return oggetto;
            }
        }

        public List<ISpedizione> elencaTutti()
        {
            String sql = "SELECT " +
                    "s.id, s.distanzaStimata, s.distanzaEffettiva, s.quantitaMerce, s.durata, s.orarioPrevistoPartenza, s.orarioPrevistoArrivo, s.orarioEffettivoPartenza, s.orarioEffettivoArrivo, s.codiceDelegato, s.codiceAutista, " +
                    "tm.id, tm.tipologia, " +
                    "a.*, " +
                    "ip.id, ip.qualificatore, ip.nome, ip.civico, ip.cap, ip.localita, ip.provincia, " +
                    "ia.id, ia.qualificatore, ia.nome, ia.civico, ip.cap, ia.localita, ia.provincia, " +
                    "ps.id, ps.fk_spedizione as spedizione, ps.orario_arrivo, " +
                    "ips.id, ips.qualificatore, ips.nome, ips.civico, ips.cap, ips.localita, ips.provincia " +
                    "FROM spedizione as s " +
                    "INNER JOIN tipologiamerce as tm ON tm.id = s.fk_tipologiamerce " +
                    "LEFT OUTER JOIN automezzo as a ON a.targa = s.fk_automezzo " +
                    "INNER JOIN indirizzo as ip ON ip.id = s.fk_indirizzo_partenza " +
                    "INNER JOIN indirizzo as ia ON ia.id = s.fk_indirizzo_arrivo " +
                    "INNER JOIN puntospedizione as ps ON ps.fk_spedizione = s.id " +
                    "INNER JOIN indirizzo as ips ON ips.id = ps.fk_indirizzo";

            using (var connection = this.getConnection())
            {
                var dizionarioSpedizioni = new Dictionary<int, Spedizione>();
                IEnumerable<ISpedizione> spedizioni = connection.Query<Spedizione, TipologiaMerce, Automezzo, Indirizzo, Indirizzo, PuntoSpedizione, Indirizzo, Spedizione>(
                    sql,
                    (spedizione, tipologiaMerce, automezzo, indirizzoPartenza, indirizzoArrivo, puntoSpedizione, indirizzoPuntoSpedizione) =>
                    {
                        Spedizione entrySpedizione;

                        if (!dizionarioSpedizioni.TryGetValue(spedizione.id, out entrySpedizione))
                        {
                            entrySpedizione = spedizione;

                            spedizione.tipologiaMerce = tipologiaMerce;
                            spedizione.automezzo = automezzo;
                            spedizione.partenza = indirizzoPartenza;
                            spedizione.destinazione = indirizzoArrivo;

                            dizionarioSpedizioni.Add(spedizione.id, entrySpedizione);
                        }

                        puntoSpedizione.indirizzo = indirizzoPuntoSpedizione;
                        entrySpedizione.puntiSpedizione.Add(puntoSpedizione);

                        return entrySpedizione;
                    }, splitOn: "id,targa,id,id,id,id"
                    ).Distinct();

                return spedizioni.ToList();
            }
        }

        public void elimina(int id)
        {
            String sql = "DELETE FROM Spedizione WHERE id = @Id";

            using (var connection = this.getConnection())
            {
                connection.Execute(sql, new { Id = id });
            }
        }

        public ISpedizione getById(int id)
        {
            String sql = "SELECT " +
                    "s.id, s.distanzaStimata, s.distanzaEffettiva, s.quantitaMerce, s.durata, s.orarioPrevistoPartenza, s.orarioPrevistoArrivo, s.orarioEffettivoPartenza, s.orarioEffettivoArrivo, s.codiceDelegato, s.codiceAutista, " +
                    "tm.id, tm.tipologia, " +
                    "a.*, " +
                    "ip.id, ip.qualificatore, ip.nome, ip.civico, ip.cap, ip.localita, ip.provincia, " +
                    "ia.id, ia.qualificatore, ia.nome, ia.civico, ip.cap, ia.localita, ia.provincia, " +
                    "ps.id, ps.fk_spedizione as spedizione, ps.orario_arrivo, " +
                    "ips.id, ips.qualificatore, ips.nome, ips.civico, ips.cap, ips.localita, ips.provincia " +
                    "FROM spedizione as s " +
                    "INNER JOIN tipologiamerce as tm ON tm.id = s.fk_tipologiamerce " +
                    "LEFT OUTER JOIN automezzo as a ON a.targa = s.fk_automezzo " +
                    "INNER JOIN indirizzo as ip ON ip.id = s.fk_indirizzo_partenza " +
                    "INNER JOIN indirizzo as ia ON ia.id = s.fk_indirizzo_arrivo " +
                    "INNER JOIN puntospedizione as ps ON ps.fk_spedizione = s.id " +
                    "INNER JOIN indirizzo as ips ON ips.id = ps.fk_indirizzo " +
                    "WHERE s.id = @Id";

            using (var connection = this.getConnection())
            {
                var dizionarioSpedizioni = new Dictionary<int, Spedizione>();
                IEnumerable<ISpedizione> spedizioni = connection.Query<Spedizione, TipologiaMerce, Automezzo, Indirizzo, Indirizzo, PuntoSpedizione, Indirizzo, Spedizione>(
                    sql,
                    (spedizione, tipologiaMerce, automezzo, indirizzoPartenza, indirizzoArrivo, puntoSpedizione, indirizzoPuntoSpedizione) =>
                    {
                        Spedizione entrySpedizione;

                        if (!dizionarioSpedizioni.TryGetValue(spedizione.id, out entrySpedizione))
                        {
                            entrySpedizione = spedizione;

                            spedizione.tipologiaMerce = tipologiaMerce;
                            spedizione.automezzo = automezzo;
                            spedizione.partenza = indirizzoPartenza;
                            spedizione.destinazione = indirizzoArrivo;

                            dizionarioSpedizioni.Add(spedizione.id, entrySpedizione);
                        }

                        puntoSpedizione.indirizzo = indirizzoPuntoSpedizione;
                        entrySpedizione.puntiSpedizione.Add(puntoSpedizione);

                        return entrySpedizione;
                    }, new { Id = id }, splitOn: "id,targa,id,id,id,id"
                    ).Distinct();

                return spedizioni.Single();
            }
        }

        public bool aggiornaPuntoSpedizione(IPuntoSpedizione puntoSpedizione)
        {
            String sqlPuntoSpedizione = "UPDATE PuntoSpedizione SET fk_spedizione = @CodiceSpedizione, fk_indirizzo = @CodiceIndirizzo, orario_arrivo = @OrarioArrivo WHERE id = @Id";

            using (var connection = this.getConnection())
            {
                int aggiornati = connection.Execute(sqlPuntoSpedizione, new
                {
                    @CodiceSpedizione = puntoSpedizione.spedizione,
                    @CodiceIndirizzo = puntoSpedizione.indirizzo.id,
                    @OrarioArrivo = puntoSpedizione.orarioArrivo,
                    @Id = puntoSpedizione.id
                });

                return aggiornati > 0;
            }
        }
    }
}
