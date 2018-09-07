using System;

namespace AutotrasportiFantini.modello.interfacce
{
    interface IPuntoSpedizione
    {
        int id { get; set; }
        IIndirizzo indirizzo { get; set; }
        ISpedizione spedizione { get; set; }
        DateTime orarioArrivo { get; set; }
    }
}
