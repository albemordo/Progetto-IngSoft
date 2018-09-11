using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.controller.log;
using AutotrasportiFantini.controller.log.interfacce;
using AutotrasportiFantini.modello.interfacce;
using System;

namespace AutotrasportiFantini.controller
{
    class ControllerAutenticazione : IControllerAutenticazione
    {
        protected static IControllerAutenticazione istanza;

		//	Logger
		IControllerLog logger = ControllerLog.GetIstanza();

		IControllerGestioneDipendenti autenticazione = new ControllerGestioneDipendenti();

		//	Viene salvata l'istanza dell'utente che si è autenticato, per tutta la durata della sessione
		IUtente UtenteAutenticato;

        private ControllerAutenticazione() { }

		/**
         *  Singleton
         */
		public static IControllerAutenticazione GetIstanza()
		{
			if (istanza is null)
				istanza = new ControllerAutenticazione();

			return istanza;
		}

        public bool Autentica(string username, string password)
        {
			bool esito = false;
			IUtente utente;

			//	Controlla che i dati siano corretti
			if ((utente = autenticazione.VerificaCredenziali(username, password)) != null)
			{
				//	Dati Corretti

				UtenteAutenticato = utente;
				esito = true;
			}
			else
			{
				//	Dati non corretti
			}

			//	Viene creato il log del tentativo di login
			logger.CreaLog(" tentativo di login per lo username "+username+". Esito: "+(esito ? "successo" : "fallimento"));

			return esito;
        }

        public void ChiudiSessione()
		{
			//	Viene creato il log per la fine della sessione di login
			logger.CreaLog(" tentativo di login per lo username " + UtenteAutenticato.idAziendale);

			UtenteAutenticato = null;
		}

        public IUtente GetUtenteAutenticato()
        {
			return UtenteAutenticato;
        }

        /**
         *  Non era da eliminare??
         */
        public bool IsAutenticato()
        {
            throw new NotImplementedException();
        }

    }
}
