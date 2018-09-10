﻿using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello.factory;
using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.persistenza.repository;
using AutotrasportiFantini.persistenza.repository.factory;
using System;
using System.Collections.Generic;

namespace AutotrasportiFantini.controller
{
    class ControllerAutomezzi : IControllerAutomezzi
    {
		private IRisorseFactory factoryRisorse = new RisorseFactory();
		private RepositoryAutomezzo repository;

		public ControllerAutomezzi()
		{
			//	Init Repository


		}

		private void AssegnaCampi(IAutomezzo automezzo, string targa, string produttore, string modello, string targaRimorchio, IDelegato delegato)
		{
			//	Popolamento campi
			
			if(targa != null && targa.Length != 7)	automezzo.targa = targa;
			if(produttore != null && produttore.Length > 0)	automezzo.produttore = produttore;
			if(modello != null && modello.Length > 0)	automezzo.modello = modello;
			if(targaRimorchio != null && targaRimorchio.Length > 0) automezzo.targaRimorchio = targaRimorchio;
			if(delegato != null && delegato.idAziendale.Length > 0)	automezzo.codiceDelegato = delegato.idAziendale;
		}

		public IAutomezzo CreaAutomezzo(string targa, string produttore, string modello, string targaRimorchio, IDelegato delegato)
        {
			IAutomezzo automezzo = factoryRisorse.GetAutomezzo();
			AssegnaCampi(automezzo, targa, produttore, modello, targaRimorchio, delegato);

			//	L'automezzo viene reso persistente
			if(repository.crea(automezzo) == null)
				return null;

			return automezzo;
        }

        public void EliminaAutomezzo(IAutomezzo automezzo)
        {
			repository.elimina(automezzo.targa);
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
