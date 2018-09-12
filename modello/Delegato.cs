using AutotrasportiFantini.modello.interfacce;
using Newtonsoft.Json;

namespace AutotrasportiFantini.modello
{
    class Delegato : IDelegato
    {

        public string idAziendale { get; set; }
        public string nome { get; set; }
        public string cognome { get; set; }

		public override string ToString()
		{
			return idAziendale + ": " + nome + " " + cognome;
		}
	}
}
