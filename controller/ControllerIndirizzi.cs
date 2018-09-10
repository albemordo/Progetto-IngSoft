using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello;
using AutotrasportiFantini.modello.factory;
using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.persistenza.repository;
using AutotrasportiFantini.persistenza.repository.factory;
using System;

namespace AutotrasportiFantini.controller
{
    class ControllerIndirizzi : IControllerIndirizzi
    {
		private IFactoryRisorse factoryRisorse = new FactoryRisorse();
		private RepositoryIndirizzo repository;

		private void AssegnaCampi(IIndirizzo indirizzo, string qualificatore, string nome, string civico, string cap, string localita, string provincia)
		{
			//	Popolamento dei campi
			indirizzo.qualificatore = qualificatore;
			indirizzo.nome = nome;
			indirizzo.civico = civico;
			indirizzo.cap = cap;
			indirizzo.localita = localita;
			indirizzo.provincia = provincia;
			
		}
		
		public ControllerIndirizzi()
		{
			//	Init repository

		}

		public IIndirizzo CreaIndirizzo(string qualificatore, string nome, string civico, string cap, string localita, string provincia)
		{
			//	Prima di tutto l'indirizzo viene cercato
			IIndirizzo indirizzo = repository.cercaIndirizzo(qualificatore, nome, civico, cap, localita, provincia);

			//	Se è già presente, viene restituito
			indirizzo = repository.cercaIndirizzo(qualificatore, nome, civico, cap, localita, provincia);
			if (indirizzo != null)
				return indirizzo;

			//	Se non è presente, viene creato
			indirizzo = factoryRisorse.GetIndirizzo();
			AssegnaCampi(indirizzo, qualificatore, nome, civico, cap, localita, provincia);

			//	L'indirizzo viene reso persistente
			indirizzo.id = repository.crea(indirizzo);

			if (indirizzo.id < 0)
				return null;

			return indirizzo;
        }

        public void EliminaIndirizzo(IIndirizzo indirizzo)
        {
			repository.elimina(indirizzo.id);
        }

        public IIndirizzo ModificaIndirizzo(IIndirizzo indirizzo, string qualificatore, string nome, string civico, string cap, string localita, string provincia)
        {

			AssegnaCampi(indirizzo, qualificatore, nome, civico, cap, localita, provincia);

			//	Le modifiche vengono rese persistenti
			repository.aggiorna(indirizzo);

			return indirizzo;
		}
    }
}
