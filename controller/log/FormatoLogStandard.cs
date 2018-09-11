using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.controller.log.interfacce;

namespace AutotrasportiFantini.controller.log
{
	public class FormatoLogStandard : IFormatoLog
	{
		protected static IFormatoLog istanza;

		protected FormatoLogStandard() { }

		/**
		 *	Singleton
		 */
		public static IFormatoLog GetIstanza()
		{
			if (istanza is null)
				istanza = new FormatoLogStandard();

			return istanza;
		}

		public virtual string GetMessaggioFormattato(string messaggio)
		{
			return messaggio;
		}
	}
}
