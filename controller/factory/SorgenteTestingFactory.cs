using AutotrasportiFantini.controller.interfacce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotrasportiFantini.controller.factory
{
	class SorgenteTestingFactory : SorgenteDatiFactory
	{
		public static ISorgenteDati GetSorgenteDati() => new SorgenteTesting();
	}
}
