using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.controller.log;
using AutotrasportiFantini.controller.log.interfacce;
using AutotrasportiFantini.modello.interfacce;
using System;

namespace AutotrasportiFantini.controller
{
    class ControllerAutenticazione : IControllerAutenticazione
    {
		//	Logger
		IControllerLog logger = ControllerLog.GetIstanza();

		//	Istanza del controller 
		IControllerGestioneDipendenti autenticazione = new ControllerGestioneDipendenti();

		//	Viene salvata l'istanza dell'utente che si è autenticato
		public IUtente UtenteAutenticato { get; private set; }

        private ControllerAutenticazione() { }

		//	Istanza della classe
		protected static IControllerAutenticazione istanza;

		//	Singleton
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
			logger.CreaLog(UtenteAutenticato.idAziendale+" ha terminato la sessione");

			UtenteAutenticato = null;
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
