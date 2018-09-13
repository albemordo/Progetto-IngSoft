using AutotrasportiFantini.controller.utilita;
using AutotrasportiFantini.modello.interfacce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotrasportiFantini.controller.factory
{
	abstract class ParserFactory
	{
		public enum Formati { JSON, XML }
		public static IParser GetParser(Formati formato)
		{
			IParser parser = null;

			if (formato.Equals(Formati.JSON))
				return JsonParserFactory.GetParser();

			return parser;
		}
	}
}
