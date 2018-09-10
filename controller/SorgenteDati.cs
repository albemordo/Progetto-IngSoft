using AutotrasportiFantini.controller.interfacce;
using System;

namespace AutotrasportiFantini.controller
{
	class SorgenteDati : ISorgenteDati
	{
		public string ListaAutisti()
		{
			return @"[
				{
					'idAziendale' : 'AFX132',
					'nome' : 'Matteo',
					'cognome' : 'Bondini',
					'ruolo' : 'autista'
				},
				{
					'idAziendale' : 'ADX132',
					'nome' : 'Dario',
					'cognome' : 'Rondini',
					'ruolo' : 'autista'
				},
			]";
		}

		public string ListaDelegati()
		{
			return @"[
				{
					'idAziendale' : 'DAS544',
					'nome' : 'Luigi',
					'cognome' : 'Delnero',
					'ruolo' : 'delegato'
				},
				{
					'idAziendale' : 'AND103',
					'nome' : 'Pierluigi',
					'cognome' : 'Verona',
					'ruolo' : 'delegato'
				},
			]";
		}

		public string VerificaUtente(string username, string password)
		{
			string dati = null;

			//	Password codificata in SHA equivalente a "password"
			if (username.ToUpper().Equals("DAS544") && password.Equals("-231203086"))
				dati = @"
				{
					'idAziendale' : 'DAS544',
					'nome' : 'Luigi',
					'cognome' : 'Delnero',
					'ruolo' : 'delegato'
				}";
			else if (username.ToUpper().Equals("ADX132") && password.Equals("-231203086"))
				dati = @"
				{
					'idAziendale' : 'ADX132',
					'nome' : 'Dario',
					'cognome' : 'Rondini',
					'ruolo' : 'autista'
				}";

			return dati;
		}
	}
}
