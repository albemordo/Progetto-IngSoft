using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello.interfacce;
using System;
using System.Collections.Generic;

namespace AutotrasportiFantini.controller
{
    class ControllerGestioneSpedizione : IControllerGestioneSpedizione
    {
        public void AssegnaDelegato(ISpedizione spedizione, IDelegato delegato)
        {
            throw new NotImplementedException();
        }

        public ISpedizione CreaSpedizione(IIndirizzo partenzaz, IIndirizzo arrivo, List<IPuntoSpedizione> puntiSpedizione, float distanzaStimata, ITipologiaMerce tipologiaMerce, float quantitaMerce)
        {
            throw new NotImplementedException();
        }

        public void EliminaSpedizione(ISpedizione spedizione)
        {
            throw new NotImplementedException();
        }

        public ISpedizione ModificaDati(ISpedizione spedizione, IIndirizzo partenza, IIndirizzo arrivo, List<IPuntoSpedizione> puntiSpedizione, float distanzaStimata, ITipologiaMerce tipologiaMerce, float quantitaMerce, IAutista autista, IAutomezzo automezzo, IDelegato delegato, DateTime partenzaPrevista, DateTime arrivoPrevisto, DateTime partenzaEffettiva, DateTime arrivoEffettivo)
        {
            throw new NotImplementedException();
        }
    }
}
