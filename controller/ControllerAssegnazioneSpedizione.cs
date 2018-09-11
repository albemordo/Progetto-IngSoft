using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.persistenza;
using AutotrasportiFantini.persistenza.repository.factory;
using System;

namespace AutotrasportiFantini.controller
{
    class ControllerAssegnazioneSpedizione : IControllerAssegnazioneSpedizione
    {
		
		IPersistenzaSpedizione repository;
		IControllerLog logger = ControllerLog.GetIstanza();

		public ControllerAssegnazioneSpedizione()
		{
			//	Init repository
			repository = new RepositoryFactory(DbConnectionFactory.SupportedDBMS.postgresql, "TestDb").GetPersistenzaSpedizione();
		
		}

		public void AssegnaAutista(ISpedizione spedizione, IAutista autista)
		{
			spedizione.autista = autista;

			//	L'assegnazione dell'autista viene resa persistente
			repository.aggiorna(spedizione);

			//	Viene creato il log dell'operazione
			logger.CreaLog("assegnato alla spedizione N° " + spedizione.id + " l'autista " + autista.ToString());
		}

        public void AssegnaAutomezzo(ISpedizione spedizione, IAutomezzo automezzo)
        {

			spedizione.automezzo = automezzo;

			//	L'assegnazione dell'automezzo viene reso persistente
			repository.aggiorna(spedizione);

			//	Viene creato il log dell'operazione
			logger.CreaLog("assegnato alla spedizione N° " + spedizione.id + " l'automezzo " + automezzo.ToString());
		}

        public void AssegnaOrari(ISpedizione spedizione, DateTime partenzaPrevista, DateTime arrivoPrevisto)
        {
			spedizione.orarioPrevistoPartenza = partenzaPrevista;
			spedizione.orarioPrevistoArrivo = arrivoPrevisto;

			//	L'assegnazione degli orari viene resa persistente
			repository.aggiorna(spedizione);

			//	Viene creato il log dell'operazione
			logger.CreaLog("assegnato alla spedizione N° " + spedizione.id + " gli orari previsti(partenza, arrivo) (" + partenzaPrevista+","+arrivoPrevisto+")");
		}
    }
}
