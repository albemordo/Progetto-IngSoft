using AutotrasportiFantini.modello.interfacce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotrasportiFantini.modello.factory
{
	interface IFactoryRisorse
	{
		ISpedizione GetSpedizione();

		IIndirizzo GetIndirizzo();

		IPuntoSpedizione GetPuntoSpedizione();

		IAutomezzo GetAutomezzo();

		ITipologiaMerce GetTipologiaMerce();

	}
}
