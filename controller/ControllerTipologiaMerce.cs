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
    class ControllerTipologiaMerce : IControllerTipologiaMerce
    {
		//	Logger
		IControllerLog logger = ControllerLog.GetIstanza();

		IPersistenzaTipologiaMerce repository;
		IRisorseFactory factory = new RisorseFactory();

		public ControllerTipologiaMerce()
		{
			//	Init repository
			repository = new RepositoryFactory(DbConnectionFactory.SupportedDBMS.postgresql, "TestDb").GetPersistenzaTipologiaMerce();
		}

		public ITipologiaMerce CreaTipologiaMerce(string tipologia)
        {
			ITipologiaMerce tipologiaMerce = factory.GetTipologiaMerce();
			tipologiaMerce.tipologia = tipologia;

			//	La tipologia viene resa persistente
			tipologiaMerce.id = repository.crea(tipologiaMerce);

			if (tipologiaMerce.id < 0)
				return null;

			//	Log operazione
			logger.CreaLog(ControllerAutenticazione.GetIstanza().GetUtenteAutenticato().idAziendale+" ha aggiunto la tipologia merce "+tipologiaMerce.tipologia);

			return tipologiaMerce;
		}

        public void EliminaTipologiaMerce(ITipologiaMerce tipologia)
        {
			repository.elimina(tipologia.id);

			//	Log operazione
			logger.CreaLog(ControllerAutenticazione.GetIstanza().GetUtenteAutenticato().idAziendale + " ha rimosso la tipologia merce "+tipologia.tipologia);
		}

        public List<ITipologiaMerce> ListaTipologieMerce()
        {
			//	Log operazione
			logger.CreaLog(ControllerAutenticazione.GetIstanza().GetUtenteAutenticato().idAziendale + " ha richiesto la lista delle tipologie della merce");

			return repository.elencaTutti();
        }

        public ITipologiaMerce ModificaTipologiaMerce(ITipologiaMerce tipologia, string nomeTipologia)
        {
			//	Log operazione
			logger.CreaLog(ControllerAutenticazione.GetIstanza().GetUtenteAutenticato().idAziendale + " ha modificato la tipologia "+tipologia.tipologia);

			tipologia.tipologia = nomeTipologia;

			//	Le modifiche vengono rese persistenti
			repository.aggiorna(tipologia);

			return tipologia;
        }
    }
}
