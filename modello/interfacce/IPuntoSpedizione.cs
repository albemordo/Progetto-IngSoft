using System;

namespace AutotrasportiFantini.modello.interfacce
{
    public interface IPuntoSpedizione
    {
        int id { get; set; }
        IIndirizzo indirizzo { get; set; }
        int spedizione { get; set; }
        DateTime orarioArrivo { get; set; }
    }
}
