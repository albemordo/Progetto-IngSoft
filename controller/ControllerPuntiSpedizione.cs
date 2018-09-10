using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello.factory;
using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.persistenza;
using AutotrasportiFantini.persistenza.repository.factory;
using System;

namespace AutotrasportiFantini.controller
{
    class ControllerPuntiSpedizione : IControllerPuntiSpedizione
	{
		private IPersistenzaPuntoSpedizione repository;
		private IRisorseFactory factory = new RisorseFactory();

		public ControllerPuntiSpedizione()
		{
			//	Init repository
			repository = new RepositoryFactory(DbConnectionFactory.SupportedDBMS.postgresql, "TestDb").GetPersistenzaPuntoSpedizione();
		}

        public IPuntoSpedizione AggiornaIndirizzo(IPuntoSpedizione puntoSpedizione, IIndirizzo indirizzo)
        {
			puntoSpedizione.indirizzo = indirizzo;
			repository.aggiorna(puntoSpedizione);

			return puntoSpedizione;
        }

        public IPuntoSpedizione CreaPuntoSpedizione(IIndirizzo indirizzo)
        {
			IPuntoSpedizione punto = factory.GetPuntoSpedizione();
			punto.indirizzo = indirizzo;

			//	Il punto di spedizione viene reso persistente
			punto.id = repository.crea(punto);

			return punto;
        }

        public void EliminaPuntoSpedizione(IPuntoSpedizione puntoSpedizione)
        {
			repository.elimina(puntoSpedizione.id);
        }

        public IPuntoSpedizione RegistraArrivo(IPuntoSpedizione puntoSpedizione, DateTime orario)
        {
			puntoSpedizione.orarioArrivo = orario;
			repository.aggiorna(puntoSpedizione);

			return puntoSpedizione;
        }
    }
}
