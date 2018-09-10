using AutotrasportiFantini.modello;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotrasportiFantini.controller
{
	class RoleResolver
	{
		public static int GetRuolo(string ruolo)
		{
			int ruoloId = -1;
			if (ruolo.ToLower().Equals("delegato"))
				ruoloId = (int)FactoryUtenti.UTENTI.DELEGATO;
			else if (ruolo.ToLower().Equals("responsabile"))
				ruoloId = (int)FactoryUtenti.UTENTI.RESPONSABILE;
			else if (ruolo.ToLower().Equals("autista"))
				ruoloId = (int)FactoryUtenti.UTENTI.AUTISTA;

			return ruoloId;
		}
	}
}
