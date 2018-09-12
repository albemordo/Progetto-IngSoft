using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.controller.log;
using AutotrasportiFantini.controller.log.interfacce;
using AutotrasportiFantini.modello.factory;
using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.persistenza;
using AutotrasportiFantini.persistenza.repository.factory;
using Newtonsoft.Json;
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
			if (!delegato.idAziendale.Equals(spedizione.delegato.idAziendale))
			{
				//	Log operazione
				logger.CreaLog(ControllerAutenticazione.GetIstanza().UtenteAutenticato.idAziendale + " ha assegnato alla spedizione " + spedizione.id + " il delegato " + delegato.idAziendale + ", sostituendo " + spedizione.delegato.idAziendale);

				spedizione.delegato = delegato;

				//	L'assegnazione del delegato viene resa persistente
				repository.aggiorna(spedizione);
			}
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
			spedizione = repository.crea(spedizione);

			return spedizione;
        }

        public void EliminaSpedizione(ISpedizione spedizione)
        {
			if(spedizione != null)
				repository.elimina(spedizione.id);

			//	Log operazione
			logger.CreaLog(ControllerAutenticazione.GetIstanza().UtenteAutenticato.idAziendale + " ha eliminato la spedizione "+spedizione.id);
		}

		public ISpedizione ModificaDati(ISpedizione spedizione, IIndirizzo partenza, IIndirizzo arrivo, List<IPuntoSpedizione> puntiSpedizione, float distanzaStimata, float distanzaEffettiva, int tempoPercorrenza, ITipologiaMerce tipologiaMerce, float quantitaMerce, IAutista autista, IAutomezzo automezzo, IDelegato delegato, DateTime partenzaPrevista, DateTime arrivoPrevisto, DateTime partenzaEffettiva, DateTime arrivoEffettivo)
		{
			string cambiamenti = "{ ";

			//	Popolamento dei campi

			//	Per ogni modifica, ne viene loggato il valore
			if (partenza != null && !spedizione.partenza.Equals(partenza))
			{
				cambiamenti += "[partenza: da " + spedizione.partenza + " a " + partenza + "] ";
				spedizione.partenza = partenza;
			}

			if (arrivo != null && !spedizione.destinazione.Equals(arrivo))
			{
				cambiamenti += "[destinazione: da " + spedizione.destinazione + " a " + arrivo + "] ";
				spedizione.destinazione = arrivo;
			}

			if (puntiSpedizione != null)
				spedizione.puntiSpedizione = puntiSpedizione;

			if (distanzaStimata > 0 && !distanzaStimata.Equals(spedizione.distanzaStimata))
			{
				cambiamenti += "[distanza stimata: da " + spedizione.distanzaStimata + " a " + distanzaStimata + "] ";
				spedizione.distanzaStimata = distanzaStimata;
			}

			if (distanzaEffettiva > 0 && !spedizione.distanzaEffettiva.Equals(distanzaEffettiva))
			{
				cambiamenti += "[distanza effettiva: da " + spedizione.distanzaEffettiva + " a " + distanzaEffettiva + "] ";
				spedizione.distanzaEffettiva = distanzaEffettiva;
			}

			if (tempoPercorrenza > 0 && !spedizione.tempoPercorrenza.Equals(tempoPercorrenza))
			{
				cambiamenti += "[tempo percorrenza: da " + spedizione.tempoPercorrenza + " a " + tempoPercorrenza + "] ";
				spedizione.tempoPercorrenza = tempoPercorrenza;
			}

			if (quantitaMerce >= 0 && !spedizione.quantitaMerce.Equals(quantitaMerce))
			{
				cambiamenti += "[quantita merce: da " + spedizione.quantitaMerce + " a " + quantitaMerce + "] ";
				spedizione.quantitaMerce = quantitaMerce;
			}

			if (tipologiaMerce != null && !spedizione.tipologiaMerce.Equals(tipologiaMerce))
			{
				cambiamenti += "[tipologia merce: da " + spedizione.tipologiaMerce.tipologia + " a " + tipologiaMerce.tipologia + "] ";
				spedizione.tipologiaMerce = tipologiaMerce;
			}

			if (autista != null && (spedizione.autista == null || !spedizione.autista.Equals(autista)))
			{
				cambiamenti += "[autista: da " + (spedizione.autista != null ? spedizione.autista.idAziendale : "vuoto" ) + " a " + autista.idAziendale + "] ";
				spedizione.autista = autista;
			}

			if (automezzo != null && (spedizione.automezzo == null ||  !spedizione.automezzo.Equals(automezzo)))
			{
				cambiamenti += "[automezzo: da " + (spedizione.automezzo != null ? spedizione.automezzo.id.ToString() : "vuoto" ) + " a " + automezzo.id + "] ";
				spedizione.automezzo = automezzo;
			}

			if (delegato != null && (spedizione.delegato == null ||  !spedizione.delegato.Equals(delegato)))
			{
				cambiamenti += "[delegato: da " + (spedizione.automezzo != null ?  spedizione.autista.idAziendale : "vuoto")  + " a " + autista.idAziendale + "] ";
				spedizione.delegato = delegato;
			}

			if (partenzaPrevista != null && !spedizione.orarioPrevistoPartenza.Equals(partenzaPrevista))
			{
				cambiamenti += "[partenza prevista: da " + spedizione.orarioPrevistoPartenza + " a " + partenzaPrevista + "] ";
				spedizione.orarioPrevistoPartenza = partenzaPrevista;
			}

			if (partenzaEffettiva != null && !spedizione.orarioEffettivoPartenza.Equals(partenzaEffettiva))
			{
				cambiamenti += "[partenza effettiva: da " + spedizione.orarioEffettivoPartenza + " a " + partenzaEffettiva + "] ";
				spedizione.orarioEffettivoPartenza = partenzaEffettiva;
			}

			if (arrivoPrevisto != null && !spedizione.orarioPrevistoArrivo.Equals(arrivoPrevisto))
			{
				cambiamenti += "[arrivo previsto: da " + spedizione.orarioPrevistoArrivo + " a " + arrivoPrevisto + "] ";
				spedizione.orarioPrevistoArrivo = arrivoPrevisto;
			}

			if (arrivoEffettivo != null && !spedizione.orarioEffettivoArrivo.Equals(arrivoEffettivo))
			{
				cambiamenti += "[arrivo effettivo: da " + spedizione.orarioEffettivoArrivo + " a " + arrivoEffettivo + "] ";
				spedizione.orarioEffettivoArrivo = arrivoEffettivo;
			}

			cambiamenti += "}";

			//	Log operazione
			logger.CreaLog(ControllerAutenticazione.GetIstanza().UtenteAutenticato.idAziendale + " ha modificato "+cambiamenti+" della spedizione "+spedizione.id);

            repository.aggiorna(spedizione);

			return spedizione;
        }
    }
}
