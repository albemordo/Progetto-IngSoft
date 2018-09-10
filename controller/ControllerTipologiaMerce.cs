﻿using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello.factory;
using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.persistenza.repository;
using AutotrasportiFantini.persistenza.repository.factory;
using System;
using System.Collections.Generic;

namespace AutotrasportiFantini.controller
{
    class ControllerTipologiaMerce : IControllerTipologieMerce
    {
		private IFactoryRisorse factoryRisorse = new FactoryRisorse();
		private RepositoryTipologiaMerce repository;

		public ControllerTipologiaMerce()
		{
			//	Init repository
		}

		public ITipologiaMerce CreaTipologiaMerce(string tipologia)
        {
			ITipologiaMerce tipologiaMerce = factoryRisorse.GetTipologiaMerce();
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
