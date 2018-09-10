using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutotrasportiFantini.modello.interfacce;

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
