using AutotrasportiFantini.modello.interfacce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotrasportiFantini.modello
{
	class FactoryAutisti : FactoryUtenti
	{
		public static IUtente GetAutista() => new Autista();
	}
}
