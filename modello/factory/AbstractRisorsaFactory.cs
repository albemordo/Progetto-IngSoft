using AutotrasportiFantini.modello.interfacce;
using System;
using System.Collections.Generic;

namespace AutotrasportiFantini.modello.factory
{
    abstract class AbstractRisorsaFactory
    {
        public abstract ISpedizione CreaSpedizione(int id, 
            float distanzaStimata,
            float distanzaEffettiva,
            ITipologiaMerce tipologiaMerce,
            float quantitaMerce,
            int tempoPercorrenza,
            IAutomezzo automezzo,
            IDelegato delegato,
            IAutista autista,
            IIndirizzo partenza,
            IIndirizzo destinazione,
            List<IPuntoSpedizione> puntiSpedizione,
            DateTime orarioPrevistoPartenza,
            DateTime orarioPrevistoArrivo,
            DateTime orarioEffettivoPartenza,
            DateTime orarioEffettivoArrivo
        );

        public abstract ITipologiaMerce TipologiaMerce(int id, string tipologia);

        public abstract IAutomezzo CreaAutomezzo(int id, string targa, string prod, string modello, string tr, string cod);
    }
}
