using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.controller.log;
using AutotrasportiFantini.controller.log.interfacce;
using AutotrasportiFantini.modello.factory;
using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.persistenza;
using AutotrasportiFantini.persistenza.repository.factory;
using System;
using System.Collections.Generic;

namespace AutotrasportiFantini.controller
{
    class ControllerGestioneSpedizione : IControllerGestioneSpedizione
    {
		IPersistenzaSpedizione repository;
		IRisorseFactory factory = new RisorseFactory();
		IControllerLog logger = ControllerLog.GetIstanza();

		public ControllerGestioneSpedizione()
		{
			//	Init repository
			repository = new RepositoryFactory(DbConnectionFactory.SupportedDBMS.postgresql, "TestDb").GetPersistenzaSpedizione();
		}

		public void AssegnaDelegato(ISpedizione spedizione, IDelegato delegato)
        {
			
			spedizione.delegato = delegato;

			//	L'assegnazione del delegato viene resa persistente
			repository.aggiorna(spedizione);

			//	Log operazione
			logger.CreaLog(ControllerAutenticazione.GetIstanza().GetUtenteAutenticato().idAziendale + " ha assegnato alla spedizione "+spedizione.id+" il delegato "+delegato.idAziendale);
		}

        public ISpedizione CreaSpedizione(IIndirizzo partenza, IIndirizzo arrivo, List<IPuntoSpedizione> puntiSpedizione, float distanzaStimata, ITipologiaMerce tipologiaMerce, float quantitaMerce)
        {
			ISpedizione spedizione = factory.GetSpedizione();

			//	Popolamento dei campi
			if (partenza != null)
				spedizione.partenza = partenza;

			if (arrivo != null)
				spedizione.destinazione = arrivo;

			if (puntiSpedizione != null)
				spedizione.puntiSpedizione = puntiSpedizione;

			if (distanzaStimata > 0)
				spedizione.distanzaStimata = distanzaStimata;

			if (quantitaMerce >= 0)
				spedizione.quantitaMerce = quantitaMerce;

			if (tipologiaMerce != null)
				spedizione.tipologiaMerce = tipologiaMerce;

			//	La spedizione viene creata e resa persistente
			repository.crea(spedizione);

			return spedizione;
        }

        public void EliminaSpedizione(ISpedizione spedizione)
        {
			if(spedizione != null)
				repository.elimina(spedizione.id);

			//	Log operazione
			logger.CreaLog(ControllerAutenticazione.GetIstanza().GetUtenteAutenticato().idAziendale + " ha eliminato la spedizione "+spedizione.id);
		}

        public ISpedizione ModificaDati(ISpedizione spedizione, IIndirizzo partenza, IIndirizzo arrivo, List<IPuntoSpedizione> puntiSpedizione, float distanzaStimata, float distanzaEffettiva, int tempoPercorrenza, ITipologiaMerce tipologiaMerce, float quantitaMerce, IAutista autista, IAutomezzo automezzo, IDelegato delegato, DateTime partenzaPrevista, DateTime arrivoPrevisto, DateTime partenzaEffettiva, DateTime arrivoEffettivo)
        {
			//	Popolamento dei campi
			if (partenza != null)
				spedizione.partenza = partenza;

			if (arrivo != null)
				spedizione.destinazione = arrivo;

			if (puntiSpedizione != null)
				spedizione.puntiSpedizione = puntiSpedizione;

			if (distanzaStimata > 0)
				spedizione.distanzaStimata = distanzaStimata;

			if (distanzaEffettiva > 0)
				spedizione.distanzaEffettiva = distanzaEffettiva;

			if (tempoPercorrenza > 0)
				spedizione.tempoPercorrenza = tempoPercorrenza;

			if (quantitaMerce >= 0)
				spedizione.quantitaMerce = quantitaMerce;

			if (tipologiaMerce != null)
				spedizione.tipologiaMerce = tipologiaMerce;

			if (autista != null)
				spedizione.autista = autista;

			if (automezzo != null)
				spedizione.automezzo = automezzo;

			if (delegato != null)
				spedizione.delegato = delegato;

			if (partenzaPrevista != null)
				spedizione.orarioPrevistoPartenza = partenzaPrevista;

			if (partenzaEffettiva != null)
				spedizione.orarioEffettivoPartenza = partenzaEffettiva;

			if (arrivoPrevisto != null)
				spedizione.orarioPrevistoArrivo = arrivoPrevisto;

			if (arrivoEffettivo != null)
				spedizione.orarioEffettivoArrivo = arrivoEffettivo;

			//	Log operazione
			logger.CreaLog(ControllerAutenticazione.GetIstanza().GetUtenteAutenticato().idAziendale + " ha modificato la spedizione "+spedizione.id);

			return spedizione;
        }
    }
}
