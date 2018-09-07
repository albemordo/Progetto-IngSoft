using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutotrasportiFantini.modello.interfacce;

namespace AutotrasportiFantini.modello.factory
{
    class RisorsaFactory : AbstractRisorsaFactory
    {
        public override IAutomezzo CreaAutomezzo(int id, string targa, string prod, string modello, string tr, string cod)
        {
            throw new NotImplementedException();
        }

        public override ISpedizione CreaSpedizione(int id, float distanzaStimata, float distanzaEffettiva, ITipologiaMerce tipologiaMerce, float quantitaMerce, int tempoPercorrenza, IAutomezzo automezzo, IDelegato delegato, IAutista autista, IIndirizzo partenza, IIndirizzo destinazione, List<IPuntoSpedizione> puntiSpedizione, DateTime orarioPrevistoPartenza, DateTime orarioPrevistoArrivo, DateTime orarioEffettivoPartenza, DateTime orarioEffettivoArrivo)
        {
            throw new NotImplementedException();
        }

        public override ITipologiaMerce TipologiaMerce(int id, string tipologia)
        {
            throw new NotImplementedException();
        }
    }
}
