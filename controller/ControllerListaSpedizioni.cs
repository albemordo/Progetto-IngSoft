using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.persistenza;
using System;
using System.Collections.Generic;
using System.Data;

namespace AutotrasportiFantini.controller
{
    class ControllerListaSpedizioni : IControllerListaSpedizioni
    {
		private RepositorySpedizione repository;

		public ControllerListaSpedizioni()
		{
			//	Init Repository

		}

        public List<ISpedizione> ListaSpedizioni(IUtente utente)
        {
			List<ISpedizione> listaSpedizioni = null;
			//	Aspetta implementazione
			if (utente is IResponsabile)
				;

			else if (utente is IDelegato)
				;

			return listaSpedizioni;
        }
    }
}
