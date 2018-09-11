using AutotrasportiFantini.modello.interfacce;
using System;

namespace AutotrasportiFantini.modello
{
    class PuntoSpedizione : IPuntoSpedizione
    {
		public int id { get; set; }
        public IIndirizzo indirizzo { get; set; }
        public int spedizione { get; set; }
        public DateTime orarioArrivo { get; set; }
    }
}
