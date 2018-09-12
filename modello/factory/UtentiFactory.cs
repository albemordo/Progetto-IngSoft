using AutotrasportiFantini.modello.interfacce;
using System;

namespace AutotrasportiFantini.modello
{
	abstract class FactoryUtenti
	{
		//	Possibili tipi di utente
		public enum Utenti { AUTISTA , DELEGATO, RESPONSABILE };

		public static IUtente GetUtente(Utenti ruolo)
		{
			IUtente utente = null;

			if (ruolo.Equals(Utenti.RESPONSABILE))
				utente = FactoryResponsabili.GetUtente();

			else if (ruolo.Equals(Utenti.AUTISTA))
				utente = FactoryAutisti.GetUtente();

			else if (ruolo.Equals(Utenti.DELEGATO))
				utente = FactoryDelegati.GetUtente();

			else
				throw new ArgumentException("Ruolo non definito", "ruolo");

			return utente;
		}
	}
}
