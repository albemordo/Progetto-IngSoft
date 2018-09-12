using AutotrasportiFantini.modello.interfacce;
using Newtonsoft.Json;
using System;

namespace AutotrasportiFantini.modello
{
    class Automezzo : IAutomezzo
    {
        public String targa { get; set; }
        public String produttore { get; set; }
        public String modello { get; set; }
        public String targaRimorchio { get; set; }
        public String codiceDelegato { get; set; }
		public int id { get; set; }

		public override String ToString()
		{
			return JsonConvert.SerializeObject(this);
		}
    }
}
