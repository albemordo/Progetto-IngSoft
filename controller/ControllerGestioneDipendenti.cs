using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.controller.log;
using AutotrasportiFantini.controller.log.interfacce;
using AutotrasportiFantini.controller.utilita;
using AutotrasportiFantini.modello.interfacce;
using System;
using System.Collections.Generic;

namespace AutotrasportiFantini.controller
{
	class ControllerGestioneDipendenti : IControllerGestioneDipendenti
	{
		/**
		 *	I seguenti valori vengono utilizzati per discriminare quale
		 *	tipo di lista si vuole ottenere 
		 */
		public enum ListeSupportate { AUTISTI, DELEGATI };

		//	Classe che mi restituisce le stringe json desiderate
		ISorgenteDati sorgente = new SorgenteDati();

		//	Classe che aiuta a parsificare le stringhe json
		JsonParser helper = new JsonParser();

		//	Logger
		IControllerLog logger = ControllerLog.GetIstanza();

		private List<IUtente> ParsificaListaUtenti(ListeSupportate qualeLista)
		{
			string lista = null;

			switch (qualeLista)
			{
				case ListeSupportate.AUTISTI:
					lista = sorgente.ListaAutisti();
					break;

				case ListeSupportate.DELEGATI:
					lista = sorgente.ListaDelegati();
					break;

				default:
					return null;
			}

			if (lista == null)
				return null;

			return helper.ParsificaListaUtenti(lista);
		}

		public List<IAutista> ListaAutisti()
        {
			List<IUtente> utenti = ParsificaListaUtenti(ListeSupportate.AUTISTI);
			List<IAutista> result = new List<IAutista>();

			foreach (IUtente u in utenti)
				result.Add(u as IAutista);

			//	Log operazione
			logger.CreaLog(ControllerAutenticazione.GetIstanza().UtenteAutenticato.idAziendale + " ha richiesto la lista degli autisti");

			return result;
        }

        public List<IDelegato> ListaDelegati()
        {
			List<IUtente> utenti = ParsificaListaUtenti(ListeSupportate.DELEGATI);
			List<IDelegato> result = new List<IDelegato>();

			foreach (IUtente u in utenti)
				result.Add(u as IDelegato);

			//	Log operazione
			logger.CreaLog(ControllerAutenticazione.GetIstanza().UtenteAutenticato.idAziendale + " ha richiesto la lista dei delegati");

			return result;
		}

        /**
         *  Anche questo andava eliminato
         */
        public string RuoloUtente(IUtente utente)
        {
			throw new NotImplementedException();
        }

		public IUtente OttieniUtente(string idAziendale)
		{
			//	Ottenimento dei dati dal sistema esterno
			string datiUtente = sorgente.OttieniUtente(idAziendale);

			//	L'utente viene creato tramite il parsificatore
			IUtente utente = helper.ParsificaUtente(datiUtente);

			return utente;
		}

        public IUtente VerificaCredenziali(string username, string password)
        {

			//	Ottenimento dell'oggetto dei dati parsati
			string dati = sorgente.VerificaUtente(username, password);

			//	Se il campo dati è nullo, allora le credenziali non sono corrette
			if (dati == null)
				return null;

			return helper.ParsificaUtente(dati);
		}
        
    }

}
