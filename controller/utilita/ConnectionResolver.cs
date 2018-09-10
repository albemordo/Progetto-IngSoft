using AutotrasportiFantini.persistenza;
using System;

namespace AutotrasportiFantini.controller.utilita
{
	class ConnectionResolver
	{
		public enum repository { INDIRIZZO, SPEDIZIONE, AUTOMEZZO, PUNTO_SPEDIZIONE, TIPOLOGIA_MERCE};
		
		public const string dbname = "TestDb";

		public static RepositoryBase<Object, int> GetRepository(int qualeRepository)
		{
			RepositoryBase<Object, int> result = null;
			DbConnectionFactory factory = new DbConnectionFactory();
			IDbConnection connection = factory.GetConnection(DbConnectionFactory.SupportedDBMS.postgresql, dbname);

			switch (qualeRepository)
			{
				case (int)repository.INDIRIZZO:
					result = new RepositoryIndirizzo(connection);
					break;

				case (int)repository.SPEDIZIONE:
					result = new RepositorySpedizione(connection);
					break;

				case (int)repository.PUNTO_SPEDIZIONE:
					result = new RepositoryPuntoSpedizione(connection);
					break;

				case (int)repository.TIPOLOGIA_MERCE:
					result = new RepositoryTipologiaMerce(connection);
					break;

				case (int)repository.AUTOMEZZO:
					result = new RepositoryAutomezzo(connection);
					break;
			}

			return result;
		}
	}
}
