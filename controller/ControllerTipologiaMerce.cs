using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello.factory;
using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.persistenza;
using AutotrasportiFantini.persistenza.repository.factory;
using System.Collections.Generic;

namespace AutotrasportiFantini.controller
{
    class ControllerTipologiaMerce : IControllerTipologieMerce
    {
		private IPersistenzaTipologiaMerce repository;
		private IRisorseFactory factory = new RisorseFactory();

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

			return tipologiaMerce;
		}

        public void EliminaTipologiaMerce(ITipologiaMerce tipologia)
        {
			repository.elimina(tipologia.id);
        }

        public List<ITipologiaMerce> ListaTipologieMerce()
        {
            return repository.elencaTutti();
        }

        public ITipologiaMerce ModificaTipologiaMerce(ITipologiaMerce tipologia, string nomeTipologia)
        {
            tipologia.tipologia = nomeTipologia;

			//	Le modifiche vengono rese persistenti
			repository.aggiorna(tipologia);

			return tipologia;
        }
    }
}
