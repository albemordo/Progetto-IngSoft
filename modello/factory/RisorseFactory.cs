using AutotrasportiFantini.modello.interfacce;
using System;
using System.Collections.Generic;

namespace AutotrasportiFantini.modello.factory
{
	class RisorseFactory : IRisorseFactory
	{
		public IAutomezzo GetAutomezzo() => new Automezzo();

		public IIndirizzo GetIndirizzo() => new Indirizzo();

		public IPuntoSpedizione GetPuntoSpedizione() => new PuntoSpedizione();

		public ISpedizione GetSpedizione() => new Spedizione();

		public ITipologiaMerce GetTipologiaMerce() => new TipologiaMerce();
	}
}
