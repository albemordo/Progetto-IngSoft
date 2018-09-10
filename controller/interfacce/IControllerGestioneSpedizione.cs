using System;
using System.Collections.Generic;
using AutotrasportiFantini.modello.interfacce;

namespace AutotrasportiFantini.controller.interfacce
{
    interface IControllerGestioneSpedizione
    {
        ISpedizione CreaSpedizione(IIndirizzo partenza, IIndirizzo arrivo, List<IPuntoSpedizione> puntiSpedizione, float distanzaStimata, ITipologiaMerce tipologiaMerce, float quantitaMerce);
        ISpedizione ModificaDati(ISpedizione spedizione, IIndirizzo partenza, IIndirizzo arrivo, List<IPuntoSpedizione> puntiSpedizione, float distanzaStimata, ITipologiaMerce tipologiaMerce,
            float quantitaMerce, IAutista autista, IAutomezzo automezzo, IDelegato delegato, DateTime partenzaPrevista, DateTime arrivoPrevisto, DateTime partenzaEffettiva,
            DateTime arrivoEffettivo);
        void AssegnaDelegato(ISpedizione spedizione, IDelegato delegato);
        void EliminaSpedizione(ISpedizione spedizione);
    }
}
