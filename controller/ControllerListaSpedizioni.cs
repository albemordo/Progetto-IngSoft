﻿using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.controller.log;
using AutotrasportiFantini.controller.log.interfacce;
using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.persistenza;
using AutotrasportiFantini.persistenza.repository.factory;
using System;
using System.Collections.Generic;

namespace AutotrasportiFantini.controller
{
    class ControllerListaSpedizioni : IControllerListaSpedizioni
    {
		IPersistenzaSpedizione repository;
		IControllerLog logger = ControllerLog.GetIstanza();

		public ControllerListaSpedizioni()
		{
			//	Init Repository
			repository = new RepositoryFactory(DbConnectionFactory.SupportedDBMS.postgresql, "TestDb").GetPersistenzaSpedizione();
		}

        public List<ISpedizione> ListaSpedizioni(IUtente utente)
        {
			List<ISpedizione> listaSpedizioni = null;

			//	In base a chi chiede la lista delle spedizione, si ottiene una lista diversa
			if (utente is IResponsabile)
				listaSpedizioni = repository.elencaTutti();
			
			else if (utente is IDelegato)
				listaSpedizioni = repository.cercaPerDelegato(utente.idAziendale);

			else if (utente is IAutista)
				listaSpedizioni = repository.cercaPerAutista(utente.idAziendale);

			//	Viene creato il log dell'operazione
			logger.CreaLog(ControllerAutenticazione.GetIstanza().UtenteAutenticato.idAziendale + " ha richiesto la lista delle spedizioni");

			return listaSpedizioni;
        }
    }
}
