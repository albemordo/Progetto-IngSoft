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

			//	Responsabile
			if (ruolo.Equals(Utenti.RESPONSABILE))
				utente = FactoryResponsabili.GetUtente();

			//	Autista
			else if (ruolo.Equals(Utenti.AUTISTA))
				utente = FactoryAutisti.GetUtente();

			//	Delegato
			else if (ruolo.Equals(Utenti.DELEGATO))
				utente = FactoryDelegati.GetUtente();

			return utente;
		}
	}
}
