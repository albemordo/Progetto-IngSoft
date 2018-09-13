using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutotrasportiFantini.controller.interfacce;

namespace AutotrasportiFantini.controller.factory
{
	abstract class SorgenteDatiFactory 
	{
		public enum SistemiSupportati { TESTING, SISTEMAESTERNO};

		public static ISorgenteDati GetSorgenteDati(SistemiSupportati sistema)
		{
			ISorgenteDati sorgente = null;

			if (sistema.Equals(SistemiSupportati.TESTING))
				sorgente = SorgenteTestingFactory.GetSorgenteDati();

			else if (sistema.Equals(SistemiSupportati.SISTEMAESTERNO))
				sorgente = SorgenteEsternaFactory.GetSorgenteDati();

			return sorgente;
		}
	}
}
