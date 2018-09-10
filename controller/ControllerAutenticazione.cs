using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello.interfacce;
using System;

namespace AutotrasportiFantini.controller
{
    class ControllerAutenticazione : IControllerAutenticazione
    {
        protected static IControllerAutenticazione istanza;
		private IUtente UtenteAutenticato { get; set; }

        private ControllerAutenticazione() { }

		private IControllerGestioneDipendenti autenticazione = new ControllerGestioneDipendenti();

		/**
         *  Singleton
         */
		public static IControllerAutenticazione GetIstanza() => istanza ?? new ControllerAutenticazione();

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

			return esito;
        }

        public void ChiudiSessione()
        {
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
