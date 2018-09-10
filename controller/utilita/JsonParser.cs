using AutotrasportiFantini.modello;
using AutotrasportiFantini.modello.interfacce;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace AutotrasportiFantini.controller
{
	class JsonParser
	{

		/**
		 *	I valori dei campi readonly presentati quà sotto rappresentano
		 *	"nomi" delle chiavi della stringa Json, ottenuta
		 *	dal sistema esterno. Se in futuro il loro formato
		 *	verrà cambiato, basterà cambiare il valore di tali campi
		 */
		private readonly string IDAZIENDALE = "idAziendale";
		private readonly string NOME = "nome";
		private readonly string COGNOME = "cognome";
		private readonly string RUOLO = "ruolo";

		public IUtente ParsificaUtente(string json)
		{
			IUtente utente = null;
			int ruolo = -1;

			JObject datiParsati = JObject.Parse(json);

			//	Ottenimento del ruolo
			ruolo = RoleResolver.GetRuolo((string)datiParsati[RUOLO]);

			//	Controllo del codice del ruolo
			if (ruolo < 0)
				return utente;

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
			int ruolo;
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
