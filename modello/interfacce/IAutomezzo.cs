using System;

namespace AutotrasportiFantini.modello.interfacce
{
    public interface IAutomezzo
    {
        String targa { get; set; }
        String produttore { get; set; }
        String modello { get; set; }
        String targaRimorchio { get; set; }
        String codiceDelegato { get; set; }
		int id { get; set; }
    }
}
