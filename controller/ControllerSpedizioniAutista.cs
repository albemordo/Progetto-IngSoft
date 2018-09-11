using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.controller.log;
using AutotrasportiFantini.controller.log.interfacce;
using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.persistenza;
using AutotrasportiFantini.persistenza.repository.factory;
using System;

namespace AutotrasportiFantini.controller
{
    class ControllerSpedizioniAutista : IControllerSpedizioniAutista
    {
		IPersistenzaSpedizione repositorySpedizione;
		IPersistenzaPuntoSpedizione repositoryPuntoSpedizione;

		//	Logger
		IControllerLog logger = ControllerLog.GetIstanza();

		public ControllerSpedizioniAutista()
		{
			//	Init repository
			repositorySpedizione = new RepositoryFactory(DbConnectionFactory.SupportedDBMS.postgresql, "TestDb").GetPersistenzaSpedizione();
			repositoryPuntoSpedizione = new RepositoryFactory(DbConnectionFactory.SupportedDBMS.postgresql, "TestDb").GetPersistenzaPuntoSpedizione();
		}

		public void RegistraFineSpedizione(ISpedizione spedizione, DateTime arrivo, float distanzaEffettiva, int tempoEffettivo)
        {
			//	Vengono inseriti i dati di fine spedizione
			spedizione.orarioEffettivoArrivo = arrivo;
			spedizione.distanzaEffettiva = distanzaEffettiva;
			spedizione.tempoPercorrenza = tempoEffettivo;

			//	Le modifiche vengono rese persistenti
			repositorySpedizione.aggiorna(spedizione);

			//	Log operazione
			logger.CreaLog(ControllerAutenticazione.GetIstanza().GetUtenteAutenticato().idAziendale + " ha registrato i dati per concludere la spedizione "+spedizione.id+": orario di arrivo "+arrivo+", distanza effettiva "+distanzaEffettiva+", tempo effettivo "+tempoEffettivo);
		}

        public void RegistraPartenza(ISpedizione spedizione, DateTime partenza)
        {
			//	Viene inserito l'orario effettivo di partenza
			spedizione.orarioEffettivoPartenza = partenza;

			//	La modifica viene resa persistente
			repositorySpedizione.aggiorna(spedizione);

			//	Log operazione
			logger.CreaLog(ControllerAutenticazione.GetIstanza().GetUtenteAutenticato().idAziendale + " ha registrato l'orario di partenza "+partenza+", per la spedizione "+spedizione);
		}

        public void RegistraPuntoSpedizione(ISpedizione spedizione, IPuntoSpedizione punto, DateTime orario)
        {
			punto.orarioArrivo = orario;

			//	L'arrivo ad un punto di spedizione viene reso persistente
			repositoryPuntoSpedizione.aggiorna(punto);

			//	Log operazione
			logger.CreaLog(ControllerAutenticazione.GetIstanza().GetUtenteAutenticato().idAziendale + " ha registrato l'orario di arrivo "+orario+" al punto di spedizione "+punto.indirizzo+" per la spededizione "+spedizione.id);
		}
    }
}
