using AutotrasportiFantini.modello;
using AutotrasportiFantini.modello.interfacce;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using static AutotrasportiFantini.modello.FactoryUtenti;

namespace AutotrasportiFantini.controller.utilita
{
	class JsonParser
	{

		/**
		 *	I valori dei campi definiti appena sotto, servono
		 *	per fare match tra il formato del sistema esterno
		 *	e il loro signifcato all'interno dell'applicazione
		 */

		readonly string IDAZIENDALE = "idAziendale";
		readonly string NOME = "nome";
		readonly string COGNOME = "cognome";
		readonly string RUOLO = "ruolo";

		public IUtente ParsificaUtente(string json)
		{
			IUtente utente = null;
			Utenti ruolo;

			JObject datiParsati = JObject.Parse(json);

			//	Ottenimento del ruolo
			ruolo = RoleResolver.GetRuolo((string)datiParsati[RUOLO]);

			//	In base al ruolo viene creata l'istanza di utente appropriata
			utente = FactoryUtenti.GetUtente(ruolo);

			//	Popolamento degli attributi di utente
			utente.idAziendale = (string)datiParsati[IDAZIENDALE];
			utente.nome = (string)datiParsati[NOME];
			utente.cognome = (string)datiParsati[COGNOME];

			return utente;
		}

		public List<IUtente> ParsificaListaUtenti(string json)
		{
			List<IUtente> utenti = new List<IUtente>();
			Utenti ruolo;
			IUtente utente = null;

			//	Parsing dell'oggetto Json
			JArray jArray = JArray.Parse(json);

			//	Popolamento dei campi
			foreach (JToken token in jArray)
			{
				//	Controllo errori dei campi

				if (token != null && token[IDAZIENDALE] != null && token[NOME] != null && token[COGNOME] != null && token[RUOLO] != null)
				{
					//	Nessun errore

					//	Ottenimento del ruolo
					ruolo = RoleResolver.GetRuolo((string)token[RUOLO]);

					utente = FactoryUtenti.GetUtente(ruolo);

					//	Inizializzazione campi
					utente.idAziendale = (string)token[IDAZIENDALE];
					utente.nome = (string)token[NOME];
					utente.cognome = (string)token[COGNOME];

					//	Aggiunta dell'oggetto nella struttura dati di ritorno
					utenti.Add(utente);
				}
				else
				{
					//	Errore durante il controllo dei campi

				}
			}

			return utenti;
		}
	}
}
