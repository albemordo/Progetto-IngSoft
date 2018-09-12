using AutotrasportiFantini.modello.interfacce;
using Newtonsoft.Json;

namespace AutotrasportiFantini.modello
{
    class TipologiaMerce : ITipologiaMerce
    {
		public int id { get; set; }
        public string tipologia { get; set; }

		public override string ToString()
		{
			return tipologia;
		}
    }
}
