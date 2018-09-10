using AutotrasportiFantini.modello.interfacce;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AutotrasportiFantini.modello
{
    class Spedizione : ISpedizione
    {
		public int id { get; set; }
        public float distanzaStimata { get; set; }
        public float distanzaEffettiva { get; set; }
        public ITipologiaMerce tipologiaMerce { get; set; }
        public float quantitaMerce { get; set; }
        public int tempoPercorrenza { get; set; }
        public IAutomezzo automezzo { get; set; }
        public IDelegato delegato { get; set; }
        public IAutista autista { get; set; }
        public IIndirizzo partenza { get; set; }
        public IIndirizzo destinazione { get; set; }
        public List<IPuntoSpedizione> puntiSpedizione { get; set; }
        public DateTime orarioPrevistoPartenza { get; set; }
        public DateTime orarioPrevistoArrivo { get; set; }
        public DateTime orarioEffettivoPartenza { get; set; }
        public DateTime orarioEffettivoArrivo { get; set; }

		public override string ToString()
		{
			return JsonConvert.SerializeObject(this);
		}
	}


}
