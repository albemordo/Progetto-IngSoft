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
			if (username.ToUpper().Equals("2") && password.Equals("-842352754"))
				dati = @"
				{
					'idAziendale' : 'DAS544',
					'nome' : 'Luigi',
					'cognome' : 'Delnero',
					'ruolo' : 'delegato'
				}";

			else if (username.ToUpper().Equals("1") && password.Equals("-842352753"))
				dati = @"

				{
					'idAziendale' : 'ADX132',
					'nome' : 'Dario',
					'cognome' : 'Rondini',
					'ruolo' : 'autista'
				}
				
				";

			else if (username.ToUpper().Equals("3") && password.Equals("-842352755"))
				dati = @"
				{
					'idAziendale' : 'ACD132',
					'nome' : 'Abdul',
					'cognome' : 'Aziz',
					'ruolo' : 'responsabile'
				}";

			return dati;
		}

		public string OttieniUtente(string username)
		{
			string dati = null;

			if (username.ToUpper().Equals("ADX132"))
				dati = @"
				{
					'idAziendale' : 'ADX132',
					'nome' : 'Dario',
					'cognome' : 'Rondini',
					'ruolo' : 'autista'
				}";

			else if (username.ToUpper().Equals("ACD132"))
				dati = @"
				{
					'idAziendale' : 'ACD132',
					'nome' : 'Abdul',
					'cognome' : 'Aziz',
					'ruolo' : 'responsabile'
				}";

			else if (username.ToUpper().Equals("DAS544"))
				dati = @"
				{
					'idAziendale' : 'DAS544',
					'nome' : 'Luigi',
					'cognome' : 'Delnero',
					'ruolo' : 'delegato'
				}";

			else if (username.ToUpper().Equals("AND103"))
				dati = @"
				{
					'idAziendale' : 'AND103',
					'nome' : 'Pierluigi',
					'cognome' : 'Verona',
					'ruolo' : 'delegato'
				}";

			else if (username.ToUpper().Equals("AFX132"))
				dati = @"
				{
					'idAziendale' : 'AFX132',
					'nome' : 'Matteo',
					'cognome' : 'Bondini',
					'ruolo' : 'autista'
				}";

			return dati;
		}

	}

	
}
