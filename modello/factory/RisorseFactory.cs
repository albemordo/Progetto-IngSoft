using AutotrasportiFantini.modello.interfacce;
using System;
using System.Collections.Generic;

namespace AutotrasportiFantini.modello.factory
{
	class RisorseFactory : IRisorseFactory
	{
		public IAutomezzo GetAutomezzo()
		{
			IAutomezzo automezzo = new Automezzo();

			automezzo.id = 0;
			automezzo.targa = "";
			automezzo.modello = "";
			automezzo.produttore = "";
			automezzo.targaRimorchio = "";
			automezzo.codiceDelegato = "";

			return automezzo;
		}

		public IIndirizzo GetIndirizzo()
		{
			IIndirizzo indirizzo = new Indirizzo();

			indirizzo.id = 0;
			indirizzo.cap = "";
			indirizzo.civico = "";
			indirizzo.localita = "";
			indirizzo.provincia = "";
			indirizzo.qualificatore = "";

			return indirizzo;
		}

		public IPuntoSpedizione GetPuntoSpedizione()
		{
			IPuntoSpedizione pspedizione = new PuntoSpedizione();

			pspedizione.id = 0;
			pspedizione.indirizzo = this.GetIndirizzo();
			pspedizione.orarioArrivo = new DateTime();
			pspedizione.spedizione = 0;

			return pspedizione;
		}

		public ISpedizione GetSpedizione()
		{
			ISpedizione spedizione = new Spedizione();

			spedizione.id = 0;
			spedizione.distanzaEffettiva = 0;
			spedizione.distanzaStimata = 0;
			spedizione.tempoPercorrenza = 0;
			spedizione.quantitaMerce = 0;
			spedizione.orarioEffettivoArrivo = new DateTime();
			spedizione.orarioEffettivoPartenza = new DateTime();
			spedizione.orarioPrevistoArrivo = new DateTime();
			spedizione.orarioPrevistoPartenza = new DateTime();
			spedizione.partenza = this.GetIndirizzo();
			spedizione.destinazione = this.GetIndirizzo();
			spedizione.autista = FactoryUtenti.GetUtente(FactoryUtenti.Utenti.AUTISTA) as IAutista;
			spedizione.delegato = FactoryUtenti.GetUtente(FactoryUtenti.Utenti.DELEGATO) as IDelegato;
			spedizione.automezzo = this.GetAutomezzo();
			spedizione.tipologiaMerce = this.GetTipologiaMerce();
			spedizione.puntiSpedizione = new List<IPuntoSpedizione>();

			return spedizione;
		}

		public ITipologiaMerce GetTipologiaMerce()
		{
			ITipologiaMerce tipologia = new TipologiaMerce();

			tipologia.id = 0;
			tipologia.tipologia = "";

			return tipologia;
		}
	}
}
