using AutotrasportiFantini.controller.interfacce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotrasportiFantini.controller
{
	class SistemaLog : ISistemaLog
	{
		public void CreaLog(string messaggio)
		{
			//	Creazione dei log

			//	Debug
			Console.WriteLine("Log : " + messaggio);
		}
	}
}
