using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.controller.log.interfacce;
using System;

namespace AutotrasportiFantini.controller.log
{
	class SistemaLog : ISistemaLog
	{
		public void CreaLog(string messaggio)
		{
			//	Creazione dei log

			//	Debug
			Console.WriteLine(messaggio);
		}
	}
}
