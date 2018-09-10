﻿using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.persistenza;
using AutotrasportiFantini.persistenza.repository.factory;
using System;

namespace AutotrasportiFantini.controller
{
    class ControllerSpedizioniAutista : IControllerSpedizioniAutista
    {
		IPersistenzaSpedizione repositorySpedizione;
		IPersistenzaPuntoSpedizione repositoryPuntoSpedizione;

		public ControllerSpedizioniAutista()
		{
			//	Init repository
			repositorySpedizione = new RepositoryFactory(DbConnectionFactory.SupportedDBMS.postgresql, "TestDb").GetPersistenzaSpedizione();
			repositoryPuntoSpedizione = new RepositoryFactory(DbConnectionFactory.SupportedDBMS.postgresql, "TestDb").GetPersistenzaPuntoSpedizione();
		}

		public void RegistraFineSpedizione(ISpedizione spedizione, DateTime arrivo, float distanzaEffettiva, int tempoEffettivo)
        {
			//	Vengono inseriti i dati di fine spedizione
			spedizione.orarioEffettivoArrivo = arrivo;
			spedizione.distanzaEffettiva = distanzaEffettiva;
			spedizione.tempoPercorrenza = tempoEffettivo;

			//	Le modifiche vengono rese persistenti
			repositorySpedizione.aggiorna(spedizione);
        }

        public void RegistraPartenza(ISpedizione spedizione, DateTime partenza)
        {
			//	Viene inserito l'orario effettivo di partenza
			spedizione.orarioEffettivoPartenza = partenza;

			//	La modifica viene resa persistente
			repositorySpedizione.aggiorna(spedizione);
        }

        public void RegistraPuntoSpedizione(ISpedizione spedizione, IPuntoSpedizione punto, DateTime orario)
        {
			/**
			 *	Soluzione 1: si aggiorna il punto di spedizione dentro la
			 *	spedizione stessa
			 */
			/*
			foreach(IPuntoSpedizione puntoS in spedizione.puntiSpedizione)
				if (puntoS.id.Equals(punto.id))
				{
					puntoS.orarioArrivo = orario;
					
					repository.aggiorna(spedizione);
				}
			*/

			/**
			 *	Soluzione 2: si aggiorna direttamente il punto di spedizione
			 */
			punto.orarioArrivo = orario;

			//	L'arrivo ad un punto di spedizione viene reso persistente
			repositoryPuntoSpedizione.aggiorna(punto);
        }
    }
}
