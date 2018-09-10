using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.persistenza;
using System;

namespace AutotrasportiFantini.controller
{
    class ControllerAssegnazioneSpedizione : IControllerAssegnazioneSpedizione
    {
		RepositorySpedizione repository;

        public void AssegnaAutista(ISpedizione spedizione, IAutista autista)
        {
			spedizione.autista = autista;

			//	L'assegnazione dell'autista viene resa persistente
			repository.aggiorna(spedizione);
        }

        public void AssegnaAutomezzo(ISpedizione spedizione, IAutomezzo automezzo)
        {

			spedizione.automezzo = automezzo;

			//	L'assegnazione dell'automezzo viene reso persistente
			repository.aggiorna(spedizione);
        }

        public void AssegnaOrari(ISpedizione spedizione, DateTime partenzaPrevista, DateTime arrivoPrevisto)
        {
			spedizione.orarioPrevistoPartenza = partenzaPrevista;
			spedizione.orarioPrevistoArrivo = arrivoPrevisto;

			//	L'assegnazione degli orari viene resa persistente
			repository.aggiorna(spedizione);
        }
    }
}
