using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.controller.log;
using AutotrasportiFantini.controller.log.interfacce;
using AutotrasportiFantini.modello.factory;
using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.persistenza;
using AutotrasportiFantini.persistenza.repository.factory;
using System.Collections.Generic;

namespace AutotrasportiFantini.controller
{
    class ControllerAutomezzi : IControllerAutomezzi
    {
		IPersistenzaAutomezzo repository;
		IRisorseFactory factory = new RisorseFactory();
		IControllerLog logger = ControllerLog.GetIstanza();

		public ControllerAutomezzi()
		{
			//	Init Repository
			repository = new RepositoryFactory(DbConnectionFactory.SupportedDBMS.postgresql, "TestDb").GetPersistenzaAutomezzo();
		}

		private void AssegnaCampi(IAutomezzo automezzo, string targa, string produttore, string modello, string targaRimorchio, IDelegato delegato)
		{
			//	Popolamento campi
			
			if(targa != null && targa.Length == 7)	automezzo.targa = targa;
			if(produttore != null && produttore.Length > 0)	automezzo.produttore = produttore;
			if(modello != null && modello.Length > 0)	automezzo.modello = modello;
			if(targaRimorchio != null && targaRimorchio.Length > 0) automezzo.targaRimorchio = targaRimorchio;
			if(delegato != null && delegato.idAziendale.Length > 0)	automezzo.codiceDelegato = delegato.idAziendale;
		}

		public IAutomezzo CreaAutomezzo(string targa, string produttore, string modello, string targaRimorchio, IDelegato delegato)
        {
			IAutomezzo automezzo = factory.GetAutomezzo();
			AssegnaCampi(automezzo, targa, produttore, modello, targaRimorchio, delegato);

			//	L'automezzo viene reso persistente
			automezzo = repository.crea(automezzo);
			if(automezzo == null)
				return null;

			//	Log operazione
			logger.CreaLog(ControllerAutenticazione.GetIstanza().UtenteAutenticato.idAziendale + " ha aggiunto l'automezzo "+automezzo.targa);

			return automezzo;
        }

        public void EliminaAutomezzo(IAutomezzo automezzo)
        {
			repository.elimina(automezzo.targa);

			//	Log operazione
			logger.CreaLog(ControllerAutenticazione.GetIstanza().UtenteAutenticato.idAziendale + " ha eliminato l'automezzo " + automezzo.targa);
		}

		public List<IAutomezzo> ListaAutomezzi(IDelegato delegato)
        {
			if (delegato.idAziendale == null)
				return null;

			//	Log operazione
			logger.CreaLog(ControllerAutenticazione.GetIstanza().UtenteAutenticato.idAziendale + " ha cercato la lista degli automezzi di " + delegato.idAziendale);

			//	Manca il delegato
			return repository.elencaPerDelegato(delegato.idAziendale);
		}

        public IAutomezzo ModificaAutomezzo(IAutomezzo automezzo, string targa, string produttore, string modello, string targaRimorchio, IDelegato delegato)
		{
			string cambiamenti = "{ ";

			if (targa != null && !automezzo.targa.Equals(targa))
				cambiamenti += "[targa: da "+automezzo.targa+" a "+targa+"] ";

			if (produttore != null && !automezzo.produttore.Equals(produttore))
				cambiamenti += "[produttore: da "+automezzo.produttore+" a "+produttore+"] ";

			if (modello != null && !automezzo.modello.Equals(modello))
				cambiamenti += "[modello: da "+automezzo.modello+" a "+modello+"] ";

			if (targaRimorchio != null && !automezzo.targaRimorchio.Equals(targaRimorchio))
				cambiamenti += "[targa_rimorchio: da "+automezzo.targaRimorchio+" a"+targaRimorchio+"] ";

			cambiamenti += "}";

			logger.CreaLog(ControllerAutenticazione.GetIstanza().UtenteAutenticato.idAziendale + " ha modificato "+cambiamenti+" dell'automezzo " + automezzo.targa);

			AssegnaCampi(automezzo, targa, produttore, modello, targaRimorchio, delegato);

			//	Le modifiche vengono rese persistenti
			repository.aggiorna(automezzo);

			return automezzo;
        }

    }
}
