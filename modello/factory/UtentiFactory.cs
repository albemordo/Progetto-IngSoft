using AutotrasportiFantini.modello.interfacce;
using System;

namespace AutotrasportiFantini.modello
{
	abstract class FactoryUtenti
	{
		public enum Utenti { AUTISTA , DELEGATO, RESPONSABILE };


		public static IUtente GetUtente(Utenti ruolo)
		{
			IUtente utente = null;

			if (ruolo.Equals(Utenti.RESPONSABILE))
				utente = FactoryResponsabili.GetResponsabile();

			else if (ruolo.Equals(Utenti.AUTISTA))
				utente = FactoryAutisti.GetAutista();

			else if (ruolo.Equals(Utenti.DELEGATO))
				utente = FactoryDelegati.GetDelegato();

			else
				throw new ArgumentException("Ruolo non definito", "ruolo");

			return utente;
		}
	}
}
