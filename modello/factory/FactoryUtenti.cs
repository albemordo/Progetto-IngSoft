using AutotrasportiFantini.modello.interfacce;
using System;

namespace AutotrasportiFantini.modello
{
	abstract class FactoryUtenti
	{

		public static readonly string DELEGATO = "delegato";

		public static readonly string RESPONSABILE = "responsabile";

		public static readonly string AUTISTA = "autista";

		public static IUtente GetUtente(string ruolo)
		{
			IUtente utente = null;
			if (ruolo.ToLower().Equals(RESPONSABILE))
				utente = FactoryResponsabili.GetResponsabile();
			else if (ruolo.ToLower().Equals(AUTISTA))
				utente = FactoryAutisti.GetAutista();
			else if (ruolo.ToLower().Equals(DELEGATO))
				utente = FactoryDelegati.GetDelegato();
			else
				throw new ArgumentException("Ruolo non definito");

			return utente;
		}
	}
}
