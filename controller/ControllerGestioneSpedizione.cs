using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.persistenza;
using System;
using System.Collections.Generic;

namespace AutotrasportiFantini.controller
{
    class ControllerGestioneSpedizione : IControllerGestioneSpedizione
    {
		RepositorySpedizione repository;

		public void AssegnaDelegato(ISpedizione spedizione, IDelegato delegato)
        {
			spedizione.delegato = delegato;

			//	L'assegnazione del delegato viene resa persistente
			repository.aggiorna(spedizione);
        }

        public ISpedizione CreaSpedizione(IIndirizzo partenza, IIndirizzo arrivo, List<IPuntoSpedizione> puntiSpedizione, float distanzaStimata, ITipologiaMerce tipologiaMerce, float quantitaMerce)
        {
            throw new NotImplementedException();
        }

        public void EliminaSpedizione(ISpedizione spedizione)
        {
			repository.elimina(spedizione.id);
        }

        public ISpedizione ModificaDati(ISpedizione spedizione, IIndirizzo partenza, IIndirizzo arrivo, List<IPuntoSpedizione> puntiSpedizione, float distanzaStimata, ITipologiaMerce tipologiaMerce, float quantitaMerce, IAutista autista, IAutomezzo automezzo, IDelegato delegato, DateTime partenzaPrevista, DateTime arrivoPrevisto, DateTime partenzaEffettiva, DateTime arrivoEffettivo)
        {
			spedizione.partenza = partenza;

			return spedizione;
        }
    }
}
