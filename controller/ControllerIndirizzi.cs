using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello.factory;
using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.persistenza;
using AutotrasportiFantini.persistenza.factory;
using System;

namespace AutotrasportiFantini.controller
{
    class ControllerIndirizzi : IControllerIndirizzi
    {
		private SqlConnectionFactory factoryConnessioni = new SqlConnectionFactory();
		private IFactoryRisorse factoryRisorse = new FactoryRisorse();
		private RepositoryIndirizzo repository;

		private IIndirizzo ModificaCampi(IIndirizzo indirizzo, string qualificatore, string nome, string civico, string cap, string localita, string provincia)
		{
			//	Popolamento dei campi
			indirizzo.qualificatore = qualificatore;
			indirizzo.nome = nome;
			indirizzo.civico = civico;
			indirizzo.cap = cap;
			indirizzo.localita = localita;
			indirizzo.provincia = provincia;

			return indirizzo;
		}

		public ControllerIndirizzi()
		{
			repository = new RepositoryIndirizzo(factoryConnessioni.GetSqlConnection("dummy"));
		}

		public IIndirizzo CreaIndirizzo(string qualificatore, string nome, string civico, string cap, string localita, string provincia)
		{
			IIndirizzo indirizzo = ModificaCampi(factoryRisorse.GetIndirizzo(), qualificatore, nome, civico, cap, localita, provincia);

			//	L'indirizzo viene reso persistente
			repository.crea(indirizzo);

			//	Lettura dell'indirizzo, per ottenerne l'id
			indirizzo = repository.cercaIndirizzo(qualificatore, nome, civico, cap, localita, provincia);

			return indirizzo;
        }

        public void EliminaIndirizzo(IIndirizzo indirizzo)
        {
			repository.elimina(indirizzo.id);
        }

        public IIndirizzo ModificaIndirizzo(IIndirizzo indirizzo, string qualificatore, string nome, string civico, string cap, string localita, string provincia)
        {
			IIndirizzo ind = ModificaCampi(indirizzo, qualificatore, nome, civico, cap, localita, provincia);

			//	Le modifiche vengono rese persistenti
			repository.aggiorna(ind);

			return ind;
		}
    }
}
