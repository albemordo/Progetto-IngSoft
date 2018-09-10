using AutotrasportiFantini.modello.interfacce;
using System;

namespace AutotrasportiFantini.modello
{
	abstract class FactoryUtenti
	{
		public enum UTENTI { AUTISTA , DELEGATO, RESPONSABILE }

		public static IUtente GetUtente(int ruolo)
		{
			IUtente utente = null;
			if (ruolo.Equals((int)UTENTI.RESPONSABILE))
				utente = FactoryResponsabili.GetResponsabile();
			else if (ruolo.Equals((int)UTENTI.AUTISTA))
				utente = FactoryAutisti.GetAutista();
			else if (ruolo.Equals((int)UTENTI.DELEGATO))
				utente = FactoryDelegati.GetDelegato();
			else
				throw new ArgumentException("Ruolo non definito", "ruolo");

			return utente;
		}
	}
}
