using AutotrasportiFantini.modello.interfacce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotrasportiFantini.controller.utilita
{
	interface IParser
	{
		IUtente ParsificaUtente(string raw);

		List<IUtente> ParsificaListaUtenti(string raw);
	}
}
