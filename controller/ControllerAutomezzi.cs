﻿using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.controller.log;
using AutotrasportiFantini.controller.log.interfacce;
using AutotrasportiFantini.modello.factory;
using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.persistenza;
using AutotrasportiFantini.persistenza.repository.factory;
using System.Collections.Generic;

namespace AutotrasportiFantini.controller
{
    class ControllerAutomezzi : IControllerAutomezzi
    {
		IPersistenzaAutomezzo repository;
		IRisorseFactory factory = new RisorseFactory();
		IControllerLog logger = ControllerLog.GetIstanza();

		public ControllerAutomezzi()
		{
			//	Init Repository
			repository = new RepositoryFactory(DbConnectionFactory.SupportedDBMS.postgresql, "TestDb").GetPersistenzaAutomezzo();
		}

		private void AssegnaCampi(IAutomezzo automezzo, string targa, string produttore, string modello, string targaRimorchio, IDelegato delegato)
		{
			//	Popolamento campi
			
			if(targa != null && targa.Length == 7)	automezzo.targa = targa;
			if(produttore != null && produttore.Length > 0)	automezzo.produttore = produttore;
			if(modello != null && modello.Length > 0)	automezzo.modello = modello;
			if(targaRimorchio != null && targaRimorchio.Length > 0) automezzo.targaRimorchio = targaRimorchio;
			if(delegato != null && delegato.idAziendale.Length > 0)	automezzo.codiceDelegato = delegato.idAziendale;
		}

		public IAutomezzo CreaAutomezzo(string targa, string produttore, string modello, string targaRimorchio, IDelegato delegato)
        {
			IAutomezzo automezzo = factory.GetAutomezzo();
			AssegnaCampi(automezzo, targa, produttore, modello, targaRimorchio, delegato);

			//	L'automezzo viene reso persistente
			automezzo = repository.crea(automezzo);
			if(automezzo == null)
				return null;

			logger.CreaLog(ControllerAutenticazione.GetIstanza().GetUtenteAutenticato().idAziendale + " ha aggiunto l'automezzo "+automezzo.targa);

			return automezzo;
        }

        public void EliminaAutomezzo(IAutomezzo automezzo)
        {
			repository.elimina(automezzo.targa);

			logger.CreaLog(ControllerAutenticazione.GetIstanza().GetUtenteAutenticato().idAziendale + " ha eliminato l'automezzo " + automezzo.targa);
		}

		public List<IAutomezzo> ListaAutomezzi(IDelegato delegato)
        {
			//	Manca il delegato
			return repository.elencaPerDelegato(delegato.idAziendale);
        }

        public IAutomezzo ModificaAutomezzo(IAutomezzo automezzo, string targa, string produttore, string modello, string targaRimorchio, IDelegato delegato)
		{
			logger.CreaLog(ControllerAutenticazione.GetIstanza().GetUtenteAutenticato().idAziendale + " ha aggiunto l'automezzo " + automezzo.targa);

			AssegnaCampi(automezzo, targa, produttore, modello, targaRimorchio, delegato);

			//	Le modifiche vengono rese persistenti
			repository.aggiorna(automezzo);

			return automezzo;
        }

    }
}
