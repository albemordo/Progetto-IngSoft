using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello.factory;
using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.persistenza;
using System;
using System.Collections.Generic;

namespace AutotrasportiFantini.controller
{
    class ControllerGestioneSpedizione : IControllerGestioneSpedizione
    {
		IRisorseFactory factory = new RisorseFactory();
		RepositorySpedizione repository;

		public void AssegnaDelegato(ISpedizione spedizione, IDelegato delegato)
        {
			if (delegato != null)
			{
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

			if (distanzaStimata > 0 && distanzaStimata != null)
				spedizione.distanzaStimata = distanzaStimata;

			if (quantitaMerce >= 0 && quantitaMerce != null)
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
        }

        public ISpedizione ModificaDati(ISpedizione spedizione, IIndirizzo partenza, IIndirizzo arrivo, List<IPuntoSpedizione> puntiSpedizione, float distanzaStimata, ITipologiaMerce tipologiaMerce, float quantitaMerce, IAutista autista, IAutomezzo automezzo, IDelegato delegato, DateTime partenzaPrevista, DateTime arrivoPrevisto, DateTime partenzaEffettiva, DateTime arrivoEffettivo)
        {
			//	Popolamento dei campi
			if (partenza != null)
				spedizione.partenza = partenza;

			if (arrivo != null)
				spedizione.destinazione = arrivo;

			if (puntiSpedizione != null)
				spedizione.puntiSpedizione = puntiSpedizione;

			if (distanzaStimata > 0 && distanzaStimata != null)
				spedizione.distanzaStimata = distanzaStimata;

			if (distanzaStimata >= 0 && quantitaMerce != null)
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

			return spedizione;
        }
    }
}
