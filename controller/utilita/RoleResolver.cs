using AutotrasportiFantini.modello;
using System;
using static AutotrasportiFantini.modello.FactoryUtenti;

namespace AutotrasportiFantini.controller
{
	class RoleResolver
	{
		public static Utenti GetRuolo(string ruolo)
		{
			Utenti ruoloId = 0;

			if (ruolo.ToLower().Equals("delegato"))
				ruoloId = FactoryUtenti.Utenti.DELEGATO;
			else if (ruolo.ToLower().Equals("responsabile"))
				ruoloId = FactoryUtenti.Utenti.RESPONSABILE;
			else if (ruolo.ToLower().Equals("autista"))
				ruoloId = FactoryUtenti.Utenti.AUTISTA;
			
			return ruoloId;
		}

	}
}
