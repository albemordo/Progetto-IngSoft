using AutotrasportiFantini.modello.interfacce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotrasportiFantini.controller.interfacce
{
	interface ISorgenteDati
	{
		string ListaDelegati();

		List<IAutista> ListaAutisti();

		
	}
}
