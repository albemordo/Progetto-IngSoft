using AutotrasportiFantini.controller.log.interfacce;
using AutotrasportiFantini.modello.interfacce;
using System;

namespace AutotrasportiFantini.controller.log
{
    class ControllerLog : IControllerLog
    {
		IUtente utente;
		ISistemaLog SistemaLog;
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

		protected ControllerLog()
		{
			utente = ControllerAutenticazione.GetIstanza().GetUtenteAutenticato();
			SistemaLog = new SistemaLog();
		}

        public void CreaLog(string messaggio)
        {
			//	Chiamata al sistema esterno
			SistemaLog.CreaLog(DateTime.Now+": "+messaggio);
        }
    }
}
