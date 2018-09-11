using AutotrasportiFantini.modello.interfacce;
using System;

namespace AutotrasportiFantini.controller.log
{
	class FormatoLogTimestamp : FormatoLogStandard
	{
		public override string GetMessaggioFormattato(string messaggio)
		{
			return DateTime.Now+":"+base.GetMessaggioFormattato(messaggio);
		}

		public string GetMessaggioFormattato(IUtente autore, string messaggio)
		{
			return DateTime.Now + ": " + autore.idAziendale + messaggio;
		}
	}
}
