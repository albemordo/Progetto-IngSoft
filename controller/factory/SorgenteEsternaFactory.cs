﻿using AutotrasportiFantini.controller.interfacce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotrasportiFantini.controller.factory
{
	class SorgenteEsternaFactory : SorgenteDatiFactory
	{
		public static ISorgenteDati GetSorgenteDati() => throw new NotImplementedException();
	}
}
