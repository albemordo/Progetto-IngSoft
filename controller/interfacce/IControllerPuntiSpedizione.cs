using System;
using AutotrasportiFantini.modello.interfacce;

namespace AutotrasportiFantini.controller.interfacce
{
    interface IControllerPuntiSpedizione
    {
        IPuntoSpedizione CreaPuntoSpedizione(IIndirizzo indirizzo);
        IPuntoSpedizione RegistraArrivo(IPuntoSpedizione puntoSpedizione, DateTime orario);
        IPuntoSpedizione AggiornaIndirizzo(IPuntoSpedizione puntoSpedizione, IIndirizzo indirizzo);
        void EliminaPuntoSpedizione(IPuntoSpedizione puntoSpedizione);
    }
}
