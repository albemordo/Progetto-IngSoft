using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.controller.log;
using AutotrasportiFantini.controller.log.interfacce;
using AutotrasportiFantini.modello.factory;
using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.persistenza;
using AutotrasportiFantini.persistenza.repository.factory;
using System;

namespace AutotrasportiFantini.controller
{
    class ControllerPuntiSpedizione : IControllerPuntiSpedizione
	{
		IPersistenzaPuntoSpedizione repository;
		IRisorseFactory factory = new RisorseFactory();

		//	Logger
		IControllerLog logger = ControllerLog.GetIstanza();

		public ControllerPuntiSpedizione()
		{
			//	Init repository
			repository = new RepositoryFactory(DbConnectionFactory.SupportedDBMS.postgresql, "TestDb").GetPersistenzaPuntoSpedizione();
		}

        public IPuntoSpedizione AggiornaIndirizzo(IPuntoSpedizione puntoSpedizione, IIndirizzo indirizzo)
        {
			puntoSpedizione.indirizzo = indirizzo;
			repository.aggiorna(puntoSpedizione);

			//	Log operazione
			logger.CreaLog(ControllerAutenticazione.GetIstanza().GetUtenteAutenticato().idAziendale + " ha aggiornato il punto di sped. "+puntoSpedizione.id+", assegnandogli l'indirizzo "+indirizzo);

			return puntoSpedizione;
        }

        public IPuntoSpedizione CreaPuntoSpedizione(IIndirizzo indirizzo)
        {
			IPuntoSpedizione punto = factory.GetPuntoSpedizione();
			punto.indirizzo = indirizzo;

			//	Il punto di spedizione viene reso persistente
			punto.id = repository.crea(punto);

			//	Log operazione
			logger.CreaLog(ControllerAutenticazione.GetIstanza().GetUtenteAutenticato().idAziendale + " ha creato il punto di spedizione "+punto.id+", avente come indirizzo "+indirizzo);

			return punto;
        }

        public void EliminaPuntoSpedizione(IPuntoSpedizione puntoSpedizione)
        {
			repository.elimina(puntoSpedizione.id);

			//	Log operazione
			logger.CreaLog(ControllerAutenticazione.GetIstanza().GetUtenteAutenticato().idAziendale + " ha eliminato il punto di spedizione "+puntoSpedizione.indirizzo+" della spedizione "+puntoSpedizione.spedizione);
		}

        public IPuntoSpedizione RegistraArrivo(IPuntoSpedizione puntoSpedizione, DateTime orario)
        {
			puntoSpedizione.orarioArrivo = orario;
			repository.aggiorna(puntoSpedizione);

			//	Log operazione
			logger.CreaLog(ControllerAutenticazione.GetIstanza().GetUtenteAutenticato().idAziendale + " ha confermato l'arrivo al punto di spedizione "+puntoSpedizione.indirizzo+" della spedizione "+puntoSpedizione.spedizione);

			return puntoSpedizione;
        }
    }
}
