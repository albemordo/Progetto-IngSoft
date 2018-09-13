using AutotrasportiFantini.controller.utilita;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotrasportiFantini.controller.factory
{
	class JsonParserFactory : ParserFactory
	{
		public static IParser GetParser() => new JsonParser();
	}
}
