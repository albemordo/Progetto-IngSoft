using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello.factory;
using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.persistenza;
using AutotrasportiFantini.persistenza.repository.factory;
using System;

namespace AutotrasportiFantini.controller
{
    class ControllerIndirizzi : IControllerIndirizzi
    {
		IPersistenzaIndirizzo repository;
		IRisorseFactory factory = new RisorseFactory();

		private void AssegnaCampi(IIndirizzo indirizzo, string qualificatore, string nome, string civico, string cap, string localita, string provincia)
		{
			//	Popolamento dei campi
			if(qualificatore != null && qualificatore.Length > 0) indirizzo.qualificatore = qualificatore;
			if(nome != null && nome.Length > 0) indirizzo.nome = nome;
			if(civico != null && civico.Length > 0)	indirizzo.civico = civico;
			if(cap != null && cap.Length > 0) indirizzo.cap = cap;
			if(localita != null && localita.Length > 0) indirizzo.localita = localita;
			if(provincia != null && provincia.Length > 0) indirizzo.provincia = provincia;
			
		}
		
		public ControllerIndirizzi()
		{
			//	Init repository
			repository = new RepositoryFactory(DbConnectionFactory.SupportedDBMS.postgresql, "TestDb").GetPersistenzaIndirizzo();
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
			indirizzo = factory.GetIndirizzo();
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
