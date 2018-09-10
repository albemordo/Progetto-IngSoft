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
		 *	I seguenti valori vengono utilizzati per discriminare quale
		 *	tipo di lista si vuole ottenere 
		 */ 
		public enum ListeSupportate { AUTISTI, DELEGATI};

		//	Classe che mi restituisce le stringe json desiderate
		private ISorgenteDati sorgente = new SorgenteDati();

		//	Classe che aiuta a parsificare le stringhe json
		private JsonParser helper = new JsonParser();

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
				result.Add((IAutista)u);

			return result;
        }

        public List<IDelegato> ListaDelegati()
        {
			List<IUtente> utenti = ParsificaListaUtenti(ListeSupportate.DELEGATI);
			List<IDelegato> result = new List<IDelegato>();

			foreach (IUtente u in utenti)
				result.Add((IDelegato)u);

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

			//	Ottenimento dell'oggetto dei dati parsati
			string dati = sorgente.VerificaUtente(username, password);

			//	Se il campo dati è nullo, allora le credenziali non sono corrette
			if (dati == null)
				return null;

			return helper.ParsificaUtente(dati);
		}
        
    }

}
