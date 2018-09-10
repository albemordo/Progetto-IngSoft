using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello.factory;
using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.persistenza.repository;
using AutotrasportiFantini.persistenza.repository.factory;
using System;
using System.Collections.Generic;

namespace AutotrasportiFantini.controller
{
    class ControllerAutomezzi : IControllerAutomezzi
    {
		private IFactoryRisorse factoryRisorse = new FactoryRisorse();
		private RepositoryAutomezzo repository;

		public ControllerAutomezzi()
		{
			//	Init Repository


		}

		private void AssegnaCampi(IAutomezzo automezzo, string targa, string produttore, string modello, string targaRimorchio, IDelegato delegato)
		{
			//	Popolamento campi
			automezzo.targa = targa;
			automezzo.produttore = produttore;
			automezzo.modello = modello;
			automezzo.targaRimorchio = targaRimorchio;
			automezzo.codiceDelegato = delegato.idAziendale;
		}

		public IAutomezzo CreaAutomezzo(string targa, string produttore, string modello, string targaRimorchio, IDelegato delegato)
        {
			IAutomezzo automezzo = factoryRisorse.GetAutomezzo();
			AssegnaCampi(automezzo, targa, produttore, modello, targaRimorchio, delegato);

			//	L'automezzo viene reso persistente
			if(repository.crea(automezzo) == null)
				return null;

			return automezzo;
        }

        public void EliminaAutomezzo(IAutomezzo automezzo)
        {
			repository.elimina(automezzo.targa);
        }

        public List<IAutomezzo> ListaAutomezzi(IDelegato delegato)
        {
			//	Manca il delegato
			return repository.elencaTutti();
        }

        public IAutomezzo ModificaAutomezzo(IAutomezzo automezzo, string targa, string produttore, string modello, string targaRimorchio, IDelegato delegato)
        {
			AssegnaCampi(automezzo, targa, produttore, modello, targaRimorchio, delegato);

			//	Le modifiche vengono rese persistenti
			repository.aggiorna(automezzo);

			return automezzo;
        }
    }
}
