using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello.interfacce;
using System;

namespace AutotrasportiFantini.controller
{
    class ControllerLog : IControllerLog
    {

		ISistemaLog SistemaLog = new SistemaLog();
		IUtente UtenteAutenticato = ControllerAutenticazione.GetIstanza().GetUtenteAutenticato();
		protected static ControllerLog istanza;

		/**
		 *	Singleton
		 */
		public static ControllerLog GetIstanza()
		{
			if (istanza is null)
				istanza = new ControllerLog();
			
			return istanza;
		}

		private ControllerLog() { }

        public void CreaLog(string messaggio)
        {
			string Preambolo = (UtenteAutenticato != null) ? UtenteAutenticato.ToString() : "Utente non autenticato";

			//	Chiamata al sistema esterno
			SistemaLog.CreaLog(Preambolo+": "+messaggio);
        }
    }
}
