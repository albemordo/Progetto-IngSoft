using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello;
using AutotrasportiFantini.modello.factory;
using AutotrasportiFantini.modello.interfacce;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace AutotrasportiFantini.controller
{
    class ControllerGestioneDipendenti : IControllerGestioneDipendenti
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

		/**
		 *	Funzione da modificare quando si vorrà
		 *	effettuare il collegamento con il sistema esterno
		 */
		private String OttieniListaAutisti()
		{
			return @"[
				{
					'idAziendale' : 'AFX132',
					'nome' : 'Matteo',
					'cognome' : 'Bondini'
				},
				{
					'idAziendale' : 'ADX132',
					'nome' : 'Dario',
					'cognome' : 'Rondini'
				},
			]";
		}

		/**
		 *	Funzione da modificare quando si vorrà
		 *	effettuare il collegamento con il sistema esterno
		 */
		private String OttieniListaDelegati()
		{
			return @"[
				{
					'idAziendale' : 'DAS544',
					'nome' : 'Luigi',
					'cognome' : 'Delnero'
				},
				{
					'idAziendale' : 'AND103',
					'nome' : 'Pierluigi',
					'cognome' : 'Verona'
				},
			]";
		}

		private String OttieniUtente(string username, string password)
		{
			string dati = null;

			//	Password codificata in SHA equivalente a "password"
			if (username.ToUpper().Equals("DAS544") && password.Equals("-231203086"))
				dati = @"
				{
					'idAziendale' : 'DAS544',
					'nome' : 'Luigi',
					'cognome' : 'Delnero',
					'ruolo' : 'delegato'
				}";
			else if (username.ToUpper().Equals("ADX132") && password.Equals("-231203086"))
				dati = @"
				{
					'idAziendale' : 'ADX132',
					'nome' : 'Dario',
					'cognome' : 'Rondini',
					'ruolo' : 'autista'
				}";

			return dati;
		}

		private List<IUtente> ParsificaListaUtenti(int qualeLista)
		{
			string lista = null;
			List<IUtente> utenti = new List<IUtente>();
			Type tipo;

			switch (qualeLista)
			{
				case 0:
					lista = OttieniListaAutisti();
					tipo = typeof(IAutista);
					break;

				case 1:
					lista = OttieniListaDelegati();
					tipo = typeof(IDelegato);
					break;

				default:
					return null;
			}

			if (lista == null)
				return utenti;

			IUtente autista = null;

			//	Parsing dell'oggetto Json
			JArray jArray = JArray.Parse(lista);

			//	Popolamento dei campi
			foreach (JToken token in jArray)
			{
				//	Controllo errori dei campi

				if (token != null && token[IDAZIENDALE] != null && token[NOME] != null && token[COGNOME] != null)
				{
					//	Nessun errore

					autista = (Type.GetType(tipo))FactoryUtenti.GetUtente(FactoryUtenti.AUTISTA);

					//	Inizializzazione campi
					autista.idAziendale = (string)token[IDAZIENDALE];
					autista.nome = (string)token[NOME];
					autista.cognome = (string)token[COGNOME];

					//	Aggiunta dell'oggetto nella struttura dati di ritorno
					result.Add(autista);
				}
				else
				{
					//	Errore durante il controllo dei campi

				}
			}

			return utenti;
		}

		public List<IAutista> ListaAutisti()
        {
			List<IAutista> result = new List<IAutista>();

			//	Ottenimento oggetto Json
			String lista = OttieniListaAutisti();

			if (lista == null)
				return result;
			
			IAutista autista = null;

			//	Parsing dell'oggetto Json
			JArray jArray = JArray.Parse(lista);

			//	Popolamento dei campi
			foreach (JToken token in jArray)
			{
				//	Controllo errori dei campi

				if (token != null && token[IDAZIENDALE] != null && token[NOME] != null && token[COGNOME] != null)
				{
					//	Nessun errore

					autista = (IAutista)FactoryUtenti.GetUtente(FactoryUtenti.AUTISTA);

					//	Inizializzazione campi
					autista.idAziendale = (string)token[IDAZIENDALE];
					autista.nome = (string)token[NOME];
					autista.cognome = (string)token[COGNOME];

					//	Aggiunta dell'oggetto nella struttura dati di ritorno
					result.Add(autista);
				}
				else
				{
					//	Errore durante il controllo dei campi
					
				}
			}

			return result;
        }

        public List<IDelegato> ListaDelegati()
        {
			List<IDelegato> result = new List<IDelegato>();

			//	Ottenimento oggetto Json
			String lista = OttieniListaAutisti();

			if (lista == null)
				return result;

			IDelegato delegato = null;

			//	Parsing dell'oggetto Json
			JArray jArray = JArray.Parse(lista);

			//	Popolamento dei campi
			foreach (JToken token in jArray)
			{
				//	Controllo errori dei campi

				if (token != null && token[IDAZIENDALE] != null && token[NOME] != null && token[COGNOME] != null)
				{
					//	Nessun errore

					delegato = (IDelegato)FactoryUtenti.GetUtente(FactoryUtenti.AUTISTA);

					//	Inizializzazione campi
					delegato.idAziendale = (string)token[IDAZIENDALE];
					delegato.nome = (string)token[NOME];
					delegato.cognome = (string)token[COGNOME];

					//	Aggiunta dell'oggetto nella struttura dati di ritorno
					result.Add(delegato);
				}
				else
				{
					//	Errore durante il controllo dei campi

				}
			}

			return result;
		}

        /**
         *  Anche questo andava eliminato, se non ricordo male
         */
        public string RuoloUtente(IUtente utente)
        {
			throw new NotImplementedException();
        }

        public IUtente VerificaCredenziali(string username, string password)
        {
			/**
			*	TODO: controllo errori
			*/

			IUtente utente = null;

			//	Ottenimento dell'oggetto dei dati parsati
			string dati = OttieniUtente(username, password);

			//	Se il campo dati è nullo, allora le credenziali non sono corrette
			if (dati == null)
				return utente;

			JObject datiParsati = JObject.Parse(dati);

			//	Viene estratto il ruolo
			string ruolo = (string)datiParsati[RUOLO];

			//	In base al ruolo viene creata l'istanza di utente appropriata
			utente = FactoryUtenti.GetUtente(ruolo);

			//	Popolamento degli attributi di utente
			utente.idAziendale = (string)datiParsati[IDAZIENDALE];
			utente.nome = (string)datiParsati[NOME];
			utente.cognome = (string)datiParsati[COGNOME];

			return utente;
		}

        
        public static void Main(string[] args)
        {
			IControllerGestioneDipendenti gd = new ControllerGestioneDipendenti();
			Console.WriteLine(typeof(IAutista));

		}
        
    }

}
