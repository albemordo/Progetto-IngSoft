using System;
using System.Collections.Generic;
using AutotrasportiFantini.modello.interfacce;

namespace AutotrasportiFantini.controller.interfacce
{
    interface IControllerAutomezzi
    {
        List<IAutomezzo> ListaAutomezzi(IDelegato delegato);
        IAutomezzo CreaAutomezzo(String targa, String produttore, String modello, String targaRimorchio, IDelegato delegato);
        IAutomezzo ModificaAutomezzo(IAutomezzo automezzo, String targa, String produttore, String modello, String targaRimorchio, IDelegato delegato);
        void EliminaAutomezzo(IAutomezzo automezzo);
    }
}
