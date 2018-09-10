using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.persistenza.repository;
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
            throw new NotImplementedException();
        }
    }
}
