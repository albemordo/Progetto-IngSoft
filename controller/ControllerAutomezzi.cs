using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello.factory;
using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.persistenza;
using AutotrasportiFantini.persistenza.factory;
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
			repository = new RepositoryAutomezzo(new SqlConnectionFactory().GetSqlConnection("dummy"));
		}

		private void AssegnaCampi(IAutomezzo automezzo, string targa, string produttore, string modello, string targaRimorchio, IDelegato delegato)
		{
			//	Popolamento campi
			automezzo.targa = targa;
			automezzo.prod = produttore;
			automezzo.modello = modello;
			automezzo.tr = targaRimorchio;
			automezzo.cod = delegato.idAziendale;
		}

		public IAutomezzo CreaAutomezzo(string targa, string produttore, string modello, string targaRimorchio, IDelegato delegato)
        {
			IAutomezzo automezzo = factoryRisorse.GetAutomezzo();
			AssegnaCampi(automezzo, targa, produttore, modello, targaRimorchio, delegato);

			//	L'automezzo viene reso persistente
			automezzo.id = repository.crea(automezzo);

			if (automezzo.id < 0)
				return null;

			return automezzo;
        }

        public void EliminaAutomezzo(IAutomezzo automezzo)
        {
			repository.elimina(automezzo.id);
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
