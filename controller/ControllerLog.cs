using AutotrasportiFantini.controller.interfacce;
using System;

namespace AutotrasportiFantini.controller
{
    class ControllerLog : IControllerLog
    {

		private ISistemaLog SistemaLog = new SistemaLog();

        public void CreaLog(string messaggio)
        {
			//	Chiamata al sistema esterno
			SistemaLog.CreaLog(messaggio);
        }
    }
}
