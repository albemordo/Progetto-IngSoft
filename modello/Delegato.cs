using AutotrasportiFantini.modello.interfacce;

namespace AutotrasportiFantini.modello
{
    class Delegato : IDelegato
    {

        public string idAziendale { get; set; }
        public string nome { get; set; }
        public string cognome { get; set; }

		public override string ToString()
		{
			return "[ID Aziendale: \"" + idAziendale + "\", Nome: \"" + nome + "\", Cognome: \"" + cognome + "\", Ruolo: \"" + this.GetType().Name + "\"]";
		}
	}
}
