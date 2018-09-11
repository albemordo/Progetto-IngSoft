using System;
using System.Collections.Generic;

namespace AutotrasportiFantini.modello.interfacce
{
    public interface ISpedizione
    {
        int id { get; set; }
        float distanzaStimata { get; set; }
        float distanzaEffettiva { get; set; }
        ITipologiaMerce tipologiaMerce { get; set; }
        float quantitaMerce { get; set; }
        int tempoPercorrenza { get; set; }
        IAutomezzo automezzo { get; set; }
        IDelegato delegato { get; set; }
        IAutista autista { get; set; }
        IIndirizzo partenza { get; set; }
        IIndirizzo destinazione { get; set; }
        List<IPuntoSpedizione> puntiSpedizione { get; set; }
        DateTime orarioPrevistoPartenza { get; set; }
        DateTime orarioPrevistoArrivo { get; set; }
        DateTime orarioEffettivoPartenza { get; set; }
        DateTime orarioEffettivoArrivo { get; set; }
    }
}
