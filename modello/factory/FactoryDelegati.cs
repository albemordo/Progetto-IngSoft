using AutotrasportiFantini.modello.interfacce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotrasportiFantini.modello
{
	class DelegatoFactory : FactoryUtenti
	{
		public static IUtente GetDelegato() => new Delegato();
	}
}
